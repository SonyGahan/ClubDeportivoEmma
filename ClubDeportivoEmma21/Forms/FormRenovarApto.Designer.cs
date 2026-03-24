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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.lblDniBusqueda = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNombreLabel = new System.Windows.Forms.Label();
            this.lblNombreDato = new System.Windows.Forms.Label();
            this.lblVencimientoLabel = new System.Windows.Forms.Label();
            this.lblVencimientoDato = new System.Windows.Forms.Label();
            this.btnRenovar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlCuerpo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(500, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(500, 70);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Renovación Apto Médico";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.pnlCuerpo.Controls.Add(this.lblDniBusqueda);
            this.pnlCuerpo.Controls.Add(this.txtDni);
            this.pnlCuerpo.Controls.Add(this.btnBuscar);
            this.pnlCuerpo.Controls.Add(this.lblNombreLabel);
            this.pnlCuerpo.Controls.Add(this.lblNombreDato);
            this.pnlCuerpo.Controls.Add(this.lblVencimientoLabel);
            this.pnlCuerpo.Controls.Add(this.lblVencimientoDato);
            this.pnlCuerpo.Controls.Add(this.btnRenovar);
            this.pnlCuerpo.Controls.Add(this.btnCancelar);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 70);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(500, 330);
            this.pnlCuerpo.TabIndex = 1;
            // 
            // lblDniBusqueda
            // 
            this.lblDniBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDniBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblDniBusqueda.Location = new System.Drawing.Point(40, 30);
            this.lblDniBusqueda.Name = "lblDniBusqueda";
            this.lblDniBusqueda.Size = new System.Drawing.Size(100, 25);
            this.lblDniBusqueda.TabIndex = 0;
            this.lblDniBusqueda.Text = "Ingrese DNI:";
            // 
            // txtDni
            // 
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDni.Location = new System.Drawing.Point(150, 27);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(180, 25);
            this.txtDni.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(350, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNombreLabel
            // 
            this.lblNombreLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblNombreLabel.Location = new System.Drawing.Point(40, 100);
            this.lblNombreLabel.Name = "lblNombreLabel";
            this.lblNombreLabel.Size = new System.Drawing.Size(100, 25);
            this.lblNombreLabel.TabIndex = 3;
            this.lblNombreLabel.Text = "Nombre:";
            // 
            // lblNombreDato
            // 
            this.lblNombreDato.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNombreDato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.lblNombreDato.Location = new System.Drawing.Point(150, 100);
            this.lblNombreDato.Name = "lblNombreDato";
            this.lblNombreDato.Size = new System.Drawing.Size(300, 25);
            this.lblNombreDato.TabIndex = 4;
            this.lblNombreDato.Text = "-";
            // 
            // lblVencimientoLabel
            // 
            this.lblVencimientoLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblVencimientoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblVencimientoLabel.Location = new System.Drawing.Point(40, 140);
            this.lblVencimientoLabel.Name = "lblVencimientoLabel";
            this.lblVencimientoLabel.Size = new System.Drawing.Size(100, 25);
            this.lblVencimientoLabel.TabIndex = 5;
            this.lblVencimientoLabel.Text = "Vence el:";
            // 
            // lblVencimientoDato
            // 
            this.lblVencimientoDato.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblVencimientoDato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblVencimientoDato.Location = new System.Drawing.Point(150, 140);
            this.lblVencimientoDato.Name = "lblVencimientoDato";
            this.lblVencimientoDato.Size = new System.Drawing.Size(300, 25);
            this.lblVencimientoDato.TabIndex = 6;
            this.lblVencimientoDato.Text = "-";
            // 
            // btnRenovar
            // 
            this.btnRenovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(113)))), ((int)(((byte)(132)))));
            this.btnRenovar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenovar.Enabled = false;
            this.btnRenovar.FlatAppearance.BorderSize = 0;
            this.btnRenovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenovar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRenovar.ForeColor = System.Drawing.Color.White;
            this.btnRenovar.Location = new System.Drawing.Point(270, 230);
            this.btnRenovar.Name = "btnRenovar";
            this.btnRenovar.Size = new System.Drawing.Size(180, 45);
            this.btnRenovar.TabIndex = 7;
            this.btnRenovar.Text = "RENOVAR (1 AÑO)";
            this.btnRenovar.UseVisualStyleBackColor = false;
            this.btnRenovar.Click += new System.EventHandler(this.btnRenovar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(215)))), ((int)(((byte)(193)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnCancelar.Location = new System.Drawing.Point(50, 230);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(180, 45);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "VOLVER";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormRenovarApto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormRenovarApto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renovación Apto Médico - Club Emma 21";
            this.Load += new System.EventHandler(this.FormRenovarApto_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlCuerpo.ResumeLayout(false);
            this.pnlCuerpo.PerformLayout();
            this.ResumeLayout(false);

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