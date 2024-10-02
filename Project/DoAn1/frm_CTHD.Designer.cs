namespace DoAn1
{
    partial class frm_CTHD
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
            this.cb_hd = new System.Windows.Forms.ComboBox();
            this.cb_phong = new System.Windows.Forms.ComboBox();
            this.cb_madv = new System.Windows.Forms.ComboBox();
            this.datetra = new System.Windows.Forms.DateTimePicker();
            this.dateden = new System.Windows.Forms.DateTimePicker();
            this.txt_tiemkiem = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvcthd = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.panel1.Location = new System.Drawing.Point(0, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_boqua
            // 
            this.btn_boqua.Location = new System.Drawing.Point(653, 34);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(84, 33);
            this.btn_boqua.TabIndex = 10;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(808, 34);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(84, 33);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(497, 34);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(84, 33);
            this.btn_timkiem.TabIndex = 9;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(43, 34);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(84, 33);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(344, 34);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(84, 33);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(199, 34);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(84, 33);
            this.btn_sua.TabIndex = 7;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cb_hd);
            this.panel2.Controls.Add(this.cb_phong);
            this.panel2.Controls.Add(this.cb_madv);
            this.panel2.Controls.Add(this.datetra);
            this.panel2.Controls.Add(this.dateden);
            this.panel2.Controls.Add(this.txt_tiemkiem);
            this.panel2.Controls.Add(this.txt_ma);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 189);
            this.panel2.TabIndex = 1;
            // 
            // cb_hd
            // 
            this.cb_hd.FormattingEnabled = true;
            this.cb_hd.Location = new System.Drawing.Point(570, 128);
            this.cb_hd.Name = "cb_hd";
            this.cb_hd.Size = new System.Drawing.Size(271, 24);
            this.cb_hd.TabIndex = 21;
            // 
            // cb_phong
            // 
            this.cb_phong.FormattingEnabled = true;
            this.cb_phong.Location = new System.Drawing.Point(570, 89);
            this.cb_phong.Name = "cb_phong";
            this.cb_phong.Size = new System.Drawing.Size(271, 24);
            this.cb_phong.TabIndex = 20;
            // 
            // cb_madv
            // 
            this.cb_madv.FormattingEnabled = true;
            this.cb_madv.Location = new System.Drawing.Point(570, 49);
            this.cb_madv.Name = "cb_madv";
            this.cb_madv.Size = new System.Drawing.Size(271, 24);
            this.cb_madv.TabIndex = 19;
            // 
            // datetra
            // 
            this.datetra.Location = new System.Drawing.Point(119, 123);
            this.datetra.Name = "datetra";
            this.datetra.Size = new System.Drawing.Size(200, 22);
            this.datetra.TabIndex = 18;
            // 
            // dateden
            // 
            this.dateden.Location = new System.Drawing.Point(119, 83);
            this.dateden.Name = "dateden";
            this.dateden.Size = new System.Drawing.Size(200, 22);
            this.dateden.TabIndex = 17;
            // 
            // txt_tiemkiem
            // 
            this.txt_tiemkiem.Location = new System.Drawing.Point(570, 159);
            this.txt_tiemkiem.Name = "txt_tiemkiem";
            this.txt_tiemkiem.Size = new System.Drawing.Size(322, 22);
            this.txt_tiemkiem.TabIndex = 16;
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(119, 46);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(322, 22);
            this.txt_ma.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tìm kiếm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mã hóa đơn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mã phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã dịch vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày trả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày đến: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã CTPD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.9292F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHI TIẾT PHIẾU ĐẶT PHÒNG";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvcthd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(933, 225);
            this.panel3.TabIndex = 1;
            // 
            // lvcthd
            // 
            this.lvcthd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvcthd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvcthd.FullRowSelect = true;
            this.lvcthd.HideSelection = false;
            this.lvcthd.Location = new System.Drawing.Point(0, 0);
            this.lvcthd.Name = "lvcthd";
            this.lvcthd.Size = new System.Drawing.Size(933, 225);
            this.lvcthd.TabIndex = 0;
            this.lvcthd.UseCompatibleStateImageBehavior = false;
            this.lvcthd.View = System.Windows.Forms.View.Details;
            this.lvcthd.SelectedIndexChanged += new System.EventHandler(this.lvcthd_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã chi tiết hóa đơn";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày đến";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày trả";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã dịch vụ";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã phòng";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã hóa đơn";
            this.columnHeader6.Width = 100;
            // 
            // frm_CTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 514);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_CTHD";
            this.Text = "frm_CTHD";
            this.Load += new System.EventHandler(this.frm_CTHD_Load);
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
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tiemkiem;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetra;
        private System.Windows.Forms.DateTimePicker dateden;
        private System.Windows.Forms.ComboBox cb_phong;
        private System.Windows.Forms.ComboBox cb_madv;
        private System.Windows.Forms.ListView lvcthd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ComboBox cb_hd;
    }
}