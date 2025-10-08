using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivoEmma21.Data;

namespace ClubDeportivoEmma21.Forms
{
    public partial class PagoCuota : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();
        private int idSocioActual = 0;
        private int idCuotaPendiente = 0;

        public PagoCuota()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void PagoCuota_Load(object sender, EventArgs e)
        {
            // Inicializar lista de formas de pago
            clbOpcionDePagoSocio.Items.Clear();
            clbOpcionDePagoSocio.Items.Add("Efectivo");
            clbOpcionDePagoSocio.Items.Add("Transferencia");
            clbOpcionDePagoSocio.Items.Add("Tarjeta");

            clbOpcionDePagoSocio.CheckOnClick = true;
            clbOpcionDePagoSocio.ItemCheck += (s, ev) =>
            {
                for (int i = 0; i < clbOpcionDePagoSocio.Items.Count; i++)
                    if (i != ev.Index)
                        clbOpcionDePagoSocio.SetItemChecked(i, false);
            };
        }

        // Buscar socio
        private void btnPagoSocioBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDniCuotaSocio.Text.Trim();
            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, ingrese el DNI del socio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();

                    // Buscar datos del socio y su estado
                    string sqlBuscar = @"SELECT s.id_socio, p.nombre, p.apellido, s.estado_membresia
                                         FROM socio s 
                                         JOIN persona p ON p.id_persona = s.id_socio 
                                         WHERE p.dni = @dni";
                    using (var cmd = new MySqlCommand(sqlBuscar, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                DialogResult opcion = MessageBox.Show(
                                    "No se encontró ningún socio con ese DNI.\n¿Desea intentar nuevamente?",
                                    "Socio no encontrado",
                                    MessageBoxButtons.RetryCancel,
                                    MessageBoxIcon.Information);

                                if (opcion == DialogResult.Retry)
                                    LimpiarCampos();
                                else
                                {
                                    this.Close();
                                    new GestionSocios().Show();
                                }
                                return;
                            }

                            idSocioActual = reader.GetInt32("id_socio");
                            string nombre = reader.GetString("nombre");
                            string apellido = reader.GetString("apellido");
                            string estado = reader.GetString("estado_membresia");

                            lblNombreSocio.Text = $"{nombre} {apellido}";

                            if (!estado.Equals("Activo", StringComparison.OrdinalIgnoreCase))
                            {
                                MessageBox.Show("Este socio no está activo. No puede realizar pagos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                LimpiarCampos();
                                return;
                            }
                        }
                    }

                    // Buscar cuota pendiente
                    string sqlCuota = @"SELECT id_cuota, mes_a_pagar, valor_cuota 
                                        FROM cuota 
                                        WHERE id_socio = @id AND estado_pago = 'Pendiente' 
                                        ORDER BY mes_a_pagar ASC LIMIT 1";
                    using (var cmd = new MySqlCommand(sqlCuota, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idSocioActual);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idCuotaPendiente = reader.GetInt32("id_cuota");
                                txtVencimiento.Text = reader.GetDateTime("mes_a_pagar").ToString("dd/MM/yyyy");
                                txtMontoCuota.Text = reader.GetDecimal("valor_cuota").ToString("N2");
                            }
                            else
                            {
                                MessageBox.Show("Este socio no tiene cuotas pendientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarCampos();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar socio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Registrar pago
        private void btnPagoSocio_Click(object sender, EventArgs e)
        {
            if (idSocioActual == 0 || idCuotaPendiente == 0)
            {
                MessageBox.Show("Primero busque un socio con una cuota pendiente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clbOpcionDePagoSocio.CheckedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una forma de pago.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string formaPago = clbOpcionDePagoSocio.CheckedItems[0].ToString();

            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();

                    string sqlPagar = @"UPDATE cuota 
                                        SET estado_pago = 'Pagado', 
                                            fecha_pago = NOW(), 
                                            forma_de_pago = @forma 
                                        WHERE id_cuota = @id";
                    using (var cmd = new MySqlCommand(sqlPagar, conn))
                    {
                        cmd.Parameters.AddWithValue("@forma", formaPago);
                        cmd.Parameters.AddWithValue("@id", idCuotaPendiente);
                        cmd.ExecuteNonQuery();
                    }
                }

                txtMontoCuota.BackColor = Color.LightGreen;
                MessageBox.Show("💰 Pago registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPagoSocioCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GestionSocios().Show();
        }

        private void LimpiarCampos()
        {
            txtDniCuotaSocio.Clear();
            txtMontoCuota.Clear();
            txtVencimiento.Clear();
            lblNombreSocio.Text = "";
            idSocioActual = 0;
            idCuotaPendiente = 0;
            txtMontoCuota.BackColor = Color.Beige;

            for (int i = 0; i < clbOpcionDePagoSocio.Items.Count; i++)
                clbOpcionDePagoSocio.SetItemChecked(i, false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}



