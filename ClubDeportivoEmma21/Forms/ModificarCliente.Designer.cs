namespace ClubDeportivoEmma21.Forms
{
    partial class FormModificaCliente
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
            lblInstruccion = new Label();
            txtDniBusqueda = new TextBox();
            btnBuscar = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblMail = new Label();
            txtMail = new TextBox();
            btnGuardar = new Button();
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
            pnlHeader.Size = new Size(550, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(550, 80);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Modificar Datos de Socio";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCuerpo
            // 
            pnlCuerpo.BackColor = Color.FromArgb(232, 237, 242);
            pnlCuerpo.Controls.Add(lblInstruccion);
            pnlCuerpo.Controls.Add(txtDniBusqueda);
            pnlCuerpo.Controls.Add(btnBuscar);
            pnlCuerpo.Controls.Add(lblNombre);
            pnlCuerpo.Controls.Add(txtNombre);
            pnlCuerpo.Controls.Add(lblApellido);
            pnlCuerpo.Controls.Add(txtApellido);
            pnlCuerpo.Controls.Add(lblTelefono);
            pnlCuerpo.Controls.Add(txtTelefono);
            pnlCuerpo.Controls.Add(lblDireccion);
            pnlCuerpo.Controls.Add(txtDireccion);
            pnlCuerpo.Controls.Add(lblMail);
            pnlCuerpo.Controls.Add(txtMail);
            pnlCuerpo.Controls.Add(btnGuardar);
            pnlCuerpo.Controls.Add(btnCancelar);
            pnlCuerpo.Dock = DockStyle.Fill;
            pnlCuerpo.Location = new Point(0, 80);
            pnlCuerpo.Name = "pnlCuerpo";
            pnlCuerpo.Size = new Size(550, 470);
            pnlCuerpo.TabIndex = 1;
            pnlCuerpo.Paint += pnlCuerpo_Paint;
            // 
            // lblInstruccion
            // 
            lblInstruccion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInstruccion.Location = new Point(40, 30);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(120, 25);
            lblInstruccion.TabIndex = 0;
            lblInstruccion.Text = "DNI del Socio:";
            // 
            // txtDniBusqueda
            // 
            txtDniBusqueda.BorderStyle = BorderStyle.FixedSingle;
            txtDniBusqueda.Font = new Font("Segoe UI", 10F);
            txtDniBusqueda.Location = new Point(170, 27);
            txtDniBusqueda.Name = "txtDniBusqueda";
            txtDniBusqueda.Size = new Size(180, 25);
            txtDniBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(58, 80, 107);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(370, 25);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 30);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "BUSCAR SOCIO";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.Location = new Point(40, 100);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(120, 25);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(170, 97);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(320, 25);
            txtNombre.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblApellido.Location = new Point(40, 150);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(120, 25);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Font = new Font("Segoe UI", 10F);
            txtApellido.Location = new Point(170, 147);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(320, 25);
            txtApellido.TabIndex = 4;
            // 
            // lblTelefono
            // 
            lblTelefono.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTelefono.Location = new Point(40, 200);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(120, 25);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Font = new Font("Segoe UI", 10F);
            txtTelefono.Location = new Point(170, 197);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(320, 25);
            txtTelefono.TabIndex = 5;
            // 
            // lblDireccion
            // 
            lblDireccion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDireccion.Location = new Point(40, 250);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(120, 25);
            lblDireccion.TabIndex = 6;
            lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Font = new Font("Segoe UI", 10F);
            txtDireccion.Location = new Point(170, 247);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(320, 25);
            txtDireccion.TabIndex = 6;
            // 
            // lblMail
            // 
            lblMail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMail.Location = new Point(40, 300);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(120, 25);
            lblMail.TabIndex = 7;
            lblMail.Text = "E-mail:";
            // 
            // txtMail
            // 
            txtMail.BorderStyle = BorderStyle.FixedSingle;
            txtMail.Font = new Font("Segoe UI", 10F);
            txtMail.Location = new Point(170, 297);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(320, 25);
            txtMail.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(90, 113, 132);
            btnGuardar.Enabled = false;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(300, 380);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(190, 50);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "GUARDAR CAMBIOS";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(231, 215, 193);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(47, 47, 47);
            btnCancelar.Location = new Point(40, 380);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(190, 50);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormModificaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 550);
            Controls.Add(pnlCuerpo);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormModificaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Socio - Club Emma 21";
            Load += FormModificaCliente_Load;
            pnlHeader.ResumeLayout(false);
            pnlCuerpo.ResumeLayout(false);
            pnlCuerpo.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.TextBox txtDniBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}