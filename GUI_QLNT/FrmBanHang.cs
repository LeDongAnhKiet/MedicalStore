using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_QLNT;
using DTO_QLNT;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_QLNT
{
    public partial class FrmBanHang : Form
    {
        private readonly NhanVien _loggedIn;

        private BUS_Loai busLoai = new BUS_Loai();

        private BUS_DuocPham busDP = new BUS_DuocPham();

        public FrmBanHang(NhanVien nv)
        {
            InitializeComponent();
            _loggedIn = nv;
        }

        private void init()
        {            
            cbLoai.Enabled = false;
            txTen.ReadOnly = true;
            txTen.Text = cbLoai.Text = "";
            dtNgay.Format = DateTimePickerFormat.Custom;
            dtNgay.CustomFormat = "dd/MM/yyyy";
            dtNgay.Value = DateTime.Now;
        }

        protected void FilldgThuoc(int ma, string ten)
        {
            dgThuoc.DataSource = busDP.getDuocPham(ma, ten);
            if (dgThuoc.DataSource == null ) { lbThuoc.Text = "Không tìm thấy Thuốc theo yêu cầu!"; return; }
            else lbThuoc.Text = "";
            dgThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgThuoc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewColumn col in dgThuoc.Columns)
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            cbLoai.DataSource = busLoai.getLoai();
            FilldgThuoc(0, "");
            cbLoai.Text = "";
            init();
            if (!_loggedIn.La_Admin) LoggedUser();
            tcBanHang.SelectedIndex = 1;
        }

        private void LoggedUser()
        {
            baoCaoTSMI.Visible = false;
        }

        private void NhanVienTSMI_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmHoaDon"] != null) 
                Application.OpenForms["FrmHoaDon"].Hide();
            this.Hide();
            FrmNhanVien f = new FrmNhanVien(_loggedIn);
            f.ShowDialog();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chắc không?", "Đang thoát...",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (d == DialogResult.Yes) Application.Exit();
        }

        private void FrmBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (!rbLoai.Checked && !rbTen.Checked) return;
            Loai l = null;
            if (rbLoai.Checked) l = busLoai.timLoai(cbLoai.SelectedItem.ToString());
            FilldgThuoc(l == null ? 0 : l.MaLoai, txTen.Text);
        }

        private void rbTen_Click(object sender, EventArgs e)
        {
            if (rbTen.Checked)
            {
                txTen.ReadOnly = cbLoai.Enabled = false;
                cbLoai.Text = "";
            }
            else
            {
                txTen.ReadOnly = cbLoai.Enabled = true;
                txTen.Text = "";
            }
        }

        private void dgThuoc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgThuoc.Columns[e.ColumnIndex].Name == "Đơn giá" && e.Value != null)
                e.Value = string.Format("{0:#,#}", Convert.ToDecimal(e.Value));
            else if (dgThuoc.Columns[e.ColumnIndex].Name == "Hạn sử dụng" && e.Value != null)
                e.Value = DateTime.Parse(e.Value.ToString()).ToString("dd/MM/yyyy");
            return;
        }

        private void dgThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tenThuoc = dgThuoc.Rows[e.RowIndex].Cells["Tên thuốc"].Value.ToString();
            txTen.Text = tenThuoc;
            FrmHoaDon f = Application.OpenForms.OfType<FrmHoaDon>().FirstOrDefault();
            if (f != null && tenThuoc != "")
                f.tenThuoc = tenThuoc;
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            if (txTenKH.Text == "" || txHoKH.Text == "")
            { MessageBox.Show("Vui lòng nhập đầy đủ thông tin!"); return; }
            BUS_KhachHang busKH = new BUS_KhachHang();
            if (busKH.themKhachHang(txHoKH.Text, txTenKH.Text, txSdt.Text, txDesc.Text, cbKeDon.Checked))
            {
                KhachHang khachHang = busKH.timKhachHang(txHoKH.Text, txTenKH.Text);
                BUS_HoaDon busHD = new BUS_HoaDon();
                HoaDon hoaDon = busHD.themHoaDon(khachHang.MaKH, _loggedIn.MaNV, dtNgay.Value);
                FrmHoaDon f = new FrmHoaDon(hoaDon, this);
                f.FormClosed += FrmHoaDon_FormClosed;
                f.Show();
                btNhap.Enabled = NhanVienTSMI.Enabled = KhoTSMI.Enabled = false;
            }
            else MessageBox.Show("Đã có lỗi xảy ra!");
        }

        private void FrmHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            btNhap.Enabled = NhanVienTSMI.Enabled = KhoTSMI.Enabled = true;
        }

        private void txTen_TextChanged(object sender, EventArgs e)
        {
            FilldgThuoc(0, txTen.Text);
        }

        public void RefreshDGThuoc(int ma, string ten)
        {
            FilldgThuoc(ma, ten);
        }

        private void KhoTSMI_Click(object sender, EventArgs e)
        {
            //BUS_NhapKho busPN = new BUS_NhapKho();
            //PhieuNhap phieuNhap = busPN.taoPhieuNhap(nhaCungCap.MaNCC, _loggedIn.MaNV, dtNgay.Value);

            FrmKhoHang f = new FrmKhoHang(/*Phiếu nhập, this*/);
            f.FormClosed += FrmHoaDon_FormClosed;
            f.Show();
            btNhap.Enabled = NhanVienTSMI.Enabled = KhoTSMI.Enabled = false;
        }

        private void ChiTieuTSMI_Click(object sender, EventArgs e)
        {
            FrmChiTieu f = new FrmChiTieu(_loggedIn);
            this.Hide();
            f.ShowDialog();
        }

        private void DoanhThuTSMI_Click(object sender, EventArgs e)
        {
            FrmDoanhThu f = new FrmDoanhThu(_loggedIn);
            this.Hide();
            f.ShowDialog();
        }
    }
}
