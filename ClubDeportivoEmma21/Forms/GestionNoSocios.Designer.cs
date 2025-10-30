namespace ClubDeportivoEmma21.Forms
{
    partial class GestionNoSocios
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
            pnlMain = new Panel();
            btnNoSociosRegistrar = new Button();
            btnNoSociosModificar = new Button();
            btnNoSociosInscribirActividad = new Button();
            btnNoSociosVolver = new Button();
            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
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
            pnlHeader.TabIndex = 1;
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
            lblTitulo.Text = "Gestión de No Socios";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(btnNoSociosRegistrar);
            pnlMain.Controls.Add(btnNoSociosModificar);
            pnlMain.Controls.Add(btnNoSociosInscribirActividad);
            pnlMain.Controls.Add(btnNoSociosVolver);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 80);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(40);
            pnlMain.Size = new Size(600, 360);
            pnlMain.TabIndex = 0;
            // 
            // btnNoSociosRegistrar
            // 
            btnNoSociosRegistrar.Location = new Point(120, 60);
            btnNoSociosRegistrar.Name = "btnNoSociosRegistrar";
            btnNoSociosRegistrar.Size = new Size(160, 55);
            btnNoSociosRegistrar.TabIndex = 0;
            btnNoSociosRegistrar.Text = "Registrar No Socio";
            btnNoSociosRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnNoSociosModificar
            // 
            btnNoSociosModificar.Location = new Point(340, 60);
            btnNoSociosModificar.Name = "btnNoSociosModificar";
            btnNoSociosModificar.Size = new Size(160, 55);
            btnNoSociosModificar.TabIndex = 1;
            btnNoSociosModificar.Text = "Modificar Datos";
            btnNoSociosModificar.UseVisualStyleBackColor = true;
            // 
            // btnNoSociosInscribirActividad
            // 
            btnNoSociosInscribirActividad.Location = new Point(227, 167);
            btnNoSociosInscribirActividad.Name = "btnNoSociosInscribirActividad";
            btnNoSociosInscribirActividad.Size = new Size(160, 55);
            btnNoSociosInscribirActividad.TabIndex = 2;
            btnNoSociosInscribirActividad.Text = "Inscribir a Actividad";
            btnNoSociosInscribirActividad.UseVisualStyleBackColor = true;
            // 
            // btnNoSociosVolver
            // 
            btnNoSociosVolver.Location = new Point(263, 277);
            btnNoSociosVolver.Name = "btnNoSociosVolver";
            btnNoSociosVolver.Size = new Size(90, 40);
            btnNoSociosVolver.TabIndex = 3;
            btnNoSociosVolver.Text = "Volver";
            btnNoSociosVolver.UseVisualStyleBackColor = true;
            // 
            // GestionNoSocios
            // 
            BackColor = Color.FromArgb(232, 237, 242);
            ClientSize = new Size(600, 440);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "GestionNoSocios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de No Socios - Club Deportivo Emma 21";
            Load += GestionNoSocios_Load;
            pnlHeader.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitulo;
        private Panel pnlMain;
        private Button btnNoSociosRegistrar;
        private Button btnNoSociosModificar;
        private Button btnNoSociosInscribirActividad;
        private Button btnNoSociosVolver;
    }
}
