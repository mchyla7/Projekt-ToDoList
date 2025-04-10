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
            // Aktualizace �kolu s nov�mi daty
            aktualniUkol.Nazev = tbNazev.Text;
            aktualniUkol.Popis = tbPodrobnosti.Text;
            aktualniUkol.Datum = dtpDatum.Value;
            aktualniUkol.JeSplneno = rbAno.Checked;

            // Ulo�en� upraven�ho �kolu
            bool ulozeno = UlozitUkol.UlozeniUkolu(aktualniUkol.Nazev, aktualniUkol.Popis, (decimal)aktualniUkol.Datum.ToOADate(), aktualniUkol.JeSplneno, (decimal)aktualniUkol.DatumPridani.ToOADate() );
            if (ulozeno)
            {
                MessageBox.Show("�kol byl �sp�n� upraven a ulo�en.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Do�lo k chyb� p�i ukl�d�n� �kolu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
