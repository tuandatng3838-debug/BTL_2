namespace BTLHoiGiang.Forms
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuGiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHoiGiang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHoiDong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKetQua = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGiaoVien,
            this.menuHoiGiang,
            this.menuHoiDong,
            this.menuKetQua,
            this.menuThongKe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuGiaoVien
            // 
            this.menuGiaoVien.Name = "menuGiaoVien";
            this.menuGiaoVien.Size = new System.Drawing.Size(159, 24);
            this.menuGiaoVien.Text = "Quản lý giáo viên";
            this.menuGiaoVien.Click += new System.EventHandler(this.menuGiaoVien_Click);
            // 
            // menuHoiGiang
            // 
            this.menuHoiGiang.Name = "menuHoiGiang";
            this.menuHoiGiang.Size = new System.Drawing.Size(153, 24);
            this.menuHoiGiang.Text = "Đăng ký hội giảng";
            this.menuHoiGiang.Click += new System.EventHandler(this.menuHoiGiang_Click);
            // 
            // menuHoiDong
            // 
            this.menuHoiDong.Name = "menuHoiDong";
            this.menuHoiDong.Size = new System.Drawing.Size(164, 24);
            this.menuHoiDong.Text = "Hội đồng dự giờ";
            this.menuHoiDong.Click += new System.EventHandler(this.menuHoiDong_Click);
            // 
            // menuKetQua
            // 
            this.menuKetQua.Name = "menuKetQua";
            this.menuKetQua.Size = new System.Drawing.Size(166, 24);
            this.menuKetQua.Text = "Kết quả hội giảng";
            this.menuKetQua.Click += new System.EventHandler(this.menuKetQua_Click);
            // 
            // menuThongKe
            // 
            this.menuThongKe.Name = "menuThongKe";
            this.menuThongKe.Size = new System.Drawing.Size(160, 24);
            this.menuThongKe.Text = "Thống kê báo cáo";
            this.menuThongKe.Click += new System.EventHandler(this.menuThongKe_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Hội giảng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuGiaoVien;
        private System.Windows.Forms.ToolStripMenuItem menuHoiGiang;
        private System.Windows.Forms.ToolStripMenuItem menuHoiDong;
        private System.Windows.Forms.ToolStripMenuItem menuKetQua;
        private System.Windows.Forms.ToolStripMenuItem menuThongKe;
    }
}
