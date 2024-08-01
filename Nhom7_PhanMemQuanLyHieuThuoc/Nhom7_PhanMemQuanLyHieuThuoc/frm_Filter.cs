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
    public partial class frm_Filter : Form
    {

        public string conStr = Properties.Settings.Default.conStr;
        public frm_Account frmQLDS;
        public frm_Filter(frm_Account frmQLDS, string connection_string)
        {
            this.frmQLDS = frmQLDS;
            this.conStr = connection_string;
            InitializeComponent();
  
        }
        private void rdioQL_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string sql = "sp_timTheoVaiTro";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@VaiTro", SqlDbType.NVarChar).Value = rdioQL.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lọc quản lý: " + ex.Message);
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
                    MessageBox.Show("Không có quản lý.");
                    return;
                }
                frmQLDS.capnhatDS(dt);
                this.Hide();

            }
        }

        private void rdioDS_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string sql = "sp_timTheoVaiTro";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@VaiTro", SqlDbType.NVarChar).Value = rdioDS.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lọc dược sĩ: " + ex.Message);
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
                    MessageBox.Show("Không có dược sĩ.");
                    return;
                }
                frmQLDS.capnhatDS(dt);
                this.Hide();
            }
        }
    }
}
