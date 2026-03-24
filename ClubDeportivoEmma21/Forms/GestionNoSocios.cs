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
            btnCerrar.MouseEnter += (s, e) => {
                btnCerrar.BackColor = Color.FromArgb(212, 175, 55);
                btnCerrar.ForeColor = Color.White;
            };
            btnCerrar.MouseLeave += (s, e) => {
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

                    // CORRECCIÓN: Se cambió pd.monto_pagado por pd.monto
                    // OJO: Si la tabla pago_diario no tiene id_actividad, esta consulta fallará en el JOIN.
                    string sql = @"SELECT p.nombre, p.apellido, p.dni, pd.monto 
                                 FROM persona p 
                                 JOIN no_socio n ON p.id_persona = n.id_no_socio 
                                 LEFT JOIN pago_diario pd ON n.id_no_socio = pd.id_no_socio AND pd.fecha_pago = CURDATE() 
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

                                // Si hay un pago hoy, mostramos el monto
                                if (reader["monto"] != DBNull.Value)
                                {
                                    lblActividadDato.Text = "Pase Diario Activo"; // Simplificado por falta de id_actividad
                                    lblMontoDato.Text = "$ " + Convert.ToDecimal(reader["monto"]).ToString("N2");
                                }
                                else
                                {
                                    lblActividadDato.Text = "Sin actividad el día de hoy";
                                    lblMontoDato.Text = "$ 0.00";
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del No Socio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}