namespace GUI
{
    partial class KhoaSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoaSo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnin = new System.Windows.Forms.Button();
            this.crvkhoaso = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnin);
            this.panel1.Location = new System.Drawing.Point(3, 634);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 131);
            this.panel1.TabIndex = 3;
            // 
            // btnin
            // 
            this.btnin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnin.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnin.Location = new System.Drawing.Point(411, 38);
            this.btnin.Margin = new System.Windows.Forms.Padding(4);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(188, 53);
            this.btnin.TabIndex = 8;
            this.btnin.Text = "In";
            this.btnin.UseVisualStyleBackColor = false;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // crvkhoaso
            // 
            this.crvkhoaso.ActiveViewIndex = -1;
            this.crvkhoaso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvkhoaso.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvkhoaso.DisplayStatusBar = false;
            this.crvkhoaso.Location = new System.Drawing.Point(3, 1);
            this.crvkhoaso.Margin = new System.Windows.Forms.Padding(4);
            this.crvkhoaso.Name = "crvkhoaso";
            this.crvkhoaso.Size = new System.Drawing.Size(1042, 633);
            this.crvkhoaso.TabIndex = 2;
            this.crvkhoaso.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvkhoaso.Load += new System.EventHandler(this.crvkhoaso_Load);
            // 
            // KhoaSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1044, 766);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crvkhoaso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KhoaSo";
            this.Text = "Khóa sổ";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnin;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvkhoaso;
    }
}