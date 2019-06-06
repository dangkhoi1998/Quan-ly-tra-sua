namespace GUI
{
    partial class DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhau));
            this.txtnhaplaimatkhau = new System.Windows.Forms.TextBox();
            this.txtmatkhaucu = new System.Windows.Forms.TextBox();
            this.txtmatkhaumoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btndoimatkhau = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndoimk = new System.Windows.Forms.Button();
            this.lbthongbaodmk = new System.Windows.Forms.Label();
            this.hienmatkhau = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnhaplaimatkhau
            // 
            this.txtnhaplaimatkhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtnhaplaimatkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtnhaplaimatkhau.Location = new System.Drawing.Point(266, 95);
            this.txtnhaplaimatkhau.Name = "txtnhaplaimatkhau";
            this.txtnhaplaimatkhau.Size = new System.Drawing.Size(190, 29);
            this.txtnhaplaimatkhau.TabIndex = 20;
            this.txtnhaplaimatkhau.UseSystemPasswordChar = true;
            // 
            // txtmatkhaucu
            // 
            this.txtmatkhaucu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmatkhaucu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtmatkhaucu.Location = new System.Drawing.Point(266, 13);
            this.txtmatkhaucu.Name = "txtmatkhaucu";
            this.txtmatkhaucu.Size = new System.Drawing.Size(190, 29);
            this.txtmatkhaucu.TabIndex = 18;
            this.txtmatkhaucu.UseSystemPasswordChar = true;
            // 
            // txtmatkhaumoi
            // 
            this.txtmatkhaumoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmatkhaumoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtmatkhaumoi.Location = new System.Drawing.Point(266, 54);
            this.txtmatkhaumoi.Name = "txtmatkhaumoi";
            this.txtmatkhaumoi.Size = new System.Drawing.Size(190, 29);
            this.txtmatkhaumoi.TabIndex = 19;
            this.txtmatkhaumoi.UseSystemPasswordChar = true;
            this.txtmatkhaumoi.TextChanged += new System.EventHandler(this.txtmatkhaumoi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(24, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(24, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(24, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // btndoimatkhau
            // 
            this.btndoimatkhau.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndoimatkhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndoimatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndoimatkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btndoimatkhau.Location = new System.Drawing.Point(360, -31);
            this.btndoimatkhau.Name = "btndoimatkhau";
            this.btndoimatkhau.Size = new System.Drawing.Size(93, 32);
            this.btndoimatkhau.TabIndex = 6;
            this.btndoimatkhau.Text = "Đổi";
            this.btndoimatkhau.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btndoimk);
            this.panel1.Controls.Add(this.lbthongbaodmk);
            this.panel1.Controls.Add(this.btndoimatkhau);
            this.panel1.Location = new System.Drawing.Point(1, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 56);
            this.panel1.TabIndex = 25;
            // 
            // btndoimk
            // 
            this.btndoimk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndoimk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndoimk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndoimk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btndoimk.Location = new System.Drawing.Point(359, 12);
            this.btndoimk.Name = "btndoimk";
            this.btndoimk.Size = new System.Drawing.Size(93, 32);
            this.btndoimk.TabIndex = 16;
            this.btndoimk.Text = "Đổi";
            this.btndoimk.UseVisualStyleBackColor = false;
            this.btndoimk.Click += new System.EventHandler(this.btndoimk_Click);
            // 
            // lbthongbaodmk
            // 
            this.lbthongbaodmk.AutoSize = true;
            this.lbthongbaodmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbthongbaodmk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbthongbaodmk.Location = new System.Drawing.Point(21, 17);
            this.lbthongbaodmk.Name = "lbthongbaodmk";
            this.lbthongbaodmk.Size = new System.Drawing.Size(0, 20);
            this.lbthongbaodmk.TabIndex = 15;
            // 
            // hienmatkhau
            // 
            this.hienmatkhau.AutoSize = true;
            this.hienmatkhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hienmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hienmatkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.hienmatkhau.Location = new System.Drawing.Point(337, 132);
            this.hienmatkhau.Name = "hienmatkhau";
            this.hienmatkhau.Size = new System.Drawing.Size(119, 19);
            this.hienmatkhau.TabIndex = 21;
            this.hienmatkhau.Text = "Hiện mật khẩu";
            this.hienmatkhau.UseVisualStyleBackColor = true;
            this.hienmatkhau.CheckedChanged += new System.EventHandler(this.hienmatkhau_CheckedChanged);
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(490, 216);
            this.Controls.Add(this.txtnhaplaimatkhau);
            this.Controls.Add(this.txtmatkhaucu);
            this.Controls.Add(this.txtmatkhaumoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hienmatkhau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnhaplaimatkhau;
        private System.Windows.Forms.TextBox txtmatkhaucu;
        private System.Windows.Forms.TextBox txtmatkhaumoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndoimatkhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btndoimk;
        private System.Windows.Forms.Label lbthongbaodmk;
        private System.Windows.Forms.CheckBox hienmatkhau;
    }
}