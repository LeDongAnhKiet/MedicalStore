namespace GUI_QLNT
{
    partial class FrmHoaDon
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
            this.gpHoaDon = new System.Windows.Forms.GroupBox();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txSlg = new System.Windows.Forms.TextBox();
            this.txTen = new System.Windows.Forms.TextBox();
            this.lbSlg = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.dgHD = new System.Windows.Forms.DataGridView();
            this.btLuu = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.gpHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHD)).BeginInit();
            this.SuspendLayout();
            // 
            // gpHoaDon
            // 
            this.gpHoaDon.Controls.Add(this.lbThanhTien);
            this.gpHoaDon.Controls.Add(this.btXoa);
            this.gpHoaDon.Controls.Add(this.btSua);
            this.gpHoaDon.Controls.Add(this.btThem);
            this.gpHoaDon.Controls.Add(this.txSlg);
            this.gpHoaDon.Controls.Add(this.txTen);
            this.gpHoaDon.Controls.Add(this.lbSlg);
            this.gpHoaDon.Controls.Add(this.lbTen);
            this.gpHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpHoaDon.Location = new System.Drawing.Point(0, 0);
            this.gpHoaDon.Margin = new System.Windows.Forms.Padding(5);
            this.gpHoaDon.Name = "gpHoaDon";
            this.gpHoaDon.Padding = new System.Windows.Forms.Padding(5);
            this.gpHoaDon.Size = new System.Drawing.Size(1226, 282);
            this.gpHoaDon.TabIndex = 3;
            this.gpHoaDon.TabStop = false;
            this.gpHoaDon.Text = "Thông Tin Thuốc";
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.BackColor = System.Drawing.Color.LightCyan;
            this.lbThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhTien.Location = new System.Drawing.Point(75, 185);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(0, 25);
            this.lbThanhTien.TabIndex = 3;
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(971, 167);
            this.btXoa.Margin = new System.Windows.Forms.Padding(5);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(109, 60);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(837, 167);
            this.btSua.Margin = new System.Windows.Forms.Padding(5);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(109, 60);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(702, 167);
            this.btThem.Margin = new System.Windows.Forms.Padding(5);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(109, 60);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txSlg
            // 
            this.txSlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSlg.Location = new System.Drawing.Point(200, 72);
            this.txSlg.Margin = new System.Windows.Forms.Padding(5);
            this.txSlg.Name = "txSlg";
            this.txSlg.Size = new System.Drawing.Size(250, 30);
            this.txSlg.TabIndex = 1;
            // 
            // txTen
            // 
            this.txTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTen.Location = new System.Drawing.Point(750, 72);
            this.txTen.Margin = new System.Windows.Forms.Padding(5);
            this.txTen.Name = "txTen";
            this.txTen.Size = new System.Drawing.Size(250, 30);
            this.txTen.TabIndex = 1;
            this.txTen.Click += new System.EventHandler(this.txTen_Click);
            // 
            // lbSlg
            // 
            this.lbSlg.AutoSize = true;
            this.lbSlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSlg.Location = new System.Drawing.Point(75, 75);
            this.lbSlg.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbSlg.Name = "lbSlg";
            this.lbSlg.Size = new System.Drawing.Size(103, 25);
            this.lbSlg.TabIndex = 0;
            this.lbSlg.Text = "Số Lượng:";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(550, 75);
            this.lbTen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(160, 25);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "Tên Dược Phẩm:";
            // 
            // dgHD
            // 
            this.dgHD.AllowUserToAddRows = false;
            this.dgHD.AllowUserToDeleteRows = false;
            this.dgHD.AllowUserToOrderColumns = true;
            this.dgHD.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgHD.Location = new System.Drawing.Point(0, 282);
            this.dgHD.Margin = new System.Windows.Forms.Padding(5);
            this.dgHD.Name = "dgHD";
            this.dgHD.ReadOnly = true;
            this.dgHD.RowHeadersWidth = 51;
            this.dgHD.Size = new System.Drawing.Size(1226, 300);
            this.dgHD.TabIndex = 4;
            this.dgHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHD_CellClick);
            this.dgHD.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgHD_CellFormatting);
            this.dgHD.Leave += new System.EventHandler(this.dgHD_Leave);
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(484, 605);
            this.btLuu.Margin = new System.Windows.Forms.Padding(5);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(125, 60);
            this.btLuu.TabIndex = 4;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btHuy
            // 
            this.btHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.Location = new System.Drawing.Point(619, 605);
            this.btHuy.Margin = new System.Windows.Forms.Padding(5);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(125, 60);
            this.btHuy.TabIndex = 5;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1226, 692);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.dgHD);
            this.Controls.Add(this.gpHoaDon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmHoaDon";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.FrmHoaDon_Load);
            this.gpHoaDon.ResumeLayout(false);
            this.gpHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpHoaDon;
        private System.Windows.Forms.TextBox txSlg;
        private System.Windows.Forms.TextBox txTen;
        private System.Windows.Forms.Label lbSlg;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgHD;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btHuy;
    }
}