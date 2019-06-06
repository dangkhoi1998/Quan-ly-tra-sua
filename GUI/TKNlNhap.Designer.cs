namespace GUI
{
    partial class TKNlNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TKNlNhap));
            this.crvnlnhap = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvnlnhap
            // 
            this.crvnlnhap.ActiveViewIndex = -1;
            this.crvnlnhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvnlnhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvnlnhap.DisplayStatusBar = false;
            this.crvnlnhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvnlnhap.Location = new System.Drawing.Point(0, 0);
            this.crvnlnhap.Name = "crvnlnhap";
            this.crvnlnhap.Size = new System.Drawing.Size(928, 728);
            this.crvnlnhap.TabIndex = 0;
            this.crvnlnhap.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // TKNlNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 728);
            this.Controls.Add(this.crvnlnhap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TKNlNhap";
            this.Text = "Thống kê nguyên liệu nhập";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvnlnhap;
    }
}