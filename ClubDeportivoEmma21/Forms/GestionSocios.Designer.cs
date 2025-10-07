namespace ClubDeportivoEmma21.Forms
{
    partial class GestionSocios
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
            btnSocioRegistrarSocio = new Button();
            btnSocioModificar = new Button();
            btnSocioPagoCuota = new Button();
            btnSocioCarnet = new Button();
            btnSocioVolver = new Button();
            SuspendLayout();
            // 
            // btnSocioRegistrarSocio
            // 
            btnSocioRegistrarSocio.Location = new Point(88, 45);
            btnSocioRegistrarSocio.Name = "btnSocioRegistrarSocio";
            btnSocioRegistrarSocio.Size = new Size(156, 66);
            btnSocioRegistrarSocio.TabIndex = 0;
            btnSocioRegistrarSocio.Text = "Registrar Nuevo Socio";
            btnSocioRegistrarSocio.UseVisualStyleBackColor = true;
            btnSocioRegistrarSocio.Click += btnSocioRegistrarSocio_Click;
            // 
            // btnSocioModificar
            // 
            btnSocioModificar.Location = new Point(305, 45);
            btnSocioModificar.Name = "btnSocioModificar";
            btnSocioModificar.Size = new Size(156, 66);
            btnSocioModificar.TabIndex = 1;
            btnSocioModificar.Text = "Modificar";
            btnSocioModificar.UseVisualStyleBackColor = true;
            btnSocioModificar.Click += btnSocioModificar_Click;
            // 
            // btnSocioPagoCuota
            // 
            btnSocioPagoCuota.Location = new Point(88, 173);
            btnSocioPagoCuota.Name = "btnSocioPagoCuota";
            btnSocioPagoCuota.Size = new Size(156, 66);
            btnSocioPagoCuota.TabIndex = 2;
            btnSocioPagoCuota.Text = "Pago Mensual";
            btnSocioPagoCuota.UseVisualStyleBackColor = true;
            btnSocioPagoCuota.Click += btnSocioPagoCuota_Click;
            // 
            // btnSocioCarnet
            // 
            btnSocioCarnet.Location = new Point(305, 173);
            btnSocioCarnet.Name = "btnSocioCarnet";
            btnSocioCarnet.Size = new Size(156, 66);
            btnSocioCarnet.TabIndex = 3;
            btnSocioCarnet.Text = "Impresión de Carnet";
            btnSocioCarnet.UseVisualStyleBackColor = true;
            btnSocioCarnet.Click += btnSocioCarnet_Click;
            // 
            // btnSocioVolver
            // 
            btnSocioVolver.Location = new Point(216, 319);
            btnSocioVolver.Name = "btnSocioVolver";
            btnSocioVolver.Size = new Size(125, 30);
            btnSocioVolver.TabIndex = 4;
            btnSocioVolver.Text = "Volver";
            btnSocioVolver.UseVisualStyleBackColor = true;
            btnSocioVolver.Click += btnSocioVolver_Click;
            // 
            // GestionSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 403);
            Controls.Add(btnSocioVolver);
            Controls.Add(btnSocioCarnet);
            Controls.Add(btnSocioPagoCuota);
            Controls.Add(btnSocioModificar);
            Controls.Add(btnSocioRegistrarSocio);
            Name = "GestionSocios";
            Text = "GestionSocios";
            Load += GestionSocios_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSocioRegistrarSocio;
        private Button btnSocioModificar;
        private Button btnSocioPagoCuota;
        private Button btnSocioCarnet;
        private Button btnSocioVolver;
    }
}