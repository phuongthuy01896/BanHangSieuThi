using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    public class EC_loaiSP
    {
        private string maLH;
        private string tenLH;

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

        public string TenLH
        {
            get
            {
                return tenLH;
            }

            set
            {
                tenLH = value;
            }
        }
    }
}
