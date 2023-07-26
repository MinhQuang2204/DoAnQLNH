using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class GiaoDichDTO
    {
        private string MaHD;
        private DateTime NgayTh;
        private DateTime NgayKT;
        private string MaGD;

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
        public DateTime ngayth
        {
            get
            {
                return NgayTh;
            }
            set
            {
                NgayTh = value;
            }
        }
        public DateTime ngaykt
        {
            get
            {
                return NgayKT;
            }
            set
            {
                NgayKT = value;
            }
        }
        public string magd
        {
            get
            {
                return MaGD;
            }
            set
            {
                MaGD = value;
            }
        }
        public GiaoDichDTO(string maHD, DateTime ngayTH, DateTime ngayKT, string maGD)
        {
            mahd = maHD;
            ngayth = ngayTH;
            ngaykt = ngayKT;
            magd = maGD;
        }

    }
}
