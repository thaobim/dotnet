namespace QuanlybanHang_MITComputer
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanli = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblKhachhang = new System.Windows.Forms.Label();
            this.lblNumberKH = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDanhmuc = new System.Windows.Forms.Label();
            this.lblNumberDM = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNumberSP = new System.Windows.Forms.Label();
            this.lblSanpham = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDashboard,
            this.bánHàngToolStripMenuItem,
            this.menuQuanli,
            this.danhMụcToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuDashboard
            // 
            this.menuDashboard.Name = "menuDashboard";
            this.menuDashboard.Size = new System.Drawing.Size(76, 20);
            this.menuDashboard.Text = "Dashboard";
            // 
            // menuQuanli
            // 
            this.menuQuanli.Name = "menuQuanli";
            this.menuQuanli.Size = new System.Drawing.Size(60, 20);
            this.menuQuanli.Text = "Quản lý";
            this.menuQuanli.Click += new System.EventHandler(this.menuQuanli_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDoiMatKhau,
            this.menuLogout});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // menuDoiMatKhau
            // 
            this.menuDoiMatKhau.Name = "menuDoiMatKhau";
            this.menuDoiMatKhau.Size = new System.Drawing.Size(180, 22);
            this.menuDoiMatKhau.Text = "Đổi mật khẩu";
            this.menuDoiMatKhau.Click += new System.EventHandler(this.MenuDoiMatKhau_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(180, 22);
            this.menuLogout.Text = "Đăng xuất";
            this.menuLogout.Click += new System.EventHandler(this.MenuLogout_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(63, 20);
            this.menuHelp.Text = "Trợ giúp";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 426);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblKhachhang);
            this.panel4.Controls.Add(this.lblNumberKH);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(541, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 120);
            this.panel4.TabIndex = 1;
            // 
            // lblKhachhang
            // 
            this.lblKhachhang.AutoSize = true;
            this.lblKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachhang.Location = new System.Drawing.Point(14, 77);
            this.lblKhachhang.Name = "lblKhachhang";
            this.lblKhachhang.Size = new System.Drawing.Size(137, 25);
            this.lblKhachhang.TabIndex = 4;
            this.lblKhachhang.Text = "Khách hàng";
            // 
            // lblNumberKH
            // 
            this.lblNumberKH.AutoSize = true;
            this.lblNumberKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberKH.Location = new System.Drawing.Point(43, 21);
            this.lblNumberKH.Name = "lblNumberKH";
            this.lblNumberKH.Size = new System.Drawing.Size(57, 39);
            this.lblNumberKH.TabIndex = 4;
            this.lblNumberKH.Text = "24";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblDanhmuc);
            this.panel3.Controls.Add(this.lblNumberDM);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(286, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 120);
            this.panel3.TabIndex = 1;
            // 
            // lblDanhmuc
            // 
            this.lblDanhmuc.AutoSize = true;
            this.lblDanhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhmuc.Location = new System.Drawing.Point(9, 73);
            this.lblDanhmuc.Name = "lblDanhmuc";
            this.lblDanhmuc.Size = new System.Drawing.Size(117, 25);
            this.lblDanhmuc.TabIndex = 5;
            this.lblDanhmuc.Text = "Danh mục";
            // 
            // lblNumberDM
            // 
            this.lblNumberDM.AutoSize = true;
            this.lblNumberDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberDM.Location = new System.Drawing.Point(41, 21);
            this.lblNumberDM.Name = "lblNumberDM";
            this.lblNumberDM.Size = new System.Drawing.Size(57, 39);
            this.lblNumberDM.TabIndex = 3;
            this.lblNumberDM.Text = "24";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblNumberSP);
            this.panel2.Controls.Add(this.lblSanpham);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(21, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 120);
            this.panel2.TabIndex = 0;
            // 
            // lblNumberSP
            // 
            this.lblNumberSP.AutoSize = true;
            this.lblNumberSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberSP.Location = new System.Drawing.Point(52, 21);
            this.lblNumberSP.Name = "lblNumberSP";
            this.lblNumberSP.Size = new System.Drawing.Size(57, 39);
            this.lblNumberSP.TabIndex = 2;
            this.lblNumberSP.Text = "24";
            // 
            // lblSanpham
            // 
            this.lblSanpham.AutoSize = true;
            this.lblSanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanpham.Location = new System.Drawing.Point(3, 73);
            this.lblSanpham.Name = "lblSanpham";
            this.lblSanpham.Size = new System.Drawing.Size(117, 25);
            this.lblSanpham.TabIndex = 1;
            this.lblSanpham.Text = "Sản phẩm";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QuanlybanHang_MITComputer.Properties.Resources.icon_dashboard2;
            this.pictureBox3.Location = new System.Drawing.Point(157, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(78, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanlybanHang_MITComputer.Properties.Resources.icon_dashboard;
            this.pictureBox2.Location = new System.Drawing.Point(144, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanlybanHang_MITComputer.Properties.Resources.Circle_icons_dolly_svg;
            this.pictureBox1.Location = new System.Drawing.Point(138, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bánHàngToolStripMenuItem
            // 
            this.bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            this.bánHàngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.bánHàngToolStripMenuItem.Text = "Bán hàng";
            this.bánHàngToolStripMenuItem.Click += new System.EventHandler(this.BánHàngToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Quản lý bán hàng - MIT Computer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDashboard;
        private System.Windows.Forms.ToolStripMenuItem menuQuanli;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblKhachhang;
        private System.Windows.Forms.Label lblNumberKH;
        private System.Windows.Forms.Label lblDanhmuc;
        private System.Windows.Forms.Label lblNumberDM;
        private System.Windows.Forms.Label lblNumberSP;
        private System.Windows.Forms.Label lblSanpham;
        private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;
    }
}

