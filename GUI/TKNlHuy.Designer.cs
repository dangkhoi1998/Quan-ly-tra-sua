namespace GUI
{
    partial class TKNlHuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TKNlHuy));
            this.grvnlhuy = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // grvnlhuy
            // 
            this.grvnlhuy.ActiveViewIndex = -1;
            this.grvnlhuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grvnlhuy.Cursor = System.Windows.Forms.Cursors.Default;
            this.grvnlhuy.DisplayStatusBar = false;
            this.grvnlhuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvnlhuy.Location = new System.Drawing.Point(0, 0);
            this.grvnlhuy.Name = "grvnlhuy";
            this.grvnlhuy.Size = new System.Drawing.Size(912, 686);
            this.grvnlhuy.TabIndex = 0;
            this.grvnlhuy.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // TKNlHuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 686);
            this.Controls.Add(this.grvnlhuy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TKNlHuy";
            this.Text = "Thống kê nguyên liệu hủy";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer grvnlhuy;
    }
}