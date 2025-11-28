using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using BTLHoiGiang.Data;

namespace BTLHoiGiang.Forms
{
    public partial class FrmKetQua : Form
    {
        public FrmKetQua()
        {
            InitializeComponent();
        }

        private void FrmKetQua_Load(object sender, EventArgs e)
        {
            LoadHoiGiang();
            LoadKetQua();
        }

        private void LoadHoiGiang()
        {
            var dt = DatabaseHelper.ExecuteQuery("SELECT MaHoiGiang, TenBai, HoTenGV FROM HoiGiang");
            cboHoiGiang.DataSource = dt;
            cboHoiGiang.DisplayMember = "TenBai";
            cboHoiGiang.ValueMember = "MaHoiGiang";
        }

        private void LoadKetQua()
        {
            dgvKetQua.DataSource = DatabaseHelper.ExecuteQuery("SELECT * FROM KetQuaHoiGiang");
        }

        private void btnTinhDiem_Click(object sender, EventArgs e)
        {
            decimal diemHb = numHieuBiet.Value;
            decimal diemGt = numGioiThieu.Value;
            decimal diemTh = numThucHanh1.Value + numThucHanh2.Value + numThucHanh3.Value + numThucHanh4.Value + numThucHanh5.Value;
            decimal avgTh = diemTh / 5;
            numThucHanhTB.Value = avgTh;
            numTongDiem.Value = diemHb + diemGt + avgTh;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboHoiGiang.SelectedValue == null) return;
            DatabaseHelper.ExecuteNonQuery(@"MERGE KetQuaHoiGiang AS target
USING (SELECT @MaHoiGiang AS MaHoiGiang) AS src
ON target.MaHoiGiang = src.MaHoiGiang
WHEN MATCHED THEN UPDATE SET TongDiemHieuBiet=@HB, TongDiemGioiThieu=@GT, DiemThucHanhTrungBinh=@TH, TongDiem=@Tong, XepLoai=@XepLoai, GiaiThuong=@GiaiThuong
WHEN NOT MATCHED THEN INSERT(MaHoiGiang, TongDiemHieuBiet, TongDiemGioiThieu, DiemThucHanhTrungBinh, TongDiem, XepLoai, GiaiThuong)
VALUES(@MaHoiGiang, @HB, @GT, @TH, @Tong, @XepLoai, @GiaiThuong);",
                new SqlParameter("@MaHoiGiang", cboHoiGiang.SelectedValue),
                new SqlParameter("@HB", numHieuBiet.Value),
                new SqlParameter("@GT", numGioiThieu.Value),
                new SqlParameter("@TH", numThucHanhTB.Value),
                new SqlParameter("@Tong", numTongDiem.Value),
                new SqlParameter("@XepLoai", cboXepLoai.Text),
                new SqlParameter("@GiaiThuong", txtGiaiThuong.Text));
            LoadKetQua();
        }
    }
}
