using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Entitys;
using BUS;
namespace BanHangSieuThi
{
    public partial class frmKhoHang : Form
    {
        public frmKhoHang()
        {
            InitializeComponent();
        }
        BUS_sanpham bus = new BUS_sanpham();
        EC_sanpham ec = new EC_sanpham();
        SQL_sanpham sql = new SQL_sanpham();

        void hienthi(string dieukien)
        {
            dgvsanpham.DataSource = bus.taobang(dieukien);
        }
        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            hienthi("");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        ketnoi kn = new ketnoi();
        private void btnchon_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(kn.GetValue("select soluong from sanpham where maSP='" + txtmasp.Text + "'"));
            if (Convert.ToInt32(txtsoluong.Text) > ma)
            {
                MessageBox.Show("So luong trong kho khong du!");
            }
            else
            {
                frmBanHang.instance.hienthichonsp(txtmasp.Text,txttensp.Text,Convert.ToInt32(txtsoluong.Text),Convert.ToInt32(txtdongia.Text));
                this.Close();
            }
        }

        private void dgvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtmasp.Text = dgvsanpham.Rows[e.RowIndex].Cells[0].Value.ToString();
                txttensp.Text = dgvsanpham.Rows[e.RowIndex].Cells[1].Value.ToString();

                txtdongia.Text = dgvsanpham.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch
            {
                 
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            hienthi("where tenSP like N'%" + txttimkiem.Text + "%'");
        }
    }
}
