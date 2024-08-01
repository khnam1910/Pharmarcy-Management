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
using System.Web;

namespace Nhom7_PhanMemQuanLyHieuThuoc
{
	public partial class frm_Bill : Form
	{
		public string MaNV { get; set; }
		public string connection_string { get; set; }
        public string id { get; set; }

		SqlConnection conn;
		SqlCommand cmd;
		SqlDataAdapter adapter;
		SqlCommandBuilder cb;
		DataSet ds;
		public frm_Bill(string id, string connection_string)
		{
			InitializeComponent();
			this.connection_string = connection_string;
            this.id = id;
		}

		private void rdo_ChiTietHoaDon_CheckedChanged(object sender, EventArgs e)
		{

		}
        DataView DGVHoaDon ;
        private void frm_Bill_Load(object sender, EventArgs e)
        {
            MaNV = id;
            lbl_MaNV.Text = id;
			conn = new SqlConnection(connection_string);
			cmd = new SqlCommand("", conn);
			adapter = new SqlDataAdapter(cmd);
			cb = new SqlCommandBuilder(adapter);
			ds = new DataSet();
			// load nhan vien
			cmd.CommandText = "Select * from tbl_KhachHang";
			adapter.Fill(ds, "KhachHang");
			cbx_KhachHang.DataSource = ds.Tables["KhachHang"];
			cbx_KhachHang.DisplayMember = "MaKH";
            cbx_KhachHang.ValueMember = "MaKH";
			// load san pham
			cmd.CommandText = "Select * from tbl_CTThuoc";
			adapter.Fill(ds, "Thuoc");
			cbx_MaThucDon.DataSource = ds.Tables["Thuoc"];
			cbx_MaThucDon.DisplayMember = "TenSP";
			cbx_MaThucDon.ValueMember = "MaSP";
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["Thuoc"].Columns[0];
            ds.Tables["Thuoc"].PrimaryKey = key;
            // load hóa đơn
            cmd.CommandText = "Select * from tbl_HoaDon where MaDuocSi ='"+MaNV+"'";
			adapter.Fill(ds, "HoaDon");
			cbx_MaHoaDon.DataSource = ds.Tables["HoaDon"];
            cbx_MaHoaDon.ValueMember = "MaHD";
			cbx_MaHoaDon.DisplayMember = "MaHD";
			dgv_HoaDon.DataSource = ds.Tables["HoaDon"];
            key[0] = ds.Tables["HoaDon"].Columns[1];
            ds.Tables["HoaDon"].PrimaryKey = key;
            DGVHoaDon = new DataView(ds.Tables["HoaDon"]);
          

            // Bind the filtered data to dgv_ChiTietHoaDon
            dgv_ChiTietHoaDon.DataSource = DGVHoaDon.ToTable();
            // load chi tiết hóa đơn
            cmd.CommandText = "Select MaCTHD,tbl_CTHoaDon.MaHD,MaSP,SoLuong,DonGia from tbl_CTHoaDon,tbl_HoaDon where tbl_CTHoaDon.MaHD=tbl_HoaDon.MaHD and MaDuocSi ='" + MaNV+"'";
			adapter.Fill(ds, "ChiTietHoaDon");
            key = new DataColumn[1];
            key[0] = ds.Tables["ChiTietHoaDon"].Columns[0];
            ds.Tables["ChiTietHoaDon"].PrimaryKey = key;
            dgv_ChiTietHoaDon.DataSource = ds.Tables["ChiTietHoaDon"];
            dgv_ChiTietHoaDon.ClearSelection();
            dgv_HoaDon.ClearSelection();
            cbx_MaThucDon.SelectedIndex = -1;
            cbx_MaHoaDon.SelectedIndex = -1;
        }
        public void SelectRow(string MaHD)
        {
            foreach(DataGridViewRow row in dgv_HoaDon.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(MaHD))
                {
                    row.Selected = true;
                    return;
                }
            }
        }
        // Hàm xử lý nút thêm dữ liệu
        private void btn_Insert_Click_1(object sender, EventArgs e)
        {
            if (rdo_HoaDon.Checked == true)
            {
                // Lấy ra mã hóa đơn tiếp theo
              
                // thêm vào hóa đơn
                DataRow newrow = ds.Tables["HoaDon"].NewRow();
                newrow[0] = 1;
                newrow[1] = "HD";
                newrow[2] = lbl_MaNV.Text;
                newrow[3] = dtp_NgayDat.Value.ToString("yyyy-MM-dd");
                newrow[4] = 0;
                newrow[5] = cbx_KhachHang.SelectedValue.ToString();
                ds.Tables["HoaDon"].Rows.Add(newrow);

              
                cmd.CommandText = "Select * from tbl_HoaDon where  MaDuocSi ='" + MaNV + "'";
                cb = new SqlCommandBuilder(adapter);
                adapter.Update(ds, "HoaDon");
                //tbx_MaDonHang.Text = MaHD;
                conn.Open();
                cmd.CommandText = "Select top 1 SoThuTu from tbl_HoaDon Order By SoThuTu Desc";
                int stt = (int)cmd.ExecuteScalar();
                conn.Close();
                string MaHD = "HD" + stt.ToString("000");
                int tongSoDong = dgv_HoaDon.RowCount-1;
                dgv_HoaDon.Rows[tongSoDong].Cells[0].Value = stt;
                dgv_HoaDon.Rows[tongSoDong].Cells[1].Value = MaHD;
                //SelectRow(MaHD);
                //dgv_HoaDon.SelectedRows[0].Cells[0].Value = stt;
                //dgv_HoaDon.SelectedRows[0].Cells[1].Value = MaHD;
                cmd.CommandText = "Select * from tbl_HoaDon where  MaDuocSi ='" + MaNV + "'";
                cb = new SqlCommandBuilder(adapter);
                adapter.Update(ds, "HoaDon");
                cbx_MaHoaDon.SelectedValue = MaHD;
                MessageBox.Show("Bạn thêm thành công", "Thông báo");
            }
            // thêm chi tiết hóa đơn
            else if (rdo_ChiTietHoaDon.Checked == true)
            {
                // Kiểm tra số lượng đã nhập chưa và có phải là số
                if (checkNumberAndRequrie() == true)
                {
                    if (cbx_MaHoaDon.SelectedItem == null)
                    {
                        MessageBox.Show("Vui lòng chọn hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (cbx_MaThucDon.SelectedItem== null)
                    {
                        MessageBox.Show("Vui lòng chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string MaHD = cbx_MaHoaDon.SelectedValue.ToString();
                    string MaSP = cbx_MaThucDon.SelectedValue.ToString();
                    string MaCT = MaHD + "_" + MaSP;
                    int soluongMua = int.Parse(tbx_SoLuong.Text);
                    DataRow[] Thuoc = ds.Tables["Thuoc"].Select("MaSP ='" + MaSP + "'");
                    int soluongTon = int.Parse(Thuoc[0][5].ToString());
                  
                    if (IsExit(MaCT) == true)
                    {
                        MessageBox.Show("Đã có sản phẩm trong hóa đơn", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (soluongMua > soluongTon)
                    {
                        MessageBox.Show("Số lượng trong kho chỉ còn " + soluongTon + " thuốc");
                        return;
                    }
                    // thêm chi tiết hóa đơn
                    DataRow row = ds.Tables["ChiTietHoaDon"].NewRow();
                    row[0] = MaCT;
                    row[1] = MaHD;
                    row[2] = MaSP;
                    row[3] = int.Parse(tbx_SoLuong.Text);
                    row[4] = int.Parse(tbx_DonGia.Text);
                    ds.Tables["ChiTietHoaDon"].Rows.Add(row);
                    cmd.CommandText = "Select * from tbl_CTHoaDon";
                    cb = new SqlCommandBuilder(adapter);
                    adapter.Update(ds, "ChiTietHoaDon");
                    int tt = int.Parse(tinhThanhTien(MaHD));
                    // Cập nhật lại thành tiền
                    DataRow hoadon = ds.Tables["HoaDon"].Rows.Find(MaHD);
                    hoadon[4] = tt;
                    cmd.CommandText = "Select * from tbl_HoaDon";
                    cb = new SqlCommandBuilder(adapter);
                    adapter.Update(ds, "HoaDon");
                  
                    tbx_ThanhTien.Text = tt.ToString();
                    // Cập nhật lại số lượng của thuốc
                    Thuoc[0][5] = (int)Thuoc[0][5] - soluongMua;
                    cmd.CommandText = "Select * from tbl_CTThuoc";
                    cb = new SqlCommandBuilder(adapter);
                    adapter.Update(ds, "Thuoc");
                   
                    viewCTHoaDonCuaHoaDon(MaHD);
                    MessageBox.Show("Bạn thêm thành công", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn check box", "Nhắc nhở");
            }
        }
        // Hàm xử lý nút cập nhật
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (rdo_HoaDon.Checked == true)
            {
               
                if (tbx_MaDonHang.Text.Count() != 0)
                {
                    string MaHD = tbx_MaDonHang.Text;
                    DataRow update = ds.Tables["HoaDon"].Rows.Find(MaHD);
                    if (update != null)
                    {
                        // cập nhật
                        update[3] = dtp_NgayDat.Value.ToString();
                        update[5] = cbx_KhachHang.SelectedValue.ToString();
                        
            
                        // luu xong CSDL
                        cmd.CommandText = "Select * from tbl_HoaDon ";
                        cb = new SqlCommandBuilder(adapter);
                        adapter.Update(ds, "HoaDon");
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn hóa đơn", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (rdo_ChiTietHoaDon.Checked)
            {
                if (cbx_MaHoaDon.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cbx_MaThucDon.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string MaHD = cbx_MaHoaDon.SelectedValue.ToString();
                string MaSP = cbx_MaThucDon.SelectedValue.ToString();
                string MaCTHD = MaHD + "_" + MaSP;
                int slCu =0;
                if (IsExit(MaCTHD) == false)
                {
                    MessageBox.Show("Chưa có sản phẩm trong hóa đơn", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (checkNumberAndRequrie() == false)
                    return;
                else
                {
                    // cập nhật số lượng và đơn giá mới
                    DataRow row = ds.Tables["ChiTietHoaDon"].Rows.Find(MaCTHD);
                    slCu = (int)row[3];
                   
                    DataRow thuoc = ds.Tables["Thuoc"].Rows.Find(MaSP);
                    int soluong = (int)thuoc[5];
                    soluong = soluong  + slCu;
                    int soluongmoi = int.Parse(tbx_SoLuong.Text);
                    // Kiểm tra trong kho có đủ thuốc
                    if(soluong<soluongmoi)
                    {
                        MessageBox.Show("Kho chỉ còn " + soluong + " thuốc");
                        return;
                    }
                    row[3] = int.Parse(tbx_SoLuong.Text);
                    row[4] = int.Parse(tbx_DonGia.Text);
                    // lưu xuống cơ sở dữ liệu
                    if (row.RowState == DataRowState.Modified)
                    {
                        cmd.CommandText = "Select * from tbl_CTHoaDon";
                        cb = new SqlCommandBuilder(adapter);
                        adapter.Update(ds, "ChiTietHoaDon");
                    }
                    // cập nhật lại đơn giá hóa đơn
                    DataRow[] hoadon = ds.Tables["HoaDon"].Select("MaHD ='" + MaHD + "'");
                    hoadon[0][4] = int.Parse(tinhThanhTien(MaHD));
                    cmd.CommandText = "Select * from tbl_HoaDon";
                    cb = new SqlCommandBuilder(adapter);
                    adapter.Update(ds, "HoaDon");
                    // Cập nhật lại thuốc

                    thuoc[5] = soluong-soluongmoi;
                    cmd.CommandText = "Select * from tbl_CTThuoc";
                    cb = new SqlCommandBuilder(adapter);
                    adapter.Update(ds, "Thuoc");
                    tbx_ThanhTien.Text = tinhThanhTien(MaHD);
                    viewCTHoaDonCuaHoaDon(MaHD);
                    MessageBox.Show("Cập nhật thành công");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn check box", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        // Hàm xử lý nút xóa
        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            if (rdo_HoaDon.Checked == true)
            {
                if(tbx_MaDonHang.Text.Length ==0)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string MaHD = tbx_MaDonHang.Text;
                DataRow[] update = ds.Tables["HoaDon"].Select("MaHD = '" + MaHD + "'");
                if(update.Length ==0)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn này", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }    
                // Xoa chi tiet hoa don
            
                dgv_HoaDon.ClearSelection();
                dgv_ChiTietHoaDon.ClearSelection();
                DataRow[] delCTHD = ds.Tables["ChiTietHoaDon"].Select("MaHD = '" + MaHD + "'");
                int sl = delCTHD.Length;
               
                for (int i = 0; i < sl; i++)
                {
                    string MaSP = delCTHD[i][2].ToString();
                    // tính lại thuốc
                    DataRow thuoc  = ds.Tables["Thuoc"].Rows.Find(MaSP); 
                    int sltru = (int)delCTHD[i][3] + int.Parse(thuoc[5].ToString());
                    thuoc[5] = sltru;
                    delCTHD[i].Delete();
             
                    cmd.CommandText = "Select * from tbl_CTThuoc";
                    cb = new SqlCommandBuilder(adapter);
                    adapter.Update(ds, "Thuoc");
                }
                cmd.CommandText = "Select * from tbl_CTHOADON";
                cb = new SqlCommandBuilder(adapter);
                adapter.Update(ds, "ChiTietHoaDon");
           
               // xoa hoa don
                if (update.Length > 0)
                {
                    // cập nhật
                    update[0].Delete();
                    //update[0].AcceptChanges();
                }

                cmd.CommandText = "Select * from tbl_HOADON";
                cb = new SqlCommandBuilder(adapter);
                adapter.Update(ds, "HOADON");
               
           

                dgv_HoaDon.ClearSelection();
                dgv_ChiTietHoaDon.ClearSelection();
                viewCTHoaDonCuaHoaDon("a");
                MessageBox.Show("Xóa hóa đơn thành công", "Thông báo");
            }
            else if (rdo_ChiTietHoaDon.Checked == true)
            {
                if (cbx_MaHoaDon.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cbx_MaThucDon.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                string MaHD = cbx_MaHoaDon.SelectedValue.ToString();
                string MaSP = cbx_MaThucDon.SelectedValue.ToString();
                // xóa chi tiết hóa đơn
              
                DataRow[] delCTHD = ds.Tables["ChiTietHoaDon"].Select("MaHD = '" + MaHD + "' and MaSP='" +MaSP+ "'");
                if(delCTHD.Length == 0 )
                {
                    MessageBox.Show("Không có sản phẩm này trong hóa đơn", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int sl = delCTHD.Length;
                int sltru=0;
                for (int i = 0; i < sl; i++)
                {
                    sltru = int.Parse(delCTHD[i][3].ToString());
                    delCTHD[i].Delete();
                }
                cmd.CommandText = "Select * from tbl_CTHOADON";
                cb = new SqlCommandBuilder(adapter);
                adapter.Update(ds, "ChiTietHoaDon");
                viewCTHoaDonCuaHoaDon(MaHD);
                tbx_ThanhTien.Text = tinhThanhTien(MaHD);
            
                // cập nhật lại thành tiền hóa đơn
       
                DataRow[] hoadon = ds.Tables["HoaDon"].Select("MaHD ='" + MaHD + "'");
                hoadon[0][4] = int.Parse(tinhThanhTien(MaHD));
                
                cmd.CommandText = "Select * from tbl_HoaDon";
                cb = new SqlCommandBuilder(adapter);
                adapter.Update(ds, "HoaDon");
                // cap nhat lai thuoc
         
                DataRow[] thuoc = ds.Tables["Thuoc"].Select("MaSP = '" + MaSP + "'");
                thuoc[0][5] = (int)thuoc[0][5] + sltru;
         
                cmd.CommandText = "Select * from tbl_CTThuoc";
                cb = new SqlCommandBuilder(adapter);
                adapter.Update(ds, "Thuoc");
               
                viewCTHoaDonCuaHoaDon(MaHD);
                MessageBox.Show("Xóa chi tiết hóa đơn thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn check box", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        // Hàm xử lý nút tìm kiếm
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (rdo_HoaDon.Checked == true)
            {
                if (tbx_MaDonHang.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập hóa đơn", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string MaHD = tbx_MaDonHang.Text;
                foreach (DataGridViewRow row in dgv_HoaDon.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(MaHD))
                    {
                        row.Selected = true;
                        return;
                    }

                }
                MessageBox.Show("Không tìm thấy hóa đơn bạn cần tìm", "Thông báo");
                return;
            }
            else if (rdo_ChiTietHoaDon.Checked == true)
            {
                if (cbx_MaHoaDon.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cbx_MaThucDon.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string MaHD = cbx_MaHoaDon.SelectedValue.ToString();
                string MaSP = cbx_MaThucDon.SelectedValue.ToString();
                if (MaHD == null || MaSP == null)
                {
                    MessageBox.Show("Vui lòng kiểm tra mã hóa đơn hoặc mã sản phẩm", "Nhắc nhở");
                }
                foreach (DataGridViewRow row in dgv_ChiTietHoaDon.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(MaHD) && row.Cells[2].Value.ToString().Equals(MaSP))
                    {
                        row.Selected = true;

                        return;
                    }

                }
                MessageBox.Show("Không tìm thấy chi tiết hóa đơn bạn cần tìm", "Thông báo");
                return;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn check box", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        // Hàm bổ trợ
        // kiểm tra số lượng phải là số và bặt buộc nhập
        public bool checkNumberAndRequrie()
		{
			if (tbx_SoLuong.Text.Length == 0)
			{
				MessageBox.Show("Không được bỏ trống số lượng");
				return false;
			}
			int k ;
			bool c = int.TryParse(tbx_SoLuong.Text,out k);
			if (c == false) {
				MessageBox.Show("Số lượng phải là số");
				return false;
			}
			if (k ==0)
			{
				MessageBox.Show("Số lượng phải lớn hơn 0");
				return false;
			}	
			return true;
		}
        // hàm tính thành tiền của hóa đơn
        public string tinhThanhTien(string MaHD)
        {
            int tt = 0;
            foreach (DataRow row in ds.Tables["ChiTietHoaDon"].Rows)
            {
                if (row[1].ToString().Equals(MaHD))
                {

                    int k = int.Parse(row[3].ToString()) * int.Parse(row[4].ToString());
                    tt = tt + k;
                }

            }
            return tt.ToString();
        }
        // Hàm kiểm tra tồn tại của chi tiết hóa đơn
        public bool IsExit(string check)
        {
            DataRow[] row = ds.Tables["ChiTietHoaDon"].Select("MaCTHD ='" + check + "'");
            if (row.Length > 0)
            {
                return true;
            }
            return false;
        }

        public void lamMoiDuLieu(string name,string query)
        {
            ds.Tables[name].Clear();
            cmd.CommandText = query;
            adapter.Fill(ds, name);
        }
        // hàm binding hóa đơn lên text box khi click
        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_MaDonHang.Text = dgv_HoaDon.SelectedRows[0].Cells[1].Value.ToString();
            DateTime time = Convert.ToDateTime(dgv_HoaDon.SelectedRows[0].Cells[3].Value);
            dtp_NgayDat.Value = time;
            tbx_ThanhTien.DataBindings.Clear();
            tbx_ThanhTien.DataBindings.Add("Text", dgv_HoaDon.DataSource, "TongTien");
            cbx_KhachHang.DataBindings.Clear();
            string MaKH = dgv_HoaDon.SelectedRows[0].Cells[5].Value.ToString();
            cbx_KhachHang.SelectedValue = MaKH;
            viewCTHoaDonCuaHoaDon(tbx_MaDonHang.Text);
        }
        // hàm binding giá bán của thuốc lên textbox giá bán
        private void cbx_MaThucDon_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbx_DonGia.DataBindings.Clear();
            tbx_DonGia.DataBindings.Add("Text", cbx_MaThucDon.DataSource, "GiaBan");
        }
        // hàm view chi tiết của 1 hóa đơn
        public void viewCTHoaDonCuaHoaDon(string MaHD)
        {
            if (MaHD != "")
            {
                    // Filter the ChiTietHoaDon DataTable based on the selected HoaDon ID
                    DataView dvChiTietHoaDon = new DataView(ds.Tables["ChiTietHoaDon"]);
                    dvChiTietHoaDon.RowFilter = "MaHD = '" + MaHD + "'";

                    // Bind the filtered data to dgv_ChiTietHoaDon
                    dgv_ChiTietHoaDon.DataSource = dvChiTietHoaDon.ToTable();
                    dgv_ChiTietHoaDon.ClearSelection();
            }
        }
        // hàm xử lý nút làm mới
        private void btn_Filter_Click(object sender, EventArgs e)
        {
            cbx_MaHoaDon.DataBindings.Clear();
            cbx_MaThucDon.DataBindings.Clear();
            dtp_NgayDat.DataBindings.Clear();
            tbx_ThanhTien.DataBindings.Clear();
            tbx_SoLuong.DataBindings.Clear();
            cbx_KhachHang.DataBindings.Clear();
            tbx_DonGia.DataBindings.Clear();
            tbx_MaDonHang.Text = "";
            tbx_SoLuong.Text = string.Empty;
            tbx_ThanhTien.Text = string.Empty;
            dgv_ChiTietHoaDon.DataSource = null;
            dgv_ChiTietHoaDon.DataSource = ds.Tables["ChiTietHoaDon"];
            dgv_ChiTietHoaDon.ClearSelection();
            dgv_HoaDon.ClearSelection();
            cbx_MaThucDon.SelectedItem = null;
            cbx_MaHoaDon.SelectedItem = null;
        }
        // hàm binding dữ liệu của chi tiết hóa đơn lên text box
        private void dgv_ChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_ChiTietHoaDon.SelectedRows.Count == 0)
                return;
            cbx_MaHoaDon.SelectedValue = dgv_ChiTietHoaDon.SelectedRows[0].Cells[1].Value.ToString();
            cbx_MaThucDon.SelectedValue = dgv_ChiTietHoaDon.SelectedRows[0].Cells[2].Value.ToString();
            int sl = (int) dgv_ChiTietHoaDon.SelectedRows[0].Cells[3].Value ;
            tbx_SoLuong.Text = sl.ToString();
            tbx_DonGia.Text = dgv_ChiTietHoaDon.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}


