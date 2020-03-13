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
    public class FigureList
    {
        List<Figure> list = new List<Figure>();

        public void Add(Figure obj)
        {
            list.Add(obj);
        }

        public void Draw()
        {
            for (var i = 0; i < list.Count; i++)
            {
                list[i].Draw();
            }
        }
    }
}
