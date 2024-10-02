using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class frm_QLDV : Form
    {
        public frm_QLDV()
        {
            InitializeComponent();
        }
        string chuoiKetNoi = @"Data Source=LAPTOP-TKDRUJMP;Initial Catalog=QLKhachSan;Integrated Security=True";
        private void hienthi()
        {
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            string sql = "SELECT * FROM Dichvu";
            ketNoi.Open();
            SqlCommand thucHien = new SqlCommand(sql, ketNoi);
            SqlDataReader docDuLieu = thucHien.ExecuteReader();
            int i = 0;
            while (docDuLieu.Read())
            {
                lvdichvu.Items.Add(docDuLieu[0].ToString());
                lvdichvu.Items[i].SubItems.Add(docDuLieu[1].ToString());
                lvdichvu.Items[i].SubItems.Add(docDuLieu[2].ToString());
                
                i++;
            }
            ketNoi.Close();

        }
        private void lvdichvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_ma.Text = lvdichvu.SelectedItems[0].SubItems[0].Text;
                txt_ten.Text = lvdichvu.SelectedItems[0].SubItems[1].Text;
                txt_gia.Text = lvdichvu.SelectedItems[0].SubItems[2].Text;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                btn_them.Enabled = false;

            }
            catch { }
        }

        private void frm_QLDV_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                lvdichvu.Items.Clear();
                string sql = @"INSERT INTO dbo.Dichvu ( MaDV, TenDV, Gia ) " +
                                "VALUES ( '" + txt_ma.Text +
                                "', N'" + txt_ten.Text +
                                "', N'" + txt_gia.Text + "' )";
                SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
                ketNoi.Open();
                SqlCommand thucHien = new SqlCommand(sql, ketNoi);
                thucHien.ExecuteNonQuery();
                hienthi();
                ketNoi.Close();


            }
            catch
            {
                MessageBox.Show("Đã có mã dịch vụ: " + txt_ma.Text, "Thông báo!", MessageBoxButtons.OK);
                hienthi();
            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            click();
        }  
        private void click()
        {
            txt_ma.Text = "";
            txt_ten.Text = "";
            txt_gia.Text = "";
            txt_timkiem.Text = "";
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            DialogResult ktra = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (ktra == DialogResult.Yes)
            {
                lvdichvu.Items.Clear();

                string sql = @"UPDATE dbo.Dichvu SET TenDV = N'" + txt_ten.Text +
                    "', Gia = '" + txt_gia.Text +
                    "' WHERE MaDV = N'" + txt_ma.Text + "'";
                ketNoi = new SqlConnection(chuoiKetNoi);
                ketNoi.Open();
                SqlCommand thucHien = new SqlCommand(sql, ketNoi);
                thucHien.ExecuteNonQuery();
                hienthi();
                ketNoi.Close();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult ktra = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (ktra == DialogResult.Yes)
            {
                lvdichvu.Items.Clear();
                string sqlDeleteDV = "DELETE FROM dbo.Dichvu WHERE MaDV = '" + txt_ma.Text + "'";
                string sqlDeleteCTPD = "DELETE FROM dbo.Chitietphieudatphong WHERE MaDV = '" + txt_ma.Text + "'";
                SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
                ketNoi.Open();
                SqlCommand thucHien = new SqlCommand(sqlDeleteDV, ketNoi);
                SqlCommand thucHienDeleteCTPD = new SqlCommand(sqlDeleteCTPD, ketNoi);
                thucHienDeleteCTPD.ExecuteNonQuery();
                thucHien.ExecuteNonQuery();
                ketNoi.Close();
                click();
                hienthi();
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            lvdichvu.Items.Clear ();
            SqlConnection ketNoi = new SqlConnection(chuoiKetNoi);
            string sql = "Select * from Dichvu where MaDV LIKE '%" + txt_timkiem.Text +
                "%' OR TenDV LIKE N'%" + txt_timkiem.Text +
                "%' OR Gia LIKE '%" + txt_timkiem.Text + "%'"; 
            ketNoi.Open();
            SqlCommand thuchien = new SqlCommand(sql, ketNoi);
            SqlDataReader docdulieu = thuchien.ExecuteReader();
            int i=0;
            while (docdulieu.Read()) {
                lvdichvu.Items.Add(docdulieu[0].ToString());
                lvdichvu.Items[i].SubItems.Add(docdulieu[1].ToString());
                lvdichvu.Items[i].SubItems.Add(docdulieu[2].ToString());
                i++;
            }
            ketNoi.Close() ;

        }
    }
}
