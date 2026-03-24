using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivoEmma21.Data;

namespace ClubDeportivoEmma21.Forms
{
    public partial class AltaNoSocio : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();

        public AltaNoSocio()
        {
            InitializeComponent();
            CargarComboActividades();
        }

        private void CargarComboActividades()
        {
            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT id_actividad, nombre_actividad, valor_actividad FROM actividad";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Agregamos un objeto anónimo al combo
                                cmbActividad.Items.Add(new
                                {
                                    Text = reader["nombre_actividad"].ToString() + " ($" + reader["costo_actividad"] + ")",
                                    Value = reader["id_actividad"],
                                    Costo = reader["costo_actividad"]
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || cmbActividad.SelectedItem == null) return;

            try
            {
                dynamic act = cmbActividad.SelectedItem;
                string[] partes = txtNombre.Text.Trim().Split(' ');
                string nom = partes[0];
                string ape = partes.Length > 1 ? partes[1] : "";

                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("sp_AltaNuevoNoSocio", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("_nom", nom);
                        cmd.Parameters.AddWithValue("_ape", ape);
                        cmd.Parameters.AddWithValue("_dni", Convert.ToInt32(txtDni.Text));
                        cmd.Parameters.AddWithValue("_tel", ""); // Opcional
                        cmd.Parameters.AddWithValue("_dir", ""); // Opcional
                        cmd.Parameters.AddWithValue("_mail", ""); // Opcional
                        cmd.Parameters.AddWithValue("_idAct", act.Value);
                        cmd.Parameters.AddWithValue("_monto", act.Costo);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("💰 Pago diario registrado con éxito.", "Éxito");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();

        private void pnlCuerpo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}