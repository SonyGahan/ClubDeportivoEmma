namespace ClubDeportivoEmma21.Forms
{
    partial class AltaNoSocio
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblTelefono = new Label();
            lblDireccion = new Label();
            lblMail = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtMail = new TextBox();
            chbAptoMedico = new CheckBox();
            btnRegistrarNoSocio = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(40, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(74, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.Location = new Point(40, 65);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(74, 23);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            lblDni.Location = new Point(40, 100);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(74, 23);
            lblDni.TabIndex = 4;
            lblDni.Text = "DNI:";
            // 
            // lblTelefono
            // 
            lblTelefono.Location = new Point(40, 135);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(74, 23);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblDireccion
            // 
            lblDireccion.Location = new Point(40, 170);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(74, 23);
            lblDireccion.TabIndex = 8;
            lblDireccion.Text = "Dirección:";
            // 
            // lblMail
            // 
            lblMail.Location = new Point(40, 205);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(74, 23);
            lblMail.TabIndex = 10;
            lblMail.Text = "Mail:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(122, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(131, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(122, 62);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(131, 23);
            txtApellido.TabIndex = 3;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(122, 97);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(131, 23);
            txtDni.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(122, 132);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(131, 23);
            txtTelefono.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(122, 167);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(131, 23);
            txtDireccion.TabIndex = 9;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(122, 202);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(131, 23);
            txtMail.TabIndex = 11;
            // 
            // chbAptoMedico
            // 
            chbAptoMedico.Location = new Point(122, 235);
            chbAptoMedico.Name = "chbAptoMedico";
            chbAptoMedico.Size = new Size(104, 24);
            chbAptoMedico.TabIndex = 12;
            chbAptoMedico.Text = "Apto médico";
            // 
            // btnRegistrarNoSocio
            // 
            btnRegistrarNoSocio.Location = new Point(296, 28);
            btnRegistrarNoSocio.Name = "btnRegistrarNoSocio";
            btnRegistrarNoSocio.Size = new Size(75, 23);
            btnRegistrarNoSocio.TabIndex = 13;
            btnRegistrarNoSocio.Text = "Registrar";
            btnRegistrarNoSocio.Click += btnRegistrarNoSocio_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(296, 63);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AltaNoSocio
            // 
            ClientSize = new Size(417, 280);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(lblDni);
            Controls.Add(txtDni);
            Controls.Add(lblTelefono);
            Controls.Add(txtTelefono);
            Controls.Add(lblDireccion);
            Controls.Add(txtDireccion);
            Controls.Add(lblMail);
            Controls.Add(txtMail);
            Controls.Add(chbAptoMedico);
            Controls.Add(btnRegistrarNoSocio);
            Controls.Add(btnCancelar);
            Name = "AltaNoSocio";
            Text = "Alta No Socio";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblNombre, lblApellido, lblDni, lblTelefono, lblDireccion, lblMail;
        private TextBox txtNombre, txtApellido, txtDni, txtTelefono, txtDireccion, txtMail;
        private CheckBox chbAptoMedico;
        private Button btnRegistrarNoSocio, btnCancelar;
    }
}
