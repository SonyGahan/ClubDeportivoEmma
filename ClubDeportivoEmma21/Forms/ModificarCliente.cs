using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivoEmma21.Data;

namespace ClubDeportivoEmma21.Forms
{
    public partial class ModificarCliente : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();
        private bool esSocio = false;
        private int idPersonaActual = 0;

        public ModificarCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Modificar Cliente - Club Deportivo Emma21";
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            btnModificarCliente.Enabled = false;
            btnEliminarCliente.Enabled = false;
        }

        // Busqueda por DNI
        private void btnBuscarCliente_Click(object sender, EventArgs e)
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

                    // 1️ Busca la persona
                    string sqlPersona = "SELECT * FROM persona WHERE dni = @dni";
                    using (var cmd = new MySqlCommand(sqlPersona, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("No se encontró ningún cliente con ese DNI.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarCampos();
                                return;
                            }

                            idPersonaActual = reader.GetInt32("id_persona");

                            txtModificarClienteNombre.Text = reader["nombre"].ToString();
                            txtModificarClienteApellido.Text = reader["apellido"].ToString();
                            txtModificarClienteDni.Text = reader["dni"].ToString();
                            txtModificarClienteTelefono.Text = reader["telefono"] != DBNull.Value ? reader["telefono"].ToString() : "";
                            txtModificarClienteDireccion.Text = reader["direccion"] != DBNull.Value ? reader["direccion"].ToString() : "";
                            txtModificarClienteMail.Text = reader["mail"] != DBNull.Value ? reader["mail"].ToString() : "";
                            chbModificarClienteAptoMedico.Checked = !reader.IsDBNull(reader.GetOrdinal("apto_medico")) && reader.GetBoolean("apto_medico");
                        }
                    }

                    // 2️ Verifica si es socio o no socio
                    string sqlSocio = "SELECT estado_membresia FROM socio WHERE id_socio = @id";
                    using (var cmd = new MySqlCommand(sqlSocio, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idPersonaActual);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            esSocio = true;
                            btnEliminarCliente.Visible = true;  // Mostrar solo para socios
                            btnEliminarCliente.BackColor = Color.LightCoral;
                            btnEliminarCliente.ForeColor = Color.White;
                        }
                        else
                        {
                            esSocio = false;
                            btnEliminarCliente.Visible = false; // Ocultar para no socios
                        }

                    }

                    btnModificarCliente.Enabled = true;
                    MessageBox.Show(esSocio ? "Cliente encontrado: SOCIO" : "Cliente encontrado: NO SOCIO",
                        "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Guarda los cambios
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (idPersonaActual == 0)
            {
                MessageBox.Show("Debe buscar un cliente primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        cmd.Parameters.AddWithValue("@nombre", txtModificarClienteNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@apellido", txtModificarClienteApellido.Text.Trim());
                        cmd.Parameters.AddWithValue("@dni", txtModificarClienteDni.Text.Trim());
                        cmd.Parameters.AddWithValue("@telefono", txtModificarClienteTelefono.Text.Trim());
                        cmd.Parameters.AddWithValue("@direccion", txtModificarClienteDireccion.Text.Trim());
                        cmd.Parameters.AddWithValue("@mail", txtModificarClienteMail.Text.Trim());
                        cmd.Parameters.AddWithValue("@apto", chbModificarClienteAptoMedico.Checked);
                        cmd.Parameters.AddWithValue("@id", idPersonaActual);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Datos actualizados correctamente ✅", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Volver al menú correspondiente
                    if (esSocio)
                    {
                        GestionSocios gestion = new GestionSocios();
                        this.Hide();
                        gestion.ShowDialog();
                    }
                    else
                    {
                        GestionNoSocios gestion = new GestionNoSocios();
                        this.Hide();
                        gestion.ShowDialog();
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Dar de baja (solo a socios)
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (!esSocio)
            {
                MessageBox.Show("Solo los socios pueden darse de baja.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Desea dar de baja este socio?", "Confirmar baja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.No)
                return;

            using (var conn = _db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string sql = "UPDATE socio SET estado_membresia = 'Inactivo' WHERE id_socio = @id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idPersonaActual);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Socio dado de baja correctamente 🚫", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GestionSocios gestion = new GestionSocios();
                    this.Hide();
                    gestion.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al dar de baja: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarCampos()
        {
            txtModificarClienteNombre.Clear();
            txtModificarClienteApellido.Clear();
            txtModificarClienteDni.Clear();
            txtModificarClienteTelefono.Clear();
            txtModificarClienteDireccion.Clear();
            txtModificarClienteMail.Clear();
            chbModificarClienteAptoMedico.Checked = false;
            idPersonaActual = 0;
            esSocio = false;
            btnModificarCliente.Enabled = false;
            btnEliminarCliente.Enabled = false;
        }
    }
}
