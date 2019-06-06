namespace GUI
{
    partial class Chinh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chinh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnquanly = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.ImageList(this.components);
            this.btnthongke = new System.Windows.Forms.Button();
            this.btnkhoaso = new System.Windows.Forms.Button();
            this.btnbanhang = new System.Windows.Forms.Button();
            this.btndangxuat = new System.Windows.Forms.Button();
            this.btndoimatkhau = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnquanly);
            this.panel1.Controls.Add(this.btnthongke);
            this.panel1.Controls.Add(this.btnkhoaso);
            this.panel1.Controls.Add(this.btnbanhang);
            this.panel1.Controls.Add(this.btndangxuat);
            this.panel1.Controls.Add(this.btndoimatkhau);
            this.panel1.Location = new System.Drawing.Point(576, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 444);
            this.panel1.TabIndex = 12;
            // 
            // btnquanly
            // 
            this.btnquanly.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnquanly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnquanly.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnquanly.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnquanly.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnquanly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnquanly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnquanly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnquanly.ImageIndex = 2;
            this.btnquanly.ImageList = this.img;
            this.btnquanly.Location = new System.Drawing.Point(45, 292);
            this.btnquanly.Name = "btnquanly";
            this.btnquanly.Size = new System.Drawing.Size(126, 60);
            this.btnquanly.TabIndex = 6;
            this.btnquanly.Text = "Quản lý";
            this.btnquanly.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnquanly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnquanly.UseVisualStyleBackColor = false;
            this.btnquanly.Click += new System.EventHandler(this.btnquanly_Click);
            // 
            // img
            // 
            this.img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img.ImageStream")));
            this.img.TransparentColor = System.Drawing.Color.Transparent;
            this.img.Images.SetKeyName(0, "chotca.png");
            this.img.Images.SetKeyName(1, "banhang.png");
            this.img.Images.SetKeyName(2, "quanly.png");
            this.img.Images.SetKeyName(3, "thongke.png");
            this.img.Images.SetKeyName(4, "doimk.png");
            this.img.Images.SetKeyName(5, "tat.png");
            // 
            // btnthongke
            // 
            this.btnthongke.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnthongke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthongke.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnthongke.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnthongke.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnthongke.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnthongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthongke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnthongke.ImageIndex = 3;
            this.btnthongke.ImageList = this.img;
            this.btnthongke.Location = new System.Drawing.Point(45, 363);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(126, 60);
            this.btnthongke.TabIndex = 5;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthongke.UseVisualStyleBackColor = false;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // btnkhoaso
            // 
            this.btnkhoaso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnkhoaso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkhoaso.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnkhoaso.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnkhoaso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnkhoaso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnkhoaso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkhoaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnkhoaso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnkhoaso.ImageIndex = 0;
            this.btnkhoaso.ImageList = this.img;
            this.btnkhoaso.Location = new System.Drawing.Point(45, 221);
            this.btnkhoaso.Name = "btnkhoaso";
            this.btnkhoaso.Size = new System.Drawing.Size(126, 60);
            this.btnkhoaso.TabIndex = 3;
            this.btnkhoaso.Text = "Khóa sổ";
            this.btnkhoaso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkhoaso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnkhoaso.UseVisualStyleBackColor = false;
            this.btnkhoaso.Click += new System.EventHandler(this.btnkhoaso_Click);
            // 
            // btnbanhang
            // 
            this.btnbanhang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnbanhang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbanhang.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnbanhang.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnbanhang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnbanhang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnbanhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbanhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnbanhang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnbanhang.ImageIndex = 1;
            this.btnbanhang.ImageList = this.img;
            this.btnbanhang.Location = new System.Drawing.Point(45, 150);
            this.btnbanhang.Name = "btnbanhang";
            this.btnbanhang.Size = new System.Drawing.Size(126, 60);
            this.btnbanhang.TabIndex = 2;
            this.btnbanhang.Text = "Bán hàng";
            this.btnbanhang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbanhang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbanhang.UseVisualStyleBackColor = false;
            this.btnbanhang.Click += new System.EventHandler(this.btnbanhang_Click);
            // 
            // btndangxuat
            // 
            this.btndangxuat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndangxuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndangxuat.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btndangxuat.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btndangxuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btndangxuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btndangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndangxuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btndangxuat.ImageIndex = 5;
            this.btndangxuat.ImageList = this.img;
            this.btndangxuat.Location = new System.Drawing.Point(45, 79);
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(126, 60);
            this.btndangxuat.TabIndex = 1;
            this.btndangxuat.Text = "Đăng xuất";
            this.btndangxuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndangxuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndangxuat.UseVisualStyleBackColor = false;
            this.btndangxuat.Click += new System.EventHandler(this.btndangxuat_Click);
            // 
            // btndoimatkhau
            // 
            this.btndoimatkhau.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndoimatkhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndoimatkhau.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btndoimatkhau.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btndoimatkhau.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btndoimatkhau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btndoimatkhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndoimatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndoimatkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btndoimatkhau.ImageIndex = 4;
            this.btndoimatkhau.ImageList = this.img;
            this.btndoimatkhau.Location = new System.Drawing.Point(45, 8);
            this.btndoimatkhau.Name = "btndoimatkhau";
            this.btndoimatkhau.Size = new System.Drawing.Size(126, 60);
            this.btndoimatkhau.TabIndex = 0;
            this.btndoimatkhau.Text = "Đổi mật khẩu";
            this.btndoimatkhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndoimatkhau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndoimatkhau.UseVisualStyleBackColor = false;
            this.btndoimatkhau.Click += new System.EventHandler(this.btndoimatkhau_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 443);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 30);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần mềm Phiên bản 1.0 - Tổng đài hỗ trợ - Nguyễn Đăng Khởi  - 0968462802";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(585, 442);
            this.panel3.TabIndex = 13;
            // 
            // Chinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Chinh";
            this.Text = "Phần mềm quán trà sữa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tat);
            this.Load += new System.EventHandler(this.Chinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnquanly;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.Button btnkhoaso;
        private System.Windows.Forms.Button btnbanhang;
        private System.Windows.Forms.Button btndangxuat;
        private System.Windows.Forms.Button btndoimatkhau;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ImageList img;
    }
}