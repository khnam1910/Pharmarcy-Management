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
    public partial class frm_Search : Form
    {
        public string conStr;
        frm_Account frmQLDS;
        public frm_Search(frm_Account frmQLDS, string conStr)
        {
            this.frmQLDS = frmQLDS;
            this.conStr = conStr;
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string sql = "sp_timDuocSi";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TenNguoiDung", SqlDbType.VarChar).Value = tbx_HoTen.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm sinh viên: " + ex.Message);
                    return;
                }
  
                dt.Columns.Add("DiaChi", typeof(string));

                // Điền dữ liệu cho cột mới
                foreach (DataRow row in dt.Rows)
                {
                    row["DiaChi"] = row["SoNha"].ToString() + " " + row["TenQuanHuyen"].ToString();
                }
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dược nào có tên như vậy.");
                    return;
                }
                frmQLDS.capnhatDS(dt);
                this.Hide();
            }

        }
    }
}
