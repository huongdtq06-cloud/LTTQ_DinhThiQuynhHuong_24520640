namespace Bai08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CapNhatSTT()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }
        private void ThemItem(string stk, string ten, string diachi, string sotien)
        {
            int stt = listView1.Items.Count + 1;
            ListViewItem item = new ListViewItem(stt.ToString());
            item.SubItems.Add(stk);
            item.SubItems.Add(ten);
            item.SubItems.Add(diachi);
            item.SubItems.Add(sotien);


            listView1.Items.Add(item);
            lb_thongbao.Text = "Them moi du lieu thanh cong!";
            lb_thongbao.ForeColor = Color.Blue;
        }
        private void SuaItem(int index, string ten, string diachi, string sotien)
        {

            listView1.Items[index].SubItems[2].Text = ten;
            listView1.Items[index].SubItems[3].Text = diachi;
            listView1.Items[index].SubItems[4].Text = sotien;
            lb_thongbao.Text = "Cap nhat du lieu thanh cong!";
            lb_thongbao.ForeColor = Color.Blue;

        }

        private int check(string stk)
        {
            foreach (ListViewItem i in listView1.Items)
            {
                if (i.SubItems[1].Text == stk)
                    return i.Index;
            }
            return -1;
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            int Index = check(tb_stk.Text);
            if (Index != -1)
                SuaItem(Index, tb_tenKH.Text, tb_diachiKH.Text, tb_sotien.Text);
            else if(string.IsNullOrWhiteSpace(tb_stk.Text) || string.IsNullOrWhiteSpace(tb_tenKH.Text) || string.IsNullOrWhiteSpace(tb_diachiKH.Text) || string.IsNullOrEmpty(tb_sotien.Text)) {
                lb_thongbao.Text = "Vui long nhap day du thong tin.";
                lb_thongbao.ForeColor = Color.Red;
            }else ThemItem(tb_stk.Text, tb_tenKH.Text, tb_diachiKH.Text, tb_sotien.Text);

            CapNhatSTT();
            tb_stk.Clear();
            tb_tenKH.Clear();
            tb_diachiKH.Clear();
            tb_sotien.Clear();
        }

        private void tb_diachiKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Tai khoan {tb_stk.Text} se bi xoa.",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                int Index = check(tb_stk.Text);
                if (Index == -1) MessageBox.Show("Khong tim thay tai khoan can xoa.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                else listView1.Items[Index].Remove();
                CapNhatSTT();
                lb_thongbao.Text = "Xoa tai khoan thanh cong";
                lb_thongbao.ForeColor = Color.Blue;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_thongbao.Text = "";
            if (listView1.SelectedItems.Count == 0)
                return;
            tb_stk.Text = listView1.SelectedItems[0].SubItems[1].Text;
            tb_tenKH.Text = listView1.SelectedItems[0].SubItems[2].Text;
            tb_diachiKH.Text = listView1.SelectedItems[0].SubItems[3].Text;
            tb_sotien.Text = listView1.SelectedItems[0].SubItems[4].Text;

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
