using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using BTLHoiGiang.Data;

namespace BTLHoiGiang.Forms
{
    public partial class FrmHoiDong : Form
    {
        public FrmHoiDong()
        {
            InitializeComponent();
        }

        private void FrmHoiDong_Load(object sender, EventArgs e)
        {
            LoadHoiGiang();
            LoadLecturers();
            LoadHoiDongGrid();
        }

        private void LoadHoiGiang()
        {
            var dt = DatabaseHelper.ExecuteQuery("SELECT MaHoiGiang, TenBai, HoTenGV FROM HoiGiang");
            cboHoiGiang.DataSource = dt;
            cboHoiGiang.DisplayMember = "TenBai";
            cboHoiGiang.ValueMember = "MaHoiGiang";
        }

        private void LoadLecturers()
        {
            var dt = DatabaseHelper.ExecuteQuery("SELECT MaSoCB, HoTen, CapBac, ChucDanh FROM GiaoVien");
            for (int i = 0; i < 5; i++)
            {
                var combo = tableMembers.Controls.OfType<ComboBox>().ElementAt(i);
                combo.DataSource = dt.Copy();
                combo.DisplayMember = "HoTen";
                combo.ValueMember = "MaSoCB";
            }
        }

        private void LoadHoiDongGrid()
        {
            dgvHoiDong.DataSource = DatabaseHelper.ExecuteQuery(@"SELECT hd.MaHoiDong, hd.MaHoiGiang, hg.TenBai, hd.GhiChu FROM HoiDong hd JOIN HoiGiang hg ON hd.MaHoiGiang = hg.MaHoiGiang");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboHoiGiang.SelectedValue == null) return;
            int hoiGiangId = Convert.ToInt32(cboHoiGiang.SelectedValue);
            object? existing = DatabaseHelper.ExecuteScalar("SELECT MaHoiDong FROM HoiDong WHERE MaHoiGiang=@Ma",
                new SqlParameter("@Ma", hoiGiangId));
            int hoiDongId;
            if (existing == null)
            {
                DatabaseHelper.ExecuteNonQuery("INSERT INTO HoiDong(MaHoiGiang, GhiChu) VALUES(@Ma,@GhiChu)",
                    new SqlParameter("@Ma", hoiGiangId), new SqlParameter("@GhiChu", txtGhiChu.Text));
                hoiDongId = Convert.ToInt32(DatabaseHelper.ExecuteScalar("SELECT SCOPE_IDENTITY()"));
            }
            else
            {
                hoiDongId = Convert.ToInt32(existing);
                DatabaseHelper.ExecuteNonQuery("UPDATE HoiDong SET GhiChu=@GhiChu WHERE MaHoiDong=@Id",
                    new SqlParameter("@GhiChu", txtGhiChu.Text), new SqlParameter("@Id", hoiDongId));
                DatabaseHelper.ExecuteNonQuery("DELETE FROM HoiDong_ThanhVien WHERE MaHoiDong=@Id", new SqlParameter("@Id", hoiDongId));
            }

            for (int i = 0; i < 5; i++)
            {
                var combo = tableMembers.Controls.OfType<ComboBox>().ElementAt(i);
                var chucDanh = tableMembers.Controls.OfType<ComboBox>().ElementAt(5 + i);
                var capBac = tableMembers.Controls.OfType<TextBox>().ElementAt(i * 2);
                var chucDanhGD = tableMembers.Controls.OfType<TextBox>().ElementAt(i * 2 + 1);
                DatabaseHelper.ExecuteNonQuery(@"INSERT INTO HoiDong_ThanhVien(MaHoiDong, MaSoCB, HoTen, CapBac, ChucDanhGiangDay, ChucDanhTrongHoiDong)
                        VALUES(@MaHoiDong, @MaSoCB, @HoTen, @CapBac, @ChucDanhGD, @ChucDanhHD)",
                    new SqlParameter("@MaHoiDong", hoiDongId),
                    new SqlParameter("@MaSoCB", combo.SelectedValue ?? ""),
                    new SqlParameter("@HoTen", combo.Text),
                    new SqlParameter("@CapBac", capBac.Text),
                    new SqlParameter("@ChucDanhGD", chucDanhGD.Text),
                    new SqlParameter("@ChucDanhHD", chucDanh.Text));
            }
            LoadHoiDongGrid();
        }

        private void dgvHoiDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvHoiDong.Rows[e.RowIndex];
                txtMaHoiDong.Text = row.Cells["MaHoiDong"].Value?.ToString();
                cboHoiGiang.SelectedValue = row.Cells["MaHoiGiang"].Value;
            }
        }
    }
}
