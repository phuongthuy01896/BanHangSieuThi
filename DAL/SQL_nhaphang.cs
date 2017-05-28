using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entitys;
namespace DAL
{
    public class SQL_nhaphang
    {
        ketnoi kn = new ketnoi();
        public int thempn(EC_phieunhap ec)
        {
            string sql = "thempn";
            int so_luong = 3;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@mapn"; Values[0] = ec.Mapn;
            Name[1] = "@ngaynhap"; Values[1] = ec.Ngaynhap.ToString();
            Name[2] = "@maNV";Values[2] = ec.MaNV;
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public int xoapn(EC_phieunhap ec)
        {
            string sql = "xoapn";
            int so_luong = 1;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@mapn"; Values[0] = ec.Mapn;
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public int themchitietpn(EC_chitietpn ec)
        {
            string sql = "themchitietpn";
            int so_luong = 7;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@mapn"; Values[0] = ec.Mapn;
            Name[1] = "@tenSP"; Values[1] = ec.TenSP;
            Name[2] = "@tencc"; Values[2] = ec.Tencc;
            Name[3] = "@maLH"; Values[3] = ec.MaLH;
            Name[4] = "@soluong"; Values[4] = ec.Soluong.ToString();
            Name[5] = "@dongia"; Values[5] = ec.Dongia.ToString();
            Name[6] = "@thanhtien"; Values[6] = ec.Thanhtien.ToString();
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public void suadulieu(EC_chitietpn ec)
        {
            kn.ThucThiCauLenhSQL("update chitietphieunhap set soluong='" + ec.Soluong + "',dongia='" + ec.Dongia + "',thanhtien='" + ec.Thanhtien + "' where mapn='" + ec.Mapn + "' and tencc=N'" + ec.Tencc + "' and maLH='" + ec.MaLH + "' and tenhang=N'" + ec.TenSP + "'");
        }
        public void xoachitietpn(EC_chitietpn ec)
        {
            kn.ThucThiCauLenhSQL("delete chitietphieunhap where mapn='" + ec.Mapn + "' and tencc=N'" + ec.Tencc + "' and maLH='" + ec.MaLH + "' and tenhang=N'" + ec.TenSP + "'");
        }
        public DataTable taobang(string dieukien)
        {
            return kn.GetDataTable("select * from phieunhap " + dieukien);
        }
        public DataTable taobangchitiet(string dieukien)
        {
            return kn.GetDataTable("select * from chitietphieunhap " + dieukien);
        }
        public int kiemtra(string mapn, string maloaihang, string tencc, string ten)
        {
            return int.Parse(kn.GetValue("select count(mapn) from chitietphieunhap where mapn='" + mapn + "' and tencc='" + tencc + "' and maLH='" + maloaihang + "' and tenhang=N'" + ten + "'"));
        }
    }
}
