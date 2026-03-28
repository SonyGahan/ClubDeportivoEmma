using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivoEmma21.Data;

namespace ClubDeportivoEmma21.Forms
{
    public partial class FormRenovarApto : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();
        private int idPersonaEncontrada = 0;

        public FormRenovarApto()
        {
            InitializeComponent();
            AsignarEfectosHover();
        }

        private void FormRenovarApto_Load(object sender, EventArgs e)
        {
            // El botón de renovar empieza bloqueado hasta que se encuentre un DNI válido.
            btnRenovar.Enabled = false;
        }

        private void AsignarEfectosHover()
        {
            // Botón Buscar (Azul Petróleo)
            btnBuscar.MouseEnter += (s, e) => btnBuscar.BackColor = Color.FromArgb(90, 113, 132);
            btnBuscar.MouseLeave += (s, e) => btnBuscar.BackColor = Color.FromArgb(58, 80, 107);

            // Botón Renovar (Azul Acero)
            btnRenovar.MouseEnter += (s, e) => btnRenovar.BackColor = Color.FromArgb(58, 80, 107);
            btnRenovar.MouseLeave += (s, e) => btnRenovar.BackColor = Color.FromArgb(90, 113, 132);

            // Botón Volver (Beige)
            btnCancelar.MouseEnter += (s, e) =>
            {
                btnCancelar.BackColor = Color.FromArgb(212, 175, 55);
                btnCancelar.ForeColor = Color.White;
            };
            btnCancelar.MouseLeave += (s, e) =>
            {
                btnCancelar.BackColor = Color.FromArgb(231, 215, 193);
                btnCancelar.ForeColor = Color.FromArgb(47, 47, 47);
            };
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dniBusqueda = txtDni.Text.Trim();

            if (string.IsNullOrEmpty(dniBusqueda))
            {
                MessageBox.Show("Por favor ingrese un número de DNI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    // Consulta la tabla PERSONA para obtener nombre y fecha de vencimiento.
                    string sql = "SELECT id_persona, nombre, apellido, fecha_venc_apto FROM persona WHERE dni = @dni";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dniBusqueda);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idPersonaEncontrada = reader.GetInt32("id_persona");
                                lblNombreDato.Text = reader["nombre"].ToString() + " " + reader["apellido"].ToString();

                                // Manejo de la fecha de vencimiento
                                if (reader["fecha_venc_apto"] != DBNull.Value)
                                {
                                    DateTime fecha = Convert.ToDateTime(reader["fecha_venc_apto"]);
                                    lblVencimientoDato.Text = fecha.ToString("dd/MM/yyyy");

                                    // Lógica de colores para el vencimiento.
                                    if (fecha < DateTime.Today)
                                    {
                                        lblVencimientoDato.ForeColor = Color.Red; // Vencido
                                    }
                                    else
                                    {
                                        lblVencimientoDato.ForeColor = Color.Green; // Vigente
                                    }
                                }
                                else
                                {
                                    lblVencimientoDato.Text = "No presentado anteriormente";
                                    lblVencimientoDato.ForeColor = Color.DarkOrange;
                                }

                                btnRenovar.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ninguna persona con ese DNI.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarFormulario();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRenovar_Click(object sender, EventArgs e)
        {
            if (idPersonaEncontrada == 0) return;

            try
            {
                // Calcula 1 año a partir de  hoy.
                DateTime nuevaFecha = DateTime.Today.AddYears(1);

                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    // Actualiza el registro en la base de datos.
                    string sqlUpdate = "UPDATE persona SET apto_medico = 1, fecha_venc_apto = @fecha WHERE id_persona = @id";

                    using (var cmd = new MySqlCommand(sqlUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@fecha", nuevaFecha);
                        cmd.Parameters.AddWithValue("@id", idPersonaEncontrada);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(" ✅ ¡Renovación exitosa!\n\nEl nuevo vencimiento es: " + nuevaFecha.ToString("dd/MM/yyyy"), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarFormulario()
        {
            lblNombreDato.Text = "-";
            lblVencimientoDato.Text = "-";
            lblVencimientoDato.ForeColor = Color.FromArgb(47, 47, 47);
            idPersonaEncontrada = 0;
            btnRenovar.Enabled = false;
        }

        private void pnlCuerpo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}