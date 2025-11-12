using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        const int GIA_LO_A = 5000;
        const int GIA_LO_B = 6500;
        const int GIA_LO_C = 8000;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGhe_Click(object sender, EventArgs e)
        {
            Button ghe = (Button)sender;

            if(ghe.BackColor == Color.White)
            {
                ghe.BackColor = Color.Blue;
            } else if(ghe.BackColor == Color.Blue)
            {
                ghe.BackColor = Color.White;
            } else if(ghe.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đã được đặt, vui lòng chọn ghế khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int tongTien = 0;

            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                if (ctrl is Button)
                {
                    Button ghe = (Button)ctrl;
                    if (ghe.BackColor == Color.Blue)
                    {
                        ghe.BackColor = Color.Yellow;
                        int soGhe = int.Parse(ghe.Text);

                        if (soGhe <= 5)
                        {
                            tongTien += GIA_LO_A;
                        }
                        else if (soGhe <= 10)
                        {
                            tongTien += GIA_LO_B;
                        }
                        else
                        {
                            tongTien += GIA_LO_C;
                        }
                    }
                }
            }
            int tienDaCo = 0;
            
            if(!string.IsNullOrEmpty(tbThanhTien.Text))
            {
                tienDaCo = int.Parse(tbThanhTien.Text);
            }

            tbThanhTien.Text = (tienDaCo + tongTien).ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in tableLayoutPanel1.Controls)
            {
                if (ctrl is Button)
                {
                    Button ghe = (Button)ctrl;
                    if (ghe.BackColor == Color.Blue)
                    {
                        ghe.BackColor = Color.White;
                    }
                }
                tbThanhTien.Text = "0";
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
