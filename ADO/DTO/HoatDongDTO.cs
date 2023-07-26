using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HoatDongDTO
    {
        private string maGD;
        private int ST;
        private DateTime Ngay;
        public string magd
        {
            get
            {
                return maGD;
            }
            set
            {
                maGD = value;
            }
        }
        public int st
        {
            get
            {
                return ST;
            }
            set
            {
                ST = value;
            }
        }
        public DateTime ngay
        {
            get
            {
                return Ngay;
            }
            set
            {
                Ngay = value;
            }
        }

        public HoatDongDTO(string MaGD, int SoT, DateTime NGAY)
        {
            maGD = MaGD;
            ST = SoT;
            Ngay = NGAY;
        }
    }
}
