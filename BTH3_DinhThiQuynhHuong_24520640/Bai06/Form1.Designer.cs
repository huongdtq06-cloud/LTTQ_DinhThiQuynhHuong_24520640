namespace Bai06
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
            menuStrip1 = new MenuStrip();
            editeToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            btn_MC = new Button();
            btn_MR = new Button();
            btn_MS = new Button();
            btn_Mp = new Button();
            textBox1 = new TextBox();
            btn_Backspace = new Button();
            btn_CE = new Button();
            btn_C = new Button();
            btn_0 = new Button();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_4 = new Button();
            btn_5 = new Button();
            btn_6 = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_sign = new Button();
            btn_dot = new Button();
            btn_equals = new Button();
            btn_plus = new Button();
            btn_sqrt = new Button();
            btn_divide = new Button();
            btn_percent = new Button();
            btn_multiply = new Button();
            btn_reciprocal = new Button();
            btn_minus = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editeToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(354, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // editeToolStripMenuItem
            // 
            editeToolStripMenuItem.Name = "editeToolStripMenuItem";
            editeToolStripMenuItem.Size = new Size(49, 24);
            editeToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // btn_MC
            // 
            btn_MC.ForeColor = Color.Red;
            btn_MC.Location = new Point(12, 131);
            btn_MC.Name = "btn_MC";
            btn_MC.Size = new Size(50, 40);
            btn_MC.TabIndex = 1;
            btn_MC.Text = "MC";
            btn_MC.UseVisualStyleBackColor = true;
            btn_MC.Click += btn_MC_Click;
            // 
            // btn_MR
            // 
            btn_MR.ForeColor = Color.Red;
            btn_MR.Location = new Point(12, 177);
            btn_MR.Name = "btn_MR";
            btn_MR.Size = new Size(50, 40);
            btn_MR.TabIndex = 2;
            btn_MR.Text = "MR";
            btn_MR.UseVisualStyleBackColor = true;
            btn_MR.Click += btn_MR_Click;
            // 
            // btn_MS
            // 
            btn_MS.ForeColor = Color.Red;
            btn_MS.Location = new Point(12, 223);
            btn_MS.Name = "btn_MS";
            btn_MS.Size = new Size(50, 40);
            btn_MS.TabIndex = 3;
            btn_MS.Text = "MS";
            btn_MS.UseVisualStyleBackColor = true;
            btn_MS.Click += btn_MS_Click;
            // 
            // btn_Mp
            // 
            btn_Mp.ForeColor = Color.Red;
            btn_Mp.Location = new Point(12, 269);
            btn_Mp.Name = "btn_Mp";
            btn_Mp.Size = new Size(50, 40);
            btn_Mp.TabIndex = 4;
            btn_Mp.Text = "M+";
            btn_Mp.UseVisualStyleBackColor = true;
            btn_Mp.Click += btn_Mp_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 34);
            textBox1.TabIndex = 5;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // btn_Backspace
            // 
            btn_Backspace.ForeColor = Color.Red;
            btn_Backspace.Location = new Point(68, 84);
            btn_Backspace.Name = "btn_Backspace";
            btn_Backspace.Size = new Size(94, 40);
            btn_Backspace.TabIndex = 6;
            btn_Backspace.Text = "Backspace";
            btn_Backspace.UseVisualStyleBackColor = true;
            btn_Backspace.Click += btn_Backspace_Click;
            // 
            // btn_CE
            // 
            btn_CE.ForeColor = Color.Red;
            btn_CE.Location = new Point(168, 84);
            btn_CE.Name = "btn_CE";
            btn_CE.Size = new Size(86, 40);
            btn_CE.TabIndex = 7;
            btn_CE.Text = "CE";
            btn_CE.UseVisualStyleBackColor = true;
            btn_CE.Click += btn_CE_Click;
            // 
            // btn_C
            // 
            btn_C.ForeColor = Color.Red;
            btn_C.Location = new Point(260, 84);
            btn_C.Name = "btn_C";
            btn_C.Size = new Size(82, 40);
            btn_C.TabIndex = 8;
            btn_C.Text = "C";
            btn_C.UseVisualStyleBackColor = true;
            btn_C.Click += btn_C_Click;
            // 
            // btn_0
            // 
            btn_0.ForeColor = Color.Blue;
            btn_0.Location = new Point(68, 269);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(50, 40);
            btn_0.TabIndex = 9;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_0_Click;
            // 
            // btn_1
            // 
            btn_1.ForeColor = Color.Blue;
            btn_1.Location = new Point(68, 223);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(50, 40);
            btn_1.TabIndex = 10;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_1_Click;
            // 
            // btn_2
            // 
            btn_2.ForeColor = Color.Blue;
            btn_2.Location = new Point(124, 223);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(50, 40);
            btn_2.TabIndex = 11;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_2_Click;
            // 
            // btn_3
            // 
            btn_3.ForeColor = Color.Blue;
            btn_3.Location = new Point(180, 223);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(50, 40);
            btn_3.TabIndex = 12;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_3_Click;
            // 
            // btn_4
            // 
            btn_4.ForeColor = Color.Blue;
            btn_4.Location = new Point(68, 177);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(50, 40);
            btn_4.TabIndex = 13;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_4_Click;
            // 
            // btn_5
            // 
            btn_5.ForeColor = Color.Blue;
            btn_5.Location = new Point(124, 177);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(50, 40);
            btn_5.TabIndex = 14;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_5_Click;
            // 
            // btn_6
            // 
            btn_6.ForeColor = Color.Blue;
            btn_6.Location = new Point(180, 177);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(50, 40);
            btn_6.TabIndex = 15;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_6_Click;
            // 
            // btn_9
            // 
            btn_9.ForeColor = Color.Blue;
            btn_9.Location = new Point(180, 131);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(50, 40);
            btn_9.TabIndex = 18;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_9_Click;
            // 
            // btn_8
            // 
            btn_8.ForeColor = Color.Blue;
            btn_8.Location = new Point(124, 131);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(50, 40);
            btn_8.TabIndex = 17;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_8_Click;
            // 
            // btn_7
            // 
            btn_7.ForeColor = Color.Blue;
            btn_7.Location = new Point(68, 131);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(50, 40);
            btn_7.TabIndex = 16;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_7_Click;
            // 
            // btn_sign
            // 
            btn_sign.ForeColor = Color.Blue;
            btn_sign.Location = new Point(124, 269);
            btn_sign.Name = "btn_sign";
            btn_sign.Size = new Size(50, 40);
            btn_sign.TabIndex = 19;
            btn_sign.Text = "+/-";
            btn_sign.UseVisualStyleBackColor = true;
            btn_sign.Click += btn_sign_Click;
            // 
            // btn_dot
            // 
            btn_dot.ForeColor = Color.Blue;
            btn_dot.Location = new Point(180, 269);
            btn_dot.Name = "btn_dot";
            btn_dot.Size = new Size(50, 40);
            btn_dot.TabIndex = 20;
            btn_dot.Text = ".";
            btn_dot.UseVisualStyleBackColor = true;
            btn_dot.Click += btn_dot_Click;
            // 
            // btn_equals
            // 
            btn_equals.ForeColor = Color.Red;
            btn_equals.Location = new Point(292, 269);
            btn_equals.Name = "btn_equals";
            btn_equals.Size = new Size(50, 40);
            btn_equals.TabIndex = 28;
            btn_equals.Text = "=";
            btn_equals.UseVisualStyleBackColor = true;
            btn_equals.Click += btn_equals_Click;
            // 
            // btn_plus
            // 
            btn_plus.ForeColor = Color.Red;
            btn_plus.Location = new Point(236, 269);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(50, 40);
            btn_plus.TabIndex = 27;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = true;
            btn_plus.Click += btn_plus_Click;
            // 
            // btn_sqrt
            // 
            btn_sqrt.ForeColor = Color.Blue;
            btn_sqrt.Location = new Point(292, 131);
            btn_sqrt.Name = "btn_sqrt";
            btn_sqrt.Size = new Size(50, 40);
            btn_sqrt.TabIndex = 26;
            btn_sqrt.Text = "sqrt";
            btn_sqrt.UseVisualStyleBackColor = true;
            btn_sqrt.Click += btn_sqrt_Click;
            // 
            // btn_divide
            // 
            btn_divide.ForeColor = Color.Red;
            btn_divide.Location = new Point(236, 131);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(50, 40);
            btn_divide.TabIndex = 25;
            btn_divide.Text = "/";
            btn_divide.UseVisualStyleBackColor = true;
            btn_divide.Click += btn_divide_Click;
            // 
            // btn_percent
            // 
            btn_percent.ForeColor = Color.Blue;
            btn_percent.Location = new Point(292, 177);
            btn_percent.Name = "btn_percent";
            btn_percent.Size = new Size(50, 40);
            btn_percent.TabIndex = 24;
            btn_percent.Text = "%";
            btn_percent.UseVisualStyleBackColor = true;
            btn_percent.Click += btn_percent_Click;
            // 
            // btn_multiply
            // 
            btn_multiply.ForeColor = Color.Red;
            btn_multiply.Location = new Point(236, 177);
            btn_multiply.Name = "btn_multiply";
            btn_multiply.Size = new Size(50, 40);
            btn_multiply.TabIndex = 23;
            btn_multiply.Text = "*";
            btn_multiply.UseVisualStyleBackColor = true;
            btn_multiply.Click += btn_multiply_Click;
            // 
            // btn_reciprocal
            // 
            btn_reciprocal.ForeColor = Color.Blue;
            btn_reciprocal.Location = new Point(292, 223);
            btn_reciprocal.Name = "btn_reciprocal";
            btn_reciprocal.Size = new Size(50, 40);
            btn_reciprocal.TabIndex = 22;
            btn_reciprocal.Text = "1/x";
            btn_reciprocal.UseVisualStyleBackColor = true;
            btn_reciprocal.Click += btn_reciprocal_Click;
            // 
            // btn_minus
            // 
            btn_minus.ForeColor = Color.Red;
            btn_minus.Location = new Point(236, 223);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(50, 40);
            btn_minus.TabIndex = 21;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = true;
            btn_minus.Click += btn_minus_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 331);
            Controls.Add(btn_equals);
            Controls.Add(btn_plus);
            Controls.Add(btn_sqrt);
            Controls.Add(btn_divide);
            Controls.Add(btn_percent);
            Controls.Add(btn_multiply);
            Controls.Add(btn_reciprocal);
            Controls.Add(btn_minus);
            Controls.Add(btn_dot);
            Controls.Add(btn_sign);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(btn_0);
            Controls.Add(btn_C);
            Controls.Add(btn_CE);
            Controls.Add(btn_Backspace);
            Controls.Add(textBox1);
            Controls.Add(btn_Mp);
            Controls.Add(btn_MS);
            Controls.Add(btn_MR);
            Controls.Add(btn_MC);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Calculator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem editeToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Button btn_MC;
        private Button btn_MR;
        private Button btn_MS;
        private Button btn_Mp;
        private TextBox textBox1;
        private Button btn_Backspace;
        private Button btn_CE;
        private Button btn_C;
        private Button btn_0;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_sign;
        private Button btn_dot;
        private Button btn_equals;
        private Button btn_plus;
        private Button btn_sqrt;
        private Button btn_divide;
        private Button btn_percent;
        private Button btn_multiply;
        private Button btn_reciprocal;
        private Button btn_minus;
    }
}
