using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivoEmma21.Data;

namespace ClubDeportivoEmma21.Forms
{
    public partial class AltaSocio : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();

        public AltaSocio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Alta de Socio - Club Deportivo Emma21";
            AplicarEstilos();
        }
		
		private void AplicarEstilos()
		{
		    // Paleta de colores institucional
		    Color fondo = ColorTranslator.FromHtml("#E7D7C1");
		    Color texto = ColorTranslator.FromHtml("#2E2E2E");
		    Color boton = ColorTranslator.FromHtml("#5A7184");
		    Color hover = ColorTranslator.FromHtml("#A78A7F");

		    this.BackColor = fondo;

		    Font fuenteLabels = new Font("Segoe UI", 10, FontStyle.Bold);
		    Font fuenteTextos = new Font("Segoe UI", 10, FontStyle.Regular);

		    // Aplicar estilos a labels
		    Label[] labels = { lblSocioNombre, lblSocioApellido, lblSocioDni, lblSocioTelefono, lblSocioDireccion, lblSocioMail };
		    foreach (var lbl in labels)
		    {
		        lbl.ForeColor = texto;
		        lbl.Font = fuenteLabels;
		    }

		    // Aplicar estilos a TextBox
		    TextBox[] cajas = { txtSocioNombre, txtSocioApellido, txtSocioDni, txtSocioTelefono, txtSocioDireccion, txtSocioMail };
		    foreach (var txt in cajas)
		    {
		        txt.Font = fuenteTextos;
		        txt.ForeColor = texto;
		        txt.BackColor = Color.White;
		        txt.BorderStyle = BorderStyle.FixedSingle;
		    }

		    // Estilizar botones
		    Button[] botones = { btnRegistrarSocio, btnCancelarAltaSocio };
		    foreach (var b in botones)
		    {
		        b.BackColor = boton;
		        b.ForeColor = Color.White;
		        b.FlatStyle = FlatStyle.Flat;
		        b.FlatAppearance.BorderSize = 0;
		        b.Font = new Font("Segoe UI", 10, FontStyle.Bold);
		        b.Cursor = Cursors.Hand;

		        // Hover delicado
		        b.MouseEnter += (s, e) => b.BackColor = hover;
		        b.MouseLeave += (s, e) => b.BackColor = boton;
		    }
		}

        private void AltaSocio_Load(object sender, EventArgs e)
        {
            // El formulario se carga limpio
        }

        // --- BOTÓN REGISTRAR SOCIO ---
        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();

                    using (var trans = conn.BeginTransaction())
                    {
                        // 1️⃣ Insertar datos en PERSONA
                        string sqlPersona = @"INSERT INTO persona 
                            (nombre, apellido, dni, telefono, direccion, mail, apto_medico)
                            VALUES (@nombre, @apellido, @dni, @telefono, @direccion, @mail, @apto)";

                        int idPersonaGenerado;

                        using (var cmd = new MySqlCommand(sqlPersona, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@nombre", txtSocioNombre.Text.Trim());
                            cmd.Parameters.AddWithValue("@apellido", txtSocioApellido.Text.Trim());
                            cmd.Parameters.AddWithValue("@dni", txtSocioDni.Text.Trim());
                            cmd.Parameters.AddWithValue("@telefono", txtSocioTelefono.Text.Trim());
                            cmd.Parameters.AddWithValue("@direccion", txtSocioDireccion.Text.Trim());
                            cmd.Parameters.AddWithValue("@mail", txtSocioMail.Text.Trim());
                            cmd.Parameters.AddWithValue("@apto", chbSocioAptoMedico.Checked);

                            cmd.ExecuteNonQuery();
                            idPersonaGenerado = (int)cmd.LastInsertedId;
                        }

                        // 2️⃣ Insertar en SOCIO (vinculado a la persona)
                        string sqlSocio = @"INSERT INTO socio 
                            (id_socio, fecha_alta, estado_membresia, carnet_entregado)
                            VALUES (@idSocio, @fecha, @estado, @carnet)";

                        using (var cmd = new MySqlCommand(sqlSocio, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@idSocio", idPersonaGenerado);
                            cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                            cmd.Parameters.AddWithValue("@estado", "Activo");
                            cmd.Parameters.AddWithValue("@carnet", false);
                            cmd.ExecuteNonQuery();
                        }

                        // 3️⃣ Crear la primera cuota inicial del socio
                        string sqlCuota = @"INSERT INTO cuota 
                            (id_socio, mes_a_pagar, valor_cuota, fecha_pago, forma_de_pago, estado_pago)
                            VALUES (@idSocio, @mes, @valor, @fecha, @forma, @estado)";

                        using (var cmd = new MySqlCommand(sqlCuota, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@idSocio", idPersonaGenerado);
                            cmd.Parameters.AddWithValue("@mes", new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1));
                            cmd.Parameters.AddWithValue("@valor", 0);
                            cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                            cmd.Parameters.AddWithValue("@forma", "Pendiente");
                            cmd.Parameters.AddWithValue("@estado", "Pendiente");
                            cmd.ExecuteNonQuery();
                        }

                        trans.Commit();
                    }

                    MessageBox.Show(
                        "Socio registrado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al registrar socio: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // --- BOTÓN CANCELAR ---
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // --- VALIDACIONES ---
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtSocioNombre.Text) ||
                string.IsNullOrWhiteSpace(txtSocioApellido.Text) ||
                string.IsNullOrWhiteSpace(txtSocioDni.Text))
            {
                MessageBox.Show(
                    "Los campos Nombre, Apellido y DNI son obligatorios.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }

            return true;
        }

        // --- MÉTODO AUXILIAR (para limpiar campos si se requiere más adelante) ---
        private void LimpiarCampos()
        {
            txtSocioNombre.Clear();
            txtSocioApellido.Clear();
            txtSocioDni.Clear();
            txtSocioTelefono.Clear();
            txtSocioDireccion.Clear();
            txtSocioMail.Clear();
            chbSocioAptoMedico.Checked = false;
        }
    }
}

