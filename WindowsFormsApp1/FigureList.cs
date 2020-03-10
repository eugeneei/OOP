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
    internal class FigureList
    {
        public FigureList(object LineButton, object RectangleButton, object EllipseButton)
        {
            LineFig a1 = new LineFig(LineButton);
            RectangleFig a2 = new RectangleFig(RectangleButton);
            EllipseFig a3 = new EllipseFig(EllipseButton);

        }

    }
}
