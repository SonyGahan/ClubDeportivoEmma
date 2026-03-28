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
            AsignarEfectosHover();
        }

        private void AltaSocio_Load(object sender, EventArgs e) { }

        private void AsignarEfectosHover()
        {
            btnRegistrarSocio.MouseEnter += (s, e) => btnRegistrarSocio.BackColor = Color.FromArgb(58, 80, 107);
            btnRegistrarSocio.MouseLeave += (s, e) => btnRegistrarSocio.BackColor = Color.FromArgb(90, 113, 132);

            btnCancelarAltaSocio.MouseEnter += (s, e) => {
                btnCancelarAltaSocio.BackColor = Color.FromArgb(212, 175, 55);
                btnCancelarAltaSocio.ForeColor = Color.White;
            };
            btnCancelarAltaSocio.MouseLeave += (s, e) => {
                btnCancelarAltaSocio.BackColor = Color.FromArgb(231, 215, 193);
                btnCancelarAltaSocio.ForeColor = Color.Black;
            };
        }

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    // Usa el Stored Procedure que se creó en la base de datos
                    using (var cmd = new MySqlCommand("sp_AltaNuevoSocio", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("_nom", txtSocioNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("_ape", txtSocioApellido.Text.Trim());
                        cmd.Parameters.AddWithValue("_dni", Convert.ToInt32(txtSocioDni.Text.Trim()));
                        cmd.Parameters.AddWithValue("_tel", txtSocioTelefono.Text.Trim());
                        cmd.Parameters.AddWithValue("_dir", txtSocioDireccion.Text.Trim());
                        cmd.Parameters.AddWithValue("_mail", txtSocioMail.Text.Trim());
                        cmd.Parameters.AddWithValue("_valorCuota", 5000.00);

                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null)
                        {
                            MessageBox.Show(" ✅ Socio registrado exitosamente.\nSe ha generado la cuota del mes actual.", "Éxito");
                            this.Close();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    MessageBox.Show("El DNI ingresado ya existe en el sistema.", "Atención");
                else
                    MessageBox.Show("Error de base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        private void btnCancelarAltaSocio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtSocioNombre.Text) ||
                string.IsNullOrWhiteSpace(txtSocioApellido.Text) ||
                string.IsNullOrWhiteSpace(txtSocioDni.Text))
            {
                MessageBox.Show("Nombre, Apellido y DNI son obligatorios.", "Aviso");
                return false;
            }
            return true;
        }

        private void pnlCuerpo_Paint(object sender, PaintEventArgs e) { }
    }
}