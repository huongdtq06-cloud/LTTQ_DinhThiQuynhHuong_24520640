using System.Drawing.Text;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();

            foreach (FontFamily font in fonts.Families)
            {
                richTextBox1.SelectionFont = new Font(font.Name,14);
                richTextBox1.AppendText($"{font.Name}\n");
            }
        }
    }
}
