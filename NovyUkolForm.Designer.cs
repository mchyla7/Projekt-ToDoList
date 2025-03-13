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
            textBox1 = new TextBox();
            lNazevUkolu = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            bPridat = new Button();
            bZrusit = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(281, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
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
            lNazevUkolu.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(281, 286);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
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
            // textBox2
            // 
            textBox2.Location = new Point(281, 213);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
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
            bPridat.Location = new Point(290, 357);
            bPridat.Name = "bPridat";
            bPridat.Size = new Size(154, 76);
            bPridat.TabIndex = 8;
            bPridat.Text = "Přidat";
            bPridat.UseVisualStyleBackColor = true;
            // 
            // bZrusit
            // 
            bZrusit.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bZrusit.Location = new Point(59, 357);
            bZrusit.Name = "bZrusit";
            bZrusit.Size = new Size(154, 76);
            bZrusit.TabIndex = 9;
            bZrusit.Text = "Zrušit";
            bZrusit.UseVisualStyleBackColor = true;
            // 
            // NovyUkolForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 513);
            Controls.Add(bZrusit);
            Controls.Add(bPridat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(lNazevUkolu);
            Controls.Add(textBox1);
            Name = "NovyUkolForm";
            Text = "NovyUkolForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lNazevUkolu;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button bPridat;
        private Button bZrusit;
    }
}