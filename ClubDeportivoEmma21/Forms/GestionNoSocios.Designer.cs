namespace ClubDeportivoEmma21.Forms
{
    partial class GestionNoSocios
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
            btnNoSociosRegistrar = new Button();
            btnNoSociosModificar = new Button();
            btnNoSociosInscribirActividad = new Button();
            btnNoSociosVolver = new Button();
            SuspendLayout();
            // 
            // btnNoSociosRegistrar
            // 
            btnNoSociosRegistrar.Location = new Point(89, 62);
            btnNoSociosRegistrar.Name = "btnNoSociosRegistrar";
            btnNoSociosRegistrar.Size = new Size(168, 63);
            btnNoSociosRegistrar.TabIndex = 0;
            btnNoSociosRegistrar.Text = "Registrar No Socio";
            btnNoSociosRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnNoSociosModificar
            // 
            btnNoSociosModificar.Location = new Point(89, 145);
            btnNoSociosModificar.Name = "btnNoSociosModificar";
            btnNoSociosModificar.Size = new Size(168, 66);
            btnNoSociosModificar.TabIndex = 1;
            btnNoSociosModificar.Text = "Modificar";
            btnNoSociosModificar.UseVisualStyleBackColor = true;
            // 
            // btnNoSociosInscribirActividad
            // 
            btnNoSociosInscribirActividad.Location = new Point(89, 234);
            btnNoSociosInscribirActividad.Name = "btnNoSociosInscribirActividad";
            btnNoSociosInscribirActividad.Size = new Size(168, 66);
            btnNoSociosInscribirActividad.TabIndex = 2;
            btnNoSociosInscribirActividad.Text = "Inscribir a Actividad";
            btnNoSociosInscribirActividad.UseVisualStyleBackColor = true;
            // 
            // btnNoSociosVolver
            // 
            btnNoSociosVolver.Location = new Point(144, 349);
            btnNoSociosVolver.Name = "btnNoSociosVolver";
            btnNoSociosVolver.Size = new Size(67, 30);
            btnNoSociosVolver.TabIndex = 3;
            btnNoSociosVolver.Text = "Volver";
            btnNoSociosVolver.UseVisualStyleBackColor = true;
            // 
            // GestionNoSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 422);
            Controls.Add(btnNoSociosVolver);
            Controls.Add(btnNoSociosInscribirActividad);
            Controls.Add(btnNoSociosModificar);
            Controls.Add(btnNoSociosRegistrar);
            Name = "GestionNoSocios";
            Text = "GestionNoSocios";
            Load += GestionNoSocios_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnNoSociosRegistrar;
        private Button btnNoSociosModificar;
        private Button btnNoSociosInscribirActividad;
        private Button btnNoSociosVolver;
    }
}