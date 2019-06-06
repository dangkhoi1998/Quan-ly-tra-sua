namespace GUI
{
    partial class TKDtCaTrongNgay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TKDtCaTrongNgay));
            this.crvdoanhthucatrongngay = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvdoanhthucatrongngay
            // 
            this.crvdoanhthucatrongngay.ActiveViewIndex = -1;
            this.crvdoanhthucatrongngay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvdoanhthucatrongngay.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvdoanhthucatrongngay.DisplayStatusBar = false;
            this.crvdoanhthucatrongngay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvdoanhthucatrongngay.Location = new System.Drawing.Point(0, 0);
            this.crvdoanhthucatrongngay.Name = "crvdoanhthucatrongngay";
            this.crvdoanhthucatrongngay.Size = new System.Drawing.Size(929, 676);
            this.crvdoanhthucatrongngay.TabIndex = 0;
            this.crvdoanhthucatrongngay.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // TKDtCaTrongNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 676);
            this.Controls.Add(this.crvdoanhthucatrongngay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TKDtCaTrongNgay";
            this.Text = "Doanh thu ca trong ngày";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvdoanhthucatrongngay;
    }
}