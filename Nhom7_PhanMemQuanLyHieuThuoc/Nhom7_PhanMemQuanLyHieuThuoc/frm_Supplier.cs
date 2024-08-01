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
    public partial class frm_Supplier : Form
    {
        public string conStr = Properties.Settings.Default.conStr;

        public frm_Supplier(string connection_string)
        {
            InitializeComponent();
            this.conStr = connection_string;
        }

        private void Frm_NhaCungCap_Load(object sender, EventArgs e)
        {
            layDSNCC();
            dsQuanHuyen();
            this.cbb_QuanHuyen_NCC.Visible = true;
        }

        public bool InforCheck()
        {

            if (tbx_TenNCC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_TenNCC.Focus();
                return false;
            }
            if (tbx_SDT_NCC.Text == "" && int.Parse(tbx_SDT_NCC.Text) > 10)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_SDT_NCC.Focus();
                return false;
            }
            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.) |(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,})$");
            if (tbx_Email_NCC.Text == "" && !regex.IsMatch(tbx_Email_NCC.Text))
            {
                MessageBox.Show("Vui lòng nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_Email_NCC.Focus();
                return false;
            }
            
            if (string.IsNullOrEmpty(cbb_QuanHuyen_NCC.Text))
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
                cbb_QuanHuyen_NCC.DataSource = dt;
                cbb_QuanHuyen_NCC.DisplayMember = "TenQuanHuyen";
                cbb_QuanHuyen_NCC.ValueMember = "QuanHuyenId";
                //cbo_QuanHuyen.Text = "Tên thể loại";
            }
        }

        public void layDSNCC()
        {
            string sql = "sp_LayDanhSachNhaCungCap";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlDataAdapter da_dsNCC = new SqlDataAdapter();
                DataTable dt_dsNCC = new DataTable();
                da_dsNCC.SelectCommand = new SqlCommand(sql, con);

                try
                {
                    con.Open();
                    da_dsNCC.Fill(dt_dsNCC);

                    DataColumn[] key = new DataColumn[1];
                    key[0] = dt_dsNCC.Columns[0];
                    dt_dsNCC.PrimaryKey = key;

                    dgv_Data_NCC.DataSource = dt_dsNCC;

                    // Duyệt qua từng hàng của DataTable
                    foreach (DataRow row in dt_dsNCC.Rows)
                    {
                        // Duyệt qua từng cột của hàng
                        foreach (DataColumn column in dt_dsNCC.Columns)
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
            dgv_Data_NCC.DataSource = dt;
        }

        private void dgv_Data_NCC_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Data_NCC.SelectedRows.Count > 0)
            {
                // Get data from the first selected row
                DataGridViewRow row = dgv_Data_NCC.SelectedRows[0];
                // Update TextBoxes
                tbx_MaNCC.Text = row.Cells["col_MaNCC"].Value.ToString();
                tbx_TenNCC.Text = row.Cells["Col_TenNCC"].Value.ToString();
                tbx_SDT_NCC.Text = row.Cells["Col_SDT"].Value.ToString();
                tbx_Email_NCC.Text = row.Cells["Col_Email"].Value.ToString();
                tbx_DiaChi_NCC.Text = row.Cells["Col_DiaChi"].Value.ToString();
                cbb_QuanHuyen_NCC.Text = row.Cells["Col_QuanHuyen"].Value.ToString();
            }
        }

        private void btn_Insert_NCC_Click(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand("sp_ThemNhaCungCap", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TenNCC", SqlDbType.NVarChar).Value = tbx_TenNCC.Text;
                cmd.Parameters.Add("@sdt", SqlDbType.VarChar).Value = tbx_SDT_NCC.Text;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = tbx_Email_NCC.Text;
                cmd.Parameters.Add("@soNha", SqlDbType.NVarChar).Value = tbx_DiaChi_NCC.Text;
                cmd.Parameters.Add("@quanHuyenId", SqlDbType.Int).Value = cbb_QuanHuyen_NCC.SelectedValue;
                //cmd.Parameters.Add("@quanHuyenId", SqlDbType.Int).Value = cbb_QuanHuyen.SelectedValue;


                // Thực thi câu lệnh
                cmd.ExecuteNonQuery();

                // Đóng kết nối
                connection.Close();

                // Thông báo thành công
                MessageBox.Show("Thêm thông tin thành công!");

                layDSNCC();
            }
        }

        private void btn_Delete_NCC_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                string sql = "sp_XoaNhaCungCap";
                con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaNCC", SqlDbType.VarChar).Value = tbx_MaNCC.Text;
                DialogResult dg = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    layDSNCC();
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbx_MaNCC.Clear();
                    tbx_TenNCC.Clear();
                    tbx_SDT_NCC.Clear();
                    tbx_Email_NCC.Clear();
                    tbx_DiaChi_NCC.Clear();
                    cbb_QuanHuyen_NCC.Text = "";
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

        private void btn_Search_NCC_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string sql = "sp_TimNhaCungCapTheoTen";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TenNCC", SqlDbType.NVarChar).Value = tbx_TenNCC.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm nhà cung cấp: " + ex.Message);
                    return;
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp nào có tên này.");
                    return;
                }
                dgv_Data_NCC.DataSource = dt;
            }
        }

        private void btn_Reset_NCC_Click(object sender, EventArgs e)
        {
            tbx_MaNCC.Text = string.Empty;
            tbx_TenNCC.Text = string.Empty;
            tbx_SDT_NCC.Text = string.Empty;
            tbx_Email_NCC.Text = string.Empty;
            tbx_DiaChi_NCC.Text = string.Empty;
            cbb_QuanHuyen_NCC.SelectedIndex = 0;
            layDSNCC();
        }

        private void btn_Update_NCC_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();

                // Tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand("sp_CapNhatThongTinNhaCungCap_test", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maNCC", SqlDbType.VarChar).Value = tbx_MaNCC.Text;
                cmd.Parameters.Add("@tenNCC", SqlDbType.NVarChar).Value = tbx_TenNCC.Text; 
                cmd.Parameters.Add("@sdt", SqlDbType.VarChar).Value = tbx_SDT_NCC.Text;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = tbx_Email_NCC.Text;
                cmd.Parameters.Add("@soNha", SqlDbType.NVarChar).Value = tbx_DiaChi_NCC.Text;
                cmd.Parameters.Add("@quanHuyenId", SqlDbType.Int).Value = cbb_QuanHuyen_NCC.SelectedValue;

                // Thực thi câu lệnh
                cmd.ExecuteNonQuery();

                // Đóng kết nối
                connection.Close();

                // Thông báo thành công
                MessageBox.Show("Sửa thông tin thành công!");
                layDSNCC();
            }
        }

        private string selectedTenNCC;

        private void dgv_Data_NCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedTenNCC = dgv_Data_NCC.Rows[e.RowIndex].Cells[0].Value.ToString();

            // Hiển thị thông tin của khách hàng để sửa
            ShowNCCInfo(selectedTenNCC);
        }

        private void ShowNCCInfo(string tenNCC)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();

                // Tạo đối tượng SqlCommand
                SqlCommand cmd = new SqlCommand("sp_LayThongTinNhaCungCapTheoTen", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tenNCC", SqlDbType.NVarChar).Value = tenNCC;

                // Sử dụng SqlDataReader để đọc thông tin của khách hàng
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Hiển thị thông tin trên các controls của form
                        tbx_TenNCC.Text = reader["TenNCC"].ToString();
                        tbx_SDT_NCC.Text = reader["SDT"].ToString();
                        tbx_Email_NCC.Text = reader["Email"].ToString();
                        tbx_DiaChi_NCC.Text = reader["SoNha"].ToString();
                        cbb_QuanHuyen_NCC.SelectedValue = reader["QuanHuyenId"].ToString();
                    }
                }

                // Đóng kết nối
                connection.Close();
            }
        }

        private void btn_LocTT_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string sql = "sp_LayDanhSachNCCTheoQuanHuyen";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@quanHuyenId", SqlDbType.Int).Value = cbb_QuanHuyen_NCC.SelectedValue;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm nhà cung cấp: " + ex.Message);
                    return;
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp nào ở quận huyện này.");
                    return;
                }
                dgv_Data_NCC.DataSource = dt;
            }
        }

        
    }
}
