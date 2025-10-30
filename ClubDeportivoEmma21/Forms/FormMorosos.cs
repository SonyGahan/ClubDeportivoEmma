using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivoEmma21.Data;
using System.Drawing.Printing;

namespace ClubDeportivoEmma21.Forms
{
    public partial class FormMorosos : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();
        private DataTable morososTable = new DataTable();

        public FormMorosos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Reporte de Vencimientos - Club Deportivo Emma 21";
        }

        private void FormMorosos_Load(object sender, EventArgs e)
        {
            ConfigurarListView();
            CargarMorosos();
            AplicarEstiloVisual();
        }

        // 🎨 Aplicar diseño coherente al formulario
        private void AplicarEstiloVisual()
        {
            this.BackColor = Color.FromArgb(232, 237, 242);
            this.Font = new Font("Segoe UI", 10F);

            EstilizarBotonAzul(btnMorososImprimir);
            EstilizarBotonAzul(btnMorososExportar);
            EstilizarBotonDorado(btnMorososVolver);
            EstilizarTitulo(txtTituloMorosos);
            EstilizarListView(lstSociosMorosos);
        }

        private void EstilizarBotonAzul(Button b)
        {
            Color baseColor = Color.FromArgb(90, 113, 132);
            Color hoverColor = Color.FromArgb(58, 80, 107);
            b.BackColor = baseColor;
            b.ForeColor = Color.White;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            b.Cursor = Cursors.Hand;

            b.MouseEnter += (s, e) =>
            {
                b.BackColor = hoverColor;
                b.FlatAppearance.BorderColor = Color.WhiteSmoke;
                b.FlatAppearance.BorderSize = 2;
            };
            b.MouseLeave += (s, e) =>
            {
                b.BackColor = baseColor;
                b.FlatAppearance.BorderSize = 0;
            };
        }

        private void EstilizarBotonDorado(Button b)
        {
            Color baseColor = Color.FromArgb(231, 215, 193);
            Color hoverColor = Color.FromArgb(212, 175, 55);
            b.BackColor = baseColor;
            b.ForeColor = Color.FromArgb(47, 47, 47);
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            b.Cursor = Cursors.Hand;

            b.MouseEnter += (s, e) =>
            {
                b.BackColor = hoverColor;
                b.ForeColor = Color.White;
            };
            b.MouseLeave += (s, e) =>
            {
                b.BackColor = baseColor;
                b.ForeColor = Color.FromArgb(47, 47, 47);
            };
        }

        private void EstilizarTitulo(TextBox t)
        {
            t.BackColor = Color.FromArgb(214, 223, 232);
            t.BorderStyle = BorderStyle.FixedSingle;
            t.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            t.ForeColor = Color.FromArgb(47, 47, 47);
            t.ReadOnly = true;
            t.TextAlign = HorizontalAlignment.Left;
        }

        private void EstilizarListView(ListView lst)
        {
            lst.BackColor = Color.White;
            lst.ForeColor = Color.FromArgb(47, 47, 47);
            lst.Font = new Font("Segoe UI", 9.5F);
            lst.FullRowSelect = true;
            lst.GridLines = true;
        }

        // Configurar columnas visuales del listado
        private void ConfigurarListView()
        {
            lstSociosMorosos.View = View.Details;
            lstSociosMorosos.Columns.Clear();
            lstSociosMorosos.Columns.Add("ID Socio", 80);
            lstSociosMorosos.Columns.Add("Nombre", 120);
            lstSociosMorosos.Columns.Add("Apellido", 120);
            lstSociosMorosos.Columns.Add("Mes a Pagar", 100);
            lstSociosMorosos.Columns.Add("Monto", 100);
            lstSociosMorosos.FullRowSelect = true;
            lstSociosMorosos.GridLines = true;
        }

        // Cargar morosos desde la BD
        private void CargarMorosos()
        {
            morososTable.Clear();

            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();

                    string sqlUpdate = @"UPDATE cuota 
                                         SET estado_pago = 'Vencido'
                                         WHERE mes_a_pagar < CURDATE()
                                         AND estado_pago = 'Pendiente';";
                    using (var updateCmd = new MySqlCommand(sqlUpdate, conn))
                    {
                        updateCmd.ExecuteNonQuery();
                    }

                    string sqlSelect = @"SELECT s.id_socio, p.nombre, p.apellido, c.mes_a_pagar, c.valor_cuota
                                         FROM cuota c
                                         JOIN socio s ON s.id_socio = c.id_socio
                                         JOIN persona p ON p.id_persona = s.id_socio
                                         WHERE c.estado_pago = 'Vencido'
                                         ORDER BY c.mes_a_pagar ASC;";
                    using (var da = new MySqlDataAdapter(sqlSelect, conn))
                    {
                        da.Fill(morososTable);
                    }
                }

                lstSociosMorosos.Items.Clear();
                foreach (DataRow row in morososTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["id_socio"].ToString());
                    item.SubItems.Add(row["nombre"].ToString());
                    item.SubItems.Add(row["apellido"].ToString());
                    DateTime fecha = Convert.ToDateTime(row["mes_a_pagar"]);
                    item.SubItems.Add(fecha.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(Convert.ToDecimal(row["valor_cuota"]).ToString("N2"));
                    lstSociosMorosos.Items.Add(item);
                }

                if (lstSociosMorosos.Items.Count == 0)
                {
                    MessageBox.Show("No hay socios morosos en este momento.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar morosos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Exportar listado a CSV
        private void btnMorososExportar_Click(object sender, EventArgs e)
        {
            if (morososTable.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "Archivo CSV|*.csv",
                Title = "Guardar listado de morosos"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    string[] columnNames = { "ID Socio", "Nombre", "Apellido", "Mes a Pagar", "Monto" };
                    sb.AppendLine(string.Join(",", columnNames));

                    foreach (DataRow row in morososTable.Rows)
                    {
                        string linea = $"{row["id_socio"]},{row["nombre"]},{row["apellido"]},{Convert.ToDateTime(row["mes_a_pagar"]).ToString("dd/MM/yyyy")},{row["valor_cuota"]}";
                        sb.AppendLine(linea);
                    }

                    File.WriteAllText(saveFile.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Archivo exportado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Imprimir listado
        private void btnMorososImprimir_Click(object sender, EventArgs e)
        {
            if (morososTable.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += (s, ev) =>
            {
                float y = 100;
                Font font = new Font("Arial", 10);
                ev.Graphics.DrawString("Listado de Socios Morosos", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 100, 50);

                foreach (DataRow row in morososTable.Rows)
                {
                    string linea = $"{row["id_socio"]} - {row["nombre"]} {row["apellido"]} - Venc.: {Convert.ToDateTime(row["mes_a_pagar"]).ToString("dd/MM/yyyy")} - ${row["valor_cuota"]}";
                    ev.Graphics.DrawString(linea, font, Brushes.Black, 100, y);
                    y += 25;
                }
            };

            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = printDoc,
                Width = 800,
                Height = 600
            };
            preview.ShowDialog();
        }

        private void btnMorososVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}


