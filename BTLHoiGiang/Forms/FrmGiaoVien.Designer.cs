namespace BTLHoiGiang.Forms
{
    partial class FrmGiaoVien
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
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMaSoCB = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtDanToc = new System.Windows.Forms.TextBox();
            this.txtTonGiao = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTrinhDoChuyenMon = new System.Windows.Forms.TextBox();
            this.txtTrinhDoLLCT = new System.Windows.Forms.TextBox();
            this.txtDonViCongTac = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtCapBac = new System.Windows.Forms.TextBox();
            this.numHeSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtChucDanh = new System.Windows.Forms.TextBox();
            this.txtHocHam = new System.Windows.Forms.TextBox();
            this.txtHocVi = new System.Windows.Forms.TextBox();
            this.txtLinhVuc = new System.Windows.Forms.TextBox();
            this.numNamDay = new System.Windows.Forms.NumericUpDown();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.grpThongTin.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamDay)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.tableLayoutPanel1);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTin.Location = new System.Drawing.Point(0, 0);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1182, 250);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin cán bộ, giáo viên";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Mã số CB", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},0,0);
            this.tableLayoutPanel1.Controls.Add(this.txtMaSoCB,1,0);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Họ tên", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},2,0);
            this.tableLayoutPanel1.Controls.Add(this.txtHoTen,3,0);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Giới tính", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},4,0);
            this.tableLayoutPanel1.Controls.Add(this.cboGioiTinh,5,0);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Ngày sinh", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},0,1);
            this.tableLayoutPanel1.Controls.Add(this.dtpNgaySinh,1,1);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Quê quán", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},2,1);
            this.tableLayoutPanel1.Controls.Add(this.txtQueQuan,3,1);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Dân tộc", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},4,1);
            this.tableLayoutPanel1.Controls.Add(this.txtDanToc,5,1);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Tôn giáo", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},0,2);
            this.tableLayoutPanel1.Controls.Add(this.txtTonGiao,1,2);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="SĐT", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},2,2);
            this.tableLayoutPanel1.Controls.Add(this.txtSDT,3,2);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Trình độ chuyên môn", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},4,2);
            this.tableLayoutPanel1.Controls.Add(this.txtTrinhDoChuyenMon,5,2);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Trình độ LLCT", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},0,3);
            this.tableLayoutPanel1.Controls.Add(this.txtTrinhDoLLCT,1,3);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Đơn vị công tác", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},2,3);
            this.tableLayoutPanel1.Controls.Add(this.txtDonViCongTac,3,3);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Chức vụ", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},4,3);
            this.tableLayoutPanel1.Controls.Add(this.txtChucVu,5,3);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Cấp bậc", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},0,4);
            this.tableLayoutPanel1.Controls.Add(this.txtCapBac,1,4);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Hệ số lương", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},2,4);
            this.tableLayoutPanel1.Controls.Add(this.numHeSoLuong,3,4);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Chức danh", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},4,4);
            this.tableLayoutPanel1.Controls.Add(this.txtChucDanh,5,4);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Học hàm", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},0,5);
            this.tableLayoutPanel1.Controls.Add(this.txtHocHam,1,5);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Học vị", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},2,5);
            this.tableLayoutPanel1.Controls.Add(this.txtHocVi,3,5);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Lĩnh vực giảng dạy / chuyên môn", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},4,5);
            this.tableLayoutPanel1.Controls.Add(this.txtLinhVuc,5,5);
            this.tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label(){Text="Năm dạy giỏi gần nhất", Anchor=System.Windows.Forms.AnchorStyles.Right, AutoSize=true},0,6);
            this.tableLayoutPanel1.Controls.Add(this.numNamDay,1,6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1176, 224);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtMaSoCB
            // 
            this.txtMaSoCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaSoCB.Location = new System.Drawing.Point(191, 4);
            this.txtMaSoCB.Name = "txtMaSoCB";
            this.txtMaSoCB.Size = new System.Drawing.Size(194, 27);
            this.txtMaSoCB.TabIndex = 0;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoTen.Location = new System.Drawing.Point(577, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(194, 27);
            this.txtHoTen.TabIndex = 1;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cboGioiTinh.Location = new System.Drawing.Point(963, 4);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(210, 28);
            this.cboGioiTinh.TabIndex = 2;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgaySinh.Location = new System.Drawing.Point(191, 36);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(194, 27);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueQuan.Location = new System.Drawing.Point(577, 36);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(194, 27);
            this.txtQueQuan.TabIndex = 4;
            // 
            // txtDanToc
            // 
            this.txtDanToc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDanToc.Location = new System.Drawing.Point(963, 36);
            this.txtDanToc.Name = "txtDanToc";
            this.txtDanToc.Size = new System.Drawing.Size(210, 27);
            this.txtDanToc.TabIndex = 5;
            // 
            // txtTonGiao
            // 
            this.txtTonGiao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTonGiao.Location = new System.Drawing.Point(191, 68);
            this.txtTonGiao.Name = "txtTonGiao";
            this.txtTonGiao.Size = new System.Drawing.Size(194, 27);
            this.txtTonGiao.TabIndex = 6;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT.Location = new System.Drawing.Point(577, 68);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(194, 27);
            this.txtSDT.TabIndex = 7;
            // 
            // txtTrinhDoChuyenMon
            // 
            this.txtTrinhDoChuyenMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrinhDoChuyenMon.Location = new System.Drawing.Point(963, 68);
            this.txtTrinhDoChuyenMon.Name = "txtTrinhDoChuyenMon";
            this.txtTrinhDoChuyenMon.Size = new System.Drawing.Size(210, 27);
            this.txtTrinhDoChuyenMon.TabIndex = 8;
            // 
            // txtTrinhDoLLCT
            // 
            this.txtTrinhDoLLCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrinhDoLLCT.Location = new System.Drawing.Point(191, 100);
            this.txtTrinhDoLLCT.Name = "txtTrinhDoLLCT";
            this.txtTrinhDoLLCT.Size = new System.Drawing.Size(194, 27);
            this.txtTrinhDoLLCT.TabIndex = 9;
            // 
            // txtDonViCongTac
            // 
            this.txtDonViCongTac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonViCongTac.Location = new System.Drawing.Point(577, 100);
            this.txtDonViCongTac.Name = "txtDonViCongTac";
            this.txtDonViCongTac.Size = new System.Drawing.Size(194, 27);
            this.txtDonViCongTac.TabIndex = 10;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChucVu.Location = new System.Drawing.Point(963, 100);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(210, 27);
            this.txtChucVu.TabIndex = 11;
            // 
            // txtCapBac
            // 
            this.txtCapBac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCapBac.Location = new System.Drawing.Point(191, 132);
            this.txtCapBac.Name = "txtCapBac";
            this.txtCapBac.Size = new System.Drawing.Size(194, 27);
            this.txtCapBac.TabIndex = 12;
            // 
            // numHeSoLuong
            // 
            this.numHeSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numHeSoLuong.DecimalPlaces = 2;
            this.numHeSoLuong.Location = new System.Drawing.Point(577, 132);
            this.numHeSoLuong.Name = "numHeSoLuong";
            this.numHeSoLuong.Size = new System.Drawing.Size(194, 27);
            this.numHeSoLuong.TabIndex = 13;
            this.numHeSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtChucDanh
            // 
            this.txtChucDanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChucDanh.Location = new System.Drawing.Point(963, 132);
            this.txtChucDanh.Name = "txtChucDanh";
            this.txtChucDanh.Size = new System.Drawing.Size(210, 27);
            this.txtChucDanh.TabIndex = 14;
            // 
            // txtHocHam
            // 
            this.txtHocHam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHocHam.Location = new System.Drawing.Point(191, 164);
            this.txtHocHam.Name = "txtHocHam";
            this.txtHocHam.Size = new System.Drawing.Size(194, 27);
            this.txtHocHam.TabIndex = 15;
            // 
            // txtHocVi
            // 
            this.txtHocVi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHocVi.Location = new System.Drawing.Point(577, 164);
            this.txtHocVi.Name = "txtHocVi";
            this.txtHocVi.Size = new System.Drawing.Size(194, 27);
            this.txtHocVi.TabIndex = 16;
            // 
            // txtLinhVuc
            // 
            this.txtLinhVuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLinhVuc.Location = new System.Drawing.Point(963, 164);
            this.txtLinhVuc.Name = "txtLinhVuc";
            this.txtLinhVuc.Size = new System.Drawing.Size(210, 27);
            this.txtLinhVuc.TabIndex = 17;
            // 
            // numNamDay
            // 
            this.numNamDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numNamDay.Location = new System.Drawing.Point(191, 196);
            this.numNamDay.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numNamDay.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numNamDay.Name = "numNamDay";
            this.numNamDay.Size = new System.Drawing.Size(194, 27);
            this.numNamDay.TabIndex = 18;
            this.numNamDay.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
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
            this.panelButtons.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.panelButtons.Location = new System.Drawing.Point(0, 250);
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
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.AllowUserToAddRows = false;
            this.dgvGiaoVien.AllowUserToDeleteRows = false;
            this.dgvGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiaoVien.Location = new System.Drawing.Point(0, 295);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.ReadOnly = true;
            this.dgvGiaoVien.RowHeadersWidth = 51;
            this.dgvGiaoVien.RowTemplate.Height = 29;
            this.dgvGiaoVien.Size = new System.Drawing.Size(1182, 358);
            this.dgvGiaoVien.TabIndex = 2;
            this.dgvGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellClick);
            // 
            // FrmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.dgvGiaoVien);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.grpThongTin);
            this.Name = "FrmGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thông tin cán bộ, giáo viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGiaoVien_Load);
            this.grpThongTin.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numHeSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamDay)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtMaSoCB;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtDanToc;
        private System.Windows.Forms.TextBox txtTonGiao;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTrinhDoChuyenMon;
        private System.Windows.Forms.TextBox txtTrinhDoLLCT;
        private System.Windows.Forms.TextBox txtDonViCongTac;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtCapBac;
        private System.Windows.Forms.NumericUpDown numHeSoLuong;
        private System.Windows.Forms.TextBox txtChucDanh;
        private System.Windows.Forms.TextBox txtHocHam;
        private System.Windows.Forms.TextBox txtHocVi;
        private System.Windows.Forms.TextBox txtLinhVuc;
        private System.Windows.Forms.NumericUpDown numNamDay;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
    }
}
