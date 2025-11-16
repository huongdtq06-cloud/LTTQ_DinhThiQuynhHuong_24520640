namespace WinFormsApp1
{
    public partial class BanVeRapChieuPhim : Form
    {
        private List<Panel> panels = new List<Panel>(4);
        private List<Panel> booked = new List<Panel>(4);
        private int sum=0;
        public BanVeRapChieuPhim()
        {
            InitializeComponent();
        }


        private void OnChooseSeat(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;

            if (p.BackColor == Color.Yellow)
                MessageBox.Show("Vi tri nay da duoc ban.");
            else if (!panels.Contains(p))
            {
                p.BackColor = Color.Blue;
                panels.Add(p);
            }
            else if (panels.Contains(p))
            {
                p.BackColor = Color.White;
                panels.Remove(p);
            }

        }
        private void OnChooseSeat_lb(object sender, EventArgs e)
        {
            Label lblSeat = (Label)sender;
            Panel p = (Panel)lblSeat.Parent;

            if (p.BackColor == Color.Yellow)
                MessageBox.Show("Vi tri nay da duoc ban.");
            else if (!panels.Contains(p))
            {
                p.BackColor = Color.Blue;
                panels.Add(p);
            }
            else if (panels.Contains(p))
            {
                p.BackColor = Color.White;
                panels.Remove(p);
            }

        }

        private void btn_chon_Click(object sender, EventArgs e)
        {            
            foreach (var u in panels)
            {
                u.BackColor = Color.Yellow;
                if (u.TabIndex == 3) sum += 5000;
                else if (u.TabIndex == 2) sum += 6500;
                else sum += 8000;
            }
            panels.Clear();
            textBox1.Text = sum.ToString();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {

            foreach (var u in panels)
            {
                u.BackColor = Color.White;
            }
            panels.Clear();
            textBox1.Text = "0";
        }

        private void btn_KT_Click(object sender, EventArgs e)
        {
            sum = 0;
            textBox1.Text = "0";
        }
    }
}
