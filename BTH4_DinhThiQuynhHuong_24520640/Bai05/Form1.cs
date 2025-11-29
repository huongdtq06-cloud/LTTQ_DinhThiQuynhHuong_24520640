namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton_add_Click(object sender, EventArgs e)
        {
            Form_add childForm_Add = new Form_add(this);
            childForm_Add.Show();

        }
        public void UpdateSTT()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                Form_add childForm_Add = new Form_add(this);
                childForm_Add.Show();
            }
        }

        public void AddStudent(string mssv, string name, string khoa, string diem)
        {
            int stt = dataGridView1.Rows.Count + 1;
            dataGridView1.Rows.Add(stt, mssv, name, khoa, diem);
        }

        private void ToolStripTextBox1_find_TextChanged(object sender, EventArgs e)
        {
            string key = toolStripTextBox1_find.Text.ToLower().Trim();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string name = row.Cells[2].Value.ToString().ToLower();

                row.Visible = name.Contains(key);
            }
        }

        private void ToolStripMenuItem_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
