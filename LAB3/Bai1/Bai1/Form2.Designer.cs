namespace Bai1
{
    partial class LifecycleForm
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
            this.SuspendLayout();
            // 
            // LifecycleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 157);
            this.Name = "LifecycleForm";
            this.Text = "LifecycleForm";
            this.Activated += new System.EventHandler(this.LifecycleForm_Activated);
            this.Deactivate += new System.EventHandler(this.LifecycleForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LifecycleForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LifecycleForm_FormClosed);
            this.Load += new System.EventHandler(this.LifecycleForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}