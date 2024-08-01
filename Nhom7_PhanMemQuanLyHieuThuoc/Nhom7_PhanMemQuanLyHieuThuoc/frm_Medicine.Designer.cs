namespace Nhom7_PhanMemQuanLyHieuThuoc
{
	partial class frm_Medicine
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
			this.lbl_Title = new System.Windows.Forms.Label();
			this.pnl_Tooltip = new System.Windows.Forms.Panel();
			this.btn_Filter = new System.Windows.Forms.Button();
			this.btn_Search = new System.Windows.Forms.Button();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Update = new System.Windows.Forms.Button();
			this.btn_Insert = new System.Windows.Forms.Button();
			this.pnl_Data = new System.Windows.Forms.Panel();
			this.lbl_Benh = new System.Windows.Forms.Label();
			this.cbx_Benh = new System.Windows.Forms.ComboBox();
			this.lbl_SoLuongTon = new System.Windows.Forms.Label();
			this.tbx_SoLuongTon = new System.Windows.Forms.TextBox();
			this.tbx_GiaBan = new System.Windows.Forms.TextBox();
			this.lbl_GiaBan = new System.Windows.Forms.Label();
			this.lbl_GiaNhap = new System.Windows.Forms.Label();
			this.tbx_GiaNhap = new System.Windows.Forms.TextBox();
			this.lbl_ThanhPhan = new System.Windows.Forms.Label();
			this.tbx_ThanhPhan = new System.Windows.Forms.TextBox();
			this.lbl_TenThuoc = new System.Windows.Forms.Label();
			this.tbx_TenThuoc = new System.Windows.Forms.TextBox();
			this.cbx_MaLoai = new System.Windows.Forms.ComboBox();
			this.cbx_MaThuoc = new System.Windows.Forms.ComboBox();
			this.lbl_MaLoai = new System.Windows.Forms.Label();
			this.lbl_MaThuoc = new System.Windows.Forms.Label();
			this.dgv_Data = new System.Windows.Forms.DataGridView();
			this.pnl_Tooltip.SuspendLayout();
			this.pnl_Data.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_Title
			// 
			this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.Location = new System.Drawing.Point(12, 17);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(277, 50);
			this.lbl_Title.TabIndex = 10;
			this.lbl_Title.Text = "Quản Lý Thuốc";
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
			this.pnl_Tooltip.Size = new System.Drawing.Size(493, 67);
			this.pnl_Tooltip.TabIndex = 9;
			// 
			// btn_Filter
			// 
			this.btn_Filter.Image = global::Nhom7_PhanMemQuanLyHieuThuoc.Properties.Resources.Filter;
			this.btn_Filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Filter.Location = new System.Drawing.Point(403, 14);
			this.btn_Filter.Name = "btn_Filter";
			this.btn_Filter.Size = new System.Drawing.Size(77, 38);
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
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
			this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
			// 
			// pnl_Data
			// 
			this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Data.Controls.Add(this.lbl_Benh);
			this.pnl_Data.Controls.Add(this.cbx_Benh);
			this.pnl_Data.Controls.Add(this.lbl_SoLuongTon);
			this.pnl_Data.Controls.Add(this.tbx_SoLuongTon);
			this.pnl_Data.Controls.Add(this.tbx_GiaBan);
			this.pnl_Data.Controls.Add(this.lbl_GiaBan);
			this.pnl_Data.Controls.Add(this.lbl_GiaNhap);
			this.pnl_Data.Controls.Add(this.tbx_GiaNhap);
			this.pnl_Data.Controls.Add(this.lbl_ThanhPhan);
			this.pnl_Data.Controls.Add(this.tbx_ThanhPhan);
			this.pnl_Data.Controls.Add(this.lbl_TenThuoc);
			this.pnl_Data.Controls.Add(this.tbx_TenThuoc);
			this.pnl_Data.Controls.Add(this.cbx_MaLoai);
			this.pnl_Data.Controls.Add(this.cbx_MaThuoc);
			this.pnl_Data.Controls.Add(this.lbl_MaLoai);
			this.pnl_Data.Controls.Add(this.lbl_MaThuoc);
			this.pnl_Data.Location = new System.Drawing.Point(12, 85);
			this.pnl_Data.Name = "pnl_Data";
			this.pnl_Data.Size = new System.Drawing.Size(776, 194);
			this.pnl_Data.TabIndex = 8;
			// 
			// lbl_Benh
			// 
			this.lbl_Benh.AutoSize = true;
			this.lbl_Benh.Location = new System.Drawing.Point(446, 37);
			this.lbl_Benh.Name = "lbl_Benh";
			this.lbl_Benh.Size = new System.Drawing.Size(40, 19);
			this.lbl_Benh.TabIndex = 47;
			this.lbl_Benh.Text = "Bệnh";
			// 
			// cbx_Benh
			// 
			this.cbx_Benh.FormattingEnabled = true;
			this.cbx_Benh.Location = new System.Drawing.Point(492, 34);
			this.cbx_Benh.Name = "cbx_Benh";
			this.cbx_Benh.Size = new System.Drawing.Size(250, 27);
			this.cbx_Benh.TabIndex = 46;
			this.cbx_Benh.SelectedIndexChanged += new System.EventHandler(this.cbx_Benh_SelectedIndexChanged);
			// 
			// lbl_SoLuongTon
			// 
			this.lbl_SoLuongTon.AutoSize = true;
			this.lbl_SoLuongTon.Location = new System.Drawing.Point(388, 134);
			this.lbl_SoLuongTon.Name = "lbl_SoLuongTon";
			this.lbl_SoLuongTon.Size = new System.Drawing.Size(98, 19);
			this.lbl_SoLuongTon.TabIndex = 45;
			this.lbl_SoLuongTon.Text = "Số Lượng Tồn";
			// 
			// tbx_SoLuongTon
			// 
			this.tbx_SoLuongTon.Location = new System.Drawing.Point(492, 131);
			this.tbx_SoLuongTon.Name = "tbx_SoLuongTon";
			this.tbx_SoLuongTon.Size = new System.Drawing.Size(250, 26);
			this.tbx_SoLuongTon.TabIndex = 44;
			this.tbx_SoLuongTon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ftn_KeyPress);
			// 
			// tbx_GiaBan
			// 
			this.tbx_GiaBan.Location = new System.Drawing.Point(492, 67);
			this.tbx_GiaBan.Name = "tbx_GiaBan";
			this.tbx_GiaBan.Size = new System.Drawing.Size(250, 26);
			this.tbx_GiaBan.TabIndex = 43;
			this.tbx_GiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ftn_KeyPress);
			// 
			// lbl_GiaBan
			// 
			this.lbl_GiaBan.AutoSize = true;
			this.lbl_GiaBan.Location = new System.Drawing.Point(428, 70);
			this.lbl_GiaBan.Name = "lbl_GiaBan";
			this.lbl_GiaBan.Size = new System.Drawing.Size(58, 19);
			this.lbl_GiaBan.TabIndex = 42;
			this.lbl_GiaBan.Text = "Giá Bán";
			// 
			// lbl_GiaNhap
			// 
			this.lbl_GiaNhap.AutoSize = true;
			this.lbl_GiaNhap.Location = new System.Drawing.Point(418, 102);
			this.lbl_GiaNhap.Name = "lbl_GiaNhap";
			this.lbl_GiaNhap.Size = new System.Drawing.Size(68, 19);
			this.lbl_GiaNhap.TabIndex = 41;
			this.lbl_GiaNhap.Text = "Giá Nhập";
			// 
			// tbx_GiaNhap
			// 
			this.tbx_GiaNhap.Location = new System.Drawing.Point(492, 99);
			this.tbx_GiaNhap.Name = "tbx_GiaNhap";
			this.tbx_GiaNhap.Size = new System.Drawing.Size(250, 26);
			this.tbx_GiaNhap.TabIndex = 40;
			this.tbx_GiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ftn_KeyPress);
			// 
			// lbl_ThanhPhan
			// 
			this.lbl_ThanhPhan.AutoSize = true;
			this.lbl_ThanhPhan.Location = new System.Drawing.Point(33, 135);
			this.lbl_ThanhPhan.Name = "lbl_ThanhPhan";
			this.lbl_ThanhPhan.Size = new System.Drawing.Size(80, 19);
			this.lbl_ThanhPhan.TabIndex = 39;
			this.lbl_ThanhPhan.Text = "Thành Phần";
			// 
			// tbx_ThanhPhan
			// 
			this.tbx_ThanhPhan.Location = new System.Drawing.Point(119, 132);
			this.tbx_ThanhPhan.Name = "tbx_ThanhPhan";
			this.tbx_ThanhPhan.Size = new System.Drawing.Size(250, 26);
			this.tbx_ThanhPhan.TabIndex = 38;
			// 
			// lbl_TenThuoc
			// 
			this.lbl_TenThuoc.AutoSize = true;
			this.lbl_TenThuoc.Location = new System.Drawing.Point(39, 103);
			this.lbl_TenThuoc.Name = "lbl_TenThuoc";
			this.lbl_TenThuoc.Size = new System.Drawing.Size(74, 19);
			this.lbl_TenThuoc.TabIndex = 37;
			this.lbl_TenThuoc.Text = "Tên Thuốc";
			// 
			// tbx_TenThuoc
			// 
			this.tbx_TenThuoc.Location = new System.Drawing.Point(119, 100);
			this.tbx_TenThuoc.Name = "tbx_TenThuoc";
			this.tbx_TenThuoc.Size = new System.Drawing.Size(250, 26);
			this.tbx_TenThuoc.TabIndex = 36;
			// 
			// cbx_MaLoai
			// 
			this.cbx_MaLoai.FormattingEnabled = true;
			this.cbx_MaLoai.Location = new System.Drawing.Point(119, 67);
			this.cbx_MaLoai.Name = "cbx_MaLoai";
			this.cbx_MaLoai.Size = new System.Drawing.Size(250, 27);
			this.cbx_MaLoai.TabIndex = 35;
			// 
			// cbx_MaThuoc
			// 
			this.cbx_MaThuoc.FormattingEnabled = true;
			this.cbx_MaThuoc.Location = new System.Drawing.Point(119, 34);
			this.cbx_MaThuoc.Name = "cbx_MaThuoc";
			this.cbx_MaThuoc.Size = new System.Drawing.Size(250, 27);
			this.cbx_MaThuoc.TabIndex = 34;
			// 
			// lbl_MaLoai
			// 
			this.lbl_MaLoai.AutoSize = true;
			this.lbl_MaLoai.Location = new System.Drawing.Point(77, 70);
			this.lbl_MaLoai.Name = "lbl_MaLoai";
			this.lbl_MaLoai.Size = new System.Drawing.Size(36, 19);
			this.lbl_MaLoai.TabIndex = 33;
			this.lbl_MaLoai.Text = "Loại";
			// 
			// lbl_MaThuoc
			// 
			this.lbl_MaThuoc.AutoSize = true;
			this.lbl_MaThuoc.Location = new System.Drawing.Point(41, 37);
			this.lbl_MaThuoc.Name = "lbl_MaThuoc";
			this.lbl_MaThuoc.Size = new System.Drawing.Size(72, 19);
			this.lbl_MaThuoc.TabIndex = 32;
			this.lbl_MaThuoc.Text = "Mã Thuốc";
			// 
			// dgv_Data
			// 
			this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Data.Location = new System.Drawing.Point(12, 293);
			this.dgv_Data.Name = "dgv_Data";
			this.dgv_Data.Size = new System.Drawing.Size(776, 445);
			this.dgv_Data.TabIndex = 7;
			// 
			// frm_Medicine
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 750);
			this.Controls.Add(this.lbl_Title);
			this.Controls.Add(this.pnl_Tooltip);
			this.Controls.Add(this.pnl_Data);
			this.Controls.Add(this.dgv_Data);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_Medicine";
			this.Text = "frm_Medicine";
			this.Load += new System.EventHandler(this.frm_Medicine_Load);
			this.pnl_Tooltip.ResumeLayout(false);
			this.pnl_Data.ResumeLayout(false);
			this.pnl_Data.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.Panel pnl_Tooltip;
		private System.Windows.Forms.Button btn_Filter;
		private System.Windows.Forms.Button btn_Search;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_Update;
		private System.Windows.Forms.Button btn_Insert;
		private System.Windows.Forms.Panel pnl_Data;
		private System.Windows.Forms.DataGridView dgv_Data;
		private System.Windows.Forms.Label lbl_Benh;
		private System.Windows.Forms.ComboBox cbx_Benh;
		private System.Windows.Forms.Label lbl_SoLuongTon;
		private System.Windows.Forms.TextBox tbx_SoLuongTon;
		private System.Windows.Forms.TextBox tbx_GiaBan;
		private System.Windows.Forms.Label lbl_GiaBan;
		private System.Windows.Forms.Label lbl_GiaNhap;
		private System.Windows.Forms.TextBox tbx_GiaNhap;
		private System.Windows.Forms.Label lbl_ThanhPhan;
		private System.Windows.Forms.TextBox tbx_ThanhPhan;
		private System.Windows.Forms.Label lbl_TenThuoc;
		private System.Windows.Forms.TextBox tbx_TenThuoc;
		private System.Windows.Forms.ComboBox cbx_MaLoai;
		private System.Windows.Forms.ComboBox cbx_MaThuoc;
		private System.Windows.Forms.Label lbl_MaLoai;
		private System.Windows.Forms.Label lbl_MaThuoc;
	}
}