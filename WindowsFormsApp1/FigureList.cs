using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

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

        public void Draw(Graphics d)
        {
            log.Clear();
            for (var i = 0; i < list.Count; i++)
            {
                log.Add(list[i].Draw(d));
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


        public void SaveFile(string file)
        {
            XmlSerializer formatter = new XmlSerializer(list.GetType());

            using (FileStream fs = new FileStream(file, FileMode.Create))
            {
                formatter.Serialize(fs, list);
            }
        }

        public void LoadFile(string file, Graphics graph)
        {
            log.Clear();

            XmlSerializer formatter = new XmlSerializer(list.GetType());
            using (FileStream fs = new FileStream(file, FileMode.Open))
            {
                list = (List<Figure>)formatter.Deserialize(fs);
            }

            this.Draw(graph);
        }
    }
}
