namespace ClubDeportivoEmma21.Forms
{
    partial class FormMorosos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            btnMorososImprimir.Size = new Size(70, 26);
            btnMorososImprimir.TabIndex = 0;
            btnMorososImprimir.Text = "Imprimir";
            btnMorososImprimir.UseVisualStyleBackColor = true;
            btnMorososImprimir.Click += btnMorososImprimir_Click;
            // 
            // btnMorososExportar
            // 
            btnMorososExportar.Location = new Point(522, 61);
            btnMorososExportar.Name = "btnMorososExportar";
            btnMorososExportar.Size = new Size(70, 27);
            btnMorososExportar.TabIndex = 1;
            btnMorososExportar.Text = "Exportar";
            btnMorososExportar.UseVisualStyleBackColor = true;
            btnMorososExportar.Click += btnMorososExportar_Click;
            // 
            // btnMorososVolver
            // 
            btnMorososVolver.Location = new Point(522, 126);
            btnMorososVolver.Name = "btnMorososVolver";
            btnMorososVolver.Size = new Size(70, 28);
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
            txtTituloMorosos.Size = new Size(158, 23);
            txtTituloMorosos.TabIndex = 4;
            txtTituloMorosos.Text = "Listado de Socios Morosos:";
            // 
            // FormMorosos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 366);
            Controls.Add(txtTituloMorosos);
            Controls.Add(lstSociosMorosos);
            Controls.Add(btnMorososVolver);
            Controls.Add(btnMorososExportar);
            Controls.Add(btnMorososImprimir);
            Name = "FormMorosos";
            Text = "Reporte de Vencimientos";
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