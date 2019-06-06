namespace GUI
{
    partial class TKDtNam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TKDtNam));
            this.crvdoanhthunam = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvdoanhthunam
            // 
            this.crvdoanhthunam.ActiveViewIndex = -1;
            this.crvdoanhthunam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvdoanhthunam.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvdoanhthunam.DisplayStatusBar = false;
            this.crvdoanhthunam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvdoanhthunam.Location = new System.Drawing.Point(0, 0);
            this.crvdoanhthunam.Name = "crvdoanhthunam";
            this.crvdoanhthunam.Size = new System.Drawing.Size(891, 700);
            this.crvdoanhthunam.TabIndex = 0;
            this.crvdoanhthunam.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // TKDtNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 700);
            this.Controls.Add(this.crvdoanhthunam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TKDtNam";
            this.Text = "Thống kê doanh thu từng năm";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvdoanhthunam;
    }
}