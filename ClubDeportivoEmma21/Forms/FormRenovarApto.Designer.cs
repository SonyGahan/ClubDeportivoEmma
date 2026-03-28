namespace ClubDeportivoEmma21.Forms
{
    partial class FormRenovarApto
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
            lblDniBusqueda = new Label();
            txtDni = new TextBox();
            btnBuscar = new Button();
            lblNombreLabel = new Label();
            lblNombreDato = new Label();
            lblVencimientoLabel = new Label();
            lblVencimientoDato = new Label();
            btnRenovar = new Button();
            btnCancelar = new Button();
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
            lblTitulo.Text = "Renovación Apto Médico";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCuerpo
            // 
            pnlCuerpo.BackColor = Color.FromArgb(232, 237, 242);
            pnlCuerpo.Controls.Add(lblDniBusqueda);
            pnlCuerpo.Controls.Add(txtDni);
            pnlCuerpo.Controls.Add(btnBuscar);
            pnlCuerpo.Controls.Add(lblNombreLabel);
            pnlCuerpo.Controls.Add(lblNombreDato);
            pnlCuerpo.Controls.Add(lblVencimientoLabel);
            pnlCuerpo.Controls.Add(lblVencimientoDato);
            pnlCuerpo.Controls.Add(btnRenovar);
            pnlCuerpo.Controls.Add(btnCancelar);
            pnlCuerpo.Dock = DockStyle.Fill;
            pnlCuerpo.Location = new Point(0, 70);
            pnlCuerpo.Name = "pnlCuerpo";
            pnlCuerpo.Size = new Size(500, 330);
            pnlCuerpo.TabIndex = 1;
            pnlCuerpo.Paint += pnlCuerpo_Paint;
            // 
            // lblDniBusqueda
            // 
            lblDniBusqueda.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDniBusqueda.ForeColor = Color.FromArgb(47, 47, 47);
            lblDniBusqueda.Location = new Point(40, 30);
            lblDniBusqueda.Name = "lblDniBusqueda";
            lblDniBusqueda.Size = new Size(100, 25);
            lblDniBusqueda.TabIndex = 0;
            lblDniBusqueda.Text = "Ingrese DNI:";
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.Font = new Font("Segoe UI", 10F);
            txtDni.Location = new Point(150, 27);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(180, 25);
            txtDni.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(58, 80, 107);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(350, 25);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 30);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblNombreLabel
            // 
            lblNombreLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombreLabel.ForeColor = Color.FromArgb(47, 47, 47);
            lblNombreLabel.Location = new Point(40, 100);
            lblNombreLabel.Name = "lblNombreLabel";
            lblNombreLabel.Size = new Size(100, 25);
            lblNombreLabel.TabIndex = 3;
            lblNombreLabel.Text = "Nombre:";
            // 
            // lblNombreDato
            // 
            lblNombreDato.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNombreDato.ForeColor = Color.FromArgb(58, 80, 107);
            lblNombreDato.Location = new Point(150, 100);
            lblNombreDato.Name = "lblNombreDato";
            lblNombreDato.Size = new Size(300, 25);
            lblNombreDato.TabIndex = 4;
            lblNombreDato.Text = "-";
            // 
            // lblVencimientoLabel
            // 
            lblVencimientoLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVencimientoLabel.ForeColor = Color.FromArgb(47, 47, 47);
            lblVencimientoLabel.Location = new Point(40, 140);
            lblVencimientoLabel.Name = "lblVencimientoLabel";
            lblVencimientoLabel.Size = new Size(100, 25);
            lblVencimientoLabel.TabIndex = 5;
            lblVencimientoLabel.Text = "Vence el:";
            // 
            // lblVencimientoDato
            // 
            lblVencimientoDato.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblVencimientoDato.ForeColor = Color.FromArgb(47, 47, 47);
            lblVencimientoDato.Location = new Point(150, 140);
            lblVencimientoDato.Name = "lblVencimientoDato";
            lblVencimientoDato.Size = new Size(300, 25);
            lblVencimientoDato.TabIndex = 6;
            lblVencimientoDato.Text = "-";
            // 
            // btnRenovar
            // 
            btnRenovar.BackColor = Color.FromArgb(90, 113, 132);
            btnRenovar.Cursor = Cursors.Hand;
            btnRenovar.Enabled = false;
            btnRenovar.FlatAppearance.BorderSize = 0;
            btnRenovar.FlatStyle = FlatStyle.Flat;
            btnRenovar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRenovar.ForeColor = Color.White;
            btnRenovar.Location = new Point(270, 230);
            btnRenovar.Name = "btnRenovar";
            btnRenovar.Size = new Size(180, 45);
            btnRenovar.TabIndex = 7;
            btnRenovar.Text = "RENOVAR (1 AÑO)";
            btnRenovar.UseVisualStyleBackColor = false;
            btnRenovar.Click += btnRenovar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(231, 215, 193);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(47, 47, 47);
            btnCancelar.Location = new Point(50, 230);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 45);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "VOLVER";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormRenovarApto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 400);
            Controls.Add(pnlCuerpo);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormRenovarApto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Renovación Apto Médico - Club Emma 21";
            Load += FormRenovarApto_Load;
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
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNombreLabel;
        private System.Windows.Forms.Label lblNombreDato;
        private System.Windows.Forms.Label lblVencimientoLabel;
        private System.Windows.Forms.Label lblVencimientoDato;
        private System.Windows.Forms.Button btnRenovar;
        private System.Windows.Forms.Button btnCancelar;
    }
}