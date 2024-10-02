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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {       
            this.Hide();
            frm_QLP frm_QLP = new frm_QLP();
            frm_QLP.ShowDialog();
            this.Show();
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_QLDSKH frm_QLDSKH = new frm_QLDSKH();   
            frm_QLDSKH.ShowDialog();
            this.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_QLNV frm_QLNV = new frm_QLNV();
            frm_QLNV.ShowDialog();  
            this.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
            
                this.Hide();
                frm_QLDV frm_QLDV = new frm_QLDV();
                frm_QLDV.ShowDialog();
                this.Show();
            
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_QLHD frm_QLHD = new frm_QLHD();
            frm_QLHD.ShowDialog();
            this .Show();
        }

        



        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void chiTiếtPhiếuĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide ();
            frm_CTHD frm_CTHD = new frm_CTHD(); 
            frm_CTHD.ShowDialog();
            this .Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this .Hide();
            frm_HDN frm_HDN = new frm_HDN();    
            frm_HDN.ShowDialog();
            this .Show();
        }
    }
}
