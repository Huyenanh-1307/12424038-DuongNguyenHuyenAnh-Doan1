namespace Doan1
{
    partial class FrmHopdong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHopdong));
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            grbDanhsach = new GroupBox();
            dgvHopDong = new DataGridView();
            btnLammoi = new Button();
            txtTimkiem = new TextBox();
            btnThoat = new Button();
            btnTim = new Button();
            grbThongtin = new GroupBox();
            dtKetthuc = new DateTimePicker();
            dtBatdau = new DateTimePicker();
            cboMaPhong = new ComboBox();
            txtMaHD = new TextBox();
            lblKT = new Label();
            lblBatdau = new Label();
            lblmaPhong = new Label();
            lblmaHD = new Label();
            p = new PictureBox();
            lblHopdong = new Label();
            grbDanhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHopDong).BeginInit();
            grbThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)p).BeginInit();
            SuspendLayout();
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(329, 463);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(114, 40);
            btnXoa.TabIndex = 30;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(160, 463);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(114, 40);
            btnSua.TabIndex = 29;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(9, 463);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(114, 40);
            btnThem.TabIndex = 28;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // grbDanhsach
            // 
            grbDanhsach.Controls.Add(dgvHopDong);
            grbDanhsach.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbDanhsach.ForeColor = Color.DarkRed;
            grbDanhsach.Location = new Point(3, 275);
            grbDanhsach.Name = "grbDanhsach";
            grbDanhsach.Size = new Size(841, 157);
            grbDanhsach.TabIndex = 27;
            grbDanhsach.TabStop = false;
            grbDanhsach.Text = "Danh sách Hợp Đồng";
            // 
            // dgvHopDong
            // 
            dgvHopDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHopDong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHopDong.Location = new Point(6, 25);
            dgvHopDong.MultiSelect = false;
            dgvHopDong.Name = "dgvHopDong";
            dgvHopDong.ReadOnly = true;
            dgvHopDong.RowHeadersWidth = 51;
            dgvHopDong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHopDong.Size = new Size(821, 126);
            dgvHopDong.TabIndex = 0;
            dgvHopDong.CellContentClick += dgvHopDong_CellContentClick;
            // 
            // btnLammoi
            // 
            btnLammoi.Location = new Point(504, 463);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(114, 40);
            btnLammoi.TabIndex = 32;
            btnLammoi.Text = "Làm mới";
            btnLammoi.UseVisualStyleBackColor = true;
            btnLammoi.Click += btnLammoi_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(116, 241);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(138, 28);
            txtTimkiem.TabIndex = 24;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(730, 463);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(114, 40);
            btnThoat.TabIndex = 31;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(9, 238);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(90, 31);
            btnTim.TabIndex = 25;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // grbThongtin
            // 
            grbThongtin.Controls.Add(dtKetthuc);
            grbThongtin.Controls.Add(dtBatdau);
            grbThongtin.Controls.Add(cboMaPhong);
            grbThongtin.Controls.Add(txtMaHD);
            grbThongtin.Controls.Add(lblKT);
            grbThongtin.Controls.Add(lblBatdau);
            grbThongtin.Controls.Add(lblmaPhong);
            grbThongtin.Controls.Add(lblmaHD);
            grbThongtin.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbThongtin.ForeColor = Color.DarkRed;
            grbThongtin.Location = new Point(3, 36);
            grbThongtin.Name = "grbThongtin";
            grbThongtin.Size = new Size(841, 196);
            grbThongtin.TabIndex = 23;
            grbThongtin.TabStop = false;
            grbThongtin.Text = "Thông tin Hợp Đồng";
            // 
            // dtKetthuc
            // 
            dtKetthuc.Location = new Point(588, 70);
            dtKetthuc.Name = "dtKetthuc";
            dtKetthuc.Size = new Size(247, 29);
            dtKetthuc.TabIndex = 13;
            // 
            // dtBatdau
            // 
            dtBatdau.Location = new Point(588, 24);
            dtBatdau.Name = "dtBatdau";
            dtBatdau.Size = new Size(247, 29);
            dtBatdau.TabIndex = 12;
            // 
            // cboMaPhong
            // 
            cboMaPhong.FormattingEnabled = true;
            cboMaPhong.Location = new Point(157, 72);
            cboMaPhong.Name = "cboMaPhong";
            cboMaPhong.Size = new Size(250, 30);
            cboMaPhong.TabIndex = 11;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(157, 22);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(250, 29);
            txtMaHD.TabIndex = 9;
            txtMaHD.TextChanged += txtMaHD_TextChanged;
            // 
            // lblKT
            // 
            lblKT.AutoSize = true;
            lblKT.Location = new Point(456, 70);
            lblKT.Name = "lblKT";
            lblKT.Size = new Size(133, 22);
            lblKT.TabIndex = 5;
            lblKT.Text = "Ngày Kết Thúc:";
            // 
            // lblBatdau
            // 
            lblBatdau.AutoSize = true;
            lblBatdau.Location = new Point(456, 29);
            lblBatdau.Name = "lblBatdau";
            lblBatdau.Size = new Size(126, 22);
            lblBatdau.TabIndex = 4;
            lblBatdau.Text = "Ngày Bắt Đầu:";
            // 
            // lblmaPhong
            // 
            lblmaPhong.AutoSize = true;
            lblmaPhong.Location = new Point(6, 70);
            lblmaPhong.Name = "lblmaPhong";
            lblmaPhong.Size = new Size(95, 22);
            lblmaPhong.TabIndex = 3;
            lblmaPhong.Text = "Mã Phòng:";
            // 
            // lblmaHD
            // 
            lblmaHD.AutoSize = true;
            lblmaHD.Location = new Point(9, 29);
            lblmaHD.Name = "lblmaHD";
            lblmaHD.Size = new Size(126, 22);
            lblmaHD.TabIndex = 0;
            lblmaHD.Text = "Mã Hợp Đồng:";
            // 
            // p
            // 
            p.Cursor = Cursors.Hand;
            p.Image = (Image)resources.GetObject("p.Image");
            p.Location = new Point(271, 241);
            p.Name = "p";
            p.Size = new Size(43, 31);
            p.SizeMode = PictureBoxSizeMode.Zoom;
            p.TabIndex = 26;
            p.TabStop = false;
            // 
            // lblHopdong
            // 
            lblHopdong.AutoSize = true;
            lblHopdong.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHopdong.Location = new Point(3, 9);
            lblHopdong.Name = "lblHopdong";
            lblHopdong.Size = new Size(173, 24);
            lblHopdong.TabIndex = 22;
            lblHopdong.Text = "Quản lý Hợp Đồng";
            // 
            // FrmHopdong
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 516);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(grbDanhsach);
            Controls.Add(btnLammoi);
            Controls.Add(txtTimkiem);
            Controls.Add(btnThoat);
            Controls.Add(btnTim);
            Controls.Add(grbThongtin);
            Controls.Add(p);
            Controls.Add(lblHopdong);
            Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkRed;
            Name = "FrmHopdong";
            Text = "FrmHopdong";
            Load += FrmHopdong_Load;
            grbDanhsach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHopDong).EndInit();
            grbThongtin.ResumeLayout(false);
            grbThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)p).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numSonguoitoida;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private GroupBox grbDanhsach;
        private DataGridView dgvHopDong;
        private Button btnLammoi;
        private TextBox txtTimkiem;
        private Button btnThoat;
        private Button btnTim;
        private GroupBox grbThongtin;
        private NumericUpDown numDango;
        private TextBox txtGia;
        private ComboBox cboTrangThai;
        private RadioButton radNu;
        private RadioButton radNam;
        private TextBox txtTenphong;
        private TextBox txtMaHD;
        private Label lblTrangThai;
        private Label lblKT;
        private Label lblBatdau;
        private Label lblmaPhong;
        private Label lblLoai;
        private Label lblmaHD;
        private PictureBox p;
        private Label lblHopdong;
        private ComboBox cboMaPhong;
        private DateTimePicker dtKetthuc;
        private DateTimePicker dtBatdau;
    }
}