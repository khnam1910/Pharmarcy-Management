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
using System.Runtime.CompilerServices;

namespace Nhom7_PhanMemQuanLyHieuThuoc
{
	public partial class frm_Home : Form
	{
		public string username { get; set; }
		public string role {  get; set; }
		public string connection_string { get; set; }

		public frm_Home(string username, string role, string connection_string)
		{
			InitializeComponent();
			this.username = username;
			this.role = role;
			this.connection_string = connection_string;
		}

		private void frm_Home_Load(object sender, EventArgs e)
		{
			if (role == "debug")
			{
				btn_ShowAccount.Enabled = false;
				btn_HideAccount.Enabled = false;
				return;
			}

			SqlConnection sql_connection = new SqlConnection(connection_string);
			SqlDataAdapter sql_dataadapter = new SqlDataAdapter("select * from tbl_TAIKHOAN where TenDangNhap = '" + username + "'", sql_connection);
			DataSet dataset = new DataSet();
			sql_dataadapter.Fill(dataset, "tbl_TAIKHOAN");

			tbx_TenTaiKhoan.Text = username;
			tbx_MatKhau.Text = dataset.Tables["tbl_TAIKHOAN"].Rows[0][1].ToString();
			tbx_LoaiTaiKhoan.Text = role;

			sql_dataadapter = new SqlDataAdapter("select * from tbl_CHITIETTAIKHOAN where TenDangNhap = '" + username + "'", sql_connection);
			sql_dataadapter.Fill(dataset, "tbl_CHITIETTAIKHOAN");

			tbx_TenNguoiDung.Text = dataset.Tables["tbl_CHITIETTAIKHOAN"].Rows[0][1].ToString();

			string ngaysinh = dataset.Tables["tbl_CHITIETTAIKHOAN"].Rows[0][2].ToString();
			tbx_NgaySinh.Text = ngaysinh.Split(' ')[0];

			tbx_GioiTinh.Text = dataset.Tables["tbl_CHITIETTAIKHOAN"].Rows[0][3].ToString();
			tbx_SoNha.Text = dataset.Tables["tbl_CHITIETTAIKHOAN"].Rows[0][4].ToString();

			sql_dataadapter = new SqlDataAdapter("select * from tbl_QUANHUYEN where QuanHuyenId = " + dataset.Tables["tbl_CHITIETTAIKHOAN"].Rows[0][5].ToString(), sql_connection);
			sql_dataadapter.Fill(dataset, "tbl_QUANHUYEN");
			tbx_QuanHuyen.Text = dataset.Tables["tbl_QUANHUYEN"].Rows[0][1].ToString();

			tbx_SDT.Text = dataset.Tables["tbl_CHITIETTAIKHOAN"].Rows[0][6].ToString();
			tbx_Email.Text = dataset.Tables["tbl_CHITIETTAIKHOAN"].Rows[0][7].ToString();

			if (role == "Dược sĩ")
			{
				sql_dataadapter = new SqlDataAdapter("select * from tbl_DUOCSI where TenDangNhap = '" + username + "'", sql_connection);
				sql_dataadapter.Fill(dataset, "tbl_DUOCSI");

				tbx_MaTaiKhoan.Text = dataset.Tables["tbl_DUOCSI"].Rows[0][1].ToString();

				gbx_Manager.Enabled = false;
			}
			else if (role == "Quản lý")
			{
				sql_dataadapter = new SqlDataAdapter("select * from tbl_QUANLY where TenDangNhap = '" + username + "'", sql_connection);
				sql_dataadapter.Fill(dataset, "tbl_QUANLY");

				tbx_MaTaiKhoan.Text = dataset.Tables["tbl_QUANLY"].Rows[0][1].ToString();
			}

			pnl_Account.Visible = false;
		}

		private void ftn_ShowForm(Form child_form)
		{
			child_form.TopLevel = false;
			pnl_Child.Controls.Clear();
			pnl_Child.Controls.Add(child_form);
			child_form.Dock = DockStyle.Fill;
			child_form.Show();
		}

		private void btn_ShowAccount_Click(object sender, EventArgs e)
		{
			frm_AskPassword form_askpassword = new frm_AskPassword(username, connection_string);
			form_askpassword.Show();
			form_askpassword.result += ftn_AccountInformation;
		}

		private void btn_HideAccount_Click(object sender, EventArgs e)
		{
			pnl_Account.Visible = false;
			pnl_Account.Enabled = false;
			btn_ShowAccount.BringToFront();
		}

		private void ftn_AccountInformation(object sender, string value)
		{
			if (value == "true")
			{
				pnl_Account.Visible = true;
				pnl_Account.Enabled = true;
				btn_HideAccount.BringToFront();
			}
			else
			{
				pnl_Account.Visible = false;
				pnl_Account.Enabled = false;
			}
		}

		private void btn_SignOut_Click(object sender, EventArgs e)
		{
			frm_SignIn form_SignIn = new frm_SignIn();
			form_SignIn.Show();
			Hide();
		}

		private void btn_Medicine_Click(object sender, EventArgs e)
		{
			frm_Medicine form_medicine = new frm_Medicine(connection_string);
			ftn_ShowForm(form_medicine);
		}

		private void btn_Bill_Click(object sender, EventArgs e)
		{
			SqlConnection sql_connection = new SqlConnection(connection_string);
			SqlDataAdapter sql_dataadapter;
			DataSet dataset = new DataSet();
			string id = "DS002";

			if (role == "Dược sĩ")
			{
				sql_dataadapter = new SqlDataAdapter("select * from tbl_DUOCSI where TenDangNhap = '" + username + "'", sql_connection);
				sql_dataadapter.Fill(dataset, "tbl_DUOCSI");

				id = dataset.Tables["tbl_DUOCSI"].Rows[0][1].ToString();

				gbx_Manager.Enabled = false;
			}
			else if (role == "Quản lý")
			{
				sql_dataadapter = new SqlDataAdapter("select * from tbl_QUANLY where TenDangNhap = '" + username + "'", sql_connection);
				sql_dataadapter.Fill(dataset, "tbl_QUANLY");

				id = dataset.Tables["tbl_QUANLY"].Rows[0][1].ToString();
			}

			frm_Bill form_bill = new frm_Bill(id, connection_string);
			ftn_ShowForm(form_bill);
		}

		private void btn_Order_Click(object sender, EventArgs e)
		{
			frm_Order form_order = new frm_Order(username, connection_string);
			ftn_ShowForm(form_order);
		}

		private void btn_Customer_Click(object sender, EventArgs e)
		{
			frm_Customer form_customer = new frm_Customer(connection_string);
			ftn_ShowForm(form_customer);
		}

		private void btn_Report_Click(object sender, EventArgs e)
		{
			frm_Report form_report = new frm_Report(connection_string);
			ftn_ShowForm(form_report);
		}

		private void btn_Doctor_Click(object sender, EventArgs e)
		{
			frm_Account form_account = new frm_Account(connection_string);
			ftn_ShowForm(form_account);
		}

		private void btn_Suppliers_Click(object sender, EventArgs e)
		{
			frm_Supplier form_supplier = new frm_Supplier(connection_string);
			ftn_ShowForm(form_supplier);
		}

		private void btn_SignUp_Click(object sender, EventArgs e)
		{
			frm_SignUp form_SignUp = new frm_SignUp(connection_string);
			ftn_ShowForm(form_SignUp);
		}

		private void btn_Account_Click(object sender, EventArgs e)
		{
			frm_Account form_account = new frm_Account(connection_string);
			ftn_ShowForm(form_account);
		}
	}
}
