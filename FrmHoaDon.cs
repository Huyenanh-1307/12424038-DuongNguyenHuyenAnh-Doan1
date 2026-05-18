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

    public partial class FrmHoaDon : Form
    {
        SqlConnection conn = new SqlConnection(
        @"Data Source=.;
        Initial Catalog=QLsinhvienKTX;
        Integrated Security=True;
        Encrypt=False;
        TrustServerCertificate=True");
        public FrmHoaDon()
        {
            InitializeComponent();
        }
        ClsThaotacCSDL cls = new ClsThaotacCSDL();

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            this.BackColor =
                Color.FromArgb(220, 230, 242);

            dgvHoaDon.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvHoaDon.BackgroundColor =
                Color.White;

            LoadHoaDon();

            LoadMaHD();

            LoadMaPhong();

            LoadMaChiSo();
        }
        void LoadHoaDon()
        {
            try
            {
                string query =
                    "SELECT * FROM HoaDon";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader =
                    cmd.ExecuteReader();

                DataTable dt =
                    new DataTable();

                dt.Load(reader);

                dgvHoaDon.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                conn.Close();
            }
        }
        void LoadMaHD()
        {
            try
            {
                string query =
                    "SELECT MaHD FROM HopDong";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader =
                    cmd.ExecuteReader();

                DataTable dt =
                    new DataTable();

                dt.Load(reader);

                cboMaHD.DataSource = dt;

                cboMaHD.DisplayMember = "MaHD";

                cboMaHD.ValueMember = "MaHD";

                conn.Close();
            }
            catch
            {
                conn.Close();
            }
        }
        void LoadMaPhong()
        {
            try
            {
                string query =
                    "SELECT MaPhong FROM Phong";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader =
                    cmd.ExecuteReader();

                DataTable dt =
                    new DataTable();

                dt.Load(reader);

                cboMaPhong.DataSource = dt;

                cboMaPhong.DisplayMember = "MaPhong";

                cboMaPhong.ValueMember = "MaPhong";

                conn.Close();
            }
            catch
            {
                conn.Close();
            }
        }
        void LoadMaChiSo()
        {
            try
            {
                string query =
                    "SELECT MaChiSo FROM ChiSoDienNuoc";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader =
                    cmd.ExecuteReader();

                DataTable dt =
                    new DataTable();

                dt.Load(reader);

                cboChisodiennuoc.DataSource = dt;

                cboChisodiennuoc.DisplayMember ="MaChiSo";

                cboChisodiennuoc.ValueMember ="MaChiSo";

                conn.Close();
            }
            catch
            {
                conn.Close();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql =
                    "INSERT INTO HoaDon " +
                    "(MaHDON, MaHD, TongTien, " +
                    "NgayLap, GiaPhong, MaPhong) " +
                    "VALUES " +
                    "(@MaHDON, @MaHD, @TongTien, " +
                    "@NgayLap, @GiaPhong, @MaPhong)";

                List<SqlParameter> param =
                    new List<SqlParameter>()
                    {
                        new SqlParameter("@MaHDON",
                            txtMaHDON.Text),

                        new SqlParameter("@MaHD",
                            cboMaHD.Text),

                        new SqlParameter("@TongTien",
                            txtTongtien.Text),

                        new SqlParameter("@NgayLap",
                            dtNgayLap.Value),

                        new SqlParameter("@GiaPhong",
                            txtGiaPhong.Text),

                        new SqlParameter("@MaPhong",
                            cboMaPhong.Text)
                    };
                cls.ThucThiNonQuery(sql, param);

                MessageBox.Show(
                    "Thêm hóa đơn thành công");

                LoadHoaDon();

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
                string sql =
                    "UPDATE HoaDon SET " +
                    "MaHD=@MaHD, " +
                    "TongTien=@TongTien, " +
                    "NgayLap=@NgayLap, " +
                    "GiaPhong=@GiaPhong, " +
                    "MaPhong=@MaPhong " +
                    "WHERE MaHDON=@MaHDON";

                List<SqlParameter> param =
                    new List<SqlParameter>()
                    {
                        new SqlParameter("@MaHDON",
                            txtMaHDON.Text),

                        new SqlParameter("@MaHD",
                            cboMaHD.Text),

                        new SqlParameter("@TongTien",
                            txtTongtien.Text),

                        new SqlParameter("@NgayLap",
                            dtNgayLap.Value),

                        new SqlParameter("@GiaPhong",
                            txtGiaPhong.Text),

                        new SqlParameter("@MaPhong",
                            cboMaPhong.Text)
                    };
                cls.ThucThiNonQuery(sql, param);

                MessageBox.Show(
                    "Sửa thành công");

                LoadHoaDon();
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
                    "DELETE FROM HoaDon " +
                    "WHERE MaHDON=@MaHDON";

                List<SqlParameter> param =
                    new List<SqlParameter>()
                    {
                        new SqlParameter("@MaHDON",
                            txtMaHDON.Text)
                    };

                cls.ThucThiNonQuery(sql, param);

                MessageBox.Show(
                    "Xóa thành công");

                LoadHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMaHDON.Clear();

            txtTongtien.Clear();

            txtGiaPhong.Clear();

            cboMaHD.SelectedIndex = -1;

            cboMaPhong.SelectedIndex = -1;

            txtMaHDON.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string sql =
                    "SELECT * FROM HoaDon " +
                    "WHERE MaHDON LIKE N'%" +
                    txtTimkiem.Text + "%' " +
                    "OR MaPhong LIKE N'%" +
                    txtTimkiem.Text + "%'";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                conn.Open();

                SqlDataReader reader =
                    cmd.ExecuteReader();

                DataTable dt =
                    new DataTable();

                dt.Load(reader);

                dgvHoaDon.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                conn.Close();
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql =
                    "SELECT * FROM HoaDon " +
                    "WHERE MaHDON LIKE N'%" +
                    txtTimkiem.Text + "%' " +
                    "OR MaPhong LIKE N'%" +
                    txtTimkiem.Text + "%'";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                conn.Open();

                SqlDataReader reader =
                    cmd.ExecuteReader();

                DataTable dt =
                    new DataTable();

                dt.Load(reader);

                dgvHoaDon.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                conn.Close();
            }
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvHoaDon.Rows[e.RowIndex];

                txtMaHDON.Text =
                    row.Cells["MaHDON"].Value.ToString();

                cboMaHD.Text =
                    row.Cells["MaHD"].Value.ToString();

                txtTongtien.Text =
                    row.Cells["TongTien"].Value.ToString();

                dtNgayLap.Text =
                    row.Cells["NgayLap"].Value.ToString();

                txtGiaPhong.Text =
                    row.Cells["GiaPhong"].Value.ToString();

                cboMaPhong.Text =
                    row.Cells["MaPhong"].Value.ToString();
            }
        }
    }

}
