using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BTLHoiGiang.Data;

namespace BTLHoiGiang.Forms
{
    public partial class FrmGiaoVien : Form
    {
        private bool _isAdding = false;

        public FrmGiaoVien()
        {
            InitializeComponent();
        }

        private void FrmGiaoVien_Load(object sender, EventArgs e)
        {
            LoadData();
            SetEditing(false);
        }

        private void LoadData()
        {
            dgvGiaoVien.DataSource = DatabaseHelper.ExecuteQuery("SELECT * FROM GiaoVien");
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
            if (string.IsNullOrWhiteSpace(txtMaSoCB.Text)) return;
            var confirm = MessageBox.Show("Xóa cán bộ này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                DatabaseHelper.ExecuteNonQuery("DELETE FROM GiaoVien WHERE MaSoCB=@MaSoCB",
                    new SqlParameter("@MaSoCB", txtMaSoCB.Text));
                LoadData();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSoCB.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Mã số CB và Họ tên không được bỏ trống");
                return;
            }

            if (_isAdding)
            {
                DatabaseHelper.ExecuteNonQuery(@"INSERT INTO GiaoVien(MaSoCB, HoTen, GioiTinh, NgaySinh, QueQuan, DanToc, TonGiao, SDT, TrinhDoChuyenMon, TrinhDoLLCT, DonViCongTac, ChucVu, CapBac, HeSoLuong, ChucDanh, HocHam, HocVi, LinhVucChuyenMon, NamDayGioiGanNhat)
                        VALUES(@MaSoCB, @HoTen, @GioiTinh, @NgaySinh, @QueQuan, @DanToc, @TonGiao, @SDT, @TrinhDoChuyenMon, @TrinhDoLLCT, @DonViCongTac, @ChucVu, @CapBac, @HeSoLuong, @ChucDanh, @HocHam, @HocVi, @LinhVucChuyenMon, @NamDayGioiGanNhat)",
                    CreateParameters());
            }
            else
            {
                DatabaseHelper.ExecuteNonQuery(@"UPDATE GiaoVien SET HoTen=@HoTen, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh, QueQuan=@QueQuan, DanToc=@DanToc, TonGiao=@TonGiao, SDT=@SDT, TrinhDoChuyenMon=@TrinhDoChuyenMon, TrinhDoLLCT=@TrinhDoLLCT, DonViCongTac=@DonViCongTac, ChucVu=@ChucVu, CapBac=@CapBac, HeSoLuong=@HeSoLuong, ChucDanh=@ChucDanh, HocHam=@HocHam, HocVi=@HocVi, LinhVucChuyenMon=@LinhVucChuyenMon, NamDayGioiGanNhat=@NamDayGioiGanNhat WHERE MaSoCB=@MaSoCB",
                    CreateParameters());
            }
            SetEditing(false);
            LoadData();
        }

        private SqlParameter[] CreateParameters()
        {
            return new[]
            {
                new SqlParameter("@MaSoCB", txtMaSoCB.Text),
                new SqlParameter("@HoTen", txtHoTen.Text),
                new SqlParameter("@GioiTinh", cboGioiTinh.Text),
                new SqlParameter("@NgaySinh", dtpNgaySinh.Value),
                new SqlParameter("@QueQuan", txtQueQuan.Text),
                new SqlParameter("@DanToc", txtDanToc.Text),
                new SqlParameter("@TonGiao", txtTonGiao.Text),
                new SqlParameter("@SDT", txtSDT.Text),
                new SqlParameter("@TrinhDoChuyenMon", txtTrinhDoChuyenMon.Text),
                new SqlParameter("@TrinhDoLLCT", txtTrinhDoLLCT.Text),
                new SqlParameter("@DonViCongTac", txtDonViCongTac.Text),
                new SqlParameter("@ChucVu", txtChucVu.Text),
                new SqlParameter("@CapBac", txtCapBac.Text),
                new SqlParameter("@HeSoLuong", numHeSoLuong.Value),
                new SqlParameter("@ChucDanh", txtChucDanh.Text),
                new SqlParameter("@HocHam", txtHocHam.Text),
                new SqlParameter("@HocVi", txtHocVi.Text),
                new SqlParameter("@LinhVucChuyenMon", txtLinhVuc.Text),
                new SqlParameter("@NamDayGioiGanNhat", (int)numNamDay.Value)
            };
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

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvGiaoVien.Rows[e.RowIndex];
                txtMaSoCB.Text = row.Cells["MaSoCB"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                cboGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString();
                if (DateTime.TryParse(row.Cells["NgaySinh"].Value?.ToString(), out var date)) dtpNgaySinh.Value = date;
                txtQueQuan.Text = row.Cells["QueQuan"].Value?.ToString();
                txtDanToc.Text = row.Cells["DanToc"].Value?.ToString();
                txtTonGiao.Text = row.Cells["TonGiao"].Value?.ToString();
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                txtTrinhDoChuyenMon.Text = row.Cells["TrinhDoChuyenMon"].Value?.ToString();
                txtTrinhDoLLCT.Text = row.Cells["TrinhDoLLCT"].Value?.ToString();
                txtDonViCongTac.Text = row.Cells["DonViCongTac"].Value?.ToString();
                txtChucVu.Text = row.Cells["ChucVu"].Value?.ToString();
                txtCapBac.Text = row.Cells["CapBac"].Value?.ToString();
                if (decimal.TryParse(row.Cells["HeSoLuong"].Value?.ToString(), out var hsl)) numHeSoLuong.Value = hsl;
                txtChucDanh.Text = row.Cells["ChucDanh"].Value?.ToString();
                txtHocHam.Text = row.Cells["HocHam"].Value?.ToString();
                txtHocVi.Text = row.Cells["HocVi"].Value?.ToString();
                txtLinhVuc.Text = row.Cells["LinhVucChuyenMon"].Value?.ToString();
                if (int.TryParse(row.Cells["NamDayGioiGanNhat"].Value?.ToString(), out var nam)) numNamDay.Value = nam;
            }
        }

        private void ClearInputs()
        {
            foreach (Control c in grpThongTin.Controls)
            {
                if (c is TextBox tb) tb.Clear();
            }
            cboGioiTinh.SelectedIndex = 0;
            numHeSoLuong.Value = 1;
            numNamDay.Value = DateTime.Now.Year;
            dtpNgaySinh.Value = DateTime.Now.AddYears(-25);
        }
    }
}
