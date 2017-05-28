using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entitys;
namespace DAL
{
    public class SQL_khachhang
    {
        ketnoi kn = new ketnoi();
        public int themdulieu(EC_khachhang ec)
        {
            string sql = "themkh";
            int so_luong = 5;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@tenkh"; Values[0] = ec.Tenkh;
            Name[1] = "@gt"; Values[1] = ec.Gioitinh;
            Name[2] = "@diachi"; Values[2] = ec.Diachi;
            Name[3] = "@sdt"; Values[3] = ec.Sdt;
            Name[4] = "@CMTND"; Values[4] = ec.CMTND1;
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public void suadulieu(EC_khachhang ec)
        {
            kn.ThucThiCauLenhSQL("update khachhang set tenKH=N'" + ec.Tenkh + "',GT=N'" + ec.Gioitinh + "',diachi=N'" + ec.Diachi + "',SDT='" + ec.Sdt + "' where maKH='" + ec.Makh + "'");
        }
        public int xoadulieu(EC_khachhang ec)
        {
            string sql = "xoakh";
            int so_luong = 1;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@makh"; Values[0] = ec.Makh;
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public DataTable taobang(string dieukien)
        {
            return kn.GetDataTable("select * from khachhang " + dieukien);
        }
    }
}
