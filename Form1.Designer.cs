namespace Buoi4LTWIN
{
    partial class Form1
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
            this.lbQLTTSV = new System.Windows.Forms.Label();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.HbHoTen = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbDTB = new System.Windows.Forms.Label();
            this.lbChuyenNganh = new System.Windows.Forms.Label();
            this.txbMSSV = new System.Windows.Forms.TextBox();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.txbDTB = new System.Windows.Forms.TextBox();
            this.grbThongTinSinhVien = new System.Windows.Forms.GroupBox();
            this.cbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lbTongSVNam = new System.Windows.Forms.Label();
            this.lbTongSVNu = new System.Windows.Forms.Label();
            this.txbTongSVNam = new System.Windows.Forms.TextBox();
            this.txbTongSVNu = new System.Windows.Forms.TextBox();
            this.grbThongTinSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQLTTSV
            // 
            this.lbQLTTSV.AutoSize = true;
            this.lbQLTTSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLTTSV.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbQLTTSV.Location = new System.Drawing.Point(184, 24);
            this.lbQLTTSV.Name = "lbQLTTSV";
            this.lbQLTTSV.Size = new System.Drawing.Size(413, 32);
            this.lbQLTTSV.TabIndex = 0;
            this.lbQLTTSV.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Location = new System.Drawing.Point(6, 30);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(85, 16);
            this.lbMSSV.TabIndex = 2;
            this.lbMSSV.Text = "Mã Sinh Viên";
            this.lbMSSV.Click += new System.EventHandler(this.label3_Click);
            // 
            // HbHoTen
            // 
            this.HbHoTen.AutoSize = true;
            this.HbHoTen.Location = new System.Drawing.Point(6, 71);
            this.HbHoTen.Name = "HbHoTen";
            this.HbHoTen.Size = new System.Drawing.Size(52, 16);
            this.HbHoTen.TabIndex = 3;
            this.HbHoTen.Text = "Họ Tên";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(6, 114);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(60, 16);
            this.lbGioiTinh.TabIndex = 4;
            this.lbGioiTinh.Text = "Giới Tính";
            // 
            // lbDTB
            // 
            this.lbDTB.AutoSize = true;
            this.lbDTB.Location = new System.Drawing.Point(7, 162);
            this.lbDTB.Name = "lbDTB";
            this.lbDTB.Size = new System.Drawing.Size(59, 16);
            this.lbDTB.TabIndex = 5;
            this.lbDTB.Text = "Điểm TB";
            // 
            // lbChuyenNganh
            // 
            this.lbChuyenNganh.AutoSize = true;
            this.lbChuyenNganh.Location = new System.Drawing.Point(6, 207);
            this.lbChuyenNganh.Name = "lbChuyenNganh";
            this.lbChuyenNganh.Size = new System.Drawing.Size(95, 16);
            this.lbChuyenNganh.TabIndex = 6;
            this.lbChuyenNganh.Text = "Chuyên Ngành";
            // 
            // txbMSSV
            // 
            this.txbMSSV.Location = new System.Drawing.Point(115, 25);
            this.txbMSSV.Name = "txbMSSV";
            this.txbMSSV.Size = new System.Drawing.Size(100, 22);
            this.txbMSSV.TabIndex = 7;
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(115, 71);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(100, 22);
            this.txbHoTen.TabIndex = 8;
            this.txbHoTen.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // txbDTB
            // 
            this.txbDTB.Location = new System.Drawing.Point(115, 159);
            this.txbDTB.Name = "txbDTB";
            this.txbDTB.Size = new System.Drawing.Size(100, 22);
            this.txbDTB.TabIndex = 11;
            // 
            // grbThongTinSinhVien
            // 
            this.grbThongTinSinhVien.Controls.Add(this.cbChuyenNganh);
            this.grbThongTinSinhVien.Controls.Add(this.rdbNu);
            this.grbThongTinSinhVien.Controls.Add(this.lbChuyenNganh);
            this.grbThongTinSinhVien.Controls.Add(this.txbDTB);
            this.grbThongTinSinhVien.Controls.Add(this.rdbNam);
            this.grbThongTinSinhVien.Controls.Add(this.lbMSSV);
            this.grbThongTinSinhVien.Controls.Add(this.lbDTB);
            this.grbThongTinSinhVien.Controls.Add(this.txbMSSV);
            this.grbThongTinSinhVien.Controls.Add(this.txbHoTen);
            this.grbThongTinSinhVien.Controls.Add(this.HbHoTen);
            this.grbThongTinSinhVien.Controls.Add(this.lbGioiTinh);
            this.grbThongTinSinhVien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbThongTinSinhVien.Location = new System.Drawing.Point(12, 59);
            this.grbThongTinSinhVien.Name = "grbThongTinSinhVien";
            this.grbThongTinSinhVien.Size = new System.Drawing.Size(297, 248);
            this.grbThongTinSinhVien.TabIndex = 1;
            this.grbThongTinSinhVien.TabStop = false;
            this.grbThongTinSinhVien.Text = "Thông Tin Sinh Viên";
            // 
            // cbChuyenNganh
            // 
            this.cbChuyenNganh.FormattingEnabled = true;
            this.cbChuyenNganh.Items.AddRange(new object[] {
            "QTKD",
            "CNTT"});
            this.cbChuyenNganh.Location = new System.Drawing.Point(115, 199);
            this.cbChuyenNganh.Name = "cbChuyenNganh";
            this.cbChuyenNganh.Size = new System.Drawing.Size(121, 24);
            this.cbChuyenNganh.TabIndex = 12;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(178, 112);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(45, 20);
            this.rdbNu.TabIndex = 10;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(115, 112);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(57, 20);
            this.rdbNam.TabIndex = 9;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(374, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(414, 285);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(38, 329);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(138, 329);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(234, 329);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // lbTongSVNam
            // 
            this.lbTongSVNam.AutoSize = true;
            this.lbTongSVNam.Location = new System.Drawing.Point(460, 362);
            this.lbTongSVNam.Name = "lbTongSVNam";
            this.lbTongSVNam.Size = new System.Drawing.Size(130, 16);
            this.lbTongSVNam.TabIndex = 6;
            this.lbTongSVNam.Text = "Tổng Sinh Viên Nam";
            // 
            // lbTongSVNu
            // 
            this.lbTongSVNu.AutoSize = true;
            this.lbTongSVNu.Location = new System.Drawing.Point(685, 362);
            this.lbTongSVNu.Name = "lbTongSVNu";
            this.lbTongSVNu.Size = new System.Drawing.Size(24, 16);
            this.lbTongSVNu.TabIndex = 7;
            this.lbTongSVNu.Text = "Nữ";
            // 
            // txbTongSVNam
            // 
            this.txbTongSVNam.Location = new System.Drawing.Point(596, 356);
            this.txbTongSVNam.Name = "txbTongSVNam";
            this.txbTongSVNam.Size = new System.Drawing.Size(56, 22);
            this.txbTongSVNam.TabIndex = 17;
            // 
            // txbTongSVNu
            // 
            this.txbTongSVNu.Location = new System.Drawing.Point(715, 356);
            this.txbTongSVNu.Name = "txbTongSVNu";
            this.txbTongSVNu.Size = new System.Drawing.Size(57, 22);
            this.txbTongSVNu.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbTongSVNu);
            this.Controls.Add(this.txbTongSVNam);
            this.Controls.Add(this.lbTongSVNu);
            this.Controls.Add(this.lbTongSVNam);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbThongTinSinhVien);
            this.Controls.Add(this.lbQLTTSV);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbThongTinSinhVien.ResumeLayout(false);
            this.grbThongTinSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQLTTSV;
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.Label HbHoTen;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbDTB;
        private System.Windows.Forms.Label lbChuyenNganh;
        private System.Windows.Forms.TextBox txbMSSV;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.TextBox txbDTB;
        private System.Windows.Forms.GroupBox grbThongTinSinhVien;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.ComboBox cbChuyenNganh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lbTongSVNam;
        private System.Windows.Forms.Label lbTongSVNu;
        private System.Windows.Forms.TextBox txbTongSVNam;
        private System.Windows.Forms.TextBox txbTongSVNu;
    }
}

