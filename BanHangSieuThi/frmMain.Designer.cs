namespace BanHangSieuThi
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnthongke = new System.Windows.Forms.Button();
            this.btnhelp = new System.Windows.Forms.Button();
            this.btnnhanvien = new System.Windows.Forms.Button();
            this.btnnhaphang = new System.Windows.Forms.Button();
            this.btnkhachhang = new System.Windows.Forms.Button();
            this.btnbanhang = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(127, 319);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(437, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Phần mềm bán hàng siêu thị";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btntimkiem);
            this.groupBox1.Controls.Add(this.btnthongke);
            this.groupBox1.Controls.Add(this.btnhelp);
            this.groupBox1.Controls.Add(this.btnnhanvien);
            this.groupBox1.Controls.Add(this.btnnhaphang);
            this.groupBox1.Controls.Add(this.btnkhachhang);
            this.groupBox1.Controls.Add(this.btnbanhang);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.groupBox1.Location = new System.Drawing.Point(18, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 148);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Image = global::BanHangSieuThi.Properties.Resources.users;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(502, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "Người dùng";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btntimkiem.ForeColor = System.Drawing.Color.Blue;
            this.btntimkiem.Image = global::BanHangSieuThi.Properties.Resources.database_search;
            this.btntimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimkiem.Location = new System.Drawing.Point(437, 79);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(87, 56);
            this.btntimkiem.TabIndex = 6;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnthongke
            // 
            this.btnthongke.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnthongke.ForeColor = System.Drawing.Color.Blue;
            this.btnthongke.Image = global::BanHangSieuThi.Properties.Resources.calculator;
            this.btnthongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthongke.Location = new System.Drawing.Point(286, 79);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(83, 56);
            this.btnthongke.TabIndex = 5;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthongke.UseVisualStyleBackColor = false;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // btnhelp
            // 
            this.btnhelp.BackColor = System.Drawing.Color.DarkRed;
            this.btnhelp.Image = global::BanHangSieuThi.Properties.Resources.help;
            this.btnhelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhelp.Location = new System.Drawing.Point(26, 96);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(42, 39);
            this.btnhelp.TabIndex = 4;
            this.btnhelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhelp.UseVisualStyleBackColor = false;
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnhanvien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnnhanvien.ForeColor = System.Drawing.Color.Blue;
            this.btnnhanvien.Image = global::BanHangSieuThi.Properties.Resources.users;
            this.btnnhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhanvien.Location = new System.Drawing.Point(62, 19);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Size = new System.Drawing.Size(81, 54);
            this.btnnhanvien.TabIndex = 3;
            this.btnnhanvien.Text = "Nhân viên";
            this.btnnhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnhanvien.UseVisualStyleBackColor = false;
            this.btnnhanvien.Click += new System.EventHandler(this.btnnhanvien_Click);
            // 
            // btnnhaphang
            // 
            this.btnnhaphang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnnhaphang.ForeColor = System.Drawing.Color.Blue;
            this.btnnhaphang.Image = global::BanHangSieuThi.Properties.Resources.database_accept;
            this.btnnhaphang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhaphang.Location = new System.Drawing.Point(354, 19);
            this.btnnhaphang.Name = "btnnhaphang";
            this.btnnhaphang.Size = new System.Drawing.Size(87, 54);
            this.btnnhaphang.TabIndex = 2;
            this.btnnhaphang.Text = "Nhập hàng";
            this.btnnhaphang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnhaphang.UseVisualStyleBackColor = false;
            this.btnnhaphang.Click += new System.EventHandler(this.btnnhaphang_Click);
            // 
            // btnkhachhang
            // 
            this.btnkhachhang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnkhachhang.ForeColor = System.Drawing.Color.Blue;
            this.btnkhachhang.Image = global::BanHangSieuThi.Properties.Resources.she_user_accept;
            this.btnkhachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkhachhang.Location = new System.Drawing.Point(142, 79);
            this.btnkhachhang.Name = "btnkhachhang";
            this.btnkhachhang.Size = new System.Drawing.Size(81, 56);
            this.btnkhachhang.TabIndex = 1;
            this.btnkhachhang.Text = "Khách hàng";
            this.btnkhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkhachhang.UseVisualStyleBackColor = false;
            this.btnkhachhang.Click += new System.EventHandler(this.btnkhachhang_Click);
            // 
            // btnbanhang
            // 
            this.btnbanhang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnbanhang.ForeColor = System.Drawing.Color.Blue;
            this.btnbanhang.Image = global::BanHangSieuThi.Properties.Resources.shopping_cart_accept;
            this.btnbanhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbanhang.Location = new System.Drawing.Point(209, 19);
            this.btnbanhang.Name = "btnbanhang";
            this.btnbanhang.Size = new System.Drawing.Size(83, 54);
            this.btnbanhang.TabIndex = 0;
            this.btnbanhang.Text = "Bán hàng";
            this.btnbanhang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbanhang.UseVisualStyleBackColor = false;
            this.btnbanhang.Click += new System.EventHandler(this.btnbanhang_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BanHangSieuThi.Properties.Resources._20160115_things_never_to_but_at_supermarket_;
            this.pictureBox1.Location = new System.Drawing.Point(18, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(643, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(679, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.Button btnhelp;
        private System.Windows.Forms.Button btnnhanvien;
        private System.Windows.Forms.Button btnnhaphang;
        private System.Windows.Forms.Button btnbanhang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnkhachhang;
    }
}