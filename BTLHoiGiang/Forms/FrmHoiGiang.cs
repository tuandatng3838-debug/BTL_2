using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using BTLHoiGiang.Data;

namespace BTLHoiGiang.Forms
{
    public partial class FrmHoiGiang : Form
    {
        private bool _isAdding = false;

        public FrmHoiGiang()
        {
            InitializeComponent();
        }

        private void FrmHoiGiang_Load(object sender, EventArgs e)
        {
            LoadLecturers();
            LoadData();
            SetEditing(false);
        }

        private void LoadLecturers()
        {
            var dt = DatabaseHelper.ExecuteQuery("SELECT MaSoCB, HoTen, CapBac, DonViCongTac, ChucDanh FROM GiaoVien");
            cboGiangVien.DataSource = dt;
            cboGiangVien.DisplayMember = "HoTen";
            cboGiangVien.ValueMember = "MaSoCB";
        }

        private void LoadData()
        {
            dgvHoiGiang.DataSource = DatabaseHelper.ExecuteQuery("SELECT * FROM HoiGiang");
        }

        private void cboGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGiangVien.SelectedItem is DataRowView row)
            {
                txtHoTen.Text = row["HoTen"].ToString();
                txtCapBac.Text = row["CapBac"].ToString();
                txtDonVi.Text = row["DonViCongTac"].ToString();
                txtChucDanhGiangDay.Text = row["ChucDanh"].ToString();
            }
        }

        private void SetEditing(bool editing)
        {
            btnLuu.Enabled = editing;
            btnHuy.Enabled = editing;
            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _isAdding = true;
            ClearInputs();
            SetEditing(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _isAdding = false;
            SetEditing(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHoiGiang.Text)) return;
            var confirm = MessageBox.Show("Xóa bản ghi này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                DatabaseHelper.ExecuteNonQuery("DELETE FROM HoiGiang WHERE MaHoiGiang=@Ma",
                    new SqlParameter("@Ma", int.Parse(txtMaHoiGiang.Text)));
                LoadData();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboGiangVien.SelectedValue == null) return;
            var parameters = new[]
            {
                new SqlParameter("@MaSoCB", cboGiangVien.SelectedValue),
                new SqlParameter("@HoTenGV", txtHoTen.Text),
                new SqlParameter("@CapBac", txtCapBac.Text),
                new SqlParameter("@DonViCongTac", txtDonVi.Text),
                new SqlParameter("@ChucDanhGiangDay", txtChucDanhGiangDay.Text),
                new SqlParameter("@TenBai", txtTenBai.Text),
                new SqlParameter("@ThuocHocPhan", txtThuocHocPhan.Text),
                new SqlParameter("@ThucHienTaiLop", txtThucHienTaiLop.Text),
                new SqlParameter("@ThoiGianThucHien", dtpThoiGian.Value),
                new SqlParameter("@CapThucHien", cboCapThucHien.Text),
                new SqlParameter("@NamHoc", txtNamHoc.Text)
            };

            if (_isAdding)
            {
                DatabaseHelper.ExecuteNonQuery(@"INSERT INTO HoiGiang(MaSoCB, HoTenGV, CapBac, DonViCongTac, ChucDanhGiangDay, TenBai, ThuocHocPhan, ThucHienTaiLop, ThoiGianThucHien, CapThucHien, NamHoc)
                        VALUES(@MaSoCB, @HoTenGV, @CapBac, @DonViCongTac, @ChucDanhGiangDay, @TenBai, @ThuocHocPhan, @ThucHienTaiLop, @ThoiGianThucHien, @CapThucHien, @NamHoc)", parameters);
            }
            else
            {
                parameters = parameters.Append(new SqlParameter("@MaHoiGiang", int.Parse(txtMaHoiGiang.Text))).ToArray();
                DatabaseHelper.ExecuteNonQuery(@"UPDATE HoiGiang SET MaSoCB=@MaSoCB, HoTenGV=@HoTenGV, CapBac=@CapBac, DonViCongTac=@DonViCongTac, ChucDanhGiangDay=@ChucDanhGiangDay, TenBai=@TenBai, ThuocHocPhan=@ThuocHocPhan, ThucHienTaiLop=@ThucHienTaiLop, ThoiGianThucHien=@ThoiGianThucHien, CapThucHien=@CapThucHien, NamHoc=@NamHoc WHERE MaHoiGiang=@MaHoiGiang", parameters);
            }
            SetEditing(false);
            LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetEditing(false);
            LoadData();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvHoiGiang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvHoiGiang.Rows[e.RowIndex];
                txtMaHoiGiang.Text = row.Cells["MaHoiGiang"].Value?.ToString();
                cboGiangVien.SelectedValue = row.Cells["MaSoCB"].Value;
                txtHoTen.Text = row.Cells["HoTenGV"].Value?.ToString();
                txtCapBac.Text = row.Cells["CapBac"].Value?.ToString();
                txtDonVi.Text = row.Cells["DonViCongTac"].Value?.ToString();
                txtChucDanhGiangDay.Text = row.Cells["ChucDanhGiangDay"].Value?.ToString();
                txtTenBai.Text = row.Cells["TenBai"].Value?.ToString();
                txtThuocHocPhan.Text = row.Cells["ThuocHocPhan"].Value?.ToString();
                txtThucHienTaiLop.Text = row.Cells["ThucHienTaiLop"].Value?.ToString();
                if (DateTime.TryParse(row.Cells["ThoiGianThucHien"].Value?.ToString(), out var date)) dtpThoiGian.Value = date;
                cboCapThucHien.Text = row.Cells["CapThucHien"].Value?.ToString();
                txtNamHoc.Text = row.Cells["NamHoc"].Value?.ToString();
            }
        }

        private void ClearInputs()
        {
            txtMaHoiGiang.Clear();
            txtTenBai.Clear();
            txtThuocHocPhan.Clear();
            txtThucHienTaiLop.Clear();
            txtNamHoc.Clear();
        }
    }
}
