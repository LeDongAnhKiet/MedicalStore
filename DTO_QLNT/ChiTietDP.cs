
namespace DTO_QLNT
{
    using System;
    
    public partial class ChiTietDP
    {
        private int _MaDP, _MaLoai, _SoLuong;
        private DateTime _HanSD;
        private decimal _DonGia;

        public int MaDP 
        { 
            get { return _MaDP; }
            set { _MaDP = value; }
        }
        public int MaLoai
        {
            get { return _MaLoai; }
            set { _MaLoai = value; }
        }

        public DateTime HanSuDung
        {
            get { return _HanSD; }
            set { _HanSD = value; }
        }

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        public decimal DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }


        public virtual DuocPham DuocPham { get; set; }
        public virtual Loai Loai { get; set; }
    }
}
