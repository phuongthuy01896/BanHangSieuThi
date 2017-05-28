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
    public class BUS_khachhang
    {
        SQL_khachhang sql = new SQL_khachhang();
        public void themdulieu(EC_khachhang ec)
        {
            sql.themdulieu(ec);
        }
        public void suadulieu(EC_khachhang ec)
        {
            sql.suadulieu(ec);
        }
        public void xoadulieu(EC_khachhang ec)
        {
            sql.xoadulieu(ec);
        }
        public DataTable taobang(string dieukien)
        {
            return sql.taobang(dieukien);
        }
    }
}
