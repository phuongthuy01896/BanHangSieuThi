﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace BanHangSieuThi
{
    public partial class frmloaisp : Form
    {
        public frmloaisp()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public static string ma;
        private void frmloaisp_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kn.GetDataTable("select* from loaihang where maLH='" + ma + "'");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
