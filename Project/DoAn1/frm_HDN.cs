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
    public partial class frm_HDN : Form
    {
        public frm_HDN()
        {
            InitializeComponent();
        }
        string chuoiKetNoi = @"Data Source=LAPTOP-TKDRUJMP;Initial Catalog=QLKhachSan;Integrated Security=True";
        private void txt_ma_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_HDN_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        private void hienthi()
        {
            SqlConnection ketnoi = new SqlConnection(chuoiKetNoi);
            ketnoi.Open();
            string sql = "SELECT " +
                " h.MaHD, " +
                " c.MaCTPDP, " +
                " P.Tenphong, " +
                " d.TenDV, " +
                " SUM(P.Gia + d.Gia) AS Tongtien " +
                " FROM Hoadon h " +
                " JOIN Chitietphieudatphong c ON h.MaHD = c.MaHD " +
                " JOIN Phong P ON c.Maphong = P.Maphong " +
                " JOIN Dichvu d ON c.MaDV = d.MaDV " +
                " GROUP BY h.MaHD, c.MaCTPDP, P.Tenphong, d.TenDV ;";
            SqlCommand thuchien = new SqlCommand(sql,ketnoi);
            SqlDataReader docdulieu = thuchien.ExecuteReader();
            int i = 0;
            while(docdulieu.Read() )   {
                lvcthd1.Items.Add(docdulieu[0].ToString());
                lvcthd1.Items[i].SubItems.Add(docdulieu[1].ToString());
                lvcthd1.Items[i].SubItems.Add(docdulieu[2].ToString());
                lvcthd1.Items[i].SubItems.Add(docdulieu[3].ToString());
                lvcthd1.Items[i].SubItems.Add(docdulieu[4].ToString());
                i++;  
            }ketnoi.Close();
        }

        private void lvcthd1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_ma.Text = lvcthd1.SelectedItems[0].SubItems[0].Text;
                txt_mact.Text = lvcthd1.SelectedItems[0].SubItems[1].Text;
                txt_tenphong.Text = lvcthd1.SelectedItems[0].SubItems[2].Text;
                txt_tendv.Text = lvcthd1.SelectedItems[0].SubItems[3].Text;

            }
            catch { }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            click();
        }
        private void click()
        {
            txt_ma.Text = "";
            txt_mact.Text = "";
            txt_tenphong.Text = "";
            txt_tendv.Text = "";
            txt_timkiem.Text="";    
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {

        }
    }
}
