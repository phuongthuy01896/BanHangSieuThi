using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using Entitys;

namespace BUS
{
    public class BUS_hoadonban
    {
        SQL_hoadonban sql = new SQL_hoadonban();
        public void themdulieu(EC_hoadonban ec)
        {
            sql.themdulieu(ec);
        }
        public void themchitiet(EC_chitiethoadon ec)
        {
            sql.themchitiet(ec);
        }
        public void suachitiet(EC_chitiethoadon ec)
        {
            sql.suadulieu(ec);
        }
        public void xoadulieu(EC_chitiethoadon ec)
        {
            sql.xoadulieu(ec);
        }
        public DataTable taobang(string dieukien)
        {
            return sql.taobang(dieukien);
        }
    }
}
