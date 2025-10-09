namespace ClubDeportivoEmma21.Forms
{
    partial class AltaSocio
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
            lblSocioNombre = new Label();
            lblSocioApellido = new Label();
            lblSocioDni = new Label();
            lblSocioTelefono = new Label();
            lblSocioDireccion = new Label();
            lblSocioMail = new Label();
            txtSocioNombre = new TextBox();
            txtSocioApellido = new TextBox();
            txtSocioDni = new TextBox();
            txtSocioTelefono = new TextBox();
            txtSocioDireccion = new TextBox();
            txtSocioMail = new TextBox();
            chbSocioAptoMedico = new CheckBox();
            btnRegistrarSocio = new Button();
            btnCancelarAltaSocio = new Button();
            SuspendLayout();
            // 
            // lblSocioNombre
            // 
            lblSocioNombre.AutoSize = true;
            lblSocioNombre.Location = new Point(59, 29);
            lblSocioNombre.Name = "lblSocioNombre";
            lblSocioNombre.Size = new Size(54, 15);
            lblSocioNombre.TabIndex = 0;
            lblSocioNombre.Text = "Nombre:";
            // 
            // lblSocioApellido
            // 
            lblSocioApellido.AutoSize = true;
            lblSocioApellido.Location = new Point(59, 64);
            lblSocioApellido.Name = "lblSocioApellido";
            lblSocioApellido.Size = new Size(54, 15);
            lblSocioApellido.TabIndex = 1;
            lblSocioApellido.Text = "Apellido:";
            // 
            // lblSocioDni
            // 
            lblSocioDni.AutoSize = true;
            lblSocioDni.Location = new Point(59, 95);
            lblSocioDni.Name = "lblSocioDni";
            lblSocioDni.Size = new Size(30, 15);
            lblSocioDni.TabIndex = 2;
            lblSocioDni.Text = "DNI:";
            // 
            // lblSocioTelefono
            // 
            lblSocioTelefono.AutoSize = true;
            lblSocioTelefono.Location = new Point(59, 130);
            lblSocioTelefono.Name = "lblSocioTelefono";
            lblSocioTelefono.Size = new Size(55, 15);
            lblSocioTelefono.TabIndex = 3;
            lblSocioTelefono.Text = "Teléfono:";
            // 
            // lblSocioDireccion
            // 
            lblSocioDireccion.AutoSize = true;
            lblSocioDireccion.Location = new Point(59, 162);
            lblSocioDireccion.Name = "lblSocioDireccion";
            lblSocioDireccion.Size = new Size(60, 15);
            lblSocioDireccion.TabIndex = 4;
            lblSocioDireccion.Text = "Dirección:";
            // 
            // lblSocioMail
            // 
            lblSocioMail.AutoSize = true;
            lblSocioMail.Location = new Point(59, 195);
            lblSocioMail.Name = "lblSocioMail";
            lblSocioMail.Size = new Size(33, 15);
            lblSocioMail.TabIndex = 5;
            lblSocioMail.Text = "Mail:";
            // 
            // txtSocioNombre
            // 
            txtSocioNombre.Location = new Point(148, 23);
            txtSocioNombre.Name = "txtSocioNombre";
            txtSocioNombre.Size = new Size(160, 23);
            txtSocioNombre.TabIndex = 6;
            // 
            // txtSocioApellido
            // 
            txtSocioApellido.Location = new Point(148, 56);
            txtSocioApellido.Name = "txtSocioApellido";
            txtSocioApellido.Size = new Size(160, 23);
            txtSocioApellido.TabIndex = 7;
            // 
            // txtSocioDni
            // 
            txtSocioDni.Location = new Point(148, 95);
            txtSocioDni.Name = "txtSocioDni";
            txtSocioDni.Size = new Size(160, 23);
            txtSocioDni.TabIndex = 8;
            // 
            // txtSocioTelefono
            // 
            txtSocioTelefono.Location = new Point(148, 130);
            txtSocioTelefono.Name = "txtSocioTelefono";
            txtSocioTelefono.Size = new Size(160, 23);
            txtSocioTelefono.TabIndex = 9;
            // 
            // txtSocioDireccion
            // 
            txtSocioDireccion.Location = new Point(148, 162);
            txtSocioDireccion.Name = "txtSocioDireccion";
            txtSocioDireccion.Size = new Size(160, 23);
            txtSocioDireccion.TabIndex = 10;
            // 
            // txtSocioMail
            // 
            txtSocioMail.Location = new Point(148, 195);
            txtSocioMail.Name = "txtSocioMail";
            txtSocioMail.Size = new Size(160, 23);
            txtSocioMail.TabIndex = 11;
            // 
            // chbSocioAptoMedico
            // 
            chbSocioAptoMedico.AutoSize = true;
            chbSocioAptoMedico.Location = new Point(148, 244);
            chbSocioAptoMedico.Name = "chbSocioAptoMedico";
            chbSocioAptoMedico.Size = new Size(95, 19);
            chbSocioAptoMedico.TabIndex = 12;
            chbSocioAptoMedico.Text = "Apto Médico";
            chbSocioAptoMedico.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.Location = new Point(329, 23);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(93, 23);
            btnRegistrarSocio.TabIndex = 13;
            btnRegistrarSocio.Text = "Registrar Socio";
            btnRegistrarSocio.UseVisualStyleBackColor = true;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
            // 
            // btnCancelarAltaSocio
            // 
            btnCancelarAltaSocio.Location = new Point(329, 54);
            btnCancelarAltaSocio.Name = "btnCancelarAltaSocio";
            btnCancelarAltaSocio.Size = new Size(93, 23);
            btnCancelarAltaSocio.TabIndex = 14;
            btnCancelarAltaSocio.Text = "Cancelar";
            btnCancelarAltaSocio.UseVisualStyleBackColor = true;
            btnCancelarAltaSocio.Click += btnCancelar_Click;
            // 
            // AltaSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 290);
            Controls.Add(btnCancelarAltaSocio);
            Controls.Add(btnRegistrarSocio);
            Controls.Add(chbSocioAptoMedico);
            Controls.Add(txtSocioMail);
            Controls.Add(txtSocioDireccion);
            Controls.Add(txtSocioTelefono);
            Controls.Add(txtSocioDni);
            Controls.Add(txtSocioApellido);
            Controls.Add(txtSocioNombre);
            Controls.Add(lblSocioMail);
            Controls.Add(lblSocioDireccion);
            Controls.Add(lblSocioTelefono);
            Controls.Add(lblSocioDni);
            Controls.Add(lblSocioApellido);
            Controls.Add(lblSocioNombre);
            Name = "AltaSocio";
            Text = "Alta Socio";
            Load += AltaSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSocioNombre;
        private Label lblSocioApellido;
        private Label lblSocioDni;
        private Label lblSocioTelefono;
        private Label lblSocioDireccion;
        private Label lblSocioMail;
        private TextBox txtSocioNombre;
        private TextBox txtSocioApellido;
        private TextBox txtSocioDni;
        private TextBox txtSocioTelefono;
        private TextBox txtSocioDireccion;
        private TextBox txtSocioMail;
        private CheckBox chbSocioAptoMedico;
        private Button btnRegistrarSocio;
        private Button btnCancelarAltaSocio;
    }
}