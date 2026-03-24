namespace ClubDeportivoEmma21.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pnlLogoContainer = new Panel();
            lblTituloClub = new Label();
            picLogo = new PictureBox();
            pnlCuerpo = new Panel();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            btnSalir = new Button();
            pnlLogoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlCuerpo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogoContainer
            // 
            pnlLogoContainer.BackColor = Color.White;
            pnlLogoContainer.Controls.Add(lblTituloClub);
            pnlLogoContainer.Controls.Add(picLogo);
            pnlLogoContainer.Dock = DockStyle.Top;
            pnlLogoContainer.Location = new Point(0, 0);
            pnlLogoContainer.Name = "pnlLogoContainer";
            pnlLogoContainer.Size = new Size(450, 240);
            pnlLogoContainer.TabIndex = 0;
            // 
            // lblTituloClub
            // 
            lblTituloClub.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloClub.ForeColor = Color.FromArgb(58, 80, 107);
            lblTituloClub.Location = new Point(0, 180);
            lblTituloClub.Name = "lblTituloClub";
            lblTituloClub.Size = new Size(450, 40);
            lblTituloClub.TabIndex = 1;
            lblTituloClub.Text = "Club Deportivo Emma 21";
            lblTituloClub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(125, 20);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(200, 150);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pnlCuerpo
            // 
            pnlCuerpo.BackColor = Color.FromArgb(232, 237, 242);
            pnlCuerpo.Controls.Add(lblUsuario);
            pnlCuerpo.Controls.Add(txtUsuario);
            pnlCuerpo.Controls.Add(lblPassword);
            pnlCuerpo.Controls.Add(txtPassword);
            pnlCuerpo.Controls.Add(btnIngresar);
            pnlCuerpo.Controls.Add(btnSalir);
            pnlCuerpo.Dock = DockStyle.Fill;
            pnlCuerpo.Location = new Point(0, 240);
            pnlCuerpo.Name = "pnlCuerpo";
            pnlCuerpo.Size = new Size(450, 410);
            pnlCuerpo.TabIndex = 1;
            pnlCuerpo.Paint += pnlCuerpo_Paint;
            // 
            // lblUsuario
            // 
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(47, 47, 47);
            lblUsuario.Location = new Point(75, 40);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(100, 25);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "USUARIO";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(75, 70);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(300, 29);
            txtUsuario.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(47, 47, 47);
            lblPassword.Location = new Point(75, 120);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "CONTRASEÑA";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(75, 150);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(300, 29);
            txtPassword.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(58, 80, 107);
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(75, 230);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(300, 55);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "ACCEDER";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(231, 215, 193);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(47, 47, 47);
            btnSalir.Location = new Point(150, 310);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 45);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 650);
            Controls.Add(pnlCuerpo);
            Controls.Add(pnlLogoContainer);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Emma 21 - Ingreso al Sistema";
            Load += FormLogin_Load;
            pnlLogoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlCuerpo.ResumeLayout(false);
            pnlCuerpo.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlLogoContainer;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTituloClub;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
    }
}