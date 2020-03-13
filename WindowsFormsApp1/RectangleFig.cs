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
        public override string Draw()
        {

            Pen pen = new Pen(Color.Black, 3);
            draw.DrawRectangle(pen, x, y, xsize, ysize);
            SolidBrush myCorp = new SolidBrush(Color.Olive);
            draw.FillRectangle(myCorp, x, y, xsize, ysize);

            return $"Rectangle({x},{y},{xsize},{ysize})";
        }
    }
}