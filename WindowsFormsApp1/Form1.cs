using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
       // Figure figure;
        FigureList serial = new FigureList();
        List<Figure> plugins = new List<Figure>();

        public Form1()
        {
            InitializeComponent();

            var plag = new Plagins();
            plugins = plag.plugins;

            int i = 0;
            foreach (var figure in plugins)
            {
                listBox2.Items.Insert(i, figure.Name());
                i++;
            }
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

            EllipseFig ell = new EllipseFig();
            
            ell.SetCoordinates((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value, (int)numericUpDown4.Value);

            serial.Add(ell);
            serial.Draw(g);
            serial.Show(listBox1);           

        }

        private void SaveStrip_Click(object sender, EventArgs e)
        {
            var save = new SaveFileDialog(); 
            save.Filter = "Data files(*.dat)|*.dat|All files(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = save.FileName;

            serial.SaveFile(filename);
            MessageBox.Show("Saved sucefully!");
        }

        private void LoadStrip_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = "Data files(*.dat)|*.dat|All files(*.*)|*.*";
            if (open.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = open.FileName;

            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            serial.LoadFile(filename, g);
            serial.Show(listBox1);
        }

        private void Form1_MouseMove(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            serial.Draw(g);
            serial.Show(listBox1);
        }

        private void FigureBut_Click(object sender, EventArgs e)
        {
            bool isnFound = true;
            string figureText = FigureText.Text;
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);

                foreach (var figure in plugins)
                    if (figure.Name() == figureText)
                    {
                        figure.SetCoordinates((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value, (int)numericUpDown4.Value);
                        serial.Add(figure);
                        isnFound = false;
                    }
                if (isnFound)
                    MessageBox.Show("Plugin not found!");


            serial.Draw(g);
            serial.Show(listBox1);
        }
    }
}

 