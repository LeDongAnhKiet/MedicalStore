namespace GUI_QLNT
{
    partial class FrmNhanVien
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
            this.dgNV = new System.Windows.Forms.DataGridView();
            this.btThoat = new System.Windows.Forms.Button();
            this.lbHo = new System.Windows.Forms.Label();
            this.txHo = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.txTen = new System.Windows.Forms.TextBox();
            this.lbSdt = new System.Windows.Forms.Label();
            this.txSdt = new System.Windows.Forms.TextBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.txDesc = new System.Windows.Forms.TextBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.lbMa = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.txMa = new System.Windows.Forms.TextBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.txUser = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.txPass = new System.Windows.Forms.TextBox();
            this.lbNV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgNV)).BeginInit();
            this.gb2.SuspendLayout();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgNV
            // 
            this.dgNV.AllowUserToAddRows = false;
            this.dgNV.AllowUserToDeleteRows = false;
            this.dgNV.AllowUserToOrderColumns = true;
            this.dgNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgNV.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNV.Location = new System.Drawing.Point(16, 343);
            this.dgNV.Margin = new System.Windows.Forms.Padding(4);
            this.dgNV.Name = "dgNV";
            this.dgNV.ReadOnly = true;
            this.dgNV.RowHeadersWidth = 51;
            this.dgNV.Size = new System.Drawing.Size(1000, 260);
            this.dgNV.TabIndex = 48;
            this.dgNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNV_CellClick);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(468, 620);
            this.btThoat.Margin = new System.Windows.Forms.Padding(5);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(100, 50);
            this.btThoat.TabIndex = 49;
            this.btThoat.Text = "Quay lại";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // lbHo
            // 
            this.lbHo.AutoSize = true;
            this.lbHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHo.Location = new System.Drawing.Point(30, 50);
            this.lbHo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(107, 20);
            this.lbHo.TabIndex = 17;
            this.lbHo.Text = "Họ nhân viên";
            // 
            // txHo
            // 
            this.txHo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txHo.Location = new System.Drawing.Point(200, 47);
            this.txHo.Margin = new System.Windows.Forms.Padding(5);
            this.txHo.Name = "txHo";
            this.txHo.Size = new System.Drawing.Size(250, 27);
            this.txHo.TabIndex = 19;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(30, 100);
            this.lbTen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(113, 20);
            this.lbTen.TabIndex = 20;
            this.lbTen.Text = "Tên nhân viên";
            // 
            // txTen
            // 
            this.txTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txTen.Location = new System.Drawing.Point(200, 97);
            this.txTen.Margin = new System.Windows.Forms.Padding(5);
            this.txTen.Name = "txTen";
            this.txTen.Size = new System.Drawing.Size(250, 27);
            this.txTen.TabIndex = 21;
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSdt.Location = new System.Drawing.Point(30, 150);
            this.lbSdt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(106, 20);
            this.lbSdt.TabIndex = 22;
            this.lbSdt.Text = "Số điện thoại";
            // 
            // txSdt
            // 
            this.txSdt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txSdt.Location = new System.Drawing.Point(200, 147);
            this.txSdt.Margin = new System.Windows.Forms.Padding(5);
            this.txSdt.Name = "txSdt";
            this.txSdt.Size = new System.Drawing.Size(250, 27);
            this.txSdt.TabIndex = 23;
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesc.Location = new System.Drawing.Point(30, 250);
            this.lbDesc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(67, 20);
            this.lbDesc.TabIndex = 24;
            this.lbDesc.Text = "Ghi chú";
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(378, 204);
            this.cbAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(78, 24);
            this.cbAdmin.TabIndex = 29;
            this.cbAdmin.Text = "Admin";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // txDesc
            // 
            this.txDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txDesc.Location = new System.Drawing.Point(200, 247);
            this.txDesc.Name = "txDesc";
            this.txDesc.Size = new System.Drawing.Size(250, 27);
            this.txDesc.TabIndex = 32;
            // 
            // gb2
            // 
            this.gb2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb2.Controls.Add(this.lbMa);
            this.gb2.Controls.Add(this.btXoa);
            this.gb2.Controls.Add(this.txMa);
            this.gb2.Controls.Add(this.btSua);
            this.gb2.Controls.Add(this.btTim);
            this.gb2.Controls.Add(this.btThem);
            this.gb2.Location = new System.Drawing.Point(500, 0);
            this.gb2.Margin = new System.Windows.Forms.Padding(4);
            this.gb2.Name = "gb2";
            this.gb2.Padding = new System.Windows.Forms.Padding(4);
            this.gb2.Size = new System.Drawing.Size(500, 310);
            this.gb2.TabIndex = 33;
            this.gb2.TabStop = false;
            this.gb2.Text = "Thao tác";
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(60, 205);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(383, 20);
            this.lbMa.TabIndex = 33;
            this.lbMa.Text = "Nhập mã nhân viên để tìm kiếm, cập nhật hay xóa ";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(110, 119);
            this.btXoa.Margin = new System.Windows.Forms.Padding(5);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 50);
            this.btXoa.TabIndex = 32;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // txMa
            // 
            this.txMa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txMa.Location = new System.Drawing.Point(110, 247);
            this.txMa.Margin = new System.Windows.Forms.Padding(4);
            this.txMa.Name = "txMa";
            this.txMa.Size = new System.Drawing.Size(280, 27);
            this.txMa.TabIndex = 30;
            this.txMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txMa.Click += new System.EventHandler(this.txMa_Click);
            this.txMa.Leave += new System.EventHandler(this.txMa_Leave);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(290, 40);
            this.btSua.Margin = new System.Windows.Forms.Padding(5);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 50);
            this.btSua.TabIndex = 31;
            this.btSua.Text = "Cập nhật";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(290, 119);
            this.btTim.Margin = new System.Windows.Forms.Padding(5);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(100, 50);
            this.btTim.TabIndex = 30;
            this.btTim.Text = "Tìm kiếm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(110, 40);
            this.btThem.Margin = new System.Windows.Forms.Padding(5);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 50);
            this.btThem.TabIndex = 29;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // gb1
            // 
            this.gb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb1.Controls.Add(this.gb2);
            this.gb1.Controls.Add(this.txDesc);
            this.gb1.Controls.Add(this.cbAdmin);
            this.gb1.Controls.Add(this.lbDesc);
            this.gb1.Controls.Add(this.txSdt);
            this.gb1.Controls.Add(this.lbSdt);
            this.gb1.Controls.Add(this.txTen);
            this.gb1.Controls.Add(this.lbTen);
            this.gb1.Controls.Add(this.txHo);
            this.gb1.Controls.Add(this.lbHo);
            this.gb1.Location = new System.Drawing.Point(16, 13);
            this.gb1.Margin = new System.Windows.Forms.Padding(4);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(4);
            this.gb1.Size = new System.Drawing.Size(1000, 310);
            this.gb1.TabIndex = 50;
            this.gb1.TabStop = false;
            this.gb1.Text = "Thông tin nhân viên";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(343, 441);
            this.lbUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(84, 20);
            this.lbUser.TabIndex = 51;
            this.lbUser.Text = "Tài Khoản";
            // 
            // txUser
            // 
            this.txUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txUser.Location = new System.Drawing.Point(533, 438);
            this.txUser.Margin = new System.Windows.Forms.Padding(5);
            this.txUser.Name = "txUser";
            this.txUser.Size = new System.Drawing.Size(250, 27);
            this.txUser.TabIndex = 52;
            this.txUser.Click += new System.EventHandler(this.txPass_Click);
            this.txUser.Leave += new System.EventHandler(this.txUser_Leave);
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(343, 491);
            this.lbPass.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(80, 20);
            this.lbPass.TabIndex = 53;
            this.lbPass.Text = "Mật Khẩu";
            // 
            // txPass
            // 
            this.txPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txPass.Location = new System.Drawing.Point(533, 488);
            this.txPass.Margin = new System.Windows.Forms.Padding(5);
            this.txPass.Name = "txPass";
            this.txPass.PasswordChar = '*';
            this.txPass.Size = new System.Drawing.Size(250, 27);
            this.txPass.TabIndex = 54;
            this.txPass.Click += new System.EventHandler(this.txPass_Click);
            this.txPass.Leave += new System.EventHandler(this.txUser_Leave);
            // 
            // lbNV
            // 
            this.lbNV.AutoSize = true;
            this.lbNV.Location = new System.Drawing.Point(363, 388);
            this.lbNV.Name = "lbNV";
            this.lbNV.Size = new System.Drawing.Size(404, 20);
            this.lbNV.TabIndex = 55;
            this.lbNV.Text = "Cập nhật tài khoản hoặc mật khẩu mới nếu bạn muốn";
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1032, 682);
            this.Controls.Add(this.lbNV);
            this.Controls.Add(this.txPass);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.txUser);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.dgNV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNhanVien";
            this.Text = "Quản lý nhân viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmNhanVien_FormClosed);
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNV)).EndInit();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgNV;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label lbHo;
        private System.Windows.Forms.TextBox txHo;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.TextBox txTen;
        private System.Windows.Forms.Label lbSdt;
        private System.Windows.Forms.TextBox txSdt;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.TextBox txDesc;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.TextBox txMa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox txUser;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox txPass;
        private System.Windows.Forms.Label lbNV;
    }
}