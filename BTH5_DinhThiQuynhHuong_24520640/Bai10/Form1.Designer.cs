namespace Bai10
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
            lb_DashStyle = new Label();
            lb_Width = new Label();
            lb_LineJoin = new Label();
            lb_DashCap = new Label();
            lb_StartCap = new Label();
            lb_EndCap = new Label();
            cbb_DashStyle = new ComboBox();
            cbb_Width = new ComboBox();
            cbb_LineJoin = new ComboBox();
            cbb_DashCap = new ComboBox();
            cbb_StartCap = new ComboBox();
            cbb_EndCap = new ComboBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lb_DashStyle
            // 
            lb_DashStyle.AutoSize = true;
            lb_DashStyle.Location = new Point(18, 27);
            lb_DashStyle.Name = "lb_DashStyle";
            lb_DashStyle.Size = new Size(81, 20);
            lb_DashStyle.TabIndex = 0;
            lb_DashStyle.Text = "Dash Style:";
            // 
            // lb_Width
            // 
            lb_Width.AutoSize = true;
            lb_Width.Location = new Point(18, 74);
            lb_Width.Name = "lb_Width";
            lb_Width.Size = new Size(52, 20);
            lb_Width.TabIndex = 1;
            lb_Width.Text = "Width:";
            // 
            // lb_LineJoin
            // 
            lb_LineJoin.AutoSize = true;
            lb_LineJoin.Location = new Point(18, 120);
            lb_LineJoin.Name = "lb_LineJoin";
            lb_LineJoin.Size = new Size(69, 20);
            lb_LineJoin.TabIndex = 2;
            lb_LineJoin.Text = "Line Join:";
            // 
            // lb_DashCap
            // 
            lb_DashCap.AutoSize = true;
            lb_DashCap.Location = new Point(18, 168);
            lb_DashCap.Name = "lb_DashCap";
            lb_DashCap.Size = new Size(75, 20);
            lb_DashCap.TabIndex = 3;
            lb_DashCap.Text = "Dash Cap:";
            // 
            // lb_StartCap
            // 
            lb_StartCap.AutoSize = true;
            lb_StartCap.Location = new Point(18, 215);
            lb_StartCap.Name = "lb_StartCap";
            lb_StartCap.Size = new Size(73, 20);
            lb_StartCap.TabIndex = 4;
            lb_StartCap.Text = "Start Cap:";
            // 
            // lb_EndCap
            // 
            lb_EndCap.AutoSize = true;
            lb_EndCap.Location = new Point(18, 261);
            lb_EndCap.Name = "lb_EndCap";
            lb_EndCap.Size = new Size(67, 20);
            lb_EndCap.TabIndex = 5;
            lb_EndCap.Text = "End Cap:";
            // 
            // cbb_DashStyle
            // 
            cbb_DashStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_DashStyle.FormattingEnabled = true;
            cbb_DashStyle.Items.AddRange(new object[] { "Solid", "Dash", "Dot", "DashDot", "DashDotDot" });
            cbb_DashStyle.Location = new Point(125, 24);
            cbb_DashStyle.Name = "cbb_DashStyle";
            cbb_DashStyle.Size = new Size(151, 28);
            cbb_DashStyle.TabIndex = 6;
            cbb_DashStyle.SelectedIndexChanged += cbb_DashStyle_SelectedIndexChanged;
            // 
            // cbb_Width
            // 
            cbb_Width.FormattingEnabled = true;
            cbb_Width.Items.AddRange(new object[] { "0.5", "2", "3", "5", "7", "9", "10", "12" });
            cbb_Width.Location = new Point(125, 71);
            cbb_Width.Name = "cbb_Width";
            cbb_Width.Size = new Size(151, 28);
            cbb_Width.TabIndex = 7;
            cbb_Width.SelectedIndexChanged += cbb_Width_SelectedIndexChanged;
            cbb_Width.KeyDown += Cbb_Width_KeyDown;
            // 
            // cbb_LineJoin
            // 
            cbb_LineJoin.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_LineJoin.FormattingEnabled = true;
            cbb_LineJoin.Items.AddRange(new object[] { "Miter", "Bevel", "Round", "MiterClipped" });
            cbb_LineJoin.Location = new Point(125, 117);
            cbb_LineJoin.Name = "cbb_LineJoin";
            cbb_LineJoin.Size = new Size(151, 28);
            cbb_LineJoin.TabIndex = 8;
            cbb_LineJoin.SelectedIndexChanged += cbb_LineJoin_SelectedIndexChanged;
            // 
            // cbb_DashCap
            // 
            cbb_DashCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_DashCap.FormattingEnabled = true;
            cbb_DashCap.Items.AddRange(new object[] { "Flat", "Round", "Triangle" });
            cbb_DashCap.Location = new Point(125, 165);
            cbb_DashCap.Name = "cbb_DashCap";
            cbb_DashCap.Size = new Size(151, 28);
            cbb_DashCap.TabIndex = 9;
            cbb_DashCap.SelectedIndexChanged += cbb_DashCap_SelectedIndexChanged;
            // 
            // cbb_StartCap
            // 
            cbb_StartCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_StartCap.FormattingEnabled = true;
            cbb_StartCap.Items.AddRange(new object[] { "Flat", "Square", "Round", "Triangle", "ArrowAnchor", "RoundAnchor", "SquareAnchor", "DiamondAnchor", "NoAnchor" });
            cbb_StartCap.Location = new Point(125, 212);
            cbb_StartCap.Name = "cbb_StartCap";
            cbb_StartCap.Size = new Size(151, 28);
            cbb_StartCap.TabIndex = 10;
            cbb_StartCap.SelectedIndexChanged += cbb_StartCap_SelectedIndexChanged;
            // 
            // cbb_EndCap
            // 
            cbb_EndCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_EndCap.FormattingEnabled = true;
            cbb_EndCap.Items.AddRange(new object[] { "Flat", "Square", "Round", "Triangle", "ArrowAnchor", "RoundAnchor", "SquareAnchor", "DiamondAnchor", "NoAnchor" });
            cbb_EndCap.Location = new Point(125, 258);
            cbb_EndCap.Name = "cbb_EndCap";
            cbb_EndCap.Size = new Size(151, 28);
            cbb_EndCap.TabIndex = 11;
            cbb_EndCap.SelectedIndexChanged += cbb_EndCap_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(301, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 330);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(711, 335);
            Controls.Add(panel1);
            Controls.Add(cbb_EndCap);
            Controls.Add(cbb_StartCap);
            Controls.Add(cbb_DashCap);
            Controls.Add(cbb_LineJoin);
            Controls.Add(cbb_Width);
            Controls.Add(cbb_DashStyle);
            Controls.Add(lb_EndCap);
            Controls.Add(lb_StartCap);
            Controls.Add(lb_DashCap);
            Controls.Add(lb_LineJoin);
            Controls.Add(lb_Width);
            Controls.Add(lb_DashStyle);
            Name = "Form1";
            Text = "Pen Demo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label lb_DashStyle;
        private Label lb_Width;
        private Label lb_LineJoin;
        private Label lb_DashCap;
        private Label lb_StartCap;
        private Label lb_EndCap;
        private ComboBox cbb_DashStyle;
        private ComboBox cbb_Width;
        private ComboBox cbb_LineJoin;
        private ComboBox cbb_DashCap;
        private ComboBox cbb_StartCap;
        private ComboBox cbb_EndCap;
        private Panel panel1;
    }
}
