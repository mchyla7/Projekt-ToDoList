namespace Projekt_ToDoList
{
    partial class UpravitUkolForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpravitUkolForm));
            bZrusit = new Button();
            bPridat = new Button();
            gbSplneno = new GroupBox();
            rbAno = new RadioButton();
            rbNe = new RadioButton();
            dtpDatum = new DateTimePicker();
            tbPodrobnosti = new TextBox();
            tbNazev = new TextBox();
            gbSplneno.SuspendLayout();
            SuspendLayout();
            // 
            // bZrusit
            // 
            resources.ApplyResources(bZrusit, "bZrusit");
            bZrusit.Name = "bZrusit";
            bZrusit.UseVisualStyleBackColor = true;
            bZrusit.Click += bZrusit_Click_1;
            // 
            // bPridat
            // 
            resources.ApplyResources(bPridat, "bPridat");
            bPridat.Name = "bPridat";
            bPridat.UseVisualStyleBackColor = true;
            bPridat.Click += bPridat_Click;
            // 
            // gbSplneno
            // 
            gbSplneno.Controls.Add(rbAno);
            gbSplneno.Controls.Add(rbNe);
            resources.ApplyResources(gbSplneno, "gbSplneno");
            gbSplneno.Name = "gbSplneno";
            gbSplneno.TabStop = false;
            // 
            // rbAno
            // 
            resources.ApplyResources(rbAno, "rbAno");
            rbAno.Name = "rbAno";
            rbAno.TabStop = true;
            rbAno.UseVisualStyleBackColor = true;
            // 
            // rbNe
            // 
            resources.ApplyResources(rbNe, "rbNe");
            rbNe.Name = "rbNe";
            rbNe.TabStop = true;
            rbNe.UseVisualStyleBackColor = true;
            // 
            // dtpDatum
            // 
            resources.ApplyResources(dtpDatum, "dtpDatum");
            dtpDatum.Name = "dtpDatum";
            // 
            // tbPodrobnosti
            // 
            resources.ApplyResources(tbPodrobnosti, "tbPodrobnosti");
            tbPodrobnosti.Name = "tbPodrobnosti";
            // 
            // tbNazev
            // 
            resources.ApplyResources(tbNazev, "tbNazev");
            tbNazev.Name = "tbNazev";
            // 
            // UpravitUkolForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bZrusit);
            Controls.Add(bPridat);
            Controls.Add(gbSplneno);
            Controls.Add(dtpDatum);
            Controls.Add(tbPodrobnosti);
            Controls.Add(tbNazev);
            Name = "UpravitUkolForm";
            gbSplneno.ResumeLayout(false);
            gbSplneno.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bZrusit;
        private Button bPridat;
        private GroupBox gbSplneno;
        private RadioButton rbAno;
        private RadioButton rbNe;
        private DateTimePicker dtpDatum;
        private TextBox tbPodrobnosti;
        private TextBox tbNazev;
    }
}