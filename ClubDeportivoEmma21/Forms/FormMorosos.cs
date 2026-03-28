using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivoEmma21.Data;

namespace ClubDeportivoEmma21.Forms
{
    public partial class FormMorosos : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();
        private DataTable morososTable = new DataTable();

        public FormMorosos()
        {
            InitializeComponent();
            AsignarEfectosHover();
        }

        private void FormMorosos_Load(object sender, EventArgs e)
        {
            CargarMorosos();
        }

        private void AsignarEfectosHover()
        {
            btnMorososImprimir.MouseEnter += (s, ev) => btnMorososImprimir.BackColor = Color.FromArgb(58, 80, 107);
            btnMorososImprimir.MouseLeave += (s, ev) => btnMorososImprimir.BackColor = Color.FromArgb(90, 113, 132);

            btnMorososExportar.MouseEnter += (s, ev) => btnMorososExportar.BackColor = Color.FromArgb(58, 80, 107);
            btnMorososExportar.MouseLeave += (s, ev) => btnMorososExportar.BackColor = Color.FromArgb(90, 113, 132);

            btnMorososVolver.MouseEnter += (s, ev) =>
            {
                btnMorososVolver.BackColor = Color.FromArgb(212, 175, 55);
                btnMorososVolver.ForeColor = Color.White;
            };
            btnMorososVolver.MouseLeave += (s, ev) =>
            {
                btnMorososVolver.BackColor = Color.FromArgb(231, 215, 193);
                btnMorososVolver.ForeColor = Color.Black;
            };
        }

        private void CargarMorosos()
        {
            morososTable.Clear();
            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();

                    // Primero asegura que la lista esté fresca llamando al procedimiento.
                    using (var cmdSp = new MySqlCommand("sp_ActualizarMorosos", conn))
                    {
                        cmdSp.CommandType = System.Data.CommandType.StoredProcedure;
                        cmdSp.ExecuteNonQuery();
                    }

                    // Luego trae solo a los que tienen cuotas con estado 'Vencido'.
                    string sqlSelect = @"SELECT DISTINCT s.id_socio, p.nombre, p.apellido, p.telefono, 
                                       c.mes_a_pagar, c.valor_cuota 
                                FROM cuota c 
                                JOIN socio s ON s.id_socio = c.id_socio 
                                JOIN persona p ON p.id_persona = s.id_socio 
                                WHERE c.estado_pago = 'Vencido' 
                                ORDER BY c.mes_a_pagar ASC";

                    using (var da = new MySqlDataAdapter(sqlSelect, conn))
                    {
                        da.Fill(morososTable);
                    }
                }

                // Llena el ListView
                lstSociosMorosos.Items.Clear();
                foreach (DataRow row in morososTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["id_socio"].ToString());
                    item.SubItems.Add(row["nombre"].ToString());
                    item.SubItems.Add(row["apellido"].ToString());
                    item.SubItems.Add(row["telefono"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(row["mes_a_pagar"]).ToString("MM/yyyy"));
                    item.SubItems.Add("$ " + Convert.ToDecimal(row["valor_cuota"]).ToString("N2"));
                    lstSociosMorosos.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar listado: " + ex.Message);
            }
        }

        private void btnMorososExportar_Click(object sender, EventArgs e)
        {
            if (morososTable.Rows.Count == 0) return;
            SaveFileDialog saveFile = new SaveFileDialog { Filter = "Archivo CSV|*.csv", Title = "Exportar Morosos", FileName = $"Morosos_{DateTime.Now:yyyyMMdd}.csv" };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("ID Socio;Nombre;Apellido;Telefono;Vencimiento;Deuda");
                    foreach (DataRow r in morososTable.Rows)
                    {
                        string fecha = Convert.ToDateTime(r["mes_a_pagar"]).ToString("dd/MM/yyyy");
                        sb.AppendLine($"{r["id_socio"]};{r["nombre"]};{r["apellido"]};{r["telefono"]};{fecha};{r["valor_cuota"]}");
                    }
                    File.WriteAllText(saveFile.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Archivo exportado correctamente.", "Éxito");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnMorososImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Preparando vista previa de impresión...", "Reporte");
        }

        private void btnMorososVolver_Click(object sender, EventArgs e) => this.Close();

        private void pnlCuerpo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}