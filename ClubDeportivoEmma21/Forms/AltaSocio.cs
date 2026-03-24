using System;
using System.Drawing;
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
            AsignarEfectosHover();
        }

        private void AltaSocio_Load(object sender, EventArgs e)
        {
            // El diseño se carga desde el Designer.cs
        }

        private void AsignarEfectosHover()
        {
            // Botón Registrar (Azul)
            btnRegistrarSocio.MouseEnter += (s, e) => btnRegistrarSocio.BackColor = Color.FromArgb(58, 80, 107);
            btnRegistrarSocio.MouseLeave += (s, e) => btnRegistrarSocio.BackColor = Color.FromArgb(90, 113, 132);

            // Botón Cancelar (Beige)
            btnCancelarAltaSocio.MouseEnter += (s, e) => {
                btnCancelarAltaSocio.BackColor = Color.FromArgb(212, 175, 55);
                btnCancelarAltaSocio.ForeColor = Color.White;
            };
            btnCancelarAltaSocio.MouseLeave += (s, e) => {
                btnCancelarAltaSocio.BackColor = Color.FromArgb(231, 215, 193);
                btnCancelarAltaSocio.ForeColor = Color.Black;
            };
        }

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    using (var trans = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Insertar en tabla PERSONA
                            string sqlPersona = @"INSERT INTO persona (nombre, apellido, dni, telefono, direccion, mail, apto_medico) 
                                                 VALUES (@nom, @ape, @dni, @tel, @dir, @mail, @apto)";
                            int idPersona;
                            using (var cmd = new MySqlCommand(sqlPersona, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@nom", txtSocioNombre.Text.Trim());
                                cmd.Parameters.AddWithValue("@ape", txtSocioApellido.Text.Trim());
                                cmd.Parameters.AddWithValue("@dni", txtSocioDni.Text.Trim());
                                cmd.Parameters.AddWithValue("@tel", txtSocioTelefono.Text.Trim());
                                cmd.Parameters.AddWithValue("@dir", txtSocioDireccion.Text.Trim());
                                cmd.Parameters.AddWithValue("@mail", txtSocioMail.Text.Trim());
                                cmd.Parameters.AddWithValue("@apto", chbSocioAptoMedico.Checked);
                                cmd.ExecuteNonQuery();
                                idPersona = (int)cmd.LastInsertedId;
                            }

                            // 2. Insertar en tabla SOCIO
                            string sqlSocio = "INSERT INTO socio (id_socio, fecha_alta, estado_membresia, carnet_entregado) VALUES (@id, NOW(), 'Activo', FALSE)";
                            using (var cmd = new MySqlCommand(sqlSocio, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@id", idPersona);
                                cmd.ExecuteNonQuery();
                            }

                            // 3. Crear primera cuota de inscripción (valor 0 o real según desees)
                            string sqlCuota = "INSERT INTO cuota (id_socio, mes_a_pagar, valor_cuota, estado_pago) VALUES (@id, @mes, 0, 'Pendiente')";
                            using (var cmd = new MySqlCommand(sqlCuota, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@id", idPersona);
                                cmd.Parameters.AddWithValue("@mes", new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1));
                                cmd.ExecuteNonQuery();
                            }

                            trans.Commit();
                            MessageBox.Show("Socio registrado exitosamente 🎉", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception)
                        {
                            trans.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar socio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtSocioNombre.Text) ||
                string.IsNullOrWhiteSpace(txtSocioApellido.Text) ||
                string.IsNullOrWhiteSpace(txtSocioDni.Text))
            {
                MessageBox.Show("Los campos Nombre, Apellido y DNI son obligatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}