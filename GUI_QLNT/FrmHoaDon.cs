using BUS_QLNT;
using DTO_QLNT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLNT
{
    public partial class FrmHoaDon : Form
    {
        private HoaDon _hoaDon; 

        private BUS_HoaDon busHD = new BUS_HoaDon();

        private FrmBanHang _banHang;

        public string tenThuoc { get; set; }

        public FrmHoaDon( HoaDon hoaDon, FrmBanHang f)
        {
            InitializeComponent();
            _hoaDon = hoaDon;
            this._banHang = f;
        }

        private void FilldgHD()
        {
            dgHD.DataSource = busHD.getDuocPham(_hoaDon.MaKH);
            dgHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn col in dgHD.Columns)
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            FilldgHD();
            string thanhTien = string.Format("{0:#,#}", busHD.tinhThanhTien(_hoaDon.MaHD));
            lbThanhTien.Text = "Thành tiền: " + thanhTien != "" ? thanhTien : "0";
        }

        private void txTen_Click(object sender, EventArgs e)
        {
            txTen.Text = tenThuoc;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txTen.Text == "" || txSlg.Text == "" || txSlg.Text == "0")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else if (busHD.themDuocPham(txTen.Text, int.Parse(txSlg.Text), _hoaDon.MaHD))
            { 
                FilldgHD();
                lbThanhTien.Text = "Thành tiền: " + string.Format("{0:#,#}", busHD.tinhThanhTien(_hoaDon.MaHD));
                _banHang.RefreshDGThuoc(0, "");
            }
            else MessageBox.Show("Đã có lỗi xảy ra!");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txTen.Text == "" || txSlg.Text == "" || txSlg.Text == "0")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else if (busHD.suaDuocPham(txTen.Text, int.Parse(txSlg.Text), _hoaDon.MaHD))
            {
                FilldgHD();
                lbThanhTien.Text = "Thành tiền: " + string.Format("{0:#,#}", busHD.tinhThanhTien(_hoaDon.MaHD));
                _banHang.RefreshDGThuoc(0, "");
            }
            else MessageBox.Show("Đã có lỗi xảy ra!");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txTen.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else if (busHD.xoaDuocPham(txTen.Text, _hoaDon.MaHD))
            {
                FilldgHD();
                lbThanhTien.Text = "Thành tiền: " + string.Format("{0:#,#}", busHD.tinhThanhTien(_hoaDon.MaHD));
                _banHang.RefreshDGThuoc(0, "");
            }
            else MessageBox.Show("Đã có lỗi xảy ra!");
        }

        private void dgHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txTen.Text = dgHD.Rows[e.RowIndex].Cells["Tên thuốc"].Value.ToString();
            txSlg.Text = dgHD.Rows[e.RowIndex].Cells["Số lượng"].Value.ToString();
            var donGia = decimal.Parse(dgHD.Rows[e.RowIndex].Cells["Đơn giá"].Value.ToString());
            var thuoc = int.Parse(txSlg.Text) * donGia;
            lbThanhTien.Text = "Giá thuốc: " + string.Format("{0:#,#}", Convert.ToDecimal(thuoc));
        }

        private void dgHD_Leave(object sender, EventArgs e)
        {
            lbThanhTien.Text = "Thành tiền: " + string.Format("{0:#,#}", busHD.tinhThanhTien(_hoaDon.MaHD));
        }

        private void dgHD_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgHD.Columns[e.ColumnIndex].Name == "Đơn giá" && e.Value != null)
                e.Value = string.Format("{0:#,#}", Convert.ToDecimal(e.Value));
            else if (dgHD.Columns[e.ColumnIndex].Name == "Hạn sử dụng" && e.Value != null)
                e.Value = DateTime.Parse(e.Value.ToString()).ToString("dd/MM/yyyy");
            return;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (dgHD.DataSource == null)
                MessageBox.Show("Không có thuốc để lưu!");
            else this.Close();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            if (dgHD.DataSource != null)
                if (MessageBox.Show("Bạn có muốn hủy Hóa đơn chưa lưu không?", "Đang hủy...",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
                { busHD.huyHoaDon(_hoaDon.MaHD); this.Close(); }
                else return;
            else this.Close();
        }

    }
}
