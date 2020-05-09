using System.Drawing;
using System;

namespace WindowsFormsApp1
{

    [Serializable]
    public class CircleFig : Figure
    {

        public float x, y, xsize, ysize;

        public string Name()
        {
            return "Circle";
        }

        public void SetCoordinates(float x, float y, float xsize, float ysize)
        {
            this.x = (int)x;
            this.y = (int)y;
            this.xsize = (int)xsize;
            this.ysize = (int)ysize;
        }


        public string Draw(Graphics draw)
        {
            Pen pen = new Pen(Color.Black, 3);
            Point point = new Point((int)x, (int)y);
            Size size = new Size((int)xsize, (int)xsize);

            Rectangle rect = new Rectangle(point, size);
            draw.DrawEllipse(pen, rect);

            SolidBrush myCorp = new SolidBrush(Color.Blue);
            draw.FillEllipse(myCorp, x, y, xsize, xsize);

            return $"Circle({x},{y},{xsize},{xsize})";
        }
    }
}