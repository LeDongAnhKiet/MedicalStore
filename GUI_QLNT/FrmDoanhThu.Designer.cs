namespace GUI_QLNT
{
    partial class FrmDoanhThu
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
            this.gbThoiGian = new System.Windows.Forms.GroupBox();
            this.lbTKeNgay = new System.Windows.Forms.Label();
            this.btLocNgay = new System.Windows.Forms.Button();
            this.lbKT = new System.Windows.Forms.Label();
            this.dtKT = new System.Windows.Forms.DateTimePicker();
            this.lbBD = new System.Windows.Forms.Label();
            this.dtBD = new System.Windows.Forms.DateTimePicker();
            this.gbHoaDon = new System.Windows.Forms.GroupBox();
            this.lbDT = new System.Windows.Forms.Label();
            this.dgDoanhThu = new System.Windows.Forms.DataGridView();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTKeLoai = new System.Windows.Forms.Label();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.lbLoai = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTKeNV = new System.Windows.Forms.Label();
            this.txUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbThoiGian.SuspendLayout();
            this.gbHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoanhThu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThoiGian
            // 
            this.gbThoiGian.Controls.Add(this.lbTKeNgay);
            this.gbThoiGian.Controls.Add(this.btLocNgay);
            this.gbThoiGian.Controls.Add(this.lbKT);
            this.gbThoiGian.Controls.Add(this.dtKT);
            this.gbThoiGian.Controls.Add(this.lbBD);
            this.gbThoiGian.Controls.Add(this.dtBD);
            this.gbThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThoiGian.Location = new System.Drawing.Point(20, 19);
            this.gbThoiGian.Margin = new System.Windows.Forms.Padding(5);
            this.gbThoiGian.Name = "gbThoiGian";
            this.gbThoiGian.Padding = new System.Windows.Forms.Padding(5);
            this.gbThoiGian.Size = new System.Drawing.Size(470, 275);
            this.gbThoiGian.TabIndex = 2;
            this.gbThoiGian.TabStop = false;
            this.gbThoiGian.Text = "Lọc theo Ngày lập";
            // 
            // lbTKeNgay
            // 
            this.lbTKeNgay.AutoSize = true;
            this.lbTKeNgay.Location = new System.Drawing.Point(21, 206);
            this.lbTKeNgay.Name = "lbTKeNgay";
            this.lbTKeNgay.Size = new System.Drawing.Size(0, 25);
            this.lbTKeNgay.TabIndex = 3;
            // 
            // btLocNgay
            // 
            this.btLocNgay.Location = new System.Drawing.Point(316, 196);
            this.btLocNgay.Margin = new System.Windows.Forms.Padding(5);
            this.btLocNgay.Name = "btLocNgay";
            this.btLocNgay.Size = new System.Drawing.Size(125, 45);
            this.btLocNgay.TabIndex = 2;
            this.btLocNgay.Text = "Lọc";
            this.btLocNgay.UseVisualStyleBackColor = true;
            this.btLocNgay.Click += new System.EventHandler(this.btLocNgay_Click);
            // 
            // lbKT
            // 
            this.lbKT.AutoSize = true;
            this.lbKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKT.Location = new System.Drawing.Point(21, 129);
            this.lbKT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbKT.Name = "lbKT";
            this.lbKT.Size = new System.Drawing.Size(163, 29);
            this.lbKT.TabIndex = 1;
            this.lbKT.Text = "Ngày kết thúc:";
            // 
            // dtKT
            // 
            this.dtKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtKT.Location = new System.Drawing.Point(206, 129);
            this.dtKT.Margin = new System.Windows.Forms.Padding(5);
            this.dtKT.Name = "dtKT";
            this.dtKT.Size = new System.Drawing.Size(235, 30);
            this.dtKT.TabIndex = 0;
            // 
            // lbBD
            // 
            this.lbBD.AutoSize = true;
            this.lbBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBD.Location = new System.Drawing.Point(21, 65);
            this.lbBD.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbBD.Name = "lbBD";
            this.lbBD.Size = new System.Drawing.Size(160, 29);
            this.lbBD.TabIndex = 1;
            this.lbBD.Text = "Ngày bắt đầu:";
            // 
            // dtBD
            // 
            this.dtBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBD.Location = new System.Drawing.Point(206, 65);
            this.dtBD.Margin = new System.Windows.Forms.Padding(5);
            this.dtBD.Name = "dtBD";
            this.dtBD.Size = new System.Drawing.Size(235, 30);
            this.dtBD.TabIndex = 0;
            // 
            // gbHoaDon
            // 
            this.gbHoaDon.Controls.Add(this.lbDT);
            this.gbHoaDon.Controls.Add(this.dgDoanhThu);
            this.gbHoaDon.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHoaDon.Location = new System.Drawing.Point(511, 0);
            this.gbHoaDon.Margin = new System.Windows.Forms.Padding(5);
            this.gbHoaDon.Name = "gbHoaDon";
            this.gbHoaDon.Padding = new System.Windows.Forms.Padding(5);
            this.gbHoaDon.Size = new System.Drawing.Size(874, 756);
            this.gbHoaDon.TabIndex = 3;
            this.gbHoaDon.TabStop = false;
            this.gbHoaDon.Text = "Bảng thống kê";
            // 
            // lbDT
            // 
            this.lbDT.AutoSize = true;
            this.lbDT.Location = new System.Drawing.Point(9, 32);
            this.lbDT.Name = "lbDT";
            this.lbDT.Size = new System.Drawing.Size(0, 25);
            this.lbDT.TabIndex = 1;
            // 
            // dgDoanhThu
            // 
            this.dgDoanhThu.AllowUserToAddRows = false;
            this.dgDoanhThu.AllowUserToDeleteRows = false;
            this.dgDoanhThu.AllowUserToOrderColumns = true;
            this.dgDoanhThu.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDoanhThu.Location = new System.Drawing.Point(5, 28);
            this.dgDoanhThu.Margin = new System.Windows.Forms.Padding(5);
            this.dgDoanhThu.Name = "dgDoanhThu";
            this.dgDoanhThu.ReadOnly = true;
            this.dgDoanhThu.RowHeadersWidth = 51;
            this.dgDoanhThu.Size = new System.Drawing.Size(864, 723);
            this.dgDoanhThu.TabIndex = 0;
            this.dgDoanhThu.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgDoanhThu_CellFormatting);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(172, 670);
            this.btThoat.Margin = new System.Windows.Forms.Padding(5);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(168, 74);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Quay lại";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTKeLoai);
            this.groupBox1.Controls.Add(this.cbLoai);
            this.groupBox1.Controls.Add(this.lbLoai);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 178);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc theo Loại";
            // 
            // lbTKeLoai
            // 
            this.lbTKeLoai.AutoSize = true;
            this.lbTKeLoai.Location = new System.Drawing.Point(21, 111);
            this.lbTKeLoai.Name = "lbTKeLoai";
            this.lbTKeLoai.Size = new System.Drawing.Size(0, 25);
            this.lbTKeLoai.TabIndex = 4;
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(206, 46);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(235, 33);
            this.cbLoai.TabIndex = 1;
            this.cbLoai.SelectedIndexChanged += new System.EventHandler(this.cbLoai_SelectedIndexChanged);
            // 
            // lbLoai
            // 
            this.lbLoai.AutoSize = true;
            this.lbLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoai.Location = new System.Drawing.Point(21, 46);
            this.lbLoai.Name = "lbLoai";
            this.lbLoai.Size = new System.Drawing.Size(129, 29);
            this.lbLoai.TabIndex = 0;
            this.lbLoai.Text = "Loại thuốc:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTKeNV);
            this.groupBox2.Controls.Add(this.txUser);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 486);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 170);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc theo Nhân viên";
            // 
            // lbTKeNV
            // 
            this.lbTKeNV.AutoSize = true;
            this.lbTKeNV.Location = new System.Drawing.Point(21, 109);
            this.lbTKeNV.Name = "lbTKeNV";
            this.lbTKeNV.Size = new System.Drawing.Size(0, 25);
            this.lbTKeNV.TabIndex = 5;
            // 
            // txUser
            // 
            this.txUser.Location = new System.Drawing.Point(206, 46);
            this.txUser.Name = "txUser";
            this.txUser.Size = new System.Drawing.Size(235, 30);
            this.txUser.TabIndex = 4;
            this.txUser.TextChanged += new System.EventHandler(this.txUser_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và Tên:";
            // 
            // FrmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1385, 756);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.gbHoaDon);
            this.Controls.Add(this.gbThoiGian);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmDoanhThu";
            this.Text = "Báo cáo Doanh Thu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDoanhThu_FormClosed);
            this.Load += new System.EventHandler(this.FrmDoanhThu_Load);
            this.gbThoiGian.ResumeLayout(false);
            this.gbThoiGian.PerformLayout();
            this.gbHoaDon.ResumeLayout(false);
            this.gbHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoanhThu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThoiGian;
        private System.Windows.Forms.Button btLocNgay;
        private System.Windows.Forms.Label lbKT;
        private System.Windows.Forms.DateTimePicker dtKT;
        private System.Windows.Forms.Label lbBD;
        private System.Windows.Forms.DateTimePicker dtBD;
        private System.Windows.Forms.GroupBox gbHoaDon;
        private System.Windows.Forms.DataGridView dgDoanhThu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label lbDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.Label lbLoai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTKeNgay;
        private System.Windows.Forms.Label lbTKeLoai;
        private System.Windows.Forms.Label lbTKeNV;
    }
}