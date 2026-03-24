namespace ClubDeportivoEmma21.Forms
{
    partial class FormCarnet
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
            this.panelFondo = new System.Windows.Forms.Panel();
            this.panelTarjeta = new System.Windows.Forms.Panel();
            this.panelBarraSuperior = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblClubNombre = new System.Windows.Forms.Label();
            this.lblTituloCarnet = new System.Windows.Forms.Label();
            this.picFotoSocio = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNroSocio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblVigencia = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelFondo.SuspendLayout();
            this.panelTarjeta.SuspendLayout();
            this.panelBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoSocio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.panelFondo.Controls.Add(this.panelTarjeta);
            this.panelFondo.Controls.Add(this.btnImprimir);
            this.panelFondo.Controls.Add(this.btnCerrar);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(600, 450);
            this.panelFondo.TabIndex = 0;
            // 
            // panelTarjeta
            // 
            this.panelTarjeta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTarjeta.Controls.Add(this.panelBarraSuperior);
            this.panelTarjeta.Controls.Add(this.lblTituloCarnet);
            this.panelTarjeta.Controls.Add(this.picFotoSocio);
            this.panelTarjeta.Controls.Add(this.lblNombre);
            this.panelTarjeta.Controls.Add(this.lblDni);
            this.panelTarjeta.Controls.Add(this.lblNroSocio);
            this.panelTarjeta.Controls.Add(this.lblCategoria);
            this.panelTarjeta.Controls.Add(this.lblVigencia);
            this.panelTarjeta.Location = new System.Drawing.Point(75, 40);
            this.panelTarjeta.Name = "panelTarjeta";
            this.panelTarjeta.Size = new System.Drawing.Size(450, 280);
            this.panelTarjeta.TabIndex = 0;
            // 
            // panelBarraSuperior
            // 
            this.panelBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.panelBarraSuperior.Controls.Add(this.lblLogo);
            this.panelBarraSuperior.Controls.Add(this.lblClubNombre);
            this.panelBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelBarraSuperior.Name = "panelBarraSuperior";
            this.panelBarraSuperior.Size = new System.Drawing.Size(448, 60);
            this.panelBarraSuperior.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblLogo.Location = new System.Drawing.Point(10, 8);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(67, 41);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "E21";
            // 
            // lblClubNombre
            // 
            this.lblClubNombre.AutoSize = true;
            this.lblClubNombre.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblClubNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblClubNombre.Location = new System.Drawing.Point(85, 18);
            this.lblClubNombre.Name = "lblClubNombre";
            this.lblClubNombre.Size = new System.Drawing.Size(225, 25);
            this.lblClubNombre.TabIndex = 1;
            this.lblClubNombre.Text = "Club Deportivo Emma 21";
            // 
            // lblTituloCarnet
            // 
            this.lblTituloCarnet.AutoSize = true;
            this.lblTituloCarnet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTituloCarnet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblTituloCarnet.Location = new System.Drawing.Point(320, 245);
            this.lblTituloCarnet.Name = "lblTituloCarnet";
            this.lblTituloCarnet.Size = new System.Drawing.Size(113, 19);
            this.lblTituloCarnet.TabIndex = 7;
            this.lblTituloCarnet.Text = "SOCIO OFICIAL";
            // 
            // picFotoSocio
            // 
            this.picFotoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFotoSocio.Location = new System.Drawing.Point(20, 75);
            this.picFotoSocio.Name = "picFotoSocio";
            this.picFotoSocio.Size = new System.Drawing.Size(110, 130);
            this.picFotoSocio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoSocio.TabIndex = 1;
            this.picFotoSocio.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblNombre.Location = new System.Drawing.Point(150, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(280, 35);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "NOMBRE APELLIDO";
            // 
            // lblDni
            // 
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDni.Location = new System.Drawing.Point(150, 115);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(280, 25);
            this.lblDni.TabIndex = 3;
            this.lblDni.Text = "DNI: -";
            // 
            // lblNroSocio
            // 
            this.lblNroSocio.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNroSocio.Location = new System.Drawing.Point(150, 145);
            this.lblNroSocio.Name = "lblNroSocio";
            this.lblNroSocio.Size = new System.Drawing.Size(280, 25);
            this.lblNroSocio.TabIndex = 4;
            this.lblNroSocio.Text = "N° Socio: -";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.lblCategoria.Location = new System.Drawing.Point(150, 175);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(280, 25);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría: Socio Activo";
            // 
            // lblVigencia
            // 
            this.lblVigencia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVigencia.ForeColor = System.Drawing.Color.Gray;
            this.lblVigencia.Location = new System.Drawing.Point(20, 215);
            this.lblVigencia.Name = "lblVigencia";
            this.lblVigencia.Size = new System.Drawing.Size(200, 20);
            this.lblVigencia.TabIndex = 6;
            this.lblVigencia.Text = "Emisión: -";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(113)))), ((int)(((byte)(132)))));
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(325, 350);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(200, 50);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "CONFIRMAR E IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(215)))), ((int)(((byte)(193)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnCerrar.Location = new System.Drawing.Point(75, 350);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 50);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "VOLVER";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormCarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 430);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormCarnet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista Previa de Carnet - Club Emma 21";
            this.panelFondo.ResumeLayout(false);
            this.panelTarjeta.ResumeLayout(false);
            this.panelTarjeta.PerformLayout();
            this.panelBarraSuperior.ResumeLayout(false);
            this.panelBarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoSocio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Panel panelTarjeta;
        private System.Windows.Forms.Panel panelBarraSuperior;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblClubNombre;
        private System.Windows.Forms.Label lblTituloCarnet;
        private System.Windows.Forms.PictureBox picFotoSocio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNroSocio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblVigencia;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCerrar;
    }
}