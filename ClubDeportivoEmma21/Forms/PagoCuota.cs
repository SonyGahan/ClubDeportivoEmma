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
            AsignarEfectosHover();
        }

        public PagoCuota(int idSocio, string dni) : this()
        {
            this.idSocioActual = idSocio;
            this.txtDniCuotaSocio.Text = dni;
            this.txtDniCuotaSocio.Enabled = false;
            this.btnPagoSocioBuscar.Visible = false;
        }

        private void PagoCuota_Load(object sender, EventArgs e)
        {
            ConfigurarMediosDePago();

            if (idSocioActual > 0)
            {
                CargarDatosSocioPorId(idSocioActual);
            }
        }

        private void ConfigurarMediosDePago()
        {
            clbOpcionDePagoSocio.Items.Clear();
            clbOpcionDePagoSocio.Items.Add("Efectivo");
            clbOpcionDePagoSocio.Items.Add("Transferencia");
            clbOpcionDePagoSocio.Items.Add("Tarjeta");
            clbOpcionDePagoSocio.CheckOnClick = true;

            // Aseguramos selección única
            clbOpcionDePagoSocio.ItemCheck += (s, ev) => {
                if (ev.NewValue == CheckState.Checked)
                {
                    for (int i = 0; i < clbOpcionDePagoSocio.Items.Count; i++)
                    {
                        if (i != ev.Index) clbOpcionDePagoSocio.SetItemChecked(i, false);
                    }
                }
            };
        }

        private void AsignarEfectosHover()
        {
            // Botones principales (Azul)
            this.btnPagoSocioBuscar.MouseEnter += (s, e) => this.btnPagoSocioBuscar.BackColor = Color.FromArgb(90, 113, 132);
            this.btnPagoSocioBuscar.MouseLeave += (s, e) => this.btnPagoSocioBuscar.BackColor = Color.FromArgb(58, 80, 107);

            this.btnPagoSocio.MouseEnter += (s, e) => this.btnPagoSocio.BackColor = Color.FromArgb(58, 80, 107);
            this.btnPagoSocio.MouseLeave += (s, e) => this.btnPagoSocio.BackColor = Color.FromArgb(90, 113, 132);

            // Botón Cancelar (Dorado)
            this.btnPagoSocioCancelar.MouseEnter += (s, e) => {
                this.btnPagoSocioCancelar.BackColor = Color.FromArgb(212, 175, 55);
                this.btnPagoSocioCancelar.ForeColor = Color.White;
            };
            this.btnPagoSocioCancelar.MouseLeave += (s, e) => {
                this.btnPagoSocioCancelar.BackColor = Color.FromArgb(231, 215, 193);
                this.btnPagoSocioCancelar.ForeColor = Color.Black;
            };
        }

        private void btnPagoSocioBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDniCuotaSocio.Text.Trim();
            if (string.IsNullOrEmpty(dni)) return;

            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT s.id_socio, p.nombre, p.apellido, s.estado_membresia 
                                 FROM socio s JOIN persona p ON p.id_persona = s.id_socio 
                                 WHERE p.dni = @dni";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idSocioActual = reader.GetInt32("id_socio");
                                lblNombreSocio.Text = reader["nombre"].ToString() + " " + reader["apellido"].ToString();

                                if (reader.GetString("estado_membresia") != "Activo")
                                {
                                    MessageBox.Show("El socio no se encuentra en estado Activo.", "Atención");
                                    Limpiar();
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el socio.");
                                Limpiar();
                                return;
                            }
                        }
                    }
                }
                CargarCuotaPendiente(idSocioActual);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void CargarDatosSocioPorId(int id)
        {
            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT nombre, apellido FROM persona WHERE id_persona = @id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var r = cmd.ExecuteReader())
                        {
                            if (r.Read()) lblNombreSocio.Text = r["nombre"].ToString() + " " + r["apellido"].ToString();
                        }
                    }
                }
                CargarCuotaPendiente(id);
            }
            catch { }
        }

        private void CargarCuotaPendiente(int id)
        {
            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    // Traemos la cuota más antigua pendiente o vencida
                    string sql = @"SELECT id_cuota, mes_a_pagar, valor_cuota FROM cuota 
                                 WHERE id_socio = @id AND (estado_pago = 'Pendiente' OR estado_pago = 'Vencido') 
                                 ORDER BY mes_a_pagar ASC LIMIT 1";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                idCuotaPendiente = r.GetInt32("id_cuota");
                                txtVencimiento.Text = Convert.ToDateTime(r["mes_a_pagar"]).ToString("MMMM yyyy").ToUpper();
                                txtMontoCuota.Text = "$ " + Convert.ToDecimal(r["valor_cuota"]).ToString("N2");
                                btnPagoSocio.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("El socio no tiene cuotas pendientes.", "Información");
                                btnPagoSocio.Enabled = false;
                            }
                        }
                    }
                }
            }
            catch { }
        }

        private void btnPagoSocio_Click(object sender, EventArgs e)
        {
            if (idCuotaPendiente == 0) return;
            if (clbOpcionDePagoSocio.CheckedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un medio de pago.", "Aviso");
                return;
            }

            try
            {
                string medio = clbOpcionDePagoSocio.CheckedItems[0].ToString();
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    string sql = @"UPDATE cuota SET estado_pago = 'Pagado', fecha_pago = NOW(), forma_de_pago = @f 
                                 WHERE id_cuota = @id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@f", medio);
                        cmd.Parameters.AddWithValue("@id", idCuotaPendiente);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("💰 Pago registrado con éxito.", "Éxito");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error al registrar pago: " + ex.Message); }
        }

        private void btnPagoSocioCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            idSocioActual = 0;
            idCuotaPendiente = 0;
            lblNombreSocio.Text = "-";
            txtVencimiento.Clear();
            txtMontoCuota.Clear();
            btnPagoSocio.Enabled = false;
        }
    }
}