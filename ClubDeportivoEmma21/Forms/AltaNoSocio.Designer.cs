namespace ClubDeportivoEmma21.Forms
{
    partial class AltaNoSocio
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
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
            lblDni = new Label();
            txtDni = new TextBox();
            lblActividad = new Label();
            cmbActividad = new ComboBox();
            btnRegistrar = new Button();
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
            pnlHeader.Size = new Size(500, 70);
            pnlHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(500, 70);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Pago Diario";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCuerpo
            // 
            pnlCuerpo.BackColor = Color.FromArgb(232, 237, 242);
            pnlCuerpo.Controls.Add(lblNombre);
            pnlCuerpo.Controls.Add(txtNombre);
            pnlCuerpo.Controls.Add(lblDni);
            pnlCuerpo.Controls.Add(txtDni);
            pnlCuerpo.Controls.Add(lblActividad);
            pnlCuerpo.Controls.Add(cmbActividad);
            pnlCuerpo.Controls.Add(btnRegistrar);
            pnlCuerpo.Controls.Add(btnCancelar);
            pnlCuerpo.Dock = DockStyle.Fill;
            pnlCuerpo.Location = new Point(0, 70);
            pnlCuerpo.Name = "pnlCuerpo";
            pnlCuerpo.Size = new Size(500, 380);
            pnlCuerpo.TabIndex = 0;
            pnlCuerpo.Paint += pnlCuerpo_Paint;
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(50, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre y Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(50, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(400, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblDni
            // 
            lblDni.Location = new Point(50, 100);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(100, 23);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(50, 125);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(180, 23);
            txtDni.TabIndex = 3;
            // 
            // lblActividad
            // 
            lblActividad.Location = new Point(50, 170);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(100, 23);
            lblActividad.TabIndex = 4;
            lblActividad.Text = "Actividad a Realizar:";
            // 
            // cmbActividad
            // 
            cmbActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActividad.Location = new Point(50, 195);
            cmbActividad.Name = "cmbActividad";
            cmbActividad.Size = new Size(400, 23);
            cmbActividad.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(90, 113, 132);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(270, 280);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(180, 50);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "REGISTRAR PAGO";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(231, 215, 193);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(50, 280);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 50);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AltaNoSocio
            // 
            ClientSize = new Size(500, 450);
            Controls.Add(pnlCuerpo);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AltaNoSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alta No Socio - Club Emma 21";
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
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.ComboBox cmbActividad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}