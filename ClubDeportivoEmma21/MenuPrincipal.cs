using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Referencia necesaria para los comandos de base de datos.
using ClubDeportivoEmma21.Data; // Referencia al DatabaseHelper.

namespace ClubDeportivoEmma21.Forms
{
    public partial class MenuPrincipal : Form
    {
        // Instancia para conectar a la base de datos.
        private readonly DatabaseHelper _db = new DatabaseHelper();

        public MenuPrincipal(string rol, string usuario)
        {
            InitializeComponent();
            lblUserStatus.Text = "Usuario: " + usuario + "\nRol: " + rol;

            // Seguridad: Solo el Administrador ve el botón de Morosos.
            if (rol != "Admin")
            {
                btnMorosos.Visible = false;
            }

            AsignarEfectosHover();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarImagenFondo();

            // LLAMADA AL BLINDAJE: 
            // Cada vez que ingresa al menú, actualiza quién debe y quién no.
            RefrescarEstadoMorosos();
        }

        private void RefrescarEstadoMorosos()
        {
            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    // Ejecuta el Stored Procedure definido en MySQL.
                    using (var cmd = new MySqlCommand("sp_ActualizarMorosos", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Un error aquí no debe detener el programa, solo lo registra en la consola.
                Console.WriteLine("Aviso: No se pudo actualizar morosos automáticamente: " + ex.Message);
            }
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
            catch { /* Failsafe: Si no está la imagen, el sistema sigue funcionando */ }
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
            btnLogOut.MouseEnter += (s, e) =>
            {
                btnLogOut.BackColor = Color.FromArgb(212, 175, 55);
                btnLogOut.ForeColor = Color.White;
            };
            btnLogOut.MouseLeave += (s, e) =>
            {
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
            // Muestra el login nuevamente.
            foreach (Form f in Application.OpenForms)
            {
                if (f is FormLogin) { f.Show(); break; }
            }
        }

        private void picFondo_Click(object sender, EventArgs e) { }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}