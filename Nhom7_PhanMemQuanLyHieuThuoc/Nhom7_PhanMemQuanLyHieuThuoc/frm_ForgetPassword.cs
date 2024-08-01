using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nhom7_PhanMemQuanLyHieuThuoc
{
	public partial class frm_ForgetPassword : Form
	{
		public string connection_string { get; set; }

		public frm_ForgetPassword(string connection_string)
		{
			InitializeComponent();
			this.connection_string = connection_string;
		}

		private void frm_ForgetPassword_Load(object sender, EventArgs e)
		{
			lbl_UsernameAnnotation.Text = "";
			lbl_EmailAnnotation.Text = "";
		}


		private void btn_GetPassword_Click(object sender, EventArgs e)
		{
			lbl_UsernameAnnotation.Text = "";
			lbl_EmailAnnotation.Text = "";

			bool error = false;
			if (string.IsNullOrEmpty(tbx_Username.Text))
			{
				error = true;
				lbl_UsernameAnnotation.Text = "Thiếu Tên Đăng Nhập";
			}
			if (string.IsNullOrEmpty(tbx_Email.Text))
			{
				error = true;
				lbl_EmailAnnotation.Text = "Thiếu Email";
			}
			if (error) return;

			SqlConnection sql_connection = new SqlConnection(connection_string);
			SqlDataAdapter sql_dataadapter = new SqlDataAdapter("select * from tbl_CHITIETTAIKHOAN where TenDangNhap = '" + tbx_Username.Text + "'", sql_connection);
			DataTable datatable = new DataTable();
			sql_dataadapter.Fill(datatable);

			if (datatable.Rows.Count == 0)
			{
				error = true;
				lbl_UsernameAnnotation.Text = "Tên Đăng Nhập Không Tồn Tại";
			}
			else
			{
				if (datatable.Rows[0][7].ToString() != tbx_Email.Text)
				{
					error = true;
					lbl_EmailAnnotation.Text = "Sai Email";
				}
			}
			if (error == true) return;

			sql_dataadapter = new SqlDataAdapter("select * from tbl_TAIKHOAN where TenDangNhap = '" + tbx_Username.Text + "'", sql_connection);
			datatable = new DataTable();
			sql_dataadapter.Fill(datatable);

			//MessageBox.Show("Mật Khẩu của Bạn là: " + datatable.Rows[0][1].ToString(), "Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ftn_SendEmail(datatable.Rows[0][1].ToString());
			Close();
		}

		private void ftn_SendEmail(string password)
		{
			string smtp_server = "smtp-relay.brevo.com";
			int smtp_port = 587;
			string smtp_username = "helloagaindumbel@gmail.com";
			string smtp_password = "T8h9Rdc1QjbFZCEU";
			string sent_email = "helloagaindumbel@gmail.com";
			string receive_email = "dangerousburnner@gmail.com";

			MailMessage mail_message = new MailMessage(sent_email, receive_email);
			mail_message.Subject = "Hiệu Thuốc Kha Khá";
			mail_message.Body = "Mật khẩu của bạn là: " + password;

			SmtpClient smtp_client = new SmtpClient(smtp_server, smtp_port);
			smtp_client.Credentials = new NetworkCredential(smtp_username, smtp_password);
			smtp_client.EnableSsl = true;

			try
			{
				smtp_client.Send(mail_message);
				MessageBox.Show("Kiểm Tra Email Để Nhận Lại Mật Khẩu", "Check Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			catch
			{
				MessageBox.Show("Giử Email Không Thành Công", "Lỗi Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}
	}
}
