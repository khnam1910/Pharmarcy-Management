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
using System.Text.RegularExpressions;

namespace Nhom7_PhanMemQuanLyHieuThuoc
{
    public partial class frm_Customer : Form
    {
        public string conStr = Properties.Settings.Default.conStr;

        public frm_Customer(string connection_string)
        {
            InitializeComponent();
            this.conStr = connection_string;
        }

        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            layDSKhachHang();
            dsQuanHuyen();
            loadcbbGender();
            this.cbb_QuanHuyen.Visible = true;
        }

        public bool InforCheck()
        {

            if (tbx_TenKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_TenKH.Focus();
                return false;
            }
            if (tbx_SDT.Text == "" && int.Parse(tbx_SDT.Text) > 10)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_SDT.Focus();
                return false;
            }
            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.) |(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,})$");
            if (tbx_Email.Text == "" && !regex.IsMatch(tbx_Email.Text))
            {
                MessageBox.Show("Vui lòng nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_Email.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbb_GT.Text))
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(cbb_QuanHuyen.Text))
            {
                MessageBox.Show("Vui lòng chọn quận/huyện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        public void dsQuanHuyen()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = "quanhuyen";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbb_QuanHuyen.DataSource = dt;
                cbb_QuanHuyen.DisplayMember = "TenQuanHuyen";
                cbb_QuanHuyen.ValueMember = "QuanHuyenId";
                //cbo_QuanHuyen.Text = "Tên thể loại";
            }
        }

        public void loadcbbGender()
        {
            Dictionary<int, string> gender = new Dictionary<int, string>
            {
                { 0, "Nam" },
                { 1, "Nữ" },
                { 2, "Khác" }
            };
            cbb_GT.DataSource = new BindingSource(gender, null);
            cbb_GT.DisplayMember = "Value";
            cbb_GT.ValueMember = "Value";
            cbb_GT.SelectedIndex = 0;
        }

        public void layDSKhachHang()
        {
            string sql = "dsKH";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlDataAdapter da_dsKH = new SqlDataAdapter();
                DataTable dt_dsKH = new DataTable();
                da_dsKH.SelectCommand = new SqlCommand(sql, con);

                try
                {
                    con.Open();
                    da_dsKH.Fill(dt_dsKH);

                    DataColumn[] key = new DataColumn[1];
                    key[0] = dt_dsKH.Columns[0];
                    dt_dsKH.PrimaryKey = key;

                    dgv_Data.DataSource = dt_dsKH;

                    // Duyệt qua từng hàng của DataTable
                    foreach (DataRow row in dt_dsKH.Rows)
                    {
                        // Duyệt qua từng cột của hàng
                        foreach (DataColumn column in dt_dsKH.Columns)
                        {
                            Console.WriteLine(row[column]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

        public void capnhatDanhSach(DataTable dt)
        {
            dgv_Data.DataSource = dt;
        }

        private void dgv_Data_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Data.SelectedRows.Count > 0)
            {
                // Get data from the first selected row
                DataGridViewRow row = dgv_Data.SelectedRows[0];
                // Update TextBoxes
                tbx_MaKH.Text = row.Cells["col_MaKH"].Value.ToString();
                tbx_TenKH.Text = row.Cells["Col_TenKH"].Value.ToString();
                tbx_SDT.Text = row.Cells["Col_SDT"].Value.ToString();
                cbb_GT.Text = row.Cells["Col_GT"].Value.ToString();
                tbx_Email.Text = row.Cells["Col_Email"].Value.ToString();
                tbx_DiaChi.Text = row.Cells["Col_DiaChi"].Value.ToString();
                cbb_QuanHuyen.Text = row.Cells["Col_QuanHuyen"].Value.ToString();
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập vào
            if (!InforCheck())
            {
                // Dữ liệu chưa nhập đầy đủ
                return;
            }

            // Kết nối với cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();

                // Tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand("themKH", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tenKH", SqlDbType.NVarChar).Value = tbx_TenKH.Text;
                cmd.Parameters.Add("@sdt", SqlDbType.VarChar).Value = tbx_SDT.Text;
                cmd.Parameters.Add("@gioiTinh", SqlDbType.NVarChar).Value = cbb_GT.SelectedValue;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = tbx_Email.Text;
                cmd.Parameters.Add("@soNha", SqlDbType.NVarChar).Value = tbx_DiaChi.Text;
                cmd.Parameters.Add("@quanHuyenId", SqlDbType.Int).Value = cbb_QuanHuyen.SelectedValue;
                //cmd.Parameters.Add("@quanHuyenId", SqlDbType.Int).Value = cbb_QuanHuyen.SelectedValue;


                // Thực thi câu lệnh
                cmd.ExecuteNonQuery();

                // Đóng kết nối
                connection.Close();

                // Thông báo thành công
                MessageBox.Show("Thêm thông tin thành công!");

                layDSKhachHang();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                string sql = "xoaKH";
                con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@maKH", SqlDbType.VarChar).Value = tbx_MaKH.Text;
                DialogResult dg = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    layDSKhachHang();
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbx_MaKH.Clear();
                    tbx_TenKH.Clear();
                    tbx_SDT.Clear();
                    tbx_Email.Clear();
                    tbx_DiaChi.Clear();
                    cbb_GT.Text = "";
                    cbb_QuanHuyen.Text = "";
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("Dữ liệu không thể xóa");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        private string selectedTenKH;

        private void dgv_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedTenKH = dgv_Data.Rows[e.RowIndex].Cells[0].Value.ToString();

            // Hiển thị thông tin của khách hàng để sửa
            ShowCustomerInfo(selectedTenKH);
        }

        private void ShowCustomerInfo(string tenKH)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();

                // Tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand("layThongTinKH", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tenKH", SqlDbType.NVarChar).Value = tenKH;

                // Sử dụng SqlDataReader để đọc thông tin của khách hàng
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Hiển thị thông tin trên các controls của form
                        tbx_TenKH.Text = reader["TenKH"].ToString();
                        tbx_SDT.Text = reader["SDT"].ToString();
                        cbb_GT.SelectedValue = reader["GioiTinh"].ToString();
                        tbx_Email.Text = reader["Email"].ToString();
                        tbx_DiaChi.Text = reader["SoNha"].ToString();
                        cbb_QuanHuyen.SelectedValue = reader["QuanHuyenId"].ToString();
                    }
                }

                // Đóng kết nối
                connection.Close();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();

                // Tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand("suaKH", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maKH", SqlDbType.VarChar).Value = tbx_MaKH.Text;
                cmd.Parameters.Add("@tenKH", SqlDbType.NVarChar).Value = tbx_TenKH.Text; // Sử dụng tên khách hàng đã chọn
                cmd.Parameters.Add("@sdt", SqlDbType.VarChar).Value = tbx_SDT.Text;
                cmd.Parameters.Add("@gioiTinh", SqlDbType.NVarChar).Value = cbb_GT.SelectedValue;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = tbx_Email.Text;
                cmd.Parameters.Add("@soNha", SqlDbType.NVarChar).Value = tbx_DiaChi.Text;
                cmd.Parameters.Add("@quanHuyenId", SqlDbType.Int).Value = cbb_QuanHuyen.SelectedValue;

                // Thực thi câu lệnh
                cmd.ExecuteNonQuery();

                // Đóng kết nối
                connection.Close();

                // Thông báo thành công
                MessageBox.Show("Sửa thông tin thành công!");

                layDSKhachHang();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string sql = "timKH";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@value", SqlDbType.NVarChar).Value = tbx_TenKH.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm khách hàng: " + ex.Message);
                    return;
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khách hàng nào có tên này.");
                    return;
                }
                dgv_Data.DataSource = dt;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            
            tbx_MaKH.Text = string.Empty;
            tbx_TenKH.Text = string.Empty;
            tbx_SDT.Text = string.Empty;
            cbb_GT.SelectedIndex = 0; // Giả sử mục đầu tiên là mục mặc định
            tbx_Email.Text = string.Empty;
            tbx_DiaChi.Text = string.Empty;
            cbb_QuanHuyen.SelectedIndex = 0;
            layDSKhachHang();
        }

        private void btn_LocTT_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string sql = "sp_LayDanhSachKhachHangTheoQuanHuyen";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@quanHuyenId", SqlDbType.Int).Value = cbb_QuanHuyen.SelectedValue;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm khách hàng: " + ex.Message);
                    return;
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khách hàng nào có tên này.");
                    return;
                }
                dgv_Data.DataSource = dt;
            }
        }

    }
}
