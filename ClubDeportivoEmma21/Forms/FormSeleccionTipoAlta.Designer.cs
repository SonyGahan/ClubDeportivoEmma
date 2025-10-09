namespace ClubDeportivoEmma21.Forms
{
    partial class FormSeleccionTipoAlta
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblMensaje = new Label();
            btnSocio = new Button();
            btnNoSocio = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 10F);
            lblMensaje.Location = new Point(35, 20);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(274, 38);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "No se encontró ningún cliente con ese DNI.\r\n¿Cómo desea registrarse?";
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSocio
            // 
            btnSocio.Location = new Point(40, 80);
            btnSocio.Name = "btnSocio";
            btnSocio.Size = new Size(120, 35);
            btnSocio.TabIndex = 1;
            btnSocio.Text = "Alta Socio";
            btnSocio.UseVisualStyleBackColor = true;
            btnSocio.Click += btnSocio_Click;
            // 
            // btnNoSocio
            // 
            btnNoSocio.Location = new Point(180, 80);
            btnNoSocio.Name = "btnNoSocio";
            btnNoSocio.Size = new Size(120, 35);
            btnNoSocio.TabIndex = 2;
            btnNoSocio.Text = "Alta No Socio";
            btnNoSocio.UseVisualStyleBackColor = true;
            btnNoSocio.Click += btnNoSocio_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(110, 130);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 30);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormSeleccionTipoAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 180);
            Controls.Add(btnCancelar);
            Controls.Add(btnNoSocio);
            Controls.Add(btnSocio);
            Controls.Add(lblMensaje);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSeleccionTipoAlta";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo Registro";
            Load += FormSeleccionTipoAlta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private Button btnSocio;
        private Button btnNoSocio;
        private Button btnCancelar;
    }
}
