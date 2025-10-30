using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClubDeportivoEmma21.Forms
{
    public partial class GestionNoSocios : Form
    {
        private int idNoSocioActual = 0;
        private string dniNoSocioActual = string.Empty;
        private bool desdeConsulta = false;

        public GestionNoSocios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Gestión de No Socios - Club Deportivo Emma 21";
        }

        public GestionNoSocios(int idNoSocio, string dni)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Gestión de No Socios - Club Deportivo Emma 21";

            this.idNoSocioActual = idNoSocio;
            this.dniNoSocioActual = dni;
            this.desdeConsulta = true;
        }

        private void GestionNoSocios_Load(object sender, EventArgs e)
        {
            if (desdeConsulta)
            {
                MessageBox.Show(
                    $"No socio encontrado con DNI: {dniNoSocioActual}",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            // Aplicar estilos coherentes
            EstilizarBoton(btnNoSociosRegistrar);
            EstilizarBoton(btnNoSociosModificar);
            EstilizarBoton(btnNoSociosInscribirActividad);
            EstilizarBotonVolver(btnNoSociosVolver);

            // Asignar eventos funcionales
            btnNoSociosRegistrar.Click += btnNoSociosRegistrar_Click;
            btnNoSociosModificar.Click += btnNoSociosModificar_Click;
            btnNoSociosInscribirActividad.Click += btnNoSociosInscribirActividad_Click;
            btnNoSociosVolver.Click += btnNoSociosVolver_Click;
        }

        private void btnNoSociosRegistrar_Click(object? sender, EventArgs e)
        {
            AltaNoSocio alta = new AltaNoSocio();
            this.Hide();
            alta.ShowDialog();
            this.Close();
        }

        private void btnNoSociosModificar_Click(object? sender, EventArgs e)
        {
            ModificarNoSocio mod = new ModificarNoSocio();
            this.Hide();
            mod.ShowDialog();
            this.Close();
        }

        private void btnNoSociosInscribirActividad_Click(object? sender, EventArgs e)
        {
            NoSocioActividad inscripcion = new NoSocioActividad(idNoSocioActual, dniNoSocioActual);
            this.Hide();
            inscripcion.ShowDialog();
            this.Close();
        }

        private void btnNoSociosVolver_Click(object? sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        // ======== MÉTODOS DE ESTILO UNIFICADO ========

        private void EstilizarBoton(Button b)
        {
            var btnFont = new Font("Segoe UI", 11F, FontStyle.Bold);
            var colorPrincipal = Color.FromArgb(90, 113, 132);   // Azul acero
            var colorHover = Color.FromArgb(58, 80, 107);       // Azul petróleo
            var colorTexto = Color.White;

            b.BackColor = colorPrincipal;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.ForeColor = colorTexto;
            b.Font = btnFont;
            b.Size = new Size(200, 55);
            b.Cursor = Cursors.Hand;

            // Efectos hover dinámicos
            b.MouseEnter += (s, e) =>
            {
                b.BackColor = colorHover;
                b.FlatAppearance.BorderColor = Color.WhiteSmoke;
                b.FlatAppearance.BorderSize = 2;
            };
            b.MouseLeave += (s, e) =>
            {
                b.BackColor = colorPrincipal;
                b.FlatAppearance.BorderSize = 0;
            };
        }

        private void EstilizarBotonVolver(Button b)
        {
            b.BackColor = Color.FromArgb(231, 215, 193);
            b.ForeColor = Color.FromArgb(47, 47, 47);
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            b.Cursor = Cursors.Hand;

            b.MouseEnter += (s, e) =>
            {
                b.BackColor = Color.FromArgb(212, 175, 55);
                b.ForeColor = Color.White;
            };
            b.MouseLeave += (s, e) =>
            {
                b.BackColor = Color.FromArgb(231, 215, 193);
                b.ForeColor = Color.FromArgb(47, 47, 47);
            };
        }
    }
}



