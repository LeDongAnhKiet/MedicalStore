using DTO_QLNT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLNT
{
    public class DAL_NhapKho : DBConnect
    {
        public PhieuNhap taoPhieuNhap(int maNCC, int maNV, DateTime dt)
        {
            using (_medical = new NhaThuoc())
            {
                PhieuNhap nhapKho = new PhieuNhap(maNCC, maNV, dt);
                _medical.PhieuNhaps.Add(nhapKho);
                _medical.SaveChanges();
                return nhapKho;
            }
        }

        public bool xoaPhieuNhap(int ma)
        {
            using (_medical = new NhaThuoc())
            {
                PhieuNhap nhapKho = _medical.PhieuNhaps.Find(ma);
                _medical.PhieuNhaps.Remove(nhapKho);
                if (_medical.SaveChanges() > 0) return true;
            }
            return false;
        }
    }
}
