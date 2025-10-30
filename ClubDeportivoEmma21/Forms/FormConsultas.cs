using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivoEmma21.Data;

namespace ClubDeportivoEmma21.Forms
{
    public partial class FormConsultas : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();

        public FormConsultas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Consulta de Clientes - Club Deportivo Emma 21";
        }

        private void FormConsultas_Load(object sender, EventArgs e)
        {
            // Aplicar estilo visual a los elementos
            EstilizarFormulario();
            EstilizarBoton(btnBuscar);
            EstilizarBotonVolver(btnVolver);
            EstilizarTextBox(txtConsultaDniPersona);
            EstilizarLabel(lblConsultaDniPersona);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtConsultaDniPersona.Text.Trim();
            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new DatabaseHelper().GetConnection())
                {
                    conn.Open();

                    // Buscar si es socio
                    string sqlSocio = @"SELECT s.id_socio 
                                FROM socio s 
                                JOIN persona p ON p.id_persona = s.id_socio
                                WHERE p.dni = @dni";
                    using (var cmd = new MySqlCommand(sqlSocio, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int idSocio = Convert.ToInt32(result);
                            MessageBox.Show("El cliente es socio activo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Abrir directamente la gestión de socios con el DNI
                            GestionSocios gestion = new GestionSocios(dni);
                            this.Hide();
                            gestion.ShowDialog();
                            this.Close();
                        }
                    }

                    // Si no es socio, ver si es NoSocio
                    string sqlNoSocio = @"SELECT n.id_no_socio 
                                  FROM no_socio n 
                                  JOIN persona p ON p.id_persona = n.id_no_socio
                                  WHERE p.dni = @dni";
                    using (var cmd = new MySqlCommand(sqlNoSocio, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int idNoSocio = Convert.ToInt32(result);
                            MessageBox.Show("El cliente es No Socio.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new GestionNoSocios(idNoSocio, dni).Show();
                            return;
                        }
                    }

                    // Si no existe ni en socio ni en no socio
                    DialogResult opcion = MessageBox.Show(
                        "El cliente no existe en el sistema.\n¿Desea registrarlo?",
                        "Cliente no encontrado",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (opcion == DialogResult.Yes)
                    {
                        DialogResult tipo = MessageBox.Show(
                            "¿Desea registrarlo como socio?",
                            "Tipo de registro",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (tipo == DialogResult.Yes)
                            new AltaSocio().ShowDialog();
                        else
                            new AltaNoSocio().ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🎨 ===== MÉTODOS DE ESTILO =====

        private void EstilizarFormulario()
        {
            this.BackColor = Color.FromArgb(232, 237, 242);
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        }

        private void EstilizarLabel(Label lbl)
        {
            lbl.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(47, 47, 47);
        }

        private void EstilizarTextBox(TextBox txt)
        {
            txt.BackColor = Color.White;
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Font = new Font("Segoe UI", 10F);
            txt.ForeColor = Color.FromArgb(47, 47, 47);
        }

        private void EstilizarBoton(Button b)
        {
            var colorPrincipal = Color.FromArgb(90, 113, 132); // Azul acero
            var colorHover = Color.FromArgb(58, 80, 107);
            var colorTexto = Color.White;

            b.BackColor = colorPrincipal;
            b.ForeColor = colorTexto;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            b.Cursor = Cursors.Hand;

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

