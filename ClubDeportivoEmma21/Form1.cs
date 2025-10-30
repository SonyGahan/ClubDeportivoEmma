using System;
using System.Drawing;
using System.Windows.Forms;
using ClubDeportivoEmma21.Forms;

namespace ClubDeportivoEmma21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Menú Principal - Club Deportivo Emma 21";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // 🎨 Método auxiliar para crear botones estilizados desde código
        private Button CrearBoton(string texto, int x, int y, int width, int height)
        {
            // Este método sirve para crear botones de manera programática
            // con un estilo uniforme (color, fuente, efectos de hover).
            // No se usa en el Designer, pero es útil si querés generar botones dinámicos
            // o mantener la coherencia de estilo en otros formularios.

            var boton = new Button
            {
                Text = texto,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#5A7184"),  // Azul acero
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(x, y),
                Size = new Size(width, height),
                Cursor = Cursors.Hand
            };

            boton.FlatAppearance.BorderSize = 0;
            boton.MouseEnter += BtnHoverEnter;
            boton.MouseLeave += BtnHoverLeave;
            return boton;
        }

        // 🌊 Efectos visuales para los botones principales
        private void BtnHoverEnter(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                btn.FlatAppearance.BorderSize = 2;
                btn.FlatAppearance.BorderColor = Color.WhiteSmoke;
                btn.BackColor = ColorTranslator.FromHtml("#c5d0da"); // tono más claro
                btn.Cursor = Cursors.Hand;
            }
        }

        private void BtnHoverLeave(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = ColorTranslator.FromHtml("#3a506b"); // color base
            }
        }

        // 🌤️ Efectos visuales específicos para el botón "Salir"
        private void BtnSalirHoverEnter(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(212, 175, 55); // Dorado cálido
                btn.ForeColor = Color.White;
            }
        }

        private void BtnSalirHoverLeave(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(231, 215, 193); // Beige original
                btn.ForeColor = Color.FromArgb(47, 47, 47);
            }
        }

        // 🧭 Eventos de navegación
        private void btnGestionSocios_Click(object sender, EventArgs e)
        {
            GestionSocios f = new GestionSocios();
            f.ShowDialog();
        }

        private void btnGestionNoSocios_Click(object sender, EventArgs e)
        {
            GestionNoSocios f = new GestionNoSocios();
            f.ShowDialog();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            FormConsultas f = new FormConsultas();
            f.ShowDialog();
        }

        private void btnMorosos_Click(object sender, EventArgs e)
        {
            FormMorosos f = new FormMorosos();
            f.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "¿Desea salir del sistema?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
                Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}



