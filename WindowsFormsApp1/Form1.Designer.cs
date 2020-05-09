namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RectBut = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.LineBut = new System.Windows.Forms.Button();
            this.ClearBut = new System.Windows.Forms.Button();
            this.EllipseBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SaveStrip = new System.Windows.Forms.ToolStripButton();
            this.LoadStrip = new System.Windows.Forms.ToolStripButton();
            this.FigureBut = new System.Windows.Forms.Button();
            this.FigureText = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(245, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(927, 487);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // RectBut
            // 
            this.RectBut.Location = new System.Drawing.Point(24, 312);
            this.RectBut.Name = "RectBut";
            this.RectBut.Size = new System.Drawing.Size(178, 67);
            this.RectBut.TabIndex = 2;
            this.RectBut.Text = "Rectangle";
            this.RectBut.UseVisualStyleBackColor = true;
            this.RectBut.Click += new System.EventHandler(this.RectBut_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(24, 101);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(85, 26);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Tag = "X coordinate";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(117, 101);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(85, 26);
            this.numericUpDown2.TabIndex = 8;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(24, 189);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(85, 26);
            this.numericUpDown3.TabIndex = 9;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown4.Location = new System.Drawing.Point(117, 189);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(85, 26);
            this.numericUpDown4.TabIndex = 10;
            // 
            // LineBut
            // 
            this.LineBut.Location = new System.Drawing.Point(24, 239);
            this.LineBut.Name = "LineBut";
            this.LineBut.Size = new System.Drawing.Size(178, 67);
            this.LineBut.TabIndex = 11;
            this.LineBut.Text = "Line";
            this.LineBut.UseVisualStyleBackColor = true;
            this.LineBut.Click += new System.EventHandler(this.LineBut_Click);
            // 
            // ClearBut
            // 
            this.ClearBut.Location = new System.Drawing.Point(24, 612);
            this.ClearBut.Name = "ClearBut";
            this.ClearBut.Size = new System.Drawing.Size(178, 66);
            this.ClearBut.TabIndex = 12;
            this.ClearBut.Text = "Clear";
            this.ClearBut.UseVisualStyleBackColor = true;
            this.ClearBut.Click += new System.EventHandler(this.ClearBut_Click);
            // 
            // EllipseBut
            // 
            this.EllipseBut.Location = new System.Drawing.Point(24, 385);
            this.EllipseBut.Name = "EllipseBut";
            this.EllipseBut.Size = new System.Drawing.Size(178, 67);
            this.EllipseBut.TabIndex = 13;
            this.EllipseBut.Text = "Ellipse";
            this.EllipseBut.UseVisualStyleBackColor = true;
            this.EllipseBut.Click += new System.EventHandler(this.EllipseBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Coordinates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Size (Coordinates 2)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "X1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "X2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Y1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Y2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(245, 554);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 124);
            this.listBox1.TabIndex = 20;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveStrip,
            this.LoadStrip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1205, 32);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SaveStrip
            // 
            this.SaveStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveStrip.Image = ((System.Drawing.Image)(resources.GetObject("SaveStrip.Image")));
            this.SaveStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveStrip.Name = "SaveStrip";
            this.SaveStrip.Size = new System.Drawing.Size(84, 29);
            this.SaveStrip.Text = "Save File";
            this.SaveStrip.Click += new System.EventHandler(this.SaveStrip_Click);
            // 
            // LoadStrip
            // 
            this.LoadStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LoadStrip.Image = ((System.Drawing.Image)(resources.GetObject("LoadStrip.Image")));
            this.LoadStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadStrip.Name = "LoadStrip";
            this.LoadStrip.Size = new System.Drawing.Size(86, 29);
            this.LoadStrip.Text = "Load File";
            this.LoadStrip.Click += new System.EventHandler(this.LoadStrip_Click);
            // 
            // FigureBut
            // 
            this.FigureBut.Location = new System.Drawing.Point(24, 518);
            this.FigureBut.Name = "FigureBut";
            this.FigureBut.Size = new System.Drawing.Size(178, 67);
            this.FigureBut.TabIndex = 22;
            this.FigureBut.Text = "Figure";
            this.FigureBut.UseVisualStyleBackColor = true;
            this.FigureBut.Click += new System.EventHandler(this.FigureBut_Click);
            // 
            // FigureText
            // 
            this.FigureText.Location = new System.Drawing.Point(24, 477);
            this.FigureText.Name = "FigureText";
            this.FigureText.Size = new System.Drawing.Size(178, 26);
            this.FigureText.TabIndex = 23;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(990, 554);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(182, 124);
            this.listBox2.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 712);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.FigureText);
            this.Controls.Add(this.FigureBut);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EllipseBut);
            this.Controls.Add(this.ClearBut);
            this.Controls.Add(this.LineBut);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.RectBut);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_MouseMove);
            this.ResizeEnd += new System.EventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button RectBut;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Button ClearBut;
        public System.Windows.Forms.Button EllipseBut;
        public System.Windows.Forms.Button LineBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SaveStrip;
        private System.Windows.Forms.ToolStripButton LoadStrip;
        private System.Windows.Forms.Button FigureBut;
        private System.Windows.Forms.TextBox FigureText;
        private System.Windows.Forms.ListBox listBox2;
    }
}

