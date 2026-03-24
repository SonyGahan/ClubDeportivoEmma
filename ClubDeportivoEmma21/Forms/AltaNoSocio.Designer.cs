namespace ClubDeportivoEmma21.Forms
{
    partial class AltaNoSocio
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitulo = new Label();
            pnlCuerpo = new Panel();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDni = new Label();
            txtDni = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblMail = new Label();
            txtMail = new TextBox();
            chbAptoMedico = new CheckBox();
            btnRegistrarNoSocio = new Button();
            btnCancelar = new Button();
            pnlHeader.SuspendLayout();
            pnlCuerpo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(58, 80, 107);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(550, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(550, 80);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de No Socio";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCuerpo
            // 
            pnlCuerpo.BackColor = Color.FromArgb(232, 237, 242);
            pnlCuerpo.Controls.Add(lblNombre);
            pnlCuerpo.Controls.Add(txtNombre);
            pnlCuerpo.Controls.Add(lblApellido);
            pnlCuerpo.Controls.Add(txtApellido);
            pnlCuerpo.Controls.Add(lblDni);
            pnlCuerpo.Controls.Add(txtDni);
            pnlCuerpo.Controls.Add(lblTelefono);
            pnlCuerpo.Controls.Add(txtTelefono);
            pnlCuerpo.Controls.Add(lblDireccion);
            pnlCuerpo.Controls.Add(txtDireccion);
            pnlCuerpo.Controls.Add(lblMail);
            pnlCuerpo.Controls.Add(txtMail);
            pnlCuerpo.Controls.Add(chbAptoMedico);
            pnlCuerpo.Controls.Add(btnRegistrarNoSocio);
            pnlCuerpo.Controls.Add(btnCancelar);
            pnlCuerpo.Dock = DockStyle.Fill;
            pnlCuerpo.Location = new Point(0, 80);
            pnlCuerpo.Name = "pnlCuerpo";
            pnlCuerpo.Size = new Size(550, 520);
            pnlCuerpo.TabIndex = 1;
            pnlCuerpo.Paint += pnlCuerpo_Paint;
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(47, 47, 47);
            lblNombre.Location = new Point(50, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(120, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(180, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 25);
            txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblApellido.ForeColor = Color.FromArgb(47, 47, 47);
            lblApellido.Location = new Point(50, 80);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(120, 25);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Font = new Font("Segoe UI", 10F);
            txtApellido.Location = new Point(180, 77);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(300, 25);
            txtApellido.TabIndex = 2;
            // 
            // lblDni
            // 
            lblDni.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDni.ForeColor = Color.FromArgb(47, 47, 47);
            lblDni.Location = new Point(50, 130);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(120, 25);
            lblDni.TabIndex = 3;
            lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.Font = new Font("Segoe UI", 10F);
            txtDni.Location = new Point(180, 127);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(300, 25);
            txtDni.TabIndex = 3;
            // 
            // lblTelefono
            // 
            lblTelefono.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTelefono.ForeColor = Color.FromArgb(47, 47, 47);
            lblTelefono.Location = new Point(50, 180);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(120, 25);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Font = new Font("Segoe UI", 10F);
            txtTelefono.Location = new Point(180, 177);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(300, 25);
            txtTelefono.TabIndex = 4;
            // 
            // lblDireccion
            // 
            lblDireccion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDireccion.ForeColor = Color.FromArgb(47, 47, 47);
            lblDireccion.Location = new Point(50, 230);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(120, 25);
            lblDireccion.TabIndex = 5;
            lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Font = new Font("Segoe UI", 10F);
            txtDireccion.Location = new Point(180, 227);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(300, 25);
            txtDireccion.TabIndex = 5;
            // 
            // lblMail
            // 
            lblMail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMail.ForeColor = Color.FromArgb(47, 47, 47);
            lblMail.Location = new Point(50, 280);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(120, 25);
            lblMail.TabIndex = 6;
            lblMail.Text = "Mail:";
            // 
            // txtMail
            // 
            txtMail.BorderStyle = BorderStyle.FixedSingle;
            txtMail.Font = new Font("Segoe UI", 10F);
            txtMail.Location = new Point(180, 277);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(300, 25);
            txtMail.TabIndex = 6;
            // 
            // chbAptoMedico
            // 
            chbAptoMedico.AutoSize = true;
            chbAptoMedico.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chbAptoMedico.ForeColor = Color.FromArgb(47, 47, 47);
            chbAptoMedico.Location = new Point(180, 325);
            chbAptoMedico.Name = "chbAptoMedico";
            chbAptoMedico.Size = new Size(218, 23);
            chbAptoMedico.TabIndex = 7;
            chbAptoMedico.Text = "Presenta Apto Médico Físico";
            chbAptoMedico.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarNoSocio
            // 
            btnRegistrarNoSocio.BackColor = Color.FromArgb(90, 113, 132);
            btnRegistrarNoSocio.Cursor = Cursors.Hand;
            btnRegistrarNoSocio.FlatAppearance.BorderSize = 0;
            btnRegistrarNoSocio.FlatStyle = FlatStyle.Flat;
            btnRegistrarNoSocio.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrarNoSocio.ForeColor = Color.White;
            btnRegistrarNoSocio.Location = new Point(300, 400);
            btnRegistrarNoSocio.Name = "btnRegistrarNoSocio";
            btnRegistrarNoSocio.Size = new Size(180, 50);
            btnRegistrarNoSocio.TabIndex = 8;
            btnRegistrarNoSocio.Text = "REGISTRAR";
            btnRegistrarNoSocio.UseVisualStyleBackColor = false;
            btnRegistrarNoSocio.Click += btnRegistrarNoSocio_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(231, 215, 193);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(47, 47, 47);
            btnCancelar.Location = new Point(70, 400);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 50);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AltaNoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 600);
            Controls.Add(pnlCuerpo);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AltaNoSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de No Socio";
            Load += AltaNoSocio_Load;
            pnlHeader.ResumeLayout(false);
            pnlCuerpo.ResumeLayout(false);
            pnlCuerpo.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.CheckBox chbAptoMedico;
        private System.Windows.Forms.Button btnRegistrarNoSocio;
        private System.Windows.Forms.Button btnCancelar;
    }
}