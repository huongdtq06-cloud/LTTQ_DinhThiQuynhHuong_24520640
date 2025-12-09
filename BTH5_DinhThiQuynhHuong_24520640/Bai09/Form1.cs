namespace Bai09
{
    public partial class Form1 : Form
    {
        Pen pen;
        Brush brush;
        public Form1()
        {
            brush = new SolidBrush(Color.DarkRed);
            pen = new Pen(brush);
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            panel1.Invalidate();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            switch(comboBox1.Text) {
                case "Circle":
                    g.DrawEllipse(pen, new Rectangle(75, 0, 200, 200));
                    break;
                case "Square":
                    g.DrawRectangle(pen, new Rectangle(75,0,200,200));
                    break;
                case "Ellipse":
                    g.DrawEllipse(pen, new Rectangle(25,0,325,150));
                    break;
                case "Pie":
                    g.DrawPie(pen, 75, 0, 200, 200, 180, 90);
                    break;
                case "Filled Circle":
                    g.FillEllipse(brush, new Rectangle(75, 0, 200, 200));
                    break;
                case "Filled Square":
                    g.FillRectangle(brush, new Rectangle(75,0,200,200));
                    break;
                case "Filled Ellipse":
                    g.FillEllipse(brush, new Rectangle(25,0,325,200));
                    break;
                case "Filled Pie":
                    g.FillPie(brush, 75, 0, 200, 200, 180, 90);
                    break;
            }
        }

    }

    

}
