using System.Windows.Forms;

namespace Bai01
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
            lb_Font = new Label();
            cbb_font = new ComboBox();
            cbb_size = new ComboBox();
            lb_size = new Label();
            cb_B = new CheckBox();
            cb_I = new CheckBox();
            cb_U = new CheckBox();
            colorDialog1 = new ColorDialog();
            lb_color = new Label();
            btn_color = new Button();
            gb_AllignText = new GroupBox();
            rb_Right = new RadioButton();
            rb_Center = new RadioButton();
            rb_left = new RadioButton();
            textBox1 = new TextBox();
            gb_AllignText.SuspendLayout();
            SuspendLayout();
            // 
            // lb_Font
            // 
            lb_Font.AutoSize = true;
            lb_Font.Location = new Point(29, 42);
            lb_Font.Name = "lb_Font";
            lb_Font.Size = new Size(38, 20);
            lb_Font.TabIndex = 0;
            lb_Font.Text = "Font";
            // 
            // cbb_font
            // 
            cbb_font.FormattingEnabled = true;
            cbb_font.Location = new Point(86, 39);
            cbb_font.Name = "cbb_font";
            cbb_font.Size = new Size(199, 28);
            cbb_font.TabIndex = 1;
            cbb_font.SelectedIndexChanged += cbb_font_SelectedIndexChanged;
            // 
            // cbb_size
            // 
            cbb_size.FormattingEnabled = true;
            cbb_size.Items.AddRange(new object[] { "8", "9", "10", "11", "12 ", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" });
            cbb_size.Location = new Point(348, 39);
            cbb_size.Name = "cbb_size";
            cbb_size.Size = new Size(96, 28);
            cbb_size.TabIndex = 2;
            cbb_size.SelectedIndexChanged += cbb_size_SelectedIndexChanged;
            cbb_size.KeyDown += Cbb_size_keydown;
            // 
            // lb_size
            // 
            lb_size.AutoSize = true;
            lb_size.Location = new Point(306, 42);
            lb_size.Name = "lb_size";
            lb_size.Size = new Size(36, 20);
            lb_size.TabIndex = 3;
            lb_size.Text = "Size";
            // 
            // cb_B
            // 
            cb_B.AutoSize = true;
            cb_B.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            cb_B.Location = new Point(38, 77);
            cb_B.Name = "cb_B";
            cb_B.Size = new Size(49, 34);
            cb_B.TabIndex = 4;
            cb_B.Text = "B";
            cb_B.UseVisualStyleBackColor = true;
            cb_B.CheckedChanged += cb_B_CheckedChanged;
            // 
            // cb_I
            // 
            cb_I.AutoSize = true;
            cb_I.Font = new Font("Segoe UI", 13F, FontStyle.Italic);
            cb_I.Location = new Point(93, 77);
            cb_I.Name = "cb_I";
            cb_I.Size = new Size(41, 34);
            cb_I.TabIndex = 5;
            cb_I.Text = "I";
            cb_I.UseVisualStyleBackColor = true;
            cb_I.CheckedChanged += cb_I_CheckedChanged;
            // 
            // cb_U
            // 
            cb_U.AutoSize = true;
            cb_U.Font = new Font("Segoe UI", 13F, FontStyle.Underline);
            cb_U.Location = new Point(140, 77);
            cb_U.Name = "cb_U";
            cb_U.Size = new Size(50, 34);
            cb_U.TabIndex = 6;
            cb_U.Text = "U";
            cb_U.UseVisualStyleBackColor = true;
            cb_U.CheckedChanged += cb_U_CheckedChanged;
            // 
            // lb_color
            // 
            lb_color.AutoSize = true;
            lb_color.Location = new Point(297, 86);
            lb_color.Name = "lb_color";
            lb_color.Size = new Size(45, 20);
            lb_color.TabIndex = 7;
            lb_color.Text = "Color";
            // 
            // btn_color
            // 
            btn_color.Location = new Point(362, 82);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(42, 29);
            btn_color.TabIndex = 8;
            btn_color.Text = "\r\n";
            btn_color.UseVisualStyleBackColor = true;
            btn_color.Click += btn_color_Click;
            // 
            // gb_AllignText
            // 
            gb_AllignText.Controls.Add(rb_Right);
            gb_AllignText.Controls.Add(rb_Center);
            gb_AllignText.Controls.Add(rb_left);
            gb_AllignText.ForeColor = Color.Blue;
            gb_AllignText.Location = new Point(38, 117);
            gb_AllignText.Name = "gb_AllignText";
            gb_AllignText.Size = new Size(176, 128);
            gb_AllignText.TabIndex = 9;
            gb_AllignText.TabStop = false;
            gb_AllignText.Text = "Allign Text";
            // 
            // rb_Right
            // 
            rb_Right.AutoSize = true;
            rb_Right.ForeColor = Color.Black;
            rb_Right.Location = new Point(23, 87);
            rb_Right.Name = "rb_Right";
            rb_Right.Size = new Size(65, 24);
            rb_Right.TabIndex = 2;
            rb_Right.TabStop = true;
            rb_Right.Text = "Right";
            rb_Right.UseVisualStyleBackColor = true;
            rb_Right.CheckedChanged += rb_CheckedChanged;
            // 
            // rb_Center
            // 
            rb_Center.AutoSize = true;
            rb_Center.ForeColor = Color.Black;
            rb_Center.Location = new Point(23, 57);
            rb_Center.Name = "rb_Center";
            rb_Center.Size = new Size(73, 24);
            rb_Center.TabIndex = 1;
            rb_Center.TabStop = true;
            rb_Center.Text = "Center";
            rb_Center.UseVisualStyleBackColor = true;
            rb_Center.CheckedChanged += rb_CheckedChanged;
            // 
            // rb_left
            // 
            rb_left.AutoSize = true;
            rb_left.ForeColor = Color.Black;
            rb_left.Location = new Point(23, 27);
            rb_left.Name = "rb_left";
            rb_left.Size = new Size(55, 24);
            rb_left.TabIndex = 0;
            rb_left.TabStop = true;
            rb_left.Text = "Left";
            rb_left.UseVisualStyleBackColor = true;
            rb_left.CheckedChanged += rb_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 28F);
            textBox1.Location = new Point(240, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 70);
            textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 274);
            Controls.Add(textBox1);
            Controls.Add(gb_AllignText);
            Controls.Add(btn_color);
            Controls.Add(lb_color);
            Controls.Add(cb_U);
            Controls.Add(cb_I);
            Controls.Add(cb_B);
            Controls.Add(lb_size);
            Controls.Add(cbb_size);
            Controls.Add(cbb_font);
            Controls.Add(lb_Font);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gb_AllignText.ResumeLayout(false);
            gb_AllignText.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label lb_Font;
        private ComboBox cbb_font;
        private ComboBox cbb_size;
        private Label lb_size;
        private CheckBox cb_B;
        private CheckBox cb_I;
        private CheckBox cb_U;
        private ColorDialog colorDialog1;
        private Label lb_color;
        private Button btn_color;
        private GroupBox gb_AllignText;
        private RadioButton rb_Right;
        private RadioButton rb_Center;
        private RadioButton rb_left;
        private TextBox textBox1;
    }
}
