using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Nhom7_PhanMemQuanLyHieuThuoc
{
    public partial class frm_Report : Form
    {
        public string connection_string { get; set; }
        public SqlConnection sql_connection { get; set; }
        SqlDataAdapter sqlDataAdapter;
        //DataSet dataSet;
        DataTable dataTable;
        public frm_Report(string connection_string)
        {
            InitializeComponent();
            this.connection_string = connection_string;
            sql_connection = new SqlConnection(connection_string);
        }
        private void frm_ThongKe_Load(object sender, EventArgs e)
        {
            chart_DoanhThu.Visible = false;
            chart_ThuocBanChay.Visible = false;

            DateTime today = DateTime.Now;
            fromDate.Value = new DateTime(today.Year, today.Month, 1);
            toDate.Value = fromDate.Value.AddMonths(1).AddDays(-1);

            chart_DoanhThu.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart_ThuocBanChay.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
        }
        private void btn_Thongke_Click(object sender, EventArgs e)
        {
            int tongtien = 0;
            chart_DoanhThu.Visible = true;
            chart_DoanhThu.Series["ChartDoanhThu"].Points.Clear();
            chart_DoanhThu.Series["ChartDoanhThu"].LegendText = "Doanh thu";
            chart_DoanhThu.Series["ChartDoanhThu"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            chart_DoanhThu.Titles.First().Text = "Biểu đồ cột doanh thu tháng " + fromDate.Value.Month;

            for (int i = fromDate.Value.Day; i <= toDate.Value.Day; i++)
            {
                string query = string.Format("Select * from dbo.UF_DOANHTHU({0},{1},{2})", i, fromDate.Value.Month, fromDate.Value.Year);
                sqlDataAdapter = new SqlDataAdapter(query, sql_connection);
                sql_connection.Open();
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sql_connection.Close();
                chart_DoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                chart_DoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Tiền";
                chart_DoanhThu.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                tongtien += int.Parse(dataTable.Rows[0]["TONGDOANHTHU"].ToString());
                chart_DoanhThu.Series["ChartDoanhThu"].Points.AddXY("Ngày " + dataTable.Rows[0]["NGAY"], dataTable.Rows[0]["TONGDOANHTHU"]);
            }
            txt_TongDT.Text = string.Format("{0:0,0 VND}", tongtien).Replace(',', '.');
        }
        private void btn_change_Click(object sender, EventArgs e)
        {
            if (cb_type.SelectedIndex == 0)
            {
                chart_DoanhThu.Series["ChartDoanhThu"].Points.Clear();
                chart_DoanhThu.Series["ChartDoanhThu"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart_DoanhThu.Titles.First().Text = "Biểu đồ đường doanh thu tháng " + fromDate.Value.Month;
                chart_DoanhThu.Series["ChartDoanhThu"].LegendText = "Doanh thu";
                int tongtien = 0;
                for (int i = fromDate.Value.Day; i <= toDate.Value.Day; i++)
                {
                    string query = string.Format("Select * from dbo.UF_DOANHTHU({0},{1},{2})", i, fromDate.Value.Month, fromDate.Value.Year);
                    sqlDataAdapter = new SqlDataAdapter(query, sql_connection);
                    sql_connection.Open();
                    dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    sql_connection.Close();
                    chart_DoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                    chart_DoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Tiền";
                    chart_DoanhThu.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    tongtien += int.Parse(dataTable.Rows[0]["TONGDOANHTHU"].ToString());
                    chart_DoanhThu.Series["ChartDoanhThu"].Points.AddXY("Ngày " + dataTable.Rows[0]["NGAY"], dataTable.Rows[0]["TONGDOANHTHU"]);
                }
                txt_TongDT.Text = string.Format("{0:0,0 VND}", tongtien).Replace(',', '.');
            }
            else if (cb_type.SelectedIndex == 1)
            {
                chart_DoanhThu.Series["ChartDoanhThu"].Points.Clear();
                chart_DoanhThu.Series["ChartDoanhThu"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                chart_DoanhThu.Titles.First().Text = "Biểu đồ tròn doanh thu tháng " + fromDate.Value.Month;
                chart_DoanhThu.Series["ChartDoanhThu"].LegendText = "";
                int tongtien = 0;
                for (int i = fromDate.Value.Day; i <= toDate.Value.Day; i++)
                {
                    string query = string.Format("Select * from dbo.UF_DOANHTHU({0},{1},{2})", i, fromDate.Value.Month, fromDate.Value.Year);
                    sqlDataAdapter = new SqlDataAdapter(query, sql_connection);
                    sql_connection.Open();
                    dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    sql_connection.Close();
                    chart_DoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                    chart_DoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Tiền";
                    chart_DoanhThu.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    tongtien += int.Parse(dataTable.Rows[0]["TONGDOANHTHU"].ToString());
                    if (dataTable.Rows[0]["TONGDOANHTHU"].ToString()!="0")
                    {
                        chart_DoanhThu.Series["ChartDoanhThu"].Points.AddXY("Ngày " + dataTable.Rows[0]["NGAY"], dataTable.Rows[0]["TONGDOANHTHU"]);
                    }
                }
                txt_TongDT.Text = string.Format("{0:0,0 VND}", tongtien).Replace(',', '.');
            }
            else
            {
                chart_DoanhThu.Series["ChartDoanhThu"].Points.Clear();
                chart_DoanhThu.Series["ChartDoanhThu"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
                chart_DoanhThu.Titles.First().Text = "Biểu đồ cột doanh thu tháng " + fromDate.Value.Month;
                chart_DoanhThu.Series["ChartDoanhThu"].LegendText = "Doanh thu";
                int tongtien = 0;
                for (int i = fromDate.Value.Day; i <= toDate.Value.Day; i++)
                {
                    string query = string.Format("Select * from dbo.UF_DOANHTHU({0},{1},{2})", i, fromDate.Value.Month, fromDate.Value.Year);
                    sqlDataAdapter = new SqlDataAdapter(query, sql_connection);
                    sql_connection.Open();
                    dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    sql_connection.Close();
                    chart_DoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                    chart_DoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Tiền";
                    chart_DoanhThu.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    tongtien += int.Parse(dataTable.Rows[0]["TONGDOANHTHU"].ToString());
                    chart_DoanhThu.Series["ChartDoanhThu"].Points.AddXY("Ngày " + dataTable.Rows[0]["NGAY"], dataTable.Rows[0]["TONGDOANHTHU"]);
                }
                txt_TongDT.Text = string.Format("{0:0,0 VND}", tongtien).Replace(',', '.');
            }

        }
        private void fromDate_ValueChanged(object sender, EventArgs e)
        {
            if (fromDate.Value.Month != toDate.Value.Month)
            {
                toDate.Value = fromDate.Value.AddMonths(1).AddDays(-1);
            }
        }
        private void btn_show_Click(object sender, EventArgs e)
        {
            chart_ThuocBanChay.Titles.First().Text = "Biểu đồ top 5 thuốc bán chạy trong tháng";
            chart_ThuocBanChay.Visible = true;
            chart_ThuocBanChay.Series["Chart_Series1"].Points.Clear();
            chart_ThuocBanChay.Titles.First().Text += " " + dateIn.Value.Month;
            string query = string.Format("SELECT TOP 5 * FROM UF_TOP5THUOCBANCHAY({0}, {1}) AS DT ORDER BY DT.SOLUONG DESC", dateIn.Value.Month, dateIn.Value.Year);
            sqlDataAdapter = new SqlDataAdapter(query, sql_connection);
            sql_connection.Open();
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sql_connection.Close();
            chart_ThuocBanChay.ChartAreas["ChartArea1"].AxisX.Title = "Tên thuốc";
            chart_ThuocBanChay.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";
            chart_ThuocBanChay.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            for (int j = 0; j < dataTable.Rows.Count; j++)
            {
                chart_ThuocBanChay.Series["Chart_Series1"].Points.AddXY(dataTable.Rows[j]["TENTHUOC"], dataTable.Rows[j]["SOLUONG"]);
                chart_ThuocBanChay.Series["Chart_Series1"].AxisLabel = dataTable.Rows[j]["TENTHUOC"].ToString();
            }
        }

        private void btn_changeChart_Click(object sender, EventArgs e)
        {
            if (cb_option.Text != "")
            {
                string query = "";
                if (cb_option.Text == "Top 5 thuốc bán chạy")
                {
                    chart_ThuocBanChay.Titles.First().Text = "Biểu đồ top 5 thuốc bán chạy trong tháng";
                    query = string.Format("SELECT TOP 5 * FROM UF_TOP5THUOCBANCHAY({0}, {1}) AS DT ORDER BY DT.SOLUONG DESC", dateIn.Value.Month, dateIn.Value.Year);
                }
                if (cb_option.Text == "Top 10 thuốc bán chạy")
                {
                    chart_ThuocBanChay.Titles.First().Text = "Biểu đồ top 10 thuốc bán chạy trong tháng";
                    query = string.Format("SELECT TOP 10 * FROM UF_TOP5THUOCBANCHAY({0}, {1}) AS DT ORDER BY DT.SOLUONG DESC", dateIn.Value.Month, dateIn.Value.Year);
                }
                if (cb_option.Text == "Top 5 thuốc không bán chạy")
                {
                    chart_ThuocBanChay.Titles.First().Text = "Biểu đồ top 5 thuốc không bán chạy trong tháng";
                    query = string.Format("SELECT TOP 5 * FROM UF_TOP5THUOCBANCHAY({0}, {1}) AS DT ORDER BY DT.SOLUONG ASC", dateIn.Value.Month, dateIn.Value.Year);
                }
                if (cb_option.Text == "Top 10 thuốc không bán chạy")
                {
                    chart_ThuocBanChay.Titles.First().Text = "Biểu đồ top 10 thuốc không bán chạy trong tháng";
                    query = string.Format("SELECT TOP 10 * FROM UF_TOP5THUOCBANCHAY({0}, {1}) AS DT ORDER BY DT.SOLUONG ASC", dateIn.Value.Month, dateIn.Value.Year);
                }
                chart_ThuocBanChay.Visible = true;
                chart_ThuocBanChay.Series["Chart_Series1"].Points.Clear();
                chart_ThuocBanChay.Titles.First().Text += " " + dateIn.Value.Month;

                sqlDataAdapter = new SqlDataAdapter(query, sql_connection);
                sql_connection.Open();
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sql_connection.Close();
                chart_ThuocBanChay.ChartAreas["ChartArea1"].AxisX.Title = "Tên thuốc";
                chart_ThuocBanChay.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";
                chart_ThuocBanChay.ChartAreas["ChartArea1"].AxisX.Interval = 1;

                for (int j = 0; j < dataTable.Rows.Count; j++)
                {
                    chart_ThuocBanChay.Series["Chart_Series1"].Points.AddXY(dataTable.Rows[j]["TENTHUOC"], dataTable.Rows[j]["SOLUONG"]);
                    chart_ThuocBanChay.Series["Chart_Series1"].AxisLabel = dataTable.Rows[j]["TENTHUOC"].ToString();
                }
            }
        }
    }
}
