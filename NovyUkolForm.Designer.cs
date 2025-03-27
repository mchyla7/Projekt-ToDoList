namespace Projekt_ToDoList
{
    partial class NovyUkolForm
    {
        private System.Windows.Forms.TextBox tbNazev;
        private System.Windows.Forms.TextBox tbPodrobnosti;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.RadioButton rbAno;
        private System.Windows.Forms.RadioButton rbNe;
        private System.Windows.Forms.Button bPridat;
        private System.Windows.Forms.Button bZrusit;
        private System.Windows.Forms.GroupBox gbSplneno;

        private void InitializeComponent()
        {
            tbNazev = new TextBox();
            tbPodrobnosti = new TextBox();
            dtpDatum = new DateTimePicker();
            rbAno = new RadioButton();
            rbNe = new RadioButton();
            bPridat = new Button();
            bZrusit = new Button();
            gbSplneno = new GroupBox();
            gbSplneno.SuspendLayout();
            SuspendLayout();
            // 
            // tbNazev
            // 
            tbNazev.Location = new Point(12, 12);
            tbNazev.Name = "tbNazev";
            tbNazev.Size = new Size(200, 23);
            tbNazev.TabIndex = 0;
            // 
            // tbPodrobnosti
            // 
            tbPodrobnosti.Location = new Point(12, 41);
            tbPodrobnosti.Multiline = true;
            tbPodrobnosti.Name = "tbPodrobnosti";
            tbPodrobnosti.Size = new Size(200, 100);
            tbPodrobnosti.TabIndex = 1;
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(12, 147);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(200, 23);
            dtpDatum.TabIndex = 2;
            // 
            // rbAno
            // 
            rbAno.AutoSize = true;
            rbAno.Location = new Point(6, 22);
            rbAno.Name = "rbAno";
            rbAno.Size = new Size(47, 19);
            rbAno.TabIndex = 0;
            rbAno.TabStop = true;
            rbAno.Text = "Ano";
            rbAno.UseVisualStyleBackColor = true;
            // 
            // rbNe
            // 
            rbNe.AutoSize = true;
            rbNe.Location = new Point(59, 22);
            rbNe.Name = "rbNe";
            rbNe.Size = new Size(40, 19);
            rbNe.TabIndex = 1;
            rbNe.TabStop = true;
            rbNe.Text = "Ne";
            rbNe.UseVisualStyleBackColor = true;
            // 
            // bPridat
            // 
            bPridat.Location = new Point(12, 232);
            bPridat.Name = "bPridat";
            bPridat.Size = new Size(75, 23);
            bPridat.TabIndex = 4;
            bPridat.Text = "Přidat";
            bPridat.UseVisualStyleBackColor = true;
            bPridat.Click += bPridat_Click_1;
            // 
            // bZrusit
            // 
            bZrusit.Location = new Point(137, 232);
            bZrusit.Name = "bZrusit";
            bZrusit.Size = new Size(75, 23);
            bZrusit.TabIndex = 5;
            bZrusit.Text = "Zrušit";
            bZrusit.UseVisualStyleBackColor = true;
            bZrusit.Click += bZrusit_Click;
            // 
            // gbSplneno
            // 
            gbSplneno.Controls.Add(rbAno);
            gbSplneno.Controls.Add(rbNe);
            gbSplneno.Location = new Point(12, 176);
            gbSplneno.Name = "gbSplneno";
            gbSplneno.Size = new Size(200, 50);
            gbSplneno.TabIndex = 3;
            gbSplneno.TabStop = false;
            gbSplneno.Text = "Splněno";
            // 
            // NovyUkolForm
            // 
            ClientSize = new Size(224, 267);
            Controls.Add(bZrusit);
            Controls.Add(bPridat);
            Controls.Add(gbSplneno);
            Controls.Add(dtpDatum);
            Controls.Add(tbPodrobnosti);
            Controls.Add(tbNazev);
            Name = "NovyUkolForm";
            Text = "Nový Úkol";
            Load += NovyUkolForm_Load;
            gbSplneno.ResumeLayout(false);
            gbSplneno.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
