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
    public partial class frm_QLP : Form
    {
        string chuoiKetNoi = @"Data Source=LAPTOP-TKDRUJMP;Initial Catalog=QLKhachSan;Integrated Security=True";
       
        public frm_QLP()
        {
            InitializeComponent();
        }
        private void hienthi()
        {
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            string sql = "SELECT * FROM dbo.Phong";
            ketNoi.Open();
            SqlCommand thucHien = new SqlCommand(sql, ketNoi);
            SqlDataReader docDuLieu = thucHien.ExecuteReader();
            int i = 0;
            while (docDuLieu.Read())
            {
                lvphong.Items.Add(docDuLieu[0].ToString());
                lvphong.Items[i].SubItems.Add(docDuLieu[1].ToString());
                lvphong.Items[i].SubItems.Add(docDuLieu[2].ToString());
                lvphong.Items[i].SubItems.Add(docDuLieu[3].ToString());
                lvphong.Items[i].SubItems.Add(docDuLieu[4].ToString());
                i++;
            }
            ketNoi.Close();

        }
       

        private void frm_QLP_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult ktra = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (ktra == DialogResult.Yes)
            {
               SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
                lvphong.Items.Clear();
                string sql = @"UPDATE dbo.Phong SET Tenphong = N'" + txt_ten.Text +
                    "', Tinhtrang = N'" + txt_tinhtrang.Text +
                    "', Gia = " + txt_gia.Text +
                    ", Songuoitoida = '" + txt_songuoi.Text +
                    "' WHERE Maphong = '" + txt_ma.Text + "'";
                ketNoi.Open();
                SqlCommand thucHien = new SqlCommand(sql, ketNoi);
                thucHien.ExecuteNonQuery();
                ketNoi.Close();
                hienthi();


            }
        }
        
        

        private void lvphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_ma.Text = lvphong.SelectedItems[0].SubItems[0].Text;
                txt_ten.Text = lvphong.SelectedItems[0].SubItems[1].Text;
                txt_tinhtrang.Text = lvphong.SelectedItems[0].SubItems[2].Text;
                txt_gia.Text = lvphong.SelectedItems[0].SubItems[3].Text;
                txt_songuoi.Text = lvphong.SelectedItems[0].SubItems[4].Text;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                btn_them.Enabled = false;
                
            }
            catch { }
        }

        private void btn_boqua_Click_1(object sender, EventArgs e)
        {
            lvphong.Items.Clear();
            hienthi();
            txt_ma.Text = "";
            txt_ten.Text = "";
            txt_tinhtrang.Text = "";
            txt_gia.Text = "";
            txt_songuoi.Text = "";
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            btn_timkiem_Click(sender, e);
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            lvphong.Items.Clear();
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            string sql = "SELECT * FROM dbo.Phong WHERE Maphong LIKE '%" + txt_timkiem.Text +
               "%' OR Tenphong LIKE N'%" + txt_timkiem.Text +
               "%' OR Tinhtrang LIKE N'%" + txt_timkiem.Text +
               "%' OR Gia LIKE '%" + txt_timkiem.Text +
               "%' OR Songuoitoida LIKE '%" + txt_timkiem.Text + "%'";
        
            ketNoi.Open();
            SqlCommand thucHien = new SqlCommand(sql, ketNoi);
            SqlDataReader docDuLieu = thucHien.ExecuteReader();
            int i = 0;
            while (docDuLieu.Read())
            {
                lvphong.Items.Add(docDuLieu[0].ToString());
                lvphong.Items[i].SubItems.Add(docDuLieu[1].ToString());
                lvphong.Items[i].SubItems.Add(docDuLieu[2].ToString());
                lvphong.Items[i].SubItems.Add(docDuLieu[3].ToString());
                lvphong.Items[i].SubItems.Add(docDuLieu[4].ToString());
                i++;
            }
            ketNoi.Close();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }
    }
}
