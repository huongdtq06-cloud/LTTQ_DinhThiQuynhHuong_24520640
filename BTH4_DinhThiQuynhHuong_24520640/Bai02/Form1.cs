using System.Windows.Forms;
namespace Bai02
{
    public partial class Form1 : Form
    {

        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval= 1000;
            timer.Tick += updateTime;
            timer.Start();
        }
        private void updateTime(object sender, EventArgs e) {
            label_datetime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss");
        }
    }
}
