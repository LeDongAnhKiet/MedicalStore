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
    public class BUS_DuocPham
    {
        private DAL_DuocPham dalDP = new DAL_DuocPham();

        public DataTable getDuocPham(int ma, string ten) 
        {
            if (ma == 0) if (ten != "")
                    return dalDP.getDuocPham(ten);
                else return dalDP.getDuocPham();
            else return dalDP.getDuocPham(ma); 
        }

        public DuocPham timDuocPham(string ten) { return dalDP.timDuocPham(ten); }
    }
}
