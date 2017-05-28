using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitys;
using DAL;
using System.Data;
namespace BUS
{
    public class BUS_sanpham
    {
        SQL_sanpham sql = new SQL_sanpham();
        public void suadulieu(EC_sanpham ec)
        {
            sql.suadulieu(ec);
        }
        public void xoadulieu(EC_sanpham ec)
        {
            sql.xoadulieu(ec);
        }
        public DataTable taobang(string dieukien)
        {
            return sql.taobang(dieukien);
        }
    }
}
