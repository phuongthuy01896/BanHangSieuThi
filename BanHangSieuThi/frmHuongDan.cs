using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangSieuThi
{
    public partial class frmHuongDan : Form
    {
        public frmHuongDan()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide();
            f.ShowDialog();
        }
    }
}
