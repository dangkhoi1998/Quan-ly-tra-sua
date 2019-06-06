namespace GUI
{
    partial class TKDtNgayTrongThang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TKDtNgayTrongThang));
            this.crvdoanhthungaytronthang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvdoanhthungaytronthang
            // 
            this.crvdoanhthungaytronthang.ActiveViewIndex = -1;
            this.crvdoanhthungaytronthang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvdoanhthungaytronthang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvdoanhthungaytronthang.DisplayStatusBar = false;
            this.crvdoanhthungaytronthang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvdoanhthungaytronthang.Location = new System.Drawing.Point(0, 0);
            this.crvdoanhthungaytronthang.Name = "crvdoanhthungaytronthang";
            this.crvdoanhthungaytronthang.Size = new System.Drawing.Size(866, 702);
            this.crvdoanhthungaytronthang.TabIndex = 0;
            this.crvdoanhthungaytronthang.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // TKDtNgayTrongThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 702);
            this.Controls.Add(this.crvdoanhthungaytronthang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TKDtNgayTrongThang";
            this.Text = "Doanh thu ngày trong tháng";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvdoanhthungaytronthang;
    }
}