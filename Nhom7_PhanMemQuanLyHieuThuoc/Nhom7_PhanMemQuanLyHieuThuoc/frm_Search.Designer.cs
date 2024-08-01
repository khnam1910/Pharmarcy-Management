
namespace Nhom7_PhanMemQuanLyHieuThuoc
{
	partial class frm_Search
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
			this.label2 = new System.Windows.Forms.Label();
			this.tbx_HoTen = new System.Windows.Forms.TextBox();
			this.btn_search = new System.Windows.Forms.Button();
			this.lbl_SignIn = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(33, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nhập Họ Tên";
			// 
			// tbx_HoTen
			// 
			this.tbx_HoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbx_HoTen.Location = new System.Drawing.Point(132, 64);
			this.tbx_HoTen.Name = "tbx_HoTen";
			this.tbx_HoTen.Size = new System.Drawing.Size(213, 26);
			this.tbx_HoTen.TabIndex = 2;
			// 
			// btn_search
			// 
			this.btn_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_search.Location = new System.Drawing.Point(114, 108);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(140, 32);
			this.btn_search.TabIndex = 3;
			this.btn_search.Text = "Tìm Thông Tin";
			this.btn_search.UseVisualStyleBackColor = true;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// lbl_SignIn
			// 
			this.lbl_SignIn.AutoSize = true;
			this.lbl_SignIn.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SignIn.Location = new System.Drawing.Point(39, 9);
			this.lbl_SignIn.Name = "lbl_SignIn";
			this.lbl_SignIn.Size = new System.Drawing.Size(306, 36);
			this.lbl_SignIn.TabIndex = 32;
			this.lbl_SignIn.Text = "Tìm Kiếm Thông Tin";
			// 
			// frm_TimKiem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(375, 152);
			this.Controls.Add(this.lbl_SignIn);
			this.Controls.Add(this.btn_search);
			this.Controls.Add(this.tbx_HoTen);
			this.Controls.Add(this.label2);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_TimKiem";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tìm Kiếm Thông Tin";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbx_HoTen;
		private System.Windows.Forms.Button btn_search;
		private System.Windows.Forms.Label lbl_SignIn;
	}
}