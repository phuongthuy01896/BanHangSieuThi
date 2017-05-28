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
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }
        BUS_nhaphang bus = new BUS_nhaphang();
        SQL_nhaphang sql = new SQL_nhaphang();
        EC_phieunhap ec = new EC_phieunhap();
        void khoadieukien()
        {
            txtmapn.Enabled = false;
            datengaynhap.Enabled = false;
            cmbtencc.Enabled = false;
            cmbnhanvien.Enabled = false;
            cmbmaloaihang.Enabled = false;
            txtsoluong.Enabled = false;
            txttenhang.Enabled = false;
            txtdongia.Enabled = false;
            txtthanhtien.Enabled = false;
            btnthanhtien.Enabled = false;
            btnLuu.Enabled = false;
            btnnhacc.Enabled = true;
            btnLoaihang.Enabled = true;
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnthemchitiet.Enabled = true;
            btnluuchitiet.Enabled = true;
            cmbmapn.Enabled = false;
        }
        void modieukienPN()
        {
            txtmapn.Enabled = true;
            datengaynhap.Enabled = true;
            cmbnhanvien.Enabled = true;
            cmbtencc.Enabled = false;
            cmbmapn.Enabled = false;
            cmbmaloaihang.Enabled = false;
            txtsoluong.Enabled = false;
            txttenhang.Enabled = false;
            txtdongia.Enabled = false;
            txtthanhtien.Enabled = false;
            btnthanhtien.Enabled = false;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnLuu.Enabled = true;
            btnnhacc.Enabled = true;
            btnLoaihang.Enabled = true;
            btnthemchitiet.Enabled = false;
            btnluuchitiet.Enabled = false;
        }
        void modieukienchitiet()
        {
            txtmapn.Enabled = false;
            datengaynhap.Enabled = false;
            cmbnhanvien.Enabled = false;
            cmbtencc.Enabled = true;
            cmbmapn.Enabled = true;
            cmbmaloaihang.Enabled = true;
            txtsoluong.Enabled = true;
            txttenhang.Enabled = true;
            txtdongia.Enabled = true;
            txtthanhtien.Enabled = true;
            btnthanhtien.Enabled = true;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnLuu.Enabled = false;
            btnnhacc.Enabled = true;
            btnLoaihang.Enabled = true;
            btnthemchitiet.Enabled = false;
            btnluuchitiet.Enabled = true;
        }
        void setnull()
        {

            txtmapn.Text = "";
            cmbtencc.Text = "";
            cmbnhanvien.Text = "";
            cmbmaloaihang.Text = "";
            txtsoluong.Text = "";
            txttenhang.Text = "";
            txtdongia.Text = "";
            txtthanhtien.Text = "";
            cmbmapn.Text = "";
        }
        void hienthiPN(string where)
        {
            DataTable dt = bus.taobang(where);
            dgvphieunhap.DataSource = dt;
        }
        void hienthiCTP(string where)
        {
            DataTable dt = bus.taobangchitiet(where);
            dgvchitietpn.DataSource = dt;
        }
        BUS_nhanvien bnv = new BUS_nhanvien();
        BUS_nhacc_loaihang b = new BUS_nhacc_loaihang();
        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            cmbnhanvien.DataSource = bnv.taobang("");
            cmbnhanvien.ValueMember = "manv";
            cmbnhanvien.DisplayMember = "manv";
            cmbmapn.DataSource = bus.taobang("");
            cmbmapn.ValueMember = "mapn";
            cmbmapn.DisplayMember = "mapn";
            cmbmaloaihang.DataSource = b.taobangLH("");
            cmbmaloaihang.ValueMember = "maLH";
            cmbmaloaihang.DisplayMember = "maLH";
            cmbtencc.DataSource = b.taobangcc("");
            cmbtencc.ValueMember = "tencc";
            cmbtencc.DisplayMember = "tencc";
            khoadieukien();
            hienthiPN("");
            hienthiCTP("");
        }
 
        private void btnthem_Click(object sender, EventArgs e)
        {

            modieukienPN();
            setnull();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.Mapn = txtmapn.Text;
                DialogResult dgr = MessageBox.Show("Xóa phiếu nhập sẽ xóa toàn bộ chi tiêt, bạn có chắc xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (dgr == DialogResult.Yes)
                {
                    bus.xoapn(ec);
                    MessageBox.Show("Da xoa!");
                }
                khoadieukien();
                setnull();
                hienthiPN("");
                hienthiCTP("");
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                ec.Mapn = txtmapn.Text;
                ec.MaNV = cmbnhanvien.Text;
                ec.Ngaynhap = Convert.ToDateTime(datengaynhap.Text);
                bus.themdulieu(ec);
                MessageBox.Show("Them thanh cong!");
            }
            catch
            {
                MessageBox.Show("Loi!");
                return;
            }
            setnull();
            khoadieukien();
            hienthiPN("");
            hienthiCTP("");
        }

        private void btnthanhtien_Click(object sender, EventArgs e)
        {
            txtthanhtien.Text = Convert.ToString(Convert.ToInt32(txtdongia.Text) * Convert.ToInt32(txtsoluong.Text));
        }
        bool them;
        private void btnthemchitiet_Click(object sender, EventArgs e)
        {
            modieukienchitiet();
            setnull();
            them = true;
        }
        ketnoi kn = new ketnoi();
        EC_chitietpn et = new EC_chitietpn();
        private void btnluuchitiet_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                try
                {
                    et.Mapn = cmbmapn.Text;
                    et.Tencc = cmbtencc.Text;
                    et.Dongia = Convert.ToInt32(txtdongia.Text);
                    et.MaLH = cmbmaloaihang.Text;
                    et.Soluong = Convert.ToInt32(txtsoluong.Text);
                    et.TenSP = txttenhang.Text;
                    et.Thanhtien = Convert.ToInt32(txtthanhtien.Text);
                    if (sql.kiemtra(et.Mapn, et.MaLH, et.Tencc, et.TenSP) == 1)
                    {
                        MessageBox.Show("Da ton tai hang hoa nay trong phieu nhap!");
                    }
                    else
                    {
                        bus.themchitietpn(et);
                        MessageBox.Show("Them thanh cong!");
                    }
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
                    et.Mapn = cmbmapn.Text;
                    et.Tencc = cmbtencc.Text;
                    et.Dongia = Convert.ToInt32(txtdongia.Text);
                    et.MaLH = cmbmaloaihang.Text;
                    et.Soluong = Convert.ToInt32(txtsoluong.Text);
                    et.TenSP = txttenhang.Text;
                    et.Thanhtien = Convert.ToInt32(txtthanhtien.Text);
                    kn.ThucThiCauLenhSQL("update sanpham set soluong=soluong-" + soluong + "+" + txtsoluong.Text + ",gianhap=" + txtdongia.Text + " where tencc='" + cmbtencc.Text + "' and tenSP=N'" + txttenhang.Text + "' and maLH='" + cmbmaloaihang.Text + "'");
                    bus.suadulieu(et);
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
            hienthiPN("");
            hienthiCTP("");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide();
            f.ShowDialog();
        }

        private void dgvphieunhap_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            khoadieukien();
            try
            {
                txtmapn.Text = dgvphieunhap.Rows[e.RowIndex].Cells[0].Value.ToString();
                datengaynhap.Text = dgvphieunhap.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbnhanvien.Text = dgvphieunhap.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void dgvchitietpn_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            khoadieukien();
            try
            {
                cmbmapn.Text = dgvchitietpn.Rows[e.RowIndex].Cells[0].Value.ToString();
                txttenhang.Text = dgvchitietpn.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbtencc.Text = dgvchitietpn.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbmaloaihang.Text = dgvchitietpn.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtsoluong.Text = dgvchitietpn.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtdongia.Text = dgvchitietpn.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtthanhtien.Text = dgvchitietpn.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch { }
        }

        private void btnnhacc_Click(object sender, EventArgs e)
        {
            frmnhacc.ma = cmbtencc.Text.Trim();
            frmnhacc f = new frmnhacc();
            f.ShowDialog();
        }

        private void btnLoaihang_Click(object sender, EventArgs e)
        {
            frmloaisp.ma = cmbmaloaihang.Text.Trim();
            frmloaisp f = new frmloaisp();
            f.ShowDialog();
        }
        string soluong;
        private void btnsuachitiet_Click(object sender, EventArgs e)
        {
            modieukienchitiet();
            cmbmapn.Enabled = false;
            cmbtencc.Enabled = false;
            cmbmaloaihang.Enabled = false;
            txttenhang.Enabled = false;
            soluong = txtsoluong.Text;
            them = false;
        }

        private void btnxoachitiet_Click(object sender, EventArgs e)
        {

            try
            {
                ec.Mapn = txtmapn.Text;
                int a = int.Parse(kn.GetValue("select count(maSP) from sanpham where tencc='" + cmbtencc.Text + "' and maLH='" + cmbmaloaihang.Text + "' and tenSP=N'" + txttenhang.Text + "' and soluong<" + txtsoluong.Text + ""));
                DialogResult dgr = MessageBox.Show("Bạn có chắc xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (dgr == DialogResult.Yes)
                {
                    if (a == 1)
                    {
                        MessageBox.Show("Khong the xoa!");
                    }
                    else
                    {
                        bus.xoachitietpn(et);
                        kn.ThucThiCauLenhSQL("update sanpham set soluong=soluong-" + txtsoluong.Text + "where tencc='" + cmbtencc.Text + "' and maLH='" + cmbmaloaihang.Text + "' and tenSP=N'" + txttenhang.Text + "'");
                        MessageBox.Show("Da xoa!");
                    }
                }
                khoadieukien();
                setnull();
                hienthiPN("");
                hienthiCTP("");
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }
    }
}
