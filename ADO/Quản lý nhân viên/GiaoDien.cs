using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quản_lý_nhân_viên
{
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien a = new NhanVien();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang b = new KhachHang();
            this.Hide();
            b.ShowDialog();
            this.Show();
        }

        private void GiaoDien_Load(object sender, EventArgs e)
        {
            
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiTaiKhoan c = new DoiTaiKhoan();
            this.Hide();
            c.ShowDialog();
            this.Show();
        }

        private void chuyểnTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

       
        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hoạtĐộngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HoatDong d = new HoatDong();
            this.Hide();
            d.ShowDialog();
            this.Show();
        }

        private void rútTiềnToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
