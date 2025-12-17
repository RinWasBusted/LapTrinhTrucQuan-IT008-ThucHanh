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

namespace Bai11
{
    public partial class Form1 : Form
    {
        public string selectedShape = "Line";
        public Color selectedColor = Color.Black;
        public string selectedBrush = "Solid";
        public struct Line
        {
            public Point start;
            public Point end;
            public Color color;
            public float width;
        }
        public struct Shape
        {
            public string type; // "Rectangle" or "Ellipse"
            public Rectangle rect;
            public Color color;
            public float width;
            public string brushType; // "Solid" or "Hatch"
        }
        public List<Line> lines = new List<Line>();
        public List<Shape> shapes = new List<Shape>();
        public bool isDrawing = false;
        public Point startPoint;
        public Point endPoint;
        public Form1()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered",
        System.Reflection.BindingFlags.SetProperty |
        System.Reflection.BindingFlags.Instance |
        System.Reflection.BindingFlags.NonPublic,
        null, panel1, new object[] { true });
        }

        private void radioLine_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLine.Checked)
            {
                selectedShape = "Line";
            }
        }

        private void radioRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRectangle.Checked)
            {
                selectedShape = "Rectangle";
            }
        }

        private void radioEllipse_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEllipse.Checked)
                selectedShape = "Ellipse";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (var line in lines)
            {
                Pen pen = new Pen(line.color, line.width);
                pen.Color = line.color;
                pen.Width = line.width;
                g.DrawLine(pen, line.start, line.end);
            }
            foreach (var shape in shapes)
            {
                Pen pen = new Pen(shape.color, shape.width);
                Brush brush;
                if (shape.brushType == "Solid")
                {
                    brush = new SolidBrush(Color.Green);
                }
                else if (shape.brushType == "Hatch") // Hatch
                {
                    brush = new HatchBrush(HatchStyle.Cross, Color.Blue, Color.Green);
                } else if(shape.brushType == "Texture") // Texture
                {
                    Bitmap bmp = Properties.Resources.bold_text_option1;
                    brush = new TextureBrush(bmp);
                }
                else // Gradient
                {
                    brush = new LinearGradientBrush(shape.rect, Color.Red, Color.Green, LinearGradientMode.Horizontal);
                }
                if (shape.type == "Rectangle")
                {
                    g.FillRectangle(brush, shape.rect);
                    g.DrawRectangle(pen, shape.rect);
                }
                else if (shape.type == "Ellipse")
                {
                    g.FillEllipse(brush, shape.rect);
                    g.DrawEllipse(pen, shape.rect);
                }
            }
            if (isDrawing)
            {
                Pen pen = new Pen(selectedColor, (float)numWidth.Value);
                pen.DashStyle = DashStyle.DashDot;
                Rectangle rect = new Rectangle(
                    Math.Min(startPoint.X, endPoint.X),
                    Math.Min(startPoint.Y, endPoint.Y),
                    Math.Abs(endPoint.X - startPoint.X),
                    Math.Abs(endPoint.Y - startPoint.Y));
                if (selectedShape == "Line")
                {
                    g.DrawLine(pen, startPoint, endPoint);
                }
                else if (selectedShape == "Rectangle")
                {
                    g.DrawRectangle(pen, rect);
                }
                else if (selectedShape == "Ellipse")
                {
                    g.DrawEllipse(pen, rect);
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = e.Location;
            endPoint = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                panel1.Invalidate();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                endPoint = e.Location;
                if (selectedShape == "Line")
                {
                    Line line = new Line
                    {
                        start = startPoint,
                        end = endPoint,
                        color = selectedColor,
                        width = (float)numWidth.Value
                    };
                    lines.Add(line);
                }
                else
                {
                    Rectangle rect = new Rectangle(
                        Math.Min(startPoint.X, endPoint.X),
                        Math.Min(startPoint.Y, endPoint.Y),
                        Math.Abs(endPoint.X - startPoint.X),
                        Math.Abs(endPoint.Y - startPoint.Y));
                    Shape shape = new Shape
                    {
                        type = selectedShape,
                        rect = rect,
                        color = selectedColor,
                        width = (float)numWidth.Value,
                        brushType = selectedBrush
                    };
                    shapes.Add(shape);
                }
                panel1.Invalidate();
            }
        }

        private void radioSolid_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSolid.Checked)
            {
                selectedBrush = "Solid";
            }
        }

        private void radioHatch_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHatch.Checked)
            {
                selectedBrush = "Hatch";
            }
        }

        private void radioTexture_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTexture.Checked)
            {
                selectedBrush = "Texture";
            }
        }

        private void radioGradient_CheckedChanged(object sender, EventArgs e)
        {
            if (radioGradient.Checked)
            {
                selectedBrush = "Gradient";
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog.Color;
            }
        }
    }
}