using DAL_QLNT;
using DTO_QLNT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLNT
{
    public class BUS_KhachHang
    {
        private DAL_KhachHang dalKH = new DAL_KhachHang();

        public bool themKhachHang(string ho, string ten, string sdt, string desc, bool keDon) 
        {
            BUS_Nguoi busNg = new BUS_Nguoi();
            int ma = busNg.themNguoi(ho, ten, sdt, desc);
            return dalKH.themKhachHang(keDon, ma);
        }

        public KhachHang timKhachHang(string ho, string ten) { return dalKH.timKhachHang (ho, ten); }
    }
}
