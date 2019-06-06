namespace GUI
{
    partial class HoaDonNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonNhap));
            this.crvhoadonnhap = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvhoadonnhap
            // 
            this.crvhoadonnhap.ActiveViewIndex = -1;
            this.crvhoadonnhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvhoadonnhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvhoadonnhap.DisplayStatusBar = false;
            this.crvhoadonnhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvhoadonnhap.Location = new System.Drawing.Point(0, 0);
            this.crvhoadonnhap.Margin = new System.Windows.Forms.Padding(4);
            this.crvhoadonnhap.Name = "crvhoadonnhap";
            this.crvhoadonnhap.Size = new System.Drawing.Size(746, 634);
            this.crvhoadonnhap.TabIndex = 2;
            this.crvhoadonnhap.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 634);
            this.Controls.Add(this.crvhoadonnhap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HoaDonNhap";
            this.Text = "Hóa đơn nhập nguyên liệu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.tat);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvhoadonnhap;
    }
}