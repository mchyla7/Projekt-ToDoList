using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_ToDoList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void bNovyUkol_Click(object sender, EventArgs e)
        {
            NovyUkolForm novyUkolForm = new NovyUkolForm();
            novyUkolForm.ShowDialog();
        }

        private void bSeznam_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.txt");

            if (File.Exists(filePath) && !string.IsNullOrWhiteSpace(File.ReadAllText(filePath)))
            {
                SeznamUkoluForm seznamUkoluForm = new SeznamUkoluForm();
                seznamUkoluForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seznam úkolů je prázdný.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bKonec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

