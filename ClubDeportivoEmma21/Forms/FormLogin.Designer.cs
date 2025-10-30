namespace ClubDeportivoEmma21.Forms
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelFondo = new Panel();
            panelLogin = new Panel();
            lblLogo = new Label();
            lblTitulo = new Label();
            lblUsuario = new Label();
            lblContrasena = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnLogin = new Button();
            btnSalir = new Button();
            lblMensaje = new Label();
            panelFondo.SuspendLayout();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelFondo
            // 
            panelFondo.BackColor = Color.FromArgb(58, 80, 107);
            panelFondo.Controls.Add(panelLogin);
            panelFondo.Dock = DockStyle.Fill;
            panelFondo.Location = new Point(0, 0);
            panelFondo.Name = "panelFondo";
            panelFondo.Size = new Size(570, 558);
            panelFondo.TabIndex = 0;
            panelFondo.Paint += panelFondo_Paint;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.WhiteSmoke;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(lblLogo);
            panelLogin.Controls.Add(lblTitulo);
            panelLogin.Controls.Add(lblUsuario);
            panelLogin.Controls.Add(lblContrasena);
            panelLogin.Controls.Add(txtUsuario);
            panelLogin.Controls.Add(txtContrasena);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(btnSalir);
            panelLogin.Controls.Add(lblMensaje);
            panelLogin.Location = new Point(110, 65);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(340, 405);
            panelLogin.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(212, 175, 55);
            lblLogo.Location = new Point(0, 10);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(339, 50);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "E21";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(47, 47, 47);
            lblTitulo.Location = new Point(0, 84);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(340, 23);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Acceso al Sistema de Gestión";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.Location = new Point(50, 130);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(100, 23);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContrasena
            // 
            lblContrasena.Font = new Font("Segoe UI", 10F);
            lblContrasena.Location = new Point(50, 200);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(100, 23);
            lblContrasena.TabIndex = 3;
            lblContrasena.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 10F);
            txtUsuario.Location = new Point(50, 155);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(240, 25);
            txtUsuario.TabIndex = 4;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 10F);
            txtContrasena.Location = new Point(50, 225);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '•';
            txtContrasena.Size = new Size(240, 25);
            txtContrasena.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(58, 80, 107);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.WhiteSmoke;
            btnLogin.Location = new Point(50, 280);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(240, 35);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseEnter += BtnHoverEnter;
            btnLogin.MouseLeave += BtnHoverLeave;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(197, 208, 218);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F);
            btnSalir.ForeColor = Color.FromArgb(47, 47, 47);
            btnSalir.Location = new Point(50, 325);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(240, 30);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            btnSalir.MouseEnter += BtnHoverEnter;
            btnSalir.MouseLeave += BtnHoverLeave;
            // 
            // lblMensaje
            // 
            lblMensaje.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblMensaje.ForeColor = Color.DarkRed;
            lblMensaje.Location = new Point(0, 260);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(340, 23);
            lblMensaje.TabIndex = 8;
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            ClientSize = new Size(570, 558);
            Controls.Add(panelFondo);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión - Club Deportivo Emma 21";
            Load += FormLogin_Load;
            panelFondo.ResumeLayout(false);
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblMensaje;
    }
}
