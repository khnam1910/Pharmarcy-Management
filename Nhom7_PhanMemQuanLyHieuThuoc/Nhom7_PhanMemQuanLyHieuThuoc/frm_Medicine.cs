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
	public partial class frm_Medicine : Form
	{
		public string connection_string { get; set; }

		SqlConnection sql_connection;
		SqlDataAdapter sql_dataaadapter;
		DataSet dataset = new DataSet();

		public frm_Medicine(string connection_string)
		{
			InitializeComponent();
			this.connection_string = connection_string;
		}

		private void frm_Medicine_Load(object sender, EventArgs e)
		{
			sql_connection = new SqlConnection(connection_string);

			sql_dataaadapter = new SqlDataAdapter("select MaSP from tbl_THUOC", sql_connection);
			sql_dataaadapter.Fill(dataset, "MaThuoc");
			cbx_MaThuoc.DataSource = dataset.Tables["MaThuoc"];
			cbx_MaThuoc.DisplayMember = "MaSP";
			cbx_MaThuoc.ValueMember = "MaSP";

			sql_dataaadapter = new SqlDataAdapter("select MaLoai, TenLoai from tbl_LOAI", sql_connection);
			sql_dataaadapter.Fill(dataset, "Loai");
			cbx_MaLoai.DataSource = dataset.Tables["Loai"];
			cbx_MaLoai.DisplayMember = "TenLoai";
			cbx_MaLoai.ValueMember = "MaLoai";

			sql_dataaadapter = new SqlDataAdapter("select * from tbl_BENH", sql_connection);
			sql_dataaadapter.Fill(dataset, "Benh");
			cbx_Benh.DataSource = dataset.Tables["Benh"];
			cbx_Benh.DisplayMember = "TenBenh";
			cbx_Benh.ValueMember = "MaBenh";
			cbx_Benh.SelectedIndex = -1;

			sql_dataaadapter = new SqlDataAdapter("select tbl_THUOC.MaSP, TenSP, TenLoai, ThanhPhan, GiaNhap, GiaBan, SoLuongTon from tbl_THUOC inner join tbl_CTTHUOC on tbl_THUOC.MaSP = tbl_CTTHUOC.MaSP inner join tbl_LOAI on tbl_LOAI.MaLoai = tbl_THUOC.MaLoai", connection_string);
			sql_dataaadapter.Fill(dataset, "Thuoc");
			dgv_Data.DataSource = dataset.Tables["Thuoc"];
			string[] name = { "Mã Thuốc", "Tên Sản Phẩm", "Loại Thuốc", "Thành Phần", "Giá Nhập", "Giá Bán", "Số Lượng" };
			for (int i = 0; i < dgv_Data.Columns.Count; i = i + 1)
			{
				dgv_Data.Columns[i].HeaderText = name[i];
				dgv_Data.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				if (i == dgv_Data.Columns.Count - 1) dgv_Data.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}
			dgv_Data.AllowUserToAddRows = false;
			dgv_Data.ReadOnly = true;
			DataColumn[] data_column = new DataColumn[1];
			data_column[0] = dataset.Tables["Thuoc"].Columns[0];
			dataset.Tables["Thuoc"].PrimaryKey = data_column;

			ftn_DataBindings(dataset.Tables["Thuoc"]);
		}

		private void ftn_DataBindings(DataTable data_table)
		{
			tbx_TenThuoc.DataBindings.Add("text", data_table, "TenSP");
			tbx_ThanhPhan.DataBindings.Add("text", data_table, "ThanhPhan");
			tbx_GiaBan.DataBindings.Add("text", data_table, "GiaBan");
			tbx_GiaNhap.DataBindings.Add("text", data_table, "GiaNhap");
			tbx_SoLuongTon.DataBindings.Add("text", data_table, "SoLuongTon");
			cbx_MaThuoc.DataBindings.Add("text", data_table, "MaSP");
			cbx_MaLoai.DataBindings.Add("text", data_table, "TenLoai");
		}

		private void ftn_LoadDataGridView()
		{
			sql_connection = new SqlConnection(connection_string);
			sql_dataaadapter = new SqlDataAdapter("select tbl_THUOC.MaSP, TenSP, TenLoai, ThanhPhan, GiaNhap, GiaBan, SoLuongTon from tbl_THUOC inner join tbl_CTTHUOC on tbl_THUOC.MaSP = tbl_CTTHUOC.MaSP inner join tbl_LOAI on tbl_LOAI.MaLoai = tbl_THUOC.MaLoai", connection_string);
			sql_dataaadapter.Fill(dataset, "Thuoc");
		}

		private void cbx_Benh_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (dataset.Tables["Thuoc"] != null)
			{
				dataset.Tables["Thuoc"].Clear();
				sql_connection = new SqlConnection(connection_string);
				sql_dataaadapter = new SqlDataAdapter("select tbl_THUOC.MaSP, TenSP, TenLoai, ThanhPhan, GiaNhap, GiaBan, SoLuongTon from tbl_THUOC inner join tbl_CTTHUOC on tbl_THUOC.MaSP = tbl_CTTHUOC.MaSP inner join tbl_LOAI on tbl_LOAI.MaLoai = tbl_THUOC.MaLoai inner join tbl_DIEUTRI on tbl_DIEUTRI.MaSP = tbl_THUOC.MaSP inner join tbl_BENH on tbl_BENH.MaBenh = tbl_DIEUTRI.MaBenh where tbl_BENH.MaBenh = '" + cbx_Benh.SelectedValue.ToString() + "'", connection_string);
				sql_dataaadapter.Fill(dataset, "Thuoc");
			}
		}

		public void ftn_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
				MessageBox.Show("Chỉ nhập giá trị số vào trong textbox!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_Insert_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(cbx_MaLoai.Text) || string.IsNullOrEmpty(tbx_TenThuoc.Text) || string.IsNullOrEmpty(tbx_ThanhPhan.Text) || string.IsNullOrEmpty(tbx_GiaNhap.Text) || string.IsNullOrEmpty(tbx_GiaBan.Text) || string.IsNullOrEmpty(tbx_SoLuongTon.Text))
			{
				MessageBox.Show("Nhập đầy đủ thông tin khi nhập thuốc mới: Loại, Tên Thuốc, Giá Nhập, Giá Bán, Số Lượng Tồn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			sql_connection = new SqlConnection(connection_string);
			sql_connection.Open();

			try
			{
				SqlCommand sql_command = new SqlCommand("insert into tbl_THUOC (MaLoai) values ('" + cbx_MaLoai.SelectedValue.ToString() + "')", sql_connection);
				sql_command.ExecuteNonQuery();

				sql_command = new SqlCommand("select top 1 MaSP from tbl_THUOC order by SoThuTu desc", sql_connection);
				string MaThuoc = sql_command.ExecuteScalar().ToString();

				sql_command = new SqlCommand("insert into tbl_CTTHUOC values ('" + MaThuoc + "', N'" + tbx_TenThuoc.Text + "', N'" + tbx_ThanhPhan.Text + "', '" + tbx_GiaNhap.Text + "', '" + tbx_GiaBan.Text + "', '" + tbx_SoLuongTon.Text + "')", sql_connection);
				sql_command.ExecuteNonQuery();

				ftn_LoadDataGridView();

				MessageBox.Show("Nhập dữ liệu thuốc mới thành công\nMã thuốc mới là: " + MaThuoc, "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{
				MessageBox.Show("Nhập dữ liệu thuốc mới không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}

			sql_connection.Close();
		}

		private void btn_Update_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(cbx_MaThuoc.Text) || string.IsNullOrEmpty(cbx_MaLoai.Text) || string.IsNullOrEmpty(tbx_TenThuoc.Text) || string.IsNullOrEmpty(tbx_ThanhPhan.Text) || string.IsNullOrEmpty(tbx_GiaNhap.Text) || string.IsNullOrEmpty(tbx_GiaBan.Text) || string.IsNullOrEmpty(tbx_SoLuongTon.Text))
			{
				MessageBox.Show("Nhập đầy đủ thông tin khi sửa thông tin thuốc: Mã Thuốc, Loại, Tên Thuốc, Giá Nhập, Giá Bán, Số Lượng Tồn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			sql_connection = new SqlConnection(connection_string);
			sql_connection.Open();

			try
			{
				SqlCommand sql_command = new SqlCommand("update tbl_THUOC set MaLoai = '" + cbx_MaLoai.SelectedValue.ToString() + "' where MaSP = '" + cbx_MaThuoc.SelectedValue.ToString() + "'", sql_connection);
				sql_command.ExecuteNonQuery();

				sql_command = new SqlCommand("update tbl_CTTHUOC set TenSP =  N'" + tbx_TenThuoc.Text + "', ThanhPhan = N'" + tbx_ThanhPhan.Text + "', GiaNhap = '" + tbx_GiaNhap.Text + "', GiaBan = '" + tbx_GiaBan.Text + "', SoLuongTon = '" + tbx_SoLuongTon.Text + "' where MaSP = '" + cbx_MaThuoc.Text + "'", sql_connection);
				sql_command.ExecuteNonQuery();
				tbx_GiaBan.Enabled = false;
				ftn_LoadDataGridView();

				MessageBox.Show("Cập nhật dữ liệu thuốc thành công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{
				MessageBox.Show("Cập nhật dữ liệu thuốc không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			sql_connection.Close();
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(cbx_MaThuoc.Text))
			{
				MessageBox.Show("Chọn Thuốc Xóa (Mã Thuốc)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			sql_connection = new SqlConnection(connection_string);
			sql_connection.Open();

			try
			{
				SqlCommand sql_command = new SqlCommand("delete tbl_CTTHUOC where MaSP = '" + cbx_MaThuoc.Text + "'", sql_connection);
				sql_command.ExecuteNonQuery();

				sql_command = new SqlCommand("delete tbl_THUOC where MaSP = '" + cbx_MaThuoc.Text + "'", sql_connection);
				sql_command.ExecuteNonQuery();

				ftn_LoadDataGridView();

				MessageBox.Show("Xóa dữ liệu thuốc thành công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{
				MessageBox.Show("Xóa dữ liệu thuốc không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			sql_connection.Close();
		}

        private void btn_Search_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection_string))
            {
                string sql = "SP_TimTheoTenThuoc";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TENTHUOC", SqlDbType.NVarChar).Value = tbx_TenThuoc.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm thuốc: " + ex.Message);
                    return;
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thuốc có tên này.", "Thông báo");
                    return;
                }
                //dgv_PhieuNhap.DataSource = dt;
				dgv_Data.DataSource = dt;
            }
        }
        private void btn_Filter_Click(object sender, EventArgs e)
		{
            using (SqlConnection con = new SqlConnection(connection_string))
            {
                string sql = "SP_LocTheoBenh_Loai";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@LoaiBenh", SqlDbType.Text).Value = cbx_Benh.SelectedValue;
				cmd.Parameters.Add("@LoaiThuoc", SqlDbType.Text).Value= cbx_MaLoai.SelectedValue;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lọc: " + ex.Message);
                    return;
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thuốc trong loại này, hoặc không thể tìm thấy theo bệnh.");
                    return;
                }
                dgv_Data.DataSource = dt;
            }
        }
	}
}
