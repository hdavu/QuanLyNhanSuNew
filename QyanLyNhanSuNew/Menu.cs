using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QyanLyNhanSuNew
{
    public partial class Menu : Form
    {




        frmHuongDan frmhuongdan = new frmHuongDan();
        frmSuaXoa frmsuaxoa = new frmSuaXoa();
        frmThem frmthem = new frmThem();
        frmThongKeChuyenMon frmtkcm = new frmThongKeChuyenMon();
        frmThongKeThuNhap frmtktn = new frmThongKeThuNhap();
        frmThongTin frmtt = new frmThongTin();



        public Menu()
        {
            InitializeComponent();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthem.ShowDialog();
        }

        private void sửaXóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsuaxoa.ShowDialog();
        }

      

        private void thuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtktn.ShowDialog();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhuongdan.ShowDialog();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtt.ShowDialog();
        }

        private void chuyênMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtkcm.ShowDialog();
        }
    }
}
