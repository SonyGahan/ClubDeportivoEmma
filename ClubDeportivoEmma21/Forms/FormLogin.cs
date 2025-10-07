using System;
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
            // No hace nada aún, evita errores de compilación
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            // Validación simple para conexion a la BD
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor complete ambos campos.",
                    "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM usuario WHERE nombre_usuario = @usuario AND contrasena = @contrasena";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Inicio de sesión exitoso 🎉", "Bienvenido",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Hide();
                                Form menu = new Form1(); // temporal, después se agrega el FormMenu
                                menu.Show();
                            }
                            else
                            {
                                MostrarErrorYReiniciar("Usuario o contraseña incorrectos.\nPor favor, intente nuevamente.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarErrorYReiniciar("Error al conectar con la base de datos:\n" + ex.Message);
            }
        }

        private void MostrarErrorYReiniciar(string mensaje)
        {
            MessageBox.Show(mensaje, "Error de inicio de sesión",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Limpia los campos y coloca el foco en el usuario
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtUsuario.Focus();
        }
    }
}
