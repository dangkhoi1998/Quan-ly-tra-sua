namespace GUI
{
    partial class HoaDonIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonIn));
            this.crvhoadon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvhoadon
            // 
            this.crvhoadon.ActiveViewIndex = -1;
            this.crvhoadon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvhoadon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvhoadon.DisplayStatusBar = false;
            this.crvhoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvhoadon.Location = new System.Drawing.Point(0, 0);
            this.crvhoadon.Margin = new System.Windows.Forms.Padding(4);
            this.crvhoadon.Name = "crvhoadon";
            this.crvhoadon.Size = new System.Drawing.Size(746, 630);
            this.crvhoadon.TabIndex = 1;
            this.crvhoadon.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // HoaDonIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 630);
            this.Controls.Add(this.crvhoadon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HoaDonIn";
            this.Text = "HoaDonIn";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvhoadon;
    }
}