using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entitys;
namespace DAL
{
    public class SQL_hoadonban
    {
        ketnoi kn = new ketnoi();
        public int themdulieu(EC_hoadonban ec)
        {
            string sql = "themhoadon";
            int so_luong = 4;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@maKH"; Values[0] = ec.MaKH;
            Name[1] = "@ngayban"; Values[1] = ec.Ngayban.ToString();
            Name[2] = "@tongtien"; Values[2] = ec.Tongtien.ToString();
            Name[3] = "@maNV"; Values[3] = ec.MaNV;
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public int themchitiet(EC_chitiethoadon ec)
        {
            string sql = "themchitiet";
            int so_luong = 5;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@maHDB"; Values[0] = ec.MaHDB;
            Name[1] = "@maSP"; Values[1] = ec.MaSP;
            Name[2] = "@soluong"; Values[2] = ec.Soluong.ToString();
            Name[3] = "@dongia"; Values[3] = ec.Dongia.ToString();
            Name[4] = "@thanhtien"; Values[4] = ec.Thanhtien.ToString();
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public void xoadulieu(EC_chitiethoadon ec)
        {
            kn.ThucThiCauLenhSQL("delete chitiethoadon where maSP='" + ec.MaSP + "'");
        }
        public void suadulieu(EC_chitiethoadon ec)
        {
            kn.ThucThiCauLenhSQL("update chitiethoadon set soluong='" + ec.Soluong + "',dongia='" + ec.Dongia + "',thanhtien='" + ec.Thanhtien + "' where maSP='" + ec.MaSP + "'");
        }
        public DataTable taobang(string dieukien)
        {
            return kn.GetDataTable("select* from chitiethoadon " + dieukien);
        }
    }
}
