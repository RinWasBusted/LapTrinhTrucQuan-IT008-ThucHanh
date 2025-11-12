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
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            string text = "Paint Event";
            using (Font font = new Font("Arial", 12))
            using (SolidBrush brush = new SolidBrush(Color.Red))
            {
                int x = random.Next(this.ClientSize.Width - 100);
                int y = random.Next(this.ClientSize.Height - 50);

                g.DrawString(text, font, brush, new PointF(x,y));
            }
        }
    }
}
