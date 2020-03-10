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
        public string name = "log.txt";


        public Form1()
        {
            InitializeComponent();

            FigureList a = new FigureList(LineBut, RectBut, EllipseBut);
        }



        private void RectBut_Click(object sender, EventArgs e)
        {

            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);

            RectangleFig Rect = new RectangleFig((float)numericUpDown1.Value, (float)numericUpDown2.Value, (float)numericUpDown3.Value, (float)numericUpDown4.Value);

            Rect.Draw(g);
        }

        private void ClearBut_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
        }

        private void LineBut_Click(object sender, EventArgs e)
        {

            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);

            LineFig Line = new LineFig((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value, (int)numericUpDown4.Value);

            Line.Draw(g);
        }

        private void EllipseBut_Click(object sender, EventArgs e)
        {

            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);

            EllipseFig Ellipse = new EllipseFig((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value, (int)numericUpDown4.Value);

            Ellipse.Draw(g);
        }
    }
}

 