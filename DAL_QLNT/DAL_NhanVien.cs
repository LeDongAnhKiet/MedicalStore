using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using DTO_QLNT;

namespace DAL_QLNT
{
    public class DAL_NhanVien : DBConnect
    {
        public DataTable getNhanVien()
        {
            string sql = @"Select MaNV as [Mã nhân viên], Ho as [Họ nhân viên], Ten as [Tên nhân viên],
			                Sdt as [Số điện thoại], TaiKhoan as [Tên tài khoản],
			                La_Admin  as [Là Admin], GhiChu as [Ghi chú]
                            From Nguoi inner join NhanVien
                            On NhanVien.MaNg = Nguoi.MaNg;";
            SqlDataAdapter da = new SqlDataAdapter(sql, _con);
            DataSet ds = new DataSet(); da.Fill(ds);
            return ds.Tables[0];
        }

        public bool themNhanVien(bool ad, int ma)
        {
            try
            {
                _con.Open();
                string sql = @"IF NOT EXISTS(SELECT MaNg FROM NhanVien WHERE MaNg = @maNg)
                                BEGIN
                                    SET IDENTITY_INSERT NhanVien ON;
                                    DECLARE @maNv INT; SET @maNv = 1;
                                    WHILE EXISTS (SELECT * FROM NhanVien WHERE MaNV = @maNv)
                                    BEGIN
                                        SET @maNv = @maNv + 1;
                                    END
                                    INSERT INTO NhanVien (MaNV, MaNg, La_Admin, TaiKhoan, MatKhau)
                                    Select @maNv, @maNg, @La_Admin, ng.Ho + ng.Ten, ng.Sdt
                                    From Nguoi ng WHERE ng.MaNg = @maNg;
                                    SET IDENTITY_INSERT NhanVien OFF;
                                END
                                ELSE
                                BEGIN
                                    UPDATE NhanVien SET La_Admin = @La_Admin WHERE MaNg = @maNg;
                                END";
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.Parameters.AddWithValue("@maNg", ma);
                cmd.Parameters.AddWithValue("@La_Admin", ad);
                if (cmd.ExecuteNonQuery() > 0) return true;
            }
            catch (Exception ex) { ex.ToString(); }
            finally { _con.Close(); }
            return false;
        }

        public NhanVien timNhanVien(int ma)
        {
            _medical = new NhaThuoc();
            NhanVien nhanVien = _medical.NhanViens.Find(ma);
            return nhanVien;
        }

        public NhanVien timNhanVien(string tk, string mk)
        {
            using (_medical = new NhaThuoc())
            {
                NhanVien nhanVien = _medical.NhanViens.FirstOrDefault
                    (nv => nv.TaiKhoan == tk && nv.MatKhau == mk);
                return nhanVien;
            }
        }

        public bool suaNhanVien(int ma, string ho, string ten, string sdt, string desc, bool ad)
        {
            _medical = new NhaThuoc();
            NhanVien nhanVien = _medical.NhanViens.Find(ma);
            if (nhanVien != null)
            {
                nhanVien.Nguoi.Ho = ho;
                nhanVien.Nguoi.Ten = ten;
                nhanVien.Nguoi.Sdt = sdt;
                nhanVien.Nguoi.GhiChu = desc;
                nhanVien.La_Admin = ad;
                _medical.SaveChanges();
                return true;
            }
            return false;
        }

        public bool suaThongTin(int ma, string tk, string mk, string desc)
        {
            _medical = new NhaThuoc();
            NhanVien nhanVien = _medical.NhanViens.Find(ma);
            if (nhanVien != null)
            {
                nhanVien.Nguoi.GhiChu = desc;
                nhanVien.TaiKhoan = tk;
                nhanVien.MatKhau = mk;
                _medical.SaveChanges();
                return true;
            }
            return false;
        }

        public bool xoaNhanVien(int ma)
        {
            using (_medical = new NhaThuoc())
            {
                NhanVien nhanVien = _medical.NhanViens.FirstOrDefault(nv => nv.MaNV == ma);
                if (nhanVien == null) return false;
                Nguoi nguoi = _medical.Nguois.FirstOrDefault(ng => ng.MaNg == nhanVien.MaNg);
                if (nguoi == null) return false;
                _medical.NhanViens.Remove(nhanVien);
                _medical.Nguois.Remove(nguoi);
                if (_medical.SaveChanges() > 0) return true;
            }
            return false;
        }

    }
}