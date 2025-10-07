using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivoEmma21.Data;

namespace ClubDeportivoEmma21.Forms
{
    public partial class AltaSocio : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();

        public AltaSocio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Alta de Socio - Club Deportivo Emma21";
        }

        private void AltaSocio_Load(object sender, EventArgs e)
        {
            // Por ahora vacio
        }

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    using (var trans = conn.BeginTransaction())
                    {
                        // 1️ Insertar en PERSONA
                        string sqlPersona = @"INSERT INTO persona 
                            (nombre, apellido, dni, telefono, direccion, mail, apto_medico)
                            VALUES (@nombre, @apellido, @dni, @telefono, @direccion, @mail, @apto)";

                        int idPersonaGenerado;

                        using (var cmd = new MySqlCommand(sqlPersona, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@nombre", txtSocioNombre.Text.Trim());
                            cmd.Parameters.AddWithValue("@apellido", txtSocioApellido.Text.Trim());
                            cmd.Parameters.AddWithValue("@dni", txtSocioDni.Text.Trim());
                            cmd.Parameters.AddWithValue("@telefono", txtSocioTelefono.Text.Trim());
                            cmd.Parameters.AddWithValue("@direccion", txtSocioDireccion.Text.Trim());
                            cmd.Parameters.AddWithValue("@mail", txtSocioMail.Text.Trim());
                            cmd.Parameters.AddWithValue("@apto", chbSocioAptoMedico.Checked);

                            cmd.ExecuteNonQuery();
                            idPersonaGenerado = (int)cmd.LastInsertedId;
                        }

                        // 2️ Insertar en SOCIO (vinculado a PERSONA)
                        string sqlSocio = @"INSERT INTO socio 
                        (id_socio, fecha_alta, estado_membresia, carnet_entregado)
                        VALUES (@idSocio, @fecha, @estado, @carnet)";

                        int idSocioGenerado = idPersonaGenerado; // Es el mismo ID

                        using (var cmd = new MySqlCommand(sqlSocio, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@idSocio", idSocioGenerado);
                            cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                            cmd.Parameters.AddWithValue("@estado", "Activo");
                            cmd.Parameters.AddWithValue("@carnet", false);
                            cmd.ExecuteNonQuery();
                        }

                        // 3️ Insertar primera cuota en CUOTA
                        string sqlCuota = @"INSERT INTO cuota 
                            (id_socio, mes_a_pagar, valor_cuota, fecha_pago, forma_de_pago, estado_pago)
                            VALUES (@idSocio, @mes, @valor, @fecha, @forma, @estado)";

                        using (var cmd = new MySqlCommand(sqlCuota, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@idSocio", idSocioGenerado);
                            cmd.Parameters.AddWithValue("@mes", new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1));
                            cmd.Parameters.AddWithValue("@valor", 0); // valor puede actualizarse luego
                            cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                            cmd.Parameters.AddWithValue("@forma", "Pendiente");
                            cmd.Parameters.AddWithValue("@estado", "Pendiente");
                            cmd.ExecuteNonQuery();
                        }

                        trans.Commit();
                    }

                    MessageBox.Show("Socio registrado correctamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // LimpiarCampos(); VEr si despues se agrega otro boton para volver y se puede agregar otro socio
                    this.DialogResult = DialogResult.OK;
                    this.Close(); // Vuelve al formulario que lo llamó
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar socio: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Indica que el usuario canceló la operación
            this.DialogResult = DialogResult.Cancel;
            this.Close(); // Cierra y devuelve Cancel a GestionSocios
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtSocioNombre.Text) ||
                string.IsNullOrWhiteSpace(txtSocioApellido.Text) ||
                string.IsNullOrWhiteSpace(txtSocioDni.Text))
            {
                MessageBox.Show("Los campos Nombre, Apellido y DNI son obligatorios.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            txtSocioNombre.Clear();
            txtSocioApellido.Clear();
            txtSocioDni.Clear();
            txtSocioTelefono.Clear();
            txtSocioDireccion.Clear();
            txtSocioMail.Clear();
            chbSocioAptoMedico.Checked = false;
        }
    }
}
