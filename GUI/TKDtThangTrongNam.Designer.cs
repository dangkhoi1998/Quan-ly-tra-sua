namespace GUI
{
    partial class TKDtThangTrongNam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TKDtThangTrongNam));
            this.crvTKDtThangTrongNam = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvTKDtThangTrongNam
            // 
            this.crvTKDtThangTrongNam.ActiveViewIndex = -1;
            this.crvTKDtThangTrongNam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvTKDtThangTrongNam.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvTKDtThangTrongNam.DisplayStatusBar = false;
            this.crvTKDtThangTrongNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvTKDtThangTrongNam.Location = new System.Drawing.Point(0, 0);
            this.crvTKDtThangTrongNam.Name = "crvTKDtThangTrongNam";
            this.crvTKDtThangTrongNam.Size = new System.Drawing.Size(1023, 713);
            this.crvTKDtThangTrongNam.TabIndex = 0;
            this.crvTKDtThangTrongNam.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // TKDtThangTrongNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 713);
            this.Controls.Add(this.crvTKDtThangTrongNam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TKDtThangTrongNam";
            this.Text = "Doanh thu tháng trong năm";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvTKDtThangTrongNam;
    }
}