using System;
using System.Windows.Forms;
using ClubDeportivoEmma21.Forms;

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

            // Asignar eventos
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
    }
}


