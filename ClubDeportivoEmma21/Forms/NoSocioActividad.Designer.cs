namespace ClubDeportivoEmma21.Forms
{
    partial class NoSocioActividad
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblDniNoSocio = new Label();
            txtDniNoSocio = new TextBox();
            lblActividadNoSocio = new Label();
            lblMontoAPagarNoSocio = new Label();
            lblFormaDePagoNoSocio = new Label();
            comboActividades = new ComboBox();
            btnActividadPagar = new Button();
            clbActividadFormaDePago = new CheckedListBox();
            btnBuscarDniActividad = new Button();
            btnCancelarDniActividad = new Button();
            txtMontoNoSocio = new TextBox();
            SuspendLayout();

            // --- lblDniNoSocio ---
            lblDniNoSocio.AutoSize = true;
            lblDniNoSocio.Location = new Point(40, 35);
            lblDniNoSocio.Name = "lblDniNoSocio";
            lblDniNoSocio.Size = new Size(80, 15);
            lblDniNoSocio.Text = "DNI No Socio:";

            // --- txtDniNoSocio ---
            txtDniNoSocio.Location = new Point(140, 32);
            txtDniNoSocio.Size = new Size(150, 23);

            // --- btnBuscarDniActividad ---
            btnBuscarDniActividad.Location = new Point(310, 30);
            btnBuscarDniActividad.Size = new Size(90, 27);
            btnBuscarDniActividad.Text = "Buscar";
            btnBuscarDniActividad.UseVisualStyleBackColor = true;
            btnBuscarDniActividad.Click += btnBuscarDniActividad_Click;

            // --- btnCancelarDniActividad ---
            btnCancelarDniActividad.Location = new Point(410, 30);
            btnCancelarDniActividad.Size = new Size(90, 27);
            btnCancelarDniActividad.Text = "Cancelar";
            btnCancelarDniActividad.UseVisualStyleBackColor = true;
            btnCancelarDniActividad.Click += btnCancelarDniActividad_Click;

            // --- lblActividadNoSocio ---
            lblActividadNoSocio.AutoSize = true;
            lblActividadNoSocio.Location = new Point(40, 90);
            lblActividadNoSocio.Text = "Actividad:";

            // --- comboActividades ---
            comboActividades.DropDownStyle = ComboBoxStyle.DropDownList;
            comboActividades.Location = new Point(140, 87);
            comboActividades.Size = new Size(200, 23);
            comboActividades.SelectedIndexChanged += comboActividades_SelectedIndexChanged;

            // --- lblMontoAPagarNoSocio ---
            lblMontoAPagarNoSocio.AutoSize = true;
            lblMontoAPagarNoSocio.Location = new Point(40, 130);
            lblMontoAPagarNoSocio.Text = "Monto a Pagar:";

            // --- txtMontoNoSocio ---
            txtMontoNoSocio.Location = new Point(140, 127);
            txtMontoNoSocio.Size = new Size(100, 23);
            txtMontoNoSocio.ReadOnly = true;

            // --- lblFormaDePagoNoSocio ---
            lblFormaDePagoNoSocio.AutoSize = true;
            lblFormaDePagoNoSocio.Location = new Point(40, 170);
            lblFormaDePagoNoSocio.Text = "Formas de Pago:";

            // --- clbActividadFormaDePago ---
            clbActividadFormaDePago.Location = new Point(40, 190);
            clbActividadFormaDePago.Size = new Size(200, 70);
            clbActividadFormaDePago.Items.AddRange(new object[]
            {
                "Efectivo",
                "Transferencia",
                "Tarjeta"
            });

            // --- btnActividadPagar ---
            btnActividadPagar.Location = new Point(310, 190);
            btnActividadPagar.Size = new Size(150, 35);
            btnActividadPagar.Text = "Registrar Inscripción";
            btnActividadPagar.UseVisualStyleBackColor = true;
            btnActividadPagar.Click += btnActividadPagar_Click;

            // --- Form ---
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 300);
            Controls.AddRange(new Control[]
            {
                lblDniNoSocio, txtDniNoSocio, btnBuscarDniActividad, btnCancelarDniActividad,
                lblActividadNoSocio, comboActividades,
                lblMontoAPagarNoSocio, txtMontoNoSocio,
                lblFormaDePagoNoSocio, clbActividadFormaDePago,
                btnActividadPagar
            });

            Name = "NoSocioActividad";
            Text = "Inscripción de No Socio a Actividad";
            Load += NoSocioActividad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblDniNoSocio, lblActividadNoSocio, lblMontoAPagarNoSocio, lblFormaDePagoNoSocio;
        private TextBox txtDniNoSocio, txtMontoNoSocio;
        private ComboBox comboActividades;
        private CheckedListBox clbActividadFormaDePago;
        private Button btnBuscarDniActividad, btnCancelarDniActividad, btnActividadPagar;
    }
}
