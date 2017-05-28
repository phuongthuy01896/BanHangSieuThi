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
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }
        BUS_sanpham bus = new BUS_sanpham();
        EC_sanpham ec = new EC_sanpham();
        void khoadieukien()
        {
            txtgiaban.Enabled = false;
            txtgianhap.Enabled = false;
            txtmaLH.Enabled = false;
            txtmasp.Enabled = false;
            txtsoluong.Enabled = false;
            txttencc.Enabled = false;
            txttensp.Enabled = false;
            datengaysx.Enabled = false;
            btnluu.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
        }
        void hienthi(string dieukien)
        {
            dgvsanpham.DataSource = bus.taobang(dieukien);
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            khoadieukien();
            hienthi("");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbtnMaHang.Checked == true)
            {
                hienthi("where maSP like '%"+txtTimKiem.Text+"%'");
            }
            if (rbtnTenHang.Checked == true)
            {
                hienthi("where tenSP like N'%" + txtTimKiem.Text + "%'");
            }
            if (rbtnMaLoaiHang.Checked == true)
            {
                hienthi("where maLH like '%" + cmbLoaiHang.Text + "%'");
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtmasp.Text = dgvsanpham.Rows[e.RowIndex].Cells[0].Value.ToString();
                txttensp.Text = dgvsanpham.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtmaLH.Text = dgvsanpham.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtsoluong.Text = dgvsanpham.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtgianhap.Text = dgvsanpham.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtgiaban.Text = dgvsanpham.Rows[e.RowIndex].Cells[5].Value.ToString();
                datengaysx.Text = dgvsanpham.Rows[e.RowIndex].Cells[6].Value.ToString();
                txttencc.Text = dgvsanpham.Rows[e.RowIndex].Cells[7].Value.ToString();
                //rtxtmota.Text = dgvsanpham.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide();
            f.ShowDialog();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            txtgiaban.Enabled = true;
            btnluu.Enabled = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                ec.MaSP = txtmasp.Text;
                ec.Giaban = int.Parse(txtgiaban.Text);
                bus.suadulieu(ec);
                MessageBox.Show("Sua thanh cong!");
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
            khoadieukien();
            hienthi("");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.MaSP = txtmasp.Text;
                DialogResult dgr = MessageBox.Show("Bạn có chắc xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (dgr == DialogResult.Yes)
                {
                    bus.xoadulieu(ec);
                    MessageBox.Show("Da xoa!");
                }
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
            hienthi("");
        }
    }
}
