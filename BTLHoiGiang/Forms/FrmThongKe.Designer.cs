namespace BTLHoiGiang.Forms
{
    partial class FrmThongKe
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHoiDong = new System.Windows.Forms.TabPage();
            this.tabCap = new System.Windows.Forms.TabPage();
            this.tabGiai = new System.Windows.Forms.TabPage();
            this.dgvHoiDong = new System.Windows.Forms.DataGridView();
            this.dgvCap = new System.Windows.Forms.DataGridView();
            this.dgvGiai = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabHoiDong.SuspendLayout();
            this.tabCap.SuspendLayout();
            this.tabGiai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoiDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiai)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHoiDong);
            this.tabControl1.Controls.Add(this.tabCap);
            this.tabControl1.Controls.Add(this.tabGiai);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1182, 653);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHoiDong
            // 
            this.tabHoiDong.Controls.Add(this.dgvHoiDong);
            this.tabHoiDong.Location = new System.Drawing.Point(4, 29);
            this.tabHoiDong.Name = "tabHoiDong";
            this.tabHoiDong.Padding = new System.Windows.Forms.Padding(3);
            this.tabHoiDong.Size = new System.Drawing.Size(1174, 620);
            this.tabHoiDong.TabIndex = 0;
            this.tabHoiDong.Text = "Thống kê Hội đồng";
            this.tabHoiDong.UseVisualStyleBackColor = true;
            // 
            // tabCap
            // 
            this.tabCap.Controls.Add(this.dgvCap);
            this.tabCap.Location = new System.Drawing.Point(4, 29);
            this.tabCap.Name = "tabCap";
            this.tabCap.Padding = new System.Windows.Forms.Padding(3);
            this.tabCap.Size = new System.Drawing.Size(1174, 620);
            this.tabCap.TabIndex = 1;
            this.tabCap.Text = "Thống kê HĐ giảng – Cấp HV/Bộ";
            this.tabCap.UseVisualStyleBackColor = true;
            // 
            // tabGiai
            // 
            this.tabGiai.Controls.Add(this.dgvGiai);
            this.tabGiai.Location = new System.Drawing.Point(4, 29);
            this.tabGiai.Name = "tabGiai";
            this.tabGiai.Padding = new System.Windows.Forms.Padding(3);
            this.tabGiai.Size = new System.Drawing.Size(1174, 620);
            this.tabGiai.TabIndex = 2;
            this.tabGiai.Text = "Thống kê Giải theo Khoa";
            this.tabGiai.UseVisualStyleBackColor = true;
            // 
            // dgvHoiDong
            // 
            this.dgvHoiDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoiDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoiDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoiDong.Location = new System.Drawing.Point(3, 3);
            this.dgvHoiDong.Name = "dgvHoiDong";
            this.dgvHoiDong.RowHeadersWidth = 51;
            this.dgvHoiDong.RowTemplate.Height = 29;
            this.dgvHoiDong.Size = new System.Drawing.Size(1168, 614);
            this.dgvHoiDong.TabIndex = 0;
            // 
            // dgvCap
            // 
            this.dgvCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCap.Location = new System.Drawing.Point(3, 3);
            this.dgvCap.Name = "dgvCap";
            this.dgvCap.RowHeadersWidth = 51;
            this.dgvCap.RowTemplate.Height = 29;
            this.dgvCap.Size = new System.Drawing.Size(1168, 614);
            this.dgvCap.TabIndex = 0;
            // 
            // dgvGiai
            // 
            this.dgvGiai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiai.Location = new System.Drawing.Point(3, 3);
            this.dgvGiai.Name = "dgvGiai";
            this.dgvGiai.RowHeadersWidth = 51;
            this.dgvGiai.RowTemplate.Height = 29;
            this.dgvGiai.Size = new System.Drawing.Size(1168, 614);
            this.dgvGiai.TabIndex = 0;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê, báo cáo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabHoiDong.ResumeLayout(false);
            this.tabCap.ResumeLayout(false);
            this.tabGiai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoiDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHoiDong;
        private System.Windows.Forms.TabPage tabCap;
        private System.Windows.Forms.TabPage tabGiai;
        private System.Windows.Forms.DataGridView dgvHoiDong;
        private System.Windows.Forms.DataGridView dgvCap;
        private System.Windows.Forms.DataGridView dgvGiai;
    }
}
