using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace Quản_lý_nhân_viên
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLyNganHang;Integrated Security=True");
            try
            {
                Conn.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string sql = "select *from NguoiDung where TaiKhoan='" + tk + "' and MatKhau='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, Conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (txtTaiKhoan.Text != null && txtMatKhau.Text != null)
                {

                    if (dta.Read() == true && txtTaiKhoan.Text != null && txtMatKhau.Text != null)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        GiaoDien a = new GiaoDien();
                        this.Hide();
                        a.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result  = MessageBox.Show("Bạn có chắc muốn thoát không?",
                "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
