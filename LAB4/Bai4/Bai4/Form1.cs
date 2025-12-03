using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        private string currentFilePath = "";
        public Form1()
        {
            InitializeComponent();
            cmbFont.Items.AddRange(FontFamily.Families.Select(f => f.Name).ToArray());
            cmbSize.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" });
            cmbFont.SelectedItem = "Tahoma";
            cmbSize.SelectedItem = "14";
        }
        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(cmbFont.SelectedItem.ToString(), richTextBox1.Font.Size);
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.Name, float.Parse(cmbSize.SelectedItem.ToString()));
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.SelectionFont;
            fontDialog1.Color = richTextBox1.SelectionColor;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                cmbFont.SelectedItem = fontDialog1.Font.Name;
                string sizeText = fontDialog1.Font.Size.ToString();
                if (!cmbSize.Items.Contains(sizeText))
                {
                    cmbSize.Items.Add(sizeText);
                }
                cmbSize.SelectedItem = sizeText;
            }

        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            currentFilePath = "";
        }

        private void cmbFont_Click(object sender, EventArgs e)
        {

        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog1.FileName;
                try
                {
                    if(Path.GetExtension(currentFilePath).ToLower() == ".rtf")
                    {
                        richTextBox1.LoadFile(currentFilePath, RichTextBoxStreamType.RichText);
                    } else
                    {
                        richTextBox1.LoadFile(currentFilePath, RichTextBoxStreamType.PlainText);
                    }
                } 
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi khi mở tập tin: " + ex.Message);
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "Rich Text Format (*.rtf)|*.rtf";
                
                if(sv.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = sv.FileName;
                    richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                    MessageBox.Show("Lưu tập tin thành công!");
                }
            }
            else
            {
                richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                MessageBox.Show("Lưu tập tin thành công!");
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChangeFontStyle(FontStyle style)
        {
            if(richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newStyle;

                if (currentFont.Style.HasFlag(style))
                {
                    newStyle = currentFont.Style & ~style;
                } else
                {
                    newStyle = currentFont.Style | style;
                }
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Bold);
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Italic);
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
             ChangeFontStyle(FontStyle.Underline);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            currentFilePath = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "Rich Text Format (*.rtf)|*.rtf";

                if (sv.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = sv.FileName;
                    richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                    MessageBox.Show("Lưu tập tin thành công!");
                }
            }
            else
            {
                richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                MessageBox.Show("Lưu tập tin thành công!");
            }
        }
    }
}
