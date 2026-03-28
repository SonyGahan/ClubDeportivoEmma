using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ClubDeportivoEmma21.Forms
{
    public partial class FormCarnet : Form
    {
        public FormCarnet(string nombreCompleto, string dni, string nroSocio)
        {
            InitializeComponent();

            // Cargar los datos recibidos
            lblNombre.Text = nombreCompleto.ToUpper();
            lblDni.Text = "DNI: " + dni;
            lblNroSocio.Text = "N° Socio: " + nroSocio;
            lblVigencia.Text = "Emisión: " + DateTime.Now.ToString("dd/MM/yyyy");

            AsignarEfectosHover();
            CargarImagenCarnet();
        }

        private void CargarImagenCarnet()
        {
            try
            {
                // Construye la ruta hacia la carpeta img del proyecto
                // Sube niveles desde bin/Debug/net9.0-windows hacia la raíz del proyecto
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string projectDir = Path.GetFullPath(Path.Combine(baseDir, "..", "..", ".."));
                string imagePath = Path.Combine(projectDir, "img", "img_carnet_3.jpeg");

                if (File.Exists(imagePath))
                {
                    // Si la imagen existe en el disco, la carga.
                    picFotoSocio.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // Intento alternativo por si ya está en Resources o se movió el ejecutable
                    // picFotoSocio.Image = Properties.Resources.img_carnet_3; 
                }
            }
            catch (Exception)
            {
                // Si falla la carga, deja un color de fondo para que no se vea vacío.
                picFotoSocio.BackColor = Color.LightGray;
            }
        }

        private void AsignarEfectosHover()
        {
            // Efectos para el botón Imprimir - Azul Petróleo
            btnImprimir.MouseEnter += (s, e) => btnImprimir.BackColor = Color.FromArgb(58, 80, 107);
            btnImprimir.MouseLeave += (s, e) => btnImprimir.BackColor = Color.FromArgb(90, 113, 132);

            // Efectos para el botón Volver - Dorado
            btnCerrar.MouseEnter += (s, e) =>
            {
                btnCerrar.BackColor = Color.FromArgb(212, 175, 55);
                btnCerrar.ForeColor = Color.White;
            };
            btnCerrar.MouseLeave += (s, e) =>
            {
                btnCerrar.BackColor = Color.FromArgb(231, 215, 193);
                btnCerrar.ForeColor = Color.Black;
            };
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 🖨️  Preparando el carnet para la impresión...", "Impresión en curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void panelFondo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}