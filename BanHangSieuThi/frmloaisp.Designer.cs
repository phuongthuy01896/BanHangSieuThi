namespace BanHangSieuThi
{
    partial class frmloaisp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(269, 153);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnthoat.Image = global::BanHangSieuThi.Properties.Resources.back;
            this.btnthoat.Location = new System.Drawing.Point(96, 12);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 38);
            this.btnthoat.TabIndex = 0;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frmloaisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(276, 216);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnthoat);
            this.Name = "frmloaisp";
            this.Text = "frmloaisp";
            this.Load += new System.EventHandler(this.frmloaisp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}