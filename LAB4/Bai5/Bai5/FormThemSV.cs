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
    public partial class FormThemSV : Form
    {
        public string mssv;
        public string tensv;
        public string khoa;
        public float diemtb;
        public FormThemSV()
        {
            InitializeComponent();
            this.comboBox1.SelectedItem = this.comboBox1.Items[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mssv = this.textBox1.Text;
                tensv = this.textBox2.Text;
                khoa = this.comboBox1.SelectedItem.ToString();
                diemtb = float.Parse(this.textBox4.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập liệu: " + ex.Message);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
