
namespace DTO_QLNT
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhieuNhap
    {
        private int _MaPN, _MaNV, _MaNCC;
        private DateTime _NgayNhap;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuNhap()
        {
            this.ChiTietPNs = new HashSet<ChiTietPN>();
        }

        public PhieuNhap(int maNV, int maNCC, DateTime dt)
        {
            this.MaNV = maNV;
            this.MaNCC = maNCC;
            this.NgayNhap = dt;
            this.ChiTietPNs = new HashSet<ChiTietPN>();
        }

        public int MaPN 
        { 
            get { return _MaPN; }
            set { _MaPN = value; }
        }
        public int MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        public int MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
        }

        public DateTime NgayNhap
        {
            get { return _NgayNhap; }
            set { NgayNhap = value; }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPN> ChiTietPNs { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
