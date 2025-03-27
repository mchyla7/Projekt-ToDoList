namespace Projekt_ToDoList
{
    partial class SeznamUkoluForm
    {
        private System.Windows.Forms.DataGridView dataGridView1;

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(760, 437);
            dataGridView1.TabIndex = 0;
            // 
            // SeznamUkoluForm
            // 
            ClientSize = new Size(784, 461);
            Controls.Add(dataGridView1);
            Name = "SeznamUkoluForm";
            Text = "Seznam Úkolů";
            Load += SeznamUkoluForm_Load;
            ResumeLayout(false);
        }

        private void SeznamUkoluForm_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}

