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
            // 
            // lblSocioNombre
            // 
            this.lblSocioNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSocioNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblSocioNombre.Location = new System.Drawing.Point(50, 30);
            this.lblSocioNombre.Name = "lblSocioNombre";
            this.lblSocioNombre.Size = new System.Drawing.Size(120, 25);
            this.lblSocioNombre.Text = "Nombre:";
            // 
            // txtSocioNombre
            // 
            this.txtSocioNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSocioNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSocioNombre.Location = new System.Drawing.Point(180, 27);
            this.txtSocioNombre.Name = "txtSocioNombre";
            this.txtSocioNombre.Size = new System.Drawing.Size(300, 25);
            this.txtSocioNombre.TabIndex = 1;
            // 
            // lblSocioApellido
            // 
            this.lblSocioApellido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSocioApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblSocioApellido.Location = new System.Drawing.Point(50, 80);
            this.lblSocioApellido.Name = "lblSocioApellido";
            this.lblSocioApellido.Size = new System.Drawing.Size(120, 25);
            this.lblSocioApellido.Text = "Apellido:";
            // 
            // txtSocioApellido
            // 
            this.txtSocioApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSocioApellido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSocioApellido.Location = new System.Drawing.Point(180, 77);
            this.txtSocioApellido.Name = "txtSocioApellido";
            this.txtSocioApellido.Size = new System.Drawing.Size(300, 25);
            this.txtSocioApellido.TabIndex = 2;
            // 
            // lblSocioDni
            // 
            this.lblSocioDni.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSocioDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblSocioDni.Location = new System.Drawing.Point(50, 130);
            this.lblSocioDni.Name = "lblSocioDni";
            this.lblSocioDni.Size = new System.Drawing.Size(120, 25);
            this.lblSocioDni.Text = "DNI:";
            // 
            // txtSocioDni
            // 
            this.txtSocioDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSocioDni.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSocioDni.Location = new System.Drawing.Point(180, 127);
            this.txtSocioDni.Name = "txtSocioDni";
            this.txtSocioDni.Size = new System.Drawing.Size(300, 25);
            this.txtSocioDni.TabIndex = 3;
            // 
            // lblSocioTelefono
            // 
            this.lblSocioTelefono.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSocioTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblSocioTelefono.Location = new System.Drawing.Point(50, 180);
            this.lblSocioTelefono.Name = "lblSocioTelefono";
            this.lblSocioTelefono.Size = new System.Drawing.Size(120, 25);
            this.lblSocioTelefono.Text = "Teléfono:";
            // 
            // txtSocioTelefono
            // 
            this.txtSocioTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSocioTelefono.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSocioTelefono.Location = new System.Drawing.Point(180, 177);
            this.txtSocioTelefono.Name = "txtSocioTelefono";
            this.txtSocioTelefono.Size = new System.Drawing.Size(300, 25);
            this.txtSocioTelefono.TabIndex = 4;
            // 
            // lblSocioDireccion
            // 
            this.lblSocioDireccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSocioDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblSocioDireccion.Location = new System.Drawing.Point(50, 230);
            this.lblSocioDireccion.Name = "lblSocioDireccion";
            this.lblSocioDireccion.Size = new System.Drawing.Size(120, 25);
            this.lblSocioDireccion.Text = "Dirección:";
            // 
            // txtSocioDireccion
            // 
            this.txtSocioDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSocioDireccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSocioDireccion.Location = new System.Drawing.Point(180, 227);
            this.txtSocioDireccion.Name = "txtSocioDireccion";
            this.txtSocioDireccion.Size = new System.Drawing.Size(300, 25);
            this.txtSocioDireccion.TabIndex = 5;
            // 
            // lblSocioMail
            // 
            this.lblSocioMail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSocioMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblSocioMail.Location = new System.Drawing.Point(50, 280);
            this.lblSocioMail.Name = "lblSocioMail";
            this.lblSocioMail.Size = new System.Drawing.Size(120, 25);
            this.lblSocioMail.Text = "Mail:";
            // 
            // txtSocioMail
            // 
            this.txtSocioMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSocioMail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSocioMail.Location = new System.Drawing.Point(180, 277);
            this.txtSocioMail.Name = "txtSocioMail";
            this.txtSocioMail.Size = new System.Drawing.Size(300, 25);
            this.txtSocioMail.TabIndex = 6;
            // 
            // chbSocioAptoMedico
            // 
            this.chbSocioAptoMedico.AutoSize = true;
            this.chbSocioAptoMedico.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.chbSocioAptoMedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.chbSocioAptoMedico.Location = new System.Drawing.Point(180, 325);
            this.chbSocioAptoMedico.Name = "chbSocioAptoMedico";
            this.chbSocioAptoMedico.Size = new System.Drawing.Size(220, 23);
            this.chbSocioAptoMedico.TabIndex = 7;
            this.chbSocioAptoMedico.Text = "Presenta Apto Médico Físico";
            this.chbSocioAptoMedico.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarSocio
            // 
            this.btnRegistrarSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(113)))), ((int)(((byte)(132)))));
            this.btnRegistrarSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarSocio.FlatAppearance.BorderSize = 0;
            this.btnRegistrarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarSocio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarSocio.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarSocio.Location = new System.Drawing.Point(300, 400);
            this.btnRegistrarSocio.Name = "btnRegistrarSocio";
            this.btnRegistrarSocio.Size = new System.Drawing.Size(180, 50);
            this.btnRegistrarSocio.TabIndex = 8;
            this.btnRegistrarSocio.Text = "REGISTRAR SOCIO";
            this.btnRegistrarSocio.UseVisualStyleBackColor = false;
            this.btnRegistrarSocio.Click += new System.EventHandler(this.btnRegistrarSocio_Click);
            // 
            // btnCancelarAltaSocio
            // 
            this.btnCancelarAltaSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(215)))), ((int)(((byte)(193)))));
            this.btnCancelarAltaSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarAltaSocio.FlatAppearance.BorderSize = 0;
            this.btnCancelarAltaSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAltaSocio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancelarAltaSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnCancelarAltaSocio.Location = new System.Drawing.Point(70, 400);
            this.btnCancelarAltaSocio.Name = "btnCancelarAltaSocio";
            this.btnCancelarAltaSocio.Size = new System.Drawing.Size(180, 50);
            this.btnCancelarAltaSocio.TabIndex = 9;
            this.btnCancelarAltaSocio.Text = "CANCELAR";
            this.btnCancelarAltaSocio.UseVisualStyleBackColor = false;
            this.btnCancelarAltaSocio.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AltaSocio
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