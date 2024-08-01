
namespace Nhom7_PhanMemQuanLyHieuThuoc
{
    partial class frm_Order
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
            this.dgv_ChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Tooltip = new System.Windows.Forms.Panel();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.nm_DonGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nm_SoLuongNhan = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_TrangThai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_MaCTPN = new System.Windows.Forms.TextBox();
            this.nm_SoLuongDat = new System.Windows.Forms.NumericUpDown();
            this.cbx_LoaiThuoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_MaPhieuNhap1 = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.cbx_NhaCungCap = new System.Windows.Forms.ComboBox();
            this.lbl_NhaCungCap = new System.Windows.Forms.Label();
            this.cbx_Thuoc = new System.Windows.Forms.ComboBox();
            this.lbl_NhanVien = new System.Windows.Forms.Label();
            this.tbx_ThanhTien = new System.Windows.Forms.TextBox();
            this.lbl_ThanhTien = new System.Windows.Forms.Label();
            this.tbx_MaPhieuNhap = new System.Windows.Forms.TextBox();
            this.lbl_MaPhieuNhap = new System.Windows.Forms.Label();
            this.dgv_PhieuNhap = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhieuNhap)).BeginInit();
            this.pnl_Tooltip.SuspendLayout();
            this.pnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_DonGiaNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_SoLuongNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_SoLuongDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ChiTietPhieuNhap
            // 
            this.dgv_ChiTietPhieuNhap.AllowUserToAddRows = false;
            this.dgv_ChiTietPhieuNhap.AllowUserToDeleteRows = false;
            this.dgv_ChiTietPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTietPhieuNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietPhieuNhap.Location = new System.Drawing.Point(6, 25);
            this.dgv_ChiTietPhieuNhap.Name = "dgv_ChiTietPhieuNhap";
            this.dgv_ChiTietPhieuNhap.ReadOnly = true;
            this.dgv_ChiTietPhieuNhap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_ChiTietPhieuNhap.Size = new System.Drawing.Size(772, 179);
            this.dgv_ChiTietPhieuNhap.TabIndex = 12;
            this.dgv_ChiTietPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiTietPhieuNhap_CellClick);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(6, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(279, 50);
            this.lbl_Title.TabIndex = 11;
            this.lbl_Title.Text = "Quản Lý Phiếu Nhập";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Tooltip
            // 
            this.pnl_Tooltip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Tooltip.Controls.Add(this.btn_Reset);
            this.pnl_Tooltip.Controls.Add(this.btn_Filter);
            this.pnl_Tooltip.Controls.Add(this.btn_Search);
            this.pnl_Tooltip.Controls.Add(this.btn_Delete);
            this.pnl_Tooltip.Controls.Add(this.btn_Update);
            this.pnl_Tooltip.Controls.Add(this.btn_Insert);
            this.pnl_Tooltip.Location = new System.Drawing.Point(291, 2);
            this.pnl_Tooltip.Name = "pnl_Tooltip";
            this.pnl_Tooltip.Size = new System.Drawing.Size(505, 67);
            this.pnl_Tooltip.TabIndex = 10;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reset.Location = new System.Drawing.Point(448, 16);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(52, 38);
            this.btn_Reset.TabIndex = 28;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.Image = global::Nhom7_PhanMemQuanLyHieuThuoc.Properties.Resources.Filter;
            this.btn_Filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Filter.Location = new System.Drawing.Point(377, 16);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(67, 38);
            this.btn_Filter.TabIndex = 4;
            this.btn_Filter.Text = "Lọc";
            this.btn_Filter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Image = global::Nhom7_PhanMemQuanLyHieuThuoc.Properties.Resources.Search;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(271, 16);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(100, 38);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Tìm Kiếm";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::Nhom7_PhanMemQuanLyHieuThuoc.Properties.Resources.Delete;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(196, 16);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(69, 38);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Image = global::Nhom7_PhanMemQuanLyHieuThuoc.Properties.Resources.Update;
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(85, 16);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(105, 38);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Cập Nhật";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Image = global::Nhom7_PhanMemQuanLyHieuThuoc.Properties.Resources.Insert;
            this.btn_Insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Insert.Location = new System.Drawing.Point(3, 16);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(79, 38);
            this.btn_Insert.TabIndex = 0;
            this.btn_Insert.Text = "Thêm";
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // pnl_Data
            // 
            this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Data.Controls.Add(this.NgayNhap);
            this.pnl_Data.Controls.Add(this.label5);
            this.pnl_Data.Controls.Add(this.nm_DonGiaNhap);
            this.pnl_Data.Controls.Add(this.label4);
            this.pnl_Data.Controls.Add(this.nm_SoLuongNhan);
            this.pnl_Data.Controls.Add(this.label3);
            this.pnl_Data.Controls.Add(this.tbx_TrangThai);
            this.pnl_Data.Controls.Add(this.label2);
            this.pnl_Data.Controls.Add(this.tbx_MaCTPN);
            this.pnl_Data.Controls.Add(this.nm_SoLuongDat);
            this.pnl_Data.Controls.Add(this.cbx_LoaiThuoc);
            this.pnl_Data.Controls.Add(this.label1);
            this.pnl_Data.Controls.Add(this.lbl_MaPhieuNhap1);
            this.pnl_Data.Controls.Add(this.lbl_SoLuong);
            this.pnl_Data.Controls.Add(this.cbx_NhaCungCap);
            this.pnl_Data.Controls.Add(this.lbl_NhaCungCap);
            this.pnl_Data.Controls.Add(this.cbx_Thuoc);
            this.pnl_Data.Controls.Add(this.lbl_NhanVien);
            this.pnl_Data.Controls.Add(this.tbx_ThanhTien);
            this.pnl_Data.Controls.Add(this.lbl_ThanhTien);
            this.pnl_Data.Controls.Add(this.tbx_MaPhieuNhap);
            this.pnl_Data.Controls.Add(this.lbl_MaPhieuNhap);
            this.pnl_Data.Location = new System.Drawing.Point(12, 75);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(784, 188);
            this.pnl_Data.TabIndex = 9;
            // 
            // NgayNhap
            // 
            this.NgayNhap.CustomFormat = "";
            this.NgayNhap.Enabled = false;
            this.NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayNhap.Location = new System.Drawing.Point(495, 116);
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Size = new System.Drawing.Size(121, 26);
            this.NgayNhap.TabIndex = 29;
            this.NgayNhap.ValueChanged += new System.EventHandler(this.NgayNhap_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ngày Nhập";
            // 
            // nm_DonGiaNhap
            // 
            this.nm_DonGiaNhap.Location = new System.Drawing.Point(559, 148);
            this.nm_DonGiaNhap.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nm_DonGiaNhap.Name = "nm_DonGiaNhap";
            this.nm_DonGiaNhap.Size = new System.Drawing.Size(88, 26);
            this.nm_DonGiaNhap.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Đơn Giá Nhập";
            // 
            // nm_SoLuongNhan
            // 
            this.nm_SoLuongNhan.Location = new System.Drawing.Point(346, 148);
            this.nm_SoLuongNhan.Name = "nm_SoLuongNhan";
            this.nm_SoLuongNhan.Size = new System.Drawing.Size(88, 26);
            this.nm_SoLuongNhan.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Số Lượng Nhận";
            // 
            // tbx_TrangThai
            // 
            this.tbx_TrangThai.Enabled = false;
            this.tbx_TrangThai.Location = new System.Drawing.Point(494, 48);
            this.tbx_TrangThai.Name = "tbx_TrangThai";
            this.tbx_TrangThai.ReadOnly = true;
            this.tbx_TrangThai.Size = new System.Drawing.Size(252, 26);
            this.tbx_TrangThai.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Trạng thái";
            // 
            // tbx_MaCTPN
            // 
            this.tbx_MaCTPN.Enabled = false;
            this.tbx_MaCTPN.Location = new System.Drawing.Point(495, 16);
            this.tbx_MaCTPN.Name = "tbx_MaCTPN";
            this.tbx_MaCTPN.ReadOnly = true;
            this.tbx_MaCTPN.Size = new System.Drawing.Size(251, 26);
            this.tbx_MaCTPN.TabIndex = 21;
            // 
            // nm_SoLuongDat
            // 
            this.nm_SoLuongDat.Location = new System.Drawing.Point(127, 148);
            this.nm_SoLuongDat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nm_SoLuongDat.Name = "nm_SoLuongDat";
            this.nm_SoLuongDat.Size = new System.Drawing.Size(88, 26);
            this.nm_SoLuongDat.TabIndex = 20;
            // 
            // cbx_LoaiThuoc
            // 
            this.cbx_LoaiThuoc.Enabled = false;
            this.cbx_LoaiThuoc.FormattingEnabled = true;
            this.cbx_LoaiThuoc.Location = new System.Drawing.Point(127, 82);
            this.cbx_LoaiThuoc.Name = "cbx_LoaiThuoc";
            this.cbx_LoaiThuoc.Size = new System.Drawing.Size(252, 27);
            this.cbx_LoaiThuoc.TabIndex = 19;
            this.cbx_LoaiThuoc.SelectedIndexChanged += new System.EventHandler(this.cbx_LoaiThuoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Loại Thuốc";
            // 
            // lbl_MaPhieuNhap1
            // 
            this.lbl_MaPhieuNhap1.AutoSize = true;
            this.lbl_MaPhieuNhap1.Location = new System.Drawing.Point(411, 20);
            this.lbl_MaPhieuNhap1.Name = "lbl_MaPhieuNhap1";
            this.lbl_MaPhieuNhap1.Size = new System.Drawing.Size(75, 19);
            this.lbl_MaPhieuNhap1.TabIndex = 16;
            this.lbl_MaPhieuNhap1.Text = "Mã CTPN";
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Location = new System.Drawing.Point(21, 150);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(96, 19);
            this.lbl_SoLuong.TabIndex = 10;
            this.lbl_SoLuong.Text = "Số Lượng Đặt";
            // 
            // cbx_NhaCungCap
            // 
            this.cbx_NhaCungCap.FormattingEnabled = true;
            this.cbx_NhaCungCap.Location = new System.Drawing.Point(127, 49);
            this.cbx_NhaCungCap.Name = "cbx_NhaCungCap";
            this.cbx_NhaCungCap.Size = new System.Drawing.Size(251, 27);
            this.cbx_NhaCungCap.TabIndex = 9;
            // 
            // lbl_NhaCungCap
            // 
            this.lbl_NhaCungCap.AutoSize = true;
            this.lbl_NhaCungCap.Location = new System.Drawing.Point(16, 52);
            this.lbl_NhaCungCap.Name = "lbl_NhaCungCap";
            this.lbl_NhaCungCap.Size = new System.Drawing.Size(101, 19);
            this.lbl_NhaCungCap.TabIndex = 8;
            this.lbl_NhaCungCap.Text = "Nhà Cung Cấp";
            // 
            // cbx_Thuoc
            // 
            this.cbx_Thuoc.Enabled = false;
            this.cbx_Thuoc.FormattingEnabled = true;
            this.cbx_Thuoc.Location = new System.Drawing.Point(127, 115);
            this.cbx_Thuoc.Name = "cbx_Thuoc";
            this.cbx_Thuoc.Size = new System.Drawing.Size(252, 27);
            this.cbx_Thuoc.TabIndex = 7;
            // 
            // lbl_NhanVien
            // 
            this.lbl_NhanVien.AutoSize = true;
            this.lbl_NhanVien.Location = new System.Drawing.Point(43, 118);
            this.lbl_NhanVien.Name = "lbl_NhanVien";
            this.lbl_NhanVien.Size = new System.Drawing.Size(74, 19);
            this.lbl_NhanVien.TabIndex = 6;
            this.lbl_NhanVien.Text = "Tên Thuốc";
            // 
            // tbx_ThanhTien
            // 
            this.tbx_ThanhTien.Enabled = false;
            this.tbx_ThanhTien.Location = new System.Drawing.Point(495, 80);
            this.tbx_ThanhTien.Name = "tbx_ThanhTien";
            this.tbx_ThanhTien.ReadOnly = true;
            this.tbx_ThanhTien.Size = new System.Drawing.Size(252, 26);
            this.tbx_ThanhTien.TabIndex = 3;
            // 
            // lbl_ThanhTien
            // 
            this.lbl_ThanhTien.AutoSize = true;
            this.lbl_ThanhTien.Location = new System.Drawing.Point(411, 84);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(75, 19);
            this.lbl_ThanhTien.TabIndex = 2;
            this.lbl_ThanhTien.Text = "Thành Tiền";
            // 
            // tbx_MaPhieuNhap
            // 
            this.tbx_MaPhieuNhap.Enabled = false;
            this.tbx_MaPhieuNhap.Location = new System.Drawing.Point(127, 17);
            this.tbx_MaPhieuNhap.Name = "tbx_MaPhieuNhap";
            this.tbx_MaPhieuNhap.ReadOnly = true;
            this.tbx_MaPhieuNhap.Size = new System.Drawing.Size(251, 26);
            this.tbx_MaPhieuNhap.TabIndex = 1;
            // 
            // lbl_MaPhieuNhap
            // 
            this.lbl_MaPhieuNhap.AutoSize = true;
            this.lbl_MaPhieuNhap.Location = new System.Drawing.Point(12, 19);
            this.lbl_MaPhieuNhap.Name = "lbl_MaPhieuNhap";
            this.lbl_MaPhieuNhap.Size = new System.Drawing.Size(105, 19);
            this.lbl_MaPhieuNhap.TabIndex = 0;
            this.lbl_MaPhieuNhap.Text = "Mã Phiếu Nhập";
            // 
            // dgv_PhieuNhap
            // 
            this.dgv_PhieuNhap.AllowUserToAddRows = false;
            this.dgv_PhieuNhap.AllowUserToDeleteRows = false;
            this.dgv_PhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PhieuNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_PhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuNhap.Location = new System.Drawing.Point(6, 25);
            this.dgv_PhieuNhap.Name = "dgv_PhieuNhap";
            this.dgv_PhieuNhap.ReadOnly = true;
            this.dgv_PhieuNhap.Size = new System.Drawing.Size(774, 221);
            this.dgv_PhieuNhap.TabIndex = 8;
            this.dgv_PhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhieuNhap_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_PhieuNhap);
            this.groupBox1.Location = new System.Drawing.Point(12, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 252);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_ChiTietPhieuNhap);
            this.groupBox2.Location = new System.Drawing.Point(12, 527);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 210);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chi tiết phiếu nhập";
            // 
            // frm_Received
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pnl_Tooltip);
            this.Controls.Add(this.pnl_Data);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Received";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Received";
            this.Load += new System.EventHandler(this.frm_Received_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhieuNhap)).EndInit();
            this.pnl_Tooltip.ResumeLayout(false);
            this.pnl_Data.ResumeLayout(false);
            this.pnl_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_DonGiaNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_SoLuongNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_SoLuongDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ChiTietPhieuNhap;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnl_Tooltip;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Panel pnl_Data;
        private System.Windows.Forms.Label lbl_MaPhieuNhap1;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.ComboBox cbx_NhaCungCap;
        private System.Windows.Forms.Label lbl_NhaCungCap;
        private System.Windows.Forms.ComboBox cbx_Thuoc;
        private System.Windows.Forms.Label lbl_NhanVien;
        private System.Windows.Forms.TextBox tbx_ThanhTien;
        private System.Windows.Forms.Label lbl_ThanhTien;
        private System.Windows.Forms.TextBox tbx_MaPhieuNhap;
        private System.Windows.Forms.Label lbl_MaPhieuNhap;
        private System.Windows.Forms.DataGridView dgv_PhieuNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_LoaiThuoc;
        private System.Windows.Forms.NumericUpDown nm_SoLuongDat;
        private System.Windows.Forms.TextBox tbx_MaCTPN;
        private System.Windows.Forms.TextBox tbx_TrangThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nm_SoLuongNhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nm_DonGiaNhap;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker NgayNhap;
    }
}