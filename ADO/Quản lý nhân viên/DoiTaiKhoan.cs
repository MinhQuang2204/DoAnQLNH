using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quản_lý_nhân_viên
{
    public partial class DoiTaiKhoan : Form
    {
      
        public DoiTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLyNganHang;Integrated Security=True");
        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select count (*) from NguoiDung where TaiKhoan = N'"+txtTaiKhoan1.Text+"' and MatKhau = N'"+txtMatKhau1.Text+"'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            errorProvider1.Clear();
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (txtMatKhauMoi1.Text == txtNhapLai1.Text)
                {
                    if (txtMatKhauMoi1.Text.Length > 8)
                    {
                        SqlDataAdapter da1 = new SqlDataAdapter("update NguoiDung set MatKhau = N'" + txtMatKhauMoi1.Text + "' where TaiKhoan = N'" +txtTaiKhoan1.Text + "' and MatKhau = N'" +txtMatKhau1.Text +"'", cn);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        MessageBox.Show("Đổi mật khẩu thành công");
                    }
                    else
                    {
                        errorProvider1.SetError(txtMatKhauMoi1, "Độ dài không hợp lệ");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtMatKhauMoi1, "Bạn chưa nhập mật khẩu mới");
                    errorProvider1.SetError(txtNhapLai1, "Mật khẩu nhập lại chưa đúng");

                }
            }
            else
            {
                errorProvider1.SetError(txtTaiKhoan1, "Tên đặng nhập không đúng");
                errorProvider1.SetError(txtMatKhau1, "Mật khẩu cũ không đúng");
            }
        }

        private void DoiTaiKhoan_Load(object sender, EventArgs e)
        {
             
        }
    }
}
