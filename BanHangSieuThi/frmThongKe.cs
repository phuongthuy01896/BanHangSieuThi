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
using BUS;
using Entitys;
namespace BanHangSieuThi
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        BUS_sanpham bus = new BUS_sanpham();
        private void btnthoat_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide();
            f.ShowDialog();
        }       
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            DataTable dt = kn.GetDataTable("select maSP,tenSP,soluong from sanpham");
            dgvThongKe.DataSource = dt;
        }
        void setnull()
        {
            cmbthang.Text = "";
        }

        private void btnhangnhap_Click(object sender, EventArgs e)
        {
            DataTable dt = kn.GetDataTable("luuluongnhap'" + cmbthang.Text + "'");
            dgvThongKe.DataSource = dt;
        }

        private void btnhangxuat_Click(object sender, EventArgs e)
        {

            DataTable dt = kn.GetDataTable("luuluongxuat'" + cmbthang.Text + "'");
            dgvThongKe.DataSource = dt;
        }

        private void btnHangtrongkho_Click(object sender, EventArgs e)
        {

            DataTable dt = kn.GetDataTable("select maSP,tenSP,soluong from sanpham");
            dgvThongKe.DataSource = dt;
        }
    }
}
