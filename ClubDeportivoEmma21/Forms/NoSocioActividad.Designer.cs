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
            btnBuscarDniActividad = new Button();
            btnCancelarDniActividad = new Button();
            textBox1 = new TextBox();
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
            lblActividadNoSocio.Location = new Point(218, 110);
            lblActividadNoSocio.Name = "lblActividadNoSocio";
            lblActividadNoSocio.Size = new Size(135, 15);
            lblActividadNoSocio.TabIndex = 2;
            lblActividadNoSocio.Text = "Actividades Disponibles:";
            // 
            // lblMontoAPagarNoSocio
            // 
            lblMontoAPagarNoSocio.AutoSize = true;
            lblMontoAPagarNoSocio.Location = new Point(44, 75);
            lblMontoAPagarNoSocio.Name = "lblMontoAPagarNoSocio";
            lblMontoAPagarNoSocio.Size = new Size(88, 15);
            lblMontoAPagarNoSocio.TabIndex = 3;
            lblMontoAPagarNoSocio.Text = "Monto a Pagar:";
            // 
            // lblFormaDePagoNoSocio
            // 
            lblFormaDePagoNoSocio.AutoSize = true;
            lblFormaDePagoNoSocio.Location = new Point(41, 111);
            lblFormaDePagoNoSocio.Name = "lblFormaDePagoNoSocio";
            lblFormaDePagoNoSocio.Size = new Size(95, 15);
            lblFormaDePagoNoSocio.TabIndex = 5;
            lblFormaDePagoNoSocio.Text = "Formas de Pago:";
            // 
            // comboActividades
            // 
            comboActividades.FormattingEnabled = true;
            comboActividades.Location = new Point(218, 132);
            comboActividades.Name = "comboActividades";
            comboActividades.Size = new Size(135, 23);
            comboActividades.TabIndex = 6;
            // 
            // btnActividadPagar
            // 
            btnActividadPagar.Location = new Point(382, 103);
            btnActividadPagar.Name = "btnActividadPagar";
            btnActividadPagar.Size = new Size(93, 30);
            btnActividadPagar.TabIndex = 7;
            btnActividadPagar.Text = "Realizar Pago";
            btnActividadPagar.UseVisualStyleBackColor = true;
            // 
            // clbActividadFormaDePago
            // 
            clbActividadFormaDePago.FormattingEnabled = true;
            clbActividadFormaDePago.Location = new Point(44, 132);
            clbActividadFormaDePago.Name = "clbActividadFormaDePago";
            clbActividadFormaDePago.Size = new Size(134, 76);
            clbActividadFormaDePago.TabIndex = 8;
            // 
            // btnBuscarDniActividad
            // 
            btnBuscarDniActividad.Location = new Point(382, 28);
            btnBuscarDniActividad.Name = "btnBuscarDniActividad";
            btnBuscarDniActividad.Size = new Size(93, 27);
            btnBuscarDniActividad.TabIndex = 9;
            btnBuscarDniActividad.Text = "Buscar";
            btnBuscarDniActividad.UseVisualStyleBackColor = true;
            // 
            // btnCancelarDniActividad
            // 
            btnCancelarDniActividad.Location = new Point(382, 65);
            btnCancelarDniActividad.Name = "btnCancelarDniActividad";
            btnCancelarDniActividad.Size = new Size(93, 27);
            btnCancelarDniActividad.TabIndex = 10;
            btnCancelarDniActividad.Text = "Cancelar";
            btnCancelarDniActividad.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(56, 23);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // NoSocioActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 326);
            Controls.Add(textBox1);
            Controls.Add(btnCancelarDniActividad);
            Controls.Add(btnBuscarDniActividad);
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
        private Button btnBuscarDniActividad;
        private Button btnCancelarDniActividad;
        private TextBox textBox1;
    }
}