namespace ClubDeportivoEmma21.Forms
{
    partial class PagoCuota
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
            lblDniSocio = new Label();
            txtDniCuotaSocio = new TextBox();
            btnPagoSocioBuscar = new Button();
            lblNombreTitulo = new Label();
            lblNombreSocio = new Label();
            lblVencimientoSocio = new Label();
            txtVencimiento = new TextBox();
            lblMontoSocio = new Label();
            txtMontoCuota = new TextBox();
            lblFormaDePagoSocio = new Label();
            clbOpcionDePagoSocio = new CheckedListBox();
            btnPagoSocio = new Button();
            btnPagoSocioCancelar = new Button();
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
            lblTitulo.Text = "Cobro de Cuota Social";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCuerpo
            // 
            pnlCuerpo.BackColor = Color.FromArgb(232, 237, 242);
            pnlCuerpo.Controls.Add(lblDniSocio);
            pnlCuerpo.Controls.Add(txtDniCuotaSocio);
            pnlCuerpo.Controls.Add(btnPagoSocioBuscar);
            pnlCuerpo.Controls.Add(lblNombreTitulo);
            pnlCuerpo.Controls.Add(lblNombreSocio);
            pnlCuerpo.Controls.Add(lblVencimientoSocio);
            pnlCuerpo.Controls.Add(txtVencimiento);
            pnlCuerpo.Controls.Add(lblMontoSocio);
            pnlCuerpo.Controls.Add(txtMontoCuota);
            pnlCuerpo.Controls.Add(lblFormaDePagoSocio);
            pnlCuerpo.Controls.Add(clbOpcionDePagoSocio);
            pnlCuerpo.Controls.Add(btnPagoSocio);
            pnlCuerpo.Controls.Add(btnPagoSocioCancelar);
            pnlCuerpo.Dock = DockStyle.Fill;
            pnlCuerpo.Location = new Point(0, 80);
            pnlCuerpo.Name = "pnlCuerpo";
            pnlCuerpo.Size = new Size(550, 470);
            pnlCuerpo.TabIndex = 1;
            pnlCuerpo.Paint += pnlCuerpo_Paint;
            // 
            // lblDniSocio
            // 
            lblDniSocio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDniSocio.ForeColor = Color.FromArgb(47, 47, 47);
            lblDniSocio.Location = new Point(40, 30);
            lblDniSocio.Name = "lblDniSocio";
            lblDniSocio.Size = new Size(120, 25);
            lblDniSocio.TabIndex = 0;
            lblDniSocio.Text = "DNI del Socio:";
            // 
            // txtDniCuotaSocio
            // 
            txtDniCuotaSocio.BorderStyle = BorderStyle.FixedSingle;
            txtDniCuotaSocio.Font = new Font("Segoe UI", 10F);
            txtDniCuotaSocio.Location = new Point(170, 27);
            txtDniCuotaSocio.Name = "txtDniCuotaSocio";
            txtDniCuotaSocio.Size = new Size(180, 25);
            txtDniCuotaSocio.TabIndex = 1;
            // 
            // btnPagoSocioBuscar
            // 
            btnPagoSocioBuscar.BackColor = Color.FromArgb(58, 80, 107);
            btnPagoSocioBuscar.Cursor = Cursors.Hand;
            btnPagoSocioBuscar.FlatAppearance.BorderSize = 0;
            btnPagoSocioBuscar.FlatStyle = FlatStyle.Flat;
            btnPagoSocioBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPagoSocioBuscar.ForeColor = Color.White;
            btnPagoSocioBuscar.Location = new Point(370, 25);
            btnPagoSocioBuscar.Name = "btnPagoSocioBuscar";
            btnPagoSocioBuscar.Size = new Size(120, 30);
            btnPagoSocioBuscar.TabIndex = 2;
            btnPagoSocioBuscar.Text = "BUSCAR";
            btnPagoSocioBuscar.UseVisualStyleBackColor = false;
            btnPagoSocioBuscar.Click += btnPagoSocioBuscar_Click;
            // 
            // lblNombreTitulo
            // 
            lblNombreTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombreTitulo.ForeColor = Color.FromArgb(47, 47, 47);
            lblNombreTitulo.Location = new Point(40, 85);
            lblNombreTitulo.Name = "lblNombreTitulo";
            lblNombreTitulo.Size = new Size(120, 25);
            lblNombreTitulo.TabIndex = 3;
            lblNombreTitulo.Text = "Nombre:";
            // 
            // lblNombreSocio
            // 
            lblNombreSocio.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNombreSocio.ForeColor = Color.FromArgb(58, 80, 107);
            lblNombreSocio.Location = new Point(170, 85);
            lblNombreSocio.Name = "lblNombreSocio";
            lblNombreSocio.Size = new Size(320, 25);
            lblNombreSocio.TabIndex = 4;
            lblNombreSocio.Text = "-";
            // 
            // lblVencimientoSocio
            // 
            lblVencimientoSocio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVencimientoSocio.ForeColor = Color.FromArgb(47, 47, 47);
            lblVencimientoSocio.Location = new Point(40, 140);
            lblVencimientoSocio.Name = "lblVencimientoSocio";
            lblVencimientoSocio.Size = new Size(120, 25);
            lblVencimientoSocio.TabIndex = 5;
            lblVencimientoSocio.Text = "Vencimiento:";
            // 
            // txtVencimiento
            // 
            txtVencimiento.BorderStyle = BorderStyle.FixedSingle;
            txtVencimiento.Font = new Font("Segoe UI", 10F);
            txtVencimiento.Location = new Point(170, 137);
            txtVencimiento.Name = "txtVencimiento";
            txtVencimiento.ReadOnly = true;
            txtVencimiento.Size = new Size(180, 25);
            txtVencimiento.TabIndex = 6;
            // 
            // lblMontoSocio
            // 
            lblMontoSocio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMontoSocio.ForeColor = Color.FromArgb(47, 47, 47);
            lblMontoSocio.Location = new Point(40, 195);
            lblMontoSocio.Name = "lblMontoSocio";
            lblMontoSocio.Size = new Size(120, 25);
            lblMontoSocio.TabIndex = 7;
            lblMontoSocio.Text = "Monto a Pagar:";
            // 
            // txtMontoCuota
            // 
            txtMontoCuota.BorderStyle = BorderStyle.FixedSingle;
            txtMontoCuota.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtMontoCuota.ForeColor = Color.DarkGreen;
            txtMontoCuota.Location = new Point(170, 192);
            txtMontoCuota.Name = "txtMontoCuota";
            txtMontoCuota.ReadOnly = true;
            txtMontoCuota.Size = new Size(180, 29);
            txtMontoCuota.TabIndex = 8;
            // 
            // lblFormaDePagoSocio
            // 
            lblFormaDePagoSocio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFormaDePagoSocio.ForeColor = Color.FromArgb(47, 47, 47);
            lblFormaDePagoSocio.Location = new Point(40, 250);
            lblFormaDePagoSocio.Name = "lblFormaDePagoSocio";
            lblFormaDePagoSocio.Size = new Size(120, 25);
            lblFormaDePagoSocio.TabIndex = 9;
            lblFormaDePagoSocio.Text = "Forma de Pago:";
            // 
            // clbOpcionDePagoSocio
            // 
            clbOpcionDePagoSocio.BorderStyle = BorderStyle.FixedSingle;
            clbOpcionDePagoSocio.Font = new Font("Segoe UI", 9F);
            clbOpcionDePagoSocio.FormattingEnabled = true;
            clbOpcionDePagoSocio.Location = new Point(170, 250);
            clbOpcionDePagoSocio.Name = "clbOpcionDePagoSocio";
            clbOpcionDePagoSocio.Size = new Size(180, 74);
            clbOpcionDePagoSocio.TabIndex = 10;
            // 
            // btnPagoSocio
            // 
            btnPagoSocio.BackColor = Color.FromArgb(90, 113, 132);
            btnPagoSocio.Cursor = Cursors.Hand;
            btnPagoSocio.Enabled = false;
            btnPagoSocio.FlatAppearance.BorderSize = 0;
            btnPagoSocio.FlatStyle = FlatStyle.Flat;
            btnPagoSocio.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPagoSocio.ForeColor = Color.White;
            btnPagoSocio.Location = new Point(300, 370);
            btnPagoSocio.Name = "btnPagoSocio";
            btnPagoSocio.Size = new Size(190, 55);
            btnPagoSocio.TabIndex = 11;
            btnPagoSocio.Text = "REGISTRAR PAGO";
            btnPagoSocio.UseVisualStyleBackColor = false;
            btnPagoSocio.Click += btnPagoSocio_Click;
            // 
            // btnPagoSocioCancelar
            // 
            btnPagoSocioCancelar.BackColor = Color.FromArgb(231, 215, 193);
            btnPagoSocioCancelar.Cursor = Cursors.Hand;
            btnPagoSocioCancelar.FlatAppearance.BorderSize = 0;
            btnPagoSocioCancelar.FlatStyle = FlatStyle.Flat;
            btnPagoSocioCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPagoSocioCancelar.ForeColor = Color.FromArgb(47, 47, 47);
            btnPagoSocioCancelar.Location = new Point(40, 370);
            btnPagoSocioCancelar.Name = "btnPagoSocioCancelar";
            btnPagoSocioCancelar.Size = new Size(190, 55);
            btnPagoSocioCancelar.TabIndex = 12;
            btnPagoSocioCancelar.Text = "CANCELAR";
            btnPagoSocioCancelar.UseVisualStyleBackColor = false;
            btnPagoSocioCancelar.Click += btnPagoSocioCancelar_Click;
            // 
            // PagoCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 550);
            Controls.Add(pnlCuerpo);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "PagoCuota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cobro de Cuotas - Club Emma 21";
            Load += PagoCuota_Load;
            pnlHeader.ResumeLayout(false);
            pnlCuerpo.ResumeLayout(false);
            pnlCuerpo.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Label lblDniSocio;
        private System.Windows.Forms.TextBox txtDniCuotaSocio;
        private System.Windows.Forms.Button btnPagoSocioBuscar;
        private System.Windows.Forms.Label lblNombreTitulo;
        private System.Windows.Forms.Label lblNombreSocio;
        private System.Windows.Forms.Label lblVencimientoSocio;
        private System.Windows.Forms.TextBox txtVencimiento;
        private System.Windows.Forms.Label lblMontoSocio;
        private System.Windows.Forms.TextBox txtMontoCuota;
        private System.Windows.Forms.Label lblFormaDePagoSocio;
        private System.Windows.Forms.CheckedListBox clbOpcionDePagoSocio;
        private System.Windows.Forms.Button btnPagoSocio;
        private System.Windows.Forms.Button btnPagoSocioCancelar;
    }
}