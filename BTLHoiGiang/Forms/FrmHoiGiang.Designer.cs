namespace BTLHoiGiang.Forms
{
    partial class FrmHoiGiang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboGiangVien = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtCapBac = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtChucDanhGiangDay = new System.Windows.Forms.TextBox();
            this.txtTenBai = new System.Windows.Forms.TextBox();
            this.txtThuocHocPhan = new System.Windows.Forms.TextBox();
            this.txtThucHienTaiLop = new System.Windows.Forms.TextBox();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.cboCapThucHien = new System.Windows.Forms.ComboBox();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.txtMaHoiGiang = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.dgvHoiGiang = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoiGiang)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.tableLayoutPanel1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1182, 220);
            this.panelTop.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Mã hội giảng", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},0,0);
            this.tableLayoutPanel1.Controls.Add(this.txtMaHoiGiang,1,0);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Chọn giảng viên", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},2,0);
            this.tableLayoutPanel1.Controls.Add(this.cboGiangVien,3,0);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Họ tên", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},0,1);
            this.tableLayoutPanel1.Controls.Add(this.txtHoTen,1,1);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Cấp bậc", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},2,1);
            this.tableLayoutPanel1.Controls.Add(this.txtCapBac,3,1);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Đơn vị công tác", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},0,2);
            this.tableLayoutPanel1.Controls.Add(this.txtDonVi,1,2);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Chức danh giảng dạy", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},2,2);
            this.tableLayoutPanel1.Controls.Add(this.txtChucDanhGiangDay,3,2);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Tên bài", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},0,3);
            this.tableLayoutPanel1.Controls.Add(this.txtTenBai,1,3);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Thuộc học phần", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},2,3);
            this.tableLayoutPanel1.Controls.Add(this.txtThuocHocPhan,3,3);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Thực hiện tại lớp", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},0,4);
            this.tableLayoutPanel1.Controls.Add(this.txtThucHienTaiLop,1,4);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Thời gian thực hiện", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},2,4);
            this.tableLayoutPanel1.Controls.Add(this.dtpThoiGian,3,4);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Cấp thực hiện", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},0,5);
            this.tableLayoutPanel1.Controls.Add(this.cboCapThucHien,1,5);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Năm học", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},2,5);
            this.tableLayoutPanel1.Controls.Add(this.txtNamHoc,3,5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1182, 220);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cboGiangVien
            // 
            this.cboGiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGiangVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGiangVien.Location = new System.Drawing.Point(829, 4);
            this.cboGiangVien.Name = "cboGiangVien";
            this.cboGiangVien.Size = new System.Drawing.Size(350, 28);
            this.cboGiangVien.TabIndex = 1;
            this.cboGiangVien.SelectedIndexChanged += new System.EventHandler(this.cboGiangVien_SelectedIndexChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoTen.Location = new System.Drawing.Point(239, 40);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(348, 27);
            this.txtHoTen.TabIndex = 2;
            // 
            // txtCapBac
            // 
            this.txtCapBac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCapBac.Location = new System.Drawing.Point(829, 40);
            this.txtCapBac.Name = "txtCapBac";
            this.txtCapBac.ReadOnly = true;
            this.txtCapBac.Size = new System.Drawing.Size(350, 27);
            this.txtCapBac.TabIndex = 3;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonVi.Location = new System.Drawing.Point(239, 76);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.ReadOnly = true;
            this.txtDonVi.Size = new System.Drawing.Size(348, 27);
            this.txtDonVi.TabIndex = 4;
            // 
            // txtChucDanhGiangDay
            // 
            this.txtChucDanhGiangDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChucDanhGiangDay.Location = new System.Drawing.Point(829, 76);
            this.txtChucDanhGiangDay.Name = "txtChucDanhGiangDay";
            this.txtChucDanhGiangDay.Size = new System.Drawing.Size(350, 27);
            this.txtChucDanhGiangDay.TabIndex = 5;
            // 
            // txtTenBai
            // 
            this.txtTenBai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenBai.Location = new System.Drawing.Point(239, 112);
            this.txtTenBai.Name = "txtTenBai";
            this.txtTenBai.Size = new System.Drawing.Size(348, 27);
            this.txtTenBai.TabIndex = 6;
            // 
            // txtThuocHocPhan
            // 
            this.txtThuocHocPhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThuocHocPhan.Location = new System.Drawing.Point(829, 112);
            this.txtThuocHocPhan.Name = "txtThuocHocPhan";
            this.txtThuocHocPhan.Size = new System.Drawing.Size(350, 27);
            this.txtThuocHocPhan.TabIndex = 7;
            // 
            // txtThucHienTaiLop
            // 
            this.txtThucHienTaiLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThucHienTaiLop.Location = new System.Drawing.Point(239, 148);
            this.txtThucHienTaiLop.Name = "txtThucHienTaiLop";
            this.txtThucHienTaiLop.Size = new System.Drawing.Size(348, 27);
            this.txtThucHienTaiLop.TabIndex = 8;
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpThoiGian.Location = new System.Drawing.Point(829, 148);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(350, 27);
            this.dtpThoiGian.TabIndex = 9;
            // 
            // cboCapThucHien
            // 
            this.cboCapThucHien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCapThucHien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCapThucHien.Items.AddRange(new object[] {
            "Cấp Học viện",
            "Cấp Bộ"});
            this.cboCapThucHien.Location = new System.Drawing.Point(239, 186);
            this.cboCapThucHien.Name = "cboCapThucHien";
            this.cboCapThucHien.Size = new System.Drawing.Size(348, 28);
            this.cboCapThucHien.TabIndex = 10;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamHoc.Location = new System.Drawing.Point(829, 186);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(350, 27);
            this.txtNamHoc.TabIndex = 11;
            // 
            // txtMaHoiGiang
            // 
            this.txtMaHoiGiang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaHoiGiang.Location = new System.Drawing.Point(239, 4);
            this.txtMaHoiGiang.Name = "txtMaHoiGiang";
            this.txtMaHoiGiang.ReadOnly = true;
            this.txtMaHoiGiang.Size = new System.Drawing.Size(348, 27);
            this.txtMaHoiGiang.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnThem);
            this.panelButtons.Controls.Add(this.btnSua);
            this.panelButtons.Controls.Add(this.btnXoa);
            this.panelButtons.Controls.Add(this.btnLuu);
            this.panelButtons.Controls.Add(this.btnHuy);
            this.panelButtons.Controls.Add(this.btnTaiLai);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 220);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1182, 45);
            this.panelButtons.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(103, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(203, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(303, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 29);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(403, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 29);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(503, 3);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(94, 29);
            this.btnTaiLai.TabIndex = 5;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // dgvHoiGiang
            // 
            this.dgvHoiGiang.AllowUserToAddRows = false;
            this.dgvHoiGiang.AllowUserToDeleteRows = false;
            this.dgvHoiGiang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoiGiang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoiGiang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoiGiang.Location = new System.Drawing.Point(0, 265);
            this.dgvHoiGiang.Name = "dgvHoiGiang";
            this.dgvHoiGiang.ReadOnly = true;
            this.dgvHoiGiang.RowHeadersWidth = 51;
            this.dgvHoiGiang.RowTemplate.Height = 29;
            this.dgvHoiGiang.Size = new System.Drawing.Size(1182, 388);
            this.dgvHoiGiang.TabIndex = 2;
            this.dgvHoiGiang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoiGiang_CellClick);
            // 
            // FrmHoiGiang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.dgvHoiGiang);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelTop);
            this.Name = "FrmHoiGiang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký hội giảng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHoiGiang_Load);
            this.panelTop.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoiGiang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cboGiangVien;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCapBac;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtChucDanhGiangDay;
        private System.Windows.Forms.TextBox txtTenBai;
        private System.Windows.Forms.TextBox txtThuocHocPhan;
        private System.Windows.Forms.TextBox txtThucHienTaiLop;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.ComboBox cboCapThucHien;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.TextBox txtMaHoiGiang;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.DataGridView dgvHoiGiang;
    }
}
