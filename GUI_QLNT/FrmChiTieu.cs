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
    public partial class FrmChiTieu : Form
    {
        private NhanVien _loggedIn;

        public FrmChiTieu(NhanVien nv)
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

        private void FrmChiTieu_Load(object sender, EventArgs e)
        {
            init();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBanHang f = new FrmBanHang(_loggedIn);
            f.ShowDialog();
        }
    }
}
