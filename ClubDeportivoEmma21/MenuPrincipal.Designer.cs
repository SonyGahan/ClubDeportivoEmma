namespace ClubDeportivoEmma21.Forms
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            pnlSidebar = new Panel();
            lblUserStatus = new Label();
            btnConsultas = new Button();
            btnMorosos = new Button();
            btnRenovarApto = new Button();
            btnLogOut = new Button();
            picFondo = new PictureBox();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFondo).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(58, 80, 107);
            pnlSidebar.Controls.Add(lblUserStatus);
            pnlSidebar.Controls.Add(btnConsultas);
            pnlSidebar.Controls.Add(btnMorosos);
            pnlSidebar.Controls.Add(btnRenovarApto);
            pnlSidebar.Controls.Add(btnLogOut);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(250, 650);
            pnlSidebar.TabIndex = 0;
            // 
            // lblUserStatus
            // 
            lblUserStatus.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblUserStatus.ForeColor = Color.FromArgb(231, 215, 193);
            lblUserStatus.Location = new Point(10, 20);
            lblUserStatus.Name = "lblUserStatus";
            lblUserStatus.Size = new Size(230, 60);
            lblUserStatus.TabIndex = 0;
            lblUserStatus.Text = "Sesión: -";
            lblUserStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnConsultas
            // 
            btnConsultas.BackColor = Color.FromArgb(90, 113, 132);
            btnConsultas.Cursor = Cursors.Hand;
            btnConsultas.FlatAppearance.BorderSize = 0;
            btnConsultas.FlatStyle = FlatStyle.Flat;
            btnConsultas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConsultas.ForeColor = Color.White;
            btnConsultas.Location = new Point(10, 100);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Size = new Size(230, 50);
            btnConsultas.TabIndex = 1;
            btnConsultas.Text = "BUSCAR CLIENTE";
            btnConsultas.UseVisualStyleBackColor = false;
            btnConsultas.Click += btnConsultas_Click;
            // 
            // btnMorosos
            // 
            btnMorosos.BackColor = Color.FromArgb(90, 113, 132);
            btnMorosos.Cursor = Cursors.Hand;
            btnMorosos.FlatAppearance.BorderSize = 0;
            btnMorosos.FlatStyle = FlatStyle.Flat;
            btnMorosos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMorosos.ForeColor = Color.White;
            btnMorosos.Location = new Point(10, 170);
            btnMorosos.Name = "btnMorosos";
            btnMorosos.Size = new Size(230, 50);
            btnMorosos.TabIndex = 2;
            btnMorosos.Text = "VER MOROSOS";
            btnMorosos.UseVisualStyleBackColor = false;
            btnMorosos.Click += btnMorosos_Click;
            // 
            // btnRenovarApto
            // 
            btnRenovarApto.BackColor = Color.FromArgb(90, 113, 132);
            btnRenovarApto.Cursor = Cursors.Hand;
            btnRenovarApto.FlatAppearance.BorderSize = 0;
            btnRenovarApto.FlatStyle = FlatStyle.Flat;
            btnRenovarApto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRenovarApto.ForeColor = Color.White;
            btnRenovarApto.Location = new Point(10, 240);
            btnRenovarApto.Name = "btnRenovarApto";
            btnRenovarApto.Size = new Size(230, 50);
            btnRenovarApto.TabIndex = 3;
            btnRenovarApto.Text = "RENOVAR APTO";
            btnRenovarApto.UseVisualStyleBackColor = false;
            btnRenovarApto.Click += btnRenovarApto_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(231, 215, 193);
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogOut.ForeColor = Color.FromArgb(47, 47, 47);
            btnLogOut.Location = new Point(25, 580);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(200, 45);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "CERRAR SESIÓN";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // picFondo
            // 
            picFondo.Dock = DockStyle.Fill;
            picFondo.Image = (Image)resources.GetObject("picFondo.Image");
            picFondo.Location = new Point(250, 0);
            picFondo.Name = "picFondo";
            picFondo.Size = new Size(750, 650);
            picFondo.SizeMode = PictureBoxSizeMode.StretchImage;
            picFondo.TabIndex = 1;
            picFondo.TabStop = false;
            picFondo.Click += picFondo_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(picFondo);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Emma 21 - Menú Principal";
            Load += MenuPrincipal_Load;
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picFondo).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblUserStatus;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnMorosos;
        private System.Windows.Forms.Button btnRenovarApto;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox picFondo;
    }
}