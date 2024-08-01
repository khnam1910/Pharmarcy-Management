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
	public partial class frm_SignIn : Form
	{
		public frm_SignIn()
		{
			InitializeComponent();
		}

		private void frm_SignIn_Load(object sender, EventArgs e)
		{
			tbx_Password.PasswordChar = '*';
			lbl_DatabaseAnnotation.Text = "";
			lbl_UsernameAnnotation.Text = "";
			lbl_PasswordAnnotation.Text = "";
			lbl_ServerAnnotation.Text = "";
			tbx_ConnectionStatus.ReadOnly = true;
			tbx_Database.Text = "dtb_QuanLyHieuThuoc";
			tbx_Server.Text = "MSI";
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

		private void btn_AccessDatabase_Click(object sender, EventArgs e)
		{
			frm_AskPassword form_askpassword = new frm_AskPassword("database", "");
			form_askpassword.Show();
			form_askpassword.result += ftn_ShowDatabase;
		}

		private void ftn_ShowDatabase(object sender, string value)
		{
			ptb_Image.Visible = false;
		}

		private void btn_SignIn_Click(object sender, EventArgs e)
		{
			lbl_DatabaseAnnotation.Text = "";
			lbl_UsernameAnnotation.Text = "";
			lbl_PasswordAnnotation.Text = "";
			lbl_ServerAnnotation.Text = "";

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
			if (error == true) return;

			if (string.IsNullOrEmpty(tbx_Database.Text) || string.IsNullOrEmpty(tbx_Server.Text))
			{
				ptb_Image.Visible = false;
				MessageBox.Show("Mời bạn nhập thông tin của server và database!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string connection_string = "Data Source = " + tbx_Server.Text + "; Initial Catalog = " + tbx_Database.Text + "; Integrated Security = True";
			try
			{
				SqlConnection test_connection = new SqlConnection(connection_string);
				test_connection.Open();
			}
			catch
			{
				MessageBox.Show("Không thể kết nối database, hãy kiểm tra lại thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

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

			frm_Home form_Home = new frm_Home(tbx_Username.Text, datatable.Rows[0][2].ToString(), connection_string);
			form_Home.Show();
			Hide();
		}

		private void btn_CheckConnection_Click(object sender, EventArgs e)
		{
			lbl_DatabaseAnnotation.Text = "";
			lbl_UsernameAnnotation.Text = "";
			lbl_PasswordAnnotation.Text = "";
			lbl_ServerAnnotation.Text = "";

			bool error = false;
			if (string.IsNullOrEmpty(tbx_Server.Text))
			{
				error = true;
				lbl_ServerAnnotation.Text = "Không để trỗng";
			}
			if (string.IsNullOrEmpty(tbx_Database.Text))
			{
				error = true;
				lbl_DatabaseAnnotation.Text = "Không để trỗng";
			}
			if (error == true) return;

			string connection_string = "Data Source = " + tbx_Server.Text + "; Initial Catalog = " + tbx_Database.Text + "; Integrated Security = True";
			try
			{
				SqlConnection test_connection = new SqlConnection(connection_string);
				test_connection.Open();
			}
			catch
			{
				tbx_ConnectionStatus.Text = "Không Thể Kết Nối";
				return;
			}

			tbx_ConnectionStatus.Text = "Có Thể Kết Nối";
		}

		private void btn_SignInWithoutAccount_Click(object sender, EventArgs e)
		{
			frm_AskPassword form_askpassword = new frm_AskPassword("debug", "");
			form_askpassword.Show();
			form_askpassword.result += ftn_SignINWithoutAccount;
		}

		private void ftn_SignINWithoutAccount(object sender, string value)
		{
			bool error = false;
			if (string.IsNullOrEmpty(tbx_Server.Text))
			{
				error = true;
				lbl_ServerAnnotation.Text = "Không để trỗng";
			}
			if (string.IsNullOrEmpty(tbx_Database.Text))
			{
				error = true;
				lbl_DatabaseAnnotation.Text = "Không để trỗng";
			}
			if (error == true) return;

			string connection_string = "Data Source = " + tbx_Server.Text + "; Initial Catalog = " + tbx_Database.Text + "; Integrated Security = True";
			try
			{
				SqlConnection test_connection = new SqlConnection(connection_string);
				test_connection.Open();
			}
			catch
			{
				MessageBox.Show("Không thể kết nối, hãy kiểm tra lại thông tin server và database!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				ptb_Image.Visible = false;
				return;
			}

			frm_Home form_Home = new frm_Home("debug", "debug", connection_string);
			form_Home.Show();
			Hide();
		}

		private void btn_ChangePassword_Click(object sender, EventArgs e)
		{
			string connection_string = "Data Source = " + tbx_Server.Text + "; Initial Catalog = " + tbx_Database.Text + "; Integrated Security = True";
			frm_ChangePassword form_changepassword = new frm_ChangePassword(connection_string);
			form_changepassword.Show();
		}

		private void btn_ForgetPassword_Click(object sender, EventArgs e)
		{
			string connection_string = "Data Source = " + tbx_Server.Text + "; Initial Catalog = " + tbx_Database.Text + "; Integrated Security = True";
			frm_ForgetPassword form_forgetpassword = new frm_ForgetPassword(connection_string);
			form_forgetpassword.Show();
		}
	}
}
