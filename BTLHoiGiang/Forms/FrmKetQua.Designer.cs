namespace BTLHoiGiang.Forms
{
    partial class FrmKetQua
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
            this.cboHoiGiang = new System.Windows.Forms.ComboBox();
            this.cboXepLoai = new System.Windows.Forms.ComboBox();
            this.txtGiaiThuong = new System.Windows.Forms.TextBox();
            this.numHieuBiet = new System.Windows.Forms.NumericUpDown();
            this.numGioiThieu = new System.Windows.Forms.NumericUpDown();
            this.numThucHanh1 = new System.Windows.Forms.NumericUpDown();
            this.numThucHanh2 = new System.Windows.Forms.NumericUpDown();
            this.numThucHanh3 = new System.Windows.Forms.NumericUpDown();
            this.numThucHanh4 = new System.Windows.Forms.NumericUpDown();
            this.numThucHanh5 = new System.Windows.Forms.NumericUpDown();
            this.numThucHanhTB = new System.Windows.Forms.NumericUpDown();
            this.numTongDiem = new System.Windows.Forms.NumericUpDown();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTinhDiem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHieuBiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGioiThieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThucHanh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThucHanh2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThucHanh3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThucHanh4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThucHanh5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThucHanhTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTongDiem)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.numTongDiem);
            this.panelTop.Controls.Add(this.numThucHanhTB);
            this.panelTop.Controls.Add(this.numThucHanh5);
            this.panelTop.Controls.Add(this.numThucHanh4);
            this.panelTop.Controls.Add(this.numThucHanh3);
            this.panelTop.Controls.Add(this.numThucHanh2);
            this.panelTop.Controls.Add(this.numThucHanh1);
            this.panelTop.Controls.Add(this.numGioiThieu);
            this.panelTop.Controls.Add(this.numHieuBiet);
            this.panelTop.Controls.Add(this.txtGiaiThuong);
            this.panelTop.Controls.Add(this.cboXepLoai);
            this.panelTop.Controls.Add(this.cboHoiGiang);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1182, 140);
            this.panelTop.TabIndex = 0;
            // 
            // cboHoiGiang
            // 
            this.cboHoiGiang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoiGiang.Location = new System.Drawing.Point(12, 12);
            this.cboHoiGiang.Name = "cboHoiGiang";
            this.cboHoiGiang.Size = new System.Drawing.Size(250, 28);
            this.cboHoiGiang.TabIndex = 0;
            // 
            // cboXepLoai
            // 
            this.cboXepLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboXepLoai.Items.AddRange(new object[] {
            "Nhất",
            "Nhì",
            "Ba",
            "Khuyến khích"});
            this.cboXepLoai.Location = new System.Drawing.Point(280, 12);
            this.cboXepLoai.Name = "cboXepLoai";
            this.cboXepLoai.Size = new System.Drawing.Size(151, 28);
            this.cboXepLoai.TabIndex = 1;
            // 
            // txtGiaiThuong
            // 
            this.txtGiaiThuong.Location = new System.Drawing.Point(450, 12);
            this.txtGiaiThuong.Name = "txtGiaiThuong";
            this.txtGiaiThuong.PlaceholderText = "Giải thưởng";
            this.txtGiaiThuong.Size = new System.Drawing.Size(200, 27);
            this.txtGiaiThuong.TabIndex = 2;
            // 
            // numHieuBiet
            // 
            this.numHieuBiet.DecimalPlaces = 2;
            this.numHieuBiet.Location = new System.Drawing.Point(12, 55);
            this.numHieuBiet.Maximum = new decimal(new int[] {100,0,0,0});
            this.numHieuBiet.Name = "numHieuBiet";
            this.numHieuBiet.Size = new System.Drawing.Size(120, 27);
            this.numHieuBiet.TabIndex = 3;
            // 
            // numGioiThieu
            // 
            this.numGioiThieu.DecimalPlaces = 2;
            this.numGioiThieu.Location = new System.Drawing.Point(150, 55);
            this.numGioiThieu.Maximum = new decimal(new int[] {100,0,0,0});
            this.numGioiThieu.Name = "numGioiThieu";
            this.numGioiThieu.Size = new System.Drawing.Size(120, 27);
            this.numGioiThieu.TabIndex = 4;
            // 
            // numThucHanh1..5
            // 
            this.numThucHanh1.DecimalPlaces = this.numThucHanh2.DecimalPlaces = this.numThucHanh3.DecimalPlaces = this.numThucHanh4.DecimalPlaces = this.numThucHanh5.DecimalPlaces = 2;
            this.numThucHanh1.Location = new System.Drawing.Point(290, 55);
            this.numThucHanh1.Maximum = new decimal(new int[] {100,0,0,0});
            this.numThucHanh2.Location = new System.Drawing.Point(420, 55);
            this.numThucHanh2.Maximum = new decimal(new int[] {100,0,0,0});
            this.numThucHanh3.Location = new System.Drawing.Point(550, 55);
            this.numThucHanh3.Maximum = new decimal(new int[] {100,0,0,0});
            this.numThucHanh4.Location = new System.Drawing.Point(680, 55);
            this.numThucHanh4.Maximum = new decimal(new int[] {100,0,0,0});
            this.numThucHanh5.Location = new System.Drawing.Point(810, 55);
            this.numThucHanh5.Maximum = new decimal(new int[] {100,0,0,0});
            // 
            // numThucHanhTB
            // 
            this.numThucHanhTB.DecimalPlaces = 2;
            this.numThucHanhTB.Location = new System.Drawing.Point(12, 96);
            this.numThucHanhTB.Maximum = new decimal(new int[] {100,0,0,0});
            this.numThucHanhTB.Name = "numThucHanhTB";
            this.numThucHanhTB.Size = new System.Drawing.Size(120, 27);
            this.numThucHanhTB.TabIndex = 10;
            // 
            // numTongDiem
            // 
            this.numTongDiem.DecimalPlaces = 2;
            this.numTongDiem.Location = new System.Drawing.Point(150, 96);
            this.numTongDiem.Maximum = new decimal(new int[] {300,0,0,0});
            this.numTongDiem.Name = "numTongDiem";
            this.numTongDiem.Size = new System.Drawing.Size(120, 27);
            this.numTongDiem.TabIndex = 11;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnTinhDiem);
            this.panelButtons.Controls.Add(this.btnLuu);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 140);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1182, 45);
            this.panelButtons.TabIndex = 1;
            // 
            // btnTinhDiem
            // 
            this.btnTinhDiem.Location = new System.Drawing.Point(3, 3);
            this.btnTinhDiem.Name = "btnTinhDiem";
            this.btnTinhDiem.Size = new System.Drawing.Size(110, 29);
            this.btnTinhDiem.TabIndex = 0;
            this.btnTinhDiem.Text = "Tính điểm";
            this.btnTinhDiem.UseVisualStyleBackColor = true;
            this.btnTinhDiem.Click += new System.EventHandler(this.btnTinhDiem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(119, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 29);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKetQua.Location = new System.Drawing.Point(0, 185);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.RowHeadersWidth = 51;
            this.dgvKetQua.RowTemplate.Height = 29;
            this.dgvKetQua.Size = new System.Drawing.Size(1182, 468);
            this.dgvKetQua.TabIndex = 2;
            // 
            // FrmKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelTop);
            this.Name = "FrmKetQua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết quả hội giảng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmKetQua_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHieuBiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGioiThieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThucHanh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThucHanh2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThucHanh3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThucHanh4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThucHanh5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThucHanhTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTongDiem)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ComboBox cboHoiGiang;
        private System.Windows.Forms.ComboBox cboXepLoai;
        private System.Windows.Forms.TextBox txtGiaiThuong;
        private System.Windows.Forms.NumericUpDown numHieuBiet;
        private System.Windows.Forms.NumericUpDown numGioiThieu;
        private System.Windows.Forms.NumericUpDown numThucHanh1;
        private System.Windows.Forms.NumericUpDown numThucHanh2;
        private System.Windows.Forms.NumericUpDown numThucHanh3;
        private System.Windows.Forms.NumericUpDown numThucHanh4;
        private System.Windows.Forms.NumericUpDown numThucHanh5;
        private System.Windows.Forms.NumericUpDown numThucHanhTB;
        private System.Windows.Forms.NumericUpDown numTongDiem;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Button btnTinhDiem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvKetQua;
    }
}
