namespace Doan1
{
    partial class FrmMenu
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
            panelMenu = new Panel();
            btnLogout = new Button();
            btnHoadon = new Button();
            btnVipham = new Button();
            btnHopdong = new Button();
            btnPhong = new Button();
            btnSinhvien = new Button();
            btnHome = new Button();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Gainsboro;
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnHoadon);
            panelMenu.Controls.Add(btnVipham);
            panelMenu.Controls.Add(btnHopdong);
            panelMenu.Controls.Add(btnPhong);
            panelMenu.Controls.Add(btnSinhvien);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Location = new Point(12, 12);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 404);
            panelMenu.TabIndex = 1;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.DarkRed;
            btnLogout.Location = new Point(0, 300);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 0, 0);
            btnLogout.Size = new Size(200, 50);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Đăng Xuất";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnHoadon
            // 
            btnHoadon.Dock = DockStyle.Top;
            btnHoadon.FlatAppearance.BorderSize = 0;
            btnHoadon.FlatStyle = FlatStyle.Flat;
            btnHoadon.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHoadon.ForeColor = Color.DarkRed;
            btnHoadon.Location = new Point(0, 250);
            btnHoadon.Name = "btnHoadon";
            btnHoadon.Padding = new Padding(10, 0, 0, 0);
            btnHoadon.Size = new Size(200, 50);
            btnHoadon.TabIndex = 6;
            btnHoadon.Text = "Hóa Đơn";
            btnHoadon.TextAlign = ContentAlignment.MiddleLeft;
            btnHoadon.UseVisualStyleBackColor = true;
            btnHoadon.Click += btnHoadon_Click;
            // 
            // btnVipham
            // 
            btnVipham.Dock = DockStyle.Top;
            btnVipham.FlatAppearance.BorderSize = 0;
            btnVipham.FlatStyle = FlatStyle.Flat;
            btnVipham.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVipham.ForeColor = Color.DarkRed;
            btnVipham.Location = new Point(0, 200);
            btnVipham.Name = "btnVipham";
            btnVipham.Padding = new Padding(10, 0, 0, 0);
            btnVipham.Size = new Size(200, 50);
            btnVipham.TabIndex = 5;
            btnVipham.Text = "Vi Phạm";
            btnVipham.TextAlign = ContentAlignment.MiddleLeft;
            btnVipham.UseVisualStyleBackColor = true;
            btnVipham.Click += btnVipham_Click;
            // 
            // btnHopdong
            // 
            btnHopdong.Dock = DockStyle.Top;
            btnHopdong.FlatAppearance.BorderSize = 0;
            btnHopdong.FlatStyle = FlatStyle.Flat;
            btnHopdong.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHopdong.ForeColor = Color.DarkRed;
            btnHopdong.Location = new Point(0, 150);
            btnHopdong.Name = "btnHopdong";
            btnHopdong.Padding = new Padding(10, 0, 0, 0);
            btnHopdong.Size = new Size(200, 50);
            btnHopdong.TabIndex = 4;
            btnHopdong.Text = "Hợp Đồng";
            btnHopdong.TextAlign = ContentAlignment.MiddleLeft;
            btnHopdong.UseVisualStyleBackColor = true;
            btnHopdong.Click += btnHopdong_Click;
            // 
            // btnPhong
            // 
            btnPhong.Dock = DockStyle.Top;
            btnPhong.FlatAppearance.BorderSize = 0;
            btnPhong.FlatStyle = FlatStyle.Flat;
            btnPhong.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPhong.ForeColor = Color.DarkRed;
            btnPhong.Location = new Point(0, 100);
            btnPhong.Name = "btnPhong";
            btnPhong.Padding = new Padding(10, 0, 0, 0);
            btnPhong.Size = new Size(200, 50);
            btnPhong.TabIndex = 3;
            btnPhong.Text = "Phòng";
            btnPhong.TextAlign = ContentAlignment.MiddleLeft;
            btnPhong.UseVisualStyleBackColor = true;
            btnPhong.Click += btnPhong_Click;
            // 
            // btnSinhvien
            // 
            btnSinhvien.Dock = DockStyle.Top;
            btnSinhvien.FlatAppearance.BorderSize = 0;
            btnSinhvien.FlatStyle = FlatStyle.Flat;
            btnSinhvien.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSinhvien.ForeColor = Color.DarkRed;
            btnSinhvien.Location = new Point(0, 50);
            btnSinhvien.Name = "btnSinhvien";
            btnSinhvien.Padding = new Padding(10, 0, 0, 0);
            btnSinhvien.Size = new Size(200, 50);
            btnSinhvien.TabIndex = 2;
            btnSinhvien.Text = "Sinh Viên";
            btnSinhvien.TextAlign = ContentAlignment.MiddleLeft;
            btnSinhvien.UseVisualStyleBackColor = true;
            btnSinhvien.Click += btnSinhvien_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.DarkRed;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(10, 0, 0, 0);
            btnHome.Size = new Size(200, 50);
            btnHome.TabIndex = 1;
            btnHome.Text = "Trang chủ";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMenu);
            Name = "FrmMenu";
            Text = "FrmMenu";
            Load += FrmMenu_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private Button btnHome;
        private Button btnSinhvien;
        private Button btnLogout;
        private Button btnHoadon;
        private Button btnVipham;
        private Button btnHopdong;
        private Button btnPhong;
    }
}