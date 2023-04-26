using DAL_QLNT;
using DTO_QLNT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLNT
{
    public  class BUS_NhapKho
    {
        DAL_NhapKho dalPN = new DAL_NhapKho();

        public PhieuNhap taoPhieuNhap(int maNCC, int maNV, DateTime dt) { return dalPN.taoPhieuNhap(maNCC, maNV, dt); }

        public bool xoaPhieuNhap(int ma) { return dalPN.xoaPhieuNhap(ma); }
    }
}
