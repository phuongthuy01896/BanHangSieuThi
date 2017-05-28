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
    public class BUS_nhaphang
    {
        SQL_nhaphang sql = new SQL_nhaphang();
        public void themdulieu(EC_phieunhap ec)
        {
            sql.thempn(ec);
        }
        public DataTable taobang(string dieukien)
        {
            return sql.taobang(dieukien);
        }
        public void xoapn(EC_phieunhap ec)
        {
            sql.xoapn(ec);
        }
        public void themchitietpn(EC_chitietpn ec)
        {
            sql.themchitietpn(ec);
        }
        public void suadulieu(EC_chitietpn ec)
        {
            sql.suadulieu(ec);
        }
        public void xoachitietpn(EC_chitietpn ec)
        {
            sql.xoachitietpn(ec);
        }
        public DataTable taobangchitiet(string dieukien)
        {
            return sql.taobangchitiet(dieukien);
        }
    }
}
