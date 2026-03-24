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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.lblDniTitulo = new System.Windows.Forms.Label();
            this.lblDniDato = new System.Windows.Forms.Label();
            this.lblNombreTitulo = new System.Windows.Forms.Label();
            this.lblNombreDato = new System.Windows.Forms.Label();
            this.lblEstadoTitulo = new System.Windows.Forms.Label();
            this.lblEstadoDato = new System.Windows.Forms.Label();
            this.lblAptoTitulo = new System.Windows.Forms.Label();
            this.lblAptoDato = new System.Windows.Forms.Label();
            this.btnPagarCuota = new System.Windows.Forms.Button();
            this.btnEmitirCarnet = new System.Windows.Forms.Button();
            this.btnRenovarApto = new System.Windows.Forms.Button();
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
            this.pnlHeader.Size = new System.Drawing.Size(600, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(600, 80);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Panel de Gestión de Socio";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.pnlCuerpo.Controls.Add(this.lblDniTitulo);
            this.pnlCuerpo.Controls.Add(this.lblDniDato);
            this.pnlCuerpo.Controls.Add(this.lblNombreTitulo);
            this.pnlCuerpo.Controls.Add(this.lblNombreDato);
            this.pnlCuerpo.Controls.Add(this.lblEstadoTitulo);
            this.pnlCuerpo.Controls.Add(this.lblEstadoDato);
            this.pnlCuerpo.Controls.Add(this.lblAptoTitulo);
            this.pnlCuerpo.Controls.Add(this.lblAptoDato);
            this.pnlCuerpo.Controls.Add(this.btnPagarCuota);
            this.pnlCuerpo.Controls.Add(this.btnEmitirCarnet);
            this.pnlCuerpo.Controls.Add(this.btnRenovarApto);
            this.pnlCuerpo.Controls.Add(this.btnVolver);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 80);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(600, 470);
            this.pnlCuerpo.TabIndex = 1;
            // 
            // lblDniTitulo
            // 
            this.lblDniTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDniTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblDniTitulo.Location = new System.Drawing.Point(60, 40);
            this.lblDniTitulo.Name = "lblDniTitulo";
            this.lblDniTitulo.Size = new System.Drawing.Size(120, 25);
            this.lblDniTitulo.Text = "DNI:";
            // 
            // lblDniDato
            // 
            this.lblDniDato.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDniDato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.lblDniDato.Location = new System.Drawing.Point(200, 40);
            this.lblDniDato.Name = "lblDniDato";
            this.lblDniDato.Size = new System.Drawing.Size(300, 25);
            this.lblDniDato.Text = "-";
            // 
            // lblNombreTitulo
            // 
            this.lblNombreTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblNombreTitulo.Location = new System.Drawing.Point(60, 80);
            this.lblNombreTitulo.Name = "lblNombreTitulo";
            this.lblNombreTitulo.Size = new System.Drawing.Size(120, 25);
            this.lblNombreTitulo.Text = "Nombre Completo:";
            // 
            // lblNombreDato
            // 
            this.lblNombreDato.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNombreDato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.lblNombreDato.Location = new System.Drawing.Point(200, 80);
            this.lblNombreDato.Name = "lblNombreDato";
            this.lblNombreDato.Size = new System.Drawing.Size(300, 25);
            this.lblNombreDato.Text = "-";
            // 
            // lblEstadoTitulo
            // 
            this.lblEstadoTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstadoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblEstadoTitulo.Location = new System.Drawing.Point(60, 120);
            this.lblEstadoTitulo.Name = "lblEstadoTitulo";
            this.lblEstadoTitulo.Size = new System.Drawing.Size(120, 25);
            this.lblEstadoTitulo.Text = "Estado Membresía:";
            // 
            // lblEstadoDato
            // 
            this.lblEstadoDato.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEstadoDato.Location = new System.Drawing.Point(200, 120);
            this.lblEstadoDato.Name = "lblEstadoDato";
            this.lblEstadoDato.Size = new System.Drawing.Size(300, 25);
            this.lblEstadoDato.Text = "-";
            // 
            // lblAptoTitulo
            // 
            this.lblAptoTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAptoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblAptoTitulo.Location = new System.Drawing.Point(60, 160);
            this.lblAptoTitulo.Name = "lblAptoTitulo";
            this.lblAptoTitulo.Size = new System.Drawing.Size(120, 25);
            this.lblAptoTitulo.Text = "Apto Médico:";
            // 
            // lblAptoDato
            // 
            this.lblAptoDato.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAptoDato.Location = new System.Drawing.Point(200, 160);
            this.lblAptoDato.Name = "lblAptoDato";
            this.lblAptoDato.Size = new System.Drawing.Size(300, 25);
            this.lblAptoDato.Text = "-";
            // 
            // btnPagarCuota
            // 
            this.btnPagarCuota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(113)))), ((int)(((byte)(132)))));
            this.btnPagarCuota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagarCuota.FlatAppearance.BorderSize = 0;
            this.btnPagarCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagarCuota.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPagarCuota.ForeColor = System.Drawing.Color.White;
            this.btnPagarCuota.Location = new System.Drawing.Point(60, 230);
            this.btnPagarCuota.Name = "btnPagarCuota";
            this.btnPagarCuota.Size = new System.Drawing.Size(220, 55);
            this.btnPagarCuota.TabIndex = 1;
            this.btnPagarCuota.Text = "PAGAR CUOTA";
            this.btnPagarCuota.UseVisualStyleBackColor = false;
            this.btnPagarCuota.Click += new System.EventHandler(this.btnPagarCuota_Click);
            // 
            // btnEmitirCarnet
            // 
            this.btnEmitirCarnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(113)))), ((int)(((byte)(132)))));
            this.btnEmitirCarnet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmitirCarnet.FlatAppearance.BorderSize = 0;
            this.btnEmitirCarnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitirCarnet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEmitirCarnet.ForeColor = System.Drawing.Color.White;
            this.btnEmitirCarnet.Location = new System.Drawing.Point(320, 230);
            this.btnEmitirCarnet.Name = "btnEmitirCarnet";
            this.btnEmitirCarnet.Size = new System.Drawing.Size(220, 55);
            this.btnEmitirCarnet.TabIndex = 2;
            this.btnEmitirCarnet.Text = "EMITIR CARNET";
            this.btnEmitirCarnet.UseVisualStyleBackColor = false;
            this.btnEmitirCarnet.Click += new System.EventHandler(this.btnEmitirCarnet_Click);
            // 
            // btnRenovarApto
            // 
            this.btnRenovarApto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(113)))), ((int)(((byte)(132)))));
            this.btnRenovarApto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenovarApto.FlatAppearance.BorderSize = 0;
            this.btnRenovarApto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenovarApto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRenovarApto.ForeColor = System.Drawing.Color.White;
            this.btnRenovarApto.Location = new System.Drawing.Point(60, 305);
            this.btnRenovarApto.Name = "btnRenovarApto";
            this.btnRenovarApto.Size = new System.Drawing.Size(220, 55);
            this.btnRenovarApto.TabIndex = 3;
            this.btnRenovarApto.Text = "RENOVAR APTO";
            this.btnRenovarApto.UseVisualStyleBackColor = false;
            this.btnRenovarApto.Click += new System.EventHandler(this.btnRenovarApto_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(215)))), ((int)(((byte)(193)))));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnVolver.Location = new System.Drawing.Point(320, 305);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(220, 55);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "VOLVER AL MENÚ";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // GestionSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 550);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GestionSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Socios - Club Emma 21";
            this.Load += new System.EventHandler(this.GestionSocios_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlCuerpo.ResumeLayout(false);
            this.ResumeLayout(false);

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