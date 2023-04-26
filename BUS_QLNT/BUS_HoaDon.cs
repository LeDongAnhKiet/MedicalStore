using DAL_QLNT;
using DTO_QLNT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLNT
{
    public class BUS_HoaDon
    {
        private DAL_HoaDon dalHD = new DAL_HoaDon();

        public DataTable getDuocPham(int maKH) { return dalHD.getDuocPham(maKH); }

        public HoaDon themHoaDon(int maKH, int maNV, DateTime dt)
        {
            HoaDon hoaDon = dalHD.timHoaDon(maKH, dt);
            if (hoaDon != null) return hoaDon;
            return dalHD.themHoaDon(maKH, maNV, dt);
        }

        public bool themDuocPham(string tenDP, int slg, int hd) { return dalHD.themDuocPham(tenDP, slg, hd); }

        public bool suaDuocPham(string tenDP, int slg, int ma) { return dalHD.suaDuocPham(tenDP, slg, ma); }

        public bool xoaDuocPham(string tenDP, int ma) { return dalHD.xoaDuocPham(tenDP, ma); }

        public decimal tinhThanhTien(int ma) { return dalHD.tinhThanhTien(ma); }

        public bool huyHoaDon(int ma) { return dalHD.xoaHoaDon(ma); }
    }
}
