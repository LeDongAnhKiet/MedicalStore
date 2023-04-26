namespace GUI_QLNT
{
    partial class FrmBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcBanHang = new System.Windows.Forms.TabControl();
            this.tpTim = new System.Windows.Forms.TabPage();
            this.lbThuoc = new System.Windows.Forms.Label();
            this.dgThuoc = new System.Windows.Forms.DataGridView();
            this.pBanHang = new System.Windows.Forms.Panel();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.btTim = new System.Windows.Forms.Button();
            this.txTen = new System.Windows.Forms.TextBox();
            this.rbLoai = new System.Windows.Forms.RadioButton();
            this.rbTen = new System.Windows.Forms.RadioButton();
            this.tpHoaDon = new System.Windows.Forms.TabPage();
            this.spcHoaDon = new System.Windows.Forms.SplitContainer();
            this.lbHoaDon = new System.Windows.Forms.Label();
            this.gpHoaDon = new System.Windows.Forms.GroupBox();
            this.cbKeDon = new System.Windows.Forms.CheckBox();
            this.txTenKH = new System.Windows.Forms.TextBox();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.txHoKH = new System.Windows.Forms.TextBox();
            this.txDesc = new System.Windows.Forms.TextBox();
            this.txSdt = new System.Windows.Forms.TextBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbHoKH = new System.Windows.Forms.Label();
            this.lbSdt = new System.Windows.Forms.Label();
            this.lbNgay = new System.Windows.Forms.Label();
            this.btNhap = new System.Windows.Forms.Button();
            this.pHoaDon = new System.Windows.Forms.Panel();
            this.msBanHang = new System.Windows.Forms.MenuStrip();
            this.KhoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DoanhThuTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ChiTieuTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.NhanVienTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.btThoat = new System.Windows.Forms.Button();
            this.tcBanHang.SuspendLayout();
            this.tpTim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgThuoc)).BeginInit();
            this.pBanHang.SuspendLayout();
            this.tpHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHoaDon)).BeginInit();
            this.spcHoaDon.Panel1.SuspendLayout();
            this.spcHoaDon.Panel2.SuspendLayout();
            this.spcHoaDon.SuspendLayout();
            this.gpHoaDon.SuspendLayout();
            this.msBanHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcBanHang
            // 
            this.tcBanHang.Controls.Add(this.tpTim);
            this.tcBanHang.Controls.Add(this.tpHoaDon);
            this.tcBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tcBanHang.Location = new System.Drawing.Point(0, 42);
            this.tcBanHang.Margin = new System.Windows.Forms.Padding(5);
            this.tcBanHang.Name = "tcBanHang";
            this.tcBanHang.SelectedIndex = 0;
            this.tcBanHang.Size = new System.Drawing.Size(1334, 631);
            this.tcBanHang.TabIndex = 0;
            // 
            // tpTim
            // 
            this.tpTim.BackColor = System.Drawing.Color.LightCyan;
            this.tpTim.Controls.Add(this.lbThuoc);
            this.tpTim.Controls.Add(this.dgThuoc);
            this.tpTim.Controls.Add(this.pBanHang);
            this.tpTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tpTim.Location = new System.Drawing.Point(4, 34);
            this.tpTim.Margin = new System.Windows.Forms.Padding(5);
            this.tpTim.Name = "tpTim";
            this.tpTim.Padding = new System.Windows.Forms.Padding(5);
            this.tpTim.Size = new System.Drawing.Size(1326, 593);
            this.tpTim.TabIndex = 0;
            this.tpTim.Text = "Tìm Kiếm";
            // 
            // lbThuoc
            // 
            this.lbThuoc.AutoSize = true;
            this.lbThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThuoc.Location = new System.Drawing.Point(9, 317);
            this.lbThuoc.Name = "lbThuoc";
            this.lbThuoc.Size = new System.Drawing.Size(0, 29);
            this.lbThuoc.TabIndex = 2;
            // 
            // dgThuoc
            // 
            this.dgThuoc.AllowUserToAddRows = false;
            this.dgThuoc.AllowUserToDeleteRows = false;
            this.dgThuoc.AllowUserToOrderColumns = true;
            this.dgThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgThuoc.BackgroundColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgThuoc.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgThuoc.Location = new System.Drawing.Point(0, 306);
            this.dgThuoc.Margin = new System.Windows.Forms.Padding(5);
            this.dgThuoc.Name = "dgThuoc";
            this.dgThuoc.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgThuoc.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgThuoc.Size = new System.Drawing.Size(1320, 282);
            this.dgThuoc.TabIndex = 1;
            this.dgThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgThuoc_CellClick);
            this.dgThuoc.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgThuoc_CellFormatting);
            // 
            // pBanHang
            // 
            this.pBanHang.BackColor = System.Drawing.Color.LightCyan;
            this.pBanHang.Controls.Add(this.cbLoai);
            this.pBanHang.Controls.Add(this.btTim);
            this.pBanHang.Controls.Add(this.txTen);
            this.pBanHang.Controls.Add(this.rbLoai);
            this.pBanHang.Controls.Add(this.rbTen);
            this.pBanHang.Location = new System.Drawing.Point(0, 0);
            this.pBanHang.Margin = new System.Windows.Forms.Padding(5);
            this.pBanHang.Name = "pBanHang";
            this.pBanHang.Size = new System.Drawing.Size(1320, 308);
            this.pBanHang.TabIndex = 0;
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(385, 139);
            this.cbLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(673, 46);
            this.cbLoai.TabIndex = 3;
            // 
            // btTim
            // 
            this.btTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btTim.Location = new System.Drawing.Point(854, 219);
            this.btTim.Margin = new System.Windows.Forms.Padding(5);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(206, 58);
            this.btTim.TabIndex = 2;
            this.btTim.Text = "Tìm Kiếm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // txTen
            // 
            this.txTen.Location = new System.Drawing.Point(385, 48);
            this.txTen.Margin = new System.Windows.Forms.Padding(5);
            this.txTen.Name = "txTen";
            this.txTen.Size = new System.Drawing.Size(673, 45);
            this.txTen.TabIndex = 1;
            this.txTen.TextChanged += new System.EventHandler(this.txTen_TextChanged);
            // 
            // rbLoai
            // 
            this.rbLoai.AutoSize = true;
            this.rbLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rbLoai.Location = new System.Drawing.Point(139, 149);
            this.rbLoai.Margin = new System.Windows.Forms.Padding(5);
            this.rbLoai.Name = "rbLoai";
            this.rbLoai.Size = new System.Drawing.Size(159, 33);
            this.rbLoai.TabIndex = 0;
            this.rbLoai.TabStop = true;
            this.rbLoai.Text = "Loại Thuốc";
            this.rbLoai.UseVisualStyleBackColor = true;
            this.rbLoai.Click += new System.EventHandler(this.rbTen_Click);
            // 
            // rbTen
            // 
            this.rbTen.AutoSize = true;
            this.rbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rbTen.Location = new System.Drawing.Point(139, 59);
            this.rbTen.Margin = new System.Windows.Forms.Padding(5);
            this.rbTen.Name = "rbTen";
            this.rbTen.Size = new System.Drawing.Size(146, 33);
            this.rbTen.TabIndex = 0;
            this.rbTen.TabStop = true;
            this.rbTen.Text = "Tên thuốc";
            this.rbTen.UseVisualStyleBackColor = true;
            this.rbTen.Click += new System.EventHandler(this.rbTen_Click);
            // 
            // tpHoaDon
            // 
            this.tpHoaDon.BackColor = System.Drawing.Color.LightCyan;
            this.tpHoaDon.Controls.Add(this.spcHoaDon);
            this.tpHoaDon.Location = new System.Drawing.Point(4, 34);
            this.tpHoaDon.Margin = new System.Windows.Forms.Padding(5);
            this.tpHoaDon.Name = "tpHoaDon";
            this.tpHoaDon.Padding = new System.Windows.Forms.Padding(5);
            this.tpHoaDon.Size = new System.Drawing.Size(1326, 593);
            this.tpHoaDon.TabIndex = 1;
            this.tpHoaDon.Text = "Hóa Đơn";
            // 
            // spcHoaDon
            // 
            this.spcHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcHoaDon.Location = new System.Drawing.Point(5, 5);
            this.spcHoaDon.Margin = new System.Windows.Forms.Padding(5);
            this.spcHoaDon.Name = "spcHoaDon";
            this.spcHoaDon.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcHoaDon.Panel1
            // 
            this.spcHoaDon.Panel1.BackColor = System.Drawing.Color.LightCyan;
            this.spcHoaDon.Panel1.Controls.Add(this.lbHoaDon);
            this.spcHoaDon.Panel1.Controls.Add(this.gpHoaDon);
            // 
            // spcHoaDon.Panel2
            // 
            this.spcHoaDon.Panel2.BackColor = System.Drawing.Color.LightCyan;
            this.spcHoaDon.Panel2.Controls.Add(this.btNhap);
            this.spcHoaDon.Panel2.Controls.Add(this.pHoaDon);
            this.spcHoaDon.Size = new System.Drawing.Size(1316, 583);
            this.spcHoaDon.SplitterDistance = 343;
            this.spcHoaDon.SplitterWidth = 6;
            this.spcHoaDon.TabIndex = 0;
            // 
            // lbHoaDon
            // 
            this.lbHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbHoaDon.Location = new System.Drawing.Point(0, 0);
            this.lbHoaDon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbHoaDon.Name = "lbHoaDon";
            this.lbHoaDon.Size = new System.Drawing.Size(1316, 75);
            this.lbHoaDon.TabIndex = 2;
            this.lbHoaDon.Text = "Lập Hóa Đơn Thuốc";
            this.lbHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpHoaDon
            // 
            this.gpHoaDon.Controls.Add(this.cbKeDon);
            this.gpHoaDon.Controls.Add(this.txTenKH);
            this.gpHoaDon.Controls.Add(this.lbTenKH);
            this.gpHoaDon.Controls.Add(this.dtNgay);
            this.gpHoaDon.Controls.Add(this.txHoKH);
            this.gpHoaDon.Controls.Add(this.txDesc);
            this.gpHoaDon.Controls.Add(this.txSdt);
            this.gpHoaDon.Controls.Add(this.lbDesc);
            this.gpHoaDon.Controls.Add(this.lbHoKH);
            this.gpHoaDon.Controls.Add(this.lbSdt);
            this.gpHoaDon.Controls.Add(this.lbNgay);
            this.gpHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpHoaDon.Location = new System.Drawing.Point(0, 97);
            this.gpHoaDon.Margin = new System.Windows.Forms.Padding(5);
            this.gpHoaDon.Name = "gpHoaDon";
            this.gpHoaDon.Padding = new System.Windows.Forms.Padding(5);
            this.gpHoaDon.Size = new System.Drawing.Size(1316, 246);
            this.gpHoaDon.TabIndex = 0;
            this.gpHoaDon.TabStop = false;
            this.gpHoaDon.Text = "Thông Tin Chung";
            // 
            // cbKeDon
            // 
            this.cbKeDon.AutoSize = true;
            this.cbKeDon.Location = new System.Drawing.Point(708, 189);
            this.cbKeDon.Name = "cbKeDon";
            this.cbKeDon.Size = new System.Drawing.Size(119, 29);
            this.cbKeDon.TabIndex = 5;
            this.cbKeDon.Text = "Tái Khám";
            this.cbKeDon.UseVisualStyleBackColor = true;
            // 
            // txTenKH
            // 
            this.txTenKH.Location = new System.Drawing.Point(324, 187);
            this.txTenKH.Margin = new System.Windows.Forms.Padding(5);
            this.txTenKH.Name = "txTenKH";
            this.txTenKH.Size = new System.Drawing.Size(224, 30);
            this.txTenKH.TabIndex = 4;
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Location = new System.Drawing.Point(77, 190);
            this.lbTenKH.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(164, 25);
            this.lbTenKH.TabIndex = 3;
            this.lbTenKH.Text = "Tên Khách hàng:";
            // 
            // dtNgay
            // 
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(324, 54);
            this.dtNgay.Margin = new System.Windows.Forms.Padding(5);
            this.dtNgay.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtNgay.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(224, 30);
            this.dtNgay.TabIndex = 2;
            this.dtNgay.Value = new System.DateTime(2023, 4, 24, 9, 46, 0, 0);
            // 
            // txHoKH
            // 
            this.txHoKH.Location = new System.Drawing.Point(324, 122);
            this.txHoKH.Margin = new System.Windows.Forms.Padding(5);
            this.txHoKH.Name = "txHoKH";
            this.txHoKH.Size = new System.Drawing.Size(224, 30);
            this.txHoKH.TabIndex = 1;
            // 
            // txDesc
            // 
            this.txDesc.Location = new System.Drawing.Point(951, 122);
            this.txDesc.Margin = new System.Windows.Forms.Padding(5);
            this.txDesc.Name = "txDesc";
            this.txDesc.Size = new System.Drawing.Size(224, 30);
            this.txDesc.TabIndex = 1;
            // 
            // txSdt
            // 
            this.txSdt.Location = new System.Drawing.Point(951, 57);
            this.txSdt.Margin = new System.Windows.Forms.Padding(5);
            this.txSdt.Name = "txSdt";
            this.txSdt.Size = new System.Drawing.Size(224, 30);
            this.txSdt.TabIndex = 1;
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(704, 125);
            this.lbDesc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(85, 25);
            this.lbDesc.TabIndex = 0;
            this.lbDesc.Text = "Ghi chú:";
            // 
            // lbHoKH
            // 
            this.lbHoKH.AutoSize = true;
            this.lbHoKH.Location = new System.Drawing.Point(74, 125);
            this.lbHoKH.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbHoKH.Name = "lbHoKH";
            this.lbHoKH.Size = new System.Drawing.Size(154, 25);
            this.lbHoKH.TabIndex = 0;
            this.lbHoKH.Text = "Họ Khách hàng:";
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.Location = new System.Drawing.Point(704, 60);
            this.lbSdt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(132, 25);
            this.lbSdt.TabIndex = 0;
            this.lbSdt.Text = "Số điện thoại:";
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Location = new System.Drawing.Point(74, 60);
            this.lbNgay.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(95, 25);
            this.lbNgay.TabIndex = 0;
            this.lbNgay.Text = "Ngày lập:";
            // 
            // btNhap
            // 
            this.btNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhap.Location = new System.Drawing.Point(605, 82);
            this.btNhap.Margin = new System.Windows.Forms.Padding(5);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(120, 60);
            this.btNhap.TabIndex = 0;
            this.btNhap.Text = "Nhập";
            this.btNhap.UseVisualStyleBackColor = true;
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // pHoaDon
            // 
            this.pHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pHoaDon.Location = new System.Drawing.Point(0, 160);
            this.pHoaDon.Margin = new System.Windows.Forms.Padding(5);
            this.pHoaDon.Name = "pHoaDon";
            this.pHoaDon.Size = new System.Drawing.Size(1316, 74);
            this.pHoaDon.TabIndex = 1;
            // 
            // msBanHang
            // 
            this.msBanHang.BackColor = System.Drawing.Color.LightCyan;
            this.msBanHang.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msBanHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KhoTSMI,
            this.baoCaoTSMI,
            this.NhanVienTSMI});
            this.msBanHang.Location = new System.Drawing.Point(0, 0);
            this.msBanHang.Name = "msBanHang";
            this.msBanHang.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.msBanHang.Size = new System.Drawing.Size(1334, 31);
            this.msBanHang.TabIndex = 1;
            this.msBanHang.Text = "menuStrip1";
            // 
            // KhoTSMI
            // 
            this.KhoTSMI.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhoTSMI.Name = "KhoTSMI";
            this.KhoTSMI.Size = new System.Drawing.Size(100, 27);
            this.KhoTSMI.Text = "Kho Hàng";
            this.KhoTSMI.Click += new System.EventHandler(this.KhoTSMI_Click);
            // 
            // baoCaoTSMI
            // 
            this.baoCaoTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DoanhThuTSMI,
            this.ChiTieuTSMI});
            this.baoCaoTSMI.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baoCaoTSMI.Name = "baoCaoTSMI";
            this.baoCaoTSMI.Size = new System.Drawing.Size(88, 27);
            this.baoCaoTSMI.Text = "Báo Cáo";
            // 
            // DoanhThuTSMI
            // 
            this.DoanhThuTSMI.Name = "DoanhThuTSMI";
            this.DoanhThuTSMI.Size = new System.Drawing.Size(176, 28);
            this.DoanhThuTSMI.Text = "Doanh thu";
            this.DoanhThuTSMI.Click += new System.EventHandler(this.DoanhThuTSMI_Click);
            // 
            // ChiTieuTSMI
            // 
            this.ChiTieuTSMI.Name = "ChiTieuTSMI";
            this.ChiTieuTSMI.Size = new System.Drawing.Size(176, 28);
            this.ChiTieuTSMI.Text = "Chi tiêu";
            this.ChiTieuTSMI.Click += new System.EventHandler(this.ChiTieuTSMI_Click);
            // 
            // NhanVienTSMI
            // 
            this.NhanVienTSMI.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhanVienTSMI.Name = "NhanVienTSMI";
            this.NhanVienTSMI.Size = new System.Drawing.Size(102, 27);
            this.NhanVienTSMI.Text = "Nhân viên";
            this.NhanVienTSMI.Click += new System.EventHandler(this.NhanVienTSMI_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btThoat.Location = new System.Drawing.Point(570, 705);
            this.btThoat.Margin = new System.Windows.Forms.Padding(5);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(206, 58);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1334, 798);
            this.Controls.Add(this.tcBanHang);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.msBanHang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.msBanHang;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmBanHang";
            this.Text = "Bán hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBanHang_FormClosed);
            this.Load += new System.EventHandler(this.FrmBanHang_Load);
            this.tcBanHang.ResumeLayout(false);
            this.tpTim.ResumeLayout(false);
            this.tpTim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgThuoc)).EndInit();
            this.pBanHang.ResumeLayout(false);
            this.pBanHang.PerformLayout();
            this.tpHoaDon.ResumeLayout(false);
            this.spcHoaDon.Panel1.ResumeLayout(false);
            this.spcHoaDon.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHoaDon)).EndInit();
            this.spcHoaDon.ResumeLayout(false);
            this.gpHoaDon.ResumeLayout(false);
            this.gpHoaDon.PerformLayout();
            this.msBanHang.ResumeLayout(false);
            this.msBanHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcBanHang;
        private System.Windows.Forms.TabPage tpTim;
        private System.Windows.Forms.TabPage tpHoaDon;
        private System.Windows.Forms.MenuStrip msBanHang;
        private System.Windows.Forms.ToolStripMenuItem KhoTSMI;
        private System.Windows.Forms.DataGridView dgThuoc;
        private System.Windows.Forms.Panel pBanHang;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.TextBox txTen;
        private System.Windows.Forms.RadioButton rbLoai;
        private System.Windows.Forms.RadioButton rbTen;
        private System.Windows.Forms.SplitContainer spcHoaDon;
        private System.Windows.Forms.Label lbHoaDon;
        private System.Windows.Forms.GroupBox gpHoaDon;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.TextBox txHoKH;
        private System.Windows.Forms.TextBox txDesc;
        private System.Windows.Forms.TextBox txSdt;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbHoKH;
        private System.Windows.Forms.Label lbSdt;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Panel pHoaDon;
        private System.Windows.Forms.ToolStripMenuItem baoCaoTSMI;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.ToolStripMenuItem DoanhThuTSMI;
        private System.Windows.Forms.ToolStripMenuItem ChiTieuTSMI;
        private System.Windows.Forms.ToolStripMenuItem NhanVienTSMI;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.Label lbThuoc;
        private System.Windows.Forms.CheckBox cbKeDon;
        private System.Windows.Forms.TextBox txTenKH;
        private System.Windows.Forms.Label lbTenKH;
    }
}