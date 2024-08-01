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
    public partial class frm_SignUp : Form
    {
        public string conStr = Properties.Settings.Default.conStr;
        
        public frm_SignUp(string connection_string)
        {
            InitializeComponent();
            this.conStr = connection_string;
        }

        private void frm_DangKy_Load(object sender, EventArgs e)
        {
            cbx_QuanHuyen.Text = "Vui lòng chọn Quận/Huyện";
            rdioNam.Checked = true;
            rdioQuanLy.Checked = true;
            dsQuanHuyen();
        }

        //lấy thông tin quận huyện từ proc trong csdl
        public void dsQuanHuyen()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = "dsQuanHuyen";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbx_QuanHuyen.DataSource = dt;
                cbx_QuanHuyen.DisplayMember = "TenQuanHuyen";
                cbx_QuanHuyen.ValueMember = "QuanHuyenId";
            }
        }
        //hàm kiểm tra thông tin khi thực hiện đăng ký
        private bool InforCheck()
        {
            // Kiểm tra xem các trường có rỗng hay không
            if (string.IsNullOrWhiteSpace(tbx_TenDN.Text))
            {
                MessageBox.Show("Tên đăng nhập không được để trống!");
                tbx_TenDN.Focus();
                return false;
            }
            else if (tbx_TenDN.Text.Length < 6)
            {
                MessageBox.Show("Tên đăng nhập phải có ít nhất 6 ký tự!");
                tbx_TenDN.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbx_MatKhau.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống!");
                tbx_MatKhau.Focus();
                return false;
            }
            else if (tbx_MatKhau.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!");
                tbx_MatKhau.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbx_XacNhanMatKhau.Text))
            {
                MessageBox.Show("Xác nhận mật khẩu không được để trống!");
                tbx_XacNhanMatKhau.Focus();
                return false;
            }
            else if (!tbx_MatKhau.Text.Equals(tbx_XacNhanMatKhau.Text))
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không giống nhau!");
                tbx_MatKhau.Focus();
                return false;
            }

            if (!rdioDuocSi.Checked && !rdioQuanLy.Checked)
            {
                MessageBox.Show("Vui lòng chọn một chức vụ!");
                rdioDuocSi.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbx_HoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống!");
                tbx_HoTen.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(cbx_QuanHuyen.Text))
            {
                MessageBox.Show("Quận huyện không được để trống!");
                cbx_QuanHuyen.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbx_DiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống!");
                tbx_DiaChi.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbx_Email.Text))
            {
                MessageBox.Show("Email không được để trống!");
                tbx_Email.Focus();
                return false;
            }
            else
            {
                // Kiểm tra xem email có đúng định dạng hay không
                var emailRegex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
                if (!emailRegex.IsMatch(tbx_Email.Text))
                {
                    MessageBox.Show("Email không đúng định dạng!");
                    tbx_Email.Focus();
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(tbx_SDT.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống!");
                tbx_SDT.Focus();
                return false;
            }
            else if (tbx_SDT.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có độ dài là 10 số!");
                tbx_SDT.Focus();
                return false;
            }

            
            return true;
        }

        public bool checkTenDangNhap()
        {
            string sql = "sp_KiemTraTenDangNhap";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar).Value = tbx_TenDN.Text;

                    var result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên đăng nhập khác.");
                        return false;
                    }
                }
            }
            return true;
        }
		private void btnDangKy_Click(object sender, EventArgs e)
		{
			try
			{
				if (InforCheck() && checkTenDangNhap() && checkEmail())
				{
					// Thêm hộp thoại xác nhận ở đây
					DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng ký?", "Xác nhận đăng ký", MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.Yes)
					{
						string sql = "sp_ThemTaiKhoan";
						using (SqlConnection conn = new SqlConnection(conStr))
						{
							conn.Open();
							using (SqlCommand cmd = new SqlCommand(sql, conn))
							{
								cmd.CommandType = CommandType.StoredProcedure;
								// Thêm các tham số vào SqlCommand
								cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar).Value = tbx_TenDN.Text;
								cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = tbx_MatKhau.Text;
								if (rdioDuocSi.Checked == true)
								{
									cmd.Parameters.Add("@VaiTro", SqlDbType.NVarChar).Value = rdioDuocSi.Text;
								}
								else
								{
									cmd.Parameters.Add("@VaiTro", SqlDbType.NVarChar).Value = rdioQuanLy.Text;
								}
								cmd.Parameters.Add("@TenNguoiDung", SqlDbType.NVarChar).Value = tbx_HoTen.Text;
								cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dt_NgaySinh.Value;
								if (rdioNam.Checked == true)
								{
									cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = rdioNam.Text;
								}
								else
								{
									cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = rdioNu.Text;
								}
								cmd.Parameters.Add("@SoNha", SqlDbType.NVarChar).Value = tbx_DiaChi.Text;
								cmd.Parameters.Add("@QuanHuyenId", SqlDbType.VarChar).Value = cbx_QuanHuyen.SelectedValue;
								cmd.Parameters.Add("@SoDienThoai", SqlDbType.VarChar).Value = tbx_SDT.Text;
								cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = tbx_Email.Text;
								cmd.ExecuteNonQuery();
							}
						}

						MessageBox.Show("Đăng ký thành công!");
						this.Close();
					}
					else if (dialogResult == DialogResult.No)
					{
						this.Close();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
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

		//reset lại thông tin để nhập thêm 
		private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbx_TenDN.Clear();
            tbx_MatKhau.Clear();
            tbx_XacNhanMatKhau.Clear();
            tbx_SDT.Clear();
            tbx_Email.Clear();
            tbx_DiaChi.Clear();
            cbx_QuanHuyen.Text = "Vui lòng chọn Quận/Huyện";
            tbx_HoTen.Clear();
        }
        //cái này nếu không cần thì có thể xóa đi nha
        //Bấm alt+f4 để xài cũng được nha
        private void mnuDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
