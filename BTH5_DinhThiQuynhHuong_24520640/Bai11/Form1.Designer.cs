namespace Bai11
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
            gb_Shapes = new GroupBox();
            rb_Ellipse = new RadioButton();
            rb_Rectangle = new RadioButton();
            rb_Line = new RadioButton();
            gb_Pen = new GroupBox();
            button1 = new Button();
            tb_width = new TextBox();
            lb_width = new Label();
            gb_brushes = new GroupBox();
            rb_LinearGradientBrush = new RadioButton();
            rb_TextureBrush = new RadioButton();
            rb_HatchBrush = new RadioButton();
            rb_SolidBrush = new RadioButton();
            colorDialog1 = new ColorDialog();
            pictureBox1 = new PictureBox();
            gb_Shapes.SuspendLayout();
            gb_Pen.SuspendLayout();
            gb_brushes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gb_Shapes
            // 
            gb_Shapes.Controls.Add(rb_Ellipse);
            gb_Shapes.Controls.Add(rb_Rectangle);
            gb_Shapes.Controls.Add(rb_Line);
            gb_Shapes.ForeColor = Color.FromArgb(0, 0, 192);
            gb_Shapes.Location = new Point(12, 12);
            gb_Shapes.Name = "gb_Shapes";
            gb_Shapes.Size = new Size(196, 120);
            gb_Shapes.TabIndex = 0;
            gb_Shapes.TabStop = false;
            gb_Shapes.Text = "Shapes";
            // 
            // rb_Ellipse
            // 
            rb_Ellipse.AutoSize = true;
            rb_Ellipse.ForeColor = Color.Black;
            rb_Ellipse.Location = new Point(16, 84);
            rb_Ellipse.Name = "rb_Ellipse";
            rb_Ellipse.Size = new Size(73, 24);
            rb_Ellipse.TabIndex = 2;
            rb_Ellipse.TabStop = true;
            rb_Ellipse.Text = "Ellipse";
            rb_Ellipse.UseVisualStyleBackColor = true;
            rb_Ellipse.CheckedChanged += rb_Ellipse_CheckedChanged;
            // 
            // rb_Rectangle
            // 
            rb_Rectangle.AutoSize = true;
            rb_Rectangle.ForeColor = Color.Black;
            rb_Rectangle.Location = new Point(16, 54);
            rb_Rectangle.Name = "rb_Rectangle";
            rb_Rectangle.Size = new Size(96, 24);
            rb_Rectangle.TabIndex = 1;
            rb_Rectangle.TabStop = true;
            rb_Rectangle.Text = "Rectangle";
            rb_Rectangle.UseVisualStyleBackColor = true;
            rb_Rectangle.CheckedChanged += rb_Rectangle_CheckedChanged;
            // 
            // rb_Line
            // 
            rb_Line.AutoSize = true;
            rb_Line.ForeColor = Color.Black;
            rb_Line.Location = new Point(16, 24);
            rb_Line.Name = "rb_Line";
            rb_Line.Size = new Size(57, 24);
            rb_Line.TabIndex = 0;
            rb_Line.TabStop = true;
            rb_Line.Text = "Line\r\n";
            rb_Line.UseVisualStyleBackColor = true;
            rb_Line.CheckedChanged += rb_Line_CheckedChanged;
            // 
            // gb_Pen
            // 
            gb_Pen.Controls.Add(button1);
            gb_Pen.Controls.Add(tb_width);
            gb_Pen.Controls.Add(lb_width);
            gb_Pen.ForeColor = Color.FromArgb(0, 0, 192);
            gb_Pen.Location = new Point(12, 138);
            gb_Pen.Name = "gb_Pen";
            gb_Pen.Size = new Size(196, 108);
            gb_Pen.TabIndex = 1;
            gb_Pen.TabStop = false;
            gb_Pen.Text = "Pen";
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(48, 63);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Color";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tb_width
            // 
            tb_width.Location = new Point(89, 20);
            tb_width.Name = "tb_width";
            tb_width.Size = new Size(71, 27);
            tb_width.TabIndex = 1;
            tb_width.TextChanged += tb_width_TextChanged;
            // 
            // lb_width
            // 
            lb_width.AutoSize = true;
            lb_width.ForeColor = Color.Black;
            lb_width.Location = new Point(16, 23);
            lb_width.Name = "lb_width";
            lb_width.Size = new Size(52, 20);
            lb_width.TabIndex = 0;
            lb_width.Text = "Width:";
            // 
            // gb_brushes
            // 
            gb_brushes.Controls.Add(rb_LinearGradientBrush);
            gb_brushes.Controls.Add(rb_TextureBrush);
            gb_brushes.Controls.Add(rb_HatchBrush);
            gb_brushes.Controls.Add(rb_SolidBrush);
            gb_brushes.ForeColor = Color.FromArgb(0, 0, 192);
            gb_brushes.Location = new Point(12, 252);
            gb_brushes.Name = "gb_brushes";
            gb_brushes.Size = new Size(196, 186);
            gb_brushes.TabIndex = 2;
            gb_brushes.TabStop = false;
            gb_brushes.Text = "Brushes";
            // 
            // rb_LinearGradientBrush
            // 
            rb_LinearGradientBrush.AutoSize = true;
            rb_LinearGradientBrush.ForeColor = Color.Black;
            rb_LinearGradientBrush.Location = new Point(16, 126);
            rb_LinearGradientBrush.Name = "rb_LinearGradientBrush";
            rb_LinearGradientBrush.Size = new Size(163, 24);
            rb_LinearGradientBrush.TabIndex = 3;
            rb_LinearGradientBrush.TabStop = true;
            rb_LinearGradientBrush.Text = "LinearGradientBrush";
            rb_LinearGradientBrush.UseVisualStyleBackColor = true;
            rb_LinearGradientBrush.CheckedChanged += rb_LinearGradientBrush_CheckedChanged;
            // 
            // rb_TextureBrush
            // 
            rb_TextureBrush.AutoSize = true;
            rb_TextureBrush.ForeColor = Color.Black;
            rb_TextureBrush.Location = new Point(16, 96);
            rb_TextureBrush.Name = "rb_TextureBrush";
            rb_TextureBrush.Size = new Size(114, 24);
            rb_TextureBrush.TabIndex = 2;
            rb_TextureBrush.TabStop = true;
            rb_TextureBrush.Text = "TextureBrush";
            rb_TextureBrush.UseVisualStyleBackColor = true;
            rb_TextureBrush.CheckedChanged += rb_TextureBrush_CheckedChanged;
            // 
            // rb_HatchBrush
            // 
            rb_HatchBrush.AutoSize = true;
            rb_HatchBrush.ForeColor = Color.Black;
            rb_HatchBrush.Location = new Point(16, 66);
            rb_HatchBrush.Name = "rb_HatchBrush";
            rb_HatchBrush.Size = new Size(105, 24);
            rb_HatchBrush.TabIndex = 1;
            rb_HatchBrush.TabStop = true;
            rb_HatchBrush.Text = "HatchBrush";
            rb_HatchBrush.UseVisualStyleBackColor = true;
            rb_HatchBrush.CheckedChanged += rb_HatchBrush_CheckedChanged;
            // 
            // rb_SolidBrush
            // 
            rb_SolidBrush.AutoSize = true;
            rb_SolidBrush.ForeColor = Color.Black;
            rb_SolidBrush.Location = new Point(16, 36);
            rb_SolidBrush.Name = "rb_SolidBrush";
            rb_SolidBrush.Size = new Size(100, 24);
            rb_SolidBrush.TabIndex = 0;
            rb_SolidBrush.TabStop = true;
            rb_SolidBrush.Text = "SolidBrush";
            rb_SolidBrush.UseVisualStyleBackColor = true;
            rb_SolidBrush.CheckedChanged += rb_SolidBrush_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(230, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(565, 441);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(gb_brushes);
            Controls.Add(gb_Pen);
            Controls.Add(gb_Shapes);
            Name = "Form1";
            Text = "Bai Thi";
            Load += Form1_Load;
            gb_Shapes.ResumeLayout(false);
            gb_Shapes.PerformLayout();
            gb_Pen.ResumeLayout(false);
            gb_Pen.PerformLayout();
            gb_brushes.ResumeLayout(false);
            gb_brushes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_Shapes;
        private RadioButton rb_Line;
        private RadioButton rb_Ellipse;
        private RadioButton rb_Rectangle;
        private GroupBox gb_Pen;
        private Label lb_width;
        private Button button1;
        private TextBox tb_width;
        private GroupBox gb_brushes;
        private RadioButton rb_LinearGradientBrush;
        private RadioButton rb_TextureBrush;
        private RadioButton rb_HatchBrush;
        private RadioButton rb_SolidBrush;
        private ColorDialog colorDialog1;
        private PictureBox pictureBox1;
    }
}
