using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nhom7_PhanMemQuanLyHieuThuoc
{
	public partial class frm_ChangePassword : Form
	{
		public string connection_string { get; set; }

		public frm_ChangePassword(string connection_string)
		{
			InitializeComponent();
			this.connection_string = connection_string;
		}

		private void frm_ChangePassword_Load(object sender, EventArgs e)
		{
			lbl_UsernameAnnotation.Text = "";
			lbl_PasswordAnnotation.Text = "";
			tbx_Password.PasswordChar = '*';
			tbx_New.PasswordChar = '*';
			lbl_NewAnnotation.Text = "";
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

		private void btn_ChangePassword_Click(object sender, EventArgs e)
		{
			lbl_UsernameAnnotation.Text = "";
			lbl_PasswordAnnotation.Text = "";

			bool error = false;
			if (string.IsNullOrEmpty(tbx_Username.Text))
			{
				error = true;
				lbl_UsernameAnnotation.Text = "Không Để Trỗng";
			}
			if (string.IsNullOrEmpty(tbx_Password.Text))
			{
				error = true;
				lbl_PasswordAnnotation.Text = "Không Để Trỗng";
			}
			if (string.IsNullOrEmpty(tbx_New.Text))
			{
				error = true;
				lbl_NewAnnotation.Text = "Không Để Trỗng";
			}
			if (error == true) return;

			SqlConnection sql_connection = new SqlConnection(connection_string);
			SqlDataAdapter sql_dataadapter = new SqlDataAdapter("select * from tbl_TAIKHOAN where TenDangNhap = '" + tbx_Username.Text + "'", sql_connection);
			DataTable datatable = new DataTable();
			sql_dataadapter.Fill(datatable);

			if (datatable.Rows.Count == 0)
			{
				error = true;
				lbl_UsernameAnnotation.Text = "Tên Đăng Nhập Không Tồn Tại";
			}
			else
			{
				if (datatable.Rows[0][1].ToString() != tbx_Password.Text)
				{
					error = true;
					lbl_PasswordAnnotation.Text = "Sai Mật Khẩu";
				}
			}
			if (error == true) return;

			sql_connection.Open();
			SqlCommand sql_command = new SqlCommand("update tbl_TAIKHOAN set MatKhau = '" + tbx_New.Text + "' where TenDangNhap = '" + tbx_Username.Text + "'", sql_connection);
			
			try
			{
				sql_command.ExecuteNonQuery();
				MessageBox.Show("Đổi Mật Khẩu Thành Công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Close();
			}
			catch
			{
				MessageBox.Show("Đổi Mật Khẩu Không Thành Công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
		}

		private void btn_HideNew_Click(object sender, EventArgs e)
		{
			btn_ShowNew.BringToFront();
			tbx_New.PasswordChar = '\0';
		}

		private void btn_ShowNew_Click(object sender, EventArgs e)
		{
			btn_HideNew.BringToFront();
			tbx_New.PasswordChar = '*';
		}
	}
}
