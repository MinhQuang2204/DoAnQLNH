using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HoaDonDTO
    {
        private string MaHD;
        private int MaKH;
        private int MaNV;
        private DateTime NgayIn;

        public string mahd
        {
            get
            {
                return MaHD;
            }
            set
            {
                MaHD = value;
            }
        }
        public int makh
        {
            get
            {
                return MaKH;
            }
            set
            {
                MaKH = value;
            }
        }
        public int manv
        {
            get
            {
                return MaNV;
            }
            set
            {
                MaNV = value;
            }
        }
        public DateTime ngayin
        {
            get
            {
                return NgayIn;
            }
            set
            {
                NgayIn = value;
            }
        }
        public HoaDonDTO(string maHD, int maKH, int maNV, DateTime ngayIn)
        {
            mahd = maHD;
            makh = maKH;
            manv = maNV;
            ngayin = ngayIn;
        }
    }
}
