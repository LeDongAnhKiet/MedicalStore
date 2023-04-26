
namespace DTO_QLNT
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietHD
    {
        private int _MaDP, _MaHD, _SoLuong;

        public ChiTietHD() { }

        public ChiTietHD(int maHD, int maDP, int Slg)
        {
            this.MaDP = maDP;
            this.MaHD = maHD;
            this.SoLuong = Slg;
        }

        public int MaDP
        {
            get { return _MaDP; }
            set { _MaDP = value; }
        }

        public int MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; }
        }

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        public virtual DuocPham DuocPham { get; set; }
        public virtual HoaDon HoaDon { get; set; }
    }
}
