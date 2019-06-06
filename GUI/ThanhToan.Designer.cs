namespace GUI
{
    partial class ThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThanhToan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbmakh = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txttienvanchuyen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtptchietkhau = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btninhoadon = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txttienchietkhau = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnhuybo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txttienkhachdua = new System.Windows.Forms.TextBox();
            this.txttienthua = new System.Windows.Forms.TextBox();
            this.txtthanhtoan = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.datachonsp = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datachonsp)).BeginInit();
            this.SuspendLayout();
            // 
            // lbmakh
            // 
            this.lbmakh.AutoSize = true;
            this.lbmakh.Location = new System.Drawing.Point(12, 448);
            this.lbmakh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmakh.Name = "lbmakh";
            this.lbmakh.Size = new System.Drawing.Size(0, 17);
            this.lbmakh.TabIndex = 23;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(227, 293);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(57, 41);
            this.panel8.TabIndex = 22;
            // 
            // txttienvanchuyen
            // 
            this.txttienvanchuyen.BackColor = System.Drawing.Color.White;
            this.txttienvanchuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttienvanchuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txttienvanchuyen.Location = new System.Drawing.Point(284, 156);
            this.txttienvanchuyen.Margin = new System.Windows.Forms.Padding(4);
            this.txttienvanchuyen.Name = "txttienvanchuyen";
            this.txttienvanchuyen.Size = new System.Drawing.Size(253, 41);
            this.txttienvanchuyen.TabIndex = 2;
            this.txttienvanchuyen.Text = "0";
            this.txttienvanchuyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttienvanchuyen.Click += new System.EventHandler(this.clicktxt);
            this.txttienvanchuyen.TextChanged += new System.EventHandler(this.txttienvanchuyen_TextChanged);
            this.txttienvanchuyen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhapso);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng tiền :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(11, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chiết khấu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(11, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phí vận chuyển :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(11, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thanh toán :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(296, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(11, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Khách đưa :";
            // 
            // txtptchietkhau
            // 
            this.txtptchietkhau.BackColor = System.Drawing.Color.White;
            this.txtptchietkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtptchietkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtptchietkhau.Location = new System.Drawing.Point(227, 91);
            this.txtptchietkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtptchietkhau.Name = "txtptchietkhau";
            this.txtptchietkhau.Size = new System.Drawing.Size(65, 41);
            this.txtptchietkhau.TabIndex = 1;
            this.txtptchietkhau.Text = "0";
            this.txtptchietkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtptchietkhau.Click += new System.EventHandler(this.clicktxt);
            this.txtptchietkhau.TextChanged += new System.EventHandler(this.txtptchietkhau_TextChanged);
            this.txtptchietkhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhapso);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(227, 362);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(57, 41);
            this.panel6.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(227, 156);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(57, 43);
            this.panel5.TabIndex = 20;
            // 
            // txttongtien
            // 
            this.txttongtien.BackColor = System.Drawing.Color.White;
            this.txttongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttongtien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txttongtien.Location = new System.Drawing.Point(284, 28);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(4);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.ReadOnly = true;
            this.txttongtien.Size = new System.Drawing.Size(253, 41);
            this.txttongtien.TabIndex = 1;
            this.txttongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttongtien.TextChanged += new System.EventHandler(this.txttongtien_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(227, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 41);
            this.panel1.TabIndex = 14;
            // 
            // btninhoadon
            // 
            this.btninhoadon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btninhoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninhoadon.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btninhoadon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btninhoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninhoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btninhoadon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btninhoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninhoadon.ImageIndex = 0;
            this.btninhoadon.ImageList = this.imageList1;
            this.btninhoadon.Location = new System.Drawing.Point(78, 34);
            this.btninhoadon.Margin = new System.Windows.Forms.Padding(4);
            this.btninhoadon.Name = "btninhoadon";
            this.btninhoadon.Size = new System.Drawing.Size(173, 75);
            this.btninhoadon.TabIndex = 4;
            this.btninhoadon.Text = "In hóa đơn";
            this.btninhoadon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninhoadon.UseVisualStyleBackColor = false;
            this.btninhoadon.Click += new System.EventHandler(this.btninhoadon_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "hoa don.png");
            this.imageList1.Images.SetKeyName(1, "dau-x.png");
            // 
            // txttienchietkhau
            // 
            this.txttienchietkhau.BackColor = System.Drawing.Color.White;
            this.txttienchietkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttienchietkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txttienchietkhau.Location = new System.Drawing.Point(332, 91);
            this.txttienchietkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txttienchietkhau.Name = "txttienchietkhau";
            this.txttienchietkhau.ReadOnly = true;
            this.txttienchietkhau.Size = new System.Drawing.Size(205, 41);
            this.txttienchietkhau.TabIndex = 3;
            this.txttienchietkhau.Text = "0";
            this.txttienchietkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttienchietkhau.TextChanged += new System.EventHandler(this.txttienchietkhau_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnhuybo);
            this.panel2.Controls.Add(this.btninhoadon);
            this.panel2.Location = new System.Drawing.Point(656, 482);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 141);
            this.panel2.TabIndex = 24;
            // 
            // btnhuybo
            // 
            this.btnhuybo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnhuybo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhuybo.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnhuybo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnhuybo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhuybo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnhuybo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnhuybo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhuybo.ImageIndex = 1;
            this.btnhuybo.ImageList = this.imageList1;
            this.btnhuybo.Location = new System.Drawing.Point(330, 34);
            this.btnhuybo.Margin = new System.Windows.Forms.Padding(4);
            this.btnhuybo.Name = "btnhuybo";
            this.btnhuybo.Size = new System.Drawing.Size(163, 75);
            this.btnhuybo.TabIndex = 5;
            this.btnhuybo.Text = "Hủy bỏ";
            this.btnhuybo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhuybo.UseVisualStyleBackColor = false;
            this.btnhuybo.Click += new System.EventHandler(this.btnhuybo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(11, 369);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tiền thừa :";
            // 
            // txttienkhachdua
            // 
            this.txttienkhachdua.BackColor = System.Drawing.Color.White;
            this.txttienkhachdua.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttienkhachdua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txttienkhachdua.Location = new System.Drawing.Point(284, 293);
            this.txttienkhachdua.Margin = new System.Windows.Forms.Padding(4);
            this.txttienkhachdua.Name = "txttienkhachdua";
            this.txttienkhachdua.Size = new System.Drawing.Size(253, 41);
            this.txttienkhachdua.TabIndex = 3;
            this.txttienkhachdua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttienkhachdua.Click += new System.EventHandler(this.clicktxt);
            this.txttienkhachdua.TextChanged += new System.EventHandler(this.txttienkhachdua_TextChanged);
            this.txttienkhachdua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhapso);
            // 
            // txttienthua
            // 
            this.txttienthua.BackColor = System.Drawing.Color.White;
            this.txttienthua.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttienthua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txttienthua.Location = new System.Drawing.Point(284, 362);
            this.txttienthua.Margin = new System.Windows.Forms.Padding(4);
            this.txttienthua.Name = "txttienthua";
            this.txttienthua.ReadOnly = true;
            this.txttienthua.Size = new System.Drawing.Size(253, 41);
            this.txttienthua.TabIndex = 12;
            this.txttienthua.Text = "0";
            this.txttienthua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtthanhtoan
            // 
            this.txtthanhtoan.BackColor = System.Drawing.Color.White;
            this.txtthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtthanhtoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtthanhtoan.Location = new System.Drawing.Point(227, 225);
            this.txtthanhtoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtthanhtoan.Name = "txtthanhtoan";
            this.txtthanhtoan.ReadOnly = true;
            this.txtthanhtoan.Size = new System.Drawing.Size(311, 41);
            this.txtthanhtoan.TabIndex = 11;
            this.txtthanhtoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtthanhtoan.TextChanged += new System.EventHandler(this.txtthanhtoan_TextChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel7.Controls.Add(this.lbmakh);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.txttienvanchuyen);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.txtptchietkhau);
            this.panel7.Controls.Add(this.txttongtien);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.txttienchietkhau);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.txttienkhachdua);
            this.panel7.Controls.Add(this.txttienthua);
            this.panel7.Controls.Add(this.txtthanhtoan);
            this.panel7.Location = new System.Drawing.Point(656, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(559, 482);
            this.panel7.TabIndex = 26;
            // 
            // datachonsp
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datachonsp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.datachonsp.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datachonsp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.datachonsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.Format = "N0";
            dataGridViewCellStyle11.NullValue = null;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datachonsp.DefaultCellStyle = dataGridViewCellStyle11;
            this.datachonsp.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.datachonsp.Location = new System.Drawing.Point(0, 0);
            this.datachonsp.Margin = new System.Windows.Forms.Padding(4);
            this.datachonsp.Name = "datachonsp";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datachonsp.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.datachonsp.Size = new System.Drawing.Size(655, 624);
            this.datachonsp.TabIndex = 25;
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 625);
            this.Controls.Add(this.datachonsp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThanhToan";
            this.Text = "ThanhToan";
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datachonsp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbmakh;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txttienvanchuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtptchietkhau;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btninhoadon;
        private System.Windows.Forms.TextBox txttienchietkhau;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnhuybo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttienkhachdua;
        private System.Windows.Forms.TextBox txttienthua;
        private System.Windows.Forms.TextBox txtthanhtoan;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView datachonsp;
        private System.Windows.Forms.ImageList imageList1;
    }
}