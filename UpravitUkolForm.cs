using System;
using System.Windows.Forms;

namespace Projekt_ToDoList
{
    public partial class UpravitUkolForm : Form
    {
        private SeznamUkoluForm.Ukol aktualniUkol;

        public UpravitUkolForm(SeznamUkoluForm.Ukol ukol)
        {
            InitializeComponent();
            aktualniUkol = ukol;

            // Fill the form fields with the task data
            tbNazev.Text = ukol.Nazev;
            tbPodrobnosti.Text = ukol.Popis;
            dtpDatum.Value = ukol.Datum;
            rbAno.Checked = ukol.JeSplneno;
        }

        private void bPridat_Click(object sender, EventArgs e)
        {
            // Aktualizace úkolu s novými daty
            aktualniUkol.Nazev = tbNazev.Text;
            aktualniUkol.Popis = tbPodrobnosti.Text;
            aktualniUkol.Datum = dtpDatum.Value;
            aktualniUkol.JeSplneno = rbAno.Checked;

            // Uložení upraveného úkolu
            bool ulozeno = UlozitUkol.UlozeniUkolu(aktualniUkol.Nazev, aktualniUkol.Popis, (decimal)aktualniUkol.Datum.ToOADate(), aktualniUkol.JeSplneno, (decimal)aktualniUkol.DatumPridani.ToOADate() );
            if (ulozeno)
            {
                MessageBox.Show("Úkol byl úspìšnì upraven a uložen.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Došlo k chybì pøi ukládání úkolu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }

        private void bZrusit_Click_1(object sender, EventArgs e)
        {
            UlozitUkol.UlozeniUkolu(aktualniUkol.Nazev, aktualniUkol.Popis, (decimal)aktualniUkol.Datum.ToOADate(), aktualniUkol.JeSplneno, (decimal)aktualniUkol.DatumPridani.ToOADate());
            Close();
        }
    }
}
