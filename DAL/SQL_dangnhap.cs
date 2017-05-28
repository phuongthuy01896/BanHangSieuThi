using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitys;
using System.Data;
namespace DAL
{
    public class SQL_dangnhap
    {
        ketnoi kn = new ketnoi();
        public string checkLogin(string Username, string Password)
        {
            return kn.GetValue(@"SELECT username,pass FROM dangnhap WHERE username ='" + Username + "' and pass ='" + Password + "'");
        }
        public int themdulieu(EC_dangnhap ec)
        {

            string sql = "themuser";
            int so_luong = 2;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@username"; Values[0] = ec.Username;
            Name[1] = "@pass"; Values[1] = ec.Pass;
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public void suadulieu(EC_dangnhap ec)
        {
            kn.ThucThiCauLenhSQL("update dangnhap set username='" + ec.Username + "', pass='" + ec.Pass + "' where ID='" + ec.Id + "'");
        }
        public void xoadulieu(EC_dangnhap ec)
        {
            kn.ThucThiCauLenhSQL("delete dangnhap where ID='" + ec.Id + "'");
        }
        public DataTable taobang(string dieukien)
        {
            return kn.GetDataTable("select * from dangnhap " + dieukien);
        }
    }
}
