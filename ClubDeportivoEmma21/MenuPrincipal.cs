using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ClubDeportivoEmma21.Forms
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal(string rol, string usuario)
        {
            InitializeComponent();
            lblUserStatus.Text = "Usuario: " + usuario + "\nRol: " + rol;

            // Seguridad: Solo el Administrador ve el botón de Morosos
            if (rol != "Admin")
            {
                btnMorosos.Visible = false;
            }

            AsignarEfectosHover();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarImagenFondo();
        }

        private void CargarImagenFondo()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "Fondo_gym_4.jpeg");
                if (File.Exists(path))
                {
                    picFondo.Image = Image.FromFile(path);
                }
            }
            catch { /* Failsafe */ }
        }

        private void AsignarEfectosHover()
        {
            // Botones del Sidebar (Azul Acero)
            Button[] botones = { btnConsultas, btnMorosos, btnRenovarApto };
            foreach (var b in botones)
            {
                b.MouseEnter += (s, e) => b.BackColor = Color.FromArgb(58, 80, 107);
                b.MouseLeave += (s, e) => b.BackColor = Color.FromArgb(90, 113, 132);
            }

            // Botón LogOut (Dorado)
            btnLogOut.MouseEnter += (s, e) => {
                btnLogOut.BackColor = Color.FromArgb(212, 175, 55);
                btnLogOut.ForeColor = Color.White;
            };
            btnLogOut.MouseLeave += (s, e) => {
                btnLogOut.BackColor = Color.FromArgb(231, 215, 193);
                btnLogOut.ForeColor = Color.FromArgb(47, 47, 47);
            };
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            new FormConsultas().ShowDialog();
        }

        private void btnMorosos_Click(object sender, EventArgs e)
        {
            new FormMorosos().ShowDialog();
        }

        private void btnRenovarApto_Click(object sender, EventArgs e)
        {
            new FormRenovarApto().ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            // Esto asume que el Login es el formulario inicial que quedó oculto
            foreach (Form f in Application.OpenForms)
            {
                if (f is FormLogin) { f.Show(); break; }
            }
        }
    }
}