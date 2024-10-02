using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class frm_QLNV : Form
    {
        public frm_QLNV()
        {
            InitializeComponent();
        }
        string chuoiKetNoi = @"Data Source=LAPTOP-TKDRUJMP;Initial Catalog=QLKhachSan;Integrated Security=True";

        private void frm_QLNV_Load(object sender, EventArgs e)
        {
            hienthi();

        }
        private void hienthi()
        {
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            string sql = "SELECT * FROM Nhanvien";
            ketNoi.Open();
            SqlCommand thucHien = new SqlCommand(sql, ketNoi);
            SqlDataReader docDuLieu = thucHien.ExecuteReader();
            int i = 0;
            while (docDuLieu.Read())
            {
                lvnhanvien.Items.Add(docDuLieu[0].ToString());
                lvnhanvien.Items[i].SubItems.Add(docDuLieu[1].ToString());
                lvnhanvien.Items[i].SubItems.Add(docDuLieu[2].ToString());
                lvnhanvien.Items[i].SubItems.Add(docDuLieu[3].ToString());
                lvnhanvien.Items[i].SubItems.Add(docDuLieu[4].ToString());
                lvnhanvien.Items[i].SubItems.Add(docDuLieu[5].ToString());
                lvnhanvien.Items[i].SubItems.Add(docDuLieu[6].ToString());
                lvnhanvien.Items[i].SubItems.Add(docDuLieu[7].ToString());
                lvnhanvien.Items[i].SubItems.Add(docDuLieu[8].ToString());
                lvnhanvien.Items[i].SubItems.Add(docDuLieu[9].ToString());
                i++;
            }
            ketNoi.Close();
             
        }
        

        private void lvnhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_ma.Text = lvnhanvien.SelectedItems[0].SubItems[0].Text;
                txt_ten.Text = lvnhanvien.SelectedItems[0].SubItems[1].Text;
                cb_gt.SelectedItem = lvnhanvien.SelectedItems[0].SubItems[2].Text;
                txt_cccd.Text = lvnhanvien.SelectedItems[0].SubItems[3].Text;
                txt_sdt.Text = lvnhanvien.SelectedItems[0].SubItems[4].Text;
                txt_noisinh.Text = lvnhanvien.SelectedItems[0].SubItems[5].Text;
                txt_diachi.Text = lvnhanvien.SelectedItems[0].SubItems[6].Text;
                txt_luongh.Text = lvnhanvien.SelectedItems[0].SubItems[7].Text;
                txt_sogio.Text = lvnhanvien.SelectedItems[0].SubItems[8].Text;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                btn_them.Enabled = false;

            }
            catch { }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
          //  try
           // {
                lvnhanvien.Items.Clear();
                string sql = @"INSERT INTO dbo.Nhanvien ( MaNV, TenNV, Gioitinh, CCCD, SDT,Noisinh,Diachi,Luong1h,Sogio ) " +
                                "VALUES ( '" + txt_ma.Text +
                                "', N'" + txt_ten.Text +
                                "', N'" + cb_gt.SelectedItem +
                                "', " + txt_cccd.Text +
                                "', " + txt_sdt.Text +
                                "', N" + txt_noisinh.Text +
                                "', N" + txt_diachi.Text +
                                "', " + txt_luongh.Text +
                                "', " + txt_sogio.Text + "' )";
                SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
                ketNoi.Open();
                SqlCommand thucHien = new SqlCommand(sql, ketNoi);
                thucHien.ExecuteNonQuery();
                hienthi();
                ketNoi.Close();
          /*  }
            catch
            {
                MessageBox.Show("Đã có mã nhân viên: " + txt_ma.Text, "Thông báo!", MessageBoxButtons.OK);
                hienthi();
            }*/
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            click();
            hienthi();
        }
        private void click()
        {
            lvnhanvien.Items.Clear();
            txt_ma.Text = "";
            txt_ten.Text = "";
            cb_gt.Text = "";
            txt_cccd.Text = "";
            txt_sdt.Text = "";
            txt_noisinh.Text = "";
            txt_diachi.Text = "";
            txt_luongh.Text = "";
            txt_sogio.Text = "";
            txt_timkiem.Text = "";
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            lvnhanvien.Items.Clear();
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            string sql = "SELECT * FROM dbo.Nhanvien WHERE MaNV LIKE '%" + txt_timkiem.Text +
               "%' OR TenNV LIKE N'%" + txt_timkiem.Text +
               "%' OR Gioitinh LIKE N'%" + txt_timkiem.Text +
               "%' OR CCCD LIKE '%" + txt_timkiem.Text +
                "%' OR SDT LIKE '%" + txt_timkiem.Text +
                 "%' OR Luong1h LIKE '%" + txt_timkiem.Text +
                 "%' OR Noisinh LIKE N'%" + txt_timkiem.Text +
               "%' OR Diachi LIKE N'%" + txt_timkiem.Text + "%'";
            ketNoi.Open();
            SqlCommand thucHien = new SqlCommand(sql, ketNoi);
            SqlDataReader docDuLieu = thucHien.ExecuteReader();
            int i = 0;
            while (docDuLieu.Read())
            {
                lvnhanvien.Items.Add(docDuLieu[0].ToString());
                lvnhanvien.Items[i].SubItems.Add(docDuLieu[1].ToString());
                lvnhanvien.Items[i].SubItems.Add(docDuLieu[2].ToString());
                lvnhanvien.Items[i].SubItems.Add(docDuLieu[3].ToString());
                lvnhanvien.Items[i].SubItems.Add(docDuLieu[4].ToString());
                lvnhanvien.Items[i].SubItems.Add(docDuLieu[5].ToString());
                lvnhanvien.Items[i].SubItems.Add(docDuLieu[6].ToString());
                lvnhanvien.Items[i].SubItems.Add(docDuLieu[7].ToString());
                lvnhanvien.Items[i].SubItems.Add(docDuLieu[8].ToString());
                lvnhanvien.Items[i].SubItems.Add(docDuLieu[9].ToString());
                i++;
            }
            ketNoi.Close();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            btn_timkiem_Click(sender, e);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }
    }
}
