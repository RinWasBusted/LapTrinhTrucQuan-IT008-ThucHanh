using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
{
    public partial class Form1 : Form
    {
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
            pictureBox1.Paint += PictureBox1_Paint;
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // Cap nhat moi 1 giay
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate(); // Ve lai PictureBox
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Lay thoi gian hien tai
            DateTime now = DateTime.Now;

            int centerX = pictureBox1.Width / 2;
            int centerY = pictureBox1.Height / 2;

            DrawClockHands(e.Graphics, centerX, centerY, now);
        }

        private void DrawClockHands(Graphics g, int centerX, int centerY, DateTime time)
        {
            double secondAngle = (time.Second * 6) - 90; // 6 do moi giay, -90 de bat dau tu tren
            double minuteAngle = (time.Minute * 6 + time.Second * 0.1) - 90;
            double hourAngle = (time.Hour * 30 + time.Minute * 0.5) - 90; // 30 do moi gio

            int radius = Math.Min(pictureBox1.Width, pictureBox1.Height) / 2 - 40;
            int hourLength = (int)(radius * 0.5);
            int minuteLength = (int)(radius * 0.7);
            int secondLength = (int)(radius * 0.8);

            // Ve kim gio
            DrawHand(g, centerX, centerY, hourAngle, hourLength, 12, Color.White);

            // Ve kim phut
            DrawHand(g, centerX, centerY, minuteAngle, minuteLength, 10, Color.White);

            // Ve kim giay
            DrawHand(g, centerX, centerY, secondAngle, secondLength, 2, Color.White);

            // Ve tam dong ho
            g.FillEllipse(new SolidBrush(Color.White), centerX - 6, centerY - 6, 12, 12);
        }

        private void DrawHand(Graphics g, int centerX, int centerY, double angle, int length, int width, Color color)
        {
            // Chuyen doi goc sang radian
            double radians = angle * Math.PI / 180;

            // Tinh toan cac diem cho hinh dang kim (mui ten)
            int backLength = (int)(length * 0.3);
            int handWidth = width / 2;

            // Diem truoc cua kim (mui)
            int frontX = (int)(centerX + length * Math.Cos(radians));
            int frontY = (int)(centerY + length * Math.Sin(radians));

            // Diem sau cua kim
            int backX = (int)(centerX - backLength * Math.Cos(radians));
            int backY = (int)(centerY - backLength * Math.Sin(radians));

            // Hai diem ben canh kim (de tao do rong)
            double perpendicular = radians + Math.PI / 2;
            int side1X = (int)(centerX + handWidth * Math.Cos(perpendicular));
            int side1Y = (int)(centerY + handWidth * Math.Sin(perpendicular));
            int side2X = (int)(centerX - handWidth * Math.Cos(perpendicular));
            int side2Y = (int)(centerY - handWidth * Math.Sin(perpendicular));

            // Tao polygon cho kim
            Point[] points = new Point[]
            {
                new Point(frontX, frontY),           // Mui kim
                new Point(side1X, side1Y),          // Ben trai
                new Point(backX, backY),            // Phan sau
                new Point(side2X, side2Y)           // Ben phai
            };

            // Ve kim
            using (Brush brush = new SolidBrush(color))
            {
                g.FillPolygon(brush, points);
            }
        }

    }
}
