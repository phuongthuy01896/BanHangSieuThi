namespace BanHangSieuThi
{
    partial class frmHuongDan
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Hướng dẫn sử dụng phần mềm quản lý bán hàng siêu thị",
            "",
            "1. Đầu tiên bạn cần đăng nhập để sử dụng phần mềm",
            "2. Quản lý nhân viên",
            "\t-Chức năng thêm nhân viên mới",
            "\t-Chức năng sửa thông tin của nhân viên",
            "\t-Chức năng xóa nhân viên",
            "3. Quản lý khách hàng",
            "\t-Chức năng thêm khách hàng mới",
            "\t-Chức năng sửa thông tin khách hàng",
            "\t-Chức năng xóa  khách hàng",
            "4. Quản lý nhập hàng",
            "\t-Chức năng nhập thông tin phiếu nhập mới",
            "\t-Chức năng nhập thông tin các sản phẩm trong phiếu nhập",
            "\t-Chức năng xóa phiếu nhập",
            "5. Quản lý bán hàng",
            "\t-Chức năng nhập hóa đơn mới",
            "\t-Chức năng chọn sản phẩm vào hóa đơn",
            "\t-Chức năng tính tiền và thanh toán",
            "6. Tìm kiếm hàng hóa trong kho",
            "7. Thống kê lưu lượng nhập bán hàng theo tháng "});
            this.listBox1.Location = new System.Drawing.Point(3, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(561, 407);
            this.listBox1.TabIndex = 0;
            // 
            // btnthoat
            // 
            this.btnthoat.Image = global::BanHangSieuThi.Properties.Resources.back;
            this.btnthoat.Location = new System.Drawing.Point(389, 12);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 37);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(565, 474);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.listBox1);
            this.Name = "frmHuongDan";
            this.Text = "frmHuongDan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnthoat;
    }
}