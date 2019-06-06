namespace GUI
{
    partial class TKDoanhThu
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
            this.lbthongtin = new System.Windows.Forms.Label();
            this.btnxem = new System.Windows.Forms.Button();
            this.dtpthoigian = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbthongtin
            // 
            this.lbthongtin.AutoSize = true;
            this.lbthongtin.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbthongtin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbthongtin.Location = new System.Drawing.Point(137, 184);
            this.lbthongtin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbthongtin.Name = "lbthongtin";
            this.lbthongtin.Size = new System.Drawing.Size(269, 29);
            this.lbthongtin.TabIndex = 59;
            this.lbthongtin.Text = "Chọn thời gian thống kê";
            // 
            // btnxem
            // 
            this.btnxem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnxem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxem.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnxem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnxem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnxem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnxem.Location = new System.Drawing.Point(530, 199);
            this.btnxem.Margin = new System.Windows.Forms.Padding(4);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(112, 60);
            this.btnxem.TabIndex = 60;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = false;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // dtpthoigian
            // 
            this.dtpthoigian.CustomFormat = "dd/MM/yyyy";
            this.dtpthoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpthoigian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpthoigian.Location = new System.Drawing.Point(142, 239);
            this.dtpthoigian.Name = "dtpthoigian";
            this.dtpthoigian.Size = new System.Drawing.Size(270, 34);
            this.dtpthoigian.TabIndex = 61;
            // 
            // TKDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(847, 465);
            this.Controls.Add(this.dtpthoigian);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.lbthongtin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TKDoanhThu";
            this.Text = "TKDoanhThu";
            this.Load += new System.EventHandler(this.TKDoanhThu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbthongtin;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.DateTimePicker dtpthoigian;
    }
}