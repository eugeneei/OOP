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
        protected string name = @"log.txt";
        List<string> log = new List<string>();

        public void Add(Figure fig)
        {
            list.Add(fig);
        }

        public void Draw()
        {
            log.Clear();
            for (var i = 0; i < list.Count; i++)
            {
                log.Add(list[i].Draw());
            }
        }

        public void Show(object obj)
        {
            (obj as ListBox).Items.Clear();
            for (var i = 0; i < log.Count; i++)
            {
                (obj as ListBox).Items.Insert(i, log[i]);
            }
        }
        public void Clear(object obj)
        {
                (obj as ListBox).Items.Clear();
                list.Clear();
                log.Clear();
        }
    }
}
