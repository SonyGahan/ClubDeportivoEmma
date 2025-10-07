namespace ClubDeportivoEmma21.Forms
{
    partial class NoSocioActividad
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
            lblDniNoSocio = new Label();
            txtDniNoSocio = new TextBox();
            lblActividadNoSocio = new Label();
            lblMontoAPagarNoSocio = new Label();
            lblFormaDePagoNoSocio = new Label();
            comboActividades = new ComboBox();
            btnActividadPagar = new Button();
            clbActividadFormaDePago = new CheckedListBox();
            SuspendLayout();
            // 
            // lblDniNoSocio
            // 
            lblDniNoSocio.AutoSize = true;
            lblDniNoSocio.Location = new Point(44, 35);
            lblDniNoSocio.Name = "lblDniNoSocio";
            lblDniNoSocio.Size = new Size(78, 15);
            lblDniNoSocio.TabIndex = 0;
            lblDniNoSocio.Text = "DNI No Socio";
            // 
            // txtDniNoSocio
            // 
            txtDniNoSocio.Location = new Point(143, 32);
            txtDniNoSocio.Name = "txtDniNoSocio";
            txtDniNoSocio.Size = new Size(168, 23);
            txtDniNoSocio.TabIndex = 1;
            txtDniNoSocio.TextChanged += textBox1_TextChanged;
            // 
            // lblActividadNoSocio
            // 
            lblActividadNoSocio.AutoSize = true;
            lblActividadNoSocio.Location = new Point(44, 86);
            lblActividadNoSocio.Name = "lblActividadNoSocio";
            lblActividadNoSocio.Size = new Size(135, 15);
            lblActividadNoSocio.TabIndex = 2;
            lblActividadNoSocio.Text = "Actividades Disponibles:";
            // 
            // lblMontoAPagarNoSocio
            // 
            lblMontoAPagarNoSocio.AutoSize = true;
            lblMontoAPagarNoSocio.Location = new Point(310, 86);
            lblMontoAPagarNoSocio.Name = "lblMontoAPagarNoSocio";
            lblMontoAPagarNoSocio.Size = new Size(85, 15);
            lblMontoAPagarNoSocio.TabIndex = 3;
            lblMontoAPagarNoSocio.Text = "Monto a Pagar";
            // 
            // lblFormaDePagoNoSocio
            // 
            lblFormaDePagoNoSocio.AutoSize = true;
            lblFormaDePagoNoSocio.Location = new Point(310, 121);
            lblFormaDePagoNoSocio.Name = "lblFormaDePagoNoSocio";
            lblFormaDePagoNoSocio.Size = new Size(92, 15);
            lblFormaDePagoNoSocio.TabIndex = 5;
            lblFormaDePagoNoSocio.Text = "Formas de Pago";
            // 
            // comboActividades
            // 
            comboActividades.FormattingEnabled = true;
            comboActividades.Location = new Point(44, 118);
            comboActividades.Name = "comboActividades";
            comboActividades.Size = new Size(147, 23);
            comboActividades.TabIndex = 6;
            // 
            // btnActividadPagar
            // 
            btnActividadPagar.Location = new Point(143, 271);
            btnActividadPagar.Name = "btnActividadPagar";
            btnActividadPagar.Size = new Size(179, 30);
            btnActividadPagar.TabIndex = 7;
            btnActividadPagar.Text = "Realizar Pago";
            btnActividadPagar.UseVisualStyleBackColor = true;
            // 
            // clbActividadFormaDePago
            // 
            clbActividadFormaDePago.FormattingEnabled = true;
            clbActividadFormaDePago.Location = new Point(310, 150);
            clbActividadFormaDePago.Name = "clbActividadFormaDePago";
            clbActividadFormaDePago.Size = new Size(134, 76);
            clbActividadFormaDePago.TabIndex = 8;
            // 
            // NoSocioActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 367);
            Controls.Add(clbActividadFormaDePago);
            Controls.Add(btnActividadPagar);
            Controls.Add(comboActividades);
            Controls.Add(lblFormaDePagoNoSocio);
            Controls.Add(lblMontoAPagarNoSocio);
            Controls.Add(lblActividadNoSocio);
            Controls.Add(txtDniNoSocio);
            Controls.Add(lblDniNoSocio);
            Name = "NoSocioActividad";
            Text = "Inscribir No Socio en Actividad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDniNoSocio;
        private TextBox txtDniNoSocio;
        private Label lblActividadNoSocio;
        private Label lblMontoAPagarNoSocio;
        private Label lblFormaDePagoNoSocio;
        private ComboBox comboActividades;
        private Button btnActividadPagar;
        private CheckedListBox clbActividadFormaDePago;
    }
}