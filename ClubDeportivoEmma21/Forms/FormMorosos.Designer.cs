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
            SuspendLayout();
            // 
            // btnMorososImprimir
            // 
            btnMorososImprimir.Location = new Point(61, 57);
            btnMorososImprimir.Name = "btnMorososImprimir";
            btnMorososImprimir.Size = new Size(121, 47);
            btnMorososImprimir.TabIndex = 0;
            btnMorososImprimir.Text = "Imprimir";
            btnMorososImprimir.UseVisualStyleBackColor = true;
            // 
            // btnMorososExportar
            // 
            btnMorososExportar.Location = new Point(226, 57);
            btnMorososExportar.Name = "btnMorososExportar";
            btnMorososExportar.Size = new Size(121, 47);
            btnMorososExportar.TabIndex = 1;
            btnMorososExportar.Text = "Exportar";
            btnMorososExportar.UseVisualStyleBackColor = true;
            // 
            // btnMorososVolver
            // 
            btnMorososVolver.Location = new Point(159, 161);
            btnMorososVolver.Name = "btnMorososVolver";
            btnMorososVolver.Size = new Size(107, 34);
            btnMorososVolver.TabIndex = 2;
            btnMorososVolver.Text = "Volver";
            btnMorososVolver.UseVisualStyleBackColor = true;
            // 
            // FormMorosos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 233);
            Controls.Add(btnMorososVolver);
            Controls.Add(btnMorososExportar);
            Controls.Add(btnMorososImprimir);
            Name = "FormMorosos";
            Text = "Reporte de Vencimientos";
            Load += FormMorosos_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnMorososImprimir;
        private Button btnMorososExportar;
        private Button btnMorososVolver;
    }
}