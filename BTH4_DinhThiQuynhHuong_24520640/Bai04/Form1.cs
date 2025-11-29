using System.Drawing.Text;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {

        Font font = new Font("Tahoma", 14);
        bool issaved = false;
        string filePath;
        public Form1()
        {
            InitializeComponent();

        }


        private void DDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.SelectionFont = fontDialog1.Font;
                toolStripComboBox1.Text=fontDialog1.Font.Name;
                toolStripComboBox2.Text=fontDialog1.Font.Size.ToString();
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();

            foreach (FontFamily font in fonts.Families)
            {
                toolStripComboBox1.Items.Add(font.Name);
            }
            toolStripComboBox1.SelectedText = "Tahoma";
            toolStripComboBox2.SelectedText = "14";
            if (!string.IsNullOrEmpty(toolStripComboBox1.Text) && !string.IsNullOrEmpty(toolStripComboBox2.Text))
            {
                richTextBox1.SelectionFont = new Font(toolStripComboBox1.Text, float.Parse(toolStripComboBox2.Text));
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(toolStripComboBox1.Text) && !string.IsNullOrEmpty(toolStripComboBox2.Text))
            {
                richTextBox1.SelectionFont = new Font(toolStripComboBox1.Text, float.Parse(toolStripComboBox2.Text));
            }
        }



        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            font = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(font, font.Style ^ FontStyle.Bold);

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            font = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(font, font.Style ^ FontStyle.Italic);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            font = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(font, font.Style ^ FontStyle.Underline);
        }

        private void new_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Font = new Font("Tahoma", 14, FontStyle.Regular);
            toolStripComboBox1.Text = "Tahoma";
            toolStripComboBox2.Text = "14";
            issaved = false;
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                string ext = Path.GetExtension(filePath).ToLower();
                if (ext == ".rtf") richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                else richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                issaved = true;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (issaved)
            {
                richTextBox1.SaveFile(filePath);
                MessageBox.Show("Luu van ban thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;
                string content = richTextBox1.Text;
                richTextBox1.SaveFile(filePath);
                issaved = true;
            }
        }

        private void ToolStripMenuItem_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
