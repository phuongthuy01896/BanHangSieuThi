namespace BanHangSieuThi
{
    partial class frmKhachHang
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnxemdanhsach = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvkhachhang = new System.Windows.Forms.DataGridView();
            this.txtcmt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.btntimkiem);
            this.groupBox3.Controls.Add(this.txttimkiem);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(642, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 163);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btntimkiem.Image = global::BanHangSieuThi.Properties.Resources.search;
            this.btntimkiem.Location = new System.Drawing.Point(34, 96);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(65, 38);
            this.btntimkiem.TabIndex = 17;
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(34, 65);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(197, 20);
            this.txttimkiem.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nhập khóa cần tìm";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnxemdanhsach);
            this.groupBox2.Controls.Add(this.btncapnhat);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Location = new System.Drawing.Point(754, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 288);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // btnxemdanhsach
            // 
            this.btnxemdanhsach.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnxemdanhsach.Image = global::BanHangSieuThi.Properties.Resources.back;
            this.btnxemdanhsach.Location = new System.Drawing.Point(43, 219);
            this.btnxemdanhsach.Name = "btnxemdanhsach";
            this.btnxemdanhsach.Size = new System.Drawing.Size(75, 31);
            this.btnxemdanhsach.TabIndex = 9;
            this.btnxemdanhsach.UseVisualStyleBackColor = false;
            this.btnxemdanhsach.Click += new System.EventHandler(this.btnxemdanhsach_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncapnhat.Image = global::BanHangSieuThi.Properties.Resources.save;
            this.btncapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncapnhat.Location = new System.Drawing.Point(43, 161);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(75, 40);
            this.btncapnhat.TabIndex = 8;
            this.btncapnhat.Text = "Lưu";
            this.btncapnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncapnhat.UseVisualStyleBackColor = false;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnxoa.Image = global::BanHangSieuThi.Properties.Resources.remove;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(43, 115);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 40);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsua.Image = global::BanHangSieuThi.Properties.Resources.note_edit;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(43, 67);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 42);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnthem.Image = global::BanHangSieuThi.Properties.Resources.add;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(43, 19);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 42);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcmt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbGioiTinh);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txttenkh);
            this.groupBox1.Controls.Add(this.txtmakh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 169);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Giới tính";
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(476, 22);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(121, 21);
            this.cmbGioiTinh.TabIndex = 34;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(149, 129);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(241, 20);
            this.txtdiachi.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Địa chỉ";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(149, 93);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(241, 20);
            this.txtsdt.TabIndex = 31;
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(149, 57);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(241, 20);
            this.txttenkh.TabIndex = 29;
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(149, 22);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(241, 20);
            this.txtmakh.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã khách hàng";
            // 
            // dgvkhachhang
            // 
            this.dgvkhachhang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhachhang.Location = new System.Drawing.Point(9, 189);
            this.dgvkhachhang.Name = "dgvkhachhang";
            this.dgvkhachhang.Size = new System.Drawing.Size(739, 290);
            this.dgvkhachhang.TabIndex = 16;
            this.dgvkhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhachhang_CellClick);
            // 
            // txtcmt
            // 
            this.txtcmt.Location = new System.Drawing.Point(476, 57);
            this.txtcmt.Name = "txtcmt";
            this.txtcmt.Size = new System.Drawing.Size(121, 20);
            this.txtcmt.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "CMTND";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(912, 491);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvkhachhang);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnxemdanhsach;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvkhachhang;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcmt;
        private System.Windows.Forms.Label label3;
    }
}