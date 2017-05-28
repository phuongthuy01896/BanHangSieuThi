using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    public class EC_hoadonban
    {
        private string maHDB;
        private string maKH;
        private DateTime ngayban;
        private int tongtien;
        private string maNV;

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

        public string MaKH
        {
            get
            {
                return maKH;
            }

            set
            {
                maKH = value;
            }
        }

        public DateTime Ngayban
        {
            get
            {
                return ngayban;
            }

            set
            {
                ngayban = value;
            }
        }

        public int Tongtien
        {
            get
            {
                return tongtien;
            }

            set
            {
                tongtien = value;
            }
        }

        public string MaNV
        {
            get
            {
                return maNV;
            }

            set
            {
                maNV = value;
            }
        }
    }
}
