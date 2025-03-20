namespace Projekt_ToDoList
{
    partial class NovyUkolForm
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
            tbNazev = new TextBox();
            lNazevUkolu = new Label();
            dtpDatum = new DateTimePicker();
            label1 = new Label();
            tbPodrobnosti = new TextBox();
            label2 = new Label();
            label3 = new Label();
            bPridat = new Button();
            bZrusit = new Button();
            rbAno = new RadioButton();
            label4 = new Label();
            rbNe = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbNazev
            // 
            tbNazev.Location = new Point(281, 153);
            tbNazev.Name = "tbNazev";
            tbNazev.Size = new Size(100, 23);
            tbNazev.TabIndex = 0;
            // 
            // lNazevUkolu
            // 
            lNazevUkolu.AutoSize = true;
            lNazevUkolu.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lNazevUkolu.Location = new Point(36, 140);
            lNazevUkolu.Name = "lNazevUkolu";
            lNazevUkolu.Size = new Size(224, 50);
            lNazevUkolu.TabIndex = 1;
            lNazevUkolu.Text = "Název úkolu";
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(281, 286);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(200, 23);
            dtpDatum.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(36, 205);
            label1.Name = "label1";
            label1.Size = new Size(194, 45);
            label1.TabIndex = 4;
            label1.Text = "Podrobnosti";
            // 
            // tbPodrobnosti
            // 
            tbPodrobnosti.Location = new Point(281, 213);
            tbPodrobnosti.Name = "tbPodrobnosti";
            tbPodrobnosti.Size = new Size(100, 23);
            tbPodrobnosti.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(12, 268);
            label2.Name = "label2";
            label2.Size = new Size(226, 45);
            label2.TabIndex = 6;
            label2.Text = "Datum splnění";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(18, 35);
            label3.Name = "label3";
            label3.Size = new Size(477, 65);
            label3.TabIndex = 7;
            label3.Text = "Přidání nového úkolu";
            // 
            // bPridat
            // 
            bPridat.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bPridat.Location = new Point(291, 399);
            bPridat.Name = "bPridat";
            bPridat.Size = new Size(154, 76);
            bPridat.TabIndex = 8;
            bPridat.Text = "Přidat";
            bPridat.UseVisualStyleBackColor = true;
            bPridat.Click += bPridat_Click;
            // 
            // bZrusit
            // 
            bZrusit.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bZrusit.Location = new Point(54, 399);
            bZrusit.Name = "bZrusit";
            bZrusit.Size = new Size(154, 76);
            bZrusit.TabIndex = 9;
            bZrusit.Text = "Zrušit";
            bZrusit.UseVisualStyleBackColor = true;
            bZrusit.Click += bZrusit_Click;
            // 
            // rbAno
            // 
            rbAno.Location = new Point(25, 19);
            rbAno.Name = "rbAno";
            rbAno.Size = new Size(58, 24);
            rbAno.TabIndex = 0;
            rbAno.Text = "Ano";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(18, 324);
            label4.Name = "label4";
            label4.Size = new Size(143, 45);
            label4.TabIndex = 10;
            label4.Text = "Splněno:";
            // 
            // rbNe
            // 
            rbNe.Location = new Point(121, 21);
            rbNe.Name = "rbNe";
            rbNe.Size = new Size(73, 24);
            rbNe.TabIndex = 11;
            rbNe.Text = "Ne";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbAno);
            groupBox1.Controls.Add(rbNe);
            groupBox1.Location = new Point(256, 324);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 54);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // NovyUkolForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 513);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(bZrusit);
            Controls.Add(bPridat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbPodrobnosti);
            Controls.Add(label1);
            Controls.Add(dtpDatum);
            Controls.Add(lNazevUkolu);
            Controls.Add(tbNazev);
            Name = "NovyUkolForm";
            Text = "NovyUkolForm";

            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNazev;
        private Label lNazevUkolu;
        private DateTimePicker dtpDatum;
        private Label label1;
        private TextBox tbPodrobnosti;
        private Label label2;
        private Label label3;
        private Button bPridat;
        private Button bZrusit;
        private RadioButton rbAno;
        private Label label4;
        private RadioButton rbNe;
        private GroupBox groupBox1;
    }
}