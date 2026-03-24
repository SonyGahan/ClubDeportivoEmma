namespace ClubDeportivoEmma21.Forms
{
    partial class FormConsultas
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
            lblDniBusqueda = new Label();
            txtConsultaDniPersona = new TextBox();
            btnBuscar = new Button();
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
            pnlHeader.Size = new Size(500, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(500, 70);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Consulta de Clientes";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCuerpo
            // 
            pnlCuerpo.BackColor = Color.FromArgb(232, 237, 242);
            pnlCuerpo.Controls.Add(lblDniBusqueda);
            pnlCuerpo.Controls.Add(txtConsultaDniPersona);
            pnlCuerpo.Controls.Add(btnBuscar);
            pnlCuerpo.Controls.Add(btnVolver);
            pnlCuerpo.Dock = DockStyle.Fill;
            pnlCuerpo.Location = new Point(0, 70);
            pnlCuerpo.Name = "pnlCuerpo";
            pnlCuerpo.Size = new Size(500, 230);
            pnlCuerpo.TabIndex = 1;
            pnlCuerpo.Paint += pnlCuerpo_Paint;
            // 
            // lblDniBusqueda
            // 
            lblDniBusqueda.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDniBusqueda.ForeColor = Color.FromArgb(47, 47, 47);
            lblDniBusqueda.Location = new Point(50, 40);
            lblDniBusqueda.Name = "lblDniBusqueda";
            lblDniBusqueda.Size = new Size(120, 25);
            lblDniBusqueda.TabIndex = 0;
            lblDniBusqueda.Text = "DNI Cliente:";
            // 
            // txtConsultaDniPersona
            // 
            txtConsultaDniPersona.BorderStyle = BorderStyle.FixedSingle;
            txtConsultaDniPersona.Font = new Font("Segoe UI", 11F);
            txtConsultaDniPersona.Location = new Point(170, 37);
            txtConsultaDniPersona.Name = "txtConsultaDniPersona";
            txtConsultaDniPersona.Size = new Size(250, 27);
            txtConsultaDniPersona.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(90, 113, 132);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(260, 110);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(160, 50);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(231, 215, 193);
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnVolver.ForeColor = Color.FromArgb(47, 47, 47);
            btnVolver.Location = new Point(80, 110);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(160, 50);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 300);
            Controls.Add(pnlCuerpo);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormConsultas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de Clientes";
            pnlHeader.ResumeLayout(false);
            pnlCuerpo.ResumeLayout(false);
            pnlCuerpo.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Label lblDniBusqueda;
        private System.Windows.Forms.TextBox txtConsultaDniPersona;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolver;
    }
}