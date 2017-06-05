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
    public partial class frmBanHang : Form
    {
        public static frmBanHang instance;
        public frmBanHang()
        {
            instance = this;
            InitializeComponent();
        }
        SQL_hoadonban sql = new SQL_hoadonban();
        BUS_hoadonban bus = new BUS_hoadonban();
        EC_chitiethoadon ec = new EC_chitiethoadon();
        EC_hoadonban eh = new EC_hoadonban();
        BUS_khachhang bk = new BUS_khachhang();
        EC_khachhang ek = new EC_khachhang();
        bool themmoi;
        void khoadieukien()
        {
            grbHoadon.Enabled = false;
            grbSanPham.Enabled = false;
            grbthanhtoan.Enabled = false;            
        }
        void modieukien()
        {
            grbHoadon.Enabled = true;
            grbSanPham.Enabled = true;
            grbthanhtoan.Enabled = true;
        }
        BUS_nhanvien bnv = new BUS_nhanvien();
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            cmbnhanvien.DataSource = bnv.taobang("");
            cmbnhanvien.ValueMember = "manv";
            cmbnhanvien.DisplayMember = "manv";
            khoadieukien();
        }
        void hienthi(string dieukien)
        {
            dgvDanhSach.DataSource = bus.taobang(dieukien);
        }
        void setnull()
        {
            txtmahd.Text = "";
            txtDonGia.Text = "";
            txtMaSP.Text = "";
            txtSoLuong.Text = "";
            txttenkh.Text = "";
            txtTenSP.Text = "";
            txtthanhtien.Text = "";
            txtTienKhachTra.Text = "";
            txtTienThoiLai.Text = "";
            txtTongTien.Text = "";
            cmbnhanvien.Text = "";
            txtcmt.Text = "";
        }
        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            setnull();
            khoadieukien();
            grbHoadon.Enabled = true;
            txtmahd.Enabled = false;
        }
        string makh;
        private void btnthemhd_Click(object sender, EventArgs e)
        {
            try
            {
                makh = kn.GetValue("select maKH from khachhang where tenKH=N'" + txttenkh.Text + "' and CMTND='"+txtcmt.Text+"'");
                if (makh != null)
                {
                    eh.MaKH = makh;
                }
                else
                {
                    ek.Makh = "";
                    ek.Gioitinh = "";
                    ek.Diachi = "";
                    ek.CMTND1 = txtcmt.Text;
                    ek.Sdt = "";
                    ek.Tenkh = txttenkh.Text;
                    bk.themdulieu(ek);
                    eh.MaKH = kn.GetValue("select maKH from khachhang where tenKH=N'" + txttenkh.Text + "' and CMTND='"+txtcmt.Text+"'");
                }
                eh.MaNV = cmbnhanvien.Text;
                eh.Ngayban = Convert.ToDateTime(datengay.Text);
                bus.themdulieu(eh);
                MessageBox.Show("Them hoa don thanh cong!");
                txtmahd.Text = kn.GetValue("select max(maHDB) from hoadonban");
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
            khoadieukien();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            khoadieukien();
            grbSanPham.Enabled = true;
            btnluu.Enabled = true;
            btnSuaSL.Enabled = false;
            btnXoaSP.Enabled = false;        
            themmoi = true;
        }

        private void btnSuaSL_Click(object sender, EventArgs e)
        {
            khoadieukien();
            grbSanPham.Enabled = true;
            themmoi = false;
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                ec.MaSP = txtMaSP.Text;
                bus.xoadulieu(ec);
                MessageBox.Show("Da xoa!");
                khoadieukien();
                hienthi("where maHDB='"+txtmahd.Text+"'");
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }
        public void hienthichonsp(string masp, string tensp, int soluong, int dongia)
        {
            txtMaSP.Text = masp;
            txtTenSP.Text = tensp;
            txtDonGia.Text = dongia.ToString();
            txtSoLuong.Text = soluong.ToString();
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (themmoi == true)
            {
                try
                {
                    ec.MaHDB = txtmahd.Text;
                    ec.MaSP = txtMaSP.Text;
                    ec.Dongia = Convert.ToInt32(txtDonGia.Text);
                    ec.Soluong = Convert.ToInt32(txtSoLuong.Text);
                    ec.Thanhtien = Convert.ToInt32(txtthanhtien.Text);
                    bus.themchitiet(ec);
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
                    ec.MaHDB = txtmahd.Text;
                    ec.MaSP = txtMaSP.Text;
                    ec.Dongia = Convert.ToInt32(txtDonGia.Text);
                    ec.Soluong = Convert.ToInt32(txtSoLuong.Text);
                    ec.Thanhtien = Convert.ToInt32(txtthanhtien.Text);
                    bus.suachitiet(ec);
                    MessageBox.Show("Sua thanh cong!");
                }
                catch
                {
                    MessageBox.Show("Loi!");
                    return;
                }
            }
            khoadieukien();
            grbthanhtoan.Enabled = true;
            hienthi("where maHDB='"+txtmahd.Text+"'");
        }
        ketnoi kn = new ketnoi();
        private void btndongia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(kn.GetValue("select giaban from sanpham where maSP='" + txtMaSP.Text + "' and tenSP=N'" + txtTenSP.Text + "'"));
            txtDonGia.Text = a.ToString();
        }

        private void btnthanhtien_Click(object sender, EventArgs e)
        {
            txtthanhtien.Text = Convert.ToString(Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSoLuong.Text));
        }

        private void btntongtien_Click(object sender, EventArgs e)
        {
            int a = int.Parse(kn.GetValue("select sum(thanhtien) from chitiethoadon where maHDB='" + txtmahd.Text + "'"));
            txtTongTien.Text = a.ToString();
        }

        private void btntinhtienkh_Click(object sender, EventArgs e)
        {
            txtTienThoiLai.Text = Convert.ToString(-Convert.ToInt32(txtTongTien.Text) + Convert.ToInt32(txtTienKhachTra.Text));
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã thanh toán!");
            kn.ThucThiCauLenhSQL("update hoadonban set tongtien='" + txtTongTien.Text + "' where maHDB='" + txtmahd.Text + "'");
            khoadieukien();
            setnull();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide();
            f.ShowDialog();
        }

        private void btnkhohang_Click(object sender, EventArgs e)
        {
            frmKhoHang f = new frmKhoHang();
            f.ShowDialog();
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();
        }
    }
}
