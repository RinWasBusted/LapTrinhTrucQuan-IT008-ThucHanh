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

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string sourcePath = tbNguon.Text;
            string destPath = tbDich.Text;
            if (string.IsNullOrWhiteSpace(sourcePath) || string.IsNullOrWhiteSpace(destPath))
            {
                MessageBox.Show("Vui lòng chọn cả thư mục nguồn và thư mục đích.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sourcePath == destPath)
            {
                MessageBox.Show("Thư mục nguồn và thư mục đích không được giống nhau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(sourcePath))
            {
                MessageBox.Show("Thư mục nguồn không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(destPath))
            {
                MessageBox.Show("Thư mục đích không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string[] files = Directory.GetFiles(sourcePath);
                int fileCount = files.Length;

                if (fileCount == 0)
                {
                    MessageBox.Show("Thư mục nguồn không có tệp tin nào để sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                progressBar1.Minimum = 0;
                progressBar1.Maximum = fileCount;
                progressBar1.Value = 0;

                button1.Enabled = false;

                await Task.Run(() =>
                {
                    for (int i = 0; i < fileCount; i++)
                    {
                        string fileName = Path.GetFileName(files[i]);
                        string destFile = Path.Combine(destPath, fileName);
                        File.Copy(files[i], destFile, true);
                        this.Invoke(new Action(() =>
                        {
                            progressBar1.Value = i + 1;
                            copyStatus.Text = "Đang sao chép: " + fileName;
                            toolTip1.SetToolTip(toolStrip1, "Đang sao chép: " + fileName);
                        }));
                        System.Threading.Thread.Sleep(1000); // Giả lập thời gian sao chép
                    }
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình sao chép: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                button1.Enabled = true;
                copyStatus.Text = "Hoàn thành!";
                toolTip1.SetToolTip(toolStrip1, "Hoàn thành sao chép");
            }
        }

        private void btnNguon_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Chọn thư mục nguồn";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbNguon.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnDich_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Chọn thư mục đích";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbDich.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
