using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivoEmma21.Data;

namespace ClubDeportivoEmma21.Forms
{
    public partial class FormLogin : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            CargarLogo();
        }

        private void CargarLogo()
        {
            try
            {
                // Busca la imagen en la subcarpeta img del directorio de ejecución.
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "Logo_gym_1.jpeg");

                if (File.Exists(path))
                {
                    picLogo.Image = Image.FromFile(path);
                }
            }
            catch (Exception)
            {
                // En caso de error, el PictureBox queda vacío pero el programa no se detiene.
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    // Usa los nombres de tabla y campos que existen en la Base de Datos.
                    string sql = "SELECT rol FROM usuario WHERE nombre_usuario = @u AND contrasena = @p";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", txtUsuario.Text.Trim());
                        cmd.Parameters.AddWithValue("@p", txtPassword.Text.Trim());

                        object rol = cmd.ExecuteScalar();

                        if (rol != null)
                        {
                            this.Hide();
                            // Pasa el rol y el nombre a la ventana principal.
                            new MenuPrincipal(rol.ToString(), txtUsuario.Text).Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Este método evita el error CS0103 del Designer.
        private void pnlCuerpo_Paint(object sender, PaintEventArgs e)
        {
            // Sin lógica de dibujo personalizada necesaria por ahora - para desarrollar.
        }
    }
}