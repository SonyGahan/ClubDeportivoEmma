using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivoEmma21.Data;

namespace ClubDeportivoEmma21.Forms
{
    public partial class ModificarNoSocio : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();
        private int idPersonaActual = 0;

        public ModificarNoSocio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Modificar No Socio - Club Deportivo Emma 21";
        }

        private void ModificarNoSocio_Load(object sender, EventArgs e)
        {
            btnModificarNoSocio.Enabled = false;
        }

        // Buscar No Socio por DNI
        private void btnBuscarNoSocio_Click(object sender, EventArgs e)
        {
            string dni = txtIngresoDni.Text.Trim();

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

                    // Buscar persona
                    string sqlPersona = @"SELECT p.* FROM persona p
                                          INNER JOIN no_socio n ON p.id_persona = n.id_no_socio
                                          WHERE p.dni = @dni";

                    using (var cmd = new MySqlCommand(sqlPersona, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("No se encontró ningún NO SOCIO con ese DNI.",
                                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarCampos();
                                return;
                            }

                            idPersonaActual = reader.GetInt32("id_persona");
                            txtModificarNoSocioNombre.Text = reader["nombre"].ToString();
                            txtModificarNoSocioApellido.Text = reader["apellido"].ToString();
                            txtModificarNoSocioDni.Text = reader["dni"].ToString();
                            txtModificarNoSocioTelefono.Text = reader["telefono"] != DBNull.Value ? reader["telefono"].ToString() : "";
                            txtModificarNoSocioDireccion.Text = reader["direccion"] != DBNull.Value ? reader["direccion"].ToString() : "";
                            txtModificarNoSocioMail.Text = reader["mail"] != DBNull.Value ? reader["mail"].ToString() : "";
                            chbModificarNoSocioAptoMedico.Checked = !reader.IsDBNull(reader.GetOrdinal("apto_medico")) && reader.GetBoolean("apto_medico");
                        }
                    }

                    btnModificarNoSocio.Enabled = true;
                    MessageBox.Show("No socio encontrado correctamente ✅",
                        "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar No Socio: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Guardar cambios
        private void btnModificarNoSocio_Click(object sender, EventArgs e)
        {
            if (idPersonaActual == 0)
            {
                MessageBox.Show("Debe buscar un No Socio primero.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = _db.GetConnection())
            {
                try
                {
                    conn.Open();

                    string sql = @"UPDATE persona 
                                   SET nombre=@nombre, apellido=@apellido, dni=@dni, telefono=@telefono, 
                                       direccion=@direccion, mail=@mail, apto_medico=@apto
                                   WHERE id_persona=@id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtModificarNoSocioNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@apellido", txtModificarNoSocioApellido.Text.Trim());
                        cmd.Parameters.AddWithValue("@dni", txtModificarNoSocioDni.Text.Trim());
                        cmd.Parameters.AddWithValue("@telefono", txtModificarNoSocioTelefono.Text.Trim());
                        cmd.Parameters.AddWithValue("@direccion", txtModificarNoSocioDireccion.Text.Trim());
                        cmd.Parameters.AddWithValue("@mail", txtModificarNoSocioMail.Text.Trim());
                        cmd.Parameters.AddWithValue("@apto", chbModificarNoSocioAptoMedico.Checked);
                        cmd.Parameters.AddWithValue("@id", idPersonaActual);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Datos del No Socio actualizados correctamente 🎉",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Volver al menú Gestión No Socios
                    GestionNoSocios gestion = new GestionNoSocios();
                    this.Hide();
                    gestion.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar cambios: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtModificarNoSocioNombre.Clear();
            txtModificarNoSocioApellido.Clear();
            txtModificarNoSocioDni.Clear();
            txtModificarNoSocioTelefono.Clear();
            txtModificarNoSocioDireccion.Clear();
            txtModificarNoSocioMail.Clear();
            chbModificarNoSocioAptoMedico.Checked = false;
            idPersonaActual = 0;
            btnModificarNoSocio.Enabled = false;
        }
    }
}

