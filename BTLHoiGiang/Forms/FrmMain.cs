using System;
using System.Windows.Forms;

namespace BTLHoiGiang.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void menuGiaoVien_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmGiaoVien());
        }

        private void menuHoiGiang_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmHoiGiang());
        }

        private void menuHoiDong_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmHoiDong());
        }

        private void menuKetQua_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmKetQua());
        }

        private void menuThongKe_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmThongKe());
        }

        private void OpenForm(Form frm)
        {
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
