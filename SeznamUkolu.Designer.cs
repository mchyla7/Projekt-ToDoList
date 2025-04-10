namespace Projekt_ToDoList
{
    partial class SeznamUkoluForm
    {
        private System.Windows.Forms.DataGridView dataGridView1;

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            bUpravit = new Button();
            bSmazat = new Button();
            bZpet = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(684, 316);
            dataGridView1.TabIndex = 0;
            // 
            // bUpravit
            // 
            bUpravit.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bUpravit.Location = new Point(62, 365);
            bUpravit.Name = "bUpravit";
            bUpravit.Size = new Size(106, 61);
            bUpravit.TabIndex = 1;
            bUpravit.Text = "Upravit";
            bUpravit.UseVisualStyleBackColor = true;
            bUpravit.Click += bUpravit_Click;
            // 
            // bSmazat
            // 
            bSmazat.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bSmazat.Location = new Point(318, 365);
            bSmazat.Name = "bSmazat";
            bSmazat.Size = new Size(106, 61);
            bSmazat.TabIndex = 2;
            bSmazat.Text = "Smazat";
            bSmazat.UseVisualStyleBackColor = true;
            bSmazat.Click += bSmazat_Click;
            // 
            // bZpet
            // 
            bZpet.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bZpet.Location = new Point(590, 365);
            bZpet.Name = "bZpet";
            bZpet.Size = new Size(106, 61);
            bZpet.TabIndex = 3;
            bZpet.Text = "Zpět";
            bZpet.UseVisualStyleBackColor = true;
            bZpet.Click += bZpet_Click;
            // 
            // SeznamUkoluForm
            // 
            ClientSize = new Size(784, 461);
            Controls.Add(bZpet);
            Controls.Add(bSmazat);
            Controls.Add(bUpravit);
            Controls.Add(dataGridView1);
            Name = "SeznamUkoluForm";
            Text = "Seznam úkolů";
            Load += SeznamUkoluForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private void SeznamUkoluForm_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        private Button bUpravit;
        private Button bSmazat;
        private Button bZpet;
    }
}

