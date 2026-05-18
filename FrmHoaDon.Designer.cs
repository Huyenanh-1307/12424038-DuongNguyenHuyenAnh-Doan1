namespace Doan1
{
    partial class FrmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDon));
            p = new PictureBox();
            dgvHoaDon = new DataGridView();
            lblHoaDon = new Label();
            cboMaPhong = new ComboBox();
            txtGiaPhong = new TextBox();
            btnThem = new Button();
            lblNgay = new Label();
            dtNgayLap = new DateTimePicker();
            btnSua = new Button();
            grbDanhsach = new GroupBox();
            btnLammoi = new Button();
            txtMaHDON = new TextBox();
            lblTong = new Label();
            lblChiso = new Label();
            lblHD = new Label();
            lblmaHD = new Label();
            btnThoat = new Button();
            btnTim = new Button();
            grbThongtin = new GroupBox();
            cboChisodiennuoc = new ComboBox();
            cboMaHD = new ComboBox();
            lblGia = new Label();
            lblMaPhong = new Label();
            btnXoa = new Button();
            txtTimkiem = new TextBox();
            txtTongtien = new TextBox();
            ((System.ComponentModel.ISupportInitialize)p).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            grbDanhsach.SuspendLayout();
            grbThongtin.SuspendLayout();
            SuspendLayout();
            // 
            // p
            // 
            p.Cursor = Cursors.Hand;
            p.Image = (Image)resources.GetObject("p.Image");
            p.Location = new Point(367, 261);
            p.Name = "p";
            p.Size = new Size(48, 27);
            p.SizeMode = PictureBoxSizeMode.Zoom;
            p.TabIndex = 48;
            p.TabStop = false;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(0, 31);
            dgvHoaDon.MultiSelect = false;
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(928, 140);
            dgvHoaDon.TabIndex = 0;
            dgvHoaDon.CellContentClick += dgvHoaDon_CellContentClick;
            // 
            // lblHoaDon
            // 
            lblHoaDon.AutoSize = true;
            lblHoaDon.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoaDon.Location = new Point(8, 9);
            lblHoaDon.Name = "lblHoaDon";
            lblHoaDon.Size = new Size(162, 24);
            lblHoaDon.TabIndex = 44;
            lblHoaDon.Text = "Quản lý Hóa Đơn";
            // 
            // cboMaPhong
            // 
            cboMaPhong.FormattingEnabled = true;
            cboMaPhong.Location = new Point(646, 84);
            cboMaPhong.Name = "cboMaPhong";
            cboMaPhong.Size = new Size(277, 30);
            cboMaPhong.TabIndex = 20;
            // 
            // txtGiaPhong
            // 
            txtGiaPhong.Location = new Point(194, 152);
            txtGiaPhong.Name = "txtGiaPhong";
            txtGiaPhong.Size = new Size(277, 29);
            txtGiaPhong.TabIndex = 18;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(18, 474);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(127, 35);
            btnThem.TabIndex = 50;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Location = new Point(488, 135);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(90, 22);
            lblNgay.TabIndex = 15;
            lblNgay.Text = "Ngày Lập:";
            // 
            // dtNgayLap
            // 
            dtNgayLap.Format = DateTimePickerFormat.Short;
            dtNgayLap.Location = new Point(646, 130);
            dtNgayLap.Name = "dtNgayLap";
            dtNgayLap.Size = new Size(277, 29);
            dtNgayLap.TabIndex = 13;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(193, 474);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(127, 35);
            btnSua.TabIndex = 51;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // grbDanhsach
            // 
            grbDanhsach.Controls.Add(dgvHoaDon);
            grbDanhsach.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbDanhsach.ForeColor = Color.DarkRed;
            grbDanhsach.Location = new Point(8, 294);
            grbDanhsach.Name = "grbDanhsach";
            grbDanhsach.Size = new Size(934, 174);
            grbDanhsach.TabIndex = 49;
            grbDanhsach.TabStop = false;
            grbDanhsach.Text = "Danh sách Hóa Đơn";
            // 
            // btnLammoi
            // 
            btnLammoi.Location = new Point(527, 474);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(127, 35);
            btnLammoi.TabIndex = 54;
            btnLammoi.Text = "Làm mới";
            btnLammoi.UseVisualStyleBackColor = true;
            btnLammoi.Click += btnLammoi_Click;
            // 
            // txtMaHDON
            // 
            txtMaHDON.Location = new Point(194, 21);
            txtMaHDON.Name = "txtMaHDON";
            txtMaHDON.Size = new Size(277, 29);
            txtMaHDON.TabIndex = 9;
            // 
            // lblTong
            // 
            lblTong.AutoSize = true;
            lblTong.Location = new Point(488, 50);
            lblTong.Name = "lblTong";
            lblTong.Size = new Size(97, 22);
            lblTong.TabIndex = 4;
            lblTong.Text = "Tổng Tiền:";
            // 
            // lblChiso
            // 
            lblChiso.AutoSize = true;
            lblChiso.Location = new Point(10, 115);
            lblChiso.Name = "lblChiso";
            lblChiso.Size = new Size(185, 22);
            lblChiso.TabIndex = 3;
            lblChiso.Text = "Mã Chỉ Số Điện Nước:";
            // 
            // lblHD
            // 
            lblHD.AutoSize = true;
            lblHD.Location = new Point(9, 72);
            lblHD.Name = "lblHD";
            lblHD.Size = new Size(69, 22);
            lblHD.TabIndex = 1;
            lblHD.Text = "Mã HD:";
            // 
            // lblmaHD
            // 
            lblmaHD.AutoSize = true;
            lblmaHD.Location = new Point(10, 28);
            lblmaHD.Name = "lblmaHD";
            lblmaHD.Size = new Size(115, 22);
            lblmaHD.TabIndex = 0;
            lblmaHD.Text = "Mã Hóa Đơn:";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(804, 474);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(127, 35);
            btnThoat.TabIndex = 53;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(18, 259);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(100, 27);
            btnTim.TabIndex = 47;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // grbThongtin
            // 
            grbThongtin.Controls.Add(txtTongtien);
            grbThongtin.Controls.Add(cboChisodiennuoc);
            grbThongtin.Controls.Add(cboMaHD);
            grbThongtin.Controls.Add(lblGia);
            grbThongtin.Controls.Add(cboMaPhong);
            grbThongtin.Controls.Add(txtGiaPhong);
            grbThongtin.Controls.Add(lblNgay);
            grbThongtin.Controls.Add(dtNgayLap);
            grbThongtin.Controls.Add(txtMaHDON);
            grbThongtin.Controls.Add(lblMaPhong);
            grbThongtin.Controls.Add(lblTong);
            grbThongtin.Controls.Add(lblChiso);
            grbThongtin.Controls.Add(lblHD);
            grbThongtin.Controls.Add(lblmaHD);
            grbThongtin.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbThongtin.ForeColor = Color.DarkRed;
            grbThongtin.Location = new Point(8, 36);
            grbThongtin.Name = "grbThongtin";
            grbThongtin.Size = new Size(934, 208);
            grbThongtin.TabIndex = 45;
            grbThongtin.TabStop = false;
            grbThongtin.Text = "Thông tin Hóa Đơn";
            // 
            // cboChisodiennuoc
            // 
            cboChisodiennuoc.FormattingEnabled = true;
            cboChisodiennuoc.Location = new Point(194, 107);
            cboChisodiennuoc.Name = "cboChisodiennuoc";
            cboChisodiennuoc.Size = new Size(277, 30);
            cboChisodiennuoc.TabIndex = 26;
            // 
            // cboMaHD
            // 
            cboMaHD.FormattingEnabled = true;
            cboMaHD.Location = new Point(194, 64);
            cboMaHD.Name = "cboMaHD";
            cboMaHD.Size = new Size(277, 30);
            cboMaHD.TabIndex = 25;
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Location = new Point(9, 159);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(97, 22);
            lblGia.TabIndex = 23;
            lblGia.Text = "Giá Phòng:";
            // 
            // lblMaPhong
            // 
            lblMaPhong.AutoSize = true;
            lblMaPhong.Location = new Point(488, 92);
            lblMaPhong.Name = "lblMaPhong";
            lblMaPhong.Size = new Size(95, 22);
            lblMaPhong.TabIndex = 5;
            lblMaPhong.Text = "Mã Phòng:";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(352, 474);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(127, 35);
            btnXoa.TabIndex = 52;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(167, 257);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(153, 29);
            txtTimkiem.TabIndex = 46;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // txtTongtien
            // 
            txtTongtien.Location = new Point(646, 43);
            txtTongtien.Name = "txtTongtien";
            txtTongtien.Size = new Size(277, 29);
            txtTongtien.TabIndex = 27;
            // 
            // FrmHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 521);
            Controls.Add(p);
            Controls.Add(lblHoaDon);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(grbDanhsach);
            Controls.Add(btnLammoi);
            Controls.Add(btnThoat);
            Controls.Add(btnTim);
            Controls.Add(grbThongtin);
            Controls.Add(btnXoa);
            Controls.Add(txtTimkiem);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkRed;
            Name = "FrmHoaDon";
            Text = "FrmHoaDon";
            Load += FrmHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)p).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            grbDanhsach.ResumeLayout(false);
            grbThongtin.ResumeLayout(false);
            grbThongtin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox p;
        private DataGridView dgvHoaDon;
        private Label lblHoaDon;
        private TextBox txtGhiChu;
        private ComboBox cboTrangThai;
        private ComboBox cboMaPhong;
        private TextBox txtNoiDung;
        private TextBox txtGiaPhong;
        private Button btnThem;
        private Label lblGhiChu;
        private Label lblTrangThai;
        private Label lblNgay;
        private DateTimePicker dtNgayLap;
        private Button btnSua;
        private GroupBox grbDanhsach;
        private Button btnLammoi;
        private ComboBox cboLoaiVP;
        private ComboBox cboMaSV;
        private TextBox txtMaHDON;
        private Label lblTong;
        private Label lblChiso;
        private Label lblHD;
        private Label lblmaHD;
        private Button btnThoat;
        private Button btnTim;
        private GroupBox grbThongtin;
        private Label lblMaPhong;
        private Button btnXoa;
        private TextBox txtTimkiem;
        private Label lblGia;
        private ComboBox cboChisodiennuoc;
        private ComboBox cboMaHD;
        private TextBox txtTongtien;
    }
}