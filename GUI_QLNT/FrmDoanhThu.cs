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
    public partial class FrmDoanhThu : Form
    {
        private NhanVien _loggedIn;

        BUS_DoanhThu busDT = new BUS_DoanhThu();

        BUS_Loai busL = new BUS_Loai();

        private bool isLoading;

        public FrmDoanhThu(NhanVien nv)
        {
            InitializeComponent();
            _loggedIn = nv;
        }

        private void init()
        {
            dtKT.Format = dtBD.Format = DateTimePickerFormat.Custom;
            dtKT.CustomFormat = dtBD.CustomFormat = "dd/MM/yyyy";
            dtKT.Value = dtBD.Value = DateTime.Now;
        }

        private void FilldgDT(DataTable dt)
        {
            lbDT.Text = "";
            dgDoanhThu.DataSource = dt;
            if (dt == null) { lbDT.Text = "Không tìm thấy thông tin nào!"; return; }
            dgDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgDoanhThu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewColumn col in dgDoanhThu.Columns)
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void FrmDoanhThu_Load(object sender, EventArgs e)
        {
            isLoading = true;
            init();
            FilldgDT(busDT.getDoanhThu());
            cbLoai.DataSource = busL.getLoai();
            cbLoai.Text = "";
            isLoading = false;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBanHang f = new FrmBanHang(_loggedIn);
            f.ShowDialog();
        }

        private void btLocNgay_Click(object sender, EventArgs e)
        {
            lbTKeLoai.Text = lbTKeNV.Text = "";
            DateTime ngayBD = dtBD.Value.Date;
            DateTime ngayKT = dtKT.Value.Date;
            FilldgDT(busDT.getDoanhThu(ngayBD, ngayKT));
            TinhDoanhThu("Thành tiền", lbTKeNgay);
        }

        private void dgDoanhThu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgDoanhThu.Columns[e.ColumnIndex].Name == "Thành tiền" && e.Value != null)
                e.Value = string.Format("{0:#,#}", Convert.ToDecimal(e.Value));
            else if (dgDoanhThu.Columns[e.ColumnIndex].Name == "Tổng tiền" && e.Value != null)
                e.Value = string.Format("{0:#,#}", Convert.ToDecimal(e.Value));
            else if (dgDoanhThu.Columns[e.ColumnIndex].Name == "Ngày lập" && e.Value != null)
                e.Value = DateTime.Parse(e.Value.ToString()).ToString("dd/MM/yyyy");
            else if (dgDoanhThu.Columns[e.ColumnIndex].Name == "Ngày mua" && e.Value != null)
                e.Value = DateTime.Parse(e.Value.ToString()).ToString("dd/MM/yyyy");
            /*      else if (dgDoanhThu.Columns[e.ColumnIndex].Name == "Tái khám" && e.Value == null)
                        e.Value = (bool)e.Value ? "7 ngày sau quay lại nếu chưa khỏi bệnh" : "";    */
            return;
        }

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTKeNgay.Text = lbTKeNV.Text = "";
            if (cbLoai.Text == "" || isLoading) return;
            Loai l = busL.timLoai(cbLoai.SelectedItem.ToString());
            if (l == null) return;
            FilldgDT(busDT.getDoanhThu(l.TenLoai));
            TinhDoanhThu("Tổng tiền", lbTKeLoai);
        }

        private void txUser_TextChanged(object sender, EventArgs e)
        {
            lbTKeNgay.Text = lbTKeLoai.Text = "";
            if (txUser.Text == "" || isLoading) return;
            FilldgDT(busDT.getDoanhThu(txUser.Text, ""));
            TinhDoanhThu("Thành tiền", lbTKeNV);
        }

        private void TinhDoanhThu(string column, Label l)
        {
            decimal tong = 0;
            try 
            {
                foreach (DataGridViewRow row in dgDoanhThu.Rows)
                {
                    decimal d;
                    if (decimal.TryParse(row.Cells[column].Value.ToString(), out d))
                        tong += d;
                }
            }
            catch (Exception ex) { ex.ToString(); } 
            l.Text = "Doanh Thu: " + string.Format("{0:#,#}", tong);
        }

        private void FrmDoanhThu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
