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
    public partial class HoaDonChuyenTien : Form
    {
        public HoaDonChuyenTien()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void HoaDonChuyenTien_Load(object sender, EventArgs e)
        {
            label9.Text = HoatDong.LuuThongTin.ten;
            label10.Text = HoatDong.LuuThongTin.ten1;
            label11.Text = HoatDong.LuuThongTin.ten2;
            label12.Text = HoatDong.LuuThongTin.ten3;
            label13.Text = HoatDong.LuuThongTin.ten4;
            label14.Text = HoatDong.LuuThongTin.ten5;
            label15.Text = HoatDong.LuuThongTin.ten6;          
        }
    }
}
