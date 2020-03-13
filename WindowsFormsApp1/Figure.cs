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
    public abstract class Figure
    {
        protected float x, y, xsize, ysize;
        protected Graphics draw;
        protected Form1 Form;
        public abstract string Draw();
        public void SetCoordinates(Graphics draw,float x, float y, float xsize, float ysize)
        {
            this.x = (int)x;
            this.x = (int)y;
            this.xsize = (int)xsize;
            this.ysize = (int)ysize;
            this.draw = draw;
        }
    }
    
}