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
    //KHI VÀO NHỚ SỬA LẠI ĐƯỜNG DẪN KẾT NỐI BẰNG CÁCH
    //Bên dưới tên project -> propertise -> click đúp 2 lần vào Settings.settings -> sửa đường dẫn tại cột value -> là xong
    public partial class frm_Account : Form
    {
        public string conStr = Properties.Settings.Default.conStr;

        public frm_Account(string connection_string)
		{
			InitializeComponent();
			this.conStr = connection_string;
		}

		//CHUYỂN SANG TRANG ĐĂNG KÝ
		private void btn_Insert_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frm_SignUp frmDK = new frm_SignUp();
            //frmDK.ShowDialog();
            //frmDK = null;
            //this.Show();
        }
        private void frm_QLDS_Load(object sender, EventArgs e)
        {
            dsQuanHuyen();
            layDS();
        }
        //Hàm lấy danh sách sinh viên từ proc trong csdl dổ vào datagridview 
        public void layDS()
        {
            string sql = "sp_HienThiThongTin"; 
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlDataAdapter da_dsDS = new SqlDataAdapter();
                DataTable dt_dsDS = new DataTable();
                da_dsDS.SelectCommand = new SqlCommand(sql, con);

                try
                {
                    con.Open();
                    da_dsDS.Fill(dt_dsDS);

                    DataColumn[] key = new DataColumn[1];
                    key[0] = dt_dsDS.Columns[0];
                    dt_dsDS.PrimaryKey = key;

                    // Thêm một cột mới vào DataTable
                    dt_dsDS.Columns.Add("DiaChi", typeof(string));

                    // Điền dữ liệu cho cột mới
                    foreach (DataRow row in dt_dsDS.Rows)
                    {
                        row["DiaChi"] = row["SoNha"].ToString() + " " + row["TenQuanHuyen"].ToString();
                    }

                    dgv_dsDSi.DataSource = dt_dsDS; // Thay đổi DataSource phù hợp với DataGridView của bạn

                    // Duyệt qua từng hàng của DataTable
                    foreach (DataRow row in dt_dsDS.Rows)
                    {
                        // Duyệt qua từng cột của hàng
                        foreach (DataColumn column in dt_dsDS.Columns)
                        {
                            Console.WriteLine(row[column]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
        }

        public void capnhatDS(DataTable dt)
        {
            dgv_dsDSi.DataSource = dt;
        }
        //lấy danh sách QUANHUYEN từ proc trong csdl đổ vào combobox QuanHuyen
        public void dsQuanHuyen()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = "dsQuanHuyen";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbx_QHuyen.DataSource = dt;
                cbx_QHuyen.DisplayMember = "TenQuanHuyen";
                cbx_QHuyen.ValueMember = "QuanHuyenId";
            }
        }
    
        //Khi click vào từng dòng sẽ hiển thị các giá trị tương ứng trên tbx tương ứng
        private void dgv_dsDSi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng người dùng đã nhấp vào một dòng, không phải tiêu đề cột
            {
                
                DataGridViewRow row = this.dgv_dsDSi.Rows[e.RowIndex]; // Lấy dòng được nhấp

                if(row.Cells["colHoTen"].Value.ToString() == "")
                {
                    MessageBox.Show("Không có dữ liệu!!");
                    return;
                }    
                if(row.Cells["colMaQL"].Value.ToString() != "")
                {
                    tbx_Ma.Text = row.Cells["colMaQL"].Value.ToString();
                }    
                else
                {
                    tbx_Ma.Text = row.Cells["colMaDs"].Value.ToString();
                }
                
                //txtGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                tbx_SDT.Text = row.Cells["colSDT"].Value.ToString();
                tbx_HoTen.Text = row.Cells["colHoTen"].Value.ToString();
                tbx_SoNha.Text = row.Cells["colSoNha"].Value.ToString();
                cbx_QHuyen.Text = row.Cells["colQuanHuyen"].Value.ToString();
                dt_NgaySinh.Value = DateTime.Parse(row.Cells["colNgaySinh"].Value.ToString());
                tbx_Email.Text = row.Cells["colEmail"].Value.ToString();
            }
        }
        
        private void btn_Delete_Click(object sender, EventArgs e)
        {
           //Lấy giá trị từ cột ẩn tendangnhap để lấy khóa chính làm paramenter truyền vào proc
            string tenDangNhap = dgv_dsDSi.SelectedRows[0].Cells["colTenDN"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string sql = "sp_XoaTaiKhoan";
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@TenDangNhap",SqlDbType.VarChar).Value = tenDangNhap;
                        cmd.ExecuteNonQuery();
                    } 
                }
                MessageBox.Show("Xóa thành công");
                layDS();

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        //hàm check thông tin
        private bool InforCheck()
        {
            //kiểm tra định dạng cho email
            var emailRegex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
            if (!emailRegex.IsMatch(tbx_Email.Text))
            {
                MessageBox.Show("Email không đúng định dạng!");
                tbx_Email.Focus();
                return false;
            }
            //kiểm tra định dạng cho số điện thoại
            if (tbx_SDT.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có độ dài là 10 số!");
                tbx_SDT.Focus();
                return false;
            }

            return true;
        }
        //reset lại datagridview mỗi khi thực hiện thêm thông tin dược sĩ
        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            layDS();
        }

		private void btn_Update_Click(object sender, EventArgs e)
		{
			if (InforCheck() && checkEmail())
			{
				using (SqlConnection conn = new SqlConnection(conStr))
				{
					conn.Open();
					string sql = "sp_capnhatthongtin";
					using (SqlCommand cmd = new SqlCommand(sql, conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						DataGridViewRow row = dgv_dsDSi.CurrentRow;
						if (row != null)
						{
							string tendangnhap = row.Cells["colTenDN"].Value.ToString();
							cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar).Value = tendangnhap;
							cmd.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar).Value = tbx_HoTen.Text;
							cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dt_NgaySinh.Value;
							cmd.Parameters.Add("@SoNha", SqlDbType.NVarChar).Value = tbx_SoNha.Text;
							cmd.Parameters.Add("@QuanHuyenId", SqlDbType.Int).Value = cbx_QHuyen.SelectedValue;
							cmd.Parameters.Add("@SoDienThoai", SqlDbType.VarChar).Value = tbx_SDT.Text;
							cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = tbx_Email.Text;

							cmd.ExecuteNonQuery();
						}
					}
					MessageBox.Show("Cập nhật thông tin thành công!!");
					layDS();
					tbx_Email.Clear();
					tbx_HoTen.Clear();
					tbx_SDT.Clear();
					tbx_Ma.Clear();
					tbx_SoNha.Clear();
					cbx_QHuyen.Text = "";
				}
			}
		}

		public bool checkEmail()
		{
			string sql = "sp_KiemTraEmail";
			using (SqlConnection conn = new SqlConnection(conStr))
			{
				conn.Open();
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = tbx_Email.Text;

					var result = (int)cmd.ExecuteScalar();
					if (result > 0)
					{
						MessageBox.Show("Email đã tồn tại. Vui lòng chọn email khác.");
						return false;
					}
				}
			}
			return true;
		}

		private void btn_Search_Click(object sender, EventArgs e)
        {
            frm_Search frmTK = new frm_Search(this, conStr);
            frmTK.ShowDialog();
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            frm_Filter frmLoc = new frm_Filter(this, conStr);
            frmLoc.ShowDialog();
        }
    }
}
