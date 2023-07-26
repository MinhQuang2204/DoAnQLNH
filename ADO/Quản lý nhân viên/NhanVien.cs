using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Quản_lý_nhân_viên
{
    public partial class NhanVien : Form
    {
        //private int MaNV1;
        //private string HoNV1;
        //private string TenLot1;
        //private string TenNV1;
        //private string DiaChi1;
        //private int SDT1;
        //private int CMND1;
        //private string ChucVu1;
        //private string Luong1;
        //private int Phong1;
     
            
        public NhanVien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {          
            dgvNhanVien.DataSource = NhanVienBUS.GetAllNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int mnv = int.Parse(txtMaNV.Text);
                string hnv = txtHoNV.Text;
                string tenlot = txtTenLot.Text;
                string tennhanvien = txtTenNV.Text;
                string diachi = txtDiaChi.Text;
                int sdt = int.Parse(txtSDT.Text);
                int cmnd = int.Parse(txtCMND.Text);
                string chucvu = txtChucVu.Text;
                string luong = txtLuong.Text;
                int phong = int.Parse(txtPhong.Text);
                NhanVienDTO nhanvien = new NhanVienDTO(mnv,hnv, tenlot,tennhanvien,diachi,sdt,cmnd,chucvu,luong,phong);
                NhanVienBUS.InsertNhanVien(nhanvien);
                MessageBox.Show("Bạn đã thêm thành công");
                dgvNhanVien.DataSource = NhanVienBUS.GetAllNhanVien();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int manv = int.Parse(txtMaNV.Text);
                string hnv = txtHoNV.Text;
                string tenlot = txtTenLot.Text;
                string tennhanvien = txtTenNV.Text;
                string diachi = txtDiaChi.Text;
                int sdt = int.Parse(txtSDT.Text);
                int cmnd = int.Parse(txtCMND.Text);
                string chucvu = txtChucVu.Text;
                string luong = txtLuong.Text;
                int phong = int.Parse(txtPhong.Text);
                NhanVienDTO nhanvien = new NhanVienDTO(manv, hnv,tenlot, tennhanvien, diachi, sdt, cmnd, chucvu, luong, phong);
                NhanVienBUS.DeleteNhanVien(manv);
                MessageBox.Show("Bạn đã xóa thành công");
                dgvNhanVien.DataSource = NhanVienBUS.GetAllNhanVien();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtHoNV.Text = row.Cells[1].Value.ToString();
                txtTenLot.Text = row.Cells[2].Value.ToString();
                txtTenNV.Text = row.Cells[3].Value.ToString();
                txtDiaChi.Text = row.Cells[4].Value.ToString();
                txtSDT.Text = row.Cells[5].Value.ToString();
                txtCMND.Text = row.Cells[6].Value.ToString();
                txtChucVu.Text = row.Cells[7].Value.ToString();
                txtLuong.Text = row.Cells[8].Value.ToString();
                txtPhong.Text = row.Cells[9].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnsSua_Click(object sender, EventArgs e)
        {
            try
            {
                int mnv = int.Parse(txtMaNV.Text);
                string hnv = txtHoNV.Text;
                string tenlot = txtTenLot.Text;
                string tennhanvien = txtTenNV.Text;
                string diachi = txtDiaChi.Text;
                int sdt = int.Parse(txtSDT.Text);
                int cmnd = int.Parse(txtCMND.Text);
                string chucvu = txtChucVu.Text;
                string luong = txtLuong.Text;
                int phong = int.Parse(txtPhong.Text);
                NhanVienDTO nhanvien = new NhanVienDTO(mnv, hnv, tenlot, tennhanvien, diachi, sdt, cmnd, chucvu, luong, phong);
                NhanVienBUS.UpdateNhanVien(nhanvien);
                MessageBox.Show("Bạn đã sửa thành công");
                dgvNhanVien.DataSource = NhanVienBUS.GetAllNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtHoNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTenLot.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtCMND.Text = dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtChucVu.Text = dgvNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtLuong.Text = dgvNhanVien.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtPhong.Text = dgvNhanVien.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Focus();
            txtMaNV.Text = "";
            txtHoNV.Text = "";
            txtTenLot.Text = "";
            txtTenNV.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtCMND.Text = "";
            txtChucVu.Text = "";
            txtLuong.Text = "";
            txtPhong.Text = "";
        }
    }
}
