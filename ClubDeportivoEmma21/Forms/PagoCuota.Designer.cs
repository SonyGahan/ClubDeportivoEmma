namespace ClubDeportivoEmma21.Forms
{
    partial class PagoCuota
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDniCuotaSocio = new Label();
            lblVencimientoSocio = new Label();
            lblMontoSocio = new Label();
            lblFormaDePagoSocio = new Label();
            clbOpcionDePagoSocio = new CheckedListBox();
            btnPagoSocio = new Button();
            txtDniCuotaSocio = new TextBox();
            btnPagoSocioBuscar = new Button();
            txtVencimiento = new TextBox();
            txtMontoCuota = new TextBox();
            btnPagoSocioCancelar = new Button();
            lblNombreSocio = new Label();
            SuspendLayout();
            // 
            // lblDniCuotaSocio
            // 
            lblDniCuotaSocio.AutoSize = true;
            lblDniCuotaSocio.Location = new Point(49, 36);
            lblDniCuotaSocio.Name = "lblDniCuotaSocio";
            lblDniCuotaSocio.Size = new Size(62, 15);
            lblDniCuotaSocio.TabIndex = 0;
            lblDniCuotaSocio.Text = "DNI Socio:";
            // 
            // lblVencimientoSocio
            // 
            lblVencimientoSocio.AutoSize = true;
            lblVencimientoSocio.Location = new Point(49, 75);
            lblVencimientoSocio.Name = "lblVencimientoSocio";
            lblVencimientoSocio.Size = new Size(124, 15);
            lblVencimientoSocio.TabIndex = 1;
            lblVencimientoSocio.Text = "Próximo Vencimiento:";
            // 
            // lblMontoSocio
            // 
            lblMontoSocio.AutoSize = true;
            lblMontoSocio.Location = new Point(49, 106);
            lblMontoSocio.Name = "lblMontoSocio";
            lblMontoSocio.Size = new Size(88, 15);
            lblMontoSocio.TabIndex = 2;
            lblMontoSocio.Text = "Monto a Pagar:";
            // 
            // lblFormaDePagoSocio
            // 
            lblFormaDePagoSocio.AutoSize = true;
            lblFormaDePagoSocio.Location = new Point(49, 144);
            lblFormaDePagoSocio.Name = "lblFormaDePagoSocio";
            lblFormaDePagoSocio.Size = new Size(95, 15);
            lblFormaDePagoSocio.TabIndex = 3;
            lblFormaDePagoSocio.Text = "Formas de Pago:";
            // 
            // clbOpcionDePagoSocio
            // 
            clbOpcionDePagoSocio.FormattingEnabled = true;
            clbOpcionDePagoSocio.Location = new Point(49, 165);
            clbOpcionDePagoSocio.Name = "clbOpcionDePagoSocio";
            clbOpcionDePagoSocio.Size = new Size(124, 94);
            clbOpcionDePagoSocio.TabIndex = 4;
            // 
            // btnPagoSocio
            // 
            btnPagoSocio.Location = new Point(319, 104);
            btnPagoSocio.Name = "btnPagoSocio";
            btnPagoSocio.Size = new Size(94, 29);
            btnPagoSocio.TabIndex = 5;
            btnPagoSocio.Text = "Realizar Pago";
            btnPagoSocio.UseVisualStyleBackColor = true;
            btnPagoSocio.Click += btnPagoSocio_Click;
            // 
            // txtDniCuotaSocio
            // 
            txtDniCuotaSocio.Location = new Point(119, 27);
            txtDniCuotaSocio.Name = "txtDniCuotaSocio";
            txtDniCuotaSocio.Size = new Size(156, 23);
            txtDniCuotaSocio.TabIndex = 6;
            txtDniCuotaSocio.TextChanged += textBox1_TextChanged;
            // 
            // btnPagoSocioBuscar
            // 
            btnPagoSocioBuscar.Location = new Point(319, 24);
            btnPagoSocioBuscar.Name = "btnPagoSocioBuscar";
            btnPagoSocioBuscar.Size = new Size(94, 27);
            btnPagoSocioBuscar.TabIndex = 7;
            btnPagoSocioBuscar.Text = "Buscar";
            btnPagoSocioBuscar.UseVisualStyleBackColor = true;
            btnPagoSocioBuscar.Click += btnPagoSocioBuscar_Click;
            // 
            // txtVencimiento
            // 
            txtVencimiento.BackColor = Color.Beige;
            txtVencimiento.Location = new Point(175, 67);
            txtVencimiento.Name = "txtVencimiento";
            txtVencimiento.ReadOnly = true;
            txtVencimiento.Size = new Size(100, 23);
            txtVencimiento.TabIndex = 8;
            // 
            // txtMontoCuota
            // 
            txtMontoCuota.BackColor = Color.Beige;
            txtMontoCuota.Location = new Point(175, 103);
            txtMontoCuota.Name = "txtMontoCuota";
            txtMontoCuota.ReadOnly = true;
            txtMontoCuota.Size = new Size(100, 23);
            txtMontoCuota.TabIndex = 9;
            // 
            // btnPagoSocioCancelar
            // 
            btnPagoSocioCancelar.Location = new Point(319, 62);
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
            lblNombreSocio.Location = new Point(49, 59);
            lblNombreSocio.Name = "lblNombreSocio";
            lblNombreSocio.Size = new Size(0, 15);
            lblNombreSocio.TabIndex = 11;
            // 
            // PagoCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 302);
            Controls.Add(lblNombreSocio);
            Controls.Add(btnPagoSocioCancelar);
            Controls.Add(txtMontoCuota);
            Controls.Add(txtVencimiento);
            Controls.Add(btnPagoSocioBuscar);
            Controls.Add(txtDniCuotaSocio);
            Controls.Add(btnPagoSocio);
            Controls.Add(clbOpcionDePagoSocio);
            Controls.Add(lblFormaDePagoSocio);
            Controls.Add(lblMontoSocio);
            Controls.Add(lblVencimientoSocio);
            Controls.Add(lblDniCuotaSocio);
            Name = "PagoCuota";
            Text = "Registrar Pago Cuota";
            Load += PagoCuota_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDniCuotaSocio;
        private Label lblVencimientoSocio;
        private Label lblMontoSocio;
        private Label lblFormaDePagoSocio;
        private CheckedListBox clbOpcionDePagoSocio;
        private Button btnPagoSocio;
        private TextBox txtDniCuotaSocio;
        private Button btnPagoSocioBuscar;
        private TextBox txtVencimiento;
        private TextBox txtMontoCuota;
        private Button btnPagoSocioCancelar;
        private Label lblNombreSocio;
    }
}