namespace ClubDeportivoEmma21.Forms
{
    partial class FormSeleccionTipoAlta
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
            lblInstruccion = new Label();
            btnAltaSocio = new Button();
            btnAltaNoSocio = new Button();
            btnVolver = new Button();
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
            pnlHeader.Size = new Size(450, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(450, 70);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Tipo de Registro";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCuerpo
            // 
            pnlCuerpo.BackColor = Color.FromArgb(232, 237, 242);
            pnlCuerpo.Controls.Add(lblInstruccion);
            pnlCuerpo.Controls.Add(btnAltaSocio);
            pnlCuerpo.Controls.Add(btnAltaNoSocio);
            pnlCuerpo.Controls.Add(btnVolver);
            pnlCuerpo.Dock = DockStyle.Fill;
            pnlCuerpo.Location = new Point(0, 70);
            pnlCuerpo.Name = "pnlCuerpo";
            pnlCuerpo.Size = new Size(450, 280);
            pnlCuerpo.TabIndex = 1;
            pnlCuerpo.Paint += pnlCuerpo_Paint;
            // 
            // lblInstruccion
            // 
            lblInstruccion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblInstruccion.ForeColor = Color.FromArgb(47, 47, 47);
            lblInstruccion.Location = new Point(50, 25);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(350, 30);
            lblInstruccion.TabIndex = 0;
            lblInstruccion.Text = "¿Cómo desea registrar al nuevo cliente?";
            lblInstruccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAltaSocio
            // 
            btnAltaSocio.BackColor = Color.FromArgb(90, 113, 132);
            btnAltaSocio.Cursor = Cursors.Hand;
            btnAltaSocio.FlatAppearance.BorderSize = 0;
            btnAltaSocio.FlatStyle = FlatStyle.Flat;
            btnAltaSocio.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAltaSocio.ForeColor = Color.White;
            btnAltaSocio.Location = new Point(75, 75);
            btnAltaSocio.Name = "btnAltaSocio";
            btnAltaSocio.Size = new Size(300, 50);
            btnAltaSocio.TabIndex = 1;
            btnAltaSocio.Text = "NUEVO SOCIO";
            btnAltaSocio.UseVisualStyleBackColor = false;
            btnAltaSocio.Click += btnAltaSocio_Click;
            // 
            // btnAltaNoSocio
            // 
            btnAltaNoSocio.BackColor = Color.FromArgb(90, 113, 132);
            btnAltaNoSocio.Cursor = Cursors.Hand;
            btnAltaNoSocio.FlatAppearance.BorderSize = 0;
            btnAltaNoSocio.FlatStyle = FlatStyle.Flat;
            btnAltaNoSocio.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAltaNoSocio.ForeColor = Color.White;
            btnAltaNoSocio.Location = new Point(75, 140);
            btnAltaNoSocio.Name = "btnAltaNoSocio";
            btnAltaNoSocio.Size = new Size(300, 50);
            btnAltaNoSocio.TabIndex = 2;
            btnAltaNoSocio.Text = "NUEVO NO SOCIO";
            btnAltaNoSocio.UseVisualStyleBackColor = false;
            btnAltaNoSocio.Click += btnAltaNoSocio_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(231, 215, 193);
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVolver.ForeColor = Color.FromArgb(47, 47, 47);
            btnVolver.Location = new Point(150, 215);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(150, 40);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "CANCELAR";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormSeleccionTipoAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 350);
            Controls.Add(pnlCuerpo);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormSeleccionTipoAlta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selección de Alta - Club Emma 21";
            pnlHeader.ResumeLayout(false);
            pnlCuerpo.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Button btnAltaSocio;
        private System.Windows.Forms.Button btnAltaNoSocio;
        private System.Windows.Forms.Button btnVolver;
    }
}