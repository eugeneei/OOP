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
    public class RectangleFig : Figure
    {
        public float X, Y, Xsize, Ysize;
            
        public RectangleFig(object sender)
        {
            (sender as Button).Show();
        }
        public RectangleFig(float X, float Y, float Xsize, float Ysize)
        {
            this.X = X;
            this.Y = Y;
            this.Xsize = Xsize;
            this.Ysize = Ysize;
        }

        public string Draw(Graphics draw)
        {
            Pen pen = new Pen(Color.Black, 3);
            draw.DrawRectangle(pen, X, Y, Xsize, Ysize);
            SolidBrush myCorp = new SolidBrush(Color.Olive);
            draw.FillRectangle(myCorp, X, Y, Xsize, Ysize);

            return $"Rectangle({X},{Y},{Xsize},{Ysize})";
        }
    }
}