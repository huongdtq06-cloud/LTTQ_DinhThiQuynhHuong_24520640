namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            label1.Text = $"Key pressed: {e.KeyCode}, ASCII: {(int)e.KeyCode}";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            label1.Text = $"Mouse button: {e.Button}, Position: ({e.X}, {e.Y})";
        }
    }
}
