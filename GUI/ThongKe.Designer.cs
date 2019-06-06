namespace GUI
{
    partial class ThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhthutungcatheotuan = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhthutungngaytheothang = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhthutungthangtheonam = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhthutungnam = new System.Windows.Forms.ToolStripMenuItem();
            this.nguyênLiệuNhậpVềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nguyênLiệuHủyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhThuToolStripMenuItem,
            this.nguyênLiệuNhậpVềToolStripMenuItem,
            this.nguyênLiệuHủyToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(852, 31);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhthutungcatheotuan,
            this.doanhthutungngaytheothang,
            this.doanhthutungthangtheonam,
            this.doanhthutungnam});
            this.doanhThuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.doanhThuToolStripMenuItem.Text = "Doanh Thu";
            // 
            // doanhthutungcatheotuan
            // 
            this.doanhthutungcatheotuan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doanhthutungcatheotuan.Name = "doanhthutungcatheotuan";
            this.doanhthutungcatheotuan.Size = new System.Drawing.Size(348, 28);
            this.doanhthutungcatheotuan.Text = "Doanh thu từng ca trong ngày";
            this.doanhthutungcatheotuan.Click += new System.EventHandler(this.doanhThuTừngCaTheoTuầnToolStripMenuItem_Click);
            // 
            // doanhthutungngaytheothang
            // 
            this.doanhthutungngaytheothang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doanhthutungngaytheothang.Name = "doanhthutungngaytheothang";
            this.doanhthutungngaytheothang.Size = new System.Drawing.Size(348, 28);
            this.doanhthutungngaytheothang.Text = "Doanh thu từng ngày trong tháng";
            this.doanhthutungngaytheothang.Click += new System.EventHandler(this.doanhthutungngaytheothang_Click);
            // 
            // doanhthutungthangtheonam
            // 
            this.doanhthutungthangtheonam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doanhthutungthangtheonam.Name = "doanhthutungthangtheonam";
            this.doanhthutungthangtheonam.Size = new System.Drawing.Size(348, 28);
            this.doanhthutungthangtheonam.Text = "Doanh thu từng tháng trong năm";
            this.doanhthutungthangtheonam.Click += new System.EventHandler(this.doanhThuTừngTuầnTheoNămToolStripMenuItem_Click);
            // 
            // doanhthutungnam
            // 
            this.doanhthutungnam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doanhthutungnam.Name = "doanhthutungnam";
            this.doanhthutungnam.Size = new System.Drawing.Size(348, 28);
            this.doanhthutungnam.Text = "Doanh thu từng năm";
            this.doanhthutungnam.Click += new System.EventHandler(this.doanhthutungnam_Click);
            // 
            // nguyênLiệuNhậpVềToolStripMenuItem
            // 
            this.nguyênLiệuNhậpVềToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nguyênLiệuNhậpVềToolStripMenuItem.Name = "nguyênLiệuNhậpVềToolStripMenuItem";
            this.nguyênLiệuNhậpVềToolStripMenuItem.Size = new System.Drawing.Size(180, 27);
            this.nguyênLiệuNhậpVềToolStripMenuItem.Text = "Nguyên liệu nhập về";
            this.nguyênLiệuNhậpVềToolStripMenuItem.Click += new System.EventHandler(this.nguyênLiệuNhậpVềToolStripMenuItem_Click);
            // 
            // nguyênLiệuHủyToolStripMenuItem
            // 
            this.nguyênLiệuHủyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nguyênLiệuHủyToolStripMenuItem.Name = "nguyênLiệuHủyToolStripMenuItem";
            this.nguyênLiệuHủyToolStripMenuItem.Size = new System.Drawing.Size(147, 27);
            this.nguyênLiệuHủyToolStripMenuItem.Text = "Nguyên liệu hủy";
            this.nguyênLiệuHủyToolStripMenuItem.Click += new System.EventHandler(this.nguyênLiệuHủyToolStripMenuItem_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(852, 504);
            this.Controls.Add(this.menu);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "ThongKe";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nguyênLiệuNhậpVềToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nguyênLiệuHủyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhthutungngaytheothang;
        private System.Windows.Forms.ToolStripMenuItem doanhthutungthangtheonam;
        private System.Windows.Forms.ToolStripMenuItem doanhthutungnam;
        private System.Windows.Forms.ToolStripMenuItem doanhthutungcatheotuan;
    }
}