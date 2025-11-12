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

        public Form1()
        {
            InitializeComponent();
        }

        private void XoaTruongDuLieu()
        {
            tbSoTaiKhoan.Clear();
            tbTenKhachHang.Clear();
            tbDiaChi.Clear();
            tbSoTien.Clear();
            tbSoTaiKhoan.Focus();
        }

        private void CapNhatSTT()
        {
            for (int i = 0; i < lvTaiKhoan.Items.Count; i++)
            {
                lvTaiKhoan.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }

        private void CapNhatTongTien()
        {
            decimal TongTien = 0;
            foreach(ListViewItem item in lvTaiKhoan.Items)
            {
                if (decimal.TryParse(item.SubItems[4].Text, out decimal soTien))
                {
                    TongTien += soTien;
                }
            }
            tbTongTien.Text = TongTien.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSoTaiKhoan.Text) ||
                string.IsNullOrWhiteSpace(tbTenKhachHang.Text) ||
                string.IsNullOrWhiteSpace(tbDiaChi.Text) ||
                string.IsNullOrWhiteSpace(tbSoTien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal soTien;
            if (!decimal.TryParse(tbSoTien.Text, out soTien))
            {
                MessageBox.Show("Số tiền không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string soTaiKhoan = tbSoTaiKhoan.Text;

            ListViewItem itemTimThay = lvTaiKhoan.FindItemWithText(soTaiKhoan);

            if (itemTimThay != null)
            {
                itemTimThay.SubItems[2].Text = tbTenKhachHang.Text;
                itemTimThay.SubItems[3].Text = tbDiaChi.Text;
                itemTimThay.SubItems[4].Text = soTien.ToString();

                MessageBox.Show("Cập nhật thông tin tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string stt = (lvTaiKhoan.Items.Count + 1).ToString();
                string[] row = { stt, soTaiKhoan, tbTenKhachHang.Text, tbDiaChi.Text, soTien.ToString() };
                ListViewItem item = new ListViewItem(row);
                lvTaiKhoan.Items.Add(item);

                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            XoaTruongDuLieu();

            CapNhatTongTien();

        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            string soTaiKhoanCanXoa = tbSoTaiKhoan.Text;

            if(string.IsNullOrEmpty(soTaiKhoanCanXoa))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem itemCanXoa = lvTaiKhoan.FindItemWithText(soTaiKhoanCanXoa);

            if(itemCanXoa != null)
            {
                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa tài khoản '{soTaiKhoanCanXoa}' không?",
                                                     "Xác nhận xóa",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    itemCanXoa.Remove();
                    CapNhatSTT(); 
                    CapNhatTongTien(); 
                    XoaTruongDuLieu(); 
                    MessageBox.Show("Xóa tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void lvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count > 0)
            {
                ListViewItem item = lvTaiKhoan.SelectedItems[0];
                tbSoTaiKhoan.Text = item.SubItems[1].Text;
                tbTenKhachHang.Text = item.SubItems[2].Text;
                tbDiaChi.Text = item.SubItems[3].Text;
                tbSoTien.Text = item.SubItems[4].Text;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
