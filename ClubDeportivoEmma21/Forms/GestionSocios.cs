using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivoEmma21.Data;
using ClubDeportivoEmma21.Utils;

namespace ClubDeportivoEmma21.Forms
{
    public partial class GestionSocios : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();
        private readonly ValidadorNegocio _validador = new ValidadorNegocio();

        private int idSocioActual = 0;
        private string dniSocioActual = "";

        public GestionSocios(string dni)
        {
            InitializeComponent();
            this.dniSocioActual = dni;
            AsignarEfectosHover();
        }

        private void GestionSocios_Load(object sender, EventArgs e)
        {
            CargarDatosSocio();
        }

        private void AsignarEfectosHover()
        {
            // Botones Azules (Acciones)
            Button[] principales = { btnPagarCuota, btnEmitirCarnet, btnRenovarApto };
            foreach (var b in principales)
            {
                b.MouseEnter += (s, e) => b.BackColor = Color.FromArgb(58, 80, 107);
                b.MouseLeave += (s, e) => b.BackColor = Color.FromArgb(90, 113, 132);
            }

            // Botón Volver (Dorado)
            btnVolver.MouseEnter += (s, e) =>
            {
                btnVolver.BackColor = Color.FromArgb(212, 175, 55);
                btnVolver.ForeColor = Color.White;
            };
            btnVolver.MouseLeave += (s, e) =>
            {
                btnVolver.BackColor = Color.FromArgb(231, 215, 193);
                btnVolver.ForeColor = Color.Black;
            };
        }

        private void CargarDatosSocio()
        {
            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    // Consulta unificada entre Persona y Socio.
                    string sql = @"SELECT s.id_socio, p.nombre, p.apellido, p.dni, s.estado_membresia, p.fecha_venc_apto 
                                 FROM socio s 
                                 JOIN persona p ON p.id_persona = s.id_socio 
                                 WHERE p.dni = @dni";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dniSocioActual);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idSocioActual = reader.GetInt32("id_socio");
                                lblDniDato.Text = reader["dni"].ToString();
                                lblNombreDato.Text = reader["nombre"].ToString() + " " + reader["apellido"].ToString();

                                string estado = reader["estado_membresia"].ToString();
                                lblEstadoDato.Text = estado;
                                lblEstadoDato.ForeColor = (estado == "Activo") ? Color.Green : Color.DarkRed;

                                if (reader["fecha_venc_apto"] != DBNull.Value)
                                {
                                    DateTime fechaVenc = Convert.ToDateTime(reader["fecha_venc_apto"]);
                                    lblAptoDato.Text = "Vence el: " + fechaVenc.ToString("dd/MM/yyyy");
                                    lblAptoDato.ForeColor = (fechaVenc < DateTime.Today) ? Color.Red : Color.Green;
                                }
                                else
                                {
                                    lblAptoDato.Text = "Sin Apto Registrado";
                                    lblAptoDato.ForeColor = Color.DarkOrange;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del socio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // MÉTODO MAESTRO DE VALIDACIÓN
        private bool EsSocioAptoParaOperar()
        {
            string mensaje;

            // 1. Valida Apto Médico.
            if (!_validador.ValidarAptoMedico(idSocioActual, out mensaje))
            {
                MessageBox.Show("⛔ BLOQUEO MÉDICO: " + mensaje, "Validación de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // 2. Valida Morosidad.
            if (_validador.EsSocioMoroso(idSocioActual, out mensaje))
            {
                MessageBox.Show("💰 BLOQUEO POR DEUDA: " + mensaje, "Validación Administrativa", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            return true; // Si pasó ambos filtros, devuelve verdadero
        }

        // EVENTOS DE BOTONES

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            // Para pagar NO bloquea, ya que es el medio para salir de la morosidad.
            new PagoCuota(idSocioActual, dniSocioActual).ShowDialog();
            CargarDatosSocio(); // Recarga para ver si el estado cambió.
        }

        private void btnRenovarApto_Click(object sender, EventArgs e)
        {
            // Para renovar apto NO bloquea, es el medio para corregir el estado médico.
            new FormRenovarApto().ShowDialog();
            CargarDatosSocio(); // Recarga para ver la nueva fecha.
        }

        private void btnEmitirCarnet_Click(object sender, EventArgs e)
        {
            // Solo emite carnet si el socio está al día y con apto vigente.
            if (!EsSocioAptoParaOperar())
            {
                return; // Se detiene la ejecución si falla cualquier validación.
            }

            // Si llegó acá, todo está correcto
            new FormCarnet(lblNombreDato.Text, dniSocioActual, idSocioActual.ToString()).ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlCuerpo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}