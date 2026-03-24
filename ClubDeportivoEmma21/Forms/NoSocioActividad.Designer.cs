namespace ClubDeportivoEmma21.Forms
{
    partial class NoSocioActividad
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
            lblActividadLabel = new Label();
            cmbActividad = new ComboBox();
            lblMontoLabel = new Label();
            lblMontoDato = new Label();
            btnRegistrar = new Button();
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
            pnlHeader.Size = new Size(550, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.WhiteSmoke;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(550, 70);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Inscripción Actividad Diaria";
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
            pnlCuerpo.Controls.Add(lblActividadLabel);
            pnlCuerpo.Controls.Add(cmbActividad);
            pnlCuerpo.Controls.Add(lblMontoLabel);
            pnlCuerpo.Controls.Add(lblMontoDato);
            pnlCuerpo.Controls.Add(btnRegistrar);
            pnlCuerpo.Controls.Add(btnCancelar);
            pnlCuerpo.Dock = DockStyle.Fill;
            pnlCuerpo.Location = new Point(0, 70);
            pnlCuerpo.Name = "pnlCuerpo";
            pnlCuerpo.Size = new Size(550, 360);
            pnlCuerpo.TabIndex = 1;
            pnlCuerpo.Paint += pnlCuerpo_Paint;
            // 
            // lblDniBusqueda
            // 
            lblDniBusqueda.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDniBusqueda.ForeColor = Color.FromArgb(47, 47, 47);
            lblDniBusqueda.Location = new Point(40, 30);
            lblDniBusqueda.Name = "lblDniBusqueda";
            lblDniBusqueda.Size = new Size(120, 25);
            lblDniBusqueda.TabIndex = 0;
            lblDniBusqueda.Text = "DNI No Socio:";
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.Font = new Font("Segoe UI", 10F);
            txtDni.Location = new Point(170, 27);
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
            btnBuscar.Location = new Point(370, 25);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 30);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblNombreLabel
            // 
            lblNombreLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombreLabel.Location = new Point(40, 85);
            lblNombreLabel.Name = "lblNombreLabel";
            lblNombreLabel.Size = new Size(120, 25);
            lblNombreLabel.TabIndex = 3;
            lblNombreLabel.Text = "Nombre:";
            // 
            // lblNombreDato
            // 
            lblNombreDato.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNombreDato.ForeColor = Color.FromArgb(58, 80, 107);
            lblNombreDato.Location = new Point(170, 85);
            lblNombreDato.Name = "lblNombreDato";
            lblNombreDato.Size = new Size(320, 25);
            lblNombreDato.TabIndex = 4;
            lblNombreDato.Text = "-";
            // 
            // lblActividadLabel
            // 
            lblActividadLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblActividadLabel.Location = new Point(40, 140);
            lblActividadLabel.Name = "lblActividadLabel";
            lblActividadLabel.Size = new Size(120, 25);
            lblActividadLabel.TabIndex = 5;
            lblActividadLabel.Text = "Seleccione Actividad:";
            // 
            // cmbActividad
            // 
            cmbActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActividad.Font = new Font("Segoe UI", 10F);
            cmbActividad.Location = new Point(170, 137);
            cmbActividad.Name = "cmbActividad";
            cmbActividad.Size = new Size(320, 25);
            cmbActividad.TabIndex = 3;
            cmbActividad.SelectedIndexChanged += cmbActividad_SelectedIndexChanged;
            // 
            // lblMontoLabel
            // 
            lblMontoLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMontoLabel.Location = new Point(40, 195);
            lblMontoLabel.Name = "lblMontoLabel";
            lblMontoLabel.Size = new Size(120, 25);
            lblMontoLabel.TabIndex = 6;
            lblMontoLabel.Text = "Costo del día:";
            // 
            // lblMontoDato
            // 
            lblMontoDato.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMontoDato.ForeColor = Color.DarkGreen;
            lblMontoDato.Location = new Point(170, 190);
            lblMontoDato.Name = "lblMontoDato";
            lblMontoDato.Size = new Size(320, 35);
            lblMontoDato.TabIndex = 7;
            lblMontoDato.Text = "$ 0.00";
            lblMontoDato.Click += lblMontoDato_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(90, 113, 132);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.Enabled = false;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(300, 270);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(190, 55);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "REGISTRAR PAGO";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(231, 215, 193);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(47, 47, 47);
            btnCancelar.Location = new Point(40, 270);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(190, 55);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // NoSocioActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 430);
            Controls.Add(pnlCuerpo);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "NoSocioActividad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscripción Diaria - Club Emma 21";
            Load += NoSocioActividad_Load;
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
        private System.Windows.Forms.Label lblActividadLabel;
        private System.Windows.Forms.ComboBox cmbActividad;
        private System.Windows.Forms.Label lblMontoLabel;
        private System.Windows.Forms.Label lblMontoDato;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}