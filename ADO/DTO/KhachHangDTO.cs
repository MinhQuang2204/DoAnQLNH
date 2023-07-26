using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class KhachHangDTO
    {       
        private int MaKH;
        private string HoKH;
        private string TenLot;
        private string TenKH;
        private string DiaChi;
        private int CMND;
        private int SDT;

        public int MaKH1
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

        public string HoKH1
        {
            get
            {
                return HoKH;
            }

            set
            {
                HoKH = value;
            }
        }

        public string TenLot1
        {
            get
            {
                return TenLot;
            }

            set
            {
                TenLot = value;
            }
        }

        public string TenKH1
        {
            get
            {
                return TenKH;
            }

            set
            {
                TenKH = value;
            }
        }

        public string DiaChi1
        {
            get
            {
                return DiaChi;
            }

            set
            {
                DiaChi = value;
            }
        }

        public int CMND1
        {
            get
            {
                return CMND;
            }

            set
            {
                CMND = value;
            }
        }

        public int SDT1
        {
            get
            {
                return SDT;
            }

            set
            {
                SDT = value;
            }
        }

        public KhachHangDTO(int maKH, string hoKH, string tenLot, string tenKH, string diaChi, int cMND, int sDT)
        {
            MaKH1 = maKH;
            HoKH1 = hoKH;
            TenLot1 = tenLot;
            TenKH1 = tenKH;
            DiaChi1 = diaChi;
            CMND1 = cMND;
            SDT1 = sDT;
        }
    }
}
