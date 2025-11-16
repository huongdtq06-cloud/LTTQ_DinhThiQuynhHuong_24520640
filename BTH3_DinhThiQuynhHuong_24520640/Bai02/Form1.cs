using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private void paint_Click(object sender, EventArgs e)
        {
            Invalidate();
        }
        private void form1_Paint(object sender, PaintEventArgs e)
        {
            string str = "Paint Event";
            Font font = new Font("Times New Roman", 14);
            SizeF textSize = e.Graphics.MeasureString(str, font);
            int maxX = (int)(ClientSize.Width - textSize.Width);
            int maxY = (int)(ClientSize.Height - textSize.Height);

            int x = random.Next(0, Math.Max(1, maxX)); 
            int y = random.Next(0, Math.Max(1, maxY));
            e.Graphics.DrawString(str,font,Brushes.Black, x,y);
        }
    }
}
