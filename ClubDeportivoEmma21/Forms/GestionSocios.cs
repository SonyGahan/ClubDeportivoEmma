using System;
using System.Windows.Forms;

namespace ClubDeportivoEmma21.Forms
{
    public partial class GestionSocios : Form
    {
        public GestionSocios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Gestión de Socios - Club Deportivo Emma 21";
        }

        private void GestionSocios_Load(object sender, EventArgs e)
        {
        }

        private void btnSocioRegistrarSocio_Click(object sender, EventArgs e)
        {
            new AltaSocio().ShowDialog();
        }

        private void btnSocioModificar_Click(object sender, EventArgs e)
        {
            // Abre el formulario de modificación
            ModificarCliente modificar = new ModificarCliente();
            this.Hide();
            modificar.ShowDialog();
            this.Close();
        }

        private void btnSocioPagoCuota_Click(object sender, EventArgs e)
        {
            // Abre el formulario de pago mensual
            PagoCuota pago = new PagoCuota();
            this.Hide();
            pago.ShowDialog();
            this.Close();
        }

        private void btnSocioCarnet_Click(object sender, EventArgs e)
        {
            // Muestra un aviso, luego se podrá implementar la impresión
            MessageBox.Show("Función de impresión de carnet aún no implementada.",
                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSocioVolver_Click(object sender, EventArgs e)
        {
            // Volver al menú principal
            Form1 menu = new Form1();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
