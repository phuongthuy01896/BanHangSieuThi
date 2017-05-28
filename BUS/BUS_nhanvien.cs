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
    public class BUS_nhanvien
    {
        SQL_nhanvien sql = new SQL_nhanvien();
        public void themdulieu(EC_nhanvien ec)
        {
            sql.themdulieu(ec);
        }
        public void suadulieu(EC_nhanvien ec)
        {
            sql.suadulieu(ec);
        }
        public void xoadulieu(EC_nhanvien ec)
        {
            sql.xoadulieu(ec);
        }
        public DataTable taobang(string dieukien)
        {
            return sql.taobang(dieukien);
        }
    }
}
