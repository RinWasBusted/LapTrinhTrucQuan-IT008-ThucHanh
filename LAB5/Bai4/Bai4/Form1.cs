using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbBold_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBold.Checked)
            {
                txtSample.Font = new Font(txtSample.Font, txtSample.Font.Style | FontStyle.Bold);
            }
            else
            {
                txtSample.Font = new Font(txtSample.Font, txtSample.Font.Style & ~FontStyle.Bold);
            }
        }

        private void cbItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (cbItalic.Checked)
            {
                txtSample.Font = new Font(txtSample.Font, txtSample.Font.Style | FontStyle.Italic);
            }
            else
            {
                txtSample.Font = new Font(txtSample.Font, txtSample.Font.Style & ~FontStyle.Italic);
            }
        }

        private void cbUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUnderline.Checked)
            {
                txtSample.Font = new Font(txtSample.Font, txtSample.Font.Style | FontStyle.Underline);
            }
            else
            {
                txtSample.Font = new Font(txtSample.Font, txtSample.Font.Style & ~FontStyle.Underline);
            }
        }

        private void radioLeftAlign_CheckedChanged(object sender, EventArgs e)
        {
            if(radioLeftAlign.Checked)
            {
                txtSample.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void radioCenterAlign_CheckedChanged(object sender, EventArgs e)
        {
            if(radioCenterAlign.Checked)
            {
                txtSample.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void radioRightAlign_CheckedChanged(object sender, EventArgs e)
        {
            if(radioRightAlign.Checked)
            {
                txtSample.TextAlign = HorizontalAlignment.Right;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                txtSample.ForeColor = colorDialog.Color;
                btnColor.BackColor = colorDialog.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var fontFamilies = System.Drawing.FontFamily.Families;
            foreach (var fontFamily in fontFamilies)
            {
                cmbFont.Items.Add(fontFamily.Name);
            }
            cmbFont.SelectedItem = txtSample.Font.FontFamily.Name;
        }

        private void cmbSize_SelectedValueChanged(object sender, EventArgs e)
        {
            txtSample.Font = new Font(txtSample.Font.FontFamily, float.Parse(cmbSize.SelectedItem.ToString()), txtSample.Font.Style);
        }

        private void cmbFont_SelectedValueChanged(object sender, EventArgs e)
        {
            txtSample.Font = new Font(cmbFont.SelectedItem.ToString(), txtSample.Font.Size, txtSample.Font.Style);
        }

        private void cmbSize_TextChanged(object sender, EventArgs e)
        {
            txtSample.Font = new Font(txtSample.Font.FontFamily, float.Parse(cmbSize.Text), txtSample.Font.Style);
        }
    }
}
