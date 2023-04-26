using DAL_QLNT;
using DTO_QLNT;

namespace BUS_QLNT
{
    public class BUS_Nguoi
    {
        private DAL_Nguoi dalNg = new DAL_Nguoi();

        public int themNguoi(string ho, string ten, string sdt, string desc) { return dalNg.themNguoi(ho, ten, sdt, desc); }

        public Nguoi timNguoi (string ho, string ten) { return dalNg.timNguoi(ho, ten); }
    }
}
