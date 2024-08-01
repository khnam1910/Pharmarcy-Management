namespace Nhom7_PhanMemQuanLyHieuThuoc
{
	partial class frm_Bill
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
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.tbx_DonGia = new System.Windows.Forms.TextBox();
            this.lbl_dongia = new System.Windows.Forms.Label();
            this.cbx_MaHoaDon = new System.Windows.Forms.ComboBox();
            this.lbl_MaHoaDon1 = new System.Windows.Forms.Label();
            this.rdo_ChiTietHoaDon = new System.Windows.Forms.RadioButton();
            this.rdo_HoaDon = new System.Windows.Forms.RadioButton();
            this.tbx_SoLuong = new System.Windows.Forms.TextBox();
            this.cbx_MaThucDon = new System.Windows.Forms.ComboBox();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.dtp_NgayDat = new System.Windows.Forms.DateTimePicker();
            this.lbl_MaThucDon = new System.Windows.Forms.Label();
            this.cbx_KhachHang = new System.Windows.Forms.ComboBox();
            this.lbl_KhachHang = new System.Windows.Forms.Label();
            this.lbl_NhanVien = new System.Windows.Forms.Label();
            this.lbl_NgayDat = new System.Windows.Forms.Label();
            this.tbx_ThanhTien = new System.Windows.Forms.TextBox();
            this.lbl_ThanhTien = new System.Windows.Forms.Label();
            this.tbx_MaDonHang = new System.Windows.Forms.TextBox();
            this.lbl_MaHoaDon = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Tooltip = new System.Windows.Forms.Panel();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.dgv_ChiTietHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            this.pnl_Data.SuspendLayout();
            this.pnl_Tooltip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.AllowUserToAddRows = false;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Location = new System.Drawing.Point(12, 293);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.RowHeadersWidth = 51;
            this.dgv_HoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HoaDon.Size = new System.Drawing.Size(812, 240);
            this.dgv_HoaDon.TabIndex = 2;
            this.dgv_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDon_CellClick);
            // 
            // pnl_Data
            // 
            this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Data.Controls.Add(this.lbl_MaNV);
            this.pnl_Data.Controls.Add(this.tbx_DonGia);
            this.pnl_Data.Controls.Add(this.lbl_dongia);
            this.pnl_Data.Controls.Add(this.cbx_MaHoaDon);
            this.pnl_Data.Controls.Add(this.lbl_MaHoaDon1);
            this.pnl_Data.Controls.Add(this.rdo_ChiTietHoaDon);
            this.pnl_Data.Controls.Add(this.rdo_HoaDon);
            this.pnl_Data.Controls.Add(this.tbx_SoLuong);
            this.pnl_Data.Controls.Add(this.cbx_MaThucDon);
            this.pnl_Data.Controls.Add(this.lbl_SoLuong);
            this.pnl_Data.Controls.Add(this.dtp_NgayDat);
            this.pnl_Data.Controls.Add(this.lbl_MaThucDon);
            this.pnl_Data.Controls.Add(this.cbx_KhachHang);
            this.pnl_Data.Controls.Add(this.lbl_KhachHang);
            this.pnl_Data.Controls.Add(this.lbl_NhanVien);
            this.pnl_Data.Controls.Add(this.lbl_NgayDat);
            this.pnl_Data.Controls.Add(this.tbx_ThanhTien);
            this.pnl_Data.Controls.Add(this.lbl_ThanhTien);
            this.pnl_Data.Controls.Add(this.tbx_MaDonHang);
            this.pnl_Data.Controls.Add(this.lbl_MaHoaDon);
            this.pnl_Data.Location = new System.Drawing.Point(12, 85);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(812, 194);
            this.pnl_Data.TabIndex = 3;
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Location = new System.Drawing.Point(127, 118);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(53, 19);
            this.lbl_MaNV.TabIndex = 20;
            this.lbl_MaNV.Text = "DS002";
            // 
            // tbx_DonGia
            // 
            this.tbx_DonGia.Enabled = false;
            this.tbx_DonGia.Location = new System.Drawing.Point(495, 116);
            this.tbx_DonGia.Name = "tbx_DonGia";
            this.tbx_DonGia.Size = new System.Drawing.Size(250, 26);
            this.tbx_DonGia.TabIndex = 19;
            // 
            // lbl_dongia
            // 
            this.lbl_dongia.AutoSize = true;
            this.lbl_dongia.Location = new System.Drawing.Point(419, 118);
            this.lbl_dongia.Name = "lbl_dongia";
            this.lbl_dongia.Size = new System.Drawing.Size(56, 19);
            this.lbl_dongia.TabIndex = 18;
            this.lbl_dongia.Text = "Đơn giá";
            // 
            // cbx_MaHoaDon
            // 
            this.cbx_MaHoaDon.FormattingEnabled = true;
            this.cbx_MaHoaDon.Location = new System.Drawing.Point(495, 16);
            this.cbx_MaHoaDon.Name = "cbx_MaHoaDon";
            this.cbx_MaHoaDon.Size = new System.Drawing.Size(250, 27);
            this.cbx_MaHoaDon.TabIndex = 17;
            // 
            // lbl_MaHoaDon1
            // 
            this.lbl_MaHoaDon1.AutoSize = true;
            this.lbl_MaHoaDon1.Location = new System.Drawing.Point(399, 20);
            this.lbl_MaHoaDon1.Name = "lbl_MaHoaDon1";
            this.lbl_MaHoaDon1.Size = new System.Drawing.Size(90, 19);
            this.lbl_MaHoaDon1.TabIndex = 16;
            this.lbl_MaHoaDon1.Text = "Mã Hóa Đơn";
            // 
            // rdo_ChiTietHoaDon
            // 
            this.rdo_ChiTietHoaDon.AutoSize = true;
            this.rdo_ChiTietHoaDon.Location = new System.Drawing.Point(557, 148);
            this.rdo_ChiTietHoaDon.Name = "rdo_ChiTietHoaDon";
            this.rdo_ChiTietHoaDon.Size = new System.Drawing.Size(134, 23);
            this.rdo_ChiTietHoaDon.TabIndex = 15;
            this.rdo_ChiTietHoaDon.TabStop = true;
            this.rdo_ChiTietHoaDon.Text = "Chi Tiết Hóa Đơn";
            this.rdo_ChiTietHoaDon.UseVisualStyleBackColor = true;
            // 
            // rdo_HoaDon
            // 
            this.rdo_HoaDon.AutoSize = true;
            this.rdo_HoaDon.Location = new System.Drawing.Point(468, 148);
            this.rdo_HoaDon.Name = "rdo_HoaDon";
            this.rdo_HoaDon.Size = new System.Drawing.Size(83, 23);
            this.rdo_HoaDon.TabIndex = 14;
            this.rdo_HoaDon.TabStop = true;
            this.rdo_HoaDon.Text = "Hóa Đơn";
            this.rdo_HoaDon.UseVisualStyleBackColor = true;
            // 
            // tbx_SoLuong
            // 
            this.tbx_SoLuong.Location = new System.Drawing.Point(495, 85);
            this.tbx_SoLuong.Name = "tbx_SoLuong";
            this.tbx_SoLuong.Size = new System.Drawing.Size(250, 26);
            this.tbx_SoLuong.TabIndex = 11;
            // 
            // cbx_MaThucDon
            // 
            this.cbx_MaThucDon.FormattingEnabled = true;
            this.cbx_MaThucDon.Location = new System.Drawing.Point(495, 52);
            this.cbx_MaThucDon.Name = "cbx_MaThucDon";
            this.cbx_MaThucDon.Size = new System.Drawing.Size(250, 27);
            this.cbx_MaThucDon.TabIndex = 13;
            this.cbx_MaThucDon.SelectionChangeCommitted += new System.EventHandler(this.cbx_MaThucDon_SelectionChangeCommitted);
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Location = new System.Drawing.Point(419, 87);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(70, 19);
            this.lbl_SoLuong.TabIndex = 10;
            this.lbl_SoLuong.Text = "Số Lượng";
            // 
            // dtp_NgayDat
            // 
            this.dtp_NgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayDat.Location = new System.Drawing.Point(127, 84);
            this.dtp_NgayDat.Name = "dtp_NgayDat";
            this.dtp_NgayDat.Size = new System.Drawing.Size(251, 26);
            this.dtp_NgayDat.TabIndex = 10;
            // 
            // lbl_MaThucDon
            // 
            this.lbl_MaThucDon.AutoSize = true;
            this.lbl_MaThucDon.Location = new System.Drawing.Point(417, 56);
            this.lbl_MaThucDon.Name = "lbl_MaThucDon";
            this.lbl_MaThucDon.Size = new System.Drawing.Size(74, 19);
            this.lbl_MaThucDon.TabIndex = 12;
            this.lbl_MaThucDon.Text = "Tên Thuốc";
            // 
            // cbx_KhachHang
            // 
            this.cbx_KhachHang.FormattingEnabled = true;
            this.cbx_KhachHang.Location = new System.Drawing.Point(127, 148);
            this.cbx_KhachHang.Name = "cbx_KhachHang";
            this.cbx_KhachHang.Size = new System.Drawing.Size(250, 27);
            this.cbx_KhachHang.TabIndex = 9;
            // 
            // lbl_KhachHang
            // 
            this.lbl_KhachHang.AutoSize = true;
            this.lbl_KhachHang.Location = new System.Drawing.Point(36, 151);
            this.lbl_KhachHang.Name = "lbl_KhachHang";
            this.lbl_KhachHang.Size = new System.Drawing.Size(85, 19);
            this.lbl_KhachHang.TabIndex = 8;
            this.lbl_KhachHang.Text = "Khách Hàng";
            // 
            // lbl_NhanVien
            // 
            this.lbl_NhanVien.AutoSize = true;
            this.lbl_NhanVien.Location = new System.Drawing.Point(48, 119);
            this.lbl_NhanVien.Name = "lbl_NhanVien";
            this.lbl_NhanVien.Size = new System.Drawing.Size(73, 19);
            this.lbl_NhanVien.TabIndex = 6;
            this.lbl_NhanVien.Text = "Nhân Viên";
            // 
            // lbl_NgayDat
            // 
            this.lbl_NgayDat.AutoSize = true;
            this.lbl_NgayDat.Location = new System.Drawing.Point(53, 88);
            this.lbl_NgayDat.Name = "lbl_NgayDat";
            this.lbl_NgayDat.Size = new System.Drawing.Size(68, 19);
            this.lbl_NgayDat.TabIndex = 4;
            this.lbl_NgayDat.Text = "Ngày Đặt";
            // 
            // tbx_ThanhTien
            // 
            this.tbx_ThanhTien.Location = new System.Drawing.Point(127, 49);
            this.tbx_ThanhTien.Name = "tbx_ThanhTien";
            this.tbx_ThanhTien.Size = new System.Drawing.Size(251, 26);
            this.tbx_ThanhTien.TabIndex = 3;
            // 
            // lbl_ThanhTien
            // 
            this.lbl_ThanhTien.AutoSize = true;
            this.lbl_ThanhTien.Location = new System.Drawing.Point(46, 52);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(75, 19);
            this.lbl_ThanhTien.TabIndex = 2;
            this.lbl_ThanhTien.Text = "Thành Tiền";
            // 
            // tbx_MaDonHang
            // 
            this.tbx_MaDonHang.Location = new System.Drawing.Point(127, 17);
            this.tbx_MaDonHang.Name = "tbx_MaDonHang";
            this.tbx_MaDonHang.Size = new System.Drawing.Size(251, 26);
            this.tbx_MaDonHang.TabIndex = 1;
            // 
            // lbl_MaHoaDon
            // 
            this.lbl_MaHoaDon.AutoSize = true;
            this.lbl_MaHoaDon.Location = new System.Drawing.Point(31, 20);
            this.lbl_MaHoaDon.Name = "lbl_MaHoaDon";
            this.lbl_MaHoaDon.Size = new System.Drawing.Size(90, 19);
            this.lbl_MaHoaDon.TabIndex = 0;
            this.lbl_MaHoaDon.Text = "Mã Hóa Đơn";
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(12, 17);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(277, 50);
            this.lbl_Title.TabIndex = 6;
            this.lbl_Title.Text = "Quản Lý Hóa Đơn";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Tooltip
            // 
            this.pnl_Tooltip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Tooltip.Controls.Add(this.btn_Filter);
            this.pnl_Tooltip.Controls.Add(this.btn_Search);
            this.pnl_Tooltip.Controls.Add(this.btn_Delete);
            this.pnl_Tooltip.Controls.Add(this.btn_Update);
            this.pnl_Tooltip.Controls.Add(this.btn_Insert);
            this.pnl_Tooltip.Location = new System.Drawing.Point(295, 12);
            this.pnl_Tooltip.Name = "pnl_Tooltip";
            this.pnl_Tooltip.Size = new System.Drawing.Size(529, 67);
            this.pnl_Tooltip.TabIndex = 5;
            // 
            // btn_Filter
            // 
            this.btn_Filter.Image = global::Nhom7_PhanMemQuanLyHieuThuoc.Properties.Resources.Filter;
            this.btn_Filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Filter.Location = new System.Drawing.Point(403, 14);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(107, 38);
            this.btn_Filter.TabIndex = 4;
            this.btn_Filter.Text = "Làm mới";
            this.btn_Filter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Image = global::Nhom7_PhanMemQuanLyHieuThuoc.Properties.Resources.Search;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(291, 14);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(106, 38);
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
            this.btn_Delete.Location = new System.Drawing.Point(212, 14);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(73, 38);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click_1);
            // 
            // btn_Update
            // 
            this.btn_Update.Image = global::Nhom7_PhanMemQuanLyHieuThuoc.Properties.Resources.Update;
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(101, 14);
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
            this.btn_Insert.Location = new System.Drawing.Point(12, 14);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(83, 38);
            this.btn_Insert.TabIndex = 0;
            this.btn_Insert.Text = "Thêm";
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click_1);
            // 
            // dgv_ChiTietHoaDon
            // 
            this.dgv_ChiTietHoaDon.AllowUserToAddRows = false;
            this.dgv_ChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietHoaDon.Location = new System.Drawing.Point(12, 539);
            this.dgv_ChiTietHoaDon.Name = "dgv_ChiTietHoaDon";
            this.dgv_ChiTietHoaDon.RowHeadersWidth = 51;
            this.dgv_ChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ChiTietHoaDon.Size = new System.Drawing.Size(812, 199);
            this.dgv_ChiTietHoaDon.TabIndex = 7;
            this.dgv_ChiTietHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChiTietHoaDon_CellClick);
            // 
            // frm_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 749);
            this.Controls.Add(this.dgv_ChiTietHoaDon);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pnl_Tooltip);
            this.Controls.Add(this.pnl_Data);
            this.Controls.Add(this.dgv_HoaDon);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Type";
            this.Load += new System.EventHandler(this.frm_Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            this.pnl_Data.ResumeLayout(false);
            this.pnl_Data.PerformLayout();
            this.pnl_Tooltip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dgv_HoaDon;
		private System.Windows.Forms.Panel pnl_Data;
		private System.Windows.Forms.TextBox tbx_ThanhTien;
		private System.Windows.Forms.Label lbl_ThanhTien;
		private System.Windows.Forms.TextBox tbx_MaDonHang;
		private System.Windows.Forms.Label lbl_MaHoaDon;
		private System.Windows.Forms.Label lbl_NgayDat;
		private System.Windows.Forms.ComboBox cbx_KhachHang;
		private System.Windows.Forms.Label lbl_KhachHang;
		private System.Windows.Forms.Label lbl_NhanVien;
		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.Panel pnl_Tooltip;
		private System.Windows.Forms.Button btn_Filter;
		private System.Windows.Forms.Button btn_Search;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_Update;
		private System.Windows.Forms.Button btn_Insert;
		private System.Windows.Forms.DateTimePicker dtp_NgayDat;
		private System.Windows.Forms.DataGridView dgv_ChiTietHoaDon;
		private System.Windows.Forms.ComboBox cbx_MaThucDon;
		private System.Windows.Forms.Label lbl_MaThucDon;
		private System.Windows.Forms.TextBox tbx_SoLuong;
		private System.Windows.Forms.Label lbl_SoLuong;
		private System.Windows.Forms.RadioButton rdo_ChiTietHoaDon;
		private System.Windows.Forms.RadioButton rdo_HoaDon;
		private System.Windows.Forms.ComboBox cbx_MaHoaDon;
		private System.Windows.Forms.Label lbl_MaHoaDon1;
        private System.Windows.Forms.TextBox tbx_DonGia;
        private System.Windows.Forms.Label lbl_dongia;
        private System.Windows.Forms.Label lbl_MaNV;
    }
}