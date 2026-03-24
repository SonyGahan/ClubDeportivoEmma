using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivoEmma21.Data;

namespace ClubDeportivoEmma21.Forms
{
    public partial class ModificarNoSocio : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();
        private int idPersonaModificar = 0;

        public ModificarNoSocio()
        {
            InitializeComponent();
            AsignarEfectosHover();
        }

        private void ModificarNoSocio_Load(object sender, EventArgs e)
        {
            this.btnGuardar.Enabled = false;
        }

        private void AsignarEfectosHover()
        {
            // Botones de acción (Azul)
            this.btnBuscar.MouseEnter += (s, e) => this.btnBuscar.BackColor = Color.FromArgb(90, 113, 132);
            this.btnBuscar.MouseLeave += (s, e) => this.btnBuscar.BackColor = Color.FromArgb(58, 80, 107);

            this.btnGuardar.MouseEnter += (s, e) => this.btnGuardar.BackColor = Color.FromArgb(58, 80, 107);
            this.btnGuardar.MouseLeave += (s, e) => this.btnGuardar.BackColor = Color.FromArgb(90, 113, 132);

            // Botón Cancelar (Dorado)
            this.btnCancelar.MouseEnter += (s, e) => {
                this.btnCancelar.BackColor = Color.FromArgb(212, 175, 55);
                this.btnCancelar.ForeColor = Color.White;
            };
            this.btnCancelar.MouseLeave += (s, e) => {
                this.btnCancelar.BackColor = Color.FromArgb(231, 215, 193);
                this.btnCancelar.ForeColor = Color.Black;
            };
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDniBusqueda.Text.Trim();
            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Ingrese un DNI para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    // Buscamos específicamente personas que existan en la tabla NO_SOCIO
                    string sql = @"SELECT p.id_persona, p.nombre, p.apellido, p.telefono, p.direccion, p.mail 
                                 FROM persona p 
                                 JOIN no_socio n ON p.id_persona = n.id_no_socio 
                                 WHERE p.dni = @dni";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idPersonaModificar = reader.GetInt32("id_persona");
                                txtNombre.Text = reader["nombre"].ToString();
                                txtApellido.Text = reader["apellido"].ToString();
                                txtTelefono.Text = reader["telefono"].ToString();
                                txtDireccion.Text = reader["direccion"].ToString();
                                txtMail.Text = reader["mail"].ToString();

                                btnGuardar.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ningún No Socio con ese DNI.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Limpiar();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idPersonaModificar == 0) return;

            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    string sqlUpdate = @"UPDATE persona 
                                       SET nombre = @nom, apellido = @ape, telefono = @tel, direccion = @dir, mail = @mail 
                                       WHERE id_persona = @id";

                    using (var cmd = new MySqlCommand(sqlUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@ape", txtApellido.Text.Trim());
                        cmd.Parameters.AddWithValue("@tel", txtTelefono.Text.Trim());
                        cmd.Parameters.AddWithValue("@dir", txtDireccion.Text.Trim());
                        cmd.Parameters.AddWithValue("@mail", txtMail.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", idPersonaModificar);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(" ✅ Cambios guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtMail.Clear();
            idPersonaModificar = 0;
            btnGuardar.Enabled = false;
        }
    }
}