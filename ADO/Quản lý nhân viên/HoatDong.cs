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
    public partial class HoatDong : Form
    {

        public HoatDong()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        public class LuuThongTin
        {
            static public DateTime ngayTh;
            static public string ten = "";
            static public string ten1 = "";
            static public string ten2 = "";
            static public string ten3 = "";
            static public string ten4 = "";
            static public string ten5 = "";
            static public string ten6 = "";
            static public string nv = "";
        }
        private string MaGDCreate()
        {
            DateTime now = DateTime.Now;
            string maGD = now.Year.ToString() + now.DayOfYear.ToString()+ now.Hour.ToString()+ now.Minute.ToString()+ now.Second.ToString()
                + LuuThongTin.ten1;
            for(int i = LuuThongTin.ten.Length; i>0 ; i--)
            {
                Random ind = new Random();
                maGD += LuuThongTin.ten[ind.Next(0, i)];
            }
            return maGD;
        }
        private string MaHDCreate()
        {
            DateTime now = DateTime.Now;
            string maHD = LuuThongTin.ten2 + now.Second.ToString() ;
            for (int i = 2; i > 0; i--)
            {
                Random ind = new Random();
                maHD += LuuThongTin.ten[ind.Next(0, i)];
            }
            return maHD;
        }
        private void LuuGiaoDich(string maGD, string maHD, int maKH)
        {
            try
            {
                if (maKH == 0)
                {
                    MessageBox.Show("Không thể thực hiện giao dịch");
                }
                else
                {
                    GiaoDichDTO giaodich = new GiaoDichDTO(maHD, LuuThongTin.ngayTh, DateTime.Now, maGD);
                    GiaoDichBUS.InsertGiaoDich(giaodich);
                    MessageBox.Show("Giao Dịch đã được lưu");
                    HoaDonDTO hoadon = new HoaDonDTO(maHD, maKH, Int32.Parse(LuuThongTin.nv), DateTime.Now);
                    HoaDonBUS.InsertHoaDon(hoadon);
                    MessageBox.Show("Hóa Đơn đã được lưu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }
        private int TimMaKH()
        {  
            int cmnd = int.Parse(LuuThongTin.ten1);
            int makh = KhachHangBUS.GetMaKH(cmnd);
            return makh;     
        }

        private void LuuChuyenTien(string magd, int st, DateTime ngaychuyen)
        {
            HoatDongDTO dl = new HoatDongDTO(magd, st, ngaychuyen);
            HoatDongBUS.InsertChuyenTien(dl);
        }

        private void LuuRutTien(string magd, int st, DateTime ngaychuyen)
        {
            HoatDongDTO dl = new HoatDongDTO(magd, st, ngaychuyen);
            HoatDongBUS.InsertRutTien(dl);
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            LuuThongTin.ten = txtTenKH.Text;
            LuuThongTin.ten1 = txtCMND.Text;
            LuuThongTin.ten2 = txtSTK.Text;
            LuuThongTin.ten3 = txtSoTC.Text;
            LuuThongTin.ten4 = txtTenNN.Text;
            LuuThongTin.ten5 = txtCMND1.Text;
            LuuThongTin.ten6 = txtSTK1.Text;
            LuuThongTin.nv = cboNV.SelectedValue.ToString();
            string magd = MaGDCreate();
            LuuGiaoDich(magd ,MaHDCreate(),TimMaKH());
            LuuChuyenTien(magd, Int32.Parse(LuuThongTin.ten3), LuuThongTin.ngayTh);
            HoaDonChuyenTien a = new HoaDonChuyenTien();
            this.Hide();
            a.ShowDialog();
            this.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LuuThongTin.ten= txtTenKH2.Text;
            LuuThongTin.ten1 = txtCMND2.Text;
            LuuThongTin.ten2 = txtSTK2.Text;
            LuuThongTin.ten3 = txtSoTR2.Text;
            LuuThongTin.nv = cboNV.SelectedValue.ToString();
            string magd = MaGDCreate();
            LuuGiaoDich(magd, MaHDCreate(), TimMaKH());
            LuuRutTien(magd, Int32.Parse(LuuThongTin.ten3), LuuThongTin.ngayTh);
            HoaDonRutTien b = new HoaDonRutTien();
            this.Hide();
            b.ShowDialog();
            this.Show();
        }

        private void HoatDong_Load(object sender, EventArgs e)
        {
            LuuThongTin.ngayTh = DateTime.Now;
            cboNV.DataSource = NhanVienBUS.GetAllNhanVien();
            cboNV.DisplayMember = "MaNV";
            cboNV.ValueMember = "MaNV";
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
