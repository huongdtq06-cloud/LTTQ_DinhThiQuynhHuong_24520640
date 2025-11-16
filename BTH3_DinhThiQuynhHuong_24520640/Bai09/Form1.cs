namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int check(string masv)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells[0].Value != null &&
                        row.Cells[0].Value.ToString() == masv)
                    {
                        return row.Index;
                    }
                }

            }
            return -1;
        }
        private void SuaItem(int index)
        {

            ListViewItem tmp;
            string GT = "Unknown";
            if (cb_nam.Checked)
            {
                GT = cb_nam.Text;
                cb_nam.Checked = false;
            }
            else if (cb_nu.Checked)
            {
                GT = cb_nu.Text;
                cb_nu.Checked = false;
            }

            if (GT == "Unknown" || string.IsNullOrWhiteSpace(tb_masv.Text) || string.IsNullOrWhiteSpace(tb_ten.Text))
            {
                MessageBox.Show("Vui long nhap day du thong tin.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            int count = lv_listMHDK.Items.Count;

            dataGridView1.Rows[index].SetValues(tb_masv.Text, tb_ten.Text, cb_nganh.Text, GT, count.ToString());


        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            int index = check(tb_masv.Text);
            if (index != -1)
            {
                SuaItem(index);
                btn_xoa_Click(sender, e);
                return;
            }
            ListViewItem tmp;
            string GT = "Unknown";
            if (cb_nam.Checked)
            {
                GT = cb_nam.Text;
                cb_nam.Checked = false;
            }
            else if (cb_nu.Checked)
            {
                GT = cb_nu.Text;
                cb_nu.Checked = false;
            }

            if (GT == "Unknown" || string.IsNullOrWhiteSpace(tb_masv.Text) || string.IsNullOrWhiteSpace(tb_ten.Text))
            {
                MessageBox.Show("Vui long nhap day du thong tin.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            int count = lv_listMHDK.Items.Count;

            dataGridView1.Rows.Add(tb_masv.Text, tb_ten.Text, cb_nganh.Text, GT, count.ToString());

            btn_xoa_Click(sender, e);

        }


        private void btn_addMH_Click(object sender, EventArgs e)
        {
            int selected = lv_listMH.SelectedItems.Count;
            if (selected > 0)
            {
                ListViewItem tmp;
                for (int i = 0; i < selected; i++)
                {
                    tmp = (ListViewItem)lv_listMH.SelectedItems[0].Clone();
                    lv_listMHDK.Items.Add(tmp);
                    lv_listMH.Items.Remove(lv_listMH.SelectedItems[0]);
                }
            }
        }

        private void btn_cancelMH_Click(object sender, EventArgs e)
        {
            int selected = lv_listMHDK.SelectedItems.Count;
            if (selected > 0)
            {
                ListViewItem tmp;
                for (int i = 0; i < selected; i++)
                {
                    tmp = (ListViewItem)lv_listMHDK.SelectedItems[0].Clone();
                    lv_listMH.Items.Add(tmp);
                    lv_listMHDK.Items.Remove(lv_listMHDK.SelectedItems[0]);
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            ListViewItem tmp;
            int count = lv_listMHDK.Items.Count;
            tb_masv.Clear();
            tb_ten.Clear();
            cb_nam.Checked = false;
            cb_nu.Checked = false;
            cb_nganh.SelectedIndex = 0;
            for (int i = 0; i < count; i++)
            {
                tmp = (ListViewItem)lv_listMHDK.Items[0].Clone();
                lv_listMHDK.Items.RemoveAt(0);
                lv_listMH.Items.Add(tmp);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_nganh.SelectedIndex = 0;
        }
    }
}
