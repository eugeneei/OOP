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
    internal class Serial
    {
        protected string name = @"log.txt";
        List<string> log = new List<string>();
        public Serial()
        {
        }
        public void LogAdd(string str)
        {
            log.Add(str);
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
                log.Clear();
        }
    }
}

