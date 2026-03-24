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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.lblDniSocio = new System.Windows.Forms.Label();
            this.txtDniCuotaSocio = new System.Windows.Forms.TextBox();
            this.btnPagoSocioBuscar = new System.Windows.Forms.Button();
            this.lblNombreTitulo = new System.Windows.Forms.Label();
            this.lblNombreSocio = new System.Windows.Forms.Label();
            this.lblVencimientoSocio = new System.Windows.Forms.Label();
            this.txtVencimiento = new System.Windows.Forms.TextBox();
            this.lblMontoSocio = new System.Windows.Forms.Label();
            this.txtMontoCuota = new System.Windows.Forms.TextBox();
            this.lblFormaDePagoSocio = new System.Windows.Forms.Label();
            this.clbOpcionDePagoSocio = new System.Windows.Forms.CheckedListBox();
            this.btnPagoSocio = new System.Windows.Forms.Button();
            this.btnPagoSocioCancelar = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlCuerpo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(550, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(550, 80);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cobro de Cuota Social";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.pnlCuerpo.Controls.Add(this.lblDniSocio);
            this.pnlCuerpo.Controls.Add(this.txtDniCuotaSocio);
            this.pnlCuerpo.Controls.Add(this.btnPagoSocioBuscar);
            this.pnlCuerpo.Controls.Add(this.lblNombreTitulo);
            this.pnlCuerpo.Controls.Add(this.lblNombreSocio);
            this.pnlCuerpo.Controls.Add(this.lblVencimientoSocio);
            this.pnlCuerpo.Controls.Add(this.txtVencimiento);
            this.pnlCuerpo.Controls.Add(this.lblMontoSocio);
            this.pnlCuerpo.Controls.Add(this.txtMontoCuota);
            this.pnlCuerpo.Controls.Add(this.lblFormaDePagoSocio);
            this.pnlCuerpo.Controls.Add(this.clbOpcionDePagoSocio);
            this.pnlCuerpo.Controls.Add(this.btnPagoSocio);
            this.pnlCuerpo.Controls.Add(this.btnPagoSocioCancelar);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 80);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(550, 470);
            this.pnlCuerpo.TabIndex = 1;
            // 
            // lblDniSocio
            // 
            this.lblDniSocio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDniSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblDniSocio.Location = new System.Drawing.Point(40, 30);
            this.lblDniSocio.Name = "lblDniSocio";
            this.lblDniSocio.Size = new System.Drawing.Size(120, 25);
            this.lblDniSocio.TabIndex = 0;
            this.lblDniSocio.Text = "DNI del Socio:";
            // 
            // txtDniCuotaSocio
            // 
            this.txtDniCuotaSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDniCuotaSocio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDniCuotaSocio.Location = new System.Drawing.Point(170, 27);
            this.txtDniCuotaSocio.Name = "txtDniCuotaSocio";
            this.txtDniCuotaSocio.Size = new System.Drawing.Size(180, 25);
            this.txtDniCuotaSocio.TabIndex = 1;
            // 
            // btnPagoSocioBuscar
            // 
            this.btnPagoSocioBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.btnPagoSocioBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagoSocioBuscar.FlatAppearance.BorderSize = 0;
            this.btnPagoSocioBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagoSocioBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPagoSocioBuscar.ForeColor = System.Drawing.Color.White;
            this.btnPagoSocioBuscar.Location = new System.Drawing.Point(370, 25);
            this.btnPagoSocioBuscar.Name = "btnPagoSocioBuscar";
            this.btnPagoSocioBuscar.Size = new System.Drawing.Size(120, 30);
            this.btnPagoSocioBuscar.TabIndex = 2;
            this.btnPagoSocioBuscar.Text = "BUSCAR";
            this.btnPagoSocioBuscar.UseVisualStyleBackColor = false;
            this.btnPagoSocioBuscar.Click += new System.EventHandler(this.btnPagoSocioBuscar_Click);
            // 
            // lblNombreTitulo
            // 
            this.lblNombreTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblNombreTitulo.Location = new System.Drawing.Point(40, 85);
            this.lblNombreTitulo.Name = "lblNombreTitulo";
            this.lblNombreTitulo.Size = new System.Drawing.Size(120, 25);
            this.lblNombreTitulo.TabIndex = 3;
            this.lblNombreTitulo.Text = "Nombre:";
            // 
            // lblNombreSocio
            // 
            this.lblNombreSocio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNombreSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.lblNombreSocio.Location = new System.Drawing.Point(170, 85);
            this.lblNombreSocio.Name = "lblNombreSocio";
            this.lblNombreSocio.Size = new System.Drawing.Size(320, 25);
            this.lblNombreSocio.TabIndex = 4;
            this.lblNombreSocio.Text = "-";
            // 
            // lblVencimientoSocio
            // 
            this.lblVencimientoSocio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblVencimientoSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblVencimientoSocio.Location = new System.Drawing.Point(40, 140);
            this.lblVencimientoSocio.Name = "lblVencimientoSocio";
            this.lblVencimientoSocio.Size = new System.Drawing.Size(120, 25);
            this.lblVencimientoSocio.TabIndex = 5;
            this.lblVencimientoSocio.Text = "Vencimiento:";
            // 
            // txtVencimiento
            // 
            this.txtVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVencimiento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtVencimiento.Location = new System.Drawing.Point(170, 137);
            this.txtVencimiento.Name = "txtVencimiento";
            this.txtVencimiento.ReadOnly = true;
            this.txtVencimiento.Size = new System.Drawing.Size(180, 25);
            this.txtVencimiento.TabIndex = 6;
            // 
            // lblMontoSocio
            // 
            this.lblMontoSocio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMontoSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblMontoSocio.Location = new System.Drawing.Point(40, 195);
            this.lblMontoSocio.Name = "lblMontoSocio";
            this.lblMontoSocio.Size = new System.Drawing.Size(120, 25);
            this.lblMontoSocio.TabIndex = 7;
            this.lblMontoSocio.Text = "Monto a Pagar:";
            // 
            // txtMontoCuota
            // 
            this.txtMontoCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoCuota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtMontoCuota.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtMontoCuota.Location = new System.Drawing.Point(170, 192);
            this.txtMontoCuota.Name = "txtMontoCuota";
            this.txtMontoCuota.ReadOnly = true;
            this.txtMontoCuota.Size = new System.Drawing.Size(180, 29);
            this.txtMontoCuota.TabIndex = 8;
            // 
            // lblFormaDePagoSocio
            // 
            this.lblFormaDePagoSocio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFormaDePagoSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblFormaDePagoSocio.Location = new System.Drawing.Point(40, 250);
            this.lblFormaDePagoSocio.Name = "lblFormaDePagoSocio";
            this.lblFormaDePagoSocio.Size = new System.Drawing.Size(120, 25);
            this.lblFormaDePagoSocio.TabIndex = 9;
            this.lblFormaDePagoSocio.Text = "Forma de Pago:";
            // 
            // clbOpcionDePagoSocio
            // 
            this.clbOpcionDePagoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbOpcionDePagoSocio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clbOpcionDePagoSocio.FormattingEnabled = true;
            this.clbOpcionDePagoSocio.Location = new System.Drawing.Point(170, 250);
            this.clbOpcionDePagoSocio.Name = "clbOpcionDePagoSocio";
            this.clbOpcionDePagoSocio.Size = new System.Drawing.Size(180, 74);
            this.clbOpcionDePagoSocio.TabIndex = 10;
            // 
            // btnPagoSocio
            // 
            this.btnPagoSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(113)))), ((int)(((byte)(132)))));
            this.btnPagoSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagoSocio.Enabled = false;
            this.btnPagoSocio.FlatAppearance.BorderSize = 0;
            this.btnPagoSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagoSocio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPagoSocio.ForeColor = System.Drawing.Color.White;
            this.btnPagoSocio.Location = new System.Drawing.Point(300, 370);
            this.btnPagoSocio.Name = "btnPagoSocio";
            this.btnPagoSocio.Size = new System.Drawing.Size(190, 55);
            this.btnPagoSocio.TabIndex = 11;
            this.btnPagoSocio.Text = "REGISTRAR PAGO";
            this.btnPagoSocio.UseVisualStyleBackColor = false;
            this.btnPagoSocio.Click += new System.EventHandler(this.btnPagoSocio_Click);
            // 
            // btnPagoSocioCancelar
            // 
            this.btnPagoSocioCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(215)))), ((int)(((byte)(193)))));
            this.btnPagoSocioCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagoSocioCancelar.FlatAppearance.BorderSize = 0;
            this.btnPagoSocioCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagoSocioCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPagoSocioCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnPagoSocioCancelar.Location = new System.Drawing.Point(40, 370);
            this.btnPagoSocioCancelar.Name = "btnPagoSocioCancelar";
            this.btnPagoSocioCancelar.Size = new System.Drawing.Size(190, 55);
            this.btnPagoSocioCancelar.TabIndex = 12;
            this.btnPagoSocioCancelar.Text = "CANCELAR";
            this.btnPagoSocioCancelar.UseVisualStyleBackColor = false;
            this.btnPagoSocioCancelar.Click += new System.EventHandler(this.btnPagoSocioCancelar_Click);
            // 
            // PagoCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 550);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PagoCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobro de Cuotas - Club Emma 21";
            this.Load += new System.EventHandler(this.PagoCuota_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlCuerpo.ResumeLayout(false);
            this.pnlCuerpo.PerformLayout();
            this.ResumeLayout(false);

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