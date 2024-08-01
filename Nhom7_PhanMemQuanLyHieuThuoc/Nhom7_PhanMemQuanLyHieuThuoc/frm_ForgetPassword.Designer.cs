namespace Nhom7_PhanMemQuanLyHieuThuoc
{
	partial class frm_ForgetPassword
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
			this.lbl_EmailAnnotation = new System.Windows.Forms.Label();
			this.tbx_Email = new System.Windows.Forms.TextBox();
			this.lbl_Email = new System.Windows.Forms.Label();
			this.lbl_UsernameAnnotation = new System.Windows.Forms.Label();
			this.btn_GetPassword = new System.Windows.Forms.Button();
			this.tbx_Username = new System.Windows.Forms.TextBox();
			this.lbl_Login = new System.Windows.Forms.Label();
			this.lbl_SignIn = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_EmailAnnotation
			// 
			this.lbl_EmailAnnotation.ForeColor = System.Drawing.Color.Red;
			this.lbl_EmailAnnotation.Location = new System.Drawing.Point(31, 200);
			this.lbl_EmailAnnotation.Name = "lbl_EmailAnnotation";
			this.lbl_EmailAnnotation.Size = new System.Drawing.Size(404, 21);
			this.lbl_EmailAnnotation.TabIndex = 54;
			this.lbl_EmailAnnotation.Text = "Báo Lỗi";
			this.lbl_EmailAnnotation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbx_Email
			// 
			this.tbx_Email.Location = new System.Drawing.Point(31, 168);
			this.tbx_Email.Name = "tbx_Email";
			this.tbx_Email.Size = new System.Drawing.Size(404, 26);
			this.tbx_Email.TabIndex = 1;
			// 
			// lbl_Email
			// 
			this.lbl_Email.AutoSize = true;
			this.lbl_Email.Location = new System.Drawing.Point(27, 144);
			this.lbl_Email.Name = "lbl_Email";
			this.lbl_Email.Size = new System.Drawing.Size(42, 19);
			this.lbl_Email.TabIndex = 53;
			this.lbl_Email.Text = "Email";
			// 
			// lbl_UsernameAnnotation
			// 
			this.lbl_UsernameAnnotation.ForeColor = System.Drawing.Color.Red;
			this.lbl_UsernameAnnotation.Location = new System.Drawing.Point(31, 123);
			this.lbl_UsernameAnnotation.Name = "lbl_UsernameAnnotation";
			this.lbl_UsernameAnnotation.Size = new System.Drawing.Size(404, 21);
			this.lbl_UsernameAnnotation.TabIndex = 47;
			this.lbl_UsernameAnnotation.Text = "Báo Lỗi";
			this.lbl_UsernameAnnotation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_GetPassword
			// 
			this.btn_GetPassword.Location = new System.Drawing.Point(31, 239);
			this.btn_GetPassword.Name = "btn_GetPassword";
			this.btn_GetPassword.Size = new System.Drawing.Size(404, 44);
			this.btn_GetPassword.TabIndex = 2;
			this.btn_GetPassword.Text = "Lấy Mật Khẩu";
			this.btn_GetPassword.UseVisualStyleBackColor = true;
			this.btn_GetPassword.Click += new System.EventHandler(this.btn_GetPassword_Click);
			// 
			// tbx_Username
			// 
			this.tbx_Username.Location = new System.Drawing.Point(31, 91);
			this.tbx_Username.Name = "tbx_Username";
			this.tbx_Username.Size = new System.Drawing.Size(404, 26);
			this.tbx_Username.TabIndex = 0;
			// 
			// lbl_Login
			// 
			this.lbl_Login.AutoSize = true;
			this.lbl_Login.Location = new System.Drawing.Point(27, 67);
			this.lbl_Login.Name = "lbl_Login";
			this.lbl_Login.Size = new System.Drawing.Size(100, 19);
			this.lbl_Login.TabIndex = 46;
			this.lbl_Login.Text = "Tên Tài Khoản";
			// 
			// lbl_SignIn
			// 
			this.lbl_SignIn.AutoSize = true;
			this.lbl_SignIn.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SignIn.Location = new System.Drawing.Point(115, 22);
			this.lbl_SignIn.Name = "lbl_SignIn";
			this.lbl_SignIn.Size = new System.Drawing.Size(242, 36);
			this.lbl_SignIn.TabIndex = 45;
			this.lbl_SignIn.Text = "Quên Mật Khẩu";
			// 
			// frm_ForgetPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(463, 320);
			this.Controls.Add(this.lbl_EmailAnnotation);
			this.Controls.Add(this.tbx_Email);
			this.Controls.Add(this.lbl_Email);
			this.Controls.Add(this.lbl_UsernameAnnotation);
			this.Controls.Add(this.btn_GetPassword);
			this.Controls.Add(this.tbx_Username);
			this.Controls.Add(this.lbl_Login);
			this.Controls.Add(this.lbl_SignIn);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_ForgetPassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quên Mật Khẩu";
			this.Load += new System.EventHandler(this.frm_ForgetPassword_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_EmailAnnotation;
		private System.Windows.Forms.TextBox tbx_Email;
		private System.Windows.Forms.Label lbl_Email;
		private System.Windows.Forms.Label lbl_UsernameAnnotation;
		private System.Windows.Forms.Button btn_GetPassword;
		private System.Windows.Forms.TextBox tbx_Username;
		private System.Windows.Forms.Label lbl_Login;
		private System.Windows.Forms.Label lbl_SignIn;
	}
}