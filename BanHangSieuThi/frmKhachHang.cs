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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        BUS_khachhang bus = new BUS_khachhang();
        SQL_khachhang sql = new SQL_khachhang();
        EC_khachhang ec = new EC_khachhang();
        bool themmoi;
        void khoadieukien()
        {
            txtdiachi.Enabled = false;
            txtmakh.Enabled = false;
            txtsdt.Enabled = false;
            txttenkh.Enabled = false;
            cmbGioiTinh.Enabled = false;
            //  cmbLoaiKH.Enabled = false;
            txtcmt.Enabled = false;
            btncapnhat.Enabled = false;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
        }
        void modieukien()
        {
            txtdiachi.Enabled = true;
            txtmakh.Enabled = true;
            txtsdt.Enabled = true;
            txttenkh.Enabled = true;
            cmbGioiTinh.Enabled = true;
            txtcmt.Enabled = true;
        //    cmbLoaiKH.Enabled = true;
            btncapnhat.Enabled = true;
            btnsua.Enabled = false;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
        }
        void hienthi(string dieukien)
        {
            dgvkhachhang.DataSource = bus.taobang(dieukien);
        }
        void setnull()
        {
            txtdiachi.Text = "";
            txtmakh.Text = "";
            txtsdt.Text = "";
            txttenkh.Text = "";
            cmbGioiTinh.Text = "";
            //cmbLoaiKH.Text = "";
            txtcmt.Text = "";
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            khoadieukien();
            hienthi("");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            modieukien();
            txtmakh.Enabled = false;
            setnull();
            themmoi = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            modieukien();
            themmoi = false;
            txtcmt.Enabled = false;
            txtmakh.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.Makh = txtmakh.Text;
                bus.xoadulieu(ec);
                MessageBox.Show("Da xoa!");
                khoadieukien();
                setnull();
                hienthi("");
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (themmoi == true)
            {
                try
                {
                    ec.Makh = txtmakh.Text;
                    ec.Tenkh = txttenkh.Text;
                    ec.Gioitinh = cmbGioiTinh.Text;
                    //      ec.Loaikh = cmbLoaiKH.Text;
                    ec.CMTND1 = txtcmt.Text;
                    ec.Sdt = txtsdt.Text;
                    ec.Diachi = txtdiachi.Text;
                    bus.themdulieu(ec);
                    MessageBox.Show("Them thanh cong!");
                }
                catch
                {
                    MessageBox.Show("Loi!");
                    return;
                }
            }
            else
            {
                try
                {
                    ec.Makh = txtmakh.Text;
                    ec.Tenkh = txttenkh.Text;
                    ec.Gioitinh = cmbGioiTinh.Text;
                //    ec.Loaikh = cmbLoaiKH.Text;
                    ec.Sdt = txtsdt.Text;
                    ec.Diachi = txtdiachi.Text;
                    bus.suadulieu(ec);
                    MessageBox.Show("Sua thanh cong!");
                }
                catch
                {
                    MessageBox.Show("Loi!");
                    return;
                }
            }
            setnull();
            khoadieukien();
            hienthi("");
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            hienthi("where tenKH like N'%" + txttimkiem.Text + "%'");
        }

        private void dgvkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtmakh.Text = dgvkhachhang.Rows[e.RowIndex].Cells[0].Value.ToString();
                //cmbmacv.Text = dgvnhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txttenkh.Text = dgvkhachhang.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbGioiTinh.Text = dgvkhachhang.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtdiachi.Text = dgvkhachhang.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtsdt.Text = dgvkhachhang.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtcmt.Text = dgvkhachhang.Rows[e.RowIndex].Cells[5].Value.ToString();    
            }
            catch
            {

            }
        }

        private void btnxemdanhsach_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide();
            f.ShowDialog();
        }
    }
}
