using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_QLNT;

namespace GUI_QLNT
{
    public partial class FrmLogin : Form
    {
        private int count = 0;
     
        private BUS_NhanVien busNV = new BUS_NhanVien();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (txUser.Text == "" || txPass.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin để đăng nhập!");
                return;
            }
            var nhanVien = busNV.dangNhap(txUser.Text, txPass.Text);
            if (nhanVien != null)
            {
                this.Hide();
                FrmBanHang f = new FrmBanHang(nhanVien);
                f.ShowDialog();
            }
            else if (count == 3)
            {
                MessageBox.Show("Đã nhập sai thông tin 3 lần!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                count++;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //ReadSQL sql = new ReadSQL();
            //sql.ExecuteScript(@"D:\QLNT\SQL_QLNT\KhoiTao_QLNT.sql");
            //sql.ExecuteScript(@"D:\QLNT\SQL_QLNT\ThongTin_QLNT.sql");
        }

        private void txUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (txUser.Text == "") txUser.Focus();
                else if (txPass.Text == "") txPass.Focus();
                    else btLogin_Click(sender, e);
        }
    }
}
