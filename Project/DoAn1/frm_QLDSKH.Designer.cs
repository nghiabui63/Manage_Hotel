namespace DoAn1
{
    partial class frm_QLDSKH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_gt = new System.Windows.Forms.ComboBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_cccd = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvkhachhang = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_boqua);
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.btn_timkiem);
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 90);
            this.panel1.TabIndex = 0;
            // 
            // btn_boqua
            // 
            this.btn_boqua.Location = new System.Drawing.Point(667, 32);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(84, 33);
            this.btn_boqua.TabIndex = 4;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btb_boqua_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(833, 32);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(84, 33);
            this.btn_thoat.TabIndex = 5;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(518, 32);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(84, 33);
            this.btn_timkiem.TabIndex = 3;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(43, 32);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(84, 33);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(358, 32);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(84, 33);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(198, 32);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(84, 33);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_timkiem);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txt_sdt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cb_gt);
            this.panel2.Controls.Add(this.txt_ten);
            this.panel2.Controls.Add(this.txt_cccd);
            this.panel2.Controls.Add(this.txt_ma);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 238);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(568, 89);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(314, 22);
            this.txt_timkiem.TabIndex = 5;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(497, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Tìm kiếm:";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(568, 47);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(314, 22);
            this.txt_sdt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "SĐT:";
            // 
            // cb_gt
            // 
            this.cb_gt.FormattingEnabled = true;
            this.cb_gt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gt.Location = new System.Drawing.Point(145, 138);
            this.cb_gt.Name = "cb_gt";
            this.cb_gt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_gt.Size = new System.Drawing.Size(137, 24);
            this.cb_gt.TabIndex = 2;
            this.cb_gt.UseWaitCursor = true;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(145, 89);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(314, 22);
            this.txt_ten.TabIndex = 1;
            // 
            // txt_cccd
            // 
            this.txt_cccd.Location = new System.Drawing.Point(145, 184);
            this.txt_cccd.Name = "txt_cccd";
            this.txt_cccd.Size = new System.Drawing.Size(314, 22);
            this.txt_cccd.TabIndex = 3;
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(145, 47);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(314, 22);
            this.txt_ma.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tên khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "CCCD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.9292F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvkhachhang);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(968, 202);
            this.panel3.TabIndex = 2;
            // 
            // lvkhachhang
            // 
            this.lvkhachhang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvkhachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvkhachhang.FullRowSelect = true;
            this.lvkhachhang.HideSelection = false;
            this.lvkhachhang.Location = new System.Drawing.Point(0, 0);
            this.lvkhachhang.Name = "lvkhachhang";
            this.lvkhachhang.Size = new System.Drawing.Size(968, 202);
            this.lvkhachhang.TabIndex = 1;
            this.lvkhachhang.UseCompatibleStateImageBehavior = false;
            this.lvkhachhang.View = System.Windows.Forms.View.Details;
            this.lvkhachhang.SelectedIndexChanged += new System.EventHandler(this.lvkhachhang_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã khách hàng";
            this.columnHeader6.Width = 158;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tên khách hàng";
            this.columnHeader7.Width = 179;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Giới tính";
            this.columnHeader8.Width = 127;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "CCCD";
            this.columnHeader9.Width = 155;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "SDT";
            this.columnHeader10.Width = 125;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(968, 202);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã khách hàng";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên khách hàng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giới tính";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SĐT";
            // 
            // frm_QLDSKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 530);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_QLDSKH";
            this.Text = "frm_QLDSKH";
            this.Load += new System.EventHandler(this.frm_QLDSKH_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_gt;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_cccd;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lvkhachhang;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}