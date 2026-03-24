using System;
using System.Drawing;
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
            AsignarEfectosHover();
        }

        private void AltaNoSocio_Load(object sender, EventArgs e)
        {
            // El diseño se carga automáticamente desde el Designer.cs
        }

        private void AsignarEfectosHover()
        {
            // Botón Registrar (Azul)
            btnRegistrarNoSocio.MouseEnter += (s, e) => btnRegistrarNoSocio.BackColor = Color.FromArgb(58, 80, 107);
            btnRegistrarNoSocio.MouseLeave += (s, e) => btnRegistrarNoSocio.BackColor = Color.FromArgb(90, 113, 132);

            // Botón Cancelar (Beige/Dorado)
            btnCancelar.MouseEnter += (s, e) =>
            {
                btnCancelar.BackColor = Color.FromArgb(212, 175, 55);
                btnCancelar.ForeColor = Color.White;
            };
            btnCancelar.MouseLeave += (s, e) =>
            {
                btnCancelar.BackColor = Color.FromArgb(231, 215, 193);
                btnCancelar.ForeColor = Color.Black;
            };
        }

        private void btnRegistrarNoSocio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Por favor complete los campos obligatorios (Nombre y DNI).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    using (var trans = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Insertar en tabla PERSONA
                            string sqlPersona = @"INSERT INTO persona (nombre, apellido, dni, telefono, direccion, mail, apto_medico) 
                                                 VALUES (@nom, @ape, @dni, @tel, @dir, @mail, @apto)";
                            int idPersona;
                            using (var cmd = new MySqlCommand(sqlPersona, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@nom", txtNombre.Text.Trim());
                                cmd.Parameters.AddWithValue("@ape", txtApellido.Text.Trim());
                                cmd.Parameters.AddWithValue("@dni", txtDni.Text.Trim());
                                cmd.Parameters.AddWithValue("@tel", txtTelefono.Text.Trim());
                                cmd.Parameters.AddWithValue("@dir", txtDireccion.Text.Trim());
                                cmd.Parameters.AddWithValue("@mail", txtMail.Text.Trim());
                                cmd.Parameters.AddWithValue("@apto", chbAptoMedico.Checked);
                                cmd.ExecuteNonQuery();
                                idPersona = (int)cmd.LastInsertedId;
                            }

                            // 2. Insertar en tabla NO_SOCIO
                            string sqlNoSocio = "INSERT INTO no_socio (id_no_socio, fecha_ingreso) VALUES (@id, NOW())";
                            using (var cmd = new MySqlCommand(sqlNoSocio, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@id", idPersona);
                                cmd.ExecuteNonQuery();
                            }

                            trans.Commit();
                            MessageBox.Show("No Socio registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception)
                        {
                            trans.Rollback();
                            throw;
                        }
                    }
                }
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
    }
}