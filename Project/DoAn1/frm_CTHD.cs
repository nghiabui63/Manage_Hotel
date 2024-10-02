using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class frm_CTHD : Form
    {
        public frm_CTHD()
        {
            InitializeComponent();
        }
        string chuoiKetNoi = @"Data Source=LAPTOP-TKDRUJMP;Initial Catalog=QLKhachSan;Integrated Security=True";
        private void frm_CTHD_Load(object sender, EventArgs e)
        {
            loadmahoadon();
            loadmadv();
            loadmaphong();
            hienthi();
        }
        public void loadmahoadon() {
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            ketNoi.Open();
            String MA = "SELECT MaHD FROM Hoadon";
            SqlCommand thucthi = new SqlCommand(MA, ketNoi);
            SqlDataReader docdulieu = thucthi.ExecuteReader();
            while (docdulieu.Read())
            {
                String mahd = docdulieu["MaHD"].ToString();
                cb_hd.Items.Add(mahd);
            }
            docdulieu.Close();
            ketNoi.Close();
        }
        public void loadmadv()
        {
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            ketNoi.Open();
            String MA = "SELECT MaDV FROM Dichvu";
            SqlCommand thucthi = new SqlCommand(MA, ketNoi);
            SqlDataReader docdulieu = thucthi.ExecuteReader();
            while (docdulieu.Read())
            {
                String madv = docdulieu["MaDV"].ToString();
                cb_madv.Items.Add(madv);
            }
            docdulieu.Close();
            ketNoi.Close();
        }
        public void loadmaphong()
        {
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            ketNoi.Open();
            String MA = "SELECT Maphong FROM Phong";
            SqlCommand thucthi = new SqlCommand(MA, ketNoi);
            SqlDataReader docdulieu = thucthi.ExecuteReader();
            while (docdulieu.Read())
            {
                String maphong = docdulieu["Maphong"].ToString();
                cb_phong.Items.Add(maphong);
            }
            docdulieu.Close();
            ketNoi.Close();
        }
        public void hienthi()
        {
            SqlConnection ketNoi =new SqlConnection(chuoiKetNoi);
            ketNoi.Open();
            String sql = "select * from Chitietphieudatphong";
            SqlCommand thucthi = new SqlCommand(sql, ketNoi);
            SqlDataReader docdulieu =thucthi.ExecuteReader();
            int i = 0;
            while (docdulieu.Read())
            {
                lvcthd.Items.Add(docdulieu[0].ToString());
                lvcthd.Items[i].SubItems.Add(docdulieu[1].ToString());
                lvcthd.Items[i].SubItems.Add(docdulieu[2].ToString());
                lvcthd.Items[i].SubItems.Add(docdulieu[3].ToString());
                lvcthd.Items[i].SubItems.Add(docdulieu[4].ToString());
                lvcthd.Items[i].SubItems.Add(docdulieu[5].ToString());
                i++;
            }
            ketNoi.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            lvcthd.Items.Clear();
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            ketNoi.Open();
            String sql = @"INSERT INTO dbo.Chitietphieudatphong ( MaCTPDP,Ngayden,Ngaytra,MaDV,Maphong,MaHD ) " +
                                "VALUES ( '" + txt_ma.Text +
                                "', '" + dateden.Value.ToString("yyyy/MM/dd") +
                                "', '" + datetra.Value.ToString("yyyy/MM/dd") +
                                "', '" + cb_madv.Text +
                                "', '" + cb_phong.Text +
                                "', '" + cb_hd.Text + "' )";
           SqlCommand thucthi = new SqlCommand(sql, ketNoi);
           thucthi.ExecuteNonQuery();
            hienthi();
            ketNoi.Close();
        }

        private void lvcthd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            txt_ma.Enabled =false;
            txt_ma.Text = lvcthd.SelectedItems[0].SubItems[0].Text;
            dateden.Text = lvcthd.SelectedItems[0].SubItems[1].Text;
            datetra.Text = lvcthd.SelectedItems[0].SubItems[2].Text;
            cb_madv.SelectedItem = lvcthd.SelectedItems[0].SubItems[3].Text;
            cb_phong.SelectedItem = lvcthd.SelectedItems[0].SubItems[4].Text;
            cb_hd.SelectedItem = lvcthd.SelectedItems[0].SubItems[5].Text;
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
        
        private void btn_sua_Click(object sender, EventArgs e)
        {
            /*
            loadmadv();
            loadmahoadon();
            loadmaphong();
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            DialogResult ktra = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (ktra == DialogResult.Yes)
            {
                lvcthd.Items.Clear();

                string sql = @"UPDATE dbo.Chitietphieudatphong SET Ngayden = '" + datetra.Value.ToString("yyyy/MM/dd") +
                    "', Ngaytra = '" + datetra.Value.ToString("yyyy/MM/dd") +
                    "', MaDV = '" + cb_madv.Text +
                    "', Maphong = '" + cb_phong.Text +
                    "', MaHD = '" + cb_hd.Text +
                    "' WHERE MaCTPDP = '" + txt_ma.Text + "'";
                ketNoi = new SqlConnection(chuoiKetNoi);
                ketNoi.Open();
                SqlCommand thucHien = new SqlCommand(sql, ketNoi);
                thucHien.ExecuteNonQuery();
                hienthi();
                ketNoi.Close();
            
            }
        */
        }
    }
}
