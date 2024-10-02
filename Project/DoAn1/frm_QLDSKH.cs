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

namespace DoAn1
{
    public partial class frm_QLDSKH : Form
    {

        public frm_QLDSKH()
        {
            InitializeComponent();
        }

        string chuoiKetNoi = @"Data Source=LAPTOP-TKDRUJMP;Initial Catalog=QLKhachSan;Integrated Security=True";
        // hàm hiển thị
        private void hienthi()
        {
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            string sql = "SELECT * FROM Khachhang";
            ketNoi.Open();
            SqlCommand thucHien = new SqlCommand(sql, ketNoi);
            SqlDataReader docDuLieu = thucHien.ExecuteReader();
            int i = 0;
            while (docDuLieu.Read())
            {
                lvkhachhang.Items.Add(docDuLieu[0].ToString());
                lvkhachhang.Items[i].SubItems.Add(docDuLieu[1].ToString());
                lvkhachhang.Items[i].SubItems.Add(docDuLieu[2].ToString());
                lvkhachhang.Items[i].SubItems.Add(docDuLieu[3].ToString());
                lvkhachhang.Items[i].SubItems.Add(docDuLieu[4].ToString());
                i++;
            }
            ketNoi.Close();
        }
        // nhấn vào listview rồi đẩy dữ liệu mấy cái text
        private void click()
        {
            lvkhachhang.Items.Clear();
            hienthi();
            txt_ma.Clear();
            txt_ten.Text = "";
            cb_gt.Text = "";
            //cb_gt.DropDownStyle =ComboBoxStyle.DropDown;
            txt_cccd.Text = "";
            txt_sdt.Text = "";
            txt_timkiem.Text = "";
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void btb_boqua_Click(object sender, EventArgs e)
        {
            click();
        }
        // chạy file cái là hiển thị luôn data 
        private void frm_QLDSKH_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        //nhấn vào bảng để 
        private void lvkhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_ma.Text = lvkhachhang.SelectedItems[0].SubItems[0].Text;
                txt_ten.Text = lvkhachhang.SelectedItems[0].SubItems[1].Text;
                cb_gt.SelectedItem = lvkhachhang.SelectedItems[0].SubItems[2].Text;
                txt_cccd.Text = lvkhachhang.SelectedItems[0].SubItems[3].Text;
                txt_sdt.Text = lvkhachhang.SelectedItems[0].SubItems[4].Text;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                btn_them.Enabled = false;
            }
            catch { }


        }
        //nút sửa

        private void btn_sua_Click(object sender, EventArgs e)
        {
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            DialogResult ktra = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (ktra == DialogResult.Yes)
            {
                lvkhachhang.Items.Clear();

                string sql = @"UPDATE dbo.KhachHang SET TenKH = N'" + txt_ten.Text +
                    "', Gioitinh = N'" + cb_gt.SelectedItem +
                    "', CCCD = " + txt_cccd.Text +
                    ", SDT = '" + txt_sdt.Text +
                    "' WHERE MaKH = '" + txt_ma.Text + "'";
                ketNoi = new SqlConnection(chuoiKetNoi);
                ketNoi.Open();
                SqlCommand thucHien = new SqlCommand(sql, ketNoi);

                thucHien.ExecuteNonQuery();
                hienthi();
                ketNoi.Close();
            }
        }
        //nút thêm
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                lvkhachhang.Items.Clear();
                string sql = @"INSERT INTO dbo.KhachHang ( MaKH, TenKH, Gioitinh, CCCD, SDT ) " +
                                "VALUES ( '" + txt_ma.Text +
                                "', N'" + txt_ten.Text +
                                "', N'" + cb_gt.SelectedItem +
                                "', " + txt_cccd.Text +
                                ", '" + txt_sdt.Text + "' )";
                SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
                ketNoi.Open();
                SqlCommand thucHien = new SqlCommand(sql, ketNoi);
                thucHien.ExecuteNonQuery();
                hienthi();
                ketNoi.Close();


            }
            catch
            {
                MessageBox.Show("Đã có mã khách hàng: " + txt_ma.Text, "Thông báo!", MessageBoxButtons.OK);
                hienthi();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            lvkhachhang.Items.Clear();
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            string sql = "SELECT * FROM dbo.KhachHang WHERE MaKH LIKE '%" + txt_timkiem.Text +
               "%' OR TenKH LIKE N'%" + txt_timkiem.Text +
               "%' OR Gioitinh LIKE N'%" + txt_timkiem.Text +
               "%' OR CCCD LIKE '%" + txt_timkiem.Text +
               "%' OR SDT LIKE '%" + txt_timkiem.Text + "%'";
            ketNoi.Open();
            SqlCommand thucHien = new SqlCommand(sql, ketNoi);
            SqlDataReader docDuLieu = thucHien.ExecuteReader();
            int i = 0;
            while (docDuLieu.Read())
            {
                lvkhachhang.Items.Add(docDuLieu[0].ToString());
                lvkhachhang.Items[i].SubItems.Add(docDuLieu[1].ToString());
                lvkhachhang.Items[i].SubItems.Add(docDuLieu[2].ToString());
                lvkhachhang.Items[i].SubItems.Add(docDuLieu[3].ToString());
                lvkhachhang.Items[i].SubItems.Add(docDuLieu[4].ToString());
                i++;
            }
            ketNoi.Close();
        }
        

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult ktra = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (ktra == DialogResult.Yes)
            {
                lvkhachhang.Items.Clear();
                string sqlDeleteKH = "DELETE FROM dbo.Khachhang WHERE MaKH = '" + txt_ma.Text + "'";
                string sqlDeleteHD = "DELETE FROM dbo.Hoadon WHERE MaKH = '" + txt_ma.Text + "'";
                SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
                ketNoi.Open();
                SqlCommand thucHien = new SqlCommand(sqlDeleteKH, ketNoi);
                SqlCommand thucHienDeleteHD = new SqlCommand(sqlDeleteHD, ketNoi);
                thucHienDeleteHD.ExecuteNonQuery();
                thucHien.ExecuteNonQuery();
                ketNoi.Close();
                click();
            }
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            btn_timkiem_Click(sender, e);   
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
