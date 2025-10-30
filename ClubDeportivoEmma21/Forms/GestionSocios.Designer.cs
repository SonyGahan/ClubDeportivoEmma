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
            pnlHeader = new Panel();
            lblTitulo = new Label();
            pnlMain = new Panel();
            btnSocioRegistrarSocio = new Button();
            btnSocioModificar = new Button();
            btnSocioPagoCuota = new Button();
            btnSocioCarnet = new Button();
            btnSocioVolver = new Button();
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
            lblTitulo.Text = "Gestión de Socios";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(btnSocioRegistrarSocio);
            pnlMain.Controls.Add(btnSocioModificar);
            pnlMain.Controls.Add(btnSocioPagoCuota);
            pnlMain.Controls.Add(btnSocioCarnet);
            pnlMain.Controls.Add(btnSocioVolver);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 80);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(40);
            pnlMain.Size = new Size(600, 360);
            pnlMain.TabIndex = 0;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // btnSocioRegistrarSocio
            // 
            btnSocioRegistrarSocio.Location = new Point(120, 60);
            btnSocioRegistrarSocio.Name = "btnSocioRegistrarSocio";
            btnSocioRegistrarSocio.Size = new Size(160, 55);
            btnSocioRegistrarSocio.TabIndex = 0;
            btnSocioRegistrarSocio.Text = "Registrar Socio";
            btnSocioRegistrarSocio.UseVisualStyleBackColor = true;
            btnSocioRegistrarSocio.Click += btnSocioRegistrarSocio_Click;
            // 
            // btnSocioModificar
            // 
            btnSocioModificar.Location = new Point(340, 60);
            btnSocioModificar.Name = "btnSocioModificar";
            btnSocioModificar.Size = new Size(160, 55);
            btnSocioModificar.TabIndex = 1;
            btnSocioModificar.Text = "Modificar Datos";
            btnSocioModificar.UseVisualStyleBackColor = true;
            btnSocioModificar.Click += btnSocioModificar_Click;
            // 
            // btnSocioPagoCuota
            // 
            btnSocioPagoCuota.Location = new Point(120, 170);
            btnSocioPagoCuota.Name = "btnSocioPagoCuota";
            btnSocioPagoCuota.Size = new Size(160, 55);
            btnSocioPagoCuota.TabIndex = 2;
            btnSocioPagoCuota.Text = "Pago Mensual";
            btnSocioPagoCuota.UseVisualStyleBackColor = true;
            btnSocioPagoCuota.Click += btnSocioPagoCuota_Click;
            // 
            // btnSocioCarnet
            // 
            btnSocioCarnet.Location = new Point(340, 170);
            btnSocioCarnet.Name = "btnSocioCarnet";
            btnSocioCarnet.Size = new Size(160, 55);
            btnSocioCarnet.TabIndex = 3;
            btnSocioCarnet.Text = "Impresión Carnet";
            btnSocioCarnet.UseVisualStyleBackColor = true;
            btnSocioCarnet.Click += btnSocioCarnet_Click;
            // 
            // btnSocioVolver
            // 
            btnSocioVolver.Location = new Point(255, 280);
            btnSocioVolver.Name = "btnSocioVolver";
            btnSocioVolver.Size = new Size(90, 40);
            btnSocioVolver.TabIndex = 4;
            btnSocioVolver.Text = "Volver";
            btnSocioVolver.UseVisualStyleBackColor = true;
            btnSocioVolver.Click += btnSocioVolver_Click;
            // 
            // GestionSocios
            // 
            BackColor = Color.FromArgb(232, 237, 242);
            ClientSize = new Size(600, 440);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "GestionSocios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Socios - Club Deportivo Emma 21";
            Load += GestionSocios_Load;
            pnlHeader.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitulo;
        private Panel pnlMain;
        private Button btnSocioRegistrarSocio;
        private Button btnSocioModificar;
        private Button btnSocioPagoCuota;
        private Button btnSocioCarnet;
        private Button btnSocioVolver;
    }
}


