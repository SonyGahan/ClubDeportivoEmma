using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivoEmma21.Data;

namespace ClubDeportivoEmma21.Forms
{
    public partial class GestionNoSocios : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();
        private int idNoSocioActual;
        private string dniActual;

        public GestionNoSocios(int id, string dni)
        {
            InitializeComponent();
            this.idNoSocioActual = id;
            this.dniActual = dni;

            AsignarEfectosHover();
        }

        private void GestionNoSocios_Load(object sender, EventArgs e)
        {
            CargarDatosNoSocio();
        }

        private void AsignarEfectosHover()
        {
            btnCerrar.MouseEnter += (s, e) =>
            {
                btnCerrar.BackColor = Color.FromArgb(212, 175, 55);
                btnCerrar.ForeColor = Color.White;
            };
            btnCerrar.MouseLeave += (s, e) =>
            {
                btnCerrar.BackColor = Color.FromArgb(231, 215, 193);
                btnCerrar.ForeColor = Color.Black;
            };
        }

        private void CargarDatosNoSocio()
        {
            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();

                    // JOIN entre persona, pago_diario y actividad para traer el nombre del deporte
                    string sql = @"SELECT p.nombre, p.apellido, p.dni, pd.monto, act.nombre_actividad 
                         FROM persona p 
                         JOIN no_socio n ON p.id_persona = n.id_no_socio 
                         LEFT JOIN pago_diario pd ON n.id_no_socio = pd.id_no_socio AND pd.fecha_pago = CURDATE() 
                         LEFT JOIN actividad act ON pd.id_actividad = act.id_actividad
                         WHERE p.dni = @dni";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dniActual);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblDniDato.Text = reader["dni"].ToString();
                                lblNombreDato.Text = reader["nombre"].ToString() + " " + reader["apellido"].ToString();

                                if (reader["monto"] != DBNull.Value)
                                {
                                    // Ahora sí mostramos el nombre real de la actividad
                                    lblActividadDato.Text = reader["nombre_actividad"].ToString();
                                    lblMontoDato.Text = "$ " + Convert.ToDecimal(reader["monto"]).ToString("N2");
                                    lblActividadDato.ForeColor = Color.DarkBlue;
                                }
                                else
                                {
                                    lblActividadDato.Text = "Sin actividad el día de hoy";
                                    lblMontoDato.Text = "$ 0.00";
                                    lblActividadDato.ForeColor = Color.Gray;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlCuerpo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}