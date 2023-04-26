namespace DTO_QLNT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;

    public partial class HoaDon
    {
        private int _MaHD, _MaKH, _MaNV;
        private DateTime _NgayLap;
        private decimal _ThanhTien;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            this.ChiTietHDs = new HashSet<ChiTietHD>();
        }

        public HoaDon(int maKH, int maNV, DateTime ngay, decimal tien)
        {
            this.MaKH = maKH;
            this.MaNV = maNV;
            this.NgayLap = ngay;
            this.ThanhTien = tien;
            this.ChiTietHDs = new HashSet<ChiTietHD>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; }
        }

        public DateTime NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; }
        }
        [ForeignKey("KhachHang")]
        public int MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }

        [ForeignKey("NhanVien")]
        public int MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        public decimal ThanhTien
        {
            get { return _ThanhTien; }
            set { _ThanhTien = value; }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHD> ChiTietHDs { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}