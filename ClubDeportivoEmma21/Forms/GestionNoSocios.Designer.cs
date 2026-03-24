namespace ClubDeportivoEmma21.Forms
{
    partial class GestionNoSocios
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
            pnlHeader = new Panel();
            lblTitulo = new Label();
            pnlCuerpo = new Panel();
            lblDniTitulo = new Label();
            lblDniDato = new Label();
            lblNombreTitulo = new Label();
            lblNombreDato = new Label();
            lblActividadTitulo = new Label();
            lblActividadDato = new Label();
            lblMontoTitulo = new Label();
            lblMontoDato = new Label();
            btnCerrar = new Button();
            pnlHeader.SuspendLayout();
            pnlCuerpo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(58, 80, 107);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(550, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(550, 70);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Panel de Gestión: No Socio";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCuerpo
            // 
            pnlCuerpo.BackColor = Color.FromArgb(232, 237, 242);
            pnlCuerpo.Controls.Add(lblDniTitulo);
            pnlCuerpo.Controls.Add(lblDniDato);
            pnlCuerpo.Controls.Add(lblNombreTitulo);
            pnlCuerpo.Controls.Add(lblNombreDato);
            pnlCuerpo.Controls.Add(lblActividadTitulo);
            pnlCuerpo.Controls.Add(lblActividadDato);
            pnlCuerpo.Controls.Add(lblMontoTitulo);
            pnlCuerpo.Controls.Add(lblMontoDato);
            pnlCuerpo.Controls.Add(btnCerrar);
            pnlCuerpo.Dock = DockStyle.Fill;
            pnlCuerpo.Location = new Point(0, 70);
            pnlCuerpo.Name = "pnlCuerpo";
            pnlCuerpo.Size = new Size(550, 380);
            pnlCuerpo.TabIndex = 1;
            pnlCuerpo.Paint += pnlCuerpo_Paint;
            // 
            // lblDniTitulo
            // 
            lblDniTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDniTitulo.ForeColor = Color.FromArgb(47, 47, 47);
            lblDniTitulo.Location = new Point(50, 40);
            lblDniTitulo.Name = "lblDniTitulo";
            lblDniTitulo.Size = new Size(120, 25);
            lblDniTitulo.TabIndex = 0;
            lblDniTitulo.Text = "DNI:";
            // 
            // lblDniDato
            // 
            lblDniDato.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDniDato.ForeColor = Color.FromArgb(58, 80, 107);
            lblDniDato.Location = new Point(180, 40);
            lblDniDato.Name = "lblDniDato";
            lblDniDato.Size = new Size(300, 25);
            lblDniDato.TabIndex = 1;
            lblDniDato.Text = "-";
            // 
            // lblNombreTitulo
            // 
            lblNombreTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombreTitulo.ForeColor = Color.FromArgb(47, 47, 47);
            lblNombreTitulo.Location = new Point(50, 85);
            lblNombreTitulo.Name = "lblNombreTitulo";
            lblNombreTitulo.Size = new Size(120, 25);
            lblNombreTitulo.TabIndex = 2;
            lblNombreTitulo.Text = "Nombre completo:";
            // 
            // lblNombreDato
            // 
            lblNombreDato.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNombreDato.ForeColor = Color.FromArgb(58, 80, 107);
            lblNombreDato.Location = new Point(180, 85);
            lblNombreDato.Name = "lblNombreDato";
            lblNombreDato.Size = new Size(300, 25);
            lblNombreDato.TabIndex = 3;
            lblNombreDato.Text = "-";
            // 
            // lblActividadTitulo
            // 
            lblActividadTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblActividadTitulo.ForeColor = Color.FromArgb(47, 47, 47);
            lblActividadTitulo.Location = new Point(50, 150);
            lblActividadTitulo.Name = "lblActividadTitulo";
            lblActividadTitulo.Size = new Size(120, 25);
            lblActividadTitulo.TabIndex = 4;
            lblActividadTitulo.Text = "Actividad Diaria:";
            // 
            // lblActividadDato
            // 
            lblActividadDato.Font = new Font("Segoe UI", 11F);
            lblActividadDato.Location = new Point(180, 150);
            lblActividadDato.Name = "lblActividadDato";
            lblActividadDato.Size = new Size(300, 25);
            lblActividadDato.TabIndex = 5;
            lblActividadDato.Text = "Ninguna registrada hoy";
            // 
            // lblMontoTitulo
            // 
            lblMontoTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMontoTitulo.ForeColor = Color.FromArgb(47, 47, 47);
            lblMontoTitulo.Location = new Point(50, 195);
            lblMontoTitulo.Name = "lblMontoTitulo";
            lblMontoTitulo.Size = new Size(120, 25);
            lblMontoTitulo.TabIndex = 6;
            lblMontoTitulo.Text = "Último Pago:";
            // 
            // lblMontoDato
            // 
            lblMontoDato.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMontoDato.ForeColor = Color.DarkGreen;
            lblMontoDato.Location = new Point(180, 195);
            lblMontoDato.Name = "lblMontoDato";
            lblMontoDato.Size = new Size(300, 25);
            lblMontoDato.TabIndex = 7;
            lblMontoDato.Text = "$ 0.00";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(231, 215, 193);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.FromArgb(47, 47, 47);
            btnCerrar.Location = new Point(185, 280);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(180, 50);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // GestionNoSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 450);
            Controls.Add(pnlCuerpo);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "GestionNoSocios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de No Socios - Club Emma 21";
            Load += GestionNoSocios_Load;
            pnlHeader.ResumeLayout(false);
            pnlCuerpo.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Label lblDniTitulo;
        private System.Windows.Forms.Label lblDniDato;
        private System.Windows.Forms.Label lblNombreTitulo;
        private System.Windows.Forms.Label lblNombreDato;
        private System.Windows.Forms.Label lblActividadTitulo;
        private System.Windows.Forms.Label lblActividadDato;
        private System.Windows.Forms.Label lblMontoTitulo;
        private System.Windows.Forms.Label lblMontoDato;
        private System.Windows.Forms.Button btnCerrar;
    }
}