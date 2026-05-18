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
    public partial class FrmViPham : Form
    {
        SqlConnection conn = new SqlConnection(
        @"Data Source=.;
        Initial Catalog=QLsinhvienKTX;
        Integrated Security=True;
        Encrypt=False;
        TrustServerCertificate=True");
        public FrmViPham()
        {
            InitializeComponent();
        }
        ClsThaotacCSDL cls = new ClsThaotacCSDL();
        private void FrmViPham_Load(object sender, EventArgs e)
        {
            this.BackColor =
              Color.FromArgb(220, 230, 242);

            dgvViPham.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvViPham.BackgroundColor =
                Color.White;

            LoadViPham();

            LoadSinhVien();

            LoadLoaiViPham();

            LoadTrangThai();

            LoadMucCanhBao();
           

        }
        void LoadViPham()
        {
            try
            {
                string query =
                    "SELECT * FROM ViPham";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader =
                    cmd.ExecuteReader();

                DataTable dt =
                    new DataTable();

                dt.Load(reader);

                dgvViPham.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                conn.Close();
            }
        }
        void LoadSinhVien()
        {
            try
            {
                string query =
                    "SELECT MaSV FROM SinhVien";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader =
                    cmd.ExecuteReader();

                DataTable dt =
                    new DataTable();

                dt.Load(reader);

                cboMaSV.DataSource = dt;

                cboMaSV.DisplayMember = "MaSV";

                cboMaSV.ValueMember = "MaSV";

                conn.Close();
            }
            catch
            {
                conn.Close();
            }
        }
        void LoadLoaiViPham()
        {
            cboLoaiVP.Items.Clear();

            cboLoaiVP.Items.Add("Về muộn");

            cboLoaiVP.Items.Add("Gây ồn");

            cboLoaiVP.Items.Add("Không đóng tiền");

            cboLoaiVP.Items.Add("Hút thuốc");

            cboLoaiVP.Items.Add("Phá hoại");
        }
        void LoadTrangThai()
        {
            cboTrangThai.Items.Clear();

            cboTrangThai.Items.Add("Đã nhắc nhở");

            cboTrangThai.Items.Add("Chưa xử lý");

            cboTrangThai.Items.Add("Đã xử lý");

            cboTrangThai.Items.Add("Kỷ luật");
        }
        void LoadMucCanhBao()
        {
            cboMucCB.Items.Clear();

            cboMucCB.Items.Add("1");

            cboMucCB.Items.Add("2");

            cboMucCB.Items.Add("3");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql =
                    "INSERT INTO ViPham " +
                    "(MaVP, MaSV, NoiDung, " +
                    "TienPhat, NgayViPham, " +
                    "LoaiViPham, MucCanhBao, " +
                    "TrangThai, GhiChu) " +
                    "VALUES " +
                    "(@MaVP, @MaSV, @NoiDung, " +
                    "@TienPhat, @NgayViPham, " +
                    "@LoaiViPham, @MucCanhBao, " +
                    "@TrangThai, @GhiChu)";

                List<SqlParameter> param =
                    new List<SqlParameter>()
                    {
                        new SqlParameter("@MaVP",
                            txtMaVP.Text),

                        new SqlParameter("@MaSV",
                            cboMaSV.Text),

                        new SqlParameter("@NoiDung",
                            txtNoiDung.Text),

                        new SqlParameter("@TienPhat",
                            txtTienPhat.Text),

                        new SqlParameter("@NgayViPham",
                            dtNgayVP.Value),

                        new SqlParameter("@LoaiViPham",
                            cboLoaiVP.Text),

                        new SqlParameter("@MucCanhBao",
                            cboMucCB.Text),

                        new SqlParameter("@TrangThai",
                            cboTrangThai.Text),

                        new SqlParameter("@GhiChu",
                            txtGhiChu.Text)
                    };

                cls.ThucThiNonQuery(sql, param);

                MessageBox.Show(
                    "Thêm vi phạm thành công");

                LoadViPham();

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
                    "UPDATE ViPham SET " +
                    "MaSV=@MaSV, " +
                    "NoiDung=@NoiDung, " +
                    "TienPhat=@TienPhat, " +
                    "NgayViPham=@NgayViPham, " +
                    "LoaiViPham=@LoaiViPham, " +
                    "MucCanhBao=@MucCanhBao, " +
                    "TrangThai=@TrangThai, " +
                    "GhiChu=@GhiChu " +
                    "WHERE MaVP=@MaVP";

                List<SqlParameter> param =
                    new List<SqlParameter>()
                    {
                        new SqlParameter("@MaVP",
                            txtMaVP.Text),

                        new SqlParameter("@MaSV",
                            cboMaSV.Text),

                        new SqlParameter("@NoiDung",
                            txtNoiDung.Text),

                        new SqlParameter("@TienPhat",
                            txtTienPhat.Text),

                        new SqlParameter("@NgayViPham",
                            dtNgayVP.Value),

                        new SqlParameter("@LoaiViPham",
                            cboLoaiVP.Text),

                        new SqlParameter("@MucCanhBao",
                            cboMucCB.Text),

                        new SqlParameter("@TrangThai",
                            cboTrangThai.Text),

                        new SqlParameter("@GhiChu",
                            txtGhiChu.Text)
                    };

                cls.ThucThiNonQuery(sql, param);

                MessageBox.Show("Sửa thành công");

                LoadViPham();
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
                    "DELETE FROM ViPham " +
                    "WHERE MaVP=@MaVP";

                List<SqlParameter> param =
                    new List<SqlParameter>()
                    {
                        new SqlParameter("@MaVP",
                            txtMaVP.Text)
                    };

                cls.ThucThiNonQuery(sql, param);

                MessageBox.Show("Xóa thành công");

                LoadViPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMaVP.Clear();

            txtNoiDung.Clear();

            txtTienPhat.Clear();

            txtGhiChu.Clear();

            cboMaSV.SelectedIndex = -1;

            cboLoaiVP.SelectedIndex = -1;

            cboMucCB.SelectedIndex = -1;

            cboTrangThai.SelectedIndex = -1;

            txtMaVP.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvViPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvViPham.Rows[e.RowIndex];

                txtMaVP.Text =
                    row.Cells["MaVP"].Value.ToString();

                cboMaSV.Text =
                    row.Cells["MaSV"].Value.ToString();

                txtNoiDung.Text =
                    row.Cells["NoiDung"].Value.ToString();

                txtTienPhat.Text =
                    row.Cells["TienPhat"].Value.ToString();

                dtNgayVP.Text =
                    row.Cells["NgayViPham"].Value.ToString();

                cboLoaiVP.Text =
                    row.Cells["LoaiViPham"].Value.ToString();

                cboMucCB.Text =
                    row.Cells["MucCanhBao"].Value.ToString();

                cboTrangThai.Text =
                    row.Cells["TrangThai"].Value.ToString();
                txtGhiChu.Text =
                   row.Cells["GhiChu"].Value.ToString();
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql =
                    "SELECT * FROM ViPham " +
                    "WHERE MaVP LIKE N'%" +
                    txtTimkiem.Text + "%' " +
                    "OR MaSV LIKE N'%" +
                    txtTimkiem.Text + "%' " +
                    "OR LoaiViPham LIKE N'%" +
                    txtTimkiem.Text + "%'";

                SqlCommand cmd =
                    new SqlCommand(sql, conn);

                conn.Open();

                SqlDataReader reader =
                    cmd.ExecuteReader();

                DataTable dt =
                    new DataTable();

                dt.Load(reader);

                dgvViPham.DataSource = dt;

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

        }
    }
}
