namespace BanHangSieuThi
{
    partial class frmThongKe
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnhangnhap = new System.Windows.Forms.Button();
            this.btnhangxuat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbthang = new System.Windows.Forms.ComboBox();
            this.btnHangtrongkho = new System.Windows.Forms.Button();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Image = global::BanHangSieuThi.Properties.Resources.back;
            this.btnthoat.Location = new System.Drawing.Point(42, 12);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(67, 34);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnhangnhap);
            this.groupBox1.Controls.Add(this.btnhangxuat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbthang);
            this.groupBox1.Controls.Add(this.btnHangtrongkho);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 111);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // btnhangnhap
            // 
            this.btnhangnhap.BackColor = System.Drawing.Color.Yellow;
            this.btnhangnhap.ForeColor = System.Drawing.Color.Blue;
            this.btnhangnhap.Location = new System.Drawing.Point(88, 20);
            this.btnhangnhap.Name = "btnhangnhap";
            this.btnhangnhap.Size = new System.Drawing.Size(167, 23);
            this.btnhangnhap.TabIndex = 14;
            this.btnhangnhap.Text = "Lưu lượng nhập";
            this.btnhangnhap.UseVisualStyleBackColor = false;
            this.btnhangnhap.Click += new System.EventHandler(this.btnhangnhap_Click);
            // 
            // btnhangxuat
            // 
            this.btnhangxuat.BackColor = System.Drawing.Color.Yellow;
            this.btnhangxuat.ForeColor = System.Drawing.Color.Blue;
            this.btnhangxuat.Location = new System.Drawing.Point(88, 49);
            this.btnhangxuat.Name = "btnhangxuat";
            this.btnhangxuat.Size = new System.Drawing.Size(167, 23);
            this.btnhangxuat.TabIndex = 13;
            this.btnhangxuat.Text = "Lưu lượng xuất";
            this.btnhangxuat.UseVisualStyleBackColor = false;
            this.btnhangxuat.Click += new System.EventHandler(this.btnhangxuat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tháng";
            // 
            // cmbthang
            // 
            this.cmbthang.FormattingEnabled = true;
            this.cmbthang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbthang.Location = new System.Drawing.Point(362, 27);
            this.cmbthang.Name = "cmbthang";
            this.cmbthang.Size = new System.Drawing.Size(121, 21);
            this.cmbthang.TabIndex = 6;
            // 
            // btnHangtrongkho
            // 
            this.btnHangtrongkho.BackColor = System.Drawing.Color.Yellow;
            this.btnHangtrongkho.ForeColor = System.Drawing.Color.Blue;
            this.btnHangtrongkho.Location = new System.Drawing.Point(88, 78);
            this.btnHangtrongkho.Name = "btnHangtrongkho";
            this.btnHangtrongkho.Size = new System.Drawing.Size(167, 23);
            this.btnHangtrongkho.TabIndex = 3;
            this.btnHangtrongkho.Text = "Số lượng hàng còn trong kho";
            this.btnHangtrongkho.UseVisualStyleBackColor = false;
            this.btnHangtrongkho.Click += new System.EventHandler(this.btnHangtrongkho_Click);
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(12, 176);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.Size = new System.Drawing.Size(629, 149);
            this.dgvThongKe.TabIndex = 5;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(649, 337);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvThongKe);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnhangnhap;
        private System.Windows.Forms.Button btnhangxuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbthang;
        private System.Windows.Forms.Button btnHangtrongkho;
        private System.Windows.Forms.DataGridView dgvThongKe;
    }
}