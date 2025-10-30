using System;
using System.Windows.Forms;

namespace ClubDeportivoEmma21.Forms
{
    public partial class GestionSocios : Form
    {
        private string dniSocioActual;
        private bool desdeConsulta;

        // Constructor por defecto (lo usa el menú principal y otros formularios)
        public GestionSocios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Gestión de Socios - Club Deportivo Emma 21";
            desdeConsulta = false;
        }

        // Constructor sobrecargado (lo usa FormConsultas)
        public GestionSocios(string dni)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Gestión de Socios - Club Deportivo Emma 21";

            dniSocioActual = dni;
            desdeConsulta = true;
        }

        private void GestionSocios_Load(object sender, EventArgs e)
        {
            if (desdeConsulta)
            {
                // Mostrar el DNI del socio en el título
                this.Text = $"Gestión de Socios - DNI: {dniSocioActual}";
            }

            // Aplicar estilo visual coherente a todos los botones
            EstilizarBoton(btnSocioRegistrarSocio);
            EstilizarBoton(btnSocioModificar);
            EstilizarBoton(btnSocioPagoCuota);
            EstilizarBoton(btnSocioCarnet);

            // Botón volver con diseño especial (igual al de “Salir” del Form1)
            EstilizarBotonVolver(btnSocioVolver);
        }

        private void btnSocioRegistrarSocio_Click(object sender, EventArgs e)
        {
            new AltaSocio().ShowDialog();
        }

        private void btnSocioModificar_Click(object sender, EventArgs e)
        {
            ModificarCliente modificar = new ModificarCliente();
            this.Hide();
            modificar.ShowDialog();
            this.Close();
        }

        private void btnSocioPagoCuota_Click(object sender, EventArgs e)
        {
            PagoCuota pago = new PagoCuota();
            this.Hide();
            pago.ShowDialog();
            this.Close();
        }

        private void btnSocioCarnet_Click(object sender, EventArgs e)
        {
            // Si el formulario tiene un socio actual cargado
            if (string.IsNullOrEmpty(dniSocioActual))
            {
                MessageBox.Show("Debe seleccionar o consultar un socio antes de imprimir el carnet.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new MySql.Data.MySqlClient.MySqlConnection(
                    "server=localhost;database=clubemma21;user=root;password=;"))
                {
                    conn.Open();

                    // Verificar si ya se entregó
                    string sqlCheck = @"SELECT carnet_entregado 
                                FROM socio s 
                                JOIN persona p ON p.id_persona = s.id_socio 
                                WHERE p.dni = @dni";
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlCheck, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dniSocioActual);
                        var result = cmd.ExecuteScalar();

                        if (result != null && Convert.ToBoolean(result))
                        {
                            MessageBox.Show("El carnet ya fue entregado anteriormente.",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    // Actualizar estado del carnet
                    string sqlUpdate = @"UPDATE socio s
                                 JOIN persona p ON p.id_persona = s.id_socio
                                 SET s.carnet_entregado = TRUE
                                 WHERE p.dni = @dni";
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dniSocioActual);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("🎟️ El carnet fue impreso y entregado con éxito.",
                        "Carnet entregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado del carnet: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSocioVolver_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
        }

        // ======== MÉTODOS DE ESTILO UNIFICADO ========

        private void EstilizarBoton(Button b)
        {
            var btnFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            var colorPrincipal = System.Drawing.Color.FromArgb(90, 113, 132);   // Azul acero
            var colorHover = System.Drawing.Color.FromArgb(58, 80, 107);       // Azul petróleo
            var colorTexto = System.Drawing.Color.White;

            b.BackColor = colorPrincipal;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.ForeColor = colorTexto;
            b.Font = btnFont;
            b.Size = new System.Drawing.Size(180, 55);
            b.Cursor = Cursors.Hand;

            // Eventos de hover dinámico
            b.MouseEnter += (s, e) => {
                b.BackColor = colorHover;
                b.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
                b.FlatAppearance.BorderSize = 2;
            };
            b.MouseLeave += (s, e) => {
                b.BackColor = colorPrincipal;
                b.FlatAppearance.BorderSize = 0;
            };
        }

        private void EstilizarBotonVolver(Button b)
        {
            // Mismo estilo del botón “Salir” del Form1 y Login
            b.BackColor = System.Drawing.Color.FromArgb(231, 215, 193);
            b.ForeColor = System.Drawing.Color.FromArgb(47, 47, 47);
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            b.Cursor = Cursors.Hand;

            b.MouseEnter += (s, e) => {
                b.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
                b.ForeColor = System.Drawing.Color.White;
            };
            b.MouseLeave += (s, e) => {
                b.BackColor = System.Drawing.Color.FromArgb(231, 215, 193);
                b.ForeColor = System.Drawing.Color.FromArgb(47, 47, 47);
            };
        }
    }
}

