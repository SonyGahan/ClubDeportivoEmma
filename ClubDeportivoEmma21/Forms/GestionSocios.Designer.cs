namespace ClubDeportivoEmma21.Forms
{
    partial class GestionSocios
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
            lblEstadoTitulo = new Label();
            lblEstadoDato = new Label();
            lblAptoTitulo = new Label();
            lblAptoDato = new Label();
            btnPagarCuota = new Button();
            btnEmitirCarnet = new Button();
            btnRenovarApto = new Button();
            btnVolver = new Button();
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
            pnlHeader.Size = new Size(600, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(600, 80);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Panel de Gestión de Socio";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCuerpo
            // 
            pnlCuerpo.BackColor = Color.FromArgb(232, 237, 242);
            pnlCuerpo.Controls.Add(lblDniTitulo);
            pnlCuerpo.Controls.Add(lblDniDato);
            pnlCuerpo.Controls.Add(lblNombreTitulo);
            pnlCuerpo.Controls.Add(lblNombreDato);
            pnlCuerpo.Controls.Add(lblEstadoTitulo);
            pnlCuerpo.Controls.Add(lblEstadoDato);
            pnlCuerpo.Controls.Add(lblAptoTitulo);
            pnlCuerpo.Controls.Add(lblAptoDato);
            pnlCuerpo.Controls.Add(btnPagarCuota);
            pnlCuerpo.Controls.Add(btnEmitirCarnet);
            pnlCuerpo.Controls.Add(btnRenovarApto);
            pnlCuerpo.Controls.Add(btnVolver);
            pnlCuerpo.Dock = DockStyle.Fill;
            pnlCuerpo.Location = new Point(0, 80);
            pnlCuerpo.Name = "pnlCuerpo";
            pnlCuerpo.Size = new Size(600, 470);
            pnlCuerpo.TabIndex = 1;
            pnlCuerpo.Paint += pnlCuerpo_Paint;
            // 
            // lblDniTitulo
            // 
            lblDniTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDniTitulo.ForeColor = Color.FromArgb(47, 47, 47);
            lblDniTitulo.Location = new Point(60, 40);
            lblDniTitulo.Name = "lblDniTitulo";
            lblDniTitulo.Size = new Size(120, 25);
            lblDniTitulo.TabIndex = 0;
            lblDniTitulo.Text = "DNI:";
            // 
            // lblDniDato
            // 
            lblDniDato.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDniDato.ForeColor = Color.FromArgb(58, 80, 107);
            lblDniDato.Location = new Point(200, 40);
            lblDniDato.Name = "lblDniDato";
            lblDniDato.Size = new Size(300, 25);
            lblDniDato.TabIndex = 1;
            lblDniDato.Text = "-";
            // 
            // lblNombreTitulo
            // 
            lblNombreTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombreTitulo.ForeColor = Color.FromArgb(47, 47, 47);
            lblNombreTitulo.Location = new Point(60, 80);
            lblNombreTitulo.Name = "lblNombreTitulo";
            lblNombreTitulo.Size = new Size(120, 25);
            lblNombreTitulo.TabIndex = 2;
            lblNombreTitulo.Text = "Nombre Completo:";
            // 
            // lblNombreDato
            // 
            lblNombreDato.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNombreDato.ForeColor = Color.FromArgb(58, 80, 107);
            lblNombreDato.Location = new Point(200, 80);
            lblNombreDato.Name = "lblNombreDato";
            lblNombreDato.Size = new Size(300, 25);
            lblNombreDato.TabIndex = 3;
            lblNombreDato.Text = "-";
            // 
            // lblEstadoTitulo
            // 
            lblEstadoTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstadoTitulo.ForeColor = Color.FromArgb(47, 47, 47);
            lblEstadoTitulo.Location = new Point(60, 120);
            lblEstadoTitulo.Name = "lblEstadoTitulo";
            lblEstadoTitulo.Size = new Size(120, 25);
            lblEstadoTitulo.TabIndex = 4;
            lblEstadoTitulo.Text = "Estado Membresía:";
            // 
            // lblEstadoDato
            // 
            lblEstadoDato.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblEstadoDato.Location = new Point(200, 120);
            lblEstadoDato.Name = "lblEstadoDato";
            lblEstadoDato.Size = new Size(300, 25);
            lblEstadoDato.TabIndex = 5;
            lblEstadoDato.Text = "-";
            // 
            // lblAptoTitulo
            // 
            lblAptoTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAptoTitulo.ForeColor = Color.FromArgb(47, 47, 47);
            lblAptoTitulo.Location = new Point(60, 160);
            lblAptoTitulo.Name = "lblAptoTitulo";
            lblAptoTitulo.Size = new Size(120, 25);
            lblAptoTitulo.TabIndex = 6;
            lblAptoTitulo.Text = "Apto Médico:";
            // 
            // lblAptoDato
            // 
            lblAptoDato.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAptoDato.Location = new Point(200, 160);
            lblAptoDato.Name = "lblAptoDato";
            lblAptoDato.Size = new Size(300, 25);
            lblAptoDato.TabIndex = 7;
            lblAptoDato.Text = "-";
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.BackColor = Color.FromArgb(90, 113, 132);
            btnPagarCuota.Cursor = Cursors.Hand;
            btnPagarCuota.FlatAppearance.BorderSize = 0;
            btnPagarCuota.FlatStyle = FlatStyle.Flat;
            btnPagarCuota.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPagarCuota.ForeColor = Color.White;
            btnPagarCuota.Location = new Point(60, 230);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(220, 55);
            btnPagarCuota.TabIndex = 1;
            btnPagarCuota.Text = "PAGAR CUOTA";
            btnPagarCuota.UseVisualStyleBackColor = false;
            btnPagarCuota.Click += btnPagarCuota_Click;
            // 
            // btnEmitirCarnet
            // 
            btnEmitirCarnet.BackColor = Color.FromArgb(90, 113, 132);
            btnEmitirCarnet.Cursor = Cursors.Hand;
            btnEmitirCarnet.FlatAppearance.BorderSize = 0;
            btnEmitirCarnet.FlatStyle = FlatStyle.Flat;
            btnEmitirCarnet.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEmitirCarnet.ForeColor = Color.White;
            btnEmitirCarnet.Location = new Point(320, 230);
            btnEmitirCarnet.Name = "btnEmitirCarnet";
            btnEmitirCarnet.Size = new Size(220, 55);
            btnEmitirCarnet.TabIndex = 2;
            btnEmitirCarnet.Text = "EMITIR CARNET";
            btnEmitirCarnet.UseVisualStyleBackColor = false;
            btnEmitirCarnet.Click += btnEmitirCarnet_Click;
            // 
            // btnRenovarApto
            // 
            btnRenovarApto.BackColor = Color.FromArgb(90, 113, 132);
            btnRenovarApto.Cursor = Cursors.Hand;
            btnRenovarApto.FlatAppearance.BorderSize = 0;
            btnRenovarApto.FlatStyle = FlatStyle.Flat;
            btnRenovarApto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRenovarApto.ForeColor = Color.White;
            btnRenovarApto.Location = new Point(60, 305);
            btnRenovarApto.Name = "btnRenovarApto";
            btnRenovarApto.Size = new Size(220, 55);
            btnRenovarApto.TabIndex = 3;
            btnRenovarApto.Text = "RENOVAR APTO";
            btnRenovarApto.UseVisualStyleBackColor = false;
            btnRenovarApto.Click += btnRenovarApto_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(231, 215, 193);
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnVolver.ForeColor = Color.FromArgb(47, 47, 47);
            btnVolver.Location = new Point(320, 305);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(220, 55);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "VOLVER AL MENÚ";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // GestionSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 550);
            Controls.Add(pnlCuerpo);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "GestionSocios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Socios - Club Emma 21";
            Load += GestionSocios_Load;
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
        private System.Windows.Forms.Label lblEstadoTitulo;
        private System.Windows.Forms.Label lblEstadoDato;
        private System.Windows.Forms.Label lblAptoTitulo;
        private System.Windows.Forms.Label lblAptoDato;
        private System.Windows.Forms.Button btnPagarCuota;
        private System.Windows.Forms.Button btnEmitirCarnet;
        private System.Windows.Forms.Button btnRenovarApto;
        private System.Windows.Forms.Button btnVolver;
    }
}