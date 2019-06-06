namespace GUI
{
    partial class ThemLoaiSp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemLoaiSp));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttenloai = new System.Windows.Forms.TextBox();
            this.btnthommoi = new System.Windows.Forms.Button();
            this.btnxoabo = new System.Windows.Forms.Button();
            this.cbmaloai = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(40, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 42;
            this.label2.Text = "Tên loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 43;
            this.label1.Text = "Mã loại";
            // 
            // txttenloai
            // 
            this.txttenloai.BackColor = System.Drawing.Color.White;
            this.txttenloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenloai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txttenloai.Location = new System.Drawing.Point(223, 102);
            this.txttenloai.Margin = new System.Windows.Forms.Padding(4);
            this.txttenloai.Name = "txttenloai";
            this.txttenloai.Size = new System.Drawing.Size(281, 36);
            this.txttenloai.TabIndex = 45;
            this.txttenloai.Click += new System.EventHandler(this.clicktxt);
            // 
            // btnthommoi
            // 
            this.btnthommoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnthommoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthommoi.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnthommoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnthommoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnthommoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthommoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthommoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnthommoi.Location = new System.Drawing.Point(223, 171);
            this.btnthommoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnthommoi.Name = "btnthommoi";
            this.btnthommoi.Size = new System.Drawing.Size(117, 52);
            this.btnthommoi.TabIndex = 47;
            this.btnthommoi.Text = "Thêm mới";
            this.btnthommoi.UseVisualStyleBackColor = false;
            this.btnthommoi.Click += new System.EventHandler(this.btnthommoi_Click);
            // 
            // btnxoabo
            // 
            this.btnxoabo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnxoabo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoabo.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnxoabo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnxoabo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnxoabo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoabo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoabo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnxoabo.Location = new System.Drawing.Point(387, 171);
            this.btnxoabo.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoabo.Name = "btnxoabo";
            this.btnxoabo.Size = new System.Drawing.Size(117, 52);
            this.btnxoabo.TabIndex = 48;
            this.btnxoabo.Text = "Xóa bỏ";
            this.btnxoabo.UseVisualStyleBackColor = false;
            this.btnxoabo.Click += new System.EventHandler(this.btnxoabo_Click);
            // 
            // cbmaloai
            // 
            this.cbmaloai.BackColor = System.Drawing.Color.White;
            this.cbmaloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbmaloai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbmaloai.FormattingEnabled = true;
            this.cbmaloai.ItemHeight = 29;
            this.cbmaloai.Location = new System.Drawing.Point(223, 36);
            this.cbmaloai.Margin = new System.Windows.Forms.Padding(4);
            this.cbmaloai.Name = "cbmaloai";
            this.cbmaloai.Size = new System.Drawing.Size(281, 37);
            this.cbmaloai.TabIndex = 49;
            this.cbmaloai.SelectedIndexChanged += new System.EventHandler(this.cbmaloai_SelectedIndexChanged);
            this.cbmaloai.Click += new System.EventHandler(this.clicktxt);
            // 
            // ThemLoaiSp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(548, 250);
            this.Controls.Add(this.cbmaloai);
            this.Controls.Add(this.btnxoabo);
            this.Controls.Add(this.btnthommoi);
            this.Controls.Add(this.txttenloai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemLoaiSp";
            this.Text = "Loại sản phẩm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenloai;
        private System.Windows.Forms.Button btnthommoi;
        private System.Windows.Forms.Button btnxoabo;
        private System.Windows.Forms.ComboBox cbmaloai;
    }
}