namespace Doan1
{
    partial class FrmViPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViPham));
            txtTimkiem = new TextBox();
            btnThoat = new Button();
            btnTim = new Button();
            grbThongtin = new GroupBox();
            txtGhiChu = new TextBox();
            cboTrangThai = new ComboBox();
            cboMucCB = new ComboBox();
            txtNoiDung = new TextBox();
            txtTienPhat = new TextBox();
            lblGhiChu = new Label();
            lblTrangThai = new Label();
            lblNgay = new Label();
            lblTien = new Label();
            dtNgayVP = new DateTimePicker();
            cboLoaiVP = new ComboBox();
            cboMaSV = new ComboBox();
            txtMaVP = new TextBox();
            lblMuc = new Label();
            lblLoai = new Label();
            lblND = new Label();
            lblmaSv = new Label();
            lblmaVP = new Label();
            p = new PictureBox();
            lblVipham = new Label();
            dgvViPham = new DataGridView();
            btnSua = new Button();
            btnThem = new Button();
            grbDanhsach = new GroupBox();
            btnXoa = new Button();
            btnLammoi = new Button();
            grbThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)p).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvViPham).BeginInit();
            grbDanhsach.SuspendLayout();
            SuspendLayout();
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(119, 285);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(138, 28);
            txtTimkiem.TabIndex = 35;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(739, 469);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(114, 37);
            btnThoat.TabIndex = 42;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(23, 285);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(90, 28);
            btnTim.TabIndex = 36;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // grbThongtin
            // 
            grbThongtin.Controls.Add(txtGhiChu);
            grbThongtin.Controls.Add(cboTrangThai);
            grbThongtin.Controls.Add(cboMucCB);
            grbThongtin.Controls.Add(txtNoiDung);
            grbThongtin.Controls.Add(txtTienPhat);
            grbThongtin.Controls.Add(lblGhiChu);
            grbThongtin.Controls.Add(lblTrangThai);
            grbThongtin.Controls.Add(lblNgay);
            grbThongtin.Controls.Add(lblTien);
            grbThongtin.Controls.Add(dtNgayVP);
            grbThongtin.Controls.Add(cboLoaiVP);
            grbThongtin.Controls.Add(cboMaSV);
            grbThongtin.Controls.Add(txtMaVP);
            grbThongtin.Controls.Add(lblMuc);
            grbThongtin.Controls.Add(lblLoai);
            grbThongtin.Controls.Add(lblND);
            grbThongtin.Controls.Add(lblmaSv);
            grbThongtin.Controls.Add(lblmaVP);
            grbThongtin.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbThongtin.ForeColor = Color.DarkRed;
            grbThongtin.Location = new Point(4, 36);
            grbThongtin.Name = "grbThongtin";
            grbThongtin.Size = new Size(841, 243);
            grbThongtin.TabIndex = 34;
            grbThongtin.TabStop = false;
            grbThongtin.Text = "Thông tin Vi Phạm";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(581, 191);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(250, 38);
            txtGhiChu.TabIndex = 22;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(581, 135);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(250, 30);
            cboTrangThai.TabIndex = 21;
            // 
            // cboMucCB
            // 
            cboMucCB.FormattingEnabled = true;
            cboMucCB.Location = new Point(581, 88);
            cboMucCB.Name = "cboMucCB";
            cboMucCB.Size = new Size(250, 30);
            cboMucCB.TabIndex = 20;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(157, 117);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(250, 29);
            txtNoiDung.TabIndex = 19;
            // 
            // txtTienPhat
            // 
            txtTienPhat.Location = new Point(157, 159);
            txtTienPhat.Name = "txtTienPhat";
            txtTienPhat.Size = new Size(250, 29);
            txtTienPhat.TabIndex = 18;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(439, 194);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(79, 22);
            lblGhiChu.TabIndex = 17;
            lblGhiChu.Text = "Ghi Chú:";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(439, 138);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(102, 22);
            lblTrangThai.TabIndex = 16;
            lblTrangThai.Text = "Trạng Thái:";
            // 
            // lblNgay
            // 
            lblNgay.AutoSize = true;
            lblNgay.Location = new Point(9, 213);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(127, 22);
            lblNgay.TabIndex = 15;
            lblNgay.Text = "Ngày Vi Phạm:";
            // 
            // lblTien
            // 
            lblTien.AutoSize = true;
            lblTien.Location = new Point(8, 166);
            lblTien.Name = "lblTien";
            lblTien.Size = new Size(91, 22);
            lblTien.TabIndex = 14;
            lblTien.Text = "Tiền Phạt:";
            // 
            // dtNgayVP
            // 
            dtNgayVP.Location = new Point(157, 208);
            dtNgayVP.Name = "dtNgayVP";
            dtNgayVP.Size = new Size(250, 29);
            dtNgayVP.TabIndex = 13;
            // 
            // cboLoaiVP
            // 
            cboLoaiVP.FormattingEnabled = true;
            cboLoaiVP.Location = new Point(581, 44);
            cboLoaiVP.Name = "cboLoaiVP";
            cboLoaiVP.Size = new Size(250, 30);
            cboLoaiVP.TabIndex = 11;
            // 
            // cboMaSV
            // 
            cboMaSV.FormattingEnabled = true;
            cboMaSV.Location = new Point(157, 75);
            cboMaSV.Name = "cboMaSV";
            cboMaSV.Size = new Size(250, 30);
            cboMaSV.TabIndex = 10;
            // 
            // txtMaVP
            // 
            txtMaVP.Location = new Point(157, 20);
            txtMaVP.Name = "txtMaVP";
            txtMaVP.Size = new Size(250, 29);
            txtMaVP.TabIndex = 9;
            // 
            // lblMuc
            // 
            lblMuc.AutoSize = true;
            lblMuc.Location = new Point(439, 96);
            lblMuc.Name = "lblMuc";
            lblMuc.Size = new Size(131, 22);
            lblMuc.TabIndex = 5;
            lblMuc.Text = "Mức Cảnh Báo:";
            // 
            // lblLoai
            // 
            lblLoai.AutoSize = true;
            lblLoai.Location = new Point(439, 52);
            lblLoai.Name = "lblLoai";
            lblLoai.Size = new Size(119, 22);
            lblLoai.TabIndex = 4;
            lblLoai.Text = "Loại Vi Phạm:";
            // 
            // lblND
            // 
            lblND.AutoSize = true;
            lblND.Location = new Point(9, 120);
            lblND.Name = "lblND";
            lblND.Size = new Size(84, 22);
            lblND.TabIndex = 3;
            lblND.Text = "Nội Dung";
            // 
            // lblmaSv
            // 
            lblmaSv.AutoSize = true;
            lblmaSv.Location = new Point(8, 75);
            lblmaSv.Name = "lblmaSv";
            lblmaSv.Size = new Size(119, 22);
            lblmaSv.TabIndex = 1;
            lblmaSv.Text = "Mã Sinh Viên:";
            // 
            // lblmaVP
            // 
            lblmaVP.AutoSize = true;
            lblmaVP.Location = new Point(9, 29);
            lblmaVP.Name = "lblmaVP";
            lblmaVP.Size = new Size(110, 22);
            lblmaVP.TabIndex = 0;
            lblmaVP.Text = "Mã Vi Phạm:";
            // 
            // p
            // 
            p.Cursor = Cursors.Hand;
            p.Image = (Image)resources.GetObject("p.Image");
            p.Location = new Point(272, 285);
            p.Name = "p";
            p.Size = new Size(43, 28);
            p.SizeMode = PictureBoxSizeMode.Zoom;
            p.TabIndex = 37;
            p.TabStop = false;
            // 
            // lblVipham
            // 
            lblVipham.AutoSize = true;
            lblVipham.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVipham.Location = new Point(4, 9);
            lblVipham.Name = "lblVipham";
            lblVipham.Size = new Size(157, 24);
            lblVipham.TabIndex = 33;
            lblVipham.Text = "Quản lý Vi Phạm";
            // 
            // dgvViPham
            // 
            dgvViPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvViPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViPham.Location = new Point(6, 23);
            dgvViPham.MultiSelect = false;
            dgvViPham.Name = "dgvViPham";
            dgvViPham.ReadOnly = true;
            dgvViPham.RowHeadersWidth = 51;
            dgvViPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvViPham.Size = new Size(821, 115);
            dgvViPham.TabIndex = 0;
            dgvViPham.CellContentClick += dgvViPham_CellContentClick;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(161, 469);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(114, 37);
            btnSua.TabIndex = 40;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(23, 469);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(114, 37);
            btnThem.TabIndex = 39;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // grbDanhsach
            // 
            grbDanhsach.Controls.Add(dgvViPham);
            grbDanhsach.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbDanhsach.ForeColor = Color.DarkRed;
            grbDanhsach.Location = new Point(12, 319);
            grbDanhsach.Name = "grbDanhsach";
            grbDanhsach.Size = new Size(841, 144);
            grbDanhsach.TabIndex = 38;
            grbDanhsach.TabStop = false;
            grbDanhsach.Text = "Danh sách Vi Phạm";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(309, 469);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(114, 37);
            btnXoa.TabIndex = 41;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLammoi
            // 
            btnLammoi.Location = new Point(460, 469);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(114, 37);
            btnLammoi.TabIndex = 43;
            btnLammoi.Text = "Làm mới";
            btnLammoi.UseVisualStyleBackColor = true;
            btnLammoi.Click += btnLammoi_Click;
            // 
            // FrmViPham
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 518);
            Controls.Add(txtTimkiem);
            Controls.Add(btnThoat);
            Controls.Add(btnTim);
            Controls.Add(grbThongtin);
            Controls.Add(p);
            Controls.Add(lblVipham);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(grbDanhsach);
            Controls.Add(btnXoa);
            Controls.Add(btnLammoi);
            Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkRed;
            Name = "FrmViPham";
            Text = "FrmViPham";
            Load += FrmViPham_Load;
            grbThongtin.ResumeLayout(false);
            grbThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)p).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvViPham).EndInit();
            grbDanhsach.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTimkiem;
        private Button btnThoat;
        private Button btnTim;
        private GroupBox grbThongtin;
        private DateTimePicker dtNgayVP;
        private ComboBox cboLoaiVP;
        private ComboBox cboMaSV;
        private TextBox txtMaVP;
        private Label lblMuc;
        private Label lblLoai;
        private Label lblND;
        private Label lblmaSv;
        private Label lblmaVP;
        private PictureBox p;
        private Label lblVipham;
        private DataGridView dgvViPham;
        private Button btnSua;
        private Button btnThem;
        private GroupBox grbDanhsach;
        private Button btnXoa;
        private Button btnLammoi;
        private Label lblNgay;
        private Label lblTien;
        private Label lblGhiChu;
        private Label lblTrangThai;
        private TextBox txtNoiDung;
        private TextBox txtTienPhat;
        private TextBox txtGhiChu;
        private ComboBox cboTrangThai;
        private ComboBox cboMucCB;
    }
}