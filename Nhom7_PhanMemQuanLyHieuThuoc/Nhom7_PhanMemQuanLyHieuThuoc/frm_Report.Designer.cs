
namespace Nhom7_PhanMemQuanLyHieuThuoc
{
	partial class frm_Report
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Color = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_changeChart = new System.Windows.Forms.Button();
            this.cb_option = new System.Windows.Forms.ComboBox();
            this.chart_ThuocBanChay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateIn = new System.Windows.Forms.DateTimePicker();
            this.tpg_doanhthu = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Thongke = new System.Windows.Forms.Button();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_TongDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chart_DoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ThuocBanChay)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tpg_doanhthu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhThu)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(12, 22);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(311, 50);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Thống Kê";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Color
            // 
            this.pnl_Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(140)))));
            this.pnl_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Color.Location = new System.Drawing.Point(329, 12);
            this.pnl_Color.Name = "pnl_Color";
            this.pnl_Color.Size = new System.Drawing.Size(459, 67);
            this.pnl_Color.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.chart_ThuocBanChay);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 613);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Số Lượng Thuốc Bán";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btn_changeChart);
            this.groupBox4.Controls.Add(this.cb_option);
            this.groupBox4.Location = new System.Drawing.Point(346, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(416, 89);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tùy chỉnh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Loại:";
            // 
            // btn_changeChart
            // 
            this.btn_changeChart.Location = new System.Drawing.Point(314, 36);
            this.btn_changeChart.Name = "btn_changeChart";
            this.btn_changeChart.Size = new System.Drawing.Size(82, 31);
            this.btn_changeChart.TabIndex = 11;
            this.btn_changeChart.Text = "Thay đổi";
            this.btn_changeChart.UseVisualStyleBackColor = true;
            this.btn_changeChart.Click += new System.EventHandler(this.btn_changeChart_Click);
            // 
            // cb_option
            // 
            this.cb_option.FormattingEnabled = true;
            this.cb_option.Items.AddRange(new object[] {
            "Top 5 thuốc bán chạy",
            "Top 10 thuốc bán chạy",
            "Top 5 thuốc không bán chạy",
            "Top 10 thuốc không bán chạy"});
            this.cb_option.Location = new System.Drawing.Point(78, 36);
            this.cb_option.Name = "cb_option";
            this.cb_option.Size = new System.Drawing.Size(210, 27);
            this.cb_option.TabIndex = 0;
            // 
            // chart_ThuocBanChay
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_ThuocBanChay.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Chú thích";
            this.chart_ThuocBanChay.Legends.Add(legend1);
            this.chart_ThuocBanChay.Location = new System.Drawing.Point(6, 101);
            this.chart_ThuocBanChay.Name = "chart_ThuocBanChay";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Chart_Series1";
            this.chart_ThuocBanChay.Series.Add(series1);
            this.chart_ThuocBanChay.Size = new System.Drawing.Size(756, 506);
            this.chart_ThuocBanChay.TabIndex = 7;
            this.chart_ThuocBanChay.Text = "chart1";
            title1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Biểu đồ top 5 thuốc bán chạy trong tháng";
            this.chart_ThuocBanChay.Titles.Add(title1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_show);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dateIn);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 89);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống kê theo ngày";
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(234, 36);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(82, 31);
            this.btn_show.TabIndex = 6;
            this.btn_show.Text = "Thống kê";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Chọn tháng";
            // 
            // dateIn
            // 
            this.dateIn.CustomFormat = "MMMM yyyy";
            this.dateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateIn.Location = new System.Drawing.Point(84, 37);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(144, 26);
            this.dateIn.TabIndex = 7;
            // 
            // tpg_doanhthu
            // 
            this.tpg_doanhthu.Controls.Add(this.groupBox2);
            this.tpg_doanhthu.Controls.Add(this.groupBox1);
            this.tpg_doanhthu.Controls.Add(this.panel2);
            this.tpg_doanhthu.Controls.Add(this.chart_DoanhThu);
            this.tpg_doanhthu.Location = new System.Drawing.Point(4, 28);
            this.tpg_doanhthu.Name = "tpg_doanhthu";
            this.tpg_doanhthu.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_doanhthu.Size = new System.Drawing.Size(768, 613);
            this.tpg_doanhthu.TabIndex = 0;
            this.tpg_doanhthu.Text = "Doanh Thu";
            this.tpg_doanhthu.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_change);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cb_type);
            this.groupBox2.Location = new System.Drawing.Point(382, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 98);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tùy chọn";
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(263, 41);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(82, 31);
            this.btn_change.TabIndex = 11;
            this.btn_change.Text = "Thay đổi";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kiểu biểu đồ:";
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "Biểu đồ đường",
            "Biểu đồ tròn",
            "Biểu đồ cột"});
            this.cb_type.Location = new System.Drawing.Point(102, 28);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(121, 27);
            this.cb_type.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Thongke);
            this.groupBox1.Controls.Add(this.toDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fromDate);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 98);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê theo ngày";
            // 
            // btn_Thongke
            // 
            this.btn_Thongke.Location = new System.Drawing.Point(244, 41);
            this.btn_Thongke.Name = "btn_Thongke";
            this.btn_Thongke.Size = new System.Drawing.Size(82, 31);
            this.btn_Thongke.TabIndex = 6;
            this.btn_Thongke.Text = "Thống kê";
            this.btn_Thongke.UseVisualStyleBackColor = true;
            this.btn_Thongke.Click += new System.EventHandler(this.btn_Thongke_Click);
            // 
            // toDate
            // 
            this.toDate.CustomFormat = "";
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDate.Location = new System.Drawing.Point(81, 63);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(123, 26);
            this.toDate.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đến ngày:";
            // 
            // fromDate
            // 
            this.fromDate.CustomFormat = "";
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDate.Location = new System.Drawing.Point(81, 25);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(123, 26);
            this.fromDate.TabIndex = 7;
            this.fromDate.ValueChanged += new System.EventHandler(this.fromDate_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_TongDT);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(6, 561);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 46);
            this.panel2.TabIndex = 4;
            // 
            // txt_TongDT
            // 
            this.txt_TongDT.ForeColor = System.Drawing.Color.Red;
            this.txt_TongDT.Location = new System.Drawing.Point(562, 12);
            this.txt_TongDT.Name = "txt_TongDT";
            this.txt_TongDT.Size = new System.Drawing.Size(159, 26);
            this.txt_TongDT.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng doanh thu:";
            // 
            // chart_DoanhThu
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_DoanhThu.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.Title = "Chú thích";
            this.chart_DoanhThu.Legends.Add(legend2);
            this.chart_DoanhThu.Location = new System.Drawing.Point(6, 110);
            this.chart_DoanhThu.Name = "chart_DoanhThu";
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "ChartDoanhThu";
            series2.ShadowColor = System.Drawing.Color.White;
            series2.YValuesPerPoint = 4;
            this.chart_DoanhThu.Series.Add(series2);
            this.chart_DoanhThu.Size = new System.Drawing.Size(756, 445);
            this.chart_DoanhThu.TabIndex = 1;
            this.chart_DoanhThu.Text = "Chart1";
            title2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Tieude1";
            title2.Text = "Biểu đồ cột doanh thu";
            this.chart_DoanhThu.Titles.Add(title2);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpg_doanhthu);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 645);
            this.tabControl1.TabIndex = 9;
            // 
            // frm_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnl_Color);
            this.Controls.Add(this.lbl_Title);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ThongKe";
            this.Load += new System.EventHandler(this.frm_ThongKe_Load);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ThuocBanChay)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tpg_doanhthu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhThu)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.Panel pnl_Color;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tpg_doanhthu;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart_DoanhThu;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Button btn_Thongke;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txt_TongDT;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker fromDate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cb_type;
		private System.Windows.Forms.Button btn_change;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btn_show;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateIn;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart_ThuocBanChay;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btn_changeChart;
		private System.Windows.Forms.ComboBox cb_option;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker toDate;
		private System.Windows.Forms.Label label2;
	}
}