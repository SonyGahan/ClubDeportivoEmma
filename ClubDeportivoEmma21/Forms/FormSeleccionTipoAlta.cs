using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Windows.Forms;

namespace ClubDeportivoEmma21.Forms
{
    public partial class FormSeleccionTipoAlta : Form
    {
        public FormSeleccionTipoAlta()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Seleccionar tipo de registro";
        }

        private void btnSocio_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNoSocio_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormSeleccionTipoAlta_Load(object sender, EventArgs e)
        {

        }
    }
}

