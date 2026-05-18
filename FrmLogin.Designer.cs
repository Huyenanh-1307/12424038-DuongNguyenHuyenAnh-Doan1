namespace Doan1
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            lblDangnhap = new Label();
            lblUser = new Label();
            lblPass = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblDangnhap
            // 
            lblDangnhap.AutoSize = true;
            lblDangnhap.Location = new Point(452, 21);
            lblDangnhap.Name = "lblDangnhap";
            lblDangnhap.Size = new Size(308, 23);
            lblDangnhap.TabIndex = 0;
            lblDangnhap.Text = "ĐĂNG NHẬP HỆ THỐNG QUẢN LÝ KTX";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(307, 123);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(129, 23);
            lblUser.TabIndex = 1;
            lblUser.Text = "Tên Đăng Nhập";
            lblUser.Click += lblUser_Click;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(307, 261);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(84, 23);
            lblPass.TabIndex = 2;
            lblPass.Text = "Mật Khẩu";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(452, 116);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(323, 30);
            txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(452, 254);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(323, 30);
            txtPass.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(567, 348);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(208, 70);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 362);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(325, 348);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(208, 70);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Controls.Add(lblDangnhap);
            Name = "FrmLogin";
            Text = "Đăng nhập";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDangnhap;
        private Label lblUser;
        private Label lblPass;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private Button btnThoat;
    }
}
