namespace QuanlybanHang_MITComputer.form
{
    partial class frmBanHang
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNameKH = new System.Windows.Forms.TextBox();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelMainBanHang = new System.Windows.Forms.Panel();
            this.txtSDTKHS = new System.Windows.Forms.TextBox();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.btnSearchKH = new System.Windows.Forms.Button();
            this.dateNgaySN = new System.Windows.Forms.DateTimePicker();
            this.btnTimSP = new System.Windows.Forms.Button();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtGiaSP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoCTT = new System.Windows.Forms.RadioButton();
            this.rdoDTT = new System.Windows.Forms.RadioButton();
            this.btnLenDonHang = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMainBanHang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1309, 57);
            this.panelTop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1309, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bán hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1069, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 536);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnThemKH);
            this.panel1.Controls.Add(this.dtBirthday);
            this.panel1.Controls.Add(this.txtSDTKH);
            this.panel1.Controls.Add(this.txtDiaChiKH);
            this.panel1.Controls.Add(this.txtNameKH);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 536);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thêm Khách Hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Năm sinh:";
            // 
            // txtNameKH
            // 
            this.txtNameKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameKH.Location = new System.Drawing.Point(9, 67);
            this.txtNameKH.Name = "txtNameKH";
            this.txtNameKH.Size = new System.Drawing.Size(219, 32);
            this.txtNameKH.TabIndex = 1;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiKH.Location = new System.Drawing.Point(9, 134);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(219, 32);
            this.txtDiaChiKH.TabIndex = 5;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTKH.Location = new System.Drawing.Point(8, 204);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(220, 32);
            this.txtSDTKH.TabIndex = 6;
            // 
            // dtBirthday
            // 
            this.dtBirthday.Location = new System.Drawing.Point(8, 275);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(220, 20);
            this.dtBirthday.TabIndex = 7;
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(61, 319);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(122, 38);
            this.btnThemKH.TabIndex = 8;
            this.btnThemKH.Text = "Thêm khách hàng";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "Đóng bán hàng";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(605, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Số điện thoại khách:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(605, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Họ tên khách hàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(605, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ngày sinh:";
            // 
            // panelMainBanHang
            // 
            this.panelMainBanHang.Controls.Add(this.btnLenDonHang);
            this.panelMainBanHang.Controls.Add(this.groupBox1);
            this.panelMainBanHang.Controls.Add(this.lblThanhTien);
            this.panelMainBanHang.Controls.Add(this.label15);
            this.panelMainBanHang.Controls.Add(this.txtGhiChu);
            this.panelMainBanHang.Controls.Add(this.label14);
            this.panelMainBanHang.Controls.Add(this.txtSoLuong);
            this.panelMainBanHang.Controls.Add(this.label13);
            this.panelMainBanHang.Controls.Add(this.txtGiaSP);
            this.panelMainBanHang.Controls.Add(this.label12);
            this.panelMainBanHang.Controls.Add(this.txtTenSP);
            this.panelMainBanHang.Controls.Add(this.btnTimSP);
            this.panelMainBanHang.Controls.Add(this.txtMaSP);
            this.panelMainBanHang.Controls.Add(this.label10);
            this.panelMainBanHang.Controls.Add(this.label11);
            this.panelMainBanHang.Controls.Add(this.dateNgaySN);
            this.panelMainBanHang.Controls.Add(this.btnSearchKH);
            this.panelMainBanHang.Controls.Add(this.txtHoTenKH);
            this.panelMainBanHang.Controls.Add(this.txtSDTKHS);
            this.panelMainBanHang.Controls.Add(this.label9);
            this.panelMainBanHang.Controls.Add(this.label8);
            this.panelMainBanHang.Controls.Add(this.label7);
            this.panelMainBanHang.Controls.Add(this.panel2);
            this.panelMainBanHang.Controls.Add(this.panelTop);
            this.panelMainBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainBanHang.Location = new System.Drawing.Point(0, 0);
            this.panelMainBanHang.Name = "panelMainBanHang";
            this.panelMainBanHang.Size = new System.Drawing.Size(1309, 593);
            this.panelMainBanHang.TabIndex = 0;
            // 
            // txtSDTKHS
            // 
            this.txtSDTKHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTKHS.Location = new System.Drawing.Point(608, 104);
            this.txtSDTKHS.Name = "txtSDTKHS";
            this.txtSDTKHS.Size = new System.Drawing.Size(270, 32);
            this.txtSDTKHS.TabIndex = 10;
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.Enabled = false;
            this.txtHoTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenKH.Location = new System.Drawing.Point(608, 180);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(270, 32);
            this.txtHoTenKH.TabIndex = 11;
            // 
            // btnSearchKH
            // 
            this.btnSearchKH.Location = new System.Drawing.Point(896, 104);
            this.btnSearchKH.Name = "btnSearchKH";
            this.btnSearchKH.Size = new System.Drawing.Size(122, 32);
            this.btnSearchKH.TabIndex = 10;
            this.btnSearchKH.Text = "Tìm kiếm";
            this.btnSearchKH.UseVisualStyleBackColor = true;
            this.btnSearchKH.Click += new System.EventHandler(this.BtnSearchKH_Click);
            // 
            // dateNgaySN
            // 
            this.dateNgaySN.Enabled = false;
            this.dateNgaySN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgaySN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaySN.Location = new System.Drawing.Point(608, 249);
            this.dateNgaySN.Name = "dateNgaySN";
            this.dateNgaySN.Size = new System.Drawing.Size(270, 32);
            this.dateNgaySN.TabIndex = 10;
            // 
            // btnTimSP
            // 
            this.btnTimSP.Location = new System.Drawing.Point(319, 104);
            this.btnTimSP.Name = "btnTimSP";
            this.btnTimSP.Size = new System.Drawing.Size(122, 32);
            this.btnTimSP.TabIndex = 14;
            this.btnTimSP.Text = "Tìm kiếm";
            this.btnTimSP.UseVisualStyleBackColor = true;
            this.btnTimSP.Click += new System.EventHandler(this.BtnTimSP_Click);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(32, 104);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(270, 32);
            this.txtMaSP.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tên sản phẩm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Nhập mã sản phẩm";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Enabled = false;
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(32, 180);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(270, 32);
            this.txtTenSP.TabIndex = 16;
            // 
            // txtGiaSP
            // 
            this.txtGiaSP.Enabled = false;
            this.txtGiaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaSP.Location = new System.Drawing.Point(32, 249);
            this.txtGiaSP.Name = "txtGiaSP";
            this.txtGiaSP.Size = new System.Drawing.Size(270, 32);
            this.txtGiaSP.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Giá sản phẩm";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(319, 179);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(122, 32);
            this.txtSoLuong.TabIndex = 20;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSoLuong_KeyPress);
            this.txtSoLuong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSoLuong_KeyUp);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(316, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Số lượng";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Enabled = false;
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(32, 313);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(270, 115);
            this.txtGhiChu.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 294);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Ghi Chú";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(608, 364);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 26);
            this.label15.TabIndex = 23;
            this.label15.Text = "Thành Tiền: ";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(734, 364);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(24, 26);
            this.lblThanhTien.TabIndex = 24;
            this.lblThanhTien.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDTT);
            this.groupBox1.Controls.Add(this.rdoCTT);
            this.groupBox1.Location = new System.Drawing.Point(319, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 198);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trạng thái";
            // 
            // rdoCTT
            // 
            this.rdoCTT.AutoSize = true;
            this.rdoCTT.Checked = true;
            this.rdoCTT.Location = new System.Drawing.Point(6, 29);
            this.rdoCTT.Name = "rdoCTT";
            this.rdoCTT.Size = new System.Drawing.Size(104, 17);
            this.rdoCTT.TabIndex = 0;
            this.rdoCTT.TabStop = true;
            this.rdoCTT.Text = "Chưa thanh toán";
            this.rdoCTT.UseVisualStyleBackColor = true;
            // 
            // rdoDTT
            // 
            this.rdoDTT.AutoSize = true;
            this.rdoDTT.Location = new System.Drawing.Point(7, 62);
            this.rdoDTT.Name = "rdoDTT";
            this.rdoDTT.Size = new System.Drawing.Size(93, 17);
            this.rdoDTT.TabIndex = 1;
            this.rdoDTT.Text = "Đã thanh toán";
            this.rdoDTT.UseVisualStyleBackColor = true;
            // 
            // btnLenDonHang
            // 
            this.btnLenDonHang.Location = new System.Drawing.Point(120, 473);
            this.btnLenDonHang.Name = "btnLenDonHang";
            this.btnLenDonHang.Size = new System.Drawing.Size(210, 43);
            this.btnLenDonHang.TabIndex = 1;
            this.btnLenDonHang.Text = "Lên đơn hàng";
            this.btnLenDonHang.UseVisualStyleBackColor = true;
            this.btnLenDonHang.Click += new System.EventHandler(this.BtnLenDonHang_Click);
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1309, 593);
            this.Controls.Add(this.panelMainBanHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBanHang_Load);
            this.panelTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMainBanHang.ResumeLayout(false);
            this.panelMainBanHang.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.TextBox txtNameKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelMainBanHang;
        private System.Windows.Forms.DateTimePicker dateNgaySN;
        private System.Windows.Forms.Button btnSearchKH;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.TextBox txtSDTKHS;
        private System.Windows.Forms.Button btnTimSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGiaSP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDTT;
        private System.Windows.Forms.RadioButton rdoCTT;
        private System.Windows.Forms.Button btnLenDonHang;
    }
}