using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom7_PhanMemQuanLyHieuThuoc
{
    public partial class frm_Order : Form
    {
        public string connection_string { get; set; }
        public string username { get; set; }
        public string userid { get; set; }
        public string accountname { get; set; }
        public SqlConnection sql_connection { get; set; }
        SqlDataAdapter sqlDataAdapter;
        //DataSet dataSet;
        DataTable dataTable;
        public frm_Order(string accountname, string connection_string)
        {
            InitializeComponent();
            this.connection_string = connection_string;
            this.sql_connection = new SqlConnection(connection_string);
            this.accountname = accountname;
        }

        public void DanhsachNhaCungCap()
        {
            string query = "SELECT MANCC,TENNCC FROM tbl_NHACUNGCAP";
            sql_connection.Open();
            sqlDataAdapter = new SqlDataAdapter(query, sql_connection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sql_connection.Close();
            cbx_NhaCungCap.DataSource = dataTable;
            cbx_NhaCungCap.DisplayMember = "TENNCC";
            cbx_NhaCungCap.ValueMember = "MANCC";
        }

        public void DanhsachLoaiThuoc()
        {
            string query = "SELECT MALOAI,TENLOAI FROM TBL_LOAI";
            sql_connection.Open();
            sqlDataAdapter = new SqlDataAdapter(query, sql_connection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sql_connection.Close();
            cbx_LoaiThuoc.DataSource = dataTable;
            cbx_LoaiThuoc.DisplayMember = "TENLOAI";
            cbx_LoaiThuoc.ValueMember = "MALOAI";
        }
        public void DanhSachThuoc(string maloai)
        {
            string query = string.Format("EXEC USP_DANHSACHTHUOCTHEOLOAI @MALOAI='{0}'", maloai);
            sql_connection.Open();
            sqlDataAdapter = new SqlDataAdapter(query, sql_connection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sql_connection.Close();
            cbx_Thuoc.DataSource = dataTable;
            cbx_Thuoc.DisplayMember = "TenSP";
            cbx_Thuoc.ValueMember = "MaSP";
        }
        public void DanhsachPhieuNhap()
        {
            string query = "EXEC USP_DANHSACHPHIEUNHAP";
            sql_connection.Open();
            sqlDataAdapter = new SqlDataAdapter(query, sql_connection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sql_connection.Close();
            dgv_PhieuNhap.DataSource = dataTable;
        }
        public void DanhsachCTPN(string mapn)
        {
            string query = string.Format("EXEC USP_DANHSACHCTPN @MAPN='{0}'", mapn);
            sql_connection.Open();
            sqlDataAdapter = new SqlDataAdapter(query, sql_connection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sql_connection.Close();
            dgv_ChiTietPhieuNhap.DataSource = dataTable;
        }
        public void TenLoaiThuoc(string tenthuoc)
        {
            string query = string.Format("EXEC USP_LAYTENLOAITHUOC @TenSP = N'{0}'", tenthuoc);
            sql_connection.Open();
            sqlDataAdapter = new SqlDataAdapter(query, sql_connection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sql_connection.Close();
            cbx_LoaiThuoc.Text = dataTable.Rows[0][0].ToString();
        }
        public void ThemCTPN(string mapn, string masp, int sldat, int slnhan, int dongianhap)
        {
            string query = string.Format("EXEC USP_THEMCTPN @MAPN='{0}',@MASP='{1}',@SOLUONGDAT='{2}',@SOLUONGNHAN='{3}',@DONGIANHAP='{4}'", mapn, masp, sldat, slnhan, dongianhap);
            sql_connection.Open();
            SqlCommand cmd = new SqlCommand(query, sql_connection);
            cmd.ExecuteNonQuery();
            sql_connection.Close();
        }
        public bool KtrCoCTPN(string mapn)
        {
            string query = string.Format("EXEC USP_DANHSACHCTPN @MAPN='{0}'", mapn);
            sql_connection.Open();
            sqlDataAdapter = new SqlDataAdapter(query, sql_connection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sql_connection.Close();
            if (dataTable.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }
        private void frm_Received_Load(object sender, EventArgs e)
        {
            //string query = string.Format("SELECT TENNGUOIDUNG FROM TBL_CHITIETTAIKHOAN WHERE TENDANGNHAP = '{0}'",accountname);
            string query = string.Format("SELECT MaDuocSi FROM tbl_DUOCSI WHERE TenDangNhap =N'{0}'", accountname);
            sql_connection.Open();
            sqlDataAdapter = new SqlDataAdapter(query, sql_connection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sql_connection.Close();
            //username = dataTable.Rows[0][0].ToString();
            userid = dataTable.Rows[0][0].ToString();
            DanhsachPhieuNhap();
            DanhsachNhaCungCap();
            DanhsachLoaiThuoc();
            DanhSachThuoc(cbx_LoaiThuoc.SelectedValue.ToString());
        }

        private void cbx_LoaiThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DanhSachThuoc(cbx_LoaiThuoc.SelectedValue.ToString());
        }

        private void dgv_PhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int tongtien = 0;
                int index = e.RowIndex;
                tbx_MaPhieuNhap.Text = dgv_PhieuNhap.Rows[index].Cells[1].Value.ToString();
                cbx_NhaCungCap.Text = dgv_PhieuNhap.Rows[index].Cells[2].Value.ToString();
                tbx_TrangThai.Text = dgv_PhieuNhap.Rows[index].Cells[5].Value.ToString();
                if (KtrCoCTPN(tbx_MaPhieuNhap.Text))
                {
                    DanhsachCTPN(dgv_PhieuNhap.Rows[index].Cells[1].Value.ToString());

                    for (int i = 0; i < dgv_ChiTietPhieuNhap.Rows.Count; i++)
                    {
                        tongtien += (int.Parse(dgv_ChiTietPhieuNhap.Rows[i].Cells[2].Value.ToString()) * int.Parse(dgv_ChiTietPhieuNhap.Rows[i].Cells[4].Value.ToString()));
                    }
                    tbx_ThanhTien.Text = string.Format("{0:0,0 VND}", tongtien).Replace(',', '.');
                    TenLoaiThuoc(dgv_ChiTietPhieuNhap.Rows[0].Cells[1].Value.ToString());
                    cbx_Thuoc.Text = dgv_ChiTietPhieuNhap.Rows[0].Cells[1].Value.ToString();
                }
                else
                {
                    dgv_ChiTietPhieuNhap.DataSource = "";
                    cbx_NhaCungCap.SelectedIndex = 0;
                    cbx_LoaiThuoc.SelectedIndex = 0;
                    cbx_Thuoc.SelectedIndex = 0;
                    tbx_MaCTPN.Text = string.Empty;
                    tbx_ThanhTien.Text = string.Empty;
                }
                tbx_MaCTPN.Text = string.Empty;
                nm_SoLuongNhan.Value = 0;
                nm_SoLuongDat.Value = 0;
                nm_DonGiaNhap.Value = 0;
                cbx_NhaCungCap.Enabled = true;
                cbx_LoaiThuoc.Enabled = true;
                cbx_Thuoc.Enabled = true;
            }
        }
        private void dgv_ChiTietPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                tbx_MaCTPN.Text = dgv_ChiTietPhieuNhap.Rows[index].Cells[0].Value.ToString();
                cbx_Thuoc.Text = dgv_ChiTietPhieuNhap.Rows[index].Cells[1].Value.ToString();
                TenLoaiThuoc(cbx_Thuoc.Text);
                nm_SoLuongNhan.Maximum = int.Parse(dgv_ChiTietPhieuNhap.Rows[index].Cells[2].Value.ToString());
                nm_SoLuongDat.Value = int.Parse(dgv_ChiTietPhieuNhap.Rows[index].Cells[2].Value.ToString());
                nm_SoLuongNhan.Value = int.Parse(dgv_ChiTietPhieuNhap.Rows[index].Cells[3].Value.ToString());
                nm_DonGiaNhap.Value = int.Parse(dgv_ChiTietPhieuNhap.Rows[index].Cells[4].Value.ToString());
                tbx_MaPhieuNhap.Text = string.Empty;
                cbx_NhaCungCap.Enabled = false;
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (tbx_MaPhieuNhap.Text != "")
            {
                if (MessageBox.Show("Bạn muốn xóa phiếu nhập này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = string.Format("EXEC USP_XOAPHIEUNHAP @MaPN='{0}'", tbx_MaPhieuNhap.Text);
                    sql_connection.Open();
                    SqlCommand cmd = new SqlCommand(query, sql_connection);
                    cmd.ExecuteNonQuery();
                    sql_connection.Close();
                    DanhsachPhieuNhap();
                    DanhsachCTPN(tbx_MaPhieuNhap.Text);
                }

            }
            else
            {
                if (tbx_MaCTPN.Text != "")
                {
                    if (MessageBox.Show("Bạn muốn xóa chi tiết phiếu nhập này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string query = string.Format("DELETE tbl_CTPhieuNhap WHERE MaCTPN='{0}'", tbx_MaCTPN.Text);
                        sql_connection.Open();
                        SqlCommand cmd = new SqlCommand(query, sql_connection);
                        cmd.ExecuteNonQuery();
                        sql_connection.Close();
                        DanhsachPhieuNhap();
                        DanhsachCTPN(tbx_MaPhieuNhap.Text);
                    }
                }
            }
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (tbx_MaPhieuNhap.Text != "")
            {
                if (tbx_TrangThai.Text != "Nhận đủ")
                {
                    try
                    {
                        ThemCTPN(tbx_MaPhieuNhap.Text, cbx_Thuoc.SelectedValue.ToString(), ((int)nm_SoLuongDat.Value), ((int)nm_SoLuongNhan.Value), ((int)nm_DonGiaNhap.Value));
                        DanhsachPhieuNhap();
                        DanhsachCTPN(tbx_MaPhieuNhap.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Sản phẩm đã có trong phiếu nhập", "Thông báo");
                        sql_connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Không thể thêm vì phiếu đã nhận đủ hàng!", "Thông báo", MessageBoxButtons.OK);
                }
                nm_SoLuongNhan.Value = 0;
                nm_SoLuongDat.Value = 0;
                nm_DonGiaNhap.Value = 0;
            }
            else
            {
                string query = string.Format("EXEC USP_THEMPHIEUNHAP @MANCC ='{0}',@MADUOCSI='{1}'", cbx_NhaCungCap.SelectedValue.ToString(), userid);
                sql_connection.Open();
                SqlCommand cmd = new SqlCommand(query, sql_connection);
                cmd.ExecuteNonQuery();
                sql_connection.Close();
                DanhsachPhieuNhap();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tbx_MaPhieuNhap.Text != "")
            {
                if (tbx_TrangThai.Text != "Nhận đủ")
                {
                    string query = string.Format("UPDATE tbl_PhieuNhap SET MaNCC = '{0}' WHERE MaPN = '{1}'", cbx_NhaCungCap.SelectedValue.ToString(), tbx_MaPhieuNhap.Text);
                    sql_connection.Open();
                    SqlCommand cmd = new SqlCommand(query, sql_connection);
                    cmd.ExecuteNonQuery();
                    sql_connection.Close();
                    DanhsachPhieuNhap();
                    DanhsachCTPN(tbx_MaCTPN.Text);
                    MessageBox.Show("Sửa đổi nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Phiếu nhập đã nhận đủ không thể cập nhật thêm!", "Thông báo");
                }
            }
            if (tbx_MaCTPN.Text != "")
            {
                if (tbx_TrangThai.Text != "Nhận đủ")
                {
                    try
                    {
                        string query = string.Format("UPDATE tbl_CTPhieuNhap SET SoLuongNhan = {0},SoLuongDat={1},MaSP= '{2}',DonGiaNhap={3} WHERE MaCTPN = '{4}'", nm_SoLuongNhan.Value, nm_SoLuongDat.Value, cbx_Thuoc.SelectedValue.ToString(), nm_DonGiaNhap.Value, tbx_MaCTPN.Text);
                        sql_connection.Open();
                        SqlCommand cmd = new SqlCommand(query, sql_connection);
                        cmd.ExecuteNonQuery();
                        sql_connection.Close();
                        DanhsachPhieuNhap();
                        DanhsachCTPN(tbx_MaCTPN.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Số lượng nhận không được hơn số lượng đặt", "Thông báo");
                        sql_connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Phiếu nhập đã nhận đủ không thể cập nhật thêm!", "Thông báo");
                }
            }
        }


        private void btn_Search_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection_string))
            {
                string sql = "USP_TIMPHIEUNHAPTHEOTENNCC";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TENNCC", SqlDbType.NVarChar).Value = cbx_NhaCungCap.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm phiếu nhập: " + ex.Message);
                    return;
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy phiếu nhập có tên nhà cung cấp này.", "Thông báo");
                    return;
                }
                dgv_PhieuNhap.DataSource = dt;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tbx_MaPhieuNhap.Text = string.Empty;
            cbx_NhaCungCap.SelectedIndex = 0;
            cbx_NhaCungCap.Enabled = true;
            cbx_LoaiThuoc.Enabled = false;
            cbx_Thuoc.Enabled = false;
            cbx_LoaiThuoc.SelectedIndex = 0;
            cbx_Thuoc.SelectedIndex = 0;
            tbx_MaCTPN.Text = string.Empty;
            tbx_TrangThai.Text = string.Empty;
            tbx_ThanhTien.Text = string.Empty;
            NgayNhap.Enabled = false;
            NgayNhap.Value = DateTime.Now;
            nm_SoLuongDat.Value = 0;
            nm_SoLuongNhan.Value = 0;
            nm_DonGiaNhap.Value = 0;
            DanhsachPhieuNhap();
            dgv_ChiTietPhieuNhap.DataSource = "";
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            NgayNhap.Enabled = true;
        }

        private void NgayNhap_ValueChanged(object sender, EventArgs e)
        {
            string query = string.Format("SET DATEFORMAT DMY EXEC USP_LOCDANHSACHPHIEUNHAP @NGAYNHAP ='{0}'", NgayNhap.Value.ToString());
            sql_connection.Open();
            sqlDataAdapter = new SqlDataAdapter(query, sql_connection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sql_connection.Close();
            dgv_PhieuNhap.DataSource = dataTable;
        }
    }
}
