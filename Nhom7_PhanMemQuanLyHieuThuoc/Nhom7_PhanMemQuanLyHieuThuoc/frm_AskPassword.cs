using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom7_PhanMemQuanLyHieuThuoc
{
	public partial class frm_AskPassword : Form
	{
		string username { get; set; }
		public string connection_string { get; set; }

		public event EventHandler<string> result;

		public frm_AskPassword(string username, string connection_string)
		{
			InitializeComponent();
			this.username = username;
			this.connection_string = connection_string;
		}

		private void frm_AskPassword_Load(object sender, EventArgs e)
		{
			lbl_PasswordAnnotation.Text = "";

			if (username == "database")
			{
				Text = "Kết Nối Database";
				lbl_Password.Text = "Mã Kết Nối";
			}
		}

		private void btn_Proceed_Click(object sender, EventArgs e)
		{
			string value = "false";
			bool error = false;

			if (string.IsNullOrEmpty(tbx_Password.Text))
			{
				error = true;
				lbl_PasswordAnnotation.Text = "Nhập Mật Khẩu";
			}
			else lbl_PasswordAnnotation.Text = "";

			if (username == "database")
			{
				if (tbx_Password.Text != "Key-Database")
				{
					error = true;
					lbl_PasswordAnnotation.Text = "Sai Mã Kết Nối Database";
				}
			}
			else if (username == "debug")
			{
				if (tbx_Password.Text != "Key-Debug")
				{
					error = true;
					lbl_PasswordAnnotation.Text = "Sai Mã Kết Nối Debug";
				}
			}
			else
			{
				SqlConnection sql_connection = new SqlConnection(connection_string);
				SqlDataAdapter sql_dataadapter = new SqlDataAdapter("select * from tbl_TAIKHOAN where TenDangNhap = '" + username + "' and MatKhau = '" + tbx_Password.Text + "'", sql_connection);
				DataTable datatable = new DataTable();
				sql_dataadapter.Fill(datatable);

				if (datatable.Rows.Count == 0)
				{
					error = true;
					lbl_PasswordAnnotation.Text = "Sai Mật Khẩu";
				}
			}

			if (!error) value = "true";
			else return;

			result?.Invoke(this, value);
			Close();
		}

		private void btn_HidePassword_Click(object sender, EventArgs e)
		{
			btn_ShowPassword.BringToFront();
			tbx_Password.PasswordChar = '\0';
		}

		private void btn_ShowPassword_Click(object sender, EventArgs e)
		{
			btn_HidePassword.BringToFront();
			tbx_Password.PasswordChar = '*';
		}

	}
}
