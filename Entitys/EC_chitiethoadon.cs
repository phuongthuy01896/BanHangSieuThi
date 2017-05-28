using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    public class EC_chitiethoadon
    {
        private string maHDB;
        private string maSP;
        private int soluong;
        private int dongia;
        private int thanhtien;

        public string MaHDB
        {
            get
            {
                return maHDB;
            }

            set
            {
                maHDB = value;
            }
        }

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
