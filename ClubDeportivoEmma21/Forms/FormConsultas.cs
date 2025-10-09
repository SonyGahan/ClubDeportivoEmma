using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivoEmma21.Data;

namespace ClubDeportivoEmma21.Forms
{
    public partial class FormConsultas : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();

        public FormConsultas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormConsultas_Load(object sender, EventArgs e)
        {
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtConsultaDniPersona.Text.Trim();

            if (string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("Por favor ingrese un DNI.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();

                    // Verifica si existe en PERSONA
                    string sqlPersona = "SELECT id_persona FROM persona WHERE dni = @dni";
                    int? idPersona = null;

                    using (var cmd = new MySqlCommand(sqlPersona, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                            idPersona = Convert.ToInt32(result);
                    }

                    if (idPersona == null)
                    {
                        // No existe, pregunta si quiere registrarse
                        FormSeleccionTipoAlta selector = new FormSeleccionTipoAlta();
                        DialogResult respuesta = selector.ShowDialog();

                        if (respuesta == DialogResult.Yes)
                        {
                            AltaSocio alta = new AltaSocio();
                            alta.ShowDialog();
                        }
                        else if (respuesta == DialogResult.No)
                        {
                            AltaNoSocio altaNo = new AltaNoSocio();
                            altaNo.ShowDialog();
                        }

                        return;
                    }

                    // Si existe, verifica si es socio o no socio
                    string sqlSocio = "SELECT id_socio FROM socio WHERE id_socio = @id";
                    string sqlNoSocio = "SELECT id_no_socio FROM no_socio WHERE id_no_socio = @id";

                    bool esSocio = false;
                    bool esNoSocio = false;

                    using (var cmd = new MySqlCommand(sqlSocio, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idPersona);
                        esSocio = cmd.ExecuteScalar() != null;
                    }

                    using (var cmd = new MySqlCommand(sqlNoSocio, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idPersona);
                        esNoSocio = cmd.ExecuteScalar() != null;
                    }

                    if (esSocio)
                    {
                        GestionSocios g = new GestionSocios();
                        g.ShowDialog();
                    }
                    else if (esNoSocio)
                    {
                        GestionNoSocios g = new GestionNoSocios();
                        g.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("El cliente existe en la base pero no tiene tipo asignado (socio/no socio).",
                            "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar cliente: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
