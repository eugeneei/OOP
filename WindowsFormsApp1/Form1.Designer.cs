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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RectBut = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.LineBut = new System.Windows.Forms.Button();
            this.ClearBut = new System.Windows.Forms.Button();
            this.EllipseBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(236, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(927, 631);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // RectBut
            // 
            this.RectBut.Location = new System.Drawing.Point(25, 274);
            this.RectBut.Name = "RectBut";
            this.RectBut.Size = new System.Drawing.Size(178, 67);
            this.RectBut.TabIndex = 2;
            this.RectBut.Text = "Rectangle";
            this.RectBut.UseVisualStyleBackColor = true;
            this.RectBut.Visible = false;
            this.RectBut.Click += new System.EventHandler(this.RectBut_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(25, 12);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(178, 26);
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
            this.numericUpDown2.Location = new System.Drawing.Point(25, 53);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(178, 26);
            this.numericUpDown2.TabIndex = 8;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(25, 94);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(178, 26);
            this.numericUpDown3.TabIndex = 9;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown4.Location = new System.Drawing.Point(25, 137);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(178, 26);
            this.numericUpDown4.TabIndex = 10;
            // 
            // LineBut
            // 
            this.LineBut.Location = new System.Drawing.Point(25, 201);
            this.LineBut.Name = "LineBut";
            this.LineBut.Size = new System.Drawing.Size(178, 67);
            this.LineBut.TabIndex = 11;
            this.LineBut.Text = "Line";
            this.LineBut.UseVisualStyleBackColor = true;
            this.LineBut.Visible = false;
            this.LineBut.Click += new System.EventHandler(this.LineBut_Click);
            // 
            // ClearBut
            // 
            this.ClearBut.Location = new System.Drawing.Point(25, 594);
            this.ClearBut.Name = "ClearBut";
            this.ClearBut.Size = new System.Drawing.Size(178, 66);
            this.ClearBut.TabIndex = 12;
            this.ClearBut.Text = "Clear";
            this.ClearBut.UseVisualStyleBackColor = true;
            this.ClearBut.Click += new System.EventHandler(this.ClearBut_Click);
            // 
            // EllipseBut
            // 
            this.EllipseBut.Location = new System.Drawing.Point(25, 347);
            this.EllipseBut.Name = "EllipseBut";
            this.EllipseBut.Size = new System.Drawing.Size(178, 67);
            this.EllipseBut.TabIndex = 13;
            this.EllipseBut.Text = "Ellipse";
            this.EllipseBut.UseVisualStyleBackColor = true;
            this.EllipseBut.Visible = false;
            this.EllipseBut.Click += new System.EventHandler(this.EllipseBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 676);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);

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
    }
}

