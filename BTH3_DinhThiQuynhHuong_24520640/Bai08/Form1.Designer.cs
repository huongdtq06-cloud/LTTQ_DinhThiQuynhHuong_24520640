namespace Bai08
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
            lb_qltttk = new Label();
            lb_stk = new Label();
            lb_tenKH = new Label();
            lb_diachiKH = new Label();
            lb_sotien = new Label();
            tb_stk = new TextBox();
            tb_sotien = new TextBox();
            tb_diachiKH = new TextBox();
            tb_tenKH = new TextBox();
            btn_add = new Button();
            btn_xoa = new Button();
            btn_thoat = new Button();
            listView1 = new ListView();
            STT = new ColumnHeader();
            stk = new ColumnHeader();
            ten = new ColumnHeader();
            diachi = new ColumnHeader();
            sotien = new ColumnHeader();
            lb_thongbao = new Label();
            SuspendLayout();
            // 
            // lb_qltttk
            // 
            lb_qltttk.AutoSize = true;
            lb_qltttk.Font = new Font("Segoe UI", 30F);
            lb_qltttk.ForeColor = Color.Blue;
            lb_qltttk.Location = new Point(12, -2);
            lb_qltttk.Name = "lb_qltttk";
            lb_qltttk.Size = new Size(764, 67);
            lb_qltttk.TabIndex = 0;
            lb_qltttk.Text = "QUẢN LÍ THÔNG TIN TÀI KHOẢN";
            // 
            // lb_stk
            // 
            lb_stk.AutoSize = true;
            lb_stk.Location = new Point(149, 65);
            lb_stk.Name = "lb_stk";
            lb_stk.Size = new Size(91, 20);
            lb_stk.TabIndex = 1;
            lb_stk.Text = "Số tài khoản";
            // 
            // lb_tenKH
            // 
            lb_tenKH.AutoSize = true;
            lb_tenKH.Location = new Point(129, 95);
            lb_tenKH.Name = "lb_tenKH";
            lb_tenKH.Size = new Size(111, 20);
            lb_tenKH.TabIndex = 2;
            lb_tenKH.Text = "Tên khách hàng";
            // 
            // lb_diachiKH
            // 
            lb_diachiKH.AutoSize = true;
            lb_diachiKH.Location = new Point(106, 124);
            lb_diachiKH.Name = "lb_diachiKH";
            lb_diachiKH.Size = new Size(134, 20);
            lb_diachiKH.TabIndex = 3;
            lb_diachiKH.Text = "Địa chỉ khách hàng";
            // 
            // lb_sotien
            // 
            lb_sotien.AutoSize = true;
            lb_sotien.Location = new Point(80, 156);
            lb_sotien.Name = "lb_sotien";
            lb_sotien.Size = new Size(160, 20);
            lb_sotien.TabIndex = 4;
            lb_sotien.Text = "Số tiền trong tài khoản";
            // 
            // tb_stk
            // 
            tb_stk.Location = new Point(246, 62);
            tb_stk.Name = "tb_stk";
            tb_stk.ShortcutsEnabled = false;
            tb_stk.Size = new Size(462, 27);
            tb_stk.TabIndex = 1;
            // 
            // tb_sotien
            // 
            tb_sotien.Location = new Point(246, 153);
            tb_sotien.Name = "tb_sotien";
            tb_sotien.Size = new Size(462, 27);
            tb_sotien.TabIndex = 4;
            // 
            // tb_diachiKH
            // 
            tb_diachiKH.Location = new Point(246, 121);
            tb_diachiKH.Name = "tb_diachiKH";
            tb_diachiKH.Size = new Size(462, 27);
            tb_diachiKH.TabIndex = 3;
            tb_diachiKH.TextChanged += tb_diachiKH_TextChanged;
            // 
            // tb_tenKH
            // 
            tb_tenKH.Location = new Point(246, 92);
            tb_tenKH.Name = "tb_tenKH";
            tb_tenKH.Size = new Size(462, 27);
            tb_tenKH.TabIndex = 2;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(362, 186);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(134, 29);
            btn_add.TabIndex = 9;
            btn_add.Text = "Thêm/Cập nhật";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(502, 186);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 10;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Location = new Point(602, 186);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(94, 29);
            btn_thoat.TabIndex = 11;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { STT, stk, ten, diachi, sotien });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 243);
            listView1.Name = "listView1";
            listView1.Size = new Size(774, 253);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // STT
            // 
            STT.Tag = "";
            STT.Text = "STT";
            STT.Width = 45;
            // 
            // stk
            // 
            stk.Text = "Số tài khoản";
            stk.Width = 140;
            // 
            // ten
            // 
            ten.Text = "Tên khách hàng";
            ten.Width = 225;
            // 
            // diachi
            // 
            diachi.Text = "Địa chỉ";
            diachi.Width = 225;
            // 
            // sotien
            // 
            sotien.Text = "Số tiền";
            sotien.Width = 130;
            // 
            // lb_thongbao
            // 
            lb_thongbao.AutoSize = true;
            lb_thongbao.Location = new Point(63, 220);
            lb_thongbao.Name = "lb_thongbao";
            lb_thongbao.Size = new Size(0, 20);
            lb_thongbao.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 508);
            Controls.Add(lb_thongbao);
            Controls.Add(listView1);
            Controls.Add(btn_thoat);
            Controls.Add(btn_xoa);
            Controls.Add(btn_add);
            Controls.Add(tb_tenKH);
            Controls.Add(tb_diachiKH);
            Controls.Add(tb_sotien);
            Controls.Add(tb_stk);
            Controls.Add(lb_sotien);
            Controls.Add(lb_diachiKH);
            Controls.Add(lb_tenKH);
            Controls.Add(lb_stk);
            Controls.Add(lb_qltttk);
            Name = "Form1";
            Text = "Quản lí thông tin tài khoản";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_qltttk;
        private Label lb_stk;
        private Label lb_tenKH;
        private Label lb_diachiKH;
        private Label lb_sotien;
        private TextBox tb_stk;
        private TextBox tb_sotien;
        private TextBox tb_diachiKH;
        private TextBox tb_tenKH;
        private Button btn_add;
        private Button btn_xoa;
        private Button btn_thoat;
        private ListView listView1;
        private ColumnHeader STT;
        private ColumnHeader stk;
        private ColumnHeader ten;
        private ColumnHeader diachi;
        private ColumnHeader sotien;
        private Label lb_thongbao;
    }
}
