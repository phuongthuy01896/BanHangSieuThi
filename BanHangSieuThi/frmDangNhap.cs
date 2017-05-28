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
namespace BanHangSieuThi
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        SQL_dangnhap sql = new SQL_dangnhap();
        private void btndangnhap_Click(object sender, EventArgs e)
        {

            if (txtname.Text == null)
            {
                MessageBox.Show("Chưa nhập mã nhân viên đăng nhập !");
            }
            if (txtpass.Text == null)
            {
                MessageBox.Show("Chưa nhập mật khẩu !");
            }
            if (sql.checkLogin(txtname.Text, txtpass.Text) != null)
            {
                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu chưa đúng !");
            }
        }

        private void rdocheck_CheckedChanged(object sender, EventArgs e)
        {
            if (rdocheck.Checked == true)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }
    }
}
