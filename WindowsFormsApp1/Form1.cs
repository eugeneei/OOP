using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
       // Figure figure;
        FigureList serial = new FigureList();

        public Form1()
        {
            InitializeComponent();
        }



        private void RectBut_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);

            RectangleFig rect = new RectangleFig();
            // figure = rect;
            rect.SetCoordinates((float)numericUpDown1.Value, (float)numericUpDown2.Value, (float)numericUpDown3.Value, (float)numericUpDown4.Value);

            serial.Add(rect);
            serial.Draw(g);
            serial.Show(listBox1);
        }

        private void ClearBut_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Invalidate();

            serial.Clear(listBox1);
        }

        private void LineBut_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);

            LineFig line = new LineFig();
            // figure = line;
            line.SetCoordinates((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value, (int)numericUpDown4.Value);

            serial.Add(line);
            serial.Draw(g);
            serial.Show(listBox1);
        }

        private void EllipseBut_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);

            var figure = new FigureList();

            EllipseFig ell = new EllipseFig();
            
            ell.SetCoordinates((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value, (int)numericUpDown4.Value);

            serial.Add(ell);
            serial.Draw(g);
            serial.Show(listBox1);           

        }

        private void SaveStrip_Click(object sender, EventArgs e)
        {
            var save = new SaveFileDialog(); 
            save.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = save.FileName;

            serial.SaveFile(filename);
        }

        private void LoadStrip_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (open.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = open.FileName;

            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            serial.LoadFile(filename, g);
            serial.Show(listBox1);
        }
    }
}

 