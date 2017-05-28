using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangSieuThi
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            this.Hide();
            f.ShowDialog();
        }

        private void btnbanhang_Click(object sender, EventArgs e)
        {
            frmBanHang f = new frmBanHang();
            this.Hide();
            f.ShowDialog();
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            this.Hide();
            f.ShowDialog();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            frmThongKe f = new frmThongKe();
            this.Hide();
            f.ShowDialog();
        }

        private void btnnhaphang_Click(object sender, EventArgs e)
        {
            frmNhapHang f = new frmNhapHang();
            this.Hide();
            f.ShowDialog();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            frmTimKiem f = new frmTimKiem();
            this.Hide();
            f.ShowDialog();
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            frmHuongDan f = new frmHuongDan();
            this.Hide();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNguoiDung f = new frmNguoiDung();
            this.Hide();
            f.ShowDialog();
        }
    }
}
