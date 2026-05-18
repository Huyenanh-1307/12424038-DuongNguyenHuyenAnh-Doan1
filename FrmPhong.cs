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
    public partial class FrmPhong : Form
    {
        SqlConnection conn = new SqlConnection(
        @"Server=localhost;
        Database=QLsinhvienKTX;
        Integrated Security=True;
        TrustServerCertificate=True");
        public FrmPhong()
        {
            InitializeComponent();
        }
        ClsThaotacCSDL cls = new ClsThaotacCSDL();

        private void FrmPhong_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(220, 230, 242);

            dgvPhong.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvPhong.BackgroundColor = Color.White;

            LoadPhong();
        }
        // LOAD PHÒNG
        void LoadPhong()
        {
            try
            {
                string query = "SELECT * FROM Phong";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader =
                    cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(reader);

                dgvPhong.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                conn.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string loaiPhong =
                    radNam.Checked ? "Nam" : "Nữ";

                string sql =
                    "INSERT INTO Phong " +
                    "(MaPhong, TenPhong, LoaiPhong, SoNguoiToiDa, Dango, GiaPhong, TrangThai) " +
                    "VALUES " +
                    "(@MaPhong, @TenPhong, @LoaiPhong, @SoNguoiToiDa, @DangO, @GiaPhong, @TrangThai)";

                List<SqlParameter> param =
                    new List<SqlParameter>()
                    {
                    new SqlParameter("@MaPhong", txtMaPhong.Text),
                    new SqlParameter("@TenPhong", txtTenphong.Text),
                    new SqlParameter("@LoaiPhong", loaiPhong),
                    new SqlParameter("@SoNguoiToiDa", numSonguoitoida.Value),
                    new SqlParameter("@DangO", numDango.Value),
                    new SqlParameter("@GiaPhong", txtGia.Text),
                    new SqlParameter("@TrangThai", cboTrangThai.Text)
                    };

                cls.ThucThiNonQuery(sql, param);

                MessageBox.Show("Thêm phòng thành công");

                LoadPhong();

                btnLammoi.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string loaiPhong =
                    radNam.Checked ? "Nam" : "Nữ";

                string sql =
                    "UPDATE Phong SET " +
                    "TenPhong=@TenPhong, " +
                    "LoaiPhong=@LoaiPhong, " +
                    "SoNguoiToiDa=@SoNguoiToiDa, " +
                    "DangO=@DangO, " +
                    "GiaPhong=@GiaPhong, " +
                    "TrangThai=@TrangThai " +
                    "WHERE MaPhong=@MaPhong";

                List<SqlParameter> param =
                    new List<SqlParameter>()
                    {
                    new SqlParameter("@MaPhong", txtMaPhong.Text),
                    new SqlParameter("@TenPhong", txtTenphong.Text),
                    new SqlParameter("@LoaiPhong", loaiPhong),
                    new SqlParameter("@SoNguoiToiDa", numSonguoitoida.Value),
                    new SqlParameter("@DangO", numDango.Value),
                    new SqlParameter("@GiaPhong", txtGia.Text),
                    new SqlParameter("@TrangThai", cboTrangThai.Text)
                    };

                cls.ThucThiNonQuery(sql, param);

                MessageBox.Show("Sửa thành công");

                LoadPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sql =
                    "DELETE FROM Phong WHERE MaPhong=@MaPhong";

                List<SqlParameter> param =
                    new List<SqlParameter>()
                    {
                    new SqlParameter("@MaPhong", txtMaPhong.Text)
                    };

                cls.ThucThiNonQuery(sql, param);

                MessageBox.Show("Xóa thành công");

                LoadPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMaPhong.Clear();
            txtTenphong.Clear();
            txtGia.Clear();

            numSonguoitoida.Value = 0;
            numDango.Value = 0;

            cboTrangThai.SelectedIndex = -1;

            radNam.Checked = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvPhong.Rows[e.RowIndex];

                txtMaPhong.Text =
                    row.Cells["MaPhong"].Value.ToString();

                txtTenphong.Text =
                    row.Cells["TenPhong"].Value.ToString();

                string loai =
                    row.Cells["LoaiPhong"].Value.ToString();

                if (loai == "Nam")
                    radNam.Checked = true;
                else
                    radNu.Checked = true;

                numSonguoitoida.Value =
                    Convert.ToInt32(row.Cells["SoNguoiToiDa"].Value);

                numDango.Value =
                    Convert.ToInt32(row.Cells["DangO"].Value);

                txtGia.Text =
                    row.Cells["GiaPhong"].Value.ToString();

                cboTrangThai.Text =
                    row.Cells["TrangThai"].Value.ToString();
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTimkiem.Text == "")
                {
                    LoadPhong();
                    return;
                }

                string sql =
                    "SELECT * FROM Phong " +
                    "WHERE MaPhong LIKE N'%" + txtTimkiem.Text + "%' " +
                    "OR TenPhong LIKE N'%" + txtTimkiem.Text + "%'";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                conn.Open();

                SqlDataReader reader =
                    cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(reader);

                dgvPhong.DataSource = dt;

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
            try
            {
                if (txtTimkiem.Text == "")
                {
                    LoadPhong();
                    return;
                }

                string sql =
                    "SELECT * FROM Phong " +
                    "WHERE MaPhong LIKE N'%" + txtTimkiem.Text + "%' " +
                    "OR TenPhong LIKE N'%" + txtTimkiem.Text + "%'";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                conn.Open();

                SqlDataReader reader =
                    cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(reader);

                dgvPhong.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                conn.Close();
            }
        }

        private void numSonguoitoida_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
