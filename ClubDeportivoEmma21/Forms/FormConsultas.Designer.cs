namespace ClubDeportivoEmma21.Forms
{
    partial class FormConsultas
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
            lblConsultaDniPersona = new Label();
            txtConsultaDniPersona = new TextBox();
            btnBuscar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblConsultaDniPersona
            // 
            lblConsultaDniPersona.AutoSize = true;
            lblConsultaDniPersona.Location = new Point(62, 26);
            lblConsultaDniPersona.Name = "lblConsultaDniPersona";
            lblConsultaDniPersona.Size = new Size(72, 15);
            lblConsultaDniPersona.TabIndex = 0;
            lblConsultaDniPersona.Text = "DNI Persona";
            // 
            // txtConsultaDniPersona
            // 
            txtConsultaDniPersona.Location = new Point(174, 23);
            txtConsultaDniPersona.Name = "txtConsultaDniPersona";
            txtConsultaDniPersona.Size = new Size(140, 23);
            txtConsultaDniPersona.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(62, 88);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(89, 31);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(225, 88);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(89, 31);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 237, 242);
            ClientSize = new Size(398, 169);
            Controls.Add(btnVolver);
            Controls.Add(btnBuscar);
            Controls.Add(txtConsultaDniPersona);
            Controls.Add(lblConsultaDniPersona);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormConsultas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de Clientes - Club Deportivo Emma 21";
            Load += FormConsultas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConsultaDniPersona;
        private TextBox txtConsultaDniPersona;
        private Button btnBuscar;
        private Button btnVolver;
    }
}
