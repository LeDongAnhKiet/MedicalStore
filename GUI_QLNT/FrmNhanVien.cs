using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_QLNT;
using DTO_QLNT;

namespace GUI_QLNT
{
    public partial class FrmNhanVien : Form
    {
        private readonly NhanVien _loggedIn;

        private BUS_NhanVien busNV = new BUS_NhanVien();

        public FrmNhanVien(NhanVien nv)
        {
            InitializeComponent();
            _loggedIn = nv;
        }

        private void FilldgNV()
        {
            try
            {
                dgNV.DataSource = busNV.getNhanVien();
                dgNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (DataGridViewColumn col in dgNV.Columns)
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void init()
        {
            txHo.Text = txTen.Text = txSdt.Text = txDesc.Text = txMa.Text = "";
            lbNV.Visible = cbAdmin.Checked = lbMa.Visible =
            lbUser.Visible = lbPass.Visible = txUser.Visible = txPass.Visible = false;
            lbMa.Location = new Point(60, 205);
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            init(); FilldgNV();
            if (_loggedIn.La_Admin == false)
                loggedUser();
        }

        private void loggedUser()
        {
            cbAdmin.Visible = txMa.Visible = dgNV.Visible = 
                btThem.Visible = btXoa.Visible = btTim.Visible = false;
            txHo.ReadOnly = txTen.ReadOnly = txSdt.ReadOnly = lbUser.Visible = 
                lbPass.Visible = txUser.Visible = txPass.Visible = true;
            var nhanVien = busNV.timNhanVien(_loggedIn.MaNV);
            txHo.Text = nhanVien.Nguoi.Ho;
            txTen.Text = nhanVien.Nguoi.Ten;
            txSdt.Text = nhanVien.Nguoi.Sdt;
            txDesc.Text = nhanVien.Nguoi.GhiChu;
            txUser.Text = nhanVien.TaiKhoan;
            txPass.Text = new string('*', nhanVien.MatKhau.Length);
            btSua.Location = new Point(200, 135);
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (!txMa.Text.Any(char.IsNumber))
            {
                MessageBox.Show("Vui lòng nhập Mã nhân viên cần tìm!");
                return;
            }
            try
            {
                var nv = busNV.timNhanVien(int.Parse(txMa.Text));
                if (nv == null)
                {
                    MessageBox.Show($"Không tìm thấy mã nhân viên {txMa.Text}!");
                    return;
                }
                txHo.Text = nv.Nguoi.Ho;
                txTen.Text = nv.Nguoi.Ten;
                txSdt.Text = nv.Nguoi.Sdt;
                cbAdmin.Checked = nv.La_Admin;
                txDesc.Text = nv.Nguoi.GhiChu;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { txMa_Leave(sender, e); }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txHo.Text == "" || txTen.Text == "")
                { MessageBox.Show("Vui lòng nhập đầy đủ thông tin!"); return; }
                else if (txMa.Text.Any(char.IsNumber))
                { MessageBox.Show("Không cần nhập mã mới!"); return; }
                BUS_Nguoi busNg = new BUS_Nguoi();
                int ma = busNg.themNguoi(txHo.Text, txTen.Text, txSdt.Text, txDesc.Text);
                if (busNV.themNhanVien(cbAdmin.Checked, ma))
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    init(); FilldgNV();
                }
                else MessageBox.Show("Đã có lỗi xảy ra!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBanHang f = new FrmBanHang(_loggedIn);
            f.ShowDialog();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!txMa.Text.Any(char.IsNumber))
                MessageBox.Show("Vui lòng nhập Mã nhân viên muốn xóa!");
            else try
                {
                    if (busNV.xoaNhanVien(int.Parse(txMa.Text)))
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
                        init(); FilldgNV();
                    }
                    else MessageBox.Show("Đã có lỗi xảy ra!");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { txMa_Leave(sender, e); }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (!_loggedIn.La_Admin)
            {
                var nv = busNV.timNhanVien(_loggedIn.MaNV);
                try
                {
                    if (txUser.Text == nv.TaiKhoan && txPass.Text == nv.MatKhau && txDesc.Text == nv.Nguoi.GhiChu)
                        MessageBox.Show("Chưa có thông tin nào đã được thay đổi!");
                    else if (txUser.Text == "" || txPass.Text == "")
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần được cập nhật!");
                    else if (busNV.suaThongTin(nv.MaNV, txUser.Text, txPass.Text, txDesc.Text))
                        MessageBox.Show("Cập nhật thông tin thành công!");
                    else MessageBox.Show("Đã có lỗi xảy ra!");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally
                {
                    nv = busNV.timNhanVien(_loggedIn.MaNV);
                    txUser.Text = nv.TaiKhoan;
                    txPass.Text = nv.MatKhau;
                }
            }
            else try
                {
                    if (!txMa.Text.Any(char.IsNumber))
                        MessageBox.Show("Vui lòng nhập Mã nhân viên cần được cập nhật");
                    else if (txHo.Text == "" || txTen.Text == "")
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần được cập nhật!");
                    else if (busNV.suaNhanVien(int.Parse(txMa.Text), txHo.Text, txTen.Text, txSdt.Text, txDesc.Text, cbAdmin.Checked))
                    {
                        MessageBox.Show("Cập nhật nhân viên thành công!");
                        init(); FilldgNV();
                    }
                    else MessageBox.Show("Đã có lỗi xảy ra!");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { txMa_Leave(sender, e); }
        }

        private void txMa_Click(object sender, EventArgs e)
        {
            btThem.Enabled = false;
            lbMa.Visible = true;
        }

        private void txMa_Leave(object sender, EventArgs e)
        {
            btThem.Enabled = true;
            lbMa.Visible = false;
        }

        private void txPass_Click(object sender, EventArgs e)
        {
            lbNV.Visible = true;
        }

        private void txUser_Leave(object sender, EventArgs e)
        {
            lbNV.Visible = false;
        }

        private void FrmNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txMa.Text = dgNV.Rows[e.RowIndex].Cells["Mã nhân viên"].Value.ToString();
                txHo.Text = dgNV.Rows[e.RowIndex].Cells["Họ nhân viên"].Value.ToString();
                txTen.Text = dgNV.Rows[e.RowIndex].Cells["Tên nhân viên"].Value.ToString();
                txSdt.Text = dgNV.Rows[e.RowIndex].Cells["Số điện thoại"].Value.ToString();
                txDesc.Text = dgNV.Rows[e.RowIndex].Cells["Ghi chú"].Value.ToString();
//                cbAdmin.Checked = dgNV.Rows[e.RowIndex].Cells["Là Admin"].Displayed;
            }
            catch (Exception ex) { ex.ToString(); return; }
        }
    }
}
