namespace Bai05
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
            ToolStripMenuItem_chucnang = new ToolStripMenuItem();
            ToolStripMenuItem_add = new ToolStripMenuItem();
            ToolStripMenuItem_exit = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton_add = new ToolStripButton();
            lb_find = new ToolStripLabel();
            toolStripTextBox1_find = new ToolStripTextBox();
            dataGridView1 = new DataGridView();
            Col_STT = new DataGridViewTextBoxColumn();
            Col_MSSV = new DataGridViewTextBoxColumn();
            Col_name = new DataGridViewTextBoxColumn();
            Col_khoa = new DataGridViewTextBoxColumn();
            Col_DTB = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem_chucnang });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_chucnang
            // 
            ToolStripMenuItem_chucnang.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_add, ToolStripMenuItem_exit });
            ToolStripMenuItem_chucnang.Name = "ToolStripMenuItem_chucnang";
            ToolStripMenuItem_chucnang.Size = new Size(93, 24);
            ToolStripMenuItem_chucnang.Text = "Chức năng";
            // 
            // ToolStripMenuItem_add
            // 
            ToolStripMenuItem_add.Name = "ToolStripMenuItem_add";
            ToolStripMenuItem_add.Size = new Size(159, 26);
            ToolStripMenuItem_add.Text = "Thêm mới";
            ToolStripMenuItem_add.Click += toolStripButton_add_Click;
            ToolStripMenuItem_add.ShortcutKeys = Keys.Control | Keys.N;
            ToolStripMenuItem_add.ShowShortcutKeys = true;
            // 
            // ToolStripMenuItem_exit
            // 
            ToolStripMenuItem_exit.Name = "ToolStripMenuItem_exit";
            ToolStripMenuItem_exit.Size = new Size(159, 26);
            ToolStripMenuItem_exit.Text = "Thoát";
            ToolStripMenuItem_exit.Click += ToolStripMenuItem_exit_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.ImageScalingSize = new Size(60, 60);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton_add, lb_find, toolStripTextBox1_find });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 68);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_add
            // 
            toolStripButton_add.AutoSize = false;
            toolStripButton_add.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripButton_add.Image = Properties.Resources.add;
            toolStripButton_add.ImageAlign = ContentAlignment.MiddleLeft;
            toolStripButton_add.ImageTransparentColor = Color.Magenta;
            toolStripButton_add.Name = "toolStripButton_add";
            toolStripButton_add.RightToLeft = RightToLeft.No;
            toolStripButton_add.Size = new Size(300, 65);
            toolStripButton_add.Text = "Thêm Mới";
            toolStripButton_add.Click += toolStripButton_add_Click;
            // 
            // lb_find
            // 
            lb_find.Font = new Font("Segoe UI", 12F);
            lb_find.Name = "lb_find";
            lb_find.Size = new Size(175, 65);
            lb_find.Text = "Tìm Kiếm Theo Tên";
            // 
            // toolStripTextBox1_find
            // 
            toolStripTextBox1_find.Name = "toolStripTextBox1_find";
            toolStripTextBox1_find.Size = new Size(290, 68);
            toolStripTextBox1_find.TextChanged += ToolStripTextBox1_find_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Col_STT, Col_MSSV, Col_name, Col_khoa, Col_DTB });
            dataGridView1.Location = new Point(0, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 353);
            dataGridView1.TabIndex = 2;
            // 
            // Col_STT
            // 
            Col_STT.HeaderText = "Số TT";
            Col_STT.MinimumWidth = 6;
            Col_STT.Name = "Col_STT";
            Col_STT.ReadOnly = true;
            Col_STT.Width = 60;
            // 
            // Col_MSSV
            // 
            Col_MSSV.HeaderText = "Mã Số SV";
            Col_MSSV.MinimumWidth = 6;
            Col_MSSV.Name = "Col_MSSV";
            Col_MSSV.ReadOnly = true;
            Col_MSSV.Width = 155;
            // 
            // Col_name
            // 
            Col_name.HeaderText = "Tên Sinh Viên";
            Col_name.MinimumWidth = 6;
            Col_name.Name = "Col_name";
            Col_name.ReadOnly = true;
            Col_name.Width = 250;
            // 
            // Col_khoa
            // 
            Col_khoa.HeaderText = "Khoa";
            Col_khoa.MinimumWidth = 6;
            Col_khoa.Name = "Col_khoa";
            Col_khoa.ReadOnly = true;
            Col_khoa.Width = 200;
            // 
            // Col_DTB
            // 
            Col_DTB.HeaderText = "Điểm TB";
            Col_DTB.MinimumWidth = 6;
            Col_DTB.Name = "Col_DTB";
            Col_DTB.ReadOnly = true;
            Col_DTB.Width = 80;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Quản lí sinh viên";
            KeyDown += Form1_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuItem_chucnang;
        private ToolStripMenuItem ToolStripMenuItem_add;
        private ToolStripMenuItem ToolStripMenuItem_exit;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton_add;
        private ToolStripLabel lb_find;
        private ToolStripTextBox toolStripTextBox1_find;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Col_STT;
        private DataGridViewTextBoxColumn Col_MSSV;
        private DataGridViewTextBoxColumn Col_name;
        private DataGridViewTextBoxColumn Col_khoa;
        private DataGridViewTextBoxColumn Col_DTB;
    }
}
