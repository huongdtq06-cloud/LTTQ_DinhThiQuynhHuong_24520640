namespace Bai05
{
    partial class Form_add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_Mssv = new Label();
            lb_ten = new Label();
            lb_Khoa = new Label();
            lb_diem = new Label();
            btn_add = new Button();
            btn_close = new Button();
            tb_mssv = new TextBox();
            tb_name = new TextBox();
            cb_khoa = new ComboBox();
            tb_diem = new TextBox();
            lb_thongbao = new Label();
            SuspendLayout();
            // 
            // lb_Mssv
            // 
            lb_Mssv.AutoSize = true;
            lb_Mssv.Location = new Point(29, 30);
            lb_Mssv.Name = "lb_Mssv";
            lb_Mssv.Size = new Size(116, 20);
            lb_Mssv.TabIndex = 0;
            lb_Mssv.Text = "Mã Số Sinh Viên";
            // 
            // lb_ten
            // 
            lb_ten.AutoSize = true;
            lb_ten.Location = new Point(29, 70);
            lb_ten.Name = "lb_ten";
            lb_ten.Size = new Size(97, 20);
            lb_ten.TabIndex = 1;
            lb_ten.Text = "Tên Sinh Viên";
            // 
            // lb_Khoa
            // 
            lb_Khoa.AutoSize = true;
            lb_Khoa.Location = new Point(29, 110);
            lb_Khoa.Name = "lb_Khoa";
            lb_Khoa.Size = new Size(43, 20);
            lb_Khoa.TabIndex = 2;
            lb_Khoa.Text = "Khoa";
            // 
            // lb_diem
            // 
            lb_diem.AutoSize = true;
            lb_diem.Location = new Point(29, 147);
            lb_diem.Name = "lb_diem";
            lb_diem.Size = new Size(66, 20);
            lb_diem.TabIndex = 3;
            lb_diem.Text = "Điểm TB";
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(0, 192, 0);
            btn_add.FlatStyle = FlatStyle.Popup;
            btn_add.Location = new Point(305, 218);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 4;
            btn_add.Text = "Thêm Mới";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.FromArgb(255, 128, 0);
            btn_close.FlatStyle = FlatStyle.Popup;
            btn_close.Location = new Point(405, 218);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(94, 29);
            btn_close.TabIndex = 5;
            btn_close.Text = "Thoát";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // tb_mssv
            // 
            tb_mssv.Location = new Point(163, 27);
            tb_mssv.Name = "tb_mssv";
            tb_mssv.Size = new Size(263, 27);
            tb_mssv.TabIndex = 6;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(163, 67);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(321, 27);
            tb_name.TabIndex = 7;
            // 
            // cb_khoa
            // 
            cb_khoa.FormattingEnabled = true;
            cb_khoa.Items.AddRange(new object[] { "Khoa Học Máy Tính", "Công Nghệ Phần Mềm", "Khoa Học Và Kỹ Thuật Thông Tin", "Kỹ Thuật Máy Tính", "Hệ Thống Thông Tin", "Mạng Máy Tính Và Truyền Thông" });
            cb_khoa.Location = new Point(163, 107);
            cb_khoa.Name = "cb_khoa";
            cb_khoa.Size = new Size(321, 28);
            cb_khoa.TabIndex = 8;
            // 
            // tb_diem
            // 
            tb_diem.Location = new Point(163, 144);
            tb_diem.Name = "tb_diem";
            tb_diem.Size = new Size(125, 27);
            tb_diem.TabIndex = 9;
            // 
            // lb_thongbao
            // 
            lb_thongbao.AutoSize = true;
            lb_thongbao.Location = new Point(29, 194);
            lb_thongbao.Name = "lb_thongbao";
            lb_thongbao.Size = new Size(0, 20);
            lb_thongbao.TabIndex = 10;
            // 
            // Form_add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 277);
            Controls.Add(lb_thongbao);
            Controls.Add(tb_diem);
            Controls.Add(cb_khoa);
            Controls.Add(tb_name);
            Controls.Add(tb_mssv);
            Controls.Add(btn_close);
            Controls.Add(btn_add);
            Controls.Add(lb_diem);
            Controls.Add(lb_Khoa);
            Controls.Add(lb_ten);
            Controls.Add(lb_Mssv);
            Name = "Form_add";
            Text = "Thêm Sinh Viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Mssv;
        private Label lb_ten;
        private Label lb_Khoa;
        private Label lb_diem;
        private Button btn_add;
        private Button btn_close;
        private TextBox tb_mssv;
        private TextBox tb_name;
        private ComboBox cb_khoa;
        private TextBox tb_diem;
        private Label lb_thongbao;
    }
}