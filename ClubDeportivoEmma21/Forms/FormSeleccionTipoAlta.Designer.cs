namespace ClubDeportivoEmma21.Forms
{
    partial class FormSeleccionTipoAlta
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
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.btnAltaSocio = new System.Windows.Forms.Button();
            this.btnAltaNoSocio = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
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
            this.pnlHeader.Size = new System.Drawing.Size(450, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(450, 70);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Tipo de Registro";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.pnlCuerpo.Controls.Add(this.lblInstruccion);
            this.pnlCuerpo.Controls.Add(this.btnAltaSocio);
            this.pnlCuerpo.Controls.Add(this.btnAltaNoSocio);
            this.pnlCuerpo.Controls.Add(this.btnVolver);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 70);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(450, 280);
            this.pnlCuerpo.TabIndex = 1;
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblInstruccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblInstruccion.Location = new System.Drawing.Point(50, 25);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(350, 30);
            this.lblInstruccion.TabIndex = 0;
            this.lblInstruccion.Text = "¿Cómo desea registrar al nuevo cliente?";
            this.lblInstruccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAltaSocio
            // 
            this.btnAltaSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(113)))), ((int)(((byte)(132)))));
            this.btnAltaSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaSocio.FlatAppearance.BorderSize = 0;
            this.btnAltaSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaSocio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAltaSocio.ForeColor = System.Drawing.Color.White;
            this.btnAltaSocio.Location = new System.Drawing.Point(75, 75);
            this.btnAltaSocio.Name = "btnAltaSocio";
            this.btnAltaSocio.Size = new System.Drawing.Size(300, 50);
            this.btnAltaSocio.TabIndex = 1;
            this.btnAltaSocio.Text = "NUEVO SOCIO";
            this.btnAltaSocio.UseVisualStyleBackColor = false;
            this.btnAltaSocio.Click += new System.EventHandler(this.btnAltaSocio_Click);
            // 
            // btnAltaNoSocio
            // 
            this.btnAltaNoSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(113)))), ((int)(((byte)(132)))));
            this.btnAltaNoSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltaNoSocio.FlatAppearance.BorderSize = 0;
            this.btnAltaNoSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaNoSocio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAltaNoSocio.ForeColor = System.Drawing.Color.White;
            this.btnAltaNoSocio.Location = new System.Drawing.Point(75, 140);
            this.btnAltaNoSocio.Name = "btnAltaNoSocio";
            this.btnAltaNoSocio.Size = new System.Drawing.Size(300, 50);
            this.btnAltaNoSocio.TabIndex = 2;
            this.btnAltaNoSocio.Text = "NUEVO NO SOCIO";
            this.btnAltaNoSocio.UseVisualStyleBackColor = false;
            this.btnAltaNoSocio.Click += new System.EventHandler(this.btnAltaNoSocio_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(215)))), ((int)(((byte)(193)))));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnVolver.Location = new System.Drawing.Point(150, 215);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 40);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "CANCELAR";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormSeleccionTipoAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormSeleccionTipoAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección de Alta - Club Emma 21";
            this.pnlHeader.ResumeLayout(false);
            this.pnlCuerpo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Button btnAltaSocio;
        private System.Windows.Forms.Button btnAltaNoSocio;
        private System.Windows.Forms.Button btnVolver;
    }
}