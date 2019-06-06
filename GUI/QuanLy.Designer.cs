namespace GUI
{
    partial class QuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLy));
            this.btnnguyenlieu = new System.Windows.Forms.Button();
            this.btncongthuc = new System.Windows.Forms.Button();
            this.btnsanpham = new System.Windows.Forms.Button();
            this.btntaikhoan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnnguyenlieu
            // 
            this.btnnguyenlieu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnnguyenlieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnguyenlieu.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnnguyenlieu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnnguyenlieu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnnguyenlieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnguyenlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnguyenlieu.Location = new System.Drawing.Point(50, 33);
            this.btnnguyenlieu.Name = "btnnguyenlieu";
            this.btnnguyenlieu.Size = new System.Drawing.Size(134, 64);
            this.btnnguyenlieu.TabIndex = 16;
            this.btnnguyenlieu.Text = "Nguyên liệu";
            this.btnnguyenlieu.UseVisualStyleBackColor = false;
            this.btnnguyenlieu.Click += new System.EventHandler(this.btnnguyenlieu_Click);
            // 
            // btncongthuc
            // 
            this.btncongthuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncongthuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncongthuc.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btncongthuc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btncongthuc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btncongthuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncongthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncongthuc.Location = new System.Drawing.Point(469, 33);
            this.btncongthuc.Name = "btncongthuc";
            this.btncongthuc.Size = new System.Drawing.Size(134, 64);
            this.btncongthuc.TabIndex = 17;
            this.btncongthuc.Text = "Công thức";
            this.btncongthuc.UseVisualStyleBackColor = false;
            this.btncongthuc.Click += new System.EventHandler(this.btncongthuc_Click);
            // 
            // btnsanpham
            // 
            this.btnsanpham.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsanpham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsanpham.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnsanpham.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsanpham.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnsanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsanpham.Location = new System.Drawing.Point(256, 33);
            this.btnsanpham.Name = "btnsanpham";
            this.btnsanpham.Size = new System.Drawing.Size(134, 64);
            this.btnsanpham.TabIndex = 18;
            this.btnsanpham.Text = "Sản phẩm";
            this.btnsanpham.UseVisualStyleBackColor = false;
            this.btnsanpham.Click += new System.EventHandler(this.btnsanpham_Click);
            // 
            // btntaikhoan
            // 
            this.btntaikhoan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btntaikhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntaikhoan.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btntaikhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btntaikhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btntaikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaikhoan.Location = new System.Drawing.Point(681, 33);
            this.btntaikhoan.Name = "btntaikhoan";
            this.btntaikhoan.Size = new System.Drawing.Size(134, 64);
            this.btntaikhoan.TabIndex = 19;
            this.btntaikhoan.Text = "Tài khoản";
            this.btntaikhoan.UseVisualStyleBackColor = false;
            this.btntaikhoan.Click += new System.EventHandler(this.btntaikhoan_Click);
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1208, 742);
            this.Controls.Add(this.btntaikhoan);
            this.Controls.Add(this.btnsanpham);
            this.Controls.Add(this.btncongthuc);
            this.Controls.Add(this.btnnguyenlieu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "QuanLy";
            this.Text = "Quản lý";
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnguyenlieu;
        private System.Windows.Forms.Button btncongthuc;
        private System.Windows.Forms.Button btnsanpham;
        private System.Windows.Forms.Button btntaikhoan;
    }
}