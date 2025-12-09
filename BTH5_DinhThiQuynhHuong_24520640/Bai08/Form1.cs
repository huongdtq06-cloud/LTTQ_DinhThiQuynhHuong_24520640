using System.Drawing;

namespace Bai08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void DrawHand(Graphics g, Point center, double angle, float length, int thickness)
        {
            int x = center.X + (int)(Math.Cos(angle - Math.PI / 2) * length);
            int y = center.Y + (int)(Math.Sin(angle - Math.PI / 2) * length);
            g.DrawLine(new Pen(Color.White, thickness), center, new Point(x, y));
        }
        private void Panel1_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int w = panel1.Width;
            int h = panel1.Height;
            int radius = Math.Min(w, h) / 2 - 20;

            Point center = new Point(w / 2, h / 2);

            DateTime now = DateTime.Now;
            int hour = now.Hour % 12;
            int minute = now.Minute;
            int second = now.Second;

            
            for (int i = 0; i < 60; i++)
            {
                double angle = Math.PI * i / 30;
                int x = center.X + (int)(Math.Cos(angle) * radius);
                int y = center.Y + (int)(Math.Sin(angle) * radius);

                int size = (i % 5 == 0) ? 10 : 5;
                g.FillEllipse(Brushes.White, x - size / 2, y - size / 2, size, size);
            }

            
            double secAngle = Math.PI * second / 30;
            double minAngle = Math.PI * minute / 30 + Math.PI * second / 1800;
            double hourAngle = Math.PI * hour / 6 + Math.PI * minute / 360;

            
            DrawHand(g, center, hourAngle, radius * 0.5f, 4);

            
            DrawHand(g, center, minAngle, radius * 0.75f, 3);

            
            DrawHand(g, center, secAngle, radius * 0.85f, 1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
    }
}
