namespace BanHangSieuThi
{
    partial class frmKhoHang
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
            this.dgvsanpham = new System.Windows.Forms.DataGridView();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.btnchon = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvsanpham
            // 
            this.dgvsanpham.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsanpham.Location = new System.Drawing.Point(-3, 101);
            this.dgvsanpham.Name = "dgvsanpham";
            this.dgvsanpham.Size = new System.Drawing.Size(769, 378);
            this.dgvsanpham.TabIndex = 7;
            this.dgvsanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsanpham_CellClick);
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(441, 21);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(100, 20);
            this.txtmasp.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã  sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số lượng";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(657, 62);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(100, 20);
            this.txtsoluong.TabIndex = 13;
            // 
            // btnchon
            // 
            this.btnchon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnchon.Image = global::BanHangSieuThi.Properties.Resources.accept;
            this.btnchon.Location = new System.Drawing.Point(252, 485);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(75, 38);
            this.btnchon.TabIndex = 10;
            this.btnchon.UseVisualStyleBackColor = false;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnthoat.Image = global::BanHangSieuThi.Properties.Resources.back;
            this.btnthoat.Location = new System.Drawing.Point(431, 485);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 38);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Đơn giá";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(441, 59);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(100, 20);
            this.txtdongia.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntimkiem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txttimkiem);
            this.groupBox1.Location = new System.Drawing.Point(-3, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 87);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Image = global::BanHangSieuThi.Properties.Resources.search;
            this.btntimkiem.Location = new System.Drawing.Point(233, 29);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(59, 38);
            this.btntimkiem.TabIndex = 12;
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(657, 21);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(100, 20);
            this.txttensp.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(111, 36);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(100, 20);
            this.txttimkiem.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã sản phẩm";
            // 
            // frmKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(769, 535);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.dgvsanpham);
            this.Name = "frmKhoHang";
            this.Text = "Kho hàng";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsanpham;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.Label label2;
    }
}