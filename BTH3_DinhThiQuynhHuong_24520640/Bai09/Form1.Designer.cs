namespace Bai09
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
            ListViewItem listViewItem1 = new ListViewItem("Cơ sở dữ liệu");
            ListViewItem listViewItem2 = new ListViewItem("Cơ sở DL NC");
            ListViewItem listViewItem3 = new ListViewItem("PTTK Hệ thống thông tin");
            ListViewItem listViewItem4 = new ListViewItem("Nhập môn lập trình");
            ListViewItem listViewItem5 = new ListViewItem("Lập trình trực quan");
            ListViewItem listViewItem6 = new ListViewItem("Lập trình hướng đối tượng");
            ListViewItem listViewItem7 = new ListViewItem("Mạng máy tính");
            panel1 = new Panel();
            btn_xoa = new Button();
            btn_luu = new Button();
            btn_cancelMH = new Button();
            btn_addMH = new Button();
            lv_listMHDK = new ListView();
            lv_listMH = new ListView();
            cb_nganh = new ComboBox();
            tb_ten = new TextBox();
            tb_masv = new TextBox();
            cb_nu = new CheckBox();
            cb_nam = new CheckBox();
            lb_MH = new Label();
            lb_GT = new Label();
            lb_nganh = new Label();
            lb_ten = new Label();
            lb_masv = new Label();
            lb_TTSV = new Label();
            dataGridView1 = new DataGridView();
            col_mssv = new DataGridViewTextBoxColumn();
            col_hoten = new DataGridViewTextBoxColumn();
            col_nganh = new DataGridViewTextBoxColumn();
            col_GT = new DataGridViewTextBoxColumn();
            col_SLmon = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_xoa);
            panel1.Controls.Add(btn_luu);
            panel1.Controls.Add(btn_cancelMH);
            panel1.Controls.Add(btn_addMH);
            panel1.Controls.Add(lv_listMHDK);
            panel1.Controls.Add(lv_listMH);
            panel1.Controls.Add(cb_nganh);
            panel1.Controls.Add(tb_ten);
            panel1.Controls.Add(tb_masv);
            panel1.Controls.Add(cb_nu);
            panel1.Controls.Add(cb_nam);
            panel1.Controls.Add(lb_MH);
            panel1.Controls.Add(lb_GT);
            panel1.Controls.Add(lb_nganh);
            panel1.Controls.Add(lb_ten);
            panel1.Controls.Add(lb_masv);
            panel1.Location = new Point(30, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(859, 334);
            panel1.TabIndex = 0;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(411, 289);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 15;
            btn_xoa.Text = "Xóa chọn";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_luu
            // 
            btn_luu.Location = new Point(284, 289);
            btn_luu.Name = "btn_luu";
            btn_luu.Size = new Size(121, 29);
            btn_luu.TabIndex = 14;
            btn_luu.Text = "Lưu thông tin";
            btn_luu.UseVisualStyleBackColor = true;
            btn_luu.Click += btn_luu_Click;
            // 
            // btn_cancelMH
            // 
            btn_cancelMH.Font = new Font("Segoe UI", 11F);
            btn_cancelMH.Location = new Point(405, 223);
            btn_cancelMH.Name = "btn_cancelMH";
            btn_cancelMH.Size = new Size(49, 43);
            btn_cancelMH.TabIndex = 13;
            btn_cancelMH.Text = "<";
            btn_cancelMH.UseVisualStyleBackColor = true;
            btn_cancelMH.Click += btn_cancelMH_Click;
            // 
            // btn_addMH
            // 
            btn_addMH.Font = new Font("Segoe UI", 11F);
            btn_addMH.Location = new Point(405, 174);
            btn_addMH.Name = "btn_addMH";
            btn_addMH.Size = new Size(49, 43);
            btn_addMH.TabIndex = 12;
            btn_addMH.Text = ">";
            btn_addMH.UseVisualStyleBackColor = true;
            btn_addMH.Click += btn_addMH_Click;
            // 
            // lv_listMHDK
            // 
            lv_listMHDK.FullRowSelect = true;
            lv_listMHDK.Location = new Point(460, 162);
            lv_listMHDK.Name = "lv_listMHDK";
            lv_listMHDK.Size = new Size(221, 121);
            lv_listMHDK.TabIndex = 11;
            lv_listMHDK.UseCompatibleStateImageBehavior = false;
            lv_listMHDK.View = View.SmallIcon;
            // 
            // lv_listMH
            // 
            lv_listMH.FullRowSelect = true;
            lv_listMH.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7 });
            lv_listMH.Location = new Point(179, 162);
            lv_listMH.Name = "lv_listMH";
            lv_listMH.Size = new Size(220, 121);
            lv_listMH.TabIndex = 10;
            lv_listMH.UseCompatibleStateImageBehavior = false;
            lv_listMH.View = View.SmallIcon;
            // 
            // cb_nganh
            // 
            cb_nganh.FormattingEnabled = true;
            cb_nganh.Items.AddRange(new object[] { "Hệ thống thông tin", "Thương mại điện tử", "Khoa học máy tính", "Kỹ thuật phần mềm", "Kỹ thuật máy tính", "Mạng máy tính và truyền thông dữ liệu", "An toàn thông tin", "Khoa học dữ liệu", "Truyền thông đa phương tiện" });
            cb_nganh.Location = new Point(280, 70);
            cb_nganh.Name = "cb_nganh";
            cb_nganh.Size = new Size(245, 28);
            cb_nganh.TabIndex = 9;
            // 
            // tb_ten
            // 
            tb_ten.Location = new Point(280, 41);
            tb_ten.Name = "tb_ten";
            tb_ten.Size = new Size(245, 27);
            tb_ten.TabIndex = 8;
            // 
            // tb_masv
            // 
            tb_masv.Location = new Point(280, 11);
            tb_masv.Name = "tb_masv";
            tb_masv.Size = new Size(125, 27);
            tb_masv.TabIndex = 7;
            // 
            // cb_nu
            // 
            cb_nu.AutoSize = true;
            cb_nu.Location = new Point(354, 101);
            cb_nu.Name = "cb_nu";
            cb_nu.Size = new Size(51, 24);
            cb_nu.TabIndex = 6;
            cb_nu.Text = "Nữ";
            cb_nu.UseVisualStyleBackColor = true;
            // 
            // cb_nam
            // 
            cb_nam.AutoSize = true;
            cb_nam.Location = new Point(285, 101);
            cb_nam.Name = "cb_nam";
            cb_nam.Size = new Size(63, 24);
            cb_nam.TabIndex = 5;
            cb_nam.Text = "Nam";
            cb_nam.UseVisualStyleBackColor = true;
            // 
            // lb_MH
            // 
            lb_MH.AutoSize = true;
            lb_MH.Location = new Point(176, 131);
            lb_MH.Name = "lb_MH";
            lb_MH.Size = new Size(194, 20);
            lb_MH.TabIndex = 4;
            lb_MH.Text = "Chọn các môn học tham gia";
            // 
            // lb_GT
            // 
            lb_GT.AutoSize = true;
            lb_GT.Location = new Point(176, 102);
            lb_GT.Name = "lb_GT";
            lb_GT.Size = new Size(65, 20);
            lb_GT.TabIndex = 3;
            lb_GT.Text = "Giới tính";
            // 
            // lb_nganh
            // 
            lb_nganh.AutoSize = true;
            lb_nganh.Location = new Point(176, 73);
            lb_nganh.Name = "lb_nganh";
            lb_nganh.Size = new Size(102, 20);
            lb_nganh.TabIndex = 2;
            lb_nganh.Text = "Chuyên ngành";
            // 
            // lb_ten
            // 
            lb_ten.AutoSize = true;
            lb_ten.Location = new Point(176, 44);
            lb_ten.Name = "lb_ten";
            lb_ten.Size = new Size(54, 20);
            lb_ten.TabIndex = 1;
            lb_ten.Text = "Họ tên";
            // 
            // lb_masv
            // 
            lb_masv.AutoSize = true;
            lb_masv.Location = new Point(176, 14);
            lb_masv.Name = "lb_masv";
            lb_masv.Size = new Size(91, 20);
            lb_masv.TabIndex = 0;
            lb_masv.Text = "Mã sinh viên";
            // 
            // lb_TTSV
            // 
            lb_TTSV.AutoSize = true;
            lb_TTSV.Font = new Font("Segoe UI", 11F);
            lb_TTSV.Location = new Point(49, 9);
            lb_TTSV.Name = "lb_TTSV";
            lb_TTSV.Size = new Size(173, 25);
            lb_TTSV.TabIndex = 0;
            lb_TTSV.Text = "Thông tin sinh viên";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { col_mssv, col_hoten, col_nganh, col_GT, col_SLmon });
            dataGridView1.Location = new Point(30, 362);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(859, 225);
            dataGridView1.TabIndex = 1;
            // 
            // col_mssv
            // 
            col_mssv.HeaderText = "MSSV";
            col_mssv.MinimumWidth = 6;
            col_mssv.Name = "col_mssv";
            col_mssv.ReadOnly = true;
            col_mssv.Width = 150;
            // 
            // col_hoten
            // 
            col_hoten.HeaderText = "Họ tên";
            col_hoten.MinimumWidth = 6;
            col_hoten.Name = "col_hoten";
            col_hoten.ReadOnly = true;
            col_hoten.Width = 220;
            // 
            // col_nganh
            // 
            col_nganh.HeaderText = "Chuyên ngành";
            col_nganh.MinimumWidth = 6;
            col_nganh.Name = "col_nganh";
            col_nganh.ReadOnly = true;
            col_nganh.Width = 240;
            // 
            // col_GT
            // 
            col_GT.HeaderText = "Giới tính";
            col_GT.MinimumWidth = 6;
            col_GT.Name = "col_GT";
            col_GT.ReadOnly = true;
            col_GT.Width = 125;
            // 
            // col_SLmon
            // 
            col_SLmon.HeaderText = "Số môn";
            col_SLmon.MinimumWidth = 6;
            col_SLmon.Name = "col_SLmon";
            col_SLmon.ReadOnly = true;
            col_SLmon.Width = 70;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 599);
            Controls.Add(dataGridView1);
            Controls.Add(lb_TTSV);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Nhập thông tin sinh viên";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lb_TTSV;
        private CheckBox cb_nu;
        private CheckBox cb_nam;
        private Label lb_MH;
        private Label lb_GT;
        private Label lb_nganh;
        private Label lb_ten;
        private Label lb_masv;
        private ComboBox cb_nganh;
        private TextBox tb_ten;
        private TextBox tb_masv;
        private Button btn_cancelMH;
        private Button btn_addMH;
        private ListView lv_listMHDK;
        private ListView lv_listMH;
        private DataGridView dataGridView1;
        private Button btn_xoa;
        private Button btn_luu;
        private DataGridViewTextBoxColumn col_mssv;
        private DataGridViewTextBoxColumn col_hoten;
        private DataGridViewTextBoxColumn col_nganh;
        private DataGridViewTextBoxColumn col_GT;
        private DataGridViewTextBoxColumn col_SLmon;
    }
}
