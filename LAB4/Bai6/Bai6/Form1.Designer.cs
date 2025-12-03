namespace Bai6
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDich = new System.Windows.Forms.Button();
            this.tbDich = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNguon = new System.Windows.Forms.Button();
            this.tbNguon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.copyStatus = new System.Windows.Forms.ToolStripLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnDich);
            this.groupBox1.Controls.Add(this.tbDich);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnNguon);
            this.groupBox1.Controls.Add(this.tbNguon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(873, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sao chép tập tin";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(350, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sao chép";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDich
            // 
            this.btnDich.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDich.ForeColor = System.Drawing.Color.Black;
            this.btnDich.Location = new System.Drawing.Point(811, 118);
            this.btnDich.Name = "btnDich";
            this.btnDich.Size = new System.Drawing.Size(50, 27);
            this.btnDich.TabIndex = 5;
            this.btnDich.Text = "...";
            this.btnDich.UseVisualStyleBackColor = true;
            this.btnDich.Click += new System.EventHandler(this.btnDich_Click);
            // 
            // tbDich
            // 
            this.tbDich.Location = new System.Drawing.Point(238, 118);
            this.tbDich.Name = "tbDich";
            this.tbDich.Size = new System.Drawing.Size(567, 27);
            this.tbDich.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đường dẫn thư mục đích";
            // 
            // btnNguon
            // 
            this.btnNguon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNguon.ForeColor = System.Drawing.Color.Black;
            this.btnNguon.Location = new System.Drawing.Point(811, 59);
            this.btnNguon.Name = "btnNguon";
            this.btnNguon.Size = new System.Drawing.Size(50, 27);
            this.btnNguon.TabIndex = 2;
            this.btnNguon.Text = "...";
            this.btnNguon.UseVisualStyleBackColor = true;
            this.btnNguon.Click += new System.EventHandler(this.btnNguon_Click);
            // 
            // tbNguon
            // 
            this.tbNguon.Location = new System.Drawing.Point(238, 59);
            this.tbNguon.Name = "tbNguon";
            this.tbNguon.Size = new System.Drawing.Size(567, 27);
            this.tbNguon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường dẫn thư mục nguồn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(14, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(874, 68);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiến trình sao chép";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 26);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(844, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyStatus});
            this.toolStrip1.Location = new System.Drawing.Point(0, 353);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(900, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // copyStatus
            // 
            this.copyStatus.Name = "copyStatus";
            this.copyStatus.Size = new System.Drawing.Size(111, 22);
            this.copyStatus.Text = "Đang sao chép:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 378);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Bài 6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDich;
        private System.Windows.Forms.TextBox tbDich;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNguon;
        private System.Windows.Forms.TextBox tbNguon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel copyStatus;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

