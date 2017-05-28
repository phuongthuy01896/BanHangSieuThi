using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entitys;
using System.Data;
namespace BUS
{
    public class BUS_NguoiDung
    {
        SQL_dangnhap sql = new SQL_dangnhap();
        public void themdulieu(EC_dangnhap ec)
        {
            sql.themdulieu(ec);
        }
        public void suadulieu(EC_dangnhap ec)
        {
            sql.suadulieu(ec);
        }
        public void xoadulieu(EC_dangnhap ec)
        {
            sql.xoadulieu(ec);
        }
        public DataTable taobang(string dieukien)
        {
            return sql.taobang(dieukien);
        }
    }
}
