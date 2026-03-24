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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.txtTituloMorosos = new System.Windows.Forms.TextBox();
            this.lstSociosMorosos = new System.Windows.Forms.ListView();
            this.colId = new System.Windows.Forms.ColumnHeader();
            this.colNom = new System.Windows.Forms.ColumnHeader();
            this.colApe = new System.Windows.Forms.ColumnHeader();
            this.colTel = new System.Windows.Forms.ColumnHeader();
            this.colVenc = new System.Windows.Forms.ColumnHeader();
            this.colMonto = new System.Windows.Forms.ColumnHeader();
            this.btnMorososImprimir = new System.Windows.Forms.Button();
            this.btnMorososExportar = new System.Windows.Forms.Button();
            this.btnMorososVolver = new System.Windows.Forms.Button();
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
            this.pnlHeader.Size = new System.Drawing.Size(750, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(750, 80);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Reporte de Vencimientos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.pnlCuerpo.Controls.Add(this.txtTituloMorosos);
            this.pnlCuerpo.Controls.Add(this.lstSociosMorosos);
            this.pnlCuerpo.Controls.Add(this.btnMorososImprimir);
            this.pnlCuerpo.Controls.Add(this.btnMorososExportar);
            this.pnlCuerpo.Controls.Add(this.btnMorososVolver);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 80);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(750, 470);
            this.pnlCuerpo.TabIndex = 1;
            // 
            // txtTituloMorosos
            // 
            this.txtTituloMorosos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.txtTituloMorosos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTituloMorosos.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.txtTituloMorosos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.txtTituloMorosos.Location = new System.Drawing.Point(40, 25);
            this.txtTituloMorosos.Name = "txtTituloMorosos";
            this.txtTituloMorosos.ReadOnly = true;
            this.txtTituloMorosos.Size = new System.Drawing.Size(250, 26);
            this.txtTituloMorosos.TabIndex = 0;
            this.txtTituloMorosos.Text = "Listado de Socios Morosos:";
            this.txtTituloMorosos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstSociosMorosos
            // 
            this.lstSociosMorosos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId, this.colNom, this.colApe, this.colTel, this.colVenc, this.colMonto});
            this.lstSociosMorosos.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstSociosMorosos.FullRowSelect = true;
            this.lstSociosMorosos.GridLines = true;
            this.lstSociosMorosos.Location = new System.Drawing.Point(40, 65);
            this.lstSociosMorosos.Name = "lstSociosMorosos";
            this.lstSociosMorosos.Size = new System.Drawing.Size(520, 350);
            this.lstSociosMorosos.TabIndex = 1;
            this.lstSociosMorosos.UseCompatibleStateImageBehavior = false;
            this.lstSociosMorosos.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeaders
            // 
            this.colId.Text = "ID"; this.colId.Width = 60;
            this.colNom.Text = "Nombre"; this.colNom.Width = 100;
            this.colApe.Text = "Apellido"; this.colApe.Width = 100;
            this.colTel.Text = "Teléfono"; this.colTel.Width = 90;
            this.colVenc.Text = "Vencimiento"; this.colVenc.Width = 90;
            this.colMonto.Text = "Monto"; this.colMonto.Width = 70;
            // 
            // btnMorososExportar
            // 
            this.btnMorososExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(113)))), ((int)(((byte)(132)))));
            this.btnMorososExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMorososExportar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMorososExportar.ForeColor = System.Drawing.Color.White;
            this.btnMorososExportar.Location = new System.Drawing.Point(580, 65);
            this.btnMorososExportar.Name = "btnMorososExportar";
            this.btnMorososExportar.Size = new System.Drawing.Size(130, 45);
            this.btnMorososExportar.TabIndex = 2;
            this.btnMorososExportar.Text = "EXPORTAR CSV";
            this.btnMorososExportar.UseVisualStyleBackColor = false;
            this.btnMorososExportar.Click += new System.EventHandler(this.btnMorososExportar_Click);
            // 
            // btnMorososImprimir
            // 
            this.btnMorososImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(113)))), ((int)(((byte)(132)))));
            this.btnMorososImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMorososImprimir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMorososImprimir.ForeColor = System.Drawing.Color.White;
            this.btnMorososImprimir.Location = new System.Drawing.Point(580, 125);
            this.btnMorososImprimir.Name = "btnMorososImprimir";
            this.btnMorososImprimir.Size = new System.Drawing.Size(130, 45);
            this.btnMorososImprimir.TabIndex = 3;
            this.btnMorososImprimir.Text = "IMPRIMIR";
            this.btnMorososImprimir.UseVisualStyleBackColor = false;
            this.btnMorososImprimir.Click += new System.EventHandler(this.btnMorososImprimir_Click);
            // 
            // btnMorososVolver
            // 
            this.btnMorososVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(215)))), ((int)(((byte)(193)))));
            this.btnMorososVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMorososVolver.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMorososVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnMorososVolver.Location = new System.Drawing.Point(580, 370);
            this.btnMorososVolver.Name = "btnMorososVolver";
            this.btnMorososVolver.Size = new System.Drawing.Size(130, 45);
            this.btnMorososVolver.TabIndex = 4;
            this.btnMorososVolver.Text = "VOLVER";
            this.btnMorososVolver.UseVisualStyleBackColor = false;
            this.btnMorososVolver.Click += new System.EventHandler(this.btnMorososVolver_Click);
            // 
            // FormMorosos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMorosos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Morosos";
            this.pnlHeader.ResumeLayout(false);
            this.pnlCuerpo.ResumeLayout(false);
            this.pnlCuerpo.PerformLayout();
            this.ResumeLayout(false);
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