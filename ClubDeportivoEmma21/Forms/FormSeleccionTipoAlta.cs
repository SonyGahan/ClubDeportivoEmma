using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClubDeportivoEmma21.Forms
{
    public partial class FormSeleccionTipoAlta : Form
    {
        public FormSeleccionTipoAlta()
        {
            InitializeComponent();
            AsignarEfectosHover();
        }

        private void AsignarEfectosHover()
        {
            // Efectos para botones de Alta (Azul Acero)
            this.btnAltaSocio.MouseEnter += (s, e) => this.btnAltaSocio.BackColor = Color.FromArgb(58, 80, 107);
            this.btnAltaSocio.MouseLeave += (s, e) => this.btnAltaSocio.BackColor = Color.FromArgb(90, 113, 132);

            this.btnAltaNoSocio.MouseEnter += (s, e) => this.btnAltaNoSocio.BackColor = Color.FromArgb(58, 80, 107);
            this.btnAltaNoSocio.MouseLeave += (s, e) => this.btnAltaNoSocio.BackColor = Color.FromArgb(90, 113, 132);

            // Efecto para botón Volver (Dorado)
            this.btnVolver.MouseEnter += (s, e) =>
            {
                this.btnVolver.BackColor = Color.FromArgb(212, 175, 55);
                this.btnVolver.ForeColor = Color.White;
            };
            this.btnVolver.MouseLeave += (s, e) =>
            {
                this.btnVolver.BackColor = Color.FromArgb(231, 215, 193);
                this.btnVolver.ForeColor = Color.FromArgb(47, 47, 47);
            };
        }

        private void btnAltaSocio_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (AltaSocio form = new AltaSocio())
            {
                form.ShowDialog();
            }
            this.Close();
        }

        private void btnAltaNoSocio_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (AltaNoSocio form = new AltaNoSocio())
            {
                form.ShowDialog();
            }
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlCuerpo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}