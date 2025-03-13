using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            SeznamUkoluForm seznamUkoluForm = new SeznamUkoluForm();
            seznamUkoluForm.ShowDialog();
        }

        private void bKonec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
