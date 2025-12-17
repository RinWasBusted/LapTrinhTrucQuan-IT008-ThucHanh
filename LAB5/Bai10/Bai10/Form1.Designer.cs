namespace Bai10
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDashStyle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLineJoin = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDashCap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStartCap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEndCap = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(232, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 326);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dash Style:";
            // 
            // cmbDashStyle
            // 
            this.cmbDashStyle.FormattingEnabled = true;
            this.cmbDashStyle.Location = new System.Drawing.Point(93, 18);
            this.cmbDashStyle.Name = "cmbDashStyle";
            this.cmbDashStyle.Size = new System.Drawing.Size(121, 24);
            this.cmbDashStyle.TabIndex = 2;
            this.cmbDashStyle.SelectedValueChanged += new System.EventHandler(this.cmbDashStyle_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width:";
            // 
            // cmbLineJoin
            // 
            this.cmbLineJoin.FormattingEnabled = true;
            this.cmbLineJoin.Location = new System.Drawing.Point(93, 120);
            this.cmbLineJoin.Name = "cmbLineJoin";
            this.cmbLineJoin.Size = new System.Drawing.Size(121, 24);
            this.cmbLineJoin.TabIndex = 6;
            this.cmbLineJoin.SelectedIndexChanged += new System.EventHandler(this.cmbLineJoin_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Line Join:";
            // 
            // cmbDashCap
            // 
            this.cmbDashCap.FormattingEnabled = true;
            this.cmbDashCap.Location = new System.Drawing.Point(93, 173);
            this.cmbDashCap.Name = "cmbDashCap";
            this.cmbDashCap.Size = new System.Drawing.Size(121, 24);
            this.cmbDashCap.TabIndex = 8;
            this.cmbDashCap.SelectedIndexChanged += new System.EventHandler(this.cmbDashCap_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dash Cap:";
            // 
            // cmbStartCap
            // 
            this.cmbStartCap.FormattingEnabled = true;
            this.cmbStartCap.Location = new System.Drawing.Point(93, 228);
            this.cmbStartCap.Name = "cmbStartCap";
            this.cmbStartCap.Size = new System.Drawing.Size(121, 24);
            this.cmbStartCap.TabIndex = 10;
            this.cmbStartCap.SelectedIndexChanged += new System.EventHandler(this.cmbStartCap_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Start Cap:";
            // 
            // cmbEndCap
            // 
            this.cmbEndCap.FormattingEnabled = true;
            this.cmbEndCap.Location = new System.Drawing.Point(93, 279);
            this.cmbEndCap.Name = "cmbEndCap";
            this.cmbEndCap.Size = new System.Drawing.Size(121, 24);
            this.cmbEndCap.TabIndex = 12;
            this.cmbEndCap.SelectedIndexChanged += new System.EventHandler(this.cmbEndCap_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "End Cap:";
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(93, 71);
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(121, 22);
            this.numWidth.TabIndex = 13;
            this.numWidth.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numWidth.ValueChanged += new System.EventHandler(this.numWidth_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 330);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.cmbEndCap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbStartCap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDashCap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbLineJoin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDashStyle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Bài 10";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDashStyle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLineJoin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDashCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbStartCap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEndCap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numWidth;
    }
}

