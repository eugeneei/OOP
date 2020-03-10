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
    public class LineFig
    {
        public int X, Y, Xsize, Ysize;
        public LineFig(object sender)
        {
            (sender as Button).Show();
        }

        public LineFig(int X, int Y, int Xsize, int Ysize)
        {
            this.X = X;
            this.Y = Y;
            this.Xsize = Xsize;
            this.Ysize = Ysize;

        }
        public string Draw(Graphics draw)
        {
            Pen pen = new Pen(Color.Black, 5);
            Point a = new Point(X, Y);
            Point b = new Point(Xsize, Ysize);
            draw.DrawLine(pen, a, b);
            return $"Line({X},{Y},{Xsize},{Ysize})";
        }
    }
}
