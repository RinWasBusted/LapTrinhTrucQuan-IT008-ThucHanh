using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbDashStyle_SelectedValueChanged(object sender, EventArgs e)
        {
            if (panel1 != null)
            {
                panel1.Invalidate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(var dashStyle in Enum.GetValues(typeof(DashStyle)))
            {
                cmbDashStyle.Items.Add(dashStyle);
            }
            cmbDashStyle.SelectedIndex = 0;
            foreach (var dashCap in Enum.GetValues(typeof(DashCap)))
            {
                cmbDashCap.Items.Add(dashCap);
            }
            cmbDashCap.SelectedIndex = 0;
            foreach (var lineJoin in Enum.GetValues(typeof(LineJoin)))
            {
                cmbLineJoin.Items.Add(lineJoin);
            }
            cmbLineJoin.SelectedIndex = 0;
            foreach (var lineCap in Enum.GetValues(typeof(LineCap)))
            {
                cmbStartCap.Items.Add(lineCap);
                cmbEndCap.Items.Add(lineCap);
            }   
            cmbStartCap.SelectedIndex = 0;
            cmbEndCap.SelectedIndex = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Graphics graphics = e.Graphics;
            using (Pen pen = new Pen(Color.Red, (float)numWidth.Value))
            {
                pen.DashStyle = (DashStyle)cmbDashStyle.SelectedItem;
                pen.DashCap = (DashCap)cmbDashCap.SelectedItem;
                pen.LineJoin = (LineJoin)cmbLineJoin.SelectedItem;
                pen.StartCap = (LineCap)cmbStartCap.SelectedItem;
                pen.EndCap = (LineCap)cmbEndCap.SelectedItem;
                graphics.DrawLine(pen, 10, 10, 100, 100);
                Point[] points =
                    {
                        new Point(100, 120),  // Điểm 1
                        new Point(160, 250),  // Điểm 2
                        new Point(220, 120)   // Điểm 3
                    };
                graphics.DrawLines(pen, points);
            }
        }

        private void numWidth_ValueChanged(object sender, EventArgs e)
        {
            if (panel1 != null)
            {
                panel1.Invalidate();
            }
        }

        private void cmbLineJoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (panel1 != null)
            {
                panel1.Invalidate();
            }
        }

        private void cmbDashCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (panel1 != null)
            {
                panel1.Invalidate();
            }
        }

        private void cmbStartCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (panel1 != null)
            {
                panel1.Invalidate();
            }
        }

        private void cmbEndCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (panel1 != null)
            {
                panel1.Invalidate();
            }
        }
    }
}
