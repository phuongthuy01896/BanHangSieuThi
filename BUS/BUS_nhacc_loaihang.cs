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
    public class BUS_nhacc_loaihang
    {
        SQL_nhacc_loaihang sql = new SQL_nhacc_loaihang();
        public DataTable taobangcc(string dieukien)
        {
            return sql.taobangcc(dieukien);
        }
        public DataTable taobangLH(string dieukien)
        {
            return sql.taobangLH(dieukien);
        }
    }
}
