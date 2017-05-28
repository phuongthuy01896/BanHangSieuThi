namespace BanHangSieuThi
{
    partial class frmBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSuaSL = new System.Windows.Forms.Button();
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.grbthanhtoan = new System.Windows.Forms.GroupBox();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.btntongtien = new System.Windows.Forms.Button();
            this.btntinhtienkh = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTienThoiLai = new System.Windows.Forms.TextBox();
            this.txtTienKhachTra = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.grbSanPham = new System.Windows.Forms.GroupBox();
            this.btnkhohang = new System.Windows.Forms.Button();
            this.btndongia = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnthanhtien = new System.Windows.Forms.Button();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grbHoadon = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcmt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.cmbnhanvien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthemhd = new System.Windows.Forms.Button();
            this.datengay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnkhachhang = new System.Windows.Forms.Button();
            this.grbthanhtoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.grbSanPham.SuspendLayout();
            this.grbHoadon.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSuaSL
            // 
            this.btnSuaSL.Location = new System.Drawing.Point(726, 159);
            this.btnSuaSL.Name = "btnSuaSL";
            this.btnSuaSL.Size = new System.Drawing.Size(70, 46);
            this.btnSuaSL.TabIndex = 37;
            this.btnSuaSL.Text = "Sửa số lượng";
            this.btnSuaSL.UseVisualStyleBackColor = true;
            this.btnSuaSL.Click += new System.EventHandler(this.btnSuaSL_Click);
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.Location = new System.Drawing.Point(432, 3);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(82, 57);
            this.btnTaoHD.TabIndex = 32;
            this.btnTaoHD.Text = "Tạo hóa đơn mới";
            this.btnTaoHD.UseVisualStyleBackColor = true;
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Location = new System.Drawing.Point(726, 118);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(70, 38);
            this.btnXoaSP.TabIndex = 26;
            this.btnXoaSP.Text = "Xóa sản phẩm";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(636, 3);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(84, 57);
            this.btnthoat.TabIndex = 30;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // grbthanhtoan
            // 
            this.grbthanhtoan.Controls.Add(this.btnthanhtoan);
            this.grbthanhtoan.Controls.Add(this.btntongtien);
            this.grbthanhtoan.Controls.Add(this.btntinhtienkh);
            this.grbthanhtoan.Controls.Add(this.label17);
            this.grbthanhtoan.Controls.Add(this.label16);
            this.grbthanhtoan.Controls.Add(this.label15);
            this.grbthanhtoan.Controls.Add(this.txtTienThoiLai);
            this.grbthanhtoan.Controls.Add(this.txtTienKhachTra);
            this.grbthanhtoan.Controls.Add(this.txtTongTien);
            this.grbthanhtoan.Controls.Add(this.label9);
            this.grbthanhtoan.Controls.Add(this.label8);
            this.grbthanhtoan.Location = new System.Drawing.Point(9, 271);
            this.grbthanhtoan.Name = "grbthanhtoan";
            this.grbthanhtoan.Size = new System.Drawing.Size(295, 216);
            this.grbthanhtoan.TabIndex = 29;
            this.grbthanhtoan.TabStop = false;
            this.grbthanhtoan.Text = "Thanh toán";
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Location = new System.Drawing.Point(193, 155);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(76, 22);
            this.btnthanhtoan.TabIndex = 42;
            this.btnthanhtoan.Text = "Thanh toán";
            this.btnthanhtoan.UseVisualStyleBackColor = true;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // btntongtien
            // 
            this.btntongtien.Location = new System.Drawing.Point(23, 27);
            this.btntongtien.Name = "btntongtien";
            this.btntongtien.Size = new System.Drawing.Size(75, 23);
            this.btntongtien.TabIndex = 41;
            this.btntongtien.Text = "Tổng tiền";
            this.btntongtien.UseVisualStyleBackColor = true;
            this.btntongtien.Click += new System.EventHandler(this.btntongtien_Click);
            // 
            // btntinhtienkh
            // 
            this.btntinhtienkh.Location = new System.Drawing.Point(174, 92);
            this.btntinhtienkh.Name = "btntinhtienkh";
            this.btntinhtienkh.Size = new System.Drawing.Size(58, 20);
            this.btntinhtienkh.TabIndex = 15;
            this.btntinhtienkh.Text = "Tính";
            this.btntinhtienkh.UseVisualStyleBackColor = true;
            this.btntinhtienkh.Click += new System.EventHandler(this.btntinhtienkh_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(246, 128);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = ".đồng";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(246, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = ".đồng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(246, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = ".đồng";
            // 
            // txtTienThoiLai
            // 
            this.txtTienThoiLai.Location = new System.Drawing.Point(133, 125);
            this.txtTienThoiLai.Name = "txtTienThoiLai";
            this.txtTienThoiLai.Size = new System.Drawing.Size(99, 20);
            this.txtTienThoiLai.TabIndex = 7;
            // 
            // txtTienKhachTra
            // 
            this.txtTienKhachTra.Location = new System.Drawing.Point(133, 66);
            this.txtTienKhachTra.Name = "txtTienKhachTra";
            this.txtTienKhachTra.Size = new System.Drawing.Size(99, 20);
            this.txtTienKhachTra.TabIndex = 6;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(133, 29);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(99, 20);
            this.txtTongTien.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tiền thối lại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tiềm khách hàng trả";
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(726, 68);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(70, 44);
            this.btnThemSP.TabIndex = 21;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(310, 271);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.Size = new System.Drawing.Size(511, 216);
            this.dgvDanhSach.TabIndex = 27;
            // 
            // grbSanPham
            // 
            this.grbSanPham.Controls.Add(this.btnkhohang);
            this.grbSanPham.Controls.Add(this.btndongia);
            this.grbSanPham.Controls.Add(this.label6);
            this.grbSanPham.Controls.Add(this.btnthanhtien);
            this.grbSanPham.Controls.Add(this.txtthanhtien);
            this.grbSanPham.Controls.Add(this.label14);
            this.grbSanPham.Controls.Add(this.txtSoLuong);
            this.grbSanPham.Controls.Add(this.txtDonGia);
            this.grbSanPham.Controls.Add(this.txtTenSP);
            this.grbSanPham.Controls.Add(this.txtMaSP);
            this.grbSanPham.Controls.Add(this.label13);
            this.grbSanPham.Controls.Add(this.label11);
            this.grbSanPham.Controls.Add(this.label10);
            this.grbSanPham.Location = new System.Drawing.Point(351, 66);
            this.grbSanPham.Name = "grbSanPham";
            this.grbSanPham.Size = new System.Drawing.Size(369, 198);
            this.grbSanPham.TabIndex = 25;
            this.grbSanPham.TabStop = false;
            this.grbSanPham.Text = "Hàng hóa";
            // 
            // btnkhohang
            // 
            this.btnkhohang.Location = new System.Drawing.Point(269, 29);
            this.btnkhohang.Name = "btnkhohang";
            this.btnkhohang.Size = new System.Drawing.Size(82, 57);
            this.btnkhohang.TabIndex = 40;
            this.btnkhohang.Text = "Chọn sản phẩm";
            this.btnkhohang.UseVisualStyleBackColor = true;
            this.btnkhohang.Click += new System.EventHandler(this.btnkhohang_Click);
            // 
            // btndongia
            // 
            this.btndongia.Location = new System.Drawing.Point(22, 111);
            this.btndongia.Name = "btndongia";
            this.btndongia.Size = new System.Drawing.Size(58, 20);
            this.btndongia.TabIndex = 18;
            this.btndongia.Text = "Đơn giá";
            this.btndongia.UseVisualStyleBackColor = true;
            this.btndongia.Click += new System.EventHandler(this.btndongia_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = ".đồng";
            // 
            // btnthanhtien
            // 
            this.btnthanhtien.Location = new System.Drawing.Point(22, 153);
            this.btnthanhtien.Name = "btnthanhtien";
            this.btnthanhtien.Size = new System.Drawing.Size(58, 20);
            this.btnthanhtien.TabIndex = 16;
            this.btnthanhtien.Text = "Tính";
            this.btnthanhtien.UseVisualStyleBackColor = true;
            this.btnthanhtien.Click += new System.EventHandler(this.btnthanhtien_Click);
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(96, 154);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(108, 20);
            this.txtthanhtien.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(179, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = ".đồng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(285, 111);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(66, 20);
            this.txtSoLuong.TabIndex = 9;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(96, 111);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(77, 20);
            this.txtDonGia.TabIndex = 8;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(96, 70);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(155, 20);
            this.txtTenSP.TabIndex = 7;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(96, 30);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(111, 20);
            this.txtMaSP.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(230, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Số lượng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tên SP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Mã SP";
            // 
            // grbHoadon
            // 
            this.grbHoadon.Controls.Add(this.label12);
            this.grbHoadon.Controls.Add(this.txtcmt);
            this.grbHoadon.Controls.Add(this.label5);
            this.grbHoadon.Controls.Add(this.txttenkh);
            this.grbHoadon.Controls.Add(this.cmbnhanvien);
            this.grbHoadon.Controls.Add(this.label1);
            this.grbHoadon.Controls.Add(this.btnthemhd);
            this.grbHoadon.Controls.Add(this.datengay);
            this.grbHoadon.Controls.Add(this.label4);
            this.grbHoadon.Controls.Add(this.txtmahd);
            this.grbHoadon.Controls.Add(this.label2);
            this.grbHoadon.Location = new System.Drawing.Point(11, 12);
            this.grbHoadon.Name = "grbHoadon";
            this.grbHoadon.Size = new System.Drawing.Size(334, 253);
            this.grbHoadon.TabIndex = 38;
            this.grbHoadon.TabStop = false;
            this.grbHoadon.Text = "Hóa đơn mới";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "CMTND";
            // 
            // txtcmt
            // 
            this.txtcmt.Location = new System.Drawing.Point(131, 184);
            this.txtcmt.Name = "txtcmt";
            this.txtcmt.Size = new System.Drawing.Size(190, 20);
            this.txtcmt.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Tên khách hàng";
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(131, 147);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(190, 20);
            this.txttenkh.TabIndex = 44;
            // 
            // cmbnhanvien
            // 
            this.cmbnhanvien.FormattingEnabled = true;
            this.cmbnhanvien.Items.AddRange(new object[] {
            "NV02",
            "NV03"});
            this.cmbnhanvien.Location = new System.Drawing.Point(133, 106);
            this.cmbnhanvien.Name = "cmbnhanvien";
            this.cmbnhanvien.Size = new System.Drawing.Size(189, 21);
            this.cmbnhanvien.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Mã nhân viên";
            // 
            // btnthemhd
            // 
            this.btnthemhd.Location = new System.Drawing.Point(232, 215);
            this.btnthemhd.Name = "btnthemhd";
            this.btnthemhd.Size = new System.Drawing.Size(75, 32);
            this.btnthemhd.TabIndex = 40;
            this.btnthemhd.Text = "Thêm";
            this.btnthemhd.UseVisualStyleBackColor = true;
            this.btnthemhd.Click += new System.EventHandler(this.btnthemhd_Click);
            // 
            // datengay
            // 
            this.datengay.Location = new System.Drawing.Point(133, 66);
            this.datengay.Name = "datengay";
            this.datengay.Size = new System.Drawing.Size(189, 20);
            this.datengay.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Ngày";
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(131, 28);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(190, 20);
            this.txtmahd.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mã hóa đơn";
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(726, 213);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(70, 46);
            this.btnluu.TabIndex = 39;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnkhachhang
            // 
            this.btnkhachhang.Location = new System.Drawing.Point(537, 3);
            this.btnkhachhang.Name = "btnkhachhang";
            this.btnkhachhang.Size = new System.Drawing.Size(84, 57);
            this.btnkhachhang.TabIndex = 40;
            this.btnkhachhang.Text = "Khách hàng";
            this.btnkhachhang.UseVisualStyleBackColor = true;
            this.btnkhachhang.Click += new System.EventHandler(this.btnkhachhang_Click);
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(826, 494);
            this.Controls.Add(this.btnkhachhang);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.grbHoadon);
            this.Controls.Add(this.btnSuaSL);
            this.Controls.Add(this.btnTaoHD);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.grbthanhtoan);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.grbSanPham);
            this.Name = "frmBanHang";
            this.Text = "frmBanHang";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.grbthanhtoan.ResumeLayout(false);
            this.grbthanhtoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.grbSanPham.ResumeLayout(false);
            this.grbSanPham.PerformLayout();
            this.grbHoadon.ResumeLayout(false);
            this.grbHoadon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSuaSL;
        private System.Windows.Forms.Button btnTaoHD;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox grbthanhtoan;
        private System.Windows.Forms.Button btntinhtienkh;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTienThoiLai;
        private System.Windows.Forms.TextBox txtTienKhachTra;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.GroupBox grbSanPham;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grbHoadon;
        private System.Windows.Forms.Button btnthemhd;
        private System.Windows.Forms.ComboBox cmbnhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datengay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnthanhtien;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btndongia;
        private System.Windows.Forms.Button btntongtien;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcmt;
        private System.Windows.Forms.Button btnkhohang;
        private System.Windows.Forms.Button btnkhachhang;
    }
}