using System.Drawing;

namespace Bai10
{
    public partial class Form1 : Form
    {
        Pen pen;

        public Form1()
        {
            pen = new Pen(Color.BlueViolet, 2);
            InitializeComponent();
            
        }
        private void Cbb_Width_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pen.Width = float.Parse(cbb_Width.Text);
            }
            panel1.Invalidate();
        }


        private void cbb_Width_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen.Width = float.Parse(cbb_Width.Text);
            panel1.Invalidate();
        }

        private void cbb_DashStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_DashStyle.Text)
            {
                case "Solid":
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    break;
                case "Dash":
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    break;
                case "Dot":
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    break;
                case "DashDot":
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                    break;
                case "DashDotDot":
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
                    break;
            }
            panel1.Invalidate();
        }

        private void cbb_LineJoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_LineJoin.Text)
            {
                case "Miter":
                    pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Miter;
                    break;
                case "Bevel":
                    pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                    break;
                case "Round":
                    pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                    break;
                case "MiterClipped":
                    pen.LineJoin = System.Drawing.Drawing2D.LineJoin.MiterClipped;
                    break;
            }
            panel1.Invalidate();
        }

        private void cbb_DashCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_DashCap.Text)
            {
                case "Flat":
                    pen.DashCap = System.Drawing.Drawing2D.DashCap.Flat;
                    break;
                case "Round":
                    pen.DashCap = System.Drawing.Drawing2D.DashCap.Round;
                    break;
                case "Triangle":
                    pen.DashCap = System.Drawing.Drawing2D.DashCap.Triangle;
                    break;
            }
            panel1.Invalidate();
        }

        private void cbb_StartCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_StartCap.Text)
            {
                case "Flat":
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
                    break;
                case "Square":
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Square;
                    break;
                case "Round":
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    break;
                case "Triangle":
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Triangle;
                    break;
                case "ArrowAnchor":
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    break;
                case "RoundAnchor":
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
                    break;
                case "SquareAnchor":
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.SquareAnchor;
                    break;
                case "DiamondAnchor":
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
                    break;
                case "NoAnchor":
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.NoAnchor;
                    break;
            }
            panel1.Invalidate();
        }

        private void cbb_EndCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_EndCap.Text)
            {
                case "Flat":
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;
                    break;
                case "Square":
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Square;
                    break;
                case "Round":
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    break;
                case "Triangle":
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Triangle;
                    break;
                case "ArrowAnchor":
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    break;
                case "RoundAnchor":
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
                    break;
                case "SquareAnchor":
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.SquareAnchor;
                    break;
                case "DiamondAnchor":
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
                    break;
                case "NoAnchor":
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.NoAnchor;
                    break;
            }
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawCurve(pen, new Point[]{
                                    new Point(50, 50),
                                    new Point(150, 50),
                                    new Point(150, 150)
                                }, 0.0f);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbb_DashCap.SelectedIndex = 0;
            cbb_DashStyle.SelectedIndex = 0;
            cbb_LineJoin.SelectedIndex = 0;
            cbb_Width.SelectedIndex = 1;
            cbb_EndCap.SelectedIndex = 0;
            cbb_StartCap.SelectedIndex = 0;

            
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pen.Width = float.Parse(cbb_Width.Text);
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Miter;
            pen.DashCap = System.Drawing.Drawing2D.DashCap.Flat;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;
        }
    }
}
