namespace Projekt_ToDoList
{
    partial class MainForm
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
            label1 = new Label();
            bNovyUkol = new Button();
            bSeznam = new Button();
            bKonec = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(74, 47);
            label1.Name = "label1";
            label1.Size = new Size(299, 86);
            label1.TabIndex = 0;
            label1.Text = "ToDo List";
            // 
            // bNovyUkol
            // 
            bNovyUkol.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bNovyUkol.Location = new Point(143, 155);
            bNovyUkol.Name = "bNovyUkol";
            bNovyUkol.Size = new Size(142, 48);
            bNovyUkol.TabIndex = 1;
            bNovyUkol.Text = "Nový úkol";
            bNovyUkol.UseVisualStyleBackColor = true;
            bNovyUkol.Click += bNovyUkol_Click;
            // 
            // bSeznam
            // 
            bSeznam.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bSeznam.Location = new Point(118, 228);
            bSeznam.Name = "bSeznam";
            bSeznam.Size = new Size(198, 48);
            bSeznam.TabIndex = 2;
            bSeznam.Text = "Seznam úkolů";
            bSeznam.UseVisualStyleBackColor = true;
            bSeznam.Click += bSeznam_Click;
            // 
            // bKonec
            // 
            bKonec.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bKonec.Location = new Point(143, 300);
            bKonec.Name = "bKonec";
            bKonec.Size = new Size(142, 48);
            bKonec.TabIndex = 3;
            bKonec.Text = "Konec";
            bKonec.UseVisualStyleBackColor = true;
            bKonec.Click += bKonec_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 450);
            Controls.Add(bKonec);
            Controls.Add(bSeznam);
            Controls.Add(bNovyUkol);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bNovyUkol;
        private Button bSeznam;
        private Button bKonec;
    }
}