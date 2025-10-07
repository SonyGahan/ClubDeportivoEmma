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
            lblFormaDePagoSocio.Size = new Size(92, 15);
            lblFormaDePagoSocio.TabIndex = 3;
            lblFormaDePagoSocio.Text = "Formas de Pago";
            // 
            // clbOpcionDePagoSocio
            // 
            clbOpcionDePagoSocio.FormattingEnabled = true;
            clbOpcionDePagoSocio.Location = new Point(49, 172);
            clbOpcionDePagoSocio.Name = "clbOpcionDePagoSocio";
            clbOpcionDePagoSocio.Size = new Size(224, 112);
            clbOpcionDePagoSocio.TabIndex = 4;
            // 
            // btnPagoSocio
            // 
            btnPagoSocio.Location = new Point(98, 313);
            btnPagoSocio.Name = "btnPagoSocio";
            btnPagoSocio.Size = new Size(125, 37);
            btnPagoSocio.TabIndex = 5;
            btnPagoSocio.Text = "Realizar Pago";
            btnPagoSocio.UseVisualStyleBackColor = true;
            btnPagoSocio.Click += btnPagoSocio_Click;
            // 
            // txtDniCuotaSocio
            // 
            txtDniCuotaSocio.Location = new Point(117, 28);
            txtDniCuotaSocio.Name = "txtDniCuotaSocio";
            txtDniCuotaSocio.Size = new Size(156, 23);
            txtDniCuotaSocio.TabIndex = 6;
            txtDniCuotaSocio.TextChanged += textBox1_TextChanged;
            // 
            // PagoCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 397);
            Controls.Add(txtDniCuotaSocio);
            Controls.Add(btnPagoSocio);
            Controls.Add(clbOpcionDePagoSocio);
            Controls.Add(lblFormaDePagoSocio);
            Controls.Add(lblMontoSocio);
            Controls.Add(lblVencimientoSocio);
            Controls.Add(lblDniCuotaSocio);
            Name = "PagoCuota";
            Text = "Registrar Pago Cuota";
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
    }
}