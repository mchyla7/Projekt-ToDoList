using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Projekt_ToDoList
{
    public partial class NovyUkolForm : Form
    {
        public NovyUkolForm()
        {
            InitializeComponent();
        }

        public class Ukol
        {
            public string Nazev { get; set; }
            public string Popis { get; set; }
            public DateTime Datum { get; set; }
            public bool JeSplneno { get; set; }
            public DateTime DatumPridani { get; set; }

            public override string ToString()
            {
                return $"{Nazev};{Popis};{Datum};{JeSplneno};{DatumPridani}";
            }

            public static Ukol FromString(string data)
            {
                var parts = data.Split(';');
                return new Ukol
                {
                    Nazev = parts[0],
                    Popis = parts[1],
                    Datum = DateTime.Parse(parts[2]),
                    JeSplneno = bool.Parse(parts[3]),
                    DatumPridani = DateTime.Parse(parts[4])
                };
            }
        }

        public static class SpravaUkolu
        {
            private static List<Ukol> ukoly = new List<Ukol>();
            private static string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ukoly.txt");

            static SpravaUkolu()
            {
                NacistUkoly();
            }

            public static void PridatUkol(Ukol novyUkol)
            {
                ukoly.Add(novyUkol);
                UlozitUkoly();
            }

            public static void UlozitUkoly()
            {
                var lines = ukoly.Select(u => u.ToString()).ToArray();
                File.WriteAllLines(filePath, lines);
            }

            public static void NacistUkoly()
            {
                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath);
                    ukoly = lines.Select(line => Ukol.FromString(line)).ToList();
                }
            }
        }

        private void bPridat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNazev.Text))
            {
                MessageBox.Show("Název úkolu nesmí být prázdný.");
                return;
            }
            else if (!rbAno.Checked && !rbNe.Checked)
            {
                MessageBox.Show("Úkol je splněný nebo nesplněný?");
                return;
            }

            Ukol novyUkol = new Ukol
            {
                Nazev = tbNazev.Text,
                Popis = tbPodrobnosti.Text,
                Datum = dtpDatum.Value,
                JeSplneno = rbAno.Checked,
                DatumPridani = DateTime.Now
            };

            SpravaUkolu.PridatUkol(novyUkol);
            MessageBox.Show("Úkol byl úspěšně přidán.");
            this.Close();
        }

        private void bZrusit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
