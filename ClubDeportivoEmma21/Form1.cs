using System;
using System.Windows.Forms;
using ClubDeportivoEmma21.Forms; // para acceder a los demás formularios

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

        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("¿Desea salir del sistema?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
                Application.Exit();
        }
    }
}

