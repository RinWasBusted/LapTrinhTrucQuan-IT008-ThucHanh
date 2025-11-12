using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        double giaTriDau = 0;
        string phepToan = "";
        bool daNhanPhepToan = false;
        double memoryValue = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(txtDisplay.Text == "0" || daNhanPhepToan)
            {
                txtDisplay.Text = btn.Text;
                daNhanPhepToan = false;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            giaTriDau = double.Parse(txtDisplay.Text);

            phepToan = btn.Text; 
            
            daNhanPhepToan = true;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            giaTriDau = 0;
            phepToan = "";
            daNhanPhepToan = false;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text.Length > 1)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
            else
            {
                txtDisplay.Text = "0";
            }
        }

        private void btnDoiDau_Click(object sender, EventArgs e)
        {
            double giaTriHienTai = double.Parse(txtDisplay.Text);
            giaTriHienTai = -giaTriHienTai;
            txtDisplay.Text = giaTriHienTai.ToString();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double giaTriHienTai = double.Parse(txtDisplay.Text);
            giaTriHienTai = Math.Sqrt(giaTriHienTai);
            txtDisplay.Text = giaTriHienTai.ToString();
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            double GiaTriHienTai = double.Parse(txtDisplay.Text);
            double ketQua = 0;
            switch (phepToan)
            {
                case "+":
                    ketQua = giaTriDau + GiaTriHienTai;
                    break;
                case "-":
                    ketQua = giaTriDau - GiaTriHienTai;
                    break;
                case "*":
                    ketQua = giaTriDau * GiaTriHienTai;
                    break;
                case "/":
                    if (GiaTriHienTai != 0)
                    {
                        ketQua = giaTriDau / GiaTriHienTai;
                    }
                    else
                    {
                        MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
            }
            txtDisplay.Text = ketQua.ToString();
            giaTriDau = ketQua;
            daNhanPhepToan = false;
            phepToan = "";
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memoryValue = 0;
            lblMemoryStatus.Text = "";
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            memoryValue = double.Parse(txtDisplay.Text);
            lblMemoryStatus.Text = "M";
            daNhanPhepToan = true;
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            memoryValue += double.Parse(txtDisplay.Text);   
            lblMemoryStatus.Text = "M";
            daNhanPhepToan = true;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memoryValue.ToString();
            daNhanPhepToan = true;
        }
    }
}
