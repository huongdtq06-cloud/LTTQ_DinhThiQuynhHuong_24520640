using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form_add : Form
    {
        private Form1 main_form;
        public Form_add(Form1 main_form)
        {
            this.main_form = main_form;
            InitializeComponent();
            cb_khoa.SelectedIndex = 0;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tb_mssv.Text) || string.IsNullOrEmpty(tb_name.Text) || string.IsNullOrEmpty (tb_diem.Text)) {
                lb_thongbao.ForeColor = Color.Red;
                lb_thongbao.Text = "Vui lòng nhập đầy đủ thông tin.";
            }
            else if(float.Parse(tb_diem.Text)>10 || float.Parse(tb_diem.Text)<0) {
                lb_thongbao.ForeColor= Color.Red;
                lb_thongbao.Text = "Điểm TB không hợp lệ.";
            }
            else {
                main_form.AddStudent(tb_mssv.Text, tb_name.Text, cb_khoa.Text, tb_diem.Text);
                Close();
            }
            
        }
    }
}
