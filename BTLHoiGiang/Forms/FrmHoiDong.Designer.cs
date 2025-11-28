namespace BTLHoiGiang.Forms
{
    partial class FrmHoiDong
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
            this.tableMembers = new System.Windows.Forms.TableLayoutPanel();
            this.cboHoiGiang = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtMaHoiDong = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvHoiDong = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoiDong)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.tableMembers);
            this.panelTop.Controls.Add(this.txtGhiChu);
            this.panelTop.Controls.Add(this.txtMaHoiDong);
            this.panelTop.Controls.Add(this.cboHoiGiang);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1182, 220);
            this.panelTop.TabIndex = 0;
            // 
            // tableMembers
            // 
            this.tableMembers.ColumnCount = 6;
            for(int i=0;i<6;i++) this.tableMembers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F/6F));
            this.tableMembers.RowCount = 5;
            for(int r=0;r<5;r++) this.tableMembers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            for (int r=0;r<5;r++)
            {
                var cbo = new System.Windows.Forms.ComboBox(){Dock=System.Windows.Forms.DockStyle.Fill, DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList};
                var txtCapBac = new System.Windows.Forms.TextBox(){Dock=System.Windows.Forms.DockStyle.Fill};
                var txtChucDanh = new System.Windows.Forms.TextBox(){Dock=System.Windows.Forms.DockStyle.Fill};
                var cboChucDanhHD = new System.Windows.Forms.ComboBox(){Dock=System.Windows.Forms.DockStyle.Fill, DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList};
                cboChucDanhHD.Items.AddRange(new object[]{"Chủ tịch Hội đồng","Thành viên","Thư ký"});
                this.tableMembers.Controls.Add(cbo,0,r);
                this.tableMembers.Controls.Add(txtCapBac,1,r);
                this.tableMembers.Controls.Add(txtChucDanh,2,r);
                this.tableMembers.Controls.Add(cboChucDanhHD,3,r);
            }
            this.tableMembers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableMembers.Location = new System.Drawing.Point(0, 60);
            this.tableMembers.Name = "tableMembers";
            this.tableMembers.Size = new System.Drawing.Size(1182, 160);
            this.tableMembers.TabIndex = 3;
            // 
            // cboHoiGiang
            // 
            this.cboHoiGiang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboHoiGiang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoiGiang.Location = new System.Drawing.Point(12, 12);
            this.cboHoiGiang.Name = "cboHoiGiang";
            this.cboHoiGiang.Size = new System.Drawing.Size(300, 28);
            this.cboHoiGiang.TabIndex = 0;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.Location = new System.Drawing.Point(330, 12);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PlaceholderText = "Ghi chú";
            this.txtGhiChu.Size = new System.Drawing.Size(500, 27);
            this.txtGhiChu.TabIndex = 1;
            // 
            // txtMaHoiDong
            // 
            this.txtMaHoiDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaHoiDong.Location = new System.Drawing.Point(850, 12);
            this.txtMaHoiDong.Name = "txtMaHoiDong";
            this.txtMaHoiDong.PlaceholderText = "Mã hội đồng";
            this.txtMaHoiDong.ReadOnly = true;
            this.txtMaHoiDong.Size = new System.Drawing.Size(150, 27);
            this.txtMaHoiDong.TabIndex = 2;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnLuu);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 220);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1182, 45);
            this.panelButtons.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(3, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 29);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvHoiDong
            // 
            this.dgvHoiDong.AllowUserToAddRows = false;
            this.dgvHoiDong.AllowUserToDeleteRows = false;
            this.dgvHoiDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoiDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoiDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoiDong.Location = new System.Drawing.Point(0, 265);
            this.dgvHoiDong.Name = "dgvHoiDong";
            this.dgvHoiDong.ReadOnly = true;
            this.dgvHoiDong.RowHeadersWidth = 51;
            this.dgvHoiDong.RowTemplate.Height = 29;
            this.dgvHoiDong.Size = new System.Drawing.Size(1182, 388);
            this.dgvHoiDong.TabIndex = 2;
            this.dgvHoiDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoiDong_CellClick);
            // 
            // FrmHoiDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.dgvHoiDong);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelTop);
            this.Name = "FrmHoiDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hội đồng dự giờ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHoiDong_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoiDong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel tableMembers;
        private System.Windows.Forms.ComboBox cboHoiGiang;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMaHoiDong;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvHoiDong;
    }
}
