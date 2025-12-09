using System.Drawing.Text;

namespace Bai01
{
    public partial class Form1 : Form
    {
        FontStyle fontStyle = FontStyle.Regular;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();

            foreach (FontFamily font in fonts.Families)
            {
                cbb_font.Items.Add(font.Name);
            }
            cbb_font.SelectedText = "Arial";
            cbb_size.SelectedText = "28";
            rb_left.Checked = true;
            btn_color.BackColor = Color.Black;
            textBox1.Font= new Font(cbb_font.Text, float.Parse(cbb_size.Text), fontStyle);
            textBox1.Text = "Hello";
        }
        private void Cbb_size_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Font = new Font(cbb_font.Text, float.Parse(cbb_size.Text), fontStyle);
            }
        }
        private void cbb_size_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox1.Font = new Font(cbb_font.Text, float.Parse(cbb_size.Text), fontStyle);
        }

        private void cbb_font_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(cbb_font.Text, float.Parse(cbb_size.Text), fontStyle);
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
                btn_color.BackColor = colorDialog1.Color;
            }
        }

        private void cb_B_CheckedChanged(object sender, EventArgs e)
        {
            fontStyle ^= FontStyle.Bold;
            textBox1.Font = new Font(cbb_font.Text, float.Parse(cbb_size.Text), fontStyle);
        }

        private void cb_I_CheckedChanged(object sender, EventArgs e)
        {
            fontStyle ^= FontStyle.Italic;
            textBox1.Font = new Font(cbb_font.Text, float.Parse(cbb_size.Text), fontStyle);
        }

        private void cb_U_CheckedChanged(object sender, EventArgs e)
        {
            fontStyle ^= FontStyle.Underline;
            textBox1.Font = new Font(cbb_font.Text, float.Parse(cbb_size.Text), fontStyle);
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            var checkedRadio = gb_AllignText.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedRadio != null) {
                switch(checkedRadio.Text) {
                    case "Left":
                        textBox1.TextAlign= HorizontalAlignment.Left; break;
                    case "Center":
                        textBox1.TextAlign = HorizontalAlignment.Center; break;
                    case "Right":
                        textBox1.TextAlign=HorizontalAlignment.Right; break;
                    }

            }
        }
    }
}
