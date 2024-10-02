using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private bool nhap()
        {
            string username = txt_taikhoan.Text;
            string password = txt_matkhau.Text;
            if (username  =="" &&password =="")
            {
                return true;
            }   else return false;
        }
   
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {  // Đăng nhập thành công, thực hiện các xử lý tiếp theo
            this.Hide();
            if (nhap())
            {
              Menu mn = new Menu();
                mn.ShowDialog();
            }
            else
            {
                // Đăng nhập thất bại, hiển thị form yêu cầu nhập lại
                LoginError loginError = new LoginError();    
                loginError.ShowDialog();
            }
            this.Show();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
