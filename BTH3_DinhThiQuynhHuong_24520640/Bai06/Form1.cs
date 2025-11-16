using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double m = 0;
        double num1;
        double num2;
        double ans;
        bool negative = false;
        string Operator = null;
        bool equal = false;

        private double GetNum() {
            string text = textBox1.Text;
            double num=0;
            if (textBox1.Text.Contains("%"))
            {
                text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                num = double.Parse(text);
                num /= 100;
            }
            else num = double.Parse(textBox1.Text);
            return num;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBox1.Text = "0";
                equal = false;
            }

            if (textBox1.Text == "0")
                return;
            textBox1.Text += "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBox1.Text = "0";
                equal = false;
            }
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBox1.Text = "0";
                equal = false;
            }
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBox1.Text = "0";
                equal = false;
            }
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBox1.Text = "0";
                equal = false;
            }
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBox1.Text = "0";
                equal = false;
            }
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBox1.Text = "0";
                equal = false;
            }
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBox1.Text = "0";
                equal = false;
            }
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBox1.Text = "0";
                equal = false;
            }
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                textBox1.Text = "0";
                equal = false;
            }
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += "9";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            Operator = "+";
            num1 = GetNum();
            textBox1.Text = "0";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            Operator += "-";
            num1 = GetNum();
            textBox1.Text = "0";
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            Operator += "*";
            num1 = GetNum();
            textBox1.Text = "0";
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            Operator += "/";
            num1 += GetNum();
            textBox1.Text = "0";
        }

        private void btn_Backspace_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (!string.IsNullOrEmpty(text))
            {
                textBox1.Text = text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            equal = true;
            string text = textBox1.Text;
            num2=GetNum();
            //textBox1.Clear();
            switch (Operator)
            {
                case "+":
                    ans = num1 + num2;
                    break;
                case "-":
                    ans = num1 - num2;
                    break;
                case "*":
                    ans = num1 * num2;
                    break;
                case "/":
                    ans = num1 / num2;
                    break;
                default:
                    ans = num2;
                    break;
            }
            num1 = 0;
            num2 = 0;
            Operator = null;
            textBox1.Text = ans.ToString();

        }

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            num1 = GetNum();
            equal = true;
            textBox1.Clear();
            if (num1 < 0)
            {
                textBox1.Text = "ERROR";
                equal = true;
                return;
            }
            ans = Math.Sqrt(num1);
            textBox1.Text += ans.ToString();

        }

        private void btn_percent_Click(object sender, EventArgs e)
        {
            textBox1.Text += "%";            
        }

        private void btn_reciprocal_Click(object sender, EventArgs e)
        {
            num1 = GetNum();
            equal = true;
            textBox1.Clear();
            if (num1 == 0)
            {
                textBox1.Text = "ERROR";
                equal = true;
                return;
            }
            ans = 1 / num1;
            textBox1.Text += ans.ToString();
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (text == "0") return;
            if (!text.Contains("-")) textBox1.Text = "-" + text;
            else textBox1.Text = text.Substring(1, text.Length - 1);
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            num1 = 0;
            num2 = 0;
            Operator = null;
        }

        private void btn_MC_Click(object sender, EventArgs e)
        {
            m = 0;
        }

        private void btn_MR_Click(object sender, EventArgs e)
        {
            textBox1.Text = m.ToString();
        }

        private void btn_MS_Click(object sender, EventArgs e)
        {
            m = GetNum();
            equal = true;
        }

        private void btn_Mp_Click(object sender, EventArgs e)
        {
            m += GetNum();
            equal = true;
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }
    }
}
