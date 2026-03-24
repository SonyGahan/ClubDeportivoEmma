using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivoEmma21.Data;

namespace ClubDeportivoEmma21.Forms
{
    public partial class NoSocioActividad : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();
        private int idNoSocioActual = 0;

        public NoSocioActividad()
        {
            InitializeComponent();
            AsignarEfectosHover();
        }

        private void NoSocioActividad_Load(object sender, EventArgs e)
        {
            CargarActividades();
        }

        private void AsignarEfectosHover()
        {
            this.btnBuscar.MouseEnter += (s, e) => this.btnBuscar.BackColor = Color.FromArgb(90, 113, 132);
            this.btnBuscar.MouseLeave += (s, e) => this.btnBuscar.BackColor = Color.FromArgb(58, 80, 107);

            this.btnRegistrar.MouseEnter += (s, e) => this.btnRegistrar.BackColor = Color.FromArgb(58, 80, 107);
            this.btnRegistrar.MouseLeave += (s, e) => this.btnRegistrar.BackColor = Color.FromArgb(90, 113, 132);

            this.btnCancelar.MouseEnter += (s, e) => {
                this.btnCancelar.BackColor = Color.FromArgb(212, 175, 55);
                this.btnCancelar.ForeColor = Color.White;
            };
            this.btnCancelar.MouseLeave += (s, e) => {
                this.btnCancelar.BackColor = Color.FromArgb(231, 215, 193);
                this.btnCancelar.ForeColor = Color.Black;
            };
        }

        private void CargarActividades()
        {
            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT id_actividad, nombre_actividad, costo_diario FROM actividad";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbActividad.Items.Add(new
                                {
                                    Text = reader["nombre_actividad"].ToString(),
                                    Value = reader["id_actividad"],
                                    Costo = reader["costo_diario"]
                                });
                            }
                        }
                    }
                }
                cmbActividad.DisplayMember = "Text";
                cmbActividad.ValueMember = "Value";
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar actividades: " + ex.Message); }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text.Trim();
            if (string.IsNullOrEmpty(dni)) return;

            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT n.id_no_socio, p.nombre, p.apellido 
                                 FROM no_socio n 
                                 JOIN persona p ON p.id_persona = n.id_no_socio 
                                 WHERE p.dni = @dni";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idNoSocioActual = reader.GetInt32("id_no_socio");
                                lblNombreDato.Text = reader["nombre"].ToString() + " " + reader["apellido"].ToString();
                                btnRegistrar.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("DNI no registrado como No Socio.", "Aviso");
                                lblNombreDato.Text = "-";
                                idNoSocioActual = 0;
                                btnRegistrar.Enabled = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void cmbActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbActividad.SelectedItem != null)
            {
                dynamic act = cmbActividad.SelectedItem;
                lblMontoDato.Text = "$ " + Convert.ToDecimal(act.Costo).ToString("N2");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (idNoSocioActual == 0 || cmbActividad.SelectedItem == null) return;

            try
            {
                dynamic act = cmbActividad.SelectedItem;
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO pago_diario (id_no_socio, id_actividad, fecha_pago, monto_pagado) 
                                 VALUES (@id, @act, CURDATE(), @monto)";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idNoSocioActual);
                        cmd.Parameters.AddWithValue("@act", act.Value);
                        cmd.Parameters.AddWithValue("@monto", act.Costo);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show(" ✅ Pago registrado y pase diario habilitado.", "Éxito");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error al registrar pago: " + ex.Message); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}