namespace GUI
{
    partial class HoaDonHuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonHuy));
            this.crvhoadonhuy = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvhoadonhuy
            // 
            this.crvhoadonhuy.ActiveViewIndex = -1;
            this.crvhoadonhuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvhoadonhuy.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvhoadonhuy.DisplayStatusBar = false;
            this.crvhoadonhuy.DisplayToolbar = false;
            this.crvhoadonhuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvhoadonhuy.Location = new System.Drawing.Point(0, 0);
            this.crvhoadonhuy.Margin = new System.Windows.Forms.Padding(4);
            this.crvhoadonhuy.Name = "crvhoadonhuy";
            this.crvhoadonhuy.Size = new System.Drawing.Size(745, 633);
            this.crvhoadonhuy.TabIndex = 3;
            this.crvhoadonhuy.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // HoaDonHuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 633);
            this.Controls.Add(this.crvhoadonhuy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HoaDonHuy";
            this.Text = "Phiếu hủy nguyên liệu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.tat);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvhoadonhuy;
    }
}