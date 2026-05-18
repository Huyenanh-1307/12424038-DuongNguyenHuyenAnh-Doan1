using System;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Doan1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            // hiệu ứng hover button
            btnLogin.MouseEnter += (s, e) => btnLogin.BackColor = Color.DarkSlateBlue;
            btnLogin.MouseLeave += (s, e) => btnLogin.BackColor = Color.FromArgb(108, 99, 255);
        }

        // ===== BO GÓC PANEL =====
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);
        private void btnLogin_Click(object sender, EventArgs e)
        {

            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            if (user == "" || pass == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ!");
                return;
            }

            // Chuỗi kết nối SQL
            string connStr =
            @"Data Source=.;
            Initial Catalog=QLsinhvienKTX;
            Integrated Security=True;
            Encrypt=False;
            TrustServerCertificate=True";

            using (SqlConnection conn =
                new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string sql =
                    "SELECT VaiTro FROM TaiKhoan " +
                    "WHERE TenDangNhap=@u " +
                    "AND MatKhau=@p";

                    SqlCommand cmd =
                        new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@u", user);

                    cmd.Parameters.AddWithValue(
                        "@p", pass);

                    object result =
                        cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string role =
                            result.ToString();

                        MessageBox.Show(
                            "Đăng nhập thành công!");

                        FrmMenu f =
                            new FrmMenu(role);

                        this.Hide();

                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show(
                        "Sai tài khoản hoặc mật khẩu!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Lỗi kết nối SQL:\n" + ex.Message);
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // form
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(220, 235, 255); // xanh pastel nhẹ, đẹp hơn

            // textbox
            txtUser.BackColor = Color.White;
            txtPass.BackColor = Color.White;
            txtPass.PasswordChar = '*';

            // button
            btnLogin.BackColor = Color.FromArgb(140, 190, 255); // xanh chuẩn app
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnThoat.BackColor = Color.FromArgb(140, 190, 255); 
            btnThoat.ForeColor = Color.White;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.Font = new Font("Segoe UI", 11, FontStyle.Bold);


            // picture
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Bạn có muốn thoát không?",
            "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }
    }
}

