
namespace Nhom7_PhanMemQuanLyHieuThuoc
{
	partial class frm_Account
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lbl_Title = new System.Windows.Forms.Label();
			this.pnl_Data = new System.Windows.Forms.Panel();
			this.dt_NgaySinh = new System.Windows.Forms.DateTimePicker();
			this.cbx_QHuyen = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_LoaiThucDon = new System.Windows.Forms.Label();
			this.lbl_DonViTinh = new System.Windows.Forms.Label();
			this.tbx_SDT = new System.Windows.Forms.TextBox();
			this.tbx_SoNha = new System.Windows.Forms.TextBox();
			this.tbx_Email = new System.Windows.Forms.TextBox();
			this.lbl_GiaBan = new System.Windows.Forms.Label();
			this.tbx_HoTen = new System.Windows.Forms.TextBox();
			this.lbl_TenThucDon = new System.Windows.Forms.Label();
			this.tbx_Ma = new System.Windows.Forms.TextBox();
			this.lbl_MaThucDon = new System.Windows.Forms.Label();
			this.dgv_dsDSi = new System.Windows.Forms.DataGridView();
			this.colTenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colVaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSoNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMaDs = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMaQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colQuanHuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_LocTT = new System.Windows.Forms.Button();
			this.btn_Reset = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.pnl_Data.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_dsDSi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_Title
			// 
			this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.Location = new System.Drawing.Point(12, 95);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(776, 41);
			this.lbl_Title.TabIndex = 7;
			this.lbl_Title.Text = "Quản Lý Tài Khoản";
			this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnl_Data
			// 
			this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Data.Controls.Add(this.dt_NgaySinh);
			this.pnl_Data.Controls.Add(this.cbx_QHuyen);
			this.pnl_Data.Controls.Add(this.label1);
			this.pnl_Data.Controls.Add(this.label2);
			this.pnl_Data.Controls.Add(this.lbl_LoaiThucDon);
			this.pnl_Data.Controls.Add(this.lbl_DonViTinh);
			this.pnl_Data.Controls.Add(this.tbx_SDT);
			this.pnl_Data.Controls.Add(this.tbx_SoNha);
			this.pnl_Data.Controls.Add(this.tbx_Email);
			this.pnl_Data.Controls.Add(this.lbl_GiaBan);
			this.pnl_Data.Controls.Add(this.tbx_HoTen);
			this.pnl_Data.Controls.Add(this.lbl_TenThucDon);
			this.pnl_Data.Controls.Add(this.tbx_Ma);
			this.pnl_Data.Controls.Add(this.lbl_MaThucDon);
			this.pnl_Data.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnl_Data.Location = new System.Drawing.Point(12, 153);
			this.pnl_Data.Name = "pnl_Data";
			this.pnl_Data.Size = new System.Drawing.Size(776, 146);
			this.pnl_Data.TabIndex = 8;
			// 
			// dt_NgaySinh
			// 
			this.dt_NgaySinh.CustomFormat = "dd/MM/yyyy";
			this.dt_NgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dt_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt_NgaySinh.Location = new System.Drawing.Point(123, 78);
			this.dt_NgaySinh.Name = "dt_NgaySinh";
			this.dt_NgaySinh.Size = new System.Drawing.Size(266, 26);
			this.dt_NgaySinh.TabIndex = 10;
			// 
			// cbx_QHuyen
			// 
			this.cbx_QHuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_QHuyen.FormattingEnabled = true;
			this.cbx_QHuyen.Location = new System.Drawing.Point(497, 46);
			this.cbx_QHuyen.Name = "cbx_QHuyen";
			this.cbx_QHuyen.Size = new System.Drawing.Size(250, 27);
			this.cbx_QHuyen.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(75, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 19);
			this.label1.TabIndex = 8;
			this.label1.Text = "Email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(435, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 19);
			this.label2.TabIndex = 8;
			this.label2.Text = "Số Nhà";
			// 
			// lbl_LoaiThucDon
			// 
			this.lbl_LoaiThucDon.AutoSize = true;
			this.lbl_LoaiThucDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_LoaiThucDon.Location = new System.Drawing.Point(398, 49);
			this.lbl_LoaiThucDon.Name = "lbl_LoaiThucDon";
			this.lbl_LoaiThucDon.Size = new System.Drawing.Size(93, 19);
			this.lbl_LoaiThucDon.TabIndex = 8;
			this.lbl_LoaiThucDon.Text = "Quận / Huyện";
			// 
			// lbl_DonViTinh
			// 
			this.lbl_DonViTinh.AutoSize = true;
			this.lbl_DonViTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_DonViTinh.Location = new System.Drawing.Point(395, 17);
			this.lbl_DonViTinh.Name = "lbl_DonViTinh";
			this.lbl_DonViTinh.Size = new System.Drawing.Size(96, 19);
			this.lbl_DonViTinh.TabIndex = 6;
			this.lbl_DonViTinh.Text = "Số Điện Thoại";
			// 
			// tbx_SDT
			// 
			this.tbx_SDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbx_SDT.Location = new System.Drawing.Point(497, 14);
			this.tbx_SDT.Name = "tbx_SDT";
			this.tbx_SDT.Size = new System.Drawing.Size(250, 26);
			this.tbx_SDT.TabIndex = 5;
			// 
			// tbx_SoNha
			// 
			this.tbx_SoNha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbx_SoNha.Location = new System.Drawing.Point(497, 79);
			this.tbx_SoNha.Name = "tbx_SoNha";
			this.tbx_SoNha.Size = new System.Drawing.Size(250, 26);
			this.tbx_SoNha.TabIndex = 5;
			// 
			// tbx_Email
			// 
			this.tbx_Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbx_Email.Location = new System.Drawing.Point(123, 110);
			this.tbx_Email.Name = "tbx_Email";
			this.tbx_Email.Size = new System.Drawing.Size(266, 26);
			this.tbx_Email.TabIndex = 5;
			// 
			// lbl_GiaBan
			// 
			this.lbl_GiaBan.AutoSize = true;
			this.lbl_GiaBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_GiaBan.Location = new System.Drawing.Point(45, 82);
			this.lbl_GiaBan.Name = "lbl_GiaBan";
			this.lbl_GiaBan.Size = new System.Drawing.Size(72, 19);
			this.lbl_GiaBan.TabIndex = 4;
			this.lbl_GiaBan.Text = "Ngày Sinh";
			// 
			// tbx_HoTen
			// 
			this.tbx_HoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbx_HoTen.Location = new System.Drawing.Point(123, 46);
			this.tbx_HoTen.Name = "tbx_HoTen";
			this.tbx_HoTen.Size = new System.Drawing.Size(266, 26);
			this.tbx_HoTen.TabIndex = 3;
			// 
			// lbl_TenThucDon
			// 
			this.lbl_TenThucDon.AutoSize = true;
			this.lbl_TenThucDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_TenThucDon.Location = new System.Drawing.Point(30, 49);
			this.lbl_TenThucDon.Name = "lbl_TenThucDon";
			this.lbl_TenThucDon.Size = new System.Drawing.Size(87, 19);
			this.lbl_TenThucDon.TabIndex = 2;
			this.lbl_TenThucDon.Text = "Tên Dược Sĩ";
			// 
			// tbx_Ma
			// 
			this.tbx_Ma.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbx_Ma.Location = new System.Drawing.Point(123, 14);
			this.tbx_Ma.Name = "tbx_Ma";
			this.tbx_Ma.ReadOnly = true;
			this.tbx_Ma.Size = new System.Drawing.Size(266, 26);
			this.tbx_Ma.TabIndex = 1;
			// 
			// lbl_MaThucDon
			// 
			this.lbl_MaThucDon.AutoSize = true;
			this.lbl_MaThucDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_MaThucDon.Location = new System.Drawing.Point(32, 17);
			this.lbl_MaThucDon.Name = "lbl_MaThucDon";
			this.lbl_MaThucDon.Size = new System.Drawing.Size(85, 19);
			this.lbl_MaThucDon.TabIndex = 0;
			this.lbl_MaThucDon.Text = "Mã Dược Sĩ";
			// 
			// dgv_dsDSi
			// 
			this.dgv_dsDSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_dsDSi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenDN,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colSDT,
            this.colDiaChi,
            this.colEmail,
            this.colVaiTro,
            this.colSoNha,
            this.colMaDs,
            this.colMaQL,
            this.colQuanHuyen});
			this.dgv_dsDSi.Location = new System.Drawing.Point(12, 305);
			this.dgv_dsDSi.Name = "dgv_dsDSi";
			this.dgv_dsDSi.RowTemplate.Height = 35;
			this.dgv_dsDSi.Size = new System.Drawing.Size(776, 433);
			this.dgv_dsDSi.TabIndex = 9;
			this.dgv_dsDSi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsDSi_CellClick);
			// 
			// colTenDN
			// 
			this.colTenDN.DataPropertyName = "TenDangNhap";
			this.colTenDN.HeaderText = "Tên đăng nhập";
			this.colTenDN.Name = "colTenDN";
			this.colTenDN.ReadOnly = true;
			this.colTenDN.Visible = false;
			// 
			// colHoTen
			// 
			this.colHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colHoTen.DataPropertyName = "TenNguoiDung";
			this.colHoTen.HeaderText = "Họ tên";
			this.colHoTen.Name = "colHoTen";
			this.colHoTen.ReadOnly = true;
			// 
			// colGioiTinh
			// 
			this.colGioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colGioiTinh.DataPropertyName = "GioiTinh";
			this.colGioiTinh.HeaderText = "Giới tính";
			this.colGioiTinh.Name = "colGioiTinh";
			this.colGioiTinh.ReadOnly = true;
			// 
			// colNgaySinh
			// 
			this.colNgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colNgaySinh.DataPropertyName = "NgaySinh";
			dataGridViewCellStyle1.Format = "dd/MM/yyy";
			dataGridViewCellStyle1.NullValue = null;
			this.colNgaySinh.DefaultCellStyle = dataGridViewCellStyle1;
			this.colNgaySinh.HeaderText = "Ngày sinh";
			this.colNgaySinh.Name = "colNgaySinh";
			this.colNgaySinh.ReadOnly = true;
			// 
			// colSDT
			// 
			this.colSDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colSDT.DataPropertyName = "SoDienThoai";
			this.colSDT.HeaderText = "Số điện thoại";
			this.colSDT.Name = "colSDT";
			this.colSDT.ReadOnly = true;
			// 
			// colDiaChi
			// 
			this.colDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colDiaChi.DataPropertyName = "DiaChi";
			this.colDiaChi.HeaderText = "Địa chỉ";
			this.colDiaChi.Name = "colDiaChi";
			this.colDiaChi.ReadOnly = true;
			// 
			// colEmail
			// 
			this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colEmail.DataPropertyName = "Email";
			this.colEmail.HeaderText = "Email";
			this.colEmail.Name = "colEmail";
			this.colEmail.ReadOnly = true;
			// 
			// colVaiTro
			// 
			this.colVaiTro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colVaiTro.DataPropertyName = "VaiTro";
			this.colVaiTro.HeaderText = "Vai trò";
			this.colVaiTro.Name = "colVaiTro";
			this.colVaiTro.ReadOnly = true;
			// 
			// colSoNha
			// 
			this.colSoNha.DataPropertyName = "SoNha";
			this.colSoNha.HeaderText = "Số nhà";
			this.colSoNha.Name = "colSoNha";
			this.colSoNha.ReadOnly = true;
			this.colSoNha.Visible = false;
			// 
			// colMaDs
			// 
			this.colMaDs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colMaDs.DataPropertyName = "MaDuocSi";
			this.colMaDs.HeaderText = "Mã dược sĩ";
			this.colMaDs.Name = "colMaDs";
			this.colMaDs.Visible = false;
			// 
			// colMaQL
			// 
			this.colMaQL.DataPropertyName = "MaQuanLy";
			this.colMaQL.HeaderText = "Mã quản lý";
			this.colMaQL.Name = "colMaQL";
			this.colMaQL.ReadOnly = true;
			this.colMaQL.Visible = false;
			// 
			// colQuanHuyen
			// 
			this.colQuanHuyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colQuanHuyen.DataPropertyName = "TenQuanHuyen";
			this.colQuanHuyen.HeaderText = "Quận huyện";
			this.colQuanHuyen.Name = "colQuanHuyen";
			this.colQuanHuyen.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(140)))));
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(574, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(214, 67);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btn_LocTT);
			this.panel1.Controls.Add(this.btn_Reset);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(556, 67);
			this.panel1.TabIndex = 10;
			// 
			// btn_LocTT
			// 
			this.btn_LocTT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_LocTT.Image = global::Nhom7_PhanMemQuanLyHieuThuoc.Properties.Resources.Filter;
			this.btn_LocTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_LocTT.Location = new System.Drawing.Point(403, 14);
			this.btn_LocTT.Name = "btn_LocTT";
			this.btn_LocTT.Size = new System.Drawing.Size(81, 38);
			this.btn_LocTT.TabIndex = 3;
			this.btn_LocTT.Text = "Lọc";
			this.btn_LocTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_LocTT.UseVisualStyleBackColor = true;
			this.btn_LocTT.Click += new System.EventHandler(this.btn_Filter_Click);
			// 
			// btn_Reset
			// 
			this.btn_Reset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Reset.Location = new System.Drawing.Point(490, 14);
			this.btn_Reset.Name = "btn_Reset";
			this.btn_Reset.Size = new System.Drawing.Size(52, 38);
			this.btn_Reset.TabIndex = 3;
			this.btn_Reset.Text = "Reset";
			this.btn_Reset.UseVisualStyleBackColor = true;
			this.btn_Reset.Click += new System.EventHandler(this.btn_LamMoi_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Image = global::Nhom7_PhanMemQuanLyHieuThuoc.Properties.Resources.Search;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(291, 14);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(106, 38);
			this.button1.TabIndex = 3;
			this.button1.Text = "Tìm Kiếm";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Image = global::Nhom7_PhanMemQuanLyHieuThuoc.Properties.Resources.Delete;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(212, 14);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(73, 38);
			this.button2.TabIndex = 2;
			this.button2.Text = "Xóa";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Image = global::Nhom7_PhanMemQuanLyHieuThuoc.Properties.Resources.Update;
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new System.Drawing.Point(101, 14);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(105, 38);
			this.button3.TabIndex = 1;
			this.button3.Text = " Cập Nhật";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.btn_Update_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Image = global::Nhom7_PhanMemQuanLyHieuThuoc.Properties.Resources.Insert;
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(12, 14);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(83, 38);
			this.button4.TabIndex = 0;
			this.button4.Text = "Thêm";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.btn_Insert_Click);
			// 
			// frm_Account
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 750);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgv_dsDSi);
			this.Controls.Add(this.pnl_Data);
			this.Controls.Add(this.lbl_Title);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_Account";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QLDS";
			this.Load += new System.EventHandler(this.frm_QLDS_Load);
			this.pnl_Data.ResumeLayout(false);
			this.pnl_Data.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_dsDSi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.Panel pnl_Data;
		private System.Windows.Forms.ComboBox cbx_QHuyen;
		private System.Windows.Forms.Label lbl_LoaiThucDon;
		private System.Windows.Forms.Label lbl_DonViTinh;
		private System.Windows.Forms.Label lbl_GiaBan;
		private System.Windows.Forms.TextBox tbx_HoTen;
		private System.Windows.Forms.Label lbl_TenThucDon;
		private System.Windows.Forms.TextBox tbx_Ma;
		private System.Windows.Forms.Label lbl_MaThucDon;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbx_Email;
		private System.Windows.Forms.TextBox tbx_SDT;
		private System.Windows.Forms.DataGridView dgv_dsDSi;
		private System.Windows.Forms.DateTimePicker dt_NgaySinh;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbx_SoNha;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTenDN;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
		private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
		private System.Windows.Forms.DataGridViewTextBoxColumn colVaiTro;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSoNha;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaDs;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaQL;
		private System.Windows.Forms.DataGridViewTextBoxColumn colQuanHuyen;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_LocTT;
		private System.Windows.Forms.Button btn_Reset;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}

