using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    internal class EllipseFig
    {
        public int Xsize, Ysize;
        public int X, Y;
        public EllipseFig(object sender)
        {
            (sender as Button).Show();
        }

        public EllipseFig(int X, int Y, int Xsize, int Ysize)
        {
            this.X = X;
            this.Y = Y;
            this.Xsize = Xsize;
            this.Ysize = Ysize;
        }

        public string Draw(Graphics draw)
        {
            Pen pen = new Pen(Color.Black, 3);
            Point point = new Point(X, Y);
            Size size = new Size(Xsize, Ysize);

            Rectangle rect = new Rectangle(point, size);
            draw.DrawEllipse(pen, rect);

            SolidBrush myCorp = new SolidBrush(Color.Blue);
            draw.FillEllipse(myCorp, (float)X, (float)Y, (float)Xsize, (float)Ysize);

            return $"Ellipse({X},{Y},{Xsize},{Ysize})";
        }
    }
}