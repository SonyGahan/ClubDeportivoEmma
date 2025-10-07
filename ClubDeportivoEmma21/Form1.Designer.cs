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
            btnGestionSocios = new Button();
            btnConsultas = new Button();
            btnMorosos = new Button();
            btnSalir = new Button();
            btnGestionNoSocios = new Button();
            SuspendLayout();
            // 
            // btnGestionSocios
            // 
            btnGestionSocios.Location = new Point(96, 195);
            btnGestionSocios.Name = "btnGestionSocios";
            btnGestionSocios.Size = new Size(195, 57);
            btnGestionSocios.TabIndex = 0;
            btnGestionSocios.Text = "Gestión Socios";
            btnGestionSocios.UseVisualStyleBackColor = true;
            btnGestionSocios.Click += btnGestionSocios_Click;
            // 
            // btnConsultas
            // 
            btnConsultas.Location = new Point(96, 57);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Size = new Size(195, 57);
            btnConsultas.TabIndex = 1;
            btnConsultas.Text = "Consulta Clientes";
            btnConsultas.UseVisualStyleBackColor = true;
            btnConsultas.Click += btnConsultas_Click;
            // 
            // btnMorosos
            // 
            btnMorosos.Location = new Point(354, 57);
            btnMorosos.Name = "btnMorosos";
            btnMorosos.Size = new Size(195, 57);
            btnMorosos.TabIndex = 2;
            btnMorosos.Text = "Reporte de Vencimientos";
            btnMorosos.UseVisualStyleBackColor = true;
            btnMorosos.Click += btnMorosos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(263, 339);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(120, 42);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGestionNoSocios
            // 
            btnGestionNoSocios.Location = new Point(354, 195);
            btnGestionNoSocios.Name = "btnGestionNoSocios";
            btnGestionNoSocios.Size = new Size(195, 57);
            btnGestionNoSocios.TabIndex = 4;
            btnGestionNoSocios.Text = "Gestión No Socios";
            btnGestionNoSocios.UseVisualStyleBackColor = true;
            btnGestionNoSocios.Click += btnGestionNoSocios_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 414);
            Controls.Add(btnGestionNoSocios);
            Controls.Add(btnSalir);
            Controls.Add(btnMorosos);
            Controls.Add(btnConsultas);
            Controls.Add(btnGestionSocios);
            Name = "Form1";
            Text = "Menú Principal";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnGestionSocios;
        private Button btnConsultas;
        private Button btnMorosos;
        private Button btnSalir;
        private Button btnGestionNoSocios;
    }
}