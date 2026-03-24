namespace ClubDeportivoEmma21.Forms
{
    partial class FormMorosos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitulo = new Label();
            pnlCuerpo = new Panel();
            txtTituloMorosos = new TextBox();
            lstSociosMorosos = new ListView();
            colId = new ColumnHeader();
            colNom = new ColumnHeader();
            colApe = new ColumnHeader();
            colTel = new ColumnHeader();
            colVenc = new ColumnHeader();
            colMonto = new ColumnHeader();
            btnMorososImprimir = new Button();
            btnMorososExportar = new Button();
            btnMorososVolver = new Button();
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
            pnlHeader.Size = new Size(750, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(750, 80);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Reporte de Vencimientos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCuerpo
            // 
            pnlCuerpo.BackColor = Color.FromArgb(232, 237, 242);
            pnlCuerpo.Controls.Add(txtTituloMorosos);
            pnlCuerpo.Controls.Add(lstSociosMorosos);
            pnlCuerpo.Controls.Add(btnMorososImprimir);
            pnlCuerpo.Controls.Add(btnMorososExportar);
            pnlCuerpo.Controls.Add(btnMorososVolver);
            pnlCuerpo.Dock = DockStyle.Fill;
            pnlCuerpo.Location = new Point(0, 80);
            pnlCuerpo.Name = "pnlCuerpo";
            pnlCuerpo.Size = new Size(750, 470);
            pnlCuerpo.TabIndex = 1;
            pnlCuerpo.Paint += pnlCuerpo_Paint;
            // 
            // txtTituloMorosos
            // 
            txtTituloMorosos.BackColor = Color.FromArgb(214, 223, 232);
            txtTituloMorosos.BorderStyle = BorderStyle.FixedSingle;
            txtTituloMorosos.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtTituloMorosos.ForeColor = Color.FromArgb(47, 47, 47);
            txtTituloMorosos.Location = new Point(40, 25);
            txtTituloMorosos.Name = "txtTituloMorosos";
            txtTituloMorosos.ReadOnly = true;
            txtTituloMorosos.Size = new Size(250, 26);
            txtTituloMorosos.TabIndex = 0;
            txtTituloMorosos.Text = "Listado de Socios Morosos:";
            txtTituloMorosos.TextAlign = HorizontalAlignment.Center;
            // 
            // lstSociosMorosos
            // 
            lstSociosMorosos.Columns.AddRange(new ColumnHeader[] { colId, colNom, colApe, colTel, colVenc, colMonto });
            lstSociosMorosos.Font = new Font("Segoe UI", 9.5F);
            lstSociosMorosos.FullRowSelect = true;
            lstSociosMorosos.GridLines = true;
            lstSociosMorosos.Location = new Point(40, 65);
            lstSociosMorosos.Name = "lstSociosMorosos";
            lstSociosMorosos.Size = new Size(520, 350);
            lstSociosMorosos.TabIndex = 1;
            lstSociosMorosos.UseCompatibleStateImageBehavior = false;
            lstSociosMorosos.View = View.Details;
            // 
            // colId
            // 
            colId.Text = "ID";
            // 
            // colNom
            // 
            colNom.Text = "Nombre";
            colNom.Width = 100;
            // 
            // colApe
            // 
            colApe.Text = "Apellido";
            colApe.Width = 100;
            // 
            // colTel
            // 
            colTel.Text = "Teléfono";
            colTel.Width = 90;
            // 
            // colVenc
            // 
            colVenc.Text = "Vencimiento";
            colVenc.Width = 90;
            // 
            // colMonto
            // 
            colMonto.Text = "Monto";
            colMonto.Width = 70;
            // 
            // btnMorososImprimir
            // 
            btnMorososImprimir.BackColor = Color.FromArgb(90, 113, 132);
            btnMorososImprimir.FlatStyle = FlatStyle.Flat;
            btnMorososImprimir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMorososImprimir.ForeColor = Color.White;
            btnMorososImprimir.Location = new Point(580, 125);
            btnMorososImprimir.Name = "btnMorososImprimir";
            btnMorososImprimir.Size = new Size(130, 45);
            btnMorososImprimir.TabIndex = 3;
            btnMorososImprimir.Text = "IMPRIMIR";
            btnMorososImprimir.UseVisualStyleBackColor = false;
            btnMorososImprimir.Click += btnMorososImprimir_Click;
            // 
            // btnMorososExportar
            // 
            btnMorososExportar.BackColor = Color.FromArgb(90, 113, 132);
            btnMorososExportar.FlatStyle = FlatStyle.Flat;
            btnMorososExportar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMorososExportar.ForeColor = Color.White;
            btnMorososExportar.Location = new Point(580, 65);
            btnMorososExportar.Name = "btnMorososExportar";
            btnMorososExportar.Size = new Size(130, 45);
            btnMorososExportar.TabIndex = 2;
            btnMorososExportar.Text = "EXPORTAR CSV";
            btnMorososExportar.UseVisualStyleBackColor = false;
            btnMorososExportar.Click += btnMorososExportar_Click;
            // 
            // btnMorososVolver
            // 
            btnMorososVolver.BackColor = Color.FromArgb(231, 215, 193);
            btnMorososVolver.FlatStyle = FlatStyle.Flat;
            btnMorososVolver.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMorososVolver.ForeColor = Color.FromArgb(47, 47, 47);
            btnMorososVolver.Location = new Point(580, 370);
            btnMorososVolver.Name = "btnMorososVolver";
            btnMorososVolver.Size = new Size(130, 45);
            btnMorososVolver.TabIndex = 4;
            btnMorososVolver.Text = "VOLVER";
            btnMorososVolver.UseVisualStyleBackColor = false;
            btnMorososVolver.Click += btnMorososVolver_Click;
            // 
            // FormMorosos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 550);
            Controls.Add(pnlCuerpo);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMorosos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reporte de Morosos";
            pnlHeader.ResumeLayout(false);
            pnlCuerpo.ResumeLayout(false);
            pnlCuerpo.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.TextBox txtTituloMorosos;
        private System.Windows.Forms.ListView lstSociosMorosos;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colNom;
        private System.Windows.Forms.ColumnHeader colApe;
        private System.Windows.Forms.ColumnHeader colTel;
        private System.Windows.Forms.ColumnHeader colVenc;
        private System.Windows.Forms.ColumnHeader colMonto;
        private System.Windows.Forms.Button btnMorososImprimir;
        private System.Windows.Forms.Button btnMorososExportar;
        private System.Windows.Forms.Button btnMorososVolver;
    }
}