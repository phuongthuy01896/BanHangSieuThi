using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    public class EC_sanpham
    {
        private string maSP;
        private string tenSP;
        private string maLH;
        private int soluong;
        private int gianhap;
        private int giaban;
        private string tencc;

        public string MaSP
        {
            get
            {
                return maSP;
            }

            set
            {
                maSP = value;
            }
        }

        public string TenSP
        {
            get
            {
                return tenSP;
            }

            set
            {
                tenSP = value;
            }
        }

        public string MaLH
        {
            get
            {
                return maLH;
            }

            set
            {
                maLH = value;
            }
        }

        public int Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public int Gianhap
        {
            get
            {
                return gianhap;
            }

            set
            {
                gianhap = value;
            }
        }

        public int Giaban
        {
            get
            {
                return giaban;
            }

            set
            {
                giaban = value;
            }
        }

        public string Tencc
        {
            get
            {
                return tencc;
            }

            set
            {
                tencc = value;
            }
        }

    }
}
