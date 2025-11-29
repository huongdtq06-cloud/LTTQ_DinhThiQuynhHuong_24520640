namespace Bai03
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += updateTime;
            timer.Start();
        }
        private void updateTime(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Hôm nay là ngày {DateTime.Now.ToString("dd/mm/yyyy")} - Bây gio là {DateTime.Now.ToString("HH:mm:ss tt")} ";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
