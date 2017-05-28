using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    public class EC_phieunhap
    {
        private string mapn;
        private DateTime ngaynhap;
        private string maNV;

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

        public DateTime Ngaynhap
        {
            get
            {
                return ngaynhap;
            }

            set
            {
                ngaynhap = value;
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
