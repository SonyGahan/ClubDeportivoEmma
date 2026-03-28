using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivoEmma21.Data;

namespace ClubDeportivoEmma21.Forms
{
    public partial class NoSocioActividad : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();
        private int idNoSocioActual = 0;

        public NoSocioActividad()
        {
            InitializeComponent();
            AsignarEfectosHover();
        }

        private void NoSocioActividad_Load(object sender, EventArgs e)
        {
            CargarActividades();
        }

        private void AsignarEfectosHover()
        {
            this.btnBuscar.MouseEnter += (s, e) => this.btnBuscar.BackColor = Color.FromArgb(90, 113, 132);
            this.btnBuscar.MouseLeave += (s, e) => this.btnBuscar.BackColor = Color.FromArgb(58, 80, 107);

            this.btnRegistrar.MouseEnter += (s, e) => this.btnRegistrar.BackColor = Color.FromArgb(58, 80, 107);
            this.btnRegistrar.MouseLeave += (s, e) => this.btnRegistrar.BackColor = Color.FromArgb(90, 113, 132);

            this.btnCancelar.MouseEnter += (s, e) =>
            {
                this.btnCancelar.BackColor = Color.FromArgb(212, 175, 55);
                this.btnCancelar.ForeColor = Color.White;
            };
            this.btnCancelar.MouseLeave += (s, e) =>
            {
                this.btnCancelar.BackColor = Color.FromArgb(231, 215, 193);
                this.btnCancelar.ForeColor = Color.Black;
            };
        }

        private void CargarActividades()
        {
            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT id_actividad, nombre_actividad, costo_diario FROM actividad";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbActividad.Items.Add(new
                                {
                                    Text = reader["nombre_actividad"].ToString(),
                                    Value = reader["id_actividad"],
                                    Costo = reader["costo_diario"]
                                });
                            }
                        }
                    }
                }
                cmbActividad.DisplayMember = "Text";
                cmbActividad.ValueMember = "Value";
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar actividades: " + ex.Message); }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text.Trim();
            if (string.IsNullOrEmpty(dni)) return;

            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT n.id_no_socio, p.nombre, p.apellido 
                                 FROM no_socio n 
                                 JOIN persona p ON p.id_persona = n.id_no_socio 
                                 WHERE p.dni = @dni";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idNoSocioActual = reader.GetInt32("id_no_socio");
                                lblNombreDato.Text = reader["nombre"].ToString() + " " + reader["apellido"].ToString();
                                btnRegistrar.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("DNI no registrado como No Socio.", "Aviso");
                                lblNombreDato.Text = "-";
                                idNoSocioActual = 0;
                                btnRegistrar.Enabled = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void cmbActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbActividad.SelectedItem != null)
            {
                dynamic act = cmbActividad.SelectedItem;
                lblMontoDato.Text = "$ " + Convert.ToDecimal(act.Costo).ToString("N2");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (idNoSocioActual == 0) return;

            // 1. Instanciamos nuestro validador
            var validador = new ClubDeportivoEmma21.Utils.ValidadorNegocio();
            string mensajeError;

            // 2. Validamos el Apto Médico antes de cobrar
            if (!validador.ValidarAptoMedico(idNoSocioActual, out mensajeError))
            {
                MessageBox.Show("⛔ BLOQUEADO: " + mensajeError, "Validación de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return; // Cortamos la ejecución, NO se registra el pago
            }

            try
            {
                // Obtenemos la actividad seleccionada del ComboBox
                dynamic act = cmbActividad.SelectedItem;

                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    // Ahora incluimos id_actividad en el INSERT
                    string sql = @"INSERT INTO pago_diario (id_no_socio, id_actividad, fecha_pago, monto, forma_de_pago) 
                         VALUES (@idNoSocio, @idAct, CURDATE(), @monto, @forma)";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@idNoSocio", idNoSocioActual);
                        cmd.Parameters.AddWithValue("@idAct", act.Value); // El ID de la actividad
                        cmd.Parameters.AddWithValue("@monto", act.Costo); // Usa 'monto' como en la BD.
                        cmd.Parameters.AddWithValue("@forma", "Efectivo"); // Se le podría sumar un selector de pago luego, ver.

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show(" ✅ ¡Pago y actividad registrados con éxito!", "Éxito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlCuerpo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMontoDato_Click(object sender, EventArgs e)
        {

        }
    }
}