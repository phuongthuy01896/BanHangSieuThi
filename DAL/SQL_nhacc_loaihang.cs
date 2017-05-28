using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitys;
using System.Data;
namespace DAL
{
    public class SQL_nhacc_loaihang
    {
        ketnoi kn = new ketnoi();
        public DataTable taobangcc(string dieukien)
        {
            return kn.GetDataTable("select* from nhacungcap " + dieukien);
        }
        public DataTable taobangLH(string dieukien)
        {
            return kn.GetDataTable("select* from loaihang " + dieukien);
        }
    }
}
