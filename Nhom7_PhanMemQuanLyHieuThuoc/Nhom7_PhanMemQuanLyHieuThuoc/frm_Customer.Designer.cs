namespace Nhom7_PhanMemQuanLyHieuThuoc
{
	partial class frm_Customer
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
            this.pnl_Tooltip = new System.Windows.Forms.Panel();
            this.btn_LocTT = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.cbb_GT = new System.Windows.Forms.ComboBox();
            this.cbb_QuanHuyen = new System.Windows.Forms.ComboBox();
            this.tbx_SDT = new System.Windows.Forms.TextBox();
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_MaKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_TenKH = new System.Windows.Forms.Label();
            this.tbx_DiaChi = new System.Windows.Forms.TextBox();
            this.lbl_TenLoai = new System.Windows.Forms.Label();
            this.tbx_TenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.col_MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_QuanHuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_Tooltip.SuspendLayout();
            this.pnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Tooltip
            // 
            this.pnl_Tooltip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Tooltip.Controls.Add(this.btn_LocTT);
            this.pnl_Tooltip.Controls.Add(this.btn_Reset);
            this.pnl_Tooltip.Controls.Add(this.btn_Search);
            this.pnl_Tooltip.Controls.Add(this.btn_Delete);
            this.pnl_Tooltip.Controls.Add(this.btn_Update);
            this.pnl_Tooltip.Controls.Add(this.btn_Insert);
            this.pnl_Tooltip.Location = new System.Drawing.Point(12, 12);
            this.pnl_Tooltip.Name = "pnl_Tooltip";
            this.pnl_Tooltip.Size = new System.Drawing.Size(556, 67);
            this.pnl_Tooltip.TabIndex = 1;
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
            this.btn_LocTT.Click += new System.EventHandler(this.btn_LocTT_Click);
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
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Image = global::Nhom7_PhanMemQuanLyHieuThuoc.Properties.Resources.Update;
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(101, 14);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(105, 38);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = " Cập Nhật";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(12, 95);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(776, 41);
            this.lbl_Title.TabIndex = 5;
            this.lbl_Title.Text = "Quản Lý Khách Hàng";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Data
            // 
            this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Data.Controls.Add(this.cbb_GT);
            this.pnl_Data.Controls.Add(this.cbb_QuanHuyen);
            this.pnl_Data.Controls.Add(this.tbx_SDT);
            this.pnl_Data.Controls.Add(this.tbx_Email);
            this.pnl_Data.Controls.Add(this.label6);
            this.pnl_Data.Controls.Add(this.tbx_MaKH);
            this.pnl_Data.Controls.Add(this.label5);
            this.pnl_Data.Controls.Add(this.label2);
            this.pnl_Data.Controls.Add(this.label4);
            this.pnl_Data.Controls.Add(this.lbl_TenKH);
            this.pnl_Data.Controls.Add(this.tbx_DiaChi);
            this.pnl_Data.Controls.Add(this.lbl_TenLoai);
            this.pnl_Data.Controls.Add(this.tbx_TenKH);
            this.pnl_Data.Controls.Add(this.label3);
            this.pnl_Data.Location = new System.Drawing.Point(12, 153);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(776, 146);
            this.pnl_Data.TabIndex = 6;
            // 
            // cbb_GT
            // 
            this.cbb_GT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_GT.FormattingEnabled = true;
            this.cbb_GT.Location = new System.Drawing.Point(134, 109);
            this.cbb_GT.Name = "cbb_GT";
            this.cbb_GT.Size = new System.Drawing.Size(254, 27);
            this.cbb_GT.TabIndex = 4;
            // 
            // cbb_QuanHuyen
            // 
            this.cbb_QuanHuyen.FormattingEnabled = true;
            this.cbb_QuanHuyen.Location = new System.Drawing.Point(502, 77);
            this.cbb_QuanHuyen.Name = "cbb_QuanHuyen";
            this.cbb_QuanHuyen.Size = new System.Drawing.Size(254, 27);
            this.cbb_QuanHuyen.TabIndex = 4;
            // 
            // tbx_SDT
            // 
            this.tbx_SDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_SDT.Location = new System.Drawing.Point(134, 77);
            this.tbx_SDT.Name = "tbx_SDT";
            this.tbx_SDT.Size = new System.Drawing.Size(254, 26);
            this.tbx_SDT.TabIndex = 3;
            // 
            // tbx_Email
            // 
            this.tbx_Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Email.Location = new System.Drawing.Point(502, 13);
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.Size = new System.Drawing.Size(254, 26);
            this.tbx_Email.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(403, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Quận / Huyện";
            // 
            // tbx_MaKH
            // 
            this.tbx_MaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_MaKH.Location = new System.Drawing.Point(134, 13);
            this.tbx_MaKH.Name = "tbx_MaKH";
            this.tbx_MaKH.ReadOnly = true;
            this.tbx_MaKH.Size = new System.Drawing.Size(254, 26);
            this.tbx_MaKH.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(441, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // lbl_TenKH
            // 
            this.lbl_TenKH.AutoSize = true;
            this.lbl_TenKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenKH.Location = new System.Drawing.Point(16, 48);
            this.lbl_TenKH.Name = "lbl_TenKH";
            this.lbl_TenKH.Size = new System.Drawing.Size(112, 19);
            this.lbl_TenKH.TabIndex = 2;
            this.lbl_TenKH.Text = "Tên Khách Hàng";
            // 
            // tbx_DiaChi
            // 
            this.tbx_DiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_DiaChi.Location = new System.Drawing.Point(502, 45);
            this.tbx_DiaChi.Name = "tbx_DiaChi";
            this.tbx_DiaChi.Size = new System.Drawing.Size(254, 26);
            this.tbx_DiaChi.TabIndex = 1;
            // 
            // lbl_TenLoai
            // 
            this.lbl_TenLoai.AutoSize = true;
            this.lbl_TenLoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenLoai.Location = new System.Drawing.Point(18, 16);
            this.lbl_TenLoai.Name = "lbl_TenLoai";
            this.lbl_TenLoai.Size = new System.Drawing.Size(110, 19);
            this.lbl_TenLoai.TabIndex = 2;
            this.lbl_TenLoai.Text = "Mã Khách Hàng";
            // 
            // tbx_TenKH
            // 
            this.tbx_TenKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_TenKH.Location = new System.Drawing.Point(134, 45);
            this.tbx_TenKH.Name = "tbx_TenKH";
            this.tbx_TenKH.Size = new System.Drawing.Size(254, 26);
            this.tbx_TenKH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới Tính";
            // 
            // dgv_Data
            // 
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaKH,
            this.Col_TenKH,
            this.Col_SDT,
            this.Col_GT,
            this.Col_Email,
            this.Col_DiaChi,
            this.Col_QuanHuyen});
            this.dgv_Data.Location = new System.Drawing.Point(12, 305);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.Size = new System.Drawing.Size(776, 433);
            this.dgv_Data.TabIndex = 4;
            this.dgv_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Data_CellClick);
            this.dgv_Data.SelectionChanged += new System.EventHandler(this.dgv_Data_SelectionChanged);
            // 
            // col_MaKH
            // 
            this.col_MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_MaKH.DataPropertyName = "MaKH";
            this.col_MaKH.HeaderText = "Mã Khách Hàng";
            this.col_MaKH.Name = "col_MaKH";
            // 
            // Col_TenKH
            // 
            this.Col_TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_TenKH.DataPropertyName = "TenKH";
            this.Col_TenKH.HeaderText = "Tên Khách Hàng";
            this.Col_TenKH.Name = "Col_TenKH";
            // 
            // Col_SDT
            // 
            this.Col_SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_SDT.DataPropertyName = "SDT";
            this.Col_SDT.HeaderText = "Số điện thoại";
            this.Col_SDT.Name = "Col_SDT";
            // 
            // Col_GT
            // 
            this.Col_GT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_GT.DataPropertyName = "GioiTinh";
            this.Col_GT.HeaderText = "Giới tính";
            this.Col_GT.Name = "Col_GT";
            // 
            // Col_Email
            // 
            this.Col_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_Email.DataPropertyName = "Email";
            this.Col_Email.HeaderText = "Email";
            this.Col_Email.Name = "Col_Email";
            // 
            // Col_DiaChi
            // 
            this.Col_DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_DiaChi.DataPropertyName = "SoNha";
            this.Col_DiaChi.HeaderText = "Địa Chỉ";
            this.Col_DiaChi.Name = "Col_DiaChi";
            // 
            // Col_QuanHuyen
            // 
            this.Col_QuanHuyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_QuanHuyen.DataPropertyName = "QuanHuyenId";
            this.Col_QuanHuyen.HeaderText = "Quận/Huyện";
            this.Col_QuanHuyen.Name = "Col_QuanHuyen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(140)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(574, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 67);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Customer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.dgv_Data);
            this.Controls.Add(this.pnl_Data);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl_Tooltip);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Customer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_KhachHang_Load);
            this.pnl_Tooltip.ResumeLayout(false);
            this.pnl_Data.ResumeLayout(false);
            this.pnl_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnl_Tooltip;
		private System.Windows.Forms.Button btn_Search;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_Update;
		private System.Windows.Forms.Button btn_Insert;
		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.Panel pnl_Data;
		private System.Windows.Forms.ComboBox cbb_QuanHuyen;
		private System.Windows.Forms.TextBox tbx_SDT;
		private System.Windows.Forms.TextBox tbx_Email;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbx_MaKH;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbl_TenKH;
		private System.Windows.Forms.TextBox tbx_DiaChi;
		private System.Windows.Forms.Label lbl_TenLoai;
		private System.Windows.Forms.TextBox tbx_TenKH;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgv_Data;
		private System.Windows.Forms.DataGridViewTextBoxColumn col_MaKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col_TenKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col_SDT;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col_GT;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col_Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col_DiaChi;
		private System.Windows.Forms.DataGridViewTextBoxColumn Col_QuanHuyen;
		private System.Windows.Forms.ComboBox cbb_GT;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_LocTT;
	}
}

