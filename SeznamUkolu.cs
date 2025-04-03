using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_ToDoList
{
    public partial class SeznamUkoluForm : Form
    {
        public SeznamUkoluForm()
        {
            InitializeComponent();
            SpravaUkolu.NacistUkoly();
            LoadDataGridView();
        }

        public class Ukol
        {
            public string Nazev { get; set; }
            public string Popis { get; set; }
            public DateTime Datum { get; set; }
            public bool JeSplneno { get; set; }
            public DateTime DatumPridani { get; set; }

            public static Ukol FromString(string data)
            {
                var lines = data.Split('\n');
                if (lines.Length < 6)
                {
                    throw new FormatException("Data nemájí správný formát");
                }

                return new Ukol
                {
                    Nazev = lines[1].Split(':')[1].Trim().Trim('"'),
                    Popis = lines[2].Split(':')[1].Trim().Trim('"'),
                    Datum = DateTime.ParseExact(lines[3].Split(':')[1].Trim().Trim('"'), "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    JeSplneno = bool.Parse(lines[4].Split(':')[1].Trim().Trim('"')),
                    DatumPridani = DateTime.ParseExact(lines[5].Split(':')[1].Trim().Trim('"'), "dd.MM.yyyy", CultureInfo.InvariantCulture)
                };
            }

            public override string ToString()
            {
                return $"---\nNázev: \"{Nazev}\"\nPodrobnosti: \"{Popis}\"\nDatum: \"{Datum.ToString("dd.MM.yyyy")}\"\nJeSplneno: \"{JeSplneno}\"\nDatum Přidání: \"{DatumPridani.ToString("dd.MM.yyyy")}\"\n";
            }
        }


        public static class SpravaUkolu
        {
            private static List<Ukol> ukoly = new List<Ukol>();
            private static string cesta = "C:\\Chila\\data.txt";

            static SpravaUkolu()
            {
                NacistUkoly();
            }

            public static void NacistUkoly()
            {
                if (File.Exists(cesta))
                {
                    var data = File.ReadAllText(cesta);
                    var ukolData = data.Split(new string[] { "---" }, StringSplitOptions.RemoveEmptyEntries);
                    ukoly = ukolData.Select(u => Ukol.FromString(u)).ToList();
                }
            }

            public static List<Ukol> ZiskatUkoly()
            {
                return ukoly;
            }

        }

        private void LoadDataGridView()
        {
            var ukoly = SpravaUkolu.ZiskatUkoly();
            dataGridView1.DataSource = ukoly;

            // Custom hlavička
            dataGridView1.Columns["Nazev"].HeaderText = "Název úkolu";
            dataGridView1.Columns["Popis"].HeaderText = "Popis úkolu";
            dataGridView1.Columns["Datum"].HeaderText = "Datum splnění";
            dataGridView1.Columns["JeSplneno"].HeaderText = "Splněno";
            dataGridView1.Columns["DatumPridani"].HeaderText = "Datum přidání";

        }

        private void bUpravit_Click(object sender, EventArgs e)
        {

        }

        private void bSmazat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var ukol = (Ukol)selectedRow.DataBoundItem;
                SmazatUkol.Smazat(ukol);
                SpravaUkolu.NacistUkoly();
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Vyberte úkol, který chcete smazat.");
            }
        }


        private void bZpet_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}


