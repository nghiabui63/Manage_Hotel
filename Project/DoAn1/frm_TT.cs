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
    public partial class frm_TT : Form
    {
        public frm_TT()
        {
            InitializeComponent();
        }
        string chuoiKetNoi = @"Data Source=LAPTOP-TKDRUJMP;Initial Catalog=QLKhachSan;Integrated Security=True";
      /*  private void hienthi()
        {
            SqlConnection ketnoi = new SqlConnection(chuoiKetNoi);
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
                " where h.MaHD = '"+ '" +
                " GROUP BY h.MaHD, c.MaCTPDP, P.Tenphong, d.TenDV ;";
            ketnoi.Open();
            SqlCommand thuchien = new SqlCommand(sql, ketnoi);
            SqlDataReader docdulieu = thuchien.ExecuteReader();
            int i = 0;
            while (docdulieu.Read())
            {
                lvcthd1.Items.Add(docdulieu[0].ToString());
                lvcthd1.Items[i].SubItems.Add(docdulieu[1].ToString());
                lvcthd1.Items[i].SubItems.Add(docdulieu[2].ToString());
                lvcthd1.Items[i].SubItems.Add(docdulieu[3].ToString());
                lvcthd1.Items[i].SubItems.Add(docdulieu[4].ToString());
                i++;
            }
            ketnoi.Close();

        }   
      */
        private void frm_TT_Load(object sender, EventArgs e)
        {

        }
    }
}
