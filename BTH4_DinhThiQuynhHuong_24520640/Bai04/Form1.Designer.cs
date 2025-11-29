using System.Windows.Forms;

namespace Bai04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            ToolStripMenuItem_hethong = new ToolStripMenuItem();
            ToolStripMenuItem_new = new ToolStripMenuItem();
            ToolStripMenuItem_open = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            ToolStripMenuItem_save = new ToolStripMenuItem();
            ToolStripMenuItem_close = new ToolStripMenuItem();
            ToolStripMenuItem_format = new ToolStripMenuItem();
            fontDialog1 = new FontDialog();
            richTextBox1 = new RichTextBox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripComboBox2 = new ToolStripComboBox();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem_hethong, ToolStripMenuItem_format });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_hethong
            // 
            ToolStripMenuItem_hethong.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_new, ToolStripMenuItem_open, toolStripSeparator3, ToolStripMenuItem_save, ToolStripMenuItem_close });
            ToolStripMenuItem_hethong.Name = "ToolStripMenuItem_hethong";
            ToolStripMenuItem_hethong.Size = new Size(85, 24);
            ToolStripMenuItem_hethong.Text = "Hệ thống";
            // 
            // ToolStripMenuItem_new
            // 
            ToolStripMenuItem_new.Image = (Image)resources.GetObject("ToolStripMenuItem_new.Image");
            ToolStripMenuItem_new.Name = "ToolStripMenuItem_new";
            ToolStripMenuItem_new.ShortcutKeys = Keys.Control | Keys.N;
            ToolStripMenuItem_new.Size = new Size(285, 26);
            ToolStripMenuItem_new.Text = "Tạo văn bản mới";
            ToolStripMenuItem_new.Click += new_Click;
            // 
            // ToolStripMenuItem_open
            // 
            ToolStripMenuItem_open.Image = (Image)resources.GetObject("ToolStripMenuItem_open.Image");
            ToolStripMenuItem_open.Name = "ToolStripMenuItem_open";
            ToolStripMenuItem_open.Size = new Size(285, 26);
            ToolStripMenuItem_open.Text = "Mở tập tin";
            ToolStripMenuItem_open.Click += open_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(282, 6);
            // 
            // ToolStripMenuItem_save
            // 
            ToolStripMenuItem_save.Image = (Image)resources.GetObject("ToolStripMenuItem_save.Image");
            ToolStripMenuItem_save.Name = "ToolStripMenuItem_save";
            ToolStripMenuItem_save.ShortcutKeys = Keys.Control | Keys.S;
            ToolStripMenuItem_save.Size = new Size(285, 26);
            ToolStripMenuItem_save.Text = "Lưu nội dung văn bản";
            ToolStripMenuItem_save.Click += save_Click;
            // 
            // ToolStripMenuItem_close
            // 
            ToolStripMenuItem_close.Name = "ToolStripMenuItem_close";
            ToolStripMenuItem_close.Size = new Size(285, 26);
            ToolStripMenuItem_close.Text = "Thoát";
            ToolStripMenuItem_close.Click += ToolStripMenuItem_close_Click;
            // 
            // ToolStripMenuItem_format
            // 
            ToolStripMenuItem_format.Name = "ToolStripMenuItem_format";
            ToolStripMenuItem_format.Size = new Size(92, 24);
            ToolStripMenuItem_format.Text = "Định dạng";
            ToolStripMenuItem_format.Click += DDToolStripMenuItem_Click;
            // 
            // fontDialog1
            // 
            fontDialog1.Apply += fontDialog1_Apply;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 59);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 395);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripSeparator1, toolStripComboBox1, toolStripComboBox2, toolStripButton3, toolStripButton4, toolStripButton5, toolStripSeparator2 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 28);
            toolStrip1.TabIndex = 9;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 25);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += new_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 25);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += save_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(160, 28);
            toolStripComboBox1.SelectedIndexChanged += toolStripComboBox1_SelectedIndexChanged;
            // 
            // toolStripComboBox2
            // 
            toolStripComboBox2.Items.AddRange(new object[] { "8", "9", "10", "11", "12 ", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" });
            toolStripComboBox2.Name = "toolStripComboBox2";
            toolStripComboBox2.Size = new Size(75, 28);
            toolStripComboBox2.SelectedIndexChanged += toolStripComboBox1_SelectedIndexChanged;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 25);
            toolStripButton3.Text = "B";
            toolStripButton3.TextImageRelation = TextImageRelation.TextAboveImage;
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.Font = new Font("Times New Roman", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(29, 25);
            toolStripButton4.Text = "I";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton5.Font = new Font("Times New Roman", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(29, 25);
            toolStripButton5.Text = "U";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Rich text file (*.rtf)|*rtf|Text files (*.txt)|*.txt";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "rtf";
            saveFileDialog1.Filter = "Rich text file (*.rtf)|*rtf";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Soạn thảo văn bản";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuItem_hethong;
        private ToolStripMenuItem ToolStripMenuItem_format;
        private ToolStripMenuItem ToolStripMenuItem_new;
        private ToolStripMenuItem ToolStripMenuItem_open;
        private FontDialog fontDialog1;
        private RichTextBox richTextBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripComboBox toolStripComboBox2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem ToolStripMenuItem_save;
        private ToolStripMenuItem ToolStripMenuItem_close;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
