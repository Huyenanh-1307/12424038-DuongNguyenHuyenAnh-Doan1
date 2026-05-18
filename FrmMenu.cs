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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        string role;

        public FrmMenu(string role)
        {
            InitializeComponent();
            this.role = role;
        }
        ClsThaotacCSDL cls = new ClsThaotacCSDL();
        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnSinhvien_Click(object sender, EventArgs e)
        {

            Label lbl = new Label();
            lbl.Text = "Sinh Viên";
            lbl.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lbl.AutoSize = true;
            lbl.Location = new Point(200, 150);

            try
            {
                FrmSinhvien f = new FrmSinhvien();

                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult tb;

            tb = MessageBox.Show(
                "Bạn chắc chắn muốn đăng xuất không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (tb == DialogResult.Yes)
            {
                this.Hide();

                FrmLogin login = new FrmLogin();

                login.ShowDialog();

                this.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            

            // ===== CARD =====
            Panel card = new Panel();
            card.Size = new Size(500, 220);
            card.BackColor = Color.White;


         
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {


            Label lbl = new Label();
            lbl.Text = "Phòng";
            lbl.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lbl.AutoSize = true;
            lbl.Location = new Point(200, 150);

            try
            {
                FrmPhong f = new FrmPhong();

                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHopdong_Click(object sender, EventArgs e)
        {

            Label lbl = new Label();
            lbl.Text = "Hợp đồng";
            lbl.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lbl.AutoSize = true;
            lbl.Location = new Point(200, 150);

            try
            {
                FrmHopdong f = new FrmHopdong();

                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVipham_Click(object sender, EventArgs e)
        {

            Label lbl = new Label();
            lbl.Text = "Vi phạm";
            lbl.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lbl.AutoSize = true;
            lbl.Location = new Point(200, 150);
            try
            {
                FrmViPham f = new FrmViPham();

                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {


            Label lbl = new Label();
            lbl.Text = "Hóa đơn";
            lbl.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lbl.AutoSize = true;
            lbl.Location = new Point(200, 150);
            try
            {
                FrmHoaDon f = new FrmHoaDon();

                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LB2_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            
            this.BackgroundImage = Image.FromFile("C:/Users/levan/source/Đồ Án 1/Khuân viên.png"); //Đường dẫn
            this.BackgroundImageLayout = ImageLayout.Stretch;

            if (role == "NhanVien")
            {
                MessageBox.Show("Đăng nhập với quyền Nhân viên");
            }

            
        }
    }
}
