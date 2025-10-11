using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivoEmma21.Data;

namespace ClubDeportivoEmma21.Forms
{
    public partial class AltaNoSocio : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();

        public AltaNoSocio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Alta de No Socio - Club Deportivo Emma 21";
        }

        private void btnRegistrarNoSocio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Los campos Nombre, Apellido y DNI son obligatorios.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    using (var trans = conn.BeginTransaction())
                    {
                        // Insertar en PERSONA
                        string sqlPersona = @"INSERT INTO persona 
                            (nombre, apellido, dni, telefono, direccion, mail, apto_medico)
                            VALUES (@nombre, @apellido, @dni, @telefono, @direccion, @mail, @apto)";

                        int idPersonaGenerado;

                        using (var cmd = new MySqlCommand(sqlPersona, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                            cmd.Parameters.AddWithValue("@apellido", txtApellido.Text.Trim());
                            cmd.Parameters.AddWithValue("@dni", txtDni.Text.Trim());
                            cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
                            cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text.Trim());
                            cmd.Parameters.AddWithValue("@mail", txtMail.Text.Trim());
                            cmd.Parameters.AddWithValue("@apto", chbAptoMedico.Checked);
                            cmd.ExecuteNonQuery();
                            idPersonaGenerado = (int)cmd.LastInsertedId;
                        }

                        // Insertar en NO_SOCIO
                        string sqlNoSocio = @"INSERT INTO no_socio (id_no_socio, fecha_ingreso)
                                              VALUES (@id, @fecha)";
                        using (var cmd = new MySqlCommand(sqlNoSocio, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@id", idPersonaGenerado);
                            cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }

                        trans.Commit();
                    }

                    MessageBox.Show("No socio registrado correctamente 🎉",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar no socio: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

