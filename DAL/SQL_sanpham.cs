using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entitys;
namespace DAL
{
    public class SQL_sanpham
    {
        ketnoi kn = new ketnoi();
        public void suadulieu(EC_sanpham ec)
        {
            kn.ThucThiCauLenhSQL("update sanpham set giaban='" + ec.Giaban+ "' where maSP='" + ec.MaSP + "'");
        }
        public void xoadulieu(EC_sanpham ec)
        {
            kn.ThucThiCauLenhSQL("delete sanpham where maSP='" + ec.MaSP + "'");
        }
        public DataTable taobang(string dieukien)
        {
            return kn.GetDataTable("select * from sanpham " + dieukien);
        }
    }
}
