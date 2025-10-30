using System;
using System.Drawing;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                lblMensaje.Text = "Por favor complete ambos campos.";
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
                                this.Hide();
                                new Form1().ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                lblMensaje.Text = "Usuario o contraseña incorrectos.";
                                txtUsuario.Clear();
                                txtContrasena.Clear();
                                txtUsuario.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnHoverEnter(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn!.BackColor = Color.FromArgb(90, 113, 132);
            btn.ForeColor = Color.White;
        }

        private void BtnHoverLeave(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == btnLogin)
            {
                btn.BackColor = Color.FromArgb(58, 80, 107);
                btn.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                btn.BackColor = Color.FromArgb(197, 208, 218);
                btn.ForeColor = Color.FromArgb(47, 47, 47);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void panelFondo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

