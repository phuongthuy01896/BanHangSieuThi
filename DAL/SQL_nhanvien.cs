using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entitys;
namespace DAL
{
    public class SQL_nhanvien
    {
        ketnoi kn = new ketnoi();
        public int themdulieu(EC_nhanvien ec)
        {
            string sql = "themnv";
            int so_luong = 5;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@manv"; Values[0] = ec.Manv;
            Name[1] = "@tennv"; Values[1] = ec.Tennv;
            Name[2] = "@gt"; Values[2] = ec.Gioitinh;
            Name[4] = "@sdt"; Values[4] = ec.Sdt;
            Name[3] = "@diachi"; Values[3] = ec.Diachi;
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public void suadulieu(EC_nhanvien ec)
        {
            kn.ThucThiCauLenhSQL("update nhanvien set tenNV=N'" + ec.Tennv + "',GT=N'" + ec.Gioitinh + "',diachi=N'" + ec.Diachi + "',SDT='" + ec.Sdt + "' where maNV='" + ec.Manv + "'");
        }
        public void xoadulieu(EC_nhanvien ec)
        {
            kn.ThucThiCauLenhSQL("delete nhanvien where maNV='" + ec.Manv + "'");
        }
        public DataTable taobang(string dieukien)
        {
            return kn.GetDataTable("select * from nhanvien " + dieukien);
        } 
    }
}
