using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ResetForm()
        {
            tbMaSinhVien.Clear();
            tbHoTen.Clear();
            cmbChuyenNganh.SelectedIndex = 0; 
            radNam.Checked = false;
            radNu.Checked = false;

            foreach (var item in lstMonHocDaChon.Items)
            {
                lstMonHocChuaChon.Items.Add(item);
            }
            lstMonHocDaChon.Items.Clear(); 

            tbMaSinhVien.Focus(); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lstMonHocChuaChon.Items.Add("Cơ Sở Dữ Liệu"); 
            lstMonHocChuaChon.Items.Add("Cơ Sở Dữ Liệu NC"); 
            lstMonHocChuaChon.Items.Add("PTTK Hệ Thống thông tin"); 
            lstMonHocChuaChon.Items.Add("Lập Trình Trực Quan");
            lstMonHocChuaChon.Items.Add("Cấu Trúc Dữ Liệu");

            dgvSinhVien.Columns.Add("MSSV", "MSSV");
            dgvSinhVien.Columns.Add("HoTen", "Họ Tên");
            dgvSinhVien.Columns.Add("ChuyenNganh", "Chuyên Ngành");
            dgvSinhVien.Columns.Add("GioiTinh", "Giới Tính");
            dgvSinhVien.Columns.Add("SoMon", "Số Môn");

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            List<Object> selectedItems = new List<Object>();
            foreach (Object item in lstMonHocChuaChon.SelectedItems)
            {
                selectedItems.Add(item);
            }
            foreach (Object item in selectedItems)
            {
                lstMonHocChuaChon.Items.Remove(item);
                lstMonHocDaChon.Items.Add(item);
            }
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            List<object> selectedItems = new List<object>();
            foreach (var item in lstMonHocDaChon.SelectedItems)
            {
                selectedItems.Add(item);
            }

            foreach (var item in selectedItems)
            {
                lstMonHocChuaChon.Items.Add(item);
                lstMonHocDaChon.Items.Remove(item);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaSinhVien.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Sinh Viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMaSinhVien.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ Tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbHoTen.Focus();
                return;
            }

            if (!radNam.Checked && !radNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn Giới Tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mssv = tbMaSinhVien.Text;
            string hoTen = tbHoTen.Text;
            string chuyenNganh = cmbChuyenNganh.SelectedItem.ToString();
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ"; 
            int soMon = lstMonHocDaChon.Items.Count; 

            dgvSinhVien.Rows.Add(mssv, hoTen, chuyenNganh, gioiTinh, soMon);

            ResetForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
