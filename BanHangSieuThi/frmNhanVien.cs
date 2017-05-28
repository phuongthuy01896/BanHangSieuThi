using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using Entitys;
namespace BanHangSieuThi
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        BUS_nhanvien bus = new BUS_nhanvien();
        SQL_nhanvien sql = new SQL_nhanvien();
        EC_nhanvien ec = new EC_nhanvien();
        bool themmoi;
        void khoadieukien()
        {
            txtdiachi.Enabled = false;
            txtmanv.Enabled = false;
            txtsdt.Enabled = false;
            txttennv.Enabled = false;
            cmbGT.Enabled = false;
            btncapnhat.Enabled = false;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
        }
        void modieukien()
        {
            txtdiachi.Enabled = true;
            txtmanv.Enabled = true;
            txtsdt.Enabled = true;
            txttennv.Enabled = true;
            cmbGT.Enabled = true;
            btncapnhat.Enabled = true;
            btnsua.Enabled = false;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
        }
        void hienthi(string dieukien)
        {
            dgvnhanvien.DataSource= bus.taobang(dieukien);
        }
        void setnull()
        {
            txtdiachi.Text = "";
            txtmanv.Text = "";
            txtsdt.Text = "";
            txttennv.Text = "";
            cmbGT.Text = "";
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            khoadieukien();
            hienthi("");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            modieukien();
            setnull();
            themmoi = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            modieukien();
            themmoi = false;
            txtmanv.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.Manv = txtmanv.Text;
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
                    ec.Manv = txtmanv.Text;
                    ec.Tennv = txttennv.Text;
                    ec.Gioitinh = cmbGT.Text;
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
                    ec.Manv = txtmanv.Text;
                    ec.Tennv = txttennv.Text;
                    ec.Gioitinh = cmbGT.Text;
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

        private void dgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoadieukien();
            try
            {
                txtmanv.Text = dgvnhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
                //cmbmacv.Text = dgvnhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txttennv.Text = dgvnhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbGT.Text = dgvnhanvien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtdiachi.Text = dgvnhanvien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtsdt.Text = dgvnhanvien.Rows[e.RowIndex].Cells[4].Value.ToString();
                //txtmathukho.Text = dgvnhanvien.Rows[e.RowIndex].Cells[5].Value.ToString();    
            }
            catch
            {

            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            hienthi("where tenNV like N'%" + txttimkiem.Text + "%'");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide();
            f.ShowDialog();
        }
    }
}
