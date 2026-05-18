using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan1
{
    public partial class FrmSinhvien : Form
    {
        SqlConnection conn = new SqlConnection(
        @"Server=localhost;
        Database=QLsinhvienKTX;
        Integrated Security=True;
        TrustServerCertificate=True");
        public FrmSinhvien()
        {
            InitializeComponent();
        }

        ClsThaotacCSDL cls = new ClsThaotacCSDL();

        private void FrmSinhvien_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(220, 230, 242);
            dgvSinhvien.AutoGenerateColumns = true;
            LoadSinhVien();
            LoadPhong();

            dgvSinhvien.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }
        void LoadSinhVien()
        {
            try
            {
                string query = "SELECT * FROM SinhVien";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader =
                    cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(reader);

                dgvSinhvien.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void LoadPhong()
        {
            string query = "SELECT MaPhong FROM Phong";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(reader);

            cboPhong.DataSource = dt;

            cboPhong.DisplayMember = "MaPhong";
            cboPhong.ValueMember = "MaPhong";

            conn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.BackColor = Color.MediumSlateBlue;
            btnThem.ForeColor = Color.White;
            btnThem.FlatStyle = FlatStyle.Flat;
            try
            {
                string gioitinh =
                    radNam.Checked ? "Nam" : "Nữ";

                string sql =
                    "INSERT INTO SinhVien " +
                    "(MaSV, HoTen, NgaySinh, GioiTinh, DienThoai, Truong, MaPhong) " +
                    "VALUES " +
                    "(@MaSV, @HoTen, @NgaySinh, @GioiTinh, @DienThoai, @Truong, @MaPhong)";

                List<SqlParameter> param = new List<SqlParameter>()
                {
                    new SqlParameter("@MaSV", txtMaSv.Text),
                    new SqlParameter("@HoTen", txtHoten.Text),
                    new SqlParameter("@NgaySinh", dtNgaysinh.Value),
                    new SqlParameter("@GioiTinh", gioitinh),
                    new SqlParameter("@DienThoai", txtSDT.Text),
                    new SqlParameter("@Truong", txtKhoa.Text),
                    new SqlParameter("@MaPhong", cboPhong.Text)
                };

                cls.ThucThiNonQuery(sql, param);

                MessageBox.Show("Thêm sinh viên thành công");

                LoadSinhVien();

                btnLammoi.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.BackColor = Color.MediumSlateBlue;
            btnSua.ForeColor = Color.White;
            btnSua.FlatStyle = FlatStyle.Flat;
            try
            {
                string gioitinh =
                    radNam.Checked ? "Nam" : "Nữ";

                string sql =
                    "UPDATE SinhVien SET " +
                    "HoTen = @HoTen, " +
                    "NgaySinh = @NgaySinh, " +
                    "GioiTinh = @GioiTinh, " +
                    "DienThoai = @DienThoai, " +
                    "Truong = @Truong, " +
                    "MaPhong = @MaPhong " +
                    "WHERE MaSV = @MaSV";

                List<SqlParameter> param = new List<SqlParameter>()
                {
                    new SqlParameter("@MaSV", txtMaSv.Text),
                    new SqlParameter("@HoTen", txtHoten.Text),
                    new SqlParameter("@NgaySinh", dtNgaysinh.Value),
                    new SqlParameter("@GioiTinh", gioitinh),
                    new SqlParameter("@DienThoai", txtSDT.Text),
                    new SqlParameter("@Truong", txtKhoa.Text),
                    new SqlParameter("@MaPhong", cboPhong.Text)
                };

                cls.ThucThiNonQuery(sql, param);

                MessageBox.Show("Sửa thành công");

                LoadSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnXoa.BackColor = Color.MediumSlateBlue;
            btnXoa.ForeColor = Color.White;
            btnXoa.FlatStyle = FlatStyle.Flat;
            try
            {
                string sql =
                    "DELETE FROM SinhVien WHERE MaSV = @MaSV";

                List<SqlParameter> param = new List<SqlParameter>()
        {
            new SqlParameter("@MaSV", txtMaSv.Text)
        };

                cls.ThucThiNonQuery(sql, param);

                MessageBox.Show("Xóa thành công");

                LoadSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            btnLammoi.BackColor = Color.MediumSlateBlue;
            btnLammoi.ForeColor = Color.White;
            btnLammoi.FlatStyle = FlatStyle.Flat;
            txtMaSv.Clear();
            txtHoten.Clear();
            txtSDT.Clear();
            txtKhoa.Clear();
            txtLop.Clear();

            radNam.Checked = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.MediumSlateBlue;
            btnThoat.ForeColor = Color.White;
            btnThoat.FlatStyle = FlatStyle.Flat;
            this.Close();
        }

        private void dgvSinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSinhvien.BackgroundColor =
             Color.FromArgb(220, 230, 242);

            dgvSinhvien.DefaultCellStyle.BackColor =
                Color.White;

            dgvSinhvien.ColumnHeadersDefaultCellStyle.BackColor =
                Color.SteelBlue;

            dgvSinhvien.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;
            dgvSinhvien.EnableHeadersVisualStyles = false;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvSinhvien.Rows[e.RowIndex];

                txtMaSv.Text =
                    row.Cells["MaSV"].Value.ToString();

                txtHoten.Text =
                    row.Cells["HoTen"].Value.ToString();

                dtNgaysinh.Text =
                    row.Cells["NgaySinh"].Value.ToString();

                string gt =
                    row.Cells["GioiTinh"].Value.ToString();

                if (gt == "Nam")
                    radNam.Checked = true;
                else
                    radNu.Checked = true;

                txtSDT.Text =
                    row.Cells["DienThoai"].Value.ToString();

                txtKhoa.Text =
                    row.Cells["Truong"].Value.ToString();
                cboPhong.Text =
                  row.Cells["MaPhong"].Value.ToString();
            }

        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTimkiem.Text == "")
                {
                    LoadSinhVien();
                    return;
                }

                string sql =
                    "SELECT * FROM SinhVien " +
                    "WHERE MaSV LIKE N'%" + txtTimkiem.Text + "%' " +
                    "OR HoTen LIKE N'%" + txtTimkiem.Text + "%'";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                conn.Open();

                SqlDataReader reader =
                    cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(reader);

                dgvSinhvien.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                conn.Close();
            }
        }
        

        private void btnTim_Click(object sender, EventArgs e)
        {
            btnTim.BackColor = Color.MediumSlateBlue;
            btnTim.ForeColor = Color.White;
            btnTim.FlatStyle = FlatStyle.Flat;
            try
            {
                if (txtTimkiem.Text == "")
                {
                    LoadSinhVien();
                    return;
                }

                string sql =
                    "SELECT * FROM SinhVien " +
                    "WHERE MaSV LIKE N'%" + txtTimkiem.Text + "%' " +
                    "OR HoTen LIKE N'%" + txtTimkiem.Text + "%'";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                conn.Open();

                SqlDataReader reader =
                    cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(reader);

                dgvSinhvien.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                conn.Close();
            }
        }

        private void p_Click(object sender, EventArgs e)
        {
          

        }
    }

}
