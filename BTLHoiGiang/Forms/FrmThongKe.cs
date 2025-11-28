using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BTLHoiGiang.Data;

namespace BTLHoiGiang.Forms
{
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            LoadThongKeHoiDong();
            LoadThongKeCap();
            LoadThongKeGiai();
        }

        private void LoadThongKeHoiDong()
        {
            dgvHoiDong.DataSource = DatabaseHelper.ExecuteQuery(@"SELECT tv.MaSoCB, tv.HoTen, gv.DonViCongTac, COUNT(*) AS SoLanThamGiaHoiDong
FROM HoiDong_ThanhVien tv JOIN GiaoVien gv ON tv.MaSoCB = gv.MaSoCB
GROUP BY tv.MaSoCB, tv.HoTen, gv.DonViCongTac");
        }

        private void LoadThongKeCap()
        {
            dgvCap.DataSource = DatabaseHelper.ExecuteQuery(@"SELECT NamHoc, SUM(CASE WHEN CapThucHien = 'Cấp Học viện' THEN 1 ELSE 0 END) AS SoHoiGiangCapHocVien,
SUM(CASE WHEN CapThucHien = 'Cấp Bộ' THEN 1 ELSE 0 END) AS SoHoiGiangCapBo FROM HoiGiang GROUP BY NamHoc");
        }

        private void LoadThongKeGiai()
        {
            dgvGiai.DataSource = DatabaseHelper.ExecuteQuery(@"SELECT gv.DonViCongTac AS TenKhoa,
SUM(CASE WHEN kq.XepLoai='Nhất' THEN 1 ELSE 0 END) AS SoGiaiNhat,
SUM(CASE WHEN kq.XepLoai='Nhì' THEN 1 ELSE 0 END) AS SoGiaiNhi,
SUM(CASE WHEN kq.XepLoai='Ba' THEN 1 ELSE 0 END) AS SoGiaiBa,
SUM(CASE WHEN kq.XepLoai='Khuyến khích' THEN 1 ELSE 0 END) AS SoGiaiKhuyenKhich,
COUNT(*) AS TongSoGiai
FROM GiaoVien gv JOIN HoiGiang hg ON gv.MaSoCB = hg.MaSoCB JOIN KetQuaHoiGiang kq ON hg.MaHoiGiang = kq.MaHoiGiang
GROUP BY gv.DonViCongTac");
        }
    }
}
