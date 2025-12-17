using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        public string hinhVe;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            hinhVe = comboBox1.SelectedItem.ToString();
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.DarkRed, 3);
            Brush brush = new SolidBrush(Color.DarkRed);
            //            Circle
            //Square
            //Ellipse
            //Pie
            //Filled Circle
            //Filled Square
            //Filled Ellipse
            //Filled Pie
            if (hinhVe == "Circle")
            {
                g.DrawEllipse(pen, 20, 70, 150, 150);
            }
            else if (hinhVe == "Square")
            {
                g.DrawRectangle(pen, 20, 70, 150, 150);
            }
            else if (hinhVe == "Ellipse")
            {
                g.DrawEllipse(pen, 20, 70, 200, 100);
            }
            else if (hinhVe == "Pie")
            {
                g.DrawPie(pen, 20, 70, 150, 150, 30, 120);
            }
            else if (hinhVe == "Filled Circle")
            {
                g.FillEllipse(brush, 20, 70, 150, 150);
            }
            else if (hinhVe == "Filled Square")
            {
                g.FillRectangle(brush, 20, 70, 150, 150);
            }
            else if (hinhVe == "Filled Ellipse")
            {
                g.FillEllipse(brush, 20, 70, 200, 100);
            }
            else if (hinhVe == "Filled Pie")
            {
                g.FillPie(brush, 20, 70, 150, 150, 30, 120);
            }
            g.Dispose();
        }
    }
}
