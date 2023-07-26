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
    public partial class KhachHang : Form
    {
       

        public KhachHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = KhachHangBUS.GetAlllKhachHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int mkh = int.Parse(txtMaKH.Text);
                string hkh = txtHoKH.Text;
                string tenlot = txtTenLot.Text;
                string tenkhachhang = txtTenKH.Text;
                string diachi = txtDiaChi.Text;
                int cmnd = int.Parse(txtCMND.Text);
                int sdt = int.Parse(txtSDT.Text);
                KhachHangDTO khachhang = new KhachHangDTO(mkh, hkh, tenlot, tenkhachhang, diachi, cmnd, sdt);
                KhachHangBUS.InsertKhachHang(khachhang);
                MessageBox.Show("Bạn đã thêm thành công");
                dgvKhachHang.DataSource = KhachHangBUS.GetAlllKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtHoKH.Text = row.Cells[1].Value.ToString();
                txtTenLot.Text = row.Cells[2].Value.ToString();
                txtTenKH.Text = row.Cells[3].Value.ToString();
                txtDiaChi.Text = row.Cells[4].Value.ToString();
                txtCMND.Text = row.Cells[6].Value.ToString();
                txtSDT.Text = row.Cells[5].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int mkh = int.Parse(txtMaKH.Text);
                string hkh = txtHoKH.Text;
                string tenlot = txtTenLot.Text;
                string tenkhachhang = txtTenKH.Text;
                string diachi = txtDiaChi.Text;               
                int cmnd = int.Parse(txtCMND.Text);
                int sdt = int.Parse(txtSDT.Text);        
                KhachHangDTO khachhang = new KhachHangDTO(mkh,hkh,tenlot,tenkhachhang,diachi,cmnd,sdt);
                KhachHangBUS.UpdateKhachHang(khachhang);
                MessageBox.Show("Bạn đã sửa thành công");
                dgvKhachHang.DataSource = KhachHangBUS.GetAlllKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Focus();
            txtMaKH.Text = "";
            txtHoKH.Text = "";
            txtTenLot.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";
            txtSDT.Text = "";
        }

        private void dgvKhachHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtHoKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTenLot.Text = dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTenKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCMND.Text = dgvKhachHang.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtSDT.Text = dgvKhachHang.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
