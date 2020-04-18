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
    public class RectangleFig : Figure
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

            Pen pen = new Pen(Color.Black, 3);
            draw.DrawRectangle(pen, x, y, xsize, ysize);
            SolidBrush myCorp = new SolidBrush(Color.Olive);
            draw.FillRectangle(myCorp, x, y, xsize, ysize);

            return $"Rectangle({x},{y},{xsize},{ysize})";
        }
    }
}