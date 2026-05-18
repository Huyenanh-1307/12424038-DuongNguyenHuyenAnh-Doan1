namespace Doan1
{
    partial class FrmSinhvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinhvien));
            grbThongtin = new GroupBox();
            txtLop = new TextBox();
            txtKhoa = new TextBox();
            txtSDT = new TextBox();
            cboPhong = new ComboBox();
            radNu = new RadioButton();
            radNam = new RadioButton();
            txtHoten = new TextBox();
            txtMaSv = new TextBox();
            dtNgaysinh = new DateTimePicker();
            lblLop = new Label();
            lblKhoa = new Label();
            lblPhong = new Label();
            lblSDT = new Label();
            lblGioitinh = new Label();
            lblNgay = new Label();
            lblTen = new Label();
            lblmaSv = new Label();
            lblSinhvien = new Label();
            txtTimkiem = new TextBox();
            btnTim = new Button();
            p = new PictureBox();
            grbDanhsach = new GroupBox();
            dgvSinhvien = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnLammoi = new Button();
            grbThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)p).BeginInit();
            grbDanhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhvien).BeginInit();
            SuspendLayout();
            // 
            // grbThongtin
            // 
            grbThongtin.Controls.Add(txtLop);
            grbThongtin.Controls.Add(txtKhoa);
            grbThongtin.Controls.Add(txtSDT);
            grbThongtin.Controls.Add(cboPhong);
            grbThongtin.Controls.Add(radNu);
            grbThongtin.Controls.Add(radNam);
            grbThongtin.Controls.Add(txtHoten);
            grbThongtin.Controls.Add(txtMaSv);
            grbThongtin.Controls.Add(dtNgaysinh);
            grbThongtin.Controls.Add(lblLop);
            grbThongtin.Controls.Add(lblKhoa);
            grbThongtin.Controls.Add(lblPhong);
            grbThongtin.Controls.Add(lblSDT);
            grbThongtin.Controls.Add(lblGioitinh);
            grbThongtin.Controls.Add(lblNgay);
            grbThongtin.Controls.Add(lblTen);
            grbThongtin.Controls.Add(lblmaSv);
            grbThongtin.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbThongtin.ForeColor = Color.DarkRed;
            grbThongtin.Location = new Point(2, 32);
            grbThongtin.Name = "grbThongtin";
            grbThongtin.Size = new Size(841, 196);
            grbThongtin.TabIndex = 0;
            grbThongtin.TabStop = false;
            grbThongtin.Text = "Thông tin Sinh viên";
            // 
            // txtLop
            // 
            txtLop.Location = new Point(593, 145);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(151, 29);
            txtLop.TabIndex = 16;
            // 
            // txtKhoa
            // 
            txtKhoa.Location = new Point(593, 100);
            txtKhoa.Name = "txtKhoa";
            txtKhoa.Size = new Size(151, 29);
            txtKhoa.TabIndex = 15;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(591, 18);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(153, 29);
            txtSDT.TabIndex = 14;
            // 
            // cboPhong
            // 
            cboPhong.FormattingEnabled = true;
            cboPhong.Location = new Point(593, 62);
            cboPhong.Name = "cboPhong";
            cboPhong.Size = new Size(151, 30);
            cboPhong.TabIndex = 13;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(270, 148);
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
            // txtHoten
            // 
            txtHoten.Location = new Point(157, 62);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(250, 29);
            txtHoten.TabIndex = 10;
            // 
            // txtMaSv
            // 
            txtMaSv.Location = new Point(157, 22);
            txtMaSv.Name = "txtMaSv";
            txtMaSv.Size = new Size(250, 29);
            txtMaSv.TabIndex = 9;
            // 
            // dtNgaysinh
            // 
            dtNgaysinh.Location = new Point(157, 107);
            dtNgaysinh.Name = "dtNgaysinh";
            dtNgaysinh.Size = new Size(250, 29);
            dtNgaysinh.TabIndex = 8;
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new Point(474, 152);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(39, 22);
            lblLop.TabIndex = 7;
            lblLop.Text = "Lớp";
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Location = new Point(474, 107);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(56, 22);
            lblKhoa.TabIndex = 6;
            lblKhoa.Text = "Khoa:";
            // 
            // lblPhong
            // 
            lblPhong.AutoSize = true;
            lblPhong.Location = new Point(474, 69);
            lblPhong.Name = "lblPhong";
            lblPhong.Size = new Size(66, 22);
            lblPhong.TabIndex = 5;
            lblPhong.Text = "Phòng:";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(474, 29);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(120, 22);
            lblSDT.TabIndex = 4;
            lblSDT.Text = "Số điện thoại:";
            // 
            // lblGioitinh
            // 
            lblGioitinh.AutoSize = true;
            lblGioitinh.Location = new Point(10, 152);
            lblGioitinh.Name = "lblGioitinh";
            lblGioitinh.Size = new Size(82, 22);
            lblGioitinh.TabIndex = 3;
            lblGioitinh.Text = "Giới tính:";
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Location = new Point(10, 107);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(94, 22);
            lblNgay.TabIndex = 2;
            lblNgay.Text = "Ngày sinh:";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(10, 65);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(93, 22);
            lblTen.TabIndex = 1;
            lblTen.Text = "Họ và tên:";
            // 
            // lblmaSv
            // 
            lblmaSv.AutoSize = true;
            lblmaSv.Location = new Point(10, 25);
            lblmaSv.Name = "lblmaSv";
            lblmaSv.Size = new Size(115, 22);
            lblmaSv.TabIndex = 0;
            lblmaSv.Text = "Mã sinh viên:";
            // 
            // lblSinhvien
            // 
            lblSinhvien.AutoSize = true;
            lblSinhvien.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSinhvien.ForeColor = Color.DarkRed;
            lblSinhvien.Location = new Point(2, 7);
            lblSinhvien.Name = "lblSinhvien";
            lblSinhvien.Size = new Size(163, 24);
            lblSinhvien.TabIndex = 1;
            lblSinhvien.Text = "Quản lý sinh viên";
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(98, 233);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(138, 28);
            txtTimkiem.TabIndex = 2;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(2, 233);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(90, 31);
            btnTim.TabIndex = 3;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // p
            // 
            p.Cursor = Cursors.Hand;
            p.Image = (Image)resources.GetObject("p.Image");
            p.Location = new Point(252, 233);
            p.Name = "p";
            p.Size = new Size(43, 31);
            p.SizeMode = PictureBoxSizeMode.Zoom;
            p.TabIndex = 4;
            p.TabStop = false;
            p.Click += p_Click;
            // 
            // grbDanhsach
            // 
            grbDanhsach.Controls.Add(dgvSinhvien);
            grbDanhsach.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbDanhsach.ForeColor = Color.DarkRed;
            grbDanhsach.Location = new Point(2, 267);
            grbDanhsach.Name = "grbDanhsach";
            grbDanhsach.Size = new Size(841, 157);
            grbDanhsach.TabIndex = 5;
            grbDanhsach.TabStop = false;
            grbDanhsach.Text = "Danh sách sinh viên";
            // 
            // dgvSinhvien
            // 
            dgvSinhvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhvien.Location = new Point(10, 31);
            dgvSinhvien.MultiSelect = false;
            dgvSinhvien.Name = "dgvSinhvien";
            dgvSinhvien.ReadOnly = true;
            dgvSinhvien.RowHeadersWidth = 51;
            dgvSinhvien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhvien.Size = new Size(821, 126);
            dgvSinhvien.TabIndex = 0;
            dgvSinhvien.CellContentClick += dgvSinhvien_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(25, 430);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(114, 40);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(170, 430);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(114, 40);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(316, 430);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(114, 40);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(708, 430);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(114, 40);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLammoi
            // 
            btnLammoi.Location = new Point(452, 430);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(114, 40);
            btnLammoi.TabIndex = 10;
            btnLammoi.Text = "Làm mới";
            btnLammoi.UseVisualStyleBackColor = true;
            btnLammoi.Click += btnLammoi_Click;
            // 
            // FrmSinhvien
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 483);
            Controls.Add(btnLammoi);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(grbDanhsach);
            Controls.Add(p);
            Controls.Add(btnTim);
            Controls.Add(txtTimkiem);
            Controls.Add(lblSinhvien);
            Controls.Add(grbThongtin);
            Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkRed;
            Name = "FrmSinhvien";
            Text = "FrmSinhvien";
            Load += FrmSinhvien_Load;
            grbThongtin.ResumeLayout(false);
            grbThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)p).EndInit();
            grbDanhsach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSinhvien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbThongtin;
        private Label lblSinhvien;
        private TextBox txtTimkiem;
        private Button btnTim;
        private PictureBox p;
        private GroupBox grbDanhsach;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dgvSinhvien;
        private Button btnThoat;
        private Button btnLammoi;
        private Label lblSDT;
        private Label lblGioitinh;
        private Label lblNgay;
        private Label lblTen;
        private Label lblmaSv;
        private DateTimePicker dtNgaysinh;
        private Label lblLop;
        private Label lblKhoa;
        private Label lblPhong;
        private RadioButton radNu;
        private RadioButton radNam;
        private TextBox txtHoten;
        private TextBox txtMaSv;
        private TextBox txtLop;
        private TextBox txtKhoa;
        private TextBox txtSDT;
        private ComboBox cboPhong;
    }
}