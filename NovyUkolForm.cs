using System;
using System.Windows.Forms;

namespace Projekt_ToDoList
{
    public partial class NovyUkolForm : Form
    {
        public NovyUkolForm()
        {
            InitializeComponent();
        }

        private void NovyUkolForm_Load(object sender, EventArgs e)
        {
        }

        private void bPridat_Click_1(object sender, EventArgs e)
        {
            string nazev = tbNazev.Text;
            string podrobnosti = tbPodrobnosti.Text;
            DateTime datum = dtpDatum.Value;
            bool splneno = rbAno.Checked;
            DateTime datumPridani = DateTime.Now;

            if (string.IsNullOrWhiteSpace(nazev))
            {
                MessageBox.Show("Název úkolu nesmí být prázdný.");
                return;
            }
            if (!rbAno.Checked && !rbNe.Checked)
            {
                MessageBox.Show("Je třeba vybrat, zda je úkol splněný.");
                return;
            }

            bool ulozeno = UlozitUkol.UlozeniUkolu(nazev, podrobnosti, (decimal)datum.ToOADate(), splneno, (decimal)datumPridani.ToOADate());

            if (ulozeno)
            {
                MessageBox.Show("Úkol byl úspěšně uložen.");
                Close();
            }
            else
            {
                MessageBox.Show("Došlo k chybě při ukládání úkolu.");
            }
        }

        private void bZrusit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

