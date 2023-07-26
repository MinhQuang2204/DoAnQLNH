using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhanVienDTO
    {
        private int MaNV;
        private string HoNV;
        private string TenLot;
        private string TenNV;
        private string DiaChi;
        private int SDT;
        private int CMND;
        private string ChucVu;
        private string Luong;
        private int Phong;

        public NhanVienDTO(int maNV, string hoNV, string tenLot, string tenNV, string diaChi, int sDT, int cMND, string chucVu, string luong, int phong)
        {
            MaNV = maNV;
            HoNV = hoNV;
            TenLot = tenLot;
            TenNV = tenNV;
            DiaChi = diaChi;
            SDT = sDT;
            CMND = cMND;
            ChucVu = chucVu;
            Luong = luong;
            Phong = phong;
        }

        public int MaNV1
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

        public string HoNV1
        {
            get
            {
                return HoNV;
            }

            set
            {
                HoNV = value;
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

        public string TenNV1
        {
            get
            {
                return TenNV;
            }

            set
            {
                TenNV = value;
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

        public string ChucVu1
        {
            get
            {
                return ChucVu;
            }

            set
            {
                ChucVu = value;
            }
        }

        public string Luong1
        {
            get
            {
                return Luong;
            }

            set
            {
                Luong = value;
            }
        }

        public int Phong1
        {
            get
            {
                return Phong;
            }

            set
            {
                Phong = value;
            }
        } 
    }
}
