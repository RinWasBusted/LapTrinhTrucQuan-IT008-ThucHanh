namespace Bai11
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioEllipse = new System.Windows.Forms.RadioButton();
            this.radioRectangle = new System.Windows.Forms.RadioButton();
            this.radioLine = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioGradient = new System.Windows.Forms.RadioButton();
            this.radioTexture = new System.Windows.Forms.RadioButton();
            this.radioHatch = new System.Windows.Forms.RadioButton();
            this.radioSolid = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioEllipse);
            this.groupBox1.Controls.Add(this.radioRectangle);
            this.groupBox1.Controls.Add(this.radioLine);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // radioEllipse
            // 
            this.radioEllipse.AutoSize = true;
            this.radioEllipse.Location = new System.Drawing.Point(6, 74);
            this.radioEllipse.Name = "radioEllipse";
            this.radioEllipse.Size = new System.Drawing.Size(69, 20);
            this.radioEllipse.TabIndex = 2;
            this.radioEllipse.TabStop = true;
            this.radioEllipse.Text = "Ellipse";
            this.radioEllipse.UseVisualStyleBackColor = true;
            this.radioEllipse.CheckedChanged += new System.EventHandler(this.radioEllipse_CheckedChanged);
            // 
            // radioRectangle
            // 
            this.radioRectangle.AutoSize = true;
            this.radioRectangle.Location = new System.Drawing.Point(6, 47);
            this.radioRectangle.Name = "radioRectangle";
            this.radioRectangle.Size = new System.Drawing.Size(90, 20);
            this.radioRectangle.TabIndex = 1;
            this.radioRectangle.TabStop = true;
            this.radioRectangle.Text = "Rectangle";
            this.radioRectangle.UseVisualStyleBackColor = true;
            this.radioRectangle.CheckedChanged += new System.EventHandler(this.radioRectangle_CheckedChanged);
            // 
            // radioLine
            // 
            this.radioLine.AutoSize = true;
            this.radioLine.Checked = true;
            this.radioLine.Location = new System.Drawing.Point(6, 21);
            this.radioLine.Name = "radioLine";
            this.radioLine.Size = new System.Drawing.Size(53, 20);
            this.radioLine.TabIndex = 0;
            this.radioLine.TabStop = true;
            this.radioLine.Text = "Line";
            this.radioLine.UseVisualStyleBackColor = true;
            this.radioLine.CheckedChanged += new System.EventHandler(this.radioLine_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Controls.Add(this.numWidth);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pen";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(46, 75);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(91, 23);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Color...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(56, 25);
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(120, 22);
            this.numWidth.TabIndex = 2;
            this.numWidth.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioGradient);
            this.groupBox3.Controls.Add(this.radioTexture);
            this.groupBox3.Controls.Add(this.radioHatch);
            this.groupBox3.Controls.Add(this.radioSolid);
            this.groupBox3.Location = new System.Drawing.Point(12, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 180);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Brushes";
            // 
            // radioGradient
            // 
            this.radioGradient.AutoSize = true;
            this.radioGradient.Location = new System.Drawing.Point(6, 100);
            this.radioGradient.Name = "radioGradient";
            this.radioGradient.Size = new System.Drawing.Size(150, 20);
            this.radioGradient.TabIndex = 3;
            this.radioGradient.Text = "LinearGradientBrush";
            this.radioGradient.UseVisualStyleBackColor = true;
            this.radioGradient.CheckedChanged += new System.EventHandler(this.radioGradient_CheckedChanged);
            // 
            // radioTexture
            // 
            this.radioTexture.AutoSize = true;
            this.radioTexture.Location = new System.Drawing.Point(6, 74);
            this.radioTexture.Name = "radioTexture";
            this.radioTexture.Size = new System.Drawing.Size(107, 20);
            this.radioTexture.TabIndex = 2;
            this.radioTexture.Text = "TextureBrush";
            this.radioTexture.UseVisualStyleBackColor = true;
            this.radioTexture.CheckedChanged += new System.EventHandler(this.radioTexture_CheckedChanged);
            // 
            // radioHatch
            // 
            this.radioHatch.AutoSize = true;
            this.radioHatch.Location = new System.Drawing.Point(6, 47);
            this.radioHatch.Name = "radioHatch";
            this.radioHatch.Size = new System.Drawing.Size(97, 20);
            this.radioHatch.TabIndex = 1;
            this.radioHatch.Text = "HatchBrush";
            this.radioHatch.UseVisualStyleBackColor = true;
            this.radioHatch.CheckedChanged += new System.EventHandler(this.radioHatch_CheckedChanged);
            // 
            // radioSolid
            // 
            this.radioSolid.AutoSize = true;
            this.radioSolid.Checked = true;
            this.radioSolid.Location = new System.Drawing.Point(6, 21);
            this.radioSolid.Name = "radioSolid";
            this.radioSolid.Size = new System.Drawing.Size(93, 20);
            this.radioSolid.TabIndex = 0;
            this.radioSolid.TabStop = true;
            this.radioSolid.Text = "SolidBrush";
            this.radioSolid.UseVisualStyleBackColor = true;
            this.radioSolid.CheckedChanged += new System.EventHandler(this.radioSolid_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(237, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 443);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bài 11";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioEllipse;
        private System.Windows.Forms.RadioButton radioRectangle;
        private System.Windows.Forms.RadioButton radioLine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioGradient;
        private System.Windows.Forms.RadioButton radioTexture;
        private System.Windows.Forms.RadioButton radioHatch;
        private System.Windows.Forms.RadioButton radioSolid;
        private System.Windows.Forms.Panel panel1;
    }
}

