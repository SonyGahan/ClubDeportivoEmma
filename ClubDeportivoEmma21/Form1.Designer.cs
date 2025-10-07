namespace ClubDeportivoEmma21
{
    partial class Form1
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
            btnAltas = new Button();
            btnConsultas = new Button();
            btnMorosos = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnAltas
            // 
            btnAltas.Location = new Point(96, 54);
            btnAltas.Name = "btnAltas";
            btnAltas.Size = new Size(195, 57);
            btnAltas.TabIndex = 0;
            btnAltas.Text = "Altas";
            btnAltas.UseVisualStyleBackColor = true;
            btnAltas.Click += btnAltas_Click;
            // 
            // btnConsultas
            // 
            btnConsultas.Location = new Point(363, 54);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Size = new Size(195, 57);
            btnConsultas.TabIndex = 1;
            btnConsultas.Text = "Consultas";
            btnConsultas.UseVisualStyleBackColor = true;
            btnConsultas.Click += btnConsultas_Click;
            // 
            // btnMorosos
            // 
            btnMorosos.Location = new Point(96, 158);
            btnMorosos.Name = "btnMorosos";
            btnMorosos.Size = new Size(195, 57);
            btnMorosos.TabIndex = 2;
            btnMorosos.Text = "Listado de Morosos";
            btnMorosos.UseVisualStyleBackColor = true;
            btnMorosos.Click += btnMorosos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(363, 158);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(195, 57);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 298);
            Controls.Add(btnSalir);
            Controls.Add(btnMorosos);
            Controls.Add(btnConsultas);
            Controls.Add(btnAltas);
            Name = "Form1";
            Text = "Menú Principal";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAltas;
        private Button btnConsultas;
        private Button btnMorosos;
        private Button btnSalir;
    }
}