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
    internal class EllipseFig : Figure
    {


        public override string Draw()
        {

            Pen pen = new Pen(Color.Black, 3);
            Point point = new Point((int)x, (int)y);
            Size size = new Size((int)xsize, (int)ysize);

            Rectangle rect = new Rectangle(point, size);
            draw.DrawEllipse(pen, rect);

            SolidBrush myCorp = new SolidBrush(Color.Blue);
            draw.FillEllipse(myCorp, (float)x, (float)y, (float)xsize, (float)ysize);

            return $"Ellipse({x},{y},{xsize},{ysize})";
        }
    }
}