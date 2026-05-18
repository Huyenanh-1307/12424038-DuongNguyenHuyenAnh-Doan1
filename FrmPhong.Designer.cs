namespace Doan1
{
    partial class FrmPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhong));
            lblPhong = new Label();
            p = new PictureBox();
            txtGia = new TextBox();
            cboTrangThai = new ComboBox();
            radNu = new RadioButton();
            radNam = new RadioButton();
            txtTenphong = new TextBox();
            txtMaPhong = new TextBox();
            dgvPhong = new DataGridView();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            lblTrangThai = new Label();
            lblGia = new Label();
            grbDanhsach = new GroupBox();
            lblDango = new Label();
            btnLammoi = new Button();
            lblSucchua = new Label();
            txtTimkiem = new TextBox();
            lblLoai = new Label();
            lblTen = new Label();
            lblmaPhong = new Label();
            btnThoat = new Button();
            btnTim = new Button();
            grbThongtin = new GroupBox();
            numSonguoitoida = new NumericUpDown();
            numDango = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)p).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).BeginInit();
            grbDanhsach.SuspendLayout();
            grbThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSonguoitoida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDango).BeginInit();
            SuspendLayout();
            // 
            // lblPhong
            // 
            lblPhong.AutoSize = true;
            lblPhong.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhong.Location = new Point(12, 9);
            lblPhong.Name = "lblPhong";
            lblPhong.Size = new Size(139, 24);
            lblPhong.TabIndex = 0;
            lblPhong.Text = "Quản lý Phòng";
            // 
            // p
            // 
            p.Cursor = Cursors.Hand;
            p.Image = (Image)resources.GetObject("p.Image");
            p.Location = new Point(255, 238);
            p.Name = "p";
            p.Size = new Size(43, 31);
            p.SizeMode = PictureBoxSizeMode.Zoom;
            p.TabIndex = 15;
            p.TabStop = false;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(593, 63);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(151, 29);
            txtGia.TabIndex = 15;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(591, 104);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(151, 30);
            cboTrangThai.TabIndex = 13;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(268, 154);
            radNu.Name = "radNu";
            radNu.Size = new Size(54, 26);
            radNu.TabIndex = 12;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(157, 152);
            radNam.Name = "radNam";
            radNam.Size = new Size(67, 26);
            radNam.TabIndex = 11;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // txtTenphong
            // 
            txtTenphong.Location = new Point(157, 62);
            txtTenphong.Name = "txtTenphong";
            txtTenphong.Size = new Size(250, 29);
            txtTenphong.TabIndex = 10;
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(157, 22);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(250, 29);
            txtMaPhong.TabIndex = 9;
            // 
            // dgvPhong
            // 
            dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhong.Location = new Point(6, 25);
            dgvPhong.MultiSelect = false;
            dgvPhong.Name = "dgvPhong";
            dgvPhong.ReadOnly = true;
            dgvPhong.RowHeadersWidth = 51;
            dgvPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhong.Size = new Size(821, 126);
            dgvPhong.TabIndex = 0;
            dgvPhong.CellContentClick += dgvPhong_CellContentClick;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(338, 463);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(114, 40);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(169, 463);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(114, 40);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 463);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(114, 40);
            btnThem.TabIndex = 17;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(474, 107);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(102, 22);
            lblTrangThai.TabIndex = 6;
            lblTrangThai.Text = "Trạng Thái:";
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Location = new Point(474, 70);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(97, 22);
            lblGia.TabIndex = 5;
            lblGia.Text = "Giá Phòng:";
            // 
            // grbDanhsach
            // 
            grbDanhsach.Controls.Add(dgvPhong);
            grbDanhsach.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbDanhsach.ForeColor = Color.DarkRed;
            grbDanhsach.Location = new Point(12, 275);
            grbDanhsach.Name = "grbDanhsach";
            grbDanhsach.Size = new Size(841, 157);
            grbDanhsach.TabIndex = 16;
            grbDanhsach.TabStop = false;
            grbDanhsach.Text = "Danh sách Phòng";
            // 
            // lblDango
            // 
            lblDango.AutoSize = true;
            lblDango.Location = new Point(474, 29);
            lblDango.Name = "lblDango";
            lblDango.Size = new Size(78, 22);
            lblDango.TabIndex = 4;
            lblDango.Text = "Đang Ở:";
            // 
            // btnLammoi
            // 
            btnLammoi.Location = new Point(513, 463);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(114, 40);
            btnLammoi.TabIndex = 21;
            btnLammoi.Text = "Làm mới";
            btnLammoi.UseVisualStyleBackColor = true;
            btnLammoi.Click += btnLammoi_Click;
            // 
            // lblSucchua
            // 
            lblSucchua.AutoSize = true;
            lblSucchua.Location = new Point(6, 107);
            lblSucchua.Name = "lblSucchua";
            lblSucchua.Size = new Size(151, 22);
            lblSucchua.TabIndex = 3;
            lblSucchua.Text = "Sức Chứa Tối Đa:";
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(110, 238);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(138, 29);
            txtTimkiem.TabIndex = 13;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // lblLoai
            // 
            lblLoai.AutoSize = true;
            lblLoai.Location = new Point(6, 154);
            lblLoai.Name = "lblLoai";
            lblLoai.Size = new Size(104, 22);
            lblLoai.TabIndex = 2;
            lblLoai.Text = "Loại Phòng:";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(6, 65);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(102, 22);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên Phòng:";
            // 
            // lblmaPhong
            // 
            lblmaPhong.AutoSize = true;
            lblmaPhong.Location = new Point(6, 25);
            lblmaPhong.Name = "lblmaPhong";
            lblmaPhong.Size = new Size(95, 22);
            lblmaPhong.TabIndex = 0;
            lblmaPhong.Text = "Mã Phòng:";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(739, 463);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(114, 40);
            btnThoat.TabIndex = 20;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(12, 238);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(90, 31);
            btnTim.TabIndex = 14;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // grbThongtin
            // 
            grbThongtin.Controls.Add(numSonguoitoida);
            grbThongtin.Controls.Add(numDango);
            grbThongtin.Controls.Add(txtGia);
            grbThongtin.Controls.Add(cboTrangThai);
            grbThongtin.Controls.Add(radNu);
            grbThongtin.Controls.Add(radNam);
            grbThongtin.Controls.Add(txtTenphong);
            grbThongtin.Controls.Add(txtMaPhong);
            grbThongtin.Controls.Add(lblTrangThai);
            grbThongtin.Controls.Add(lblGia);
            grbThongtin.Controls.Add(lblDango);
            grbThongtin.Controls.Add(lblSucchua);
            grbThongtin.Controls.Add(lblLoai);
            grbThongtin.Controls.Add(lblTen);
            grbThongtin.Controls.Add(lblmaPhong);
            grbThongtin.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbThongtin.ForeColor = Color.DarkRed;
            grbThongtin.Location = new Point(12, 36);
            grbThongtin.Name = "grbThongtin";
            grbThongtin.Size = new Size(841, 196);
            grbThongtin.TabIndex = 11;
            grbThongtin.TabStop = false;
            grbThongtin.Text = "Thông tin Phòng";
            // 
            // numSonguoitoida
            // 
            numSonguoitoida.Location = new Point(157, 104);
            numSonguoitoida.Name = "numSonguoitoida";
            numSonguoitoida.Size = new Size(250, 29);
            numSonguoitoida.TabIndex = 17;
            numSonguoitoida.ValueChanged += numSonguoitoida_ValueChanged;
            // 
            // numDango
            // 
            numDango.Location = new Point(594, 27);
            numDango.Name = "numDango";
            numDango.Size = new Size(150, 29);
            numDango.TabIndex = 16;
            // 
            // FrmPhong
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 524);
            Controls.Add(p);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(grbDanhsach);
            Controls.Add(btnLammoi);
            Controls.Add(txtTimkiem);
            Controls.Add(btnThoat);
            Controls.Add(btnTim);
            Controls.Add(grbThongtin);
            Controls.Add(lblPhong);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkRed;
            Name = "FrmPhong";
            Text = "FrmPhong";
            Load += FrmPhong_Load;
            ((System.ComponentModel.ISupportInitialize)p).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).EndInit();
            grbDanhsach.ResumeLayout(false);
            grbThongtin.ResumeLayout(false);
            grbThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSonguoitoida).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDango).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPhong;
        private PictureBox p;
        private TextBox txtGia;
        private TextBox txtSDT;
        private ComboBox cboTrangThai;
        private RadioButton radNu;
        private RadioButton radNam;
        private TextBox txtTenphong;
        private TextBox txtMaPhong;
        private DataGridView dgvPhong;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label lblTrangThai;
        private Label lblGia;
        private GroupBox grbDanhsach;
        private Label lblDango;
        private Button btnLammoi;
        private Label lblSucchua;
        private TextBox txtTimkiem;
        private Label lblLoai;
        private Label lblTen;
        private Label lblmaPhong;
        private Button btnThoat;
        private Button btnTim;
        private GroupBox grbThongtin;
        private NumericUpDown numSonguoitoida;
        private NumericUpDown numDango;
    }
}