namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(Num1_txtbox.Text);
            double num2 = double.Parse(num2_txtbox.Text);
            ans_txtbox.Text = (num1 + num2).ToString();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(Num1_txtbox.Text);
            double num2 = double.Parse(num2_txtbox.Text);
            ans_txtbox.Text = (num1 - num2).ToString();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(Num1_txtbox.Text);
            double num2 = double.Parse(num2_txtbox.Text);
            ans_txtbox.Text = (num1 * num2).ToString();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(Num1_txtbox.Text);
            double num2 = double.Parse(num2_txtbox.Text);
            ans_txtbox.Text = (num1 / num2).ToString();
        }

        
    }
}
