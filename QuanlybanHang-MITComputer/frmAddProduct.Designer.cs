namespace QuanlybanHang_MITComputer
{
    partial class frmAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtMaSPAdd = new System.Windows.Forms.TextBox();
            this.txtTenSPAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaNhapAdd = new System.Windows.Forms.TextBox();
            this.txtNumberAdd = new System.Windows.Forms.TextBox();
            this.txtMaHDAdd = new System.Windows.Forms.TextBox();
            this.txtGiabanAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGhichuAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(166, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Silver;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(354, 263);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(108, 40);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtMaSPAdd
            // 
            this.txtMaSPAdd.Location = new System.Drawing.Point(151, 43);
            this.txtMaSPAdd.Multiline = true;
            this.txtMaSPAdd.Name = "txtMaSPAdd";
            this.txtMaSPAdd.Size = new System.Drawing.Size(112, 36);
            this.txtMaSPAdd.TabIndex = 2;
            this.txtMaSPAdd.TextChanged += new System.EventHandler(this.txtMaSPAdd_TextChanged);
            // 
            // txtTenSPAdd
            // 
            this.txtTenSPAdd.Location = new System.Drawing.Point(151, 96);
            this.txtTenSPAdd.Multiline = true;
            this.txtTenSPAdd.Name = "txtTenSPAdd";
            this.txtTenSPAdd.Size = new System.Drawing.Size(112, 36);
            this.txtTenSPAdd.TabIndex = 3;
            this.txtTenSPAdd.TextChanged += new System.EventHandler(this.txtTenSPAdd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // txtGiaNhapAdd
            // 
            this.txtGiaNhapAdd.Location = new System.Drawing.Point(407, 43);
            this.txtGiaNhapAdd.Multiline = true;
            this.txtGiaNhapAdd.Name = "txtGiaNhapAdd";
            this.txtGiaNhapAdd.Size = new System.Drawing.Size(130, 36);
            this.txtGiaNhapAdd.TabIndex = 5;
            // 
            // txtNumberAdd
            // 
            this.txtNumberAdd.Location = new System.Drawing.Point(151, 197);
            this.txtNumberAdd.Multiline = true;
            this.txtNumberAdd.Name = "txtNumberAdd";
            this.txtNumberAdd.Size = new System.Drawing.Size(112, 36);
            this.txtNumberAdd.TabIndex = 7;
            this.txtNumberAdd.TextChanged += new System.EventHandler(this.txtNumberAdd_TextChanged);
            // 
            // txtMaHDAdd
            // 
            this.txtMaHDAdd.Location = new System.Drawing.Point(151, 153);
            this.txtMaHDAdd.Multiline = true;
            this.txtMaHDAdd.Name = "txtMaHDAdd";
            this.txtMaHDAdd.Size = new System.Drawing.Size(112, 36);
            this.txtMaHDAdd.TabIndex = 8;
            this.txtMaHDAdd.TextChanged += new System.EventHandler(this.txtMaHDAdd_TextChanged);
            // 
            // txtGiabanAdd
            // 
            this.txtGiabanAdd.Location = new System.Drawing.Point(407, 94);
            this.txtGiabanAdd.Multiline = true;
            this.txtGiabanAdd.Name = "txtGiabanAdd";
            this.txtGiabanAdd.Size = new System.Drawing.Size(130, 36);
            this.txtGiabanAdd.TabIndex = 9;
            this.txtGiabanAdd.TextChanged += new System.EventHandler(this.txtGiabanAdd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã danh mục:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Đơn giá nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(293, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ghi chú:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(293, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Đơn giá bán:";
            // 
            // txtGhichuAdd
            // 
            this.txtGhichuAdd.Location = new System.Drawing.Point(407, 140);
            this.txtGhichuAdd.Multiline = true;
            this.txtGhichuAdd.Name = "txtGhichuAdd";
            this.txtGhichuAdd.Size = new System.Drawing.Size(182, 93);
            this.txtGhichuAdd.TabIndex = 6;
            this.txtGhichuAdd.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 330);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGiabanAdd);
            this.Controls.Add(this.txtMaHDAdd);
            this.Controls.Add(this.txtNumberAdd);
            this.Controls.Add(this.txtGhichuAdd);
            this.Controls.Add(this.txtGiaNhapAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenSPAdd);
            this.Controls.Add(this.txtMaSPAdd);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm sản phẩm";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtMaSPAdd;
        private System.Windows.Forms.TextBox txtTenSPAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaNhapAdd;
        private System.Windows.Forms.TextBox txtNumberAdd;
        private System.Windows.Forms.TextBox txtMaHDAdd;
        private System.Windows.Forms.TextBox txtGiabanAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGhichuAdd;
    }
}