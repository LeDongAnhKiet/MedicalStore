using System;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QLNT;
using DTO_QLNT;

namespace BUS_QLNT
{
    public class BUS_NhanVien
    {
        private DAL_NhanVien dalNV = new DAL_NhanVien();

        public DataTable getNhanVien() { return dalNV.getNhanVien(); }

        public bool themNhanVien(bool ad, int ma) { return dalNV.themNhanVien(ad, ma); }

        public bool suaNhanVien(int ma, string ho, string ten, string sdt, string desc, bool ad)
        { return dalNV.suaNhanVien(ma, ho, ten, sdt, desc, ad); }

        public bool suaThongTin(int ma, string tk, string mk, string desc)
        { return dalNV.suaThongTin(ma, tk, mk, desc); }

        public NhanVien timNhanVien(int ma) { return dalNV.timNhanVien(ma); }

        public NhanVien dangNhap(string tk, string mk) { return dalNV.timNhanVien(tk, mk); }

        public bool xoaNhanVien(int ma) { return dalNV.xoaNhanVien(ma); }

    }
}
