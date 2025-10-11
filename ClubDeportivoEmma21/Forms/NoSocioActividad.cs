using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivoEmma21.Data;

namespace ClubDeportivoEmma21.Forms
{
    public partial class NoSocioActividad : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();
        private int idNoSocio = 0;

        public NoSocioActividad()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Constructor que recibe idNoSocio y dni (cuando se abre desde Gestión No Socios / Consultas)
        /// </summary>
        public NoSocioActividad(int idNoSocioParam, string dni)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Inscripción de Actividades - No Socio";

            // Guarda los datos recibidos
            this.idNoSocio = idNoSocioParam;
            txtDniNoSocio.Text = dni;

            // Bloquear búsqueda (ya tenemos el DNI y el id)
            txtDniNoSocio.Enabled = false;
            btnBuscarDniActividad.Enabled = false;

            // Mostrar un mensaje elegante de contexto
            MessageBox.Show(
                $"Se cargó correctamente el No Socio con DNI: {dni}.\nAhora puede inscribirlo en una actividad.",
                "No Socio encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void NoSocioActividad_Load(object sender, EventArgs e)
        {
            CargarActividades();

            clbActividadFormaDePago.Items.Clear();
            clbActividadFormaDePago.Items.Add("Efectivo");
            clbActividadFormaDePago.Items.Add("Transferencia");
            clbActividadFormaDePago.Items.Add("Tarjeta");

            clbActividadFormaDePago.CheckOnClick = true;
        }

        private void CargarActividades()
        {
            using (var conn = _db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT id_actividad, nombre_actividad, precio FROM actividad";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboActividades.DataSource = dt;
                    comboActividades.DisplayMember = "nombre_actividad";
                    comboActividades.ValueMember = "id_actividad";
                    comboActividades.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar actividades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscarDniActividad_Click(object sender, EventArgs e)
        {
            string dni = txtDniNoSocio.Text.Trim();
            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor ingrese un DNI.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = _db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT p.id_persona 
                                   FROM persona p
                                   INNER JOIN no_socio n ON p.id_persona = n.id_no_socio
                                   WHERE p.dni = @dni";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        var result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("No se encontró ningún No Socio con ese DNI.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            idNoSocio = 0;
                        }
                        else
                        {
                            idNoSocio = Convert.ToInt32(result);
                            MessageBox.Show("No Socio encontrado correctamente ✅", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar No Socio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboActividades.SelectedItem is DataRowView row)
            {
                txtMontoNoSocio.Text = row["precio"].ToString();
            }
        }

        private void btnActividadPagar_Click(object sender, EventArgs e)
        {
            if (idNoSocio == 0)
            {
                MessageBox.Show("Debe buscar un No Socio antes de continuar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboActividades.SelectedIndex == -1 || comboActividades.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una actividad.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Comprobación segura de forma de pago
            if (clbActividadFormaDePago.CheckedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una forma de pago.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se toma el primer item marcado de forma segura
            var checkedItem = clbActividadFormaDePago.CheckedItems.Cast<object>().FirstOrDefault();
            if (checkedItem == null)
            {
                MessageBox.Show("Error interno: forma de pago no seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string formaPago = checkedItem.ToString()!; // Una vez validado, se puede usar con seguridad.

            int idActividad;
            try
            {
                idActividad = Convert.ToInt32(comboActividades.SelectedValue);
            }
            catch
            {
                MessageBox.Show("Error al obtener la actividad seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var conn = _db.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Insertar inscripción (tabla: inscripcion)
                    string sqlInscripcion = @"INSERT INTO inscripcion (id_persona, id_actividad, fecha_inscripcion)
                                      VALUES (@persona, @actividad, NOW())";
                    using (var cmd = new MySqlCommand(sqlInscripcion, conn))
                    {
                        cmd.Parameters.AddWithValue("@persona", idNoSocio);
                        cmd.Parameters.AddWithValue("@actividad", idActividad);
                        cmd.ExecuteNonQuery();
                    }

                    // Registrar pago diario (tabla: pago_diario)
                    string sqlPago = @"INSERT INTO pago_diario (id_no_socio, fecha_pago, monto, forma_de_pago)
                               VALUES (@noSocio, NOW(), @monto, @forma)";
                    using (var cmd = new MySqlCommand(sqlPago, conn))
                    {
                        decimal monto = 0;
                        decimal.TryParse(txtMontoNoSocio.Text, out monto);

                        cmd.Parameters.AddWithValue("@noSocio", idNoSocio);
                        cmd.Parameters.AddWithValue("@monto", monto);
                        cmd.Parameters.AddWithValue("@forma", formaPago);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Inscripción y pago registrados exitosamente 🎉", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar inscripción/pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnCancelarDniActividad_Click(object sender, EventArgs e)
        {
            GestionNoSocios volver = new GestionNoSocios();
            this.Hide();
            volver.ShowDialog();
            this.Close();
        }

        private void LimpiarFormulario()
        {
            txtDniNoSocio.Clear();
            txtMontoNoSocio.Clear();
            comboActividades.SelectedIndex = -1;
            clbActividadFormaDePago.ClearSelected();
            idNoSocio = 0;
        }
    }
}

