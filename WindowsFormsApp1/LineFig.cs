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
    [Serializable]
    public class LineFig : Figure
    {

        public float x, y, xsize, ysize;

        public void SetCoordinates(float x, float y, float xsize, float ysize)
        {
            this.x = (int)x;
            this.y = (int)y;
            this.xsize = (int)xsize;
            this.ysize = (int)ysize;
        }
        public override string Draw(Graphics draw)
        {

            Pen pen = new Pen(Color.Black, 5);
            Point a = new Point((int)x, (int)y);
            Point b = new Point((int)xsize, (int)ysize);
            draw.DrawLine(pen, a, b);
            return $"Line({x},{y},{xsize},{ysize})";
        }
    }
}
