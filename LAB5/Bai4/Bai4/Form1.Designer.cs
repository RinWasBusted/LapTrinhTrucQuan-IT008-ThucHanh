namespace Bai4
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.cbBold = new System.Windows.Forms.CheckBox();
            this.cbItalic = new System.Windows.Forms.CheckBox();
            this.cbUnderline = new System.Windows.Forms.CheckBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCenterAlign = new System.Windows.Forms.RadioButton();
            this.radioRightAlign = new System.Windows.Forms.RadioButton();
            this.radioLeftAlign = new System.Windows.Forms.RadioButton();
            this.txtSample = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font";
            // 
            // cmbFont
            // 
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.Location = new System.Drawing.Point(81, 29);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(121, 27);
            this.cmbFont.TabIndex = 1;
            this.cmbFont.SelectedValueChanged += new System.EventHandler(this.cmbFont_SelectedValueChanged);
            // 
            // cbBold
            // 
            this.cbBold.AutoSize = true;
            this.cbBold.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBold.Image = global::Bai4.Properties.Resources.bold_text_option;
            this.cbBold.Location = new System.Drawing.Point(38, 75);
            this.cbBold.Name = "cbBold";
            this.cbBold.Size = new System.Drawing.Size(48, 42);
            this.cbBold.TabIndex = 2;
            this.cbBold.Text = " ";
            this.cbBold.UseVisualStyleBackColor = true;
            this.cbBold.CheckedChanged += new System.EventHandler(this.cbBold_CheckedChanged);
            // 
            // cbItalic
            // 
            this.cbItalic.AutoSize = true;
            this.cbItalic.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItalic.Image = global::Bai4.Properties.Resources.letter;
            this.cbItalic.Location = new System.Drawing.Point(92, 75);
            this.cbItalic.Name = "cbItalic";
            this.cbItalic.Size = new System.Drawing.Size(48, 42);
            this.cbItalic.TabIndex = 3;
            this.cbItalic.Text = " ";
            this.cbItalic.UseVisualStyleBackColor = true;
            this.cbItalic.CheckedChanged += new System.EventHandler(this.cbItalic_CheckedChanged);
            // 
            // cbUnderline
            // 
            this.cbUnderline.AutoSize = true;
            this.cbUnderline.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnderline.Image = global::Bai4.Properties.Resources.underline_text_option;
            this.cbUnderline.Location = new System.Drawing.Point(154, 75);
            this.cbUnderline.Name = "cbUnderline";
            this.cbUnderline.Size = new System.Drawing.Size(48, 42);
            this.cbUnderline.TabIndex = 4;
            this.cbUnderline.Text = " ";
            this.cbUnderline.UseVisualStyleBackColor = true;
            this.cbUnderline.CheckedChanged += new System.EventHandler(this.cbUnderline_CheckedChanged);
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.cmbSize.Location = new System.Drawing.Point(326, 32);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 27);
            this.cmbSize.TabIndex = 6;
            this.cmbSize.Text = "28";
            this.cmbSize.SelectedValueChanged += new System.EventHandler(this.cmbSize_SelectedValueChanged);
            this.cmbSize.TextChanged += new System.EventHandler(this.cmbSize_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Color";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(326, 91);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(38, 34);
            this.btnColor.TabIndex = 8;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCenterAlign);
            this.groupBox1.Controls.Add(this.radioRightAlign);
            this.groupBox1.Controls.Add(this.radioLeftAlign);
            this.groupBox1.Location = new System.Drawing.Point(38, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 120);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Align Text";
            // 
            // radioCenterAlign
            // 
            this.radioCenterAlign.AutoSize = true;
            this.radioCenterAlign.Location = new System.Drawing.Point(6, 55);
            this.radioCenterAlign.Name = "radioCenterAlign";
            this.radioCenterAlign.Size = new System.Drawing.Size(79, 23);
            this.radioCenterAlign.TabIndex = 2;
            this.radioCenterAlign.TabStop = true;
            this.radioCenterAlign.Text = "Center";
            this.radioCenterAlign.UseVisualStyleBackColor = true;
            this.radioCenterAlign.CheckedChanged += new System.EventHandler(this.radioCenterAlign_CheckedChanged);
            // 
            // radioRightAlign
            // 
            this.radioRightAlign.AutoSize = true;
            this.radioRightAlign.Location = new System.Drawing.Point(6, 84);
            this.radioRightAlign.Name = "radioRightAlign";
            this.radioRightAlign.Size = new System.Drawing.Size(67, 23);
            this.radioRightAlign.TabIndex = 1;
            this.radioRightAlign.TabStop = true;
            this.radioRightAlign.Text = "Right";
            this.radioRightAlign.UseVisualStyleBackColor = true;
            this.radioRightAlign.CheckedChanged += new System.EventHandler(this.radioRightAlign_CheckedChanged);
            // 
            // radioLeftAlign
            // 
            this.radioLeftAlign.AutoSize = true;
            this.radioLeftAlign.Checked = true;
            this.radioLeftAlign.Location = new System.Drawing.Point(6, 26);
            this.radioLeftAlign.Name = "radioLeftAlign";
            this.radioLeftAlign.Size = new System.Drawing.Size(57, 23);
            this.radioLeftAlign.TabIndex = 0;
            this.radioLeftAlign.TabStop = true;
            this.radioLeftAlign.Text = "Left";
            this.radioLeftAlign.UseVisualStyleBackColor = true;
            this.radioLeftAlign.CheckedChanged += new System.EventHandler(this.radioLeftAlign_CheckedChanged);
            // 
            // txtSample
            // 
            this.txtSample.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSample.Location = new System.Drawing.Point(192, 169);
            this.txtSample.Multiline = true;
            this.txtSample.Name = "txtSample";
            this.txtSample.Size = new System.Drawing.Size(255, 62);
            this.txtSample.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 295);
            this.Controls.Add(this.txtSample);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbUnderline);
            this.Controls.Add(this.cbItalic);
            this.Controls.Add(this.cbBold);
            this.Controls.Add(this.cmbFont);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Bài 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFont;
        private System.Windows.Forms.CheckBox cbBold;
        private System.Windows.Forms.CheckBox cbItalic;
        private System.Windows.Forms.CheckBox cbUnderline;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioCenterAlign;
        private System.Windows.Forms.RadioButton radioRightAlign;
        private System.Windows.Forms.RadioButton radioLeftAlign;
        private System.Windows.Forms.TextBox txtSample;
    }
}

