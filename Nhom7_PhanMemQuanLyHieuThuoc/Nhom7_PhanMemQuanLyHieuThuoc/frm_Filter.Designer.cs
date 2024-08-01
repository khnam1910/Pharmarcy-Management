
namespace Nhom7_PhanMemQuanLyHieuThuoc
{
	partial class frm_Filter
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
			this.rdioQL = new System.Windows.Forms.RadioButton();
			this.rdioDS = new System.Windows.Forms.RadioButton();
			this.lbl_SignIn = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// rdioQL
			// 
			this.rdioQL.AutoSize = true;
			this.rdioQL.Location = new System.Drawing.Point(84, 80);
			this.rdioQL.Name = "rdioQL";
			this.rdioQL.Size = new System.Drawing.Size(74, 23);
			this.rdioQL.TabIndex = 1;
			this.rdioQL.Text = "Quản lý";
			this.rdioQL.UseVisualStyleBackColor = true;
			this.rdioQL.Click += new System.EventHandler(this.rdioQL_Click);
			// 
			// rdioDS
			// 
			this.rdioDS.AutoSize = true;
			this.rdioDS.Location = new System.Drawing.Point(164, 80);
			this.rdioDS.Name = "rdioDS";
			this.rdioDS.Size = new System.Drawing.Size(75, 23);
			this.rdioDS.TabIndex = 1;
			this.rdioDS.Text = "Dược sĩ";
			this.rdioDS.UseVisualStyleBackColor = true;
			this.rdioDS.Click += new System.EventHandler(this.rdioDS_Click);
			// 
			// lbl_SignIn
			// 
			this.lbl_SignIn.AutoSize = true;
			this.lbl_SignIn.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SignIn.Location = new System.Drawing.Point(57, 27);
			this.lbl_SignIn.Name = "lbl_SignIn";
			this.lbl_SignIn.Size = new System.Drawing.Size(216, 36);
			this.lbl_SignIn.TabIndex = 31;
			this.lbl_SignIn.Text = "Lọc Thông Tin";
			// 
			// frm_Filter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(323, 128);
			this.Controls.Add(this.lbl_SignIn);
			this.Controls.Add(this.rdioDS);
			this.Controls.Add(this.rdioQL);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_Filter";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lọc Thông Tin";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.RadioButton rdioQL;
		private System.Windows.Forms.RadioButton rdioDS;
		private System.Windows.Forms.Label lbl_SignIn;
	}
}