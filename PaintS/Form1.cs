using System.Drawing.Imaging;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace PaintS
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 2);
        Pen Eraser = new Pen(Color.White, 10);
        int index;
        int x, y, sx, sy, cx, cy;
        

        Color New_Color;
        ColorDialog cd = new ColorDialog();

        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
           
        }


        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cx = e.X;
            cy = e.Y;
           
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
            }
            pic.Refresh();

            x = e.X;
            y = e.Y;
            sx = e.X - cx;
            sy = e.Y - cy;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sx = x - cx;
            sy = y - cy;
            if (index == 3)
            {
                g.DrawEllipse(p, cx, cy, sx, sy);
            }
            if (index == 4)
            {
                g.DrawRectangle(p, cx, cy, sx, sy);
            }
            if (index == 5)
            {
                g.DrawLine(p, cx, cy, x, y);
            }
            if (index == 7)
            {
                Point[] points = new Point[]
                {
            new Point(cx, cy),   // ������� A
            new Point(x, y),     // ������� B
            new Point(cx, y)     // ������� C
                };
                g.DrawPolygon(p, points);
            }
        }


        private void btnEllipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }
        private void btnTriangle_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            index = 5;
        }
        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cx, cy, sx, sy);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cx, cy, sx, sy);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cx, cy, x, y);
                    if (index == 7)
                    {
                        Point[] points = new Point[]
                        {
                        new Point(cx, cy),   // ������� A
                        new Point(x, y),     // ������� B
                        new Point(cx, y)     // ������� C
                        };
                        g.DrawPolygon(p, points);
                    }
                }
               

            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
        }
        private void btnRectang_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        static Point set_Point(PictureBox pb, Point pt)
        {
            float px = 1f * pb.Width / pb.Width;
            float py = 1f * pb.Height / pb.Height;
            return new Point((int)(pt.X * px), (int)(pt.Y * py));
        }
        private void Validate(Bitmap bm, Stack<Point> sp, int x, int y, Color Old_Color, Color New_Color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == Old_Color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, New_Color);
            }
        }

        public void Fill(Bitmap bm, int x, int y, Color New_Clr)
        {
            Color Old_Color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, New_Clr);
            if (Old_Color == New_Clr) { return; }

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    Validate(bm, pixel, pt.X - 1, pt.Y, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X, pt.Y - 1, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X + 1, pt.Y, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X, pt.Y + 1, Old_Color, New_Clr);
                }
            }
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 6)
            {
                Point point = set_Point(pic, e.Location);
                Fill(bm, point.X, point.Y, New_Color);
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            New_Color = cd.Color;
            pic.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }
    }
}