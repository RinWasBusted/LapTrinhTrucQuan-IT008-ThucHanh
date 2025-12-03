using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        private Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open File";
            openFileDialog1.Filter = "Media Files|*.avi;*.mp4;*.mp3;*.wav;*.wmv|All Files|*.*";
            
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
