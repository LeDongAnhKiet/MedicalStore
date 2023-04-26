namespace DTO_QLNT
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class NhanVien
    {
        private int _MaNV, _MaNg;
        private bool _LaAdmin;
        private string _TaiKhoan, _MatKhau;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            this.HoaDons = new HashSet<HoaDon>();
            this.PhieuNhaps = new HashSet<PhieuNhap>();
        }
        public NhanVien(int manv, int mang, string ten, string mk, bool ad)
        {
            this.MaNV = manv;
            this.MaNg = mang;
            this.TaiKhoan = ten;
            this.MatKhau = mk;
            this.La_Admin = ad;
            this.HoaDons = new HashSet<HoaDon>();
            this.PhieuNhaps = new HashSet<PhieuNhap>();
        }
        public NhanVien(int mang, string ten, string mk, bool ad)
        {
            this.MaNg = mang;
            this.TaiKhoan = ten;
            this.MatKhau = mk;
            this.La_Admin = ad;
            this.HoaDons = new HashSet<HoaDon>();
            this.PhieuNhaps = new HashSet<PhieuNhap>();
        }
        public NhanVien(string ten, string mk, bool ad)
        {
            this.TaiKhoan = ten;
            this.MatKhau = mk;
            this.La_Admin = ad;
            this.HoaDons = new HashSet<HoaDon>();
            this.PhieuNhaps = new HashSet<PhieuNhap>();
        }
        public NhanVien(int manv, Nguoi ng, bool ad)
        {
            this.MaNV = manv;
            this.Nguoi = ng;
            this.La_Admin = ad;
            this.HoaDons = new HashSet<HoaDon>();
            this.PhieuNhaps = new HashSet<PhieuNhap>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        [ForeignKey("Nguoi")]
        public int MaNg
        {
            get { return _MaNg; }
            set { _MaNg = value; }
        }
        public bool La_Admin
        {
            get { return _LaAdmin; }
            set { _LaAdmin = value; }
        }
        [Index(IsUnique = true)]
        [MaxLength(20)]
        public string TaiKhoan
        {
            get { return _TaiKhoan; }
            set { _TaiKhoan = value; }
        }
        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual Nguoi Nguoi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; }
    }
}