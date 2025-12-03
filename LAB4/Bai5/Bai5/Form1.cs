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

        private void button1_Click(object sender, EventArgs e)
        {
            FormThemSV formThemSV = new FormThemSV();
            formThemSV.ShowDialog();
            if (formThemSV.DialogResult == DialogResult.OK)
            {
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow newRow = dataGridView1.Rows[rowIndex];
                newRow.Cells["stt"].Value = dataGridView1.Rows.Count - 1;
                newRow.Cells["mssv"].Value = formThemSV.mssv;
                newRow.Cells["tensv"].Value = formThemSV.tensv;
                newRow.Cells["khoa"].Value = formThemSV.khoa;
                newRow.Cells["diemtb"].Value = formThemSV.diemtb;
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filterText = this.textBox1.Text.Trim().ToLower();

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue; 
                string tensv = row.Cells["tensv"].Value?.ToString().ToLower() ?? "";
                row.Visible = tensv.Contains(filterText);
            }
        }
    }
}
