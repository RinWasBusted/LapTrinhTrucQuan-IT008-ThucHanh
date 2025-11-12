using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            this.tbAnswer.Text = (double.Parse(this.tbNum1.Text) + double.Parse(this.tbNum2.Text)).ToString();
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            this.tbAnswer.Text = (double.Parse(this.tbNum1.Text) - double.Parse(this.tbNum2.Text)).ToString();
        }

        private void btMul_Click(object sender, EventArgs e)
        {
            this.tbAnswer.Text = (double.Parse(this.tbNum1.Text) * double.Parse(this.tbNum2.Text)).ToString();
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            if(this.tbNum2.Text == "0")
            {
                MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.tbAnswer.Text = (double.Parse(this.tbNum1.Text) / double.Parse(this.tbNum2.Text)).ToString();
        }
    }
}
