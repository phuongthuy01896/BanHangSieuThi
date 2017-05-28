using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    public class EC_chitietpn
    {
        private string mapn;
        private string tenSP;
        private string tencc;
        private string maLH;
        private int soluong;
        private int dongia;
        private int thanhtien;

        public string Mapn
        {
            get
            {
                return mapn;
            }

            set
            {
                mapn = value;
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

        public int Dongia
        {
            get
            {
                return dongia;
            }

            set
            {
                dongia = value;
            }
        }

        public int Thanhtien
        {
            get
            {
                return thanhtien;
            }

            set
            {
                thanhtien = value;
            }
        }
    }
}
