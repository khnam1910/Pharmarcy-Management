using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom7_PhanMemQuanLyHieuThuoc
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frm_SignIn());
			//Application.Run(new frm_Medicine("Data Source = LAPTOP-AS0DLKGN\\COSMOTORE; Initial Catalog = dtb_QuanLyHieuThuoc; Integrated Security = True"));
		}
	}
}
