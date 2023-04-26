namespace DTO_QLNT
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Nguoi
    {
        private int _MaNg;
        private string _Ho, _Ten, _Sdt, _GhiChu;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nguoi()
        {
            this.KhachHangs = new HashSet<KhachHang>();
            this.NhanViens = new HashSet<NhanVien>();
        }
        public Nguoi(int ma, string ho, string ten, string sdt, string ghichu)
        {
            this.MaNg = ma;
            this.Ho = ho;
            this.Ten = ten;
            this.Sdt = sdt;
            this.GhiChu = ghichu;
            this.KhachHangs = new HashSet<KhachHang>();
            this.NhanViens = new HashSet<NhanVien>();
        }
        public Nguoi(string ho, string ten, string sdt, string ghichu)
        {
            this.Ho = ho;
            this.Ten = ten;
            this.Sdt = sdt;
            this.GhiChu = ghichu;
            this.KhachHangs = new HashSet<KhachHang>();
            this.NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaNg
        {
            get { return _MaNg; }
            set { _MaNg = value; }
        }
        [Required]
        [StringLength(30)]
        public string Ho
        {
            get { return _Ho; }
            set { _Ho = value; }
        }
        [Required]
        [StringLength(10)]
        public string Ten
        {
            get { return _Ten; }
            set { _Ten = value; }
        }
        [MaxLength(10)]
        public string Sdt
        {
            get { return _Sdt; }
            set { _Sdt = value; }
        }
        [MaxLength(50)]
        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}