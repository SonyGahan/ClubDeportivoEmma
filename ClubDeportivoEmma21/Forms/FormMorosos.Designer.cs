namespace ClubDeportivoEmma21.Forms
{
    partial class FormMorosos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnMorososImprimir = new Button();
            btnMorososExportar = new Button();
            btnMorososVolver = new Button();
            lstSociosMorosos = new ListView();
            txtTituloMorosos = new TextBox();
            SuspendLayout();
            // 
            // btnMorososImprimir
            // 
            btnMorososImprimir.Location = new Point(522, 94);
            btnMorososImprimir.Name = "btnMorososImprimir";
            btnMorososImprimir.Size = new Size(83, 26);
            btnMorososImprimir.TabIndex = 0;
            btnMorososImprimir.Text = "Imprimir";
            btnMorososImprimir.UseVisualStyleBackColor = true;
            btnMorososImprimir.Click += btnMorososImprimir_Click;
            // 
            // btnMorososExportar
            // 
            btnMorososExportar.Location = new Point(522, 61);
            btnMorososExportar.Name = "btnMorososExportar";
            btnMorososExportar.Size = new Size(83, 27);
            btnMorososExportar.TabIndex = 1;
            btnMorososExportar.Text = "Exportar";
            btnMorososExportar.UseVisualStyleBackColor = true;
            btnMorososExportar.Click += btnMorososExportar_Click;
            // 
            // btnMorososVolver
            // 
            btnMorososVolver.Location = new Point(522, 126);
            btnMorososVolver.Name = "btnMorososVolver";
            btnMorososVolver.Size = new Size(83, 28);
            btnMorososVolver.TabIndex = 2;
            btnMorososVolver.Text = "Volver";
            btnMorososVolver.UseVisualStyleBackColor = true;
            btnMorososVolver.Click += btnMorososVolver_Click;
            // 
            // lstSociosMorosos
            // 
            lstSociosMorosos.Location = new Point(40, 60);
            lstSociosMorosos.Name = "lstSociosMorosos";
            lstSociosMorosos.Size = new Size(459, 281);
            lstSociosMorosos.TabIndex = 3;
            lstSociosMorosos.UseCompatibleStateImageBehavior = false;
            // 
            // txtTituloMorosos
            // 
            txtTituloMorosos.Location = new Point(40, 31);
            txtTituloMorosos.Name = "txtTituloMorosos";
            txtTituloMorosos.Size = new Size(187, 23);
            txtTituloMorosos.TabIndex = 4;
            txtTituloMorosos.Text = "Listado de Socios Morosos:";
            // 
            // FormMorosos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 237, 242);
            ClientSize = new Size(677, 366);
            Controls.Add(txtTituloMorosos);
            Controls.Add(lstSociosMorosos);
            Controls.Add(btnMorososVolver);
            Controls.Add(btnMorososExportar);
            Controls.Add(btnMorososImprimir);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMorosos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reporte de Vencimientos - Club Deportivo Emma 21";
            Load += FormMorosos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMorososImprimir;
        private Button btnMorososExportar;
        private Button btnMorososVolver;
        private ListView lstSociosMorosos;
        private TextBox txtTituloMorosos;
    }
}
