namespace Nhom7_PhanMemQuanLyHieuThuoc
{
	partial class frm_AskPassword
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
			this.lbl_PasswordAnnotation = new System.Windows.Forms.Label();
			this.tbx_Password = new System.Windows.Forms.TextBox();
			this.lbl_Password = new System.Windows.Forms.Label();
			this.btn_HidePassword = new System.Windows.Forms.Button();
			this.btn_ShowPassword = new System.Windows.Forms.Button();
			this.btn_Proceed = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_PasswordAnnotation
			// 
			this.lbl_PasswordAnnotation.ForeColor = System.Drawing.Color.Red;
			this.lbl_PasswordAnnotation.Location = new System.Drawing.Point(12, 71);
			this.lbl_PasswordAnnotation.Name = "lbl_PasswordAnnotation";
			this.lbl_PasswordAnnotation.Size = new System.Drawing.Size(256, 26);
			this.lbl_PasswordAnnotation.TabIndex = 19;
			this.lbl_PasswordAnnotation.Text = "Báo Lỗi";
			this.lbl_PasswordAnnotation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbx_Password
			// 
			this.tbx_Password.Location = new System.Drawing.Point(12, 42);
			this.tbx_Password.Name = "tbx_Password";
			this.tbx_Password.PasswordChar = '*';
			this.tbx_Password.Size = new System.Drawing.Size(256, 26);
			this.tbx_Password.TabIndex = 0;
			// 
			// lbl_Password
			// 
			this.lbl_Password.AutoSize = true;
			this.lbl_Password.Location = new System.Drawing.Point(12, 20);
			this.lbl_Password.Name = "lbl_Password";
			this.lbl_Password.Size = new System.Drawing.Size(71, 19);
			this.lbl_Password.TabIndex = 18;
			this.lbl_Password.Text = "Mật Khẩu";
			// 
			// btn_HidePassword
			// 
			this.btn_HidePassword.Image = global::Nhom7_PhanMemQuanLyHieuThuoc.Properties.Resources.Eye_Cross;
			this.btn_HidePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_HidePassword.Location = new System.Drawing.Point(274, 40);
			this.btn_HidePassword.Name = "btn_HidePassword";
			this.btn_HidePassword.Size = new System.Drawing.Size(33, 29);
			this.btn_HidePassword.TabIndex = 16;
			this.btn_HidePassword.UseVisualStyleBackColor = true;
			this.btn_HidePassword.Click += new System.EventHandler(this.btn_HidePassword_Click);
			// 
			// btn_ShowPassword
			// 
			this.btn_ShowPassword.Image = global::Nhom7_PhanMemQuanLyHieuThuoc.Properties.Resources.Eye;
			this.btn_ShowPassword.Location = new System.Drawing.Point(274, 40);
			this.btn_ShowPassword.Name = "btn_ShowPassword";
			this.btn_ShowPassword.Size = new System.Drawing.Size(33, 29);
			this.btn_ShowPassword.TabIndex = 17;
			this.btn_ShowPassword.UseVisualStyleBackColor = true;
			this.btn_ShowPassword.Click += new System.EventHandler(this.btn_ShowPassword_Click);
			// 
			// btn_Proceed
			// 
			this.btn_Proceed.Location = new System.Drawing.Point(12, 100);
			this.btn_Proceed.Name = "btn_Proceed";
			this.btn_Proceed.Size = new System.Drawing.Size(295, 32);
			this.btn_Proceed.TabIndex = 1;
			this.btn_Proceed.Text = "Xác Nhận";
			this.btn_Proceed.UseVisualStyleBackColor = true;
			this.btn_Proceed.Click += new System.EventHandler(this.btn_Proceed_Click);
			// 
			// frm_AskPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(320, 156);
			this.Controls.Add(this.btn_Proceed);
			this.Controls.Add(this.lbl_PasswordAnnotation);
			this.Controls.Add(this.btn_HidePassword);
			this.Controls.Add(this.btn_ShowPassword);
			this.Controls.Add(this.tbx_Password);
			this.Controls.Add(this.lbl_Password);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_AskPassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nhập Mật Khẩu Để Tiếp Tục";
			this.Load += new System.EventHandler(this.frm_AskPassword_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_PasswordAnnotation;
		private System.Windows.Forms.Button btn_HidePassword;
		private System.Windows.Forms.Button btn_ShowPassword;
		private System.Windows.Forms.TextBox tbx_Password;
		private System.Windows.Forms.Label lbl_Password;
		private System.Windows.Forms.Button btn_Proceed;
	}
}