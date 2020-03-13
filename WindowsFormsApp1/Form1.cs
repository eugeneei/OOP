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
    
    public partial class Form1 : Form
    {
        Figure figure;
        FigureList serial = new FigureList();

        public Form1()
        {
            InitializeComponent();
        }



        private void RectBut_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);

            RectangleFig rect = new RectangleFig();
            figure = rect;
            figure.SetCoordinates(g, (float)numericUpDown1.Value, (float)numericUpDown2.Value, (float)numericUpDown3.Value, (float)numericUpDown4.Value);

            serial.Add(rect);
            serial.Draw();
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
            figure = line;
            figure.SetCoordinates(g, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value, (int)numericUpDown4.Value);

            serial.Add(line);
            serial.Draw();
            serial.Show(listBox1);
        }

        private void EllipseBut_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);

            EllipseFig ell = new EllipseFig();
            figure = ell;
            figure.SetCoordinates(g, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value, (int)numericUpDown4.Value);

            serial.Add(ell);
            serial.Draw();
            serial.Show(listBox1);
        }
    }
}

 