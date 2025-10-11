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
            lblVencimientoSocio = new Label();
            lblMontoSocio = new Label();
            lblFormaDePagoSocio = new Label();
            clbOpcionDePagoSocio = new CheckedListBox();
            btnPagoSocio = new Button();
            txtVencimiento = new TextBox();
            txtMontoCuota = new TextBox();
            btnPagoSocioCancelar = new Button();
            lblNombreSocio = new Label();
            btnPagoSocioBuscar = new Button();
            lblDniSocio = new Label();
            txtDniCuotaSocio = new TextBox();
            SuspendLayout();
            // 
            // lblVencimientoSocio
            // 
            lblVencimientoSocio.AutoSize = true;
            lblVencimientoSocio.Location = new Point(49, 79);
            lblVencimientoSocio.Name = "lblVencimientoSocio";
            lblVencimientoSocio.Size = new Size(124, 15);
            lblVencimientoSocio.TabIndex = 1;
            lblVencimientoSocio.Text = "Próximo Vencimiento:";
            // 
            // lblMontoSocio
            // 
            lblMontoSocio.AutoSize = true;
            lblMontoSocio.Location = new Point(49, 116);
            lblMontoSocio.Name = "lblMontoSocio";
            lblMontoSocio.Size = new Size(88, 15);
            lblMontoSocio.TabIndex = 2;
            lblMontoSocio.Text = "Monto a Pagar:";
            // 
            // lblFormaDePagoSocio
            // 
            lblFormaDePagoSocio.AutoSize = true;
            lblFormaDePagoSocio.Location = new Point(49, 147);
            lblFormaDePagoSocio.Name = "lblFormaDePagoSocio";
            lblFormaDePagoSocio.Size = new Size(95, 15);
            lblFormaDePagoSocio.TabIndex = 3;
            lblFormaDePagoSocio.Text = "Formas de Pago:";
            // 
            // clbOpcionDePagoSocio
            // 
            clbOpcionDePagoSocio.FormattingEnabled = true;
            clbOpcionDePagoSocio.Location = new Point(49, 168);
            clbOpcionDePagoSocio.Name = "clbOpcionDePagoSocio";
            clbOpcionDePagoSocio.Size = new Size(124, 58);
            clbOpcionDePagoSocio.TabIndex = 4;
            // 
            // btnPagoSocio
            // 
            btnPagoSocio.Location = new Point(313, 69);
            btnPagoSocio.Name = "btnPagoSocio";
            btnPagoSocio.Size = new Size(94, 29);
            btnPagoSocio.TabIndex = 5;
            btnPagoSocio.Text = "Realizar Pago";
            btnPagoSocio.UseVisualStyleBackColor = true;
            btnPagoSocio.Click += btnPagoSocio_Click;
            // 
            // txtVencimiento
            // 
            txtVencimiento.BackColor = Color.Beige;
            txtVencimiento.Location = new Point(182, 74);
            txtVencimiento.Name = "txtVencimiento";
            txtVencimiento.ReadOnly = true;
            txtVencimiento.Size = new Size(100, 23);
            txtVencimiento.TabIndex = 8;
            // 
            // txtMontoCuota
            // 
            txtMontoCuota.BackColor = Color.Beige;
            txtMontoCuota.Location = new Point(182, 110);
            txtMontoCuota.Name = "txtMontoCuota";
            txtMontoCuota.ReadOnly = true;
            txtMontoCuota.Size = new Size(100, 23);
            txtMontoCuota.TabIndex = 9;
            // 
            // btnPagoSocioCancelar
            // 
            btnPagoSocioCancelar.Location = new Point(313, 109);
            btnPagoSocioCancelar.Name = "btnPagoSocioCancelar";
            btnPagoSocioCancelar.Size = new Size(94, 28);
            btnPagoSocioCancelar.TabIndex = 10;
            btnPagoSocioCancelar.Text = "Cancelar";
            btnPagoSocioCancelar.UseVisualStyleBackColor = true;
            btnPagoSocioCancelar.Click += btnPagoSocioCancelar_Click;
            // 
            // lblNombreSocio
            // 
            lblNombreSocio.AutoSize = true;
            lblNombreSocio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombreSocio.ForeColor = Color.DarkBlue;
            lblNombreSocio.Location = new Point(49, 58);
            lblNombreSocio.Name = "lblNombreSocio";
            lblNombreSocio.Size = new Size(0, 15);
            lblNombreSocio.TabIndex = 11;
            // 
            // btnPagoSocioBuscar
            // 
            btnPagoSocioBuscar.Location = new Point(313, 25);
            btnPagoSocioBuscar.Name = "btnPagoSocioBuscar";
            btnPagoSocioBuscar.Size = new Size(94, 27);
            btnPagoSocioBuscar.TabIndex = 12;
            btnPagoSocioBuscar.Text = "Buscar";
            btnPagoSocioBuscar.UseVisualStyleBackColor = true;
            btnPagoSocioBuscar.Click += btnPagoSocioBuscar_Click;
            // 
            // lblDniSocio
            // 
            lblDniSocio.AutoSize = true;
            lblDniSocio.Location = new Point(121, 31);
            lblDniSocio.Name = "lblDniSocio";
            lblDniSocio.Size = new Size(30, 15);
            lblDniSocio.TabIndex = 13;
            lblDniSocio.Text = "DNI:";
            // 
            // txtDniCuotaSocio
            // 
            txtDniCuotaSocio.Location = new Point(164, 26);
            txtDniCuotaSocio.Name = "txtDniCuotaSocio";
            txtDniCuotaSocio.Size = new Size(118, 23);
            txtDniCuotaSocio.TabIndex = 14;
            // 
            // PagoCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 261);
            Controls.Add(txtDniCuotaSocio);
            Controls.Add(lblDniSocio);
            Controls.Add(btnPagoSocioBuscar);
            Controls.Add(lblNombreSocio);
            Controls.Add(btnPagoSocioCancelar);
            Controls.Add(txtMontoCuota);
            Controls.Add(txtVencimiento);
            Controls.Add(btnPagoSocio);
            Controls.Add(clbOpcionDePagoSocio);
            Controls.Add(lblFormaDePagoSocio);
            Controls.Add(lblMontoSocio);
            Controls.Add(lblVencimientoSocio);
            Name = "PagoCuota";
            Text = "Registrar Pago Cuota";
            Load += PagoCuota_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVencimientoSocio;
        private Label lblMontoSocio;
        private Label lblFormaDePagoSocio;
        private CheckedListBox clbOpcionDePagoSocio;
        private Button btnPagoSocio;
        private TextBox txtVencimiento;
        private TextBox txtMontoCuota;
        private Button btnPagoSocioCancelar;
        private Label lblNombreSocio;
        private Button btnPagoSocioBuscar;
        private Label lblDniSocio;
        private TextBox txtDniCuotaSocio;
    }
}
