namespace GUI
{
    partial class BanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanHang));
            this.datachonsp = new System.Windows.Forms.DataGridView();
            this.MASANPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSANPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lOAISANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbloaisp = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnluachon = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnbomon = new System.Windows.Forms.Button();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbgia = new System.Windows.Forms.ComboBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbtensp = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnhdmoi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.gbthongtinsp = new System.Windows.Forms.GroupBox();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.btnkhachhang = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.txttongsoluong = new System.Windows.Forms.TextBox();
            this.lbthoigianchay = new System.Windows.Forms.Label();
            this.pandongho = new System.Windows.Forms.Panel();
            this.lbngayhientai = new System.Windows.Forms.Label();
            this.thoigianhientai = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datachonsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISANPHAMBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pandongho.SuspendLayout();
            this.SuspendLayout();
            // 
            // datachonsp
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datachonsp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datachonsp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datachonsp.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datachonsp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datachonsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datachonsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASANPHAM,
            this.TENSANPHAM,
            this.SOLUONG,
            this.GIA,
            this.THANHTIEN});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datachonsp.DefaultCellStyle = dataGridViewCellStyle7;
            this.datachonsp.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.datachonsp.Location = new System.Drawing.Point(1, 0);
            this.datachonsp.Name = "datachonsp";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datachonsp.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.datachonsp.Size = new System.Drawing.Size(940, 318);
            this.datachonsp.TabIndex = 17;
            this.datachonsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datachonsp_CellContentClick);
            this.datachonsp.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.thaydoidata);
            // 
            // MASANPHAM
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.MASANPHAM.DefaultCellStyle = dataGridViewCellStyle3;
            this.MASANPHAM.HeaderText = "Mã Sản Phẩm";
            this.MASANPHAM.Name = "MASANPHAM";
            // 
            // TENSANPHAM
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TENSANPHAM.DefaultCellStyle = dataGridViewCellStyle4;
            this.TENSANPHAM.HeaderText = "Tên Sản Phẩm";
            this.TENSANPHAM.Name = "TENSANPHAM";
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.Name = "SOLUONG";
            // 
            // GIA
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#,0";
            dataGridViewCellStyle5.NullValue = null;
            this.GIA.DefaultCellStyle = dataGridViewCellStyle5;
            this.GIA.HeaderText = "Đơn Giá";
            this.GIA.Name = "GIA";
            // 
            // THANHTIEN
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.THANHTIEN.DefaultCellStyle = dataGridViewCellStyle6;
            this.THANHTIEN.HeaderText = "Thành Tiền";
            this.THANHTIEN.Name = "THANHTIEN";
            // 
            // lOAISANPHAMBindingSource
            // 
            this.lOAISANPHAMBindingSource.DataMember = "LOAISANPHAM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Loại sản phẩm";
            // 
            // cbloaisp
            // 
            this.cbloaisp.BackColor = System.Drawing.Color.White;
            this.cbloaisp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbloaisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbloaisp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbloaisp.FormattingEnabled = true;
            this.cbloaisp.Location = new System.Drawing.Point(11, 49);
            this.cbloaisp.Name = "cbloaisp";
            this.cbloaisp.Size = new System.Drawing.Size(195, 32);
            this.cbloaisp.TabIndex = 1;
            this.cbloaisp.SelectedIndexChanged += new System.EventHandler(this.cbloaisp_SelectedIndexChanged);
            this.cbloaisp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kothaydoi);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.cbloaisp);
            this.panel5.Location = new System.Drawing.Point(1, 343);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(228, 169);
            this.panel5.TabIndex = 15;
            // 
            // btnluachon
            // 
            this.btnluachon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnluachon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnluachon.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnluachon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnluachon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnluachon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnluachon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnluachon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnluachon.Location = new System.Drawing.Point(21, 20);
            this.btnluachon.Name = "btnluachon";
            this.btnluachon.Size = new System.Drawing.Size(85, 57);
            this.btnluachon.TabIndex = 7;
            this.btnluachon.Text = "Chọn món";
            this.btnluachon.UseVisualStyleBackColor = false;
            this.btnluachon.Click += new System.EventHandler(this.btnluachon_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnluachon);
            this.panel4.Controls.Add(this.btnbomon);
            this.panel4.Location = new System.Drawing.Point(580, 343);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(361, 169);
            this.panel4.TabIndex = 16;
            // 
            // btnbomon
            // 
            this.btnbomon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnbomon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbomon.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnbomon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnbomon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnbomon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbomon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnbomon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnbomon.Location = new System.Drawing.Point(21, 96);
            this.btnbomon.Name = "btnbomon";
            this.btnbomon.Size = new System.Drawing.Size(85, 57);
            this.btnbomon.TabIndex = 1;
            this.btnbomon.Text = "Bỏ món";
            this.btnbomon.UseVisualStyleBackColor = false;
            this.btnbomon.Click += new System.EventHandler(this.btnbomon_Click);
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataMember = "SANPHAM";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.AutoScroll = true;
            this.panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.cbgia);
            this.panel6.Controls.Add(this.txtsoluong);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txtgia);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.cbtensp);
            this.panel6.Location = new System.Drawing.Point(226, 343);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(355, 169);
            this.panel6.TabIndex = 14;
            // 
            // cbgia
            // 
            this.cbgia.BackColor = System.Drawing.Color.White;
            this.cbgia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbgia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbgia.FormattingEnabled = true;
            this.cbgia.IntegralHeight = false;
            this.cbgia.Location = new System.Drawing.Point(21, 121);
            this.cbgia.Name = "cbgia";
            this.cbgia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbgia.Size = new System.Drawing.Size(153, 32);
            this.cbgia.TabIndex = 22;
            this.cbgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kothaydoi);
            // 
            // txtsoluong
            // 
            this.txtsoluong.BackColor = System.Drawing.Color.White;
            this.txtsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsoluong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtsoluong.Location = new System.Drawing.Point(180, 122);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsoluong.Size = new System.Drawing.Size(143, 31);
            this.txtsoluong.TabIndex = 3;
            this.txtsoluong.Click += new System.EventHandler(this.click_soluong);
            this.txtsoluong.TextChanged += new System.EventHandler(this.txtsoluong_TextChanged);
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nhapso);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(176, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Số lượng";
            // 
            // txtgia
            // 
            this.txtgia.AutoSize = true;
            this.txtgia.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtgia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtgia.Location = new System.Drawing.Point(17, 90);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(42, 24);
            this.txtgia.TabIndex = 23;
            this.txtgia.Text = "Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên sản phẩm";
            // 
            // cbtensp
            // 
            this.cbtensp.BackColor = System.Drawing.Color.White;
            this.cbtensp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbtensp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbtensp.FormattingEnabled = true;
            this.cbtensp.Location = new System.Drawing.Point(21, 49);
            this.cbtensp.Name = "cbtensp";
            this.cbtensp.Size = new System.Drawing.Size(302, 32);
            this.cbtensp.TabIndex = 2;
            this.cbtensp.SelectedIndexChanged += new System.EventHandler(this.cbtensp_SelectedIndexChanged);
            this.cbtensp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kothaydoi);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnhdmoi);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnthanhtoan);
            this.panel1.Controls.Add(this.btnload);
            this.panel1.Controls.Add(this.btnkhachhang);
            this.panel1.Location = new System.Drawing.Point(940, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 427);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnhdmoi
            // 
            this.btnhdmoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnhdmoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhdmoi.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnhdmoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnhdmoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnhdmoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhdmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnhdmoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnhdmoi.Location = new System.Drawing.Point(97, 72);
            this.btnhdmoi.Name = "btnhdmoi";
            this.btnhdmoi.Size = new System.Drawing.Size(83, 57);
            this.btnhdmoi.TabIndex = 11;
            this.btnhdmoi.Text = "Hóa đơn mới";
            this.btnhdmoi.UseVisualStyleBackColor = false;
            this.btnhdmoi.Click += new System.EventHandler(this.btnhdmoi_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.gbthongtinsp);
            this.panel2.Location = new System.Drawing.Point(6, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 206);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(20, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Thông tin sản phẩm";
            // 
            // gbthongtinsp
            // 
            this.gbthongtinsp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbthongtinsp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gbthongtinsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbthongtinsp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gbthongtinsp.Location = new System.Drawing.Point(2, 27);
            this.gbthongtinsp.Name = "gbthongtinsp";
            this.gbthongtinsp.Size = new System.Drawing.Size(168, 174);
            this.gbthongtinsp.TabIndex = 0;
            this.gbthongtinsp.TabStop = false;
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnthanhtoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthanhtoan.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnthanhtoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnthanhtoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnthanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthanhtoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnthanhtoan.Location = new System.Drawing.Point(6, 134);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(174, 57);
            this.btnthanhtoan.TabIndex = 5;
            this.btnthanhtoan.Text = "Thanh toán";
            this.btnthanhtoan.UseVisualStyleBackColor = false;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // btnload
            // 
            this.btnload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnload.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnload.Location = new System.Drawing.Point(6, 71);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(83, 57);
            this.btnload.TabIndex = 4;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = false;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnkhachhang
            // 
            this.btnkhachhang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnkhachhang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkhachhang.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnkhachhang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnkhachhang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnkhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnkhachhang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnkhachhang.Location = new System.Drawing.Point(6, 8);
            this.btnkhachhang.Name = "btnkhachhang";
            this.btnkhachhang.Size = new System.Drawing.Size(174, 57);
            this.btnkhachhang.TabIndex = 2;
            this.btnkhachhang.Text = "Khách hàng";
            this.btnkhachhang.UseVisualStyleBackColor = false;
            this.btnkhachhang.Click += new System.EventHandler(this.btnkhachhang_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txttongtien);
            this.panel3.Controls.Add(this.txttongsoluong);
            this.panel3.Location = new System.Drawing.Point(1, 317);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(940, 27);
            this.panel3.TabIndex = 12;
            // 
            // txttongtien
            // 
            this.txttongtien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txttongtien.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txttongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttongtien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txttongtien.Location = new System.Drawing.Point(578, -1);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.ReadOnly = true;
            this.txttongtien.Size = new System.Drawing.Size(129, 27);
            this.txttongtien.TabIndex = 1;
            this.txttongtien.Text = "0";
            this.txttongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttongtien.TextChanged += new System.EventHandler(this.txttongtien_TextChanged);
            // 
            // txttongsoluong
            // 
            this.txttongsoluong.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txttongsoluong.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txttongsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttongsoluong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txttongsoluong.Location = new System.Drawing.Point(376, -1);
            this.txttongsoluong.Name = "txttongsoluong";
            this.txttongsoluong.ReadOnly = true;
            this.txttongsoluong.Size = new System.Drawing.Size(94, 27);
            this.txttongsoluong.TabIndex = 0;
            this.txttongsoluong.Text = "0";
            this.txttongsoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttongsoluong.TextChanged += new System.EventHandler(this.txttongsoluong_TextChanged);
            // 
            // lbthoigianchay
            // 
            this.lbthoigianchay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthoigianchay.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbthoigianchay.Location = new System.Drawing.Point(27, 9);
            this.lbthoigianchay.Name = "lbthoigianchay";
            this.lbthoigianchay.Size = new System.Drawing.Size(140, 33);
            this.lbthoigianchay.TabIndex = 0;
            // 
            // pandongho
            // 
            this.pandongho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pandongho.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pandongho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pandongho.Controls.Add(this.lbngayhientai);
            this.pandongho.Controls.Add(this.lbthoigianchay);
            this.pandongho.Location = new System.Drawing.Point(940, 425);
            this.pandongho.Name = "pandongho";
            this.pandongho.Size = new System.Drawing.Size(188, 88);
            this.pandongho.TabIndex = 13;
            // 
            // lbngayhientai
            // 
            this.lbngayhientai.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngayhientai.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbngayhientai.Location = new System.Drawing.Point(17, 45);
            this.lbngayhientai.Name = "lbngayhientai";
            this.lbngayhientai.Size = new System.Drawing.Size(161, 33);
            this.lbngayhientai.TabIndex = 1;
            // 
            // thoigianhientai
            // 
            this.thoigianhientai.Tick += new System.EventHandler(this.thoigianhientai_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "02_About.png");
            this.imageList1.Images.SetKeyName(1, "03_About.png");
            this.imageList1.Images.SetKeyName(2, "04_About.png");
            this.imageList1.Images.SetKeyName(3, "05_About.png");
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 512);
            this.Controls.Add(this.datachonsp);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pandongho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BanHang";
            this.Text = "Bán hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.tat);
            this.Load += new System.EventHandler(this.BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datachonsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISANPHAMBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pandongho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datachonsp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource lOAISANPHAMBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbloaisp;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnluachon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbgia;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtgia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbtensp;
        private System.Windows.Forms.Button btnbomon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbthongtinsp;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnkhachhang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.TextBox txttongsoluong;
        private System.Windows.Forms.Label lbthoigianchay;
        private System.Windows.Forms.Panel pandongho;
        private System.Windows.Forms.Label lbngayhientai;
        private System.Windows.Forms.Timer thoigianhientai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASANPHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSANPHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.Button btnhdmoi;
        private System.Windows.Forms.ImageList imageList1;
    }
}