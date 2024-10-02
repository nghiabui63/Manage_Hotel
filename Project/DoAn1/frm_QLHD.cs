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
    public partial class frm_QLHD : Form
    {
        public frm_QLHD()
        {
            InitializeComponent();
        }

        string chuoiKetNoi = @"Data Source=LAPTOP-TKDRUJMP;Initial Catalog=QLKhachSan;Integrated Security=True";

        private void frm_QLHD_Load(object sender, EventArgs e)
        {
            loadmakh();
            loadmanv();
            updatezodata();
            loadlai();
            
        }

        //chưa sử dụng đến
        private void hienthi()
        {
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            string sql = "select H.MaHD ,H.ngaylap,H.MaNV,H.MaKH,SUM(P.Gia + D.Gia) AS Tongtien" +
                " from Hoadon H " +
                " join Chitietphieudatphong C ON H.MaHD = C.MaHD " +
                " join Phong P ON C.MaPhong = P.MaPhong " +
                " join DichVu D ON C.MaDV = D.MaDV " +
                " group by H.MaHD,H.ngaylap,H.MaNV,H.MaKH"; 
            ketNoi.Open();
            SqlCommand thucHien = new SqlCommand(sql, ketNoi);
            SqlDataReader docdulieu = thucHien.ExecuteReader();
            int i = 0;
            while (docdulieu.Read())
            {
                lvhoadon.Items.Add(docdulieu[0].ToString());
                lvhoadon.Items[i].SubItems.Add(docdulieu[1].ToString());
                lvhoadon.Items[i].SubItems.Add(docdulieu[2].ToString());
                lvhoadon.Items[i].SubItems.Add(docdulieu[3].ToString());
                lvhoadon.Items[i].SubItems.Add(docdulieu[4].ToString());
                i++;
            }
            ketNoi.Close();

        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
                lvhoadon.Items.Clear();
                updatezodata();
                txt_ma.Clear();
                cb_kh.Text = "";
                cb_nv.Text = "";
                date.Text = "";
                txt_timkiem.Text = "";
                btn_them.Enabled = true;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
            
        }
        

        private void loadmakh()
        {
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            ketNoi.Open();
            String MA = "SELECT MaKH FROM Khachhang";
            SqlCommand thucthi = new SqlCommand(MA, ketNoi);
            SqlDataReader docdulieu = thucthi.ExecuteReader();
            while (docdulieu.Read())
            {
                String makh = docdulieu["MaKH"].ToString();
                cb_kh.Items.Add(makh);
            }
            docdulieu.Close();
            ketNoi.Close();
        }
        private void loadmanv()
        {
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            ketNoi.Open();
            String MA = "SELECT MaNV FROM Nhanvien";
            SqlCommand thucthi = new SqlCommand(MA, ketNoi);
            SqlDataReader docdulieu = thucthi.ExecuteReader();
            while (docdulieu.Read())
            {
                String makh = docdulieu["MaNV"].ToString();
                cb_nv.Items.Add(makh);
            }
            docdulieu.Close();
            ketNoi.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            ketNoi.Open();
            lvhoadon.Items.Clear();
                string sql = @"INSERT INTO dbo.Hoadon ( MaHD,ngaylap,MaNV,MaKH,Tongtien ) " +
                                "VALUES ( '" + txt_ma.Text +
                                "', '" + date.Value.ToString("yyyy/MM/dd") +
                                "', N'" + cb_nv.Text+
                                "', N'" + cb_kh.Text +
                                "', '" + 0 + "' )";
                
                SqlCommand thucHien = new SqlCommand(sql, ketNoi);
                thucHien.ExecuteNonQuery();
                loadlai();
                ketNoi.Close();
        }
        private void updatezodata()
        {
            SqlConnection ketNoi =  new SqlConnection (chuoiKetNoi);
            ketNoi.Open();
            String sqlupdate = "UPDATE Hoadon" +
                " SET Hoadon.MaHD = UpdatedHoadon.MaHD," +
                " Hoadon.ngaylap = UpdatedHoadon.ngaylap," +
                " Hoadon.MaNV = UpdatedHoadon.MaNV," +
                " Hoadon.MaKH = UpdatedHoadon.MaKH," +
                " Hoadon.TongTien = UpdatedHoadon.TongTien " +
                " FROM ( " +
                " SELECT H.MaHD, H.ngaylap, H.MaNV, H.MaKH, SUM(P.Gia + D.Gia) AS TongTien " +
                " FROM Hoadon H " +
                " JOIN Chitietphieudatphong C ON H.MaHD = C.MaHD " +
                " JOIN Phong P ON C.MaPhong = P.MaPhong " +
                " JOIN DichVu D ON C.MaDV = D.MaDV " +
                " GROUP BY H.MaHD, H.ngaylap, H.MaNV, H.MaKH " +
                " ) AS UpdatedHoadon  WHERE Hoadon.MaHD = UpdatedHoadon.MaHD";
            SqlCommand thucthi = new SqlCommand(sqlupdate, ketNoi);
            thucthi.ExecuteNonQuery();
            ketNoi.Close() ;

        }

        private void lvhoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_ma.Text = lvhoadon.SelectedItems[0].SubItems[0].Text;
                date.Text = lvhoadon.SelectedItems[0].SubItems[1].Text;
                cb_nv.SelectedItem = lvhoadon.SelectedItems[0].SubItems[2].Text;
                cb_kh.Text = lvhoadon.SelectedItems[0].SubItems[3].Text;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                btn_them.Enabled = false;
            }
            catch { }
        }
        private void loadlai()
        {
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            ketNoi.Open();
            String sql = "select * from Hoadon ";
            SqlCommand thuthi = new SqlCommand(sql, ketNoi);
            SqlDataReader docdulieu = thuthi.ExecuteReader();
            int i = 0;
            while (docdulieu.Read()) 
            {
                lvhoadon.Items.Add(docdulieu[0].ToString());
                lvhoadon.Items[i].SubItems.Add(docdulieu[1].ToString());
                lvhoadon.Items[i].SubItems.Add(docdulieu[2].ToString());
                lvhoadon.Items[i].SubItems.Add(docdulieu[3].ToString());
                lvhoadon.Items[i].SubItems.Add(docdulieu[4].ToString());
                i++;
            }
            ketNoi.Close();

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

       
    }

