namespace ClubDeportivoEmma21.Forms
{
    partial class AltaSocio
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
            this.lblSocioNombre = new System.Windows.Forms.Label();
            this.txtSocioNombre = new System.Windows.Forms.TextBox();
            this.lblSocioApellido = new System.Windows.Forms.Label();
            this.txtSocioApellido = new System.Windows.Forms.TextBox();
            this.lblSocioDni = new System.Windows.Forms.Label();
            this.txtSocioDni = new System.Windows.Forms.TextBox();
            this.lblSocioTelefono = new System.Windows.Forms.Label();
            this.txtSocioTelefono = new System.Windows.Forms.TextBox();
            this.lblSocioDireccion = new System.Windows.Forms.Label();
            this.txtSocioDireccion = new System.Windows.Forms.TextBox();
            this.lblSocioMail = new System.Windows.Forms.Label();
            this.txtSocioMail = new System.Windows.Forms.TextBox();
            this.chbSocioAptoMedico = new System.Windows.Forms.CheckBox();
            this.btnRegistrarSocio = new System.Windows.Forms.Button();
            this.btnCancelarAltaSocio = new System.Windows.Forms.Button();
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
            this.lblTitulo.Text = "Registro de Nuevo Socio";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.pnlCuerpo.Controls.Add(this.lblSocioNombre);
            this.pnlCuerpo.Controls.Add(this.txtSocioNombre);
            this.pnlCuerpo.Controls.Add(this.lblSocioApellido);
            this.pnlCuerpo.Controls.Add(this.txtSocioApellido);
            this.pnlCuerpo.Controls.Add(this.lblSocioDni);
            this.pnlCuerpo.Controls.Add(this.txtSocioDni);
            this.pnlCuerpo.Controls.Add(this.lblSocioTelefono);
            this.pnlCuerpo.Controls.Add(this.txtSocioTelefono);
            this.pnlCuerpo.Controls.Add(this.lblSocioDireccion);
            this.pnlCuerpo.Controls.Add(this.txtSocioDireccion);
            this.pnlCuerpo.Controls.Add(this.lblSocioMail);
            this.pnlCuerpo.Controls.Add(this.txtSocioMail);
            this.pnlCuerpo.Controls.Add(this.chbSocioAptoMedico);
            this.pnlCuerpo.Controls.Add(this.btnRegistrarSocio);
            this.pnlCuerpo.Controls.Add(this.btnCancelarAltaSocio);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 80);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(550, 520);
            this.pnlCuerpo.TabIndex = 1;
            this.pnlCuerpo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCuerpo_Paint);
            // 
            // Labels y Textbox
            // 
            this.lblSocioNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSocioNombre.Location = new System.Drawing.Point(50, 30);
            this.lblSocioNombre.Name = "lblSocioNombre";
            this.lblSocioNombre.Size = new System.Drawing.Size(120, 25);
            this.lblSocioNombre.Text = "Nombre:";

            this.txtSocioNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSocioNombre.Location = new System.Drawing.Point(180, 27);
            this.txtSocioNombre.Name = "txtSocioNombre";
            this.txtSocioNombre.Size = new System.Drawing.Size(300, 25);

            this.lblSocioApellido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSocioApellido.Location = new System.Drawing.Point(50, 80);
            this.lblSocioApellido.Text = "Apellido:";

            this.txtSocioApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSocioApellido.Location = new System.Drawing.Point(180, 77);
            this.txtSocioApellido.Size = new System.Drawing.Size(300, 25);

            this.lblSocioDni.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSocioDni.Location = new System.Drawing.Point(50, 130);
            this.lblSocioDni.Text = "DNI:";

            this.txtSocioDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSocioDni.Location = new System.Drawing.Point(180, 127);
            this.txtSocioDni.Size = new System.Drawing.Size(300, 25);

            this.lblSocioTelefono.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSocioTelefono.Location = new System.Drawing.Point(50, 180);
            this.lblSocioTelefono.Text = "Teléfono:";

            this.txtSocioTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSocioTelefono.Location = new System.Drawing.Point(180, 177);
            this.txtSocioTelefono.Size = new System.Drawing.Size(300, 25);

            this.lblSocioDireccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSocioDireccion.Location = new System.Drawing.Point(50, 230);
            this.lblSocioDireccion.Text = "Dirección:";

            this.txtSocioDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSocioDireccion.Location = new System.Drawing.Point(180, 227);
            this.txtSocioDireccion.Size = new System.Drawing.Size(300, 25);

            this.lblSocioMail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSocioMail.Location = new System.Drawing.Point(50, 280);
            this.lblSocioMail.Text = "Mail:";

            this.txtSocioMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSocioMail.Location = new System.Drawing.Point(180, 277);
            this.txtSocioMail.Size = new System.Drawing.Size(300, 25);

            this.chbSocioAptoMedico.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.chbSocioAptoMedico.Location = new System.Drawing.Point(180, 325);
            this.chbSocioAptoMedico.Size = new System.Drawing.Size(218, 23);
            this.chbSocioAptoMedico.Text = "Presenta Apto Médico Físico";

            // Botón Registrar
            this.btnRegistrarSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(113)))), ((int)(((byte)(132)))));
            this.btnRegistrarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarSocio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarSocio.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarSocio.Location = new System.Drawing.Point(300, 400);
            this.btnRegistrarSocio.Name = "btnRegistrarSocio";
            this.btnRegistrarSocio.Size = new System.Drawing.Size(180, 50);
            this.btnRegistrarSocio.Text = "REGISTRAR SOCIO";
            this.btnRegistrarSocio.Click += new System.EventHandler(this.btnRegistrarSocio_Click);

            // Botón Cancelar - Apunta a btnCancelarAltaSocio_Click
            this.btnCancelarAltaSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(215)))), ((int)(((byte)(193)))));
            this.btnCancelarAltaSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAltaSocio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancelarAltaSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnCancelarAltaSocio.Location = new System.Drawing.Point(70, 400);
            this.btnCancelarAltaSocio.Name = "btnCancelarAltaSocio";
            this.btnCancelarAltaSocio.Size = new System.Drawing.Size(180, 50);
            this.btnCancelarAltaSocio.Text = "CANCELAR";
            this.btnCancelarAltaSocio.Click += new System.EventHandler(this.btnCancelarAltaSocio_Click);
            // 
            // AltaSocio Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 600);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AltaSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Socio - Club Emma 21";
            this.Load += new System.EventHandler(this.AltaSocio_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlCuerpo.ResumeLayout(false);
            this.pnlCuerpo.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Label lblSocioNombre;
        private System.Windows.Forms.TextBox txtSocioNombre;
        private System.Windows.Forms.Label lblSocioApellido;
        private System.Windows.Forms.TextBox txtSocioApellido;
        private System.Windows.Forms.Label lblSocioDni;
        private System.Windows.Forms.TextBox txtSocioDni;
        private System.Windows.Forms.Label lblSocioTelefono;
        private System.Windows.Forms.TextBox txtSocioTelefono;
        private System.Windows.Forms.Label lblSocioDireccion;
        private System.Windows.Forms.TextBox txtSocioDireccion;
        private System.Windows.Forms.Label lblSocioMail;
        private System.Windows.Forms.TextBox txtSocioMail;
        private System.Windows.Forms.CheckBox chbSocioAptoMedico;
        private System.Windows.Forms.Button btnRegistrarSocio;
        private System.Windows.Forms.Button btnCancelarAltaSocio;
    }
}