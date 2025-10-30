namespace ClubDeportivoEmma21
{
    partial class Form1
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
            panelHeader = new Panel();
            lblLogo = new Label();
            lblTitulo = new Label();
            panelFooter = new Panel();
            lblFooter = new Label();
            btnConsultas = new Button();
            btnGestionSocios = new Button();
            btnGestionNoSocios = new Button();
            btnMorosos = new Button();
            btnSalir = new Button();
            panelHeader.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(58, 80, 107);
            panelHeader.Controls.Add(lblLogo);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(612, 70);
            panelHeader.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(212, 175, 55);
            lblLogo.Location = new Point(20, 15);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(60, 40);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "E21";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(90, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(409, 25);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Club Deportivo Emma 21 – Sistema de Gestión";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(197, 208, 218);
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 401);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(612, 40);
            panelFooter.TabIndex = 1;
            // 
            // lblFooter
            // 
            lblFooter.Dock = DockStyle.Fill;
            lblFooter.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblFooter.ForeColor = Color.FromArgb(47, 47, 47);
            lblFooter.Location = new Point(0, 0);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(612, 40);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "© 2025 Club Deportivo Emma 21 – Todos los derechos reservados";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConsultas
            // 
            btnConsultas.BackColor = Color.FromArgb(90, 113, 132);
            btnConsultas.FlatAppearance.BorderSize = 0;
            btnConsultas.FlatStyle = FlatStyle.Flat;
            btnConsultas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnConsultas.ForeColor = Color.White;
            btnConsultas.Location = new Point(102, 127);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Size = new Size(168, 54);
            btnConsultas.TabIndex = 2;
            btnConsultas.Text = "Consultas";
            btnConsultas.UseVisualStyleBackColor = false;
            btnConsultas.Click += btnConsultas_Click;
            btnConsultas.MouseEnter += BtnHoverEnter;
            btnConsultas.MouseLeave += BtnHoverLeave;
            // 
            // btnGestionSocios
            // 
            btnGestionSocios.BackColor = Color.FromArgb(90, 113, 132);
            btnGestionSocios.FlatAppearance.BorderSize = 0;
            btnGestionSocios.FlatStyle = FlatStyle.Flat;
            btnGestionSocios.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGestionSocios.ForeColor = Color.White;
            btnGestionSocios.Location = new Point(102, 213);
            btnGestionSocios.Name = "btnGestionSocios";
            btnGestionSocios.Size = new Size(168, 52);
            btnGestionSocios.TabIndex = 0;
            btnGestionSocios.Text = "Gestión Socios";
            btnGestionSocios.UseVisualStyleBackColor = false;
            btnGestionSocios.Click += btnGestionSocios_Click;
            btnGestionSocios.MouseEnter += BtnHoverEnter;
            btnGestionSocios.MouseLeave += BtnHoverLeave;
            // 
            // btnGestionNoSocios
            // 
            btnGestionNoSocios.BackColor = Color.FromArgb(90, 113, 132);
            btnGestionNoSocios.FlatAppearance.BorderSize = 0;
            btnGestionNoSocios.FlatStyle = FlatStyle.Flat;
            btnGestionNoSocios.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGestionNoSocios.ForeColor = Color.White;
            btnGestionNoSocios.Location = new Point(343, 213);
            btnGestionNoSocios.Name = "btnGestionNoSocios";
            btnGestionNoSocios.Size = new Size(167, 52);
            btnGestionNoSocios.TabIndex = 1;
            btnGestionNoSocios.Text = "Gestión No Socios";
            btnGestionNoSocios.UseVisualStyleBackColor = false;
            btnGestionNoSocios.Click += btnGestionNoSocios_Click;
            btnGestionNoSocios.MouseEnter += BtnHoverEnter;
            btnGestionNoSocios.MouseLeave += BtnHoverLeave;
            // 
            // btnMorosos
            // 
            btnMorosos.BackColor = Color.FromArgb(90, 113, 132);
            btnMorosos.FlatAppearance.BorderSize = 0;
            btnMorosos.FlatStyle = FlatStyle.Flat;
            btnMorosos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnMorosos.ForeColor = Color.White;
            btnMorosos.Location = new Point(343, 127);
            btnMorosos.Name = "btnMorosos";
            btnMorosos.Size = new Size(167, 54);
            btnMorosos.TabIndex = 3;
            btnMorosos.Text = "Listado Morosos";
            btnMorosos.UseVisualStyleBackColor = false;
            btnMorosos.Click += btnMorosos_Click;
            btnMorosos.MouseEnter += BtnHoverEnter;
            btnMorosos.MouseLeave += BtnHoverLeave;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(231, 215, 193); // Beige claro
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(47, 47, 47);
            btnSalir.Location = new Point(252, 330);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 40);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Click += btnSalir_Click;
            btnSalir.MouseEnter += BtnSalirHoverEnter;
            btnSalir.MouseLeave += BtnSalirHoverLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 237, 242);
            ClientSize = new Size(612, 441);
            Controls.Add(btnGestionSocios);
            Controls.Add(btnGestionNoSocios);
            Controls.Add(btnConsultas);
            Controls.Add(btnMorosos);
            Controls.Add(btnSalir);
            Controls.Add(panelHeader);
            Controls.Add(panelFooter);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal - Club Deportivo Emma 21";
            Load += Form1_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblLogo;
        private Label lblTitulo;
        private Panel panelFooter;
        private Label lblFooter;
        private Button btnConsultas;
        private Button btnGestionSocios;
        private Button btnGestionNoSocios;
        private Button btnMorosos;
        private Button btnSalir;
    }
}

