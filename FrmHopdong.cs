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
    public partial class FrmHopdong : Form
    {
        SqlConnection conn = new SqlConnection(
        @"Server=localhost;
        Database=QLsinhvienKTX;
        Integrated Security=True;
        TrustServerCertificate=True");
        public FrmHopdong()
        {
            InitializeComponent();
        }
        ClsThaotacCSDL cls = new ClsThaotacCSDL();

        private void FrmHopdong_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(220, 230, 242);

            dgvHopDong.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvHopDong.BackgroundColor = Color.White;

            LoadHopDong();



            LoadPhong();
        }
        void LoadHopDong()
        {
            try
            {
                string query =
                    "SELECT * FROM HopDong";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader =
                    cmd.ExecuteReader();

                DataTable dt =
                    new DataTable();

                dt.Load(reader);

                dgvHopDong.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                conn.Close();
            }
        }


        void LoadPhong()
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql =
                        "INSERT INTO HopDong " +
                        "(MaHD, MaPhong, NgayBatDau, NgayKetThuc) " +
                        "VALUES " +
                        "(@MaHD, @MaPhong, @NgayBatDau, @NgayKetThuc)";

                List<SqlParameter> param =
                    new List<SqlParameter>()
                    {
                    new SqlParameter("@MaHD",
                        txtMaHD.Text),

                    new SqlParameter("@MaPhong",
                        cboMaPhong.Text),

                    new SqlParameter("@NgayBatDau",
                        dtBatdau.Value),

                    new SqlParameter("@NgayKetThuc",
                        dtKetthuc.Value)
                    };

                cls.ThucThiNonQuery(sql, param);

                MessageBox.Show("Thêm hợp đồng thành công");

                LoadHopDong();

                btnLammoi.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sql =
                    "UPDATE HopDong SET " +
                    "MaPhong=@MaPhong, " +
                    "NgayBatDau=@NgayBatDau, " +
                    "NgayKetThuc=@NgayKetThuc " +
                    "WHERE MaHD=@MaHD";

                List<SqlParameter> param =
                    new List<SqlParameter>()
                    {
                    new SqlParameter("@MaHD",
                        txtMaHD.Text),

                    new SqlParameter("@MaPhong",
                        cboMaPhong.Text),

                    new SqlParameter("@NgayBatDau",
                        dtBatdau.Value),

                    new SqlParameter("@NgayKetThuc",
                        dtKetthuc.Value)
                    };

                cls.ThucThiNonQuery(sql, param);

                MessageBox.Show("Sửa thành công");

                LoadHopDong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMaHD.Clear();

            cboMaPhong.SelectedIndex = -1;

            txtMaHD.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHopDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvHopDong.Rows[e.RowIndex];

                txtMaHD.Text =
                    row.Cells["MaHD"].Value.ToString();


                cboMaPhong.Text =
                    row.Cells["MaPhong"].Value.ToString();

                dtBatdau.Text =
                    row.Cells["NgayBatDau"].Value.ToString();

                dtKetthuc.Text =
                    row.Cells["NgayKetThuc"].Value.ToString();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string sql =
                    "SELECT * FROM HopDong " +
                    "WHERE MaHD LIKE N'%" +
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

                dgvHopDong.DataSource = dt;

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
                    "SELECT * FROM HopDong " +
                    "WHERE MaHD LIKE N'%" +
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

                dgvHopDong.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                conn.Close();
            }
        }

        private void btnThanhly_Click(object sender, EventArgs e)
        {
            DialogResult tb;

            tb = MessageBox.Show(
                "Bạn có chắc muốn thanh lý hợp đồng không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (tb == DialogResult.Yes)
            {
                try
                {
                    string sql =
                        "DELETE FROM HopDong " +
                        "WHERE MaHD=@MaHD";

                    List<SqlParameter> param =
                        new List<SqlParameter>()
                        {
                    new SqlParameter("@MaHD",
                        txtMaHD.Text)
                        };

                    cls.ThucThiNonQuery(sql, param);

                    MessageBox.Show(
                        "Thanh lý hợp đồng thành công");

                    LoadHopDong();

                    btnLammoi.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
