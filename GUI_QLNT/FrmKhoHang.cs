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
    public partial class FrmKhoHang : Form
    {
        //private PhieuNhap _PhieuNhap;

        //private FrmBanHang _BanHang;

        public FrmKhoHang(/*PhieuNhap pn, FrmBanHang f*/)
        {
            InitializeComponent();
            //_PhieuNhap = pn;
            //_BanHang = f;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
