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
    public partial class HoaDonRutTien : Form
    {
        public HoaDonRutTien()
        {
            InitializeComponent();
        }

        private void HoaDonRutTien_Load(object sender, EventArgs e)
        {
            label16.Text = HoatDong.LuuThongTin.ten;
            label17.Text = HoatDong.LuuThongTin.ten1;
            label18.Text = HoatDong.LuuThongTin.ten2;
            label19.Text = HoatDong.LuuThongTin.ten3;
           
        }
    }
}
