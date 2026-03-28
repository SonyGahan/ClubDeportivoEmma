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
            panelFondo = new Panel();
            panelTarjeta = new Panel();
            panelBarraSuperior = new Panel();
            lblLogo = new Label();
            lblClubNombre = new Label();
            lblTituloCarnet = new Label();
            picFotoSocio = new PictureBox();
            lblNombre = new Label();
            lblDni = new Label();
            lblNroSocio = new Label();
            lblCategoria = new Label();
            lblVigencia = new Label();
            btnImprimir = new Button();
            btnCerrar = new Button();
            panelFondo.SuspendLayout();
            panelTarjeta.SuspendLayout();
            panelBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoSocio).BeginInit();
            SuspendLayout();
            // 
            // panelFondo
            // 
            panelFondo.BackColor = Color.FromArgb(232, 237, 242);
            panelFondo.Controls.Add(panelTarjeta);
            panelFondo.Controls.Add(btnImprimir);
            panelFondo.Controls.Add(btnCerrar);
            panelFondo.Dock = DockStyle.Fill;
            panelFondo.Location = new Point(0, 0);
            panelFondo.Name = "panelFondo";
            panelFondo.Size = new Size(600, 430);
            panelFondo.TabIndex = 0;
            panelFondo.Paint += panelFondo_Paint;
            // 
            // panelTarjeta
            // 
            panelTarjeta.BackColor = Color.WhiteSmoke;
            panelTarjeta.BorderStyle = BorderStyle.FixedSingle;
            panelTarjeta.Controls.Add(panelBarraSuperior);
            panelTarjeta.Controls.Add(lblTituloCarnet);
            panelTarjeta.Controls.Add(picFotoSocio);
            panelTarjeta.Controls.Add(lblNombre);
            panelTarjeta.Controls.Add(lblDni);
            panelTarjeta.Controls.Add(lblNroSocio);
            panelTarjeta.Controls.Add(lblCategoria);
            panelTarjeta.Controls.Add(lblVigencia);
            panelTarjeta.Location = new Point(75, 40);
            panelTarjeta.Name = "panelTarjeta";
            panelTarjeta.Size = new Size(450, 280);
            panelTarjeta.TabIndex = 0;
            // 
            // panelBarraSuperior
            // 
            panelBarraSuperior.BackColor = Color.FromArgb(58, 80, 107);
            panelBarraSuperior.Controls.Add(lblLogo);
            panelBarraSuperior.Controls.Add(lblClubNombre);
            panelBarraSuperior.Dock = DockStyle.Top;
            panelBarraSuperior.Location = new Point(0, 0);
            panelBarraSuperior.Name = "panelBarraSuperior";
            panelBarraSuperior.Size = new Size(448, 60);
            panelBarraSuperior.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(212, 175, 55);
            lblLogo.Location = new Point(10, 8);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(68, 41);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "E21";
            // 
            // lblClubNombre
            // 
            lblClubNombre.AutoSize = true;
            lblClubNombre.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblClubNombre.ForeColor = Color.WhiteSmoke;
            lblClubNombre.Location = new Point(85, 18);
            lblClubNombre.Name = "lblClubNombre";
            lblClubNombre.Size = new Size(223, 25);
            lblClubNombre.TabIndex = 1;
            lblClubNombre.Text = "Club Deportivo Emma 21";
            // 
            // lblTituloCarnet
            // 
            lblTituloCarnet.AutoSize = true;
            lblTituloCarnet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTituloCarnet.ForeColor = Color.FromArgb(212, 175, 55);
            lblTituloCarnet.Location = new Point(320, 245);
            lblTituloCarnet.Name = "lblTituloCarnet";
            lblTituloCarnet.Size = new Size(108, 19);
            lblTituloCarnet.TabIndex = 7;
            lblTituloCarnet.Text = "SOCIO OFICIAL";
            // 
            // picFotoSocio
            // 
            picFotoSocio.BorderStyle = BorderStyle.FixedSingle;
            picFotoSocio.Location = new Point(20, 75);
            picFotoSocio.Name = "picFotoSocio";
            picFotoSocio.Size = new Size(110, 130);
            picFotoSocio.SizeMode = PictureBoxSizeMode.StretchImage;
            picFotoSocio.TabIndex = 1;
            picFotoSocio.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(47, 47, 47);
            lblNombre.Location = new Point(150, 75);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(280, 35);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "NOMBRE APELLIDO";
            // 
            // lblDni
            // 
            lblDni.Font = new Font("Segoe UI", 11F);
            lblDni.Location = new Point(150, 115);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(280, 25);
            lblDni.TabIndex = 3;
            lblDni.Text = "DNI: -";
            // 
            // lblNroSocio
            // 
            lblNroSocio.Font = new Font("Segoe UI", 11F);
            lblNroSocio.Location = new Point(150, 145);
            lblNroSocio.Name = "lblNroSocio";
            lblNroSocio.Size = new Size(280, 25);
            lblNroSocio.TabIndex = 4;
            lblNroSocio.Text = "N° Socio: -";
            // 
            // lblCategoria
            // 
            lblCategoria.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lblCategoria.ForeColor = Color.FromArgb(58, 80, 107);
            lblCategoria.Location = new Point(150, 175);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(280, 25);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoría: Socio Activo";
            // 
            // lblVigencia
            // 
            lblVigencia.Font = new Font("Segoe UI", 9F);
            lblVigencia.ForeColor = Color.Gray;
            lblVigencia.Location = new Point(20, 215);
            lblVigencia.Name = "lblVigencia";
            lblVigencia.Size = new Size(200, 20);
            lblVigencia.TabIndex = 6;
            lblVigencia.Text = "Emisión: -";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(90, 113, 132);
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(325, 350);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(200, 50);
            btnImprimir.TabIndex = 1;
            btnImprimir.Text = "CONFIRMAR E IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(231, 215, 193);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.FromArgb(47, 47, 47);
            btnCerrar.Location = new Point(75, 350);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(120, 50);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "VOLVER";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 430);
            Controls.Add(panelFondo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormCarnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vista Previa de Carnet - Club Emma 21";
            panelFondo.ResumeLayout(false);
            panelTarjeta.ResumeLayout(false);
            panelTarjeta.PerformLayout();
            panelBarraSuperior.ResumeLayout(false);
            panelBarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoSocio).EndInit();
            ResumeLayout(false);

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