using DAL_QLNT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLNT
{
    public class BUS_DoanhThu
    {
        DAL_DoanhThu dalDT = new DAL_DoanhThu();

        public DataTable getDoanhThu() { return dalDT.getDoanhThu(); }

        public DataTable getDoanhThu(DateTime ngayBatDau, DateTime ngayKetThuc) { return dalDT.getDoanhThu(ngayBatDau, ngayKetThuc); }

        public DataTable getDoanhThu(string tenLoai) { return dalDT.getDoanhThu(tenLoai); }

        public DataTable getDoanhThu(string hoNV, string tenNV) { return dalDT.getDoanhThu(hoNV, tenNV); }

    }
}
