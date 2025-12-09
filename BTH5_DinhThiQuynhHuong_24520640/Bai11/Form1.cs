using System.Drawing.Drawing2D;
using System.Net;

namespace Bai11
{
    public partial class Form1 : Form
    {
        Brush brush;
        Pen pen;
        bool isDrawing = false;
        Point startPoint;
        Point currentPoint;
        string currentShape;

        Bitmap canvas;
        Graphics gCanvas;
        public Form1()
        {
            brush = new SolidBrush(Color.Green);
            pen = new Pen(Color.Black);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rb_Line.Checked = true;
            rb_SolidBrush.Checked = true;
            tb_width.Text = "1";
            pen.Width = float.Parse(tb_width.Text);

            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gCanvas = Graphics.FromImage(canvas);
            gCanvas.Clear(Color.White);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
            }
        }

        private void tb_width_TextChanged(object sender, EventArgs e)
        {
            pen.Width = float.Parse(tb_width.Text);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
                currentPoint = e.Location;
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                currentPoint = e.Location;
                pictureBox1.Invalidate();
            }
        }
        private Rectangle GetRect(Point pt1, Point pt2)
        {
            return new Rectangle(
                    Math.Min(pt1.X, pt2.X),
                    Math.Min(pt1.Y, pt2.Y),
                    Math.Abs(pt1.X - pt2.X),
                    Math.Abs(pt1.Y - pt2.Y)
            );
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;

                switch (currentShape)
                {
                    case "Line":
                        gCanvas.DrawLine(pen, startPoint, e.Location);
                        break;

                    case "Rectangle":
                        gCanvas.FillRectangle(brush, GetRect(startPoint, e.Location));
                        break;

                    case "Ellipse":
                        gCanvas.FillEllipse(brush, GetRect(startPoint, e.Location));
                        break;
                }

                pictureBox1.Image = canvas;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (isDrawing)
            {
                switch (currentShape)
                {
                    case "Line":
                        e.Graphics.DrawLine(pen, startPoint, currentPoint);
                        break;

                    case "Rectangle":
                        e.Graphics.FillRectangle(brush, GetRect(startPoint, currentPoint));
                        break;

                    case "Ellipse":
                        e.Graphics.FillEllipse(brush, GetRect(startPoint, currentPoint));
                        break;
                }
            }
        }

        private void rb_Line_CheckedChanged(object sender, EventArgs e)
        {
            currentShape = "Line";
        }

        private void rb_Rectangle_CheckedChanged(object sender, EventArgs e)
        {
            currentShape = "Rectangle";
        }

        private void rb_Ellipse_CheckedChanged(object sender, EventArgs e)
        {
            currentShape = "Ellipse";
        }

        private void rb_SolidBrush_CheckedChanged(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.Green);
        }

        private void rb_HatchBrush_CheckedChanged(object sender, EventArgs e)
        {
            brush = new HatchBrush(HatchStyle.Horizontal,Color.Blue, Color.Green);
        }

        private void rb_TextureBrush_CheckedChanged(object sender, EventArgs e)
        {
            brush = new TextureBrush(Properties.Resources.Picture1);
        }

        private void rb_LinearGradientBrush_CheckedChanged(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
            brush = new LinearGradientBrush( rect,Color.Red,Color.Green,LinearGradientMode.Vertical);

        }
    }
}
