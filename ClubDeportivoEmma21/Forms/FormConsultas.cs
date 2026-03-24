using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivoEmma21.Data;

namespace ClubDeportivoEmma21.Forms
{
    public partial class FormConsultas : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();

        public FormConsultas()
        {
            InitializeComponent();
            AsignarEfectosHover();
        }

        private void FormConsultas_Load(object sender, EventArgs e)
        {
            // Carga inicial
        }

        private void AsignarEfectosHover()
        {
            // Botón Buscar
            btnBuscar.MouseEnter += (s, e) => btnBuscar.BackColor = Color.FromArgb(58, 80, 107);
            btnBuscar.MouseLeave += (s, e) => btnBuscar.BackColor = Color.FromArgb(90, 113, 132);

            // Botón Volver
            btnVolver.MouseEnter += (s, e) => {
                btnVolver.BackColor = Color.FromArgb(212, 175, 55);
                btnVolver.ForeColor = Color.White;
            };
            btnVolver.MouseLeave += (s, e) => {
                btnVolver.BackColor = Color.FromArgb(231, 215, 193);
                btnVolver.ForeColor = Color.Black;
            };
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtConsultaDniPersona.Text.Trim();
            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor ingrese un DNI válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();

                    // 1. Buscar en la tabla SOCIO
                    string sqlSocio = @"SELECT s.id_socio FROM socio s 
                                       JOIN persona p ON p.id_persona = s.id_socio 
                                       WHERE p.dni = @dni";
                    using (var cmd = new MySqlCommand(sqlSocio, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            MessageBox.Show("El cliente es Socio Activo del Club.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new GestionSocios(dni).ShowDialog();
                            this.Close();
                            return;
                        }
                    }

                    // 2. Buscar en la tabla NO_SOCIO
                    string sqlNoSocio = @"SELECT n.id_no_socio FROM no_socio n 
                                         JOIN persona p ON p.id_persona = n.id_no_socio 
                                         WHERE p.dni = @dni";
                    using (var cmd = new MySqlCommand(sqlNoSocio, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            int idNoSocio = Convert.ToInt32(result);
                            MessageBox.Show("El cliente está registrado como No Socio.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new GestionNoSocios(idNoSocio, dni).Show();
                            this.Close();
                            return;
                        }
                    }

                    // 3. Si no existe en ninguna
                    DialogResult opcion = MessageBox.Show("El DNI no se encuentra registrado.\n¿Desea iniciar el proceso de alta?", "No Encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opcion == DialogResult.Yes)
                    {
                        this.Hide();
                        new FormSeleccionTipoAlta().ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}