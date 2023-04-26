using DTO_QLNT;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLNT
{
    public class DAL_KhachHang : DBConnect
    {
        public bool themKhachHang(bool keDon, int ma)
        {
            try
            {
                _con.Open();
                string sql = @"IF NOT EXISTS(SELECT MaNg FROM KhachHang WHERE MaNg = @maNg)
                                BEGIN
                                    SET IDENTITY_INSERT KhachHang ON;
                                    DECLARE @maKh INT; SET @maKh = 1;
                                    WHILE EXISTS (SELECT * FROM KhachHang WHERE MaKH = @maKh)
                                    BEGIN
                                        SET @maKh = @maKh + 1;
                                    END
                                    INSERT INTO KhachHang (MaKH, MaNg, Co_KeDon)
                                    Select @maKh, @maNg, @keDon
                                    From Nguoi ng WHERE ng.MaNg = @maNg;
                                    SET IDENTITY_INSERT KhachHang OFF;
                                END
                                ELSE
                                BEGIN
                                    UPDATE KhachHang SET Co_KeDon = @keDon WHERE MaNg = @maNg;
                                END";
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.Parameters.AddWithValue("@maNg", ma);
                cmd.Parameters.AddWithValue("@keDon", keDon);
                if (cmd.ExecuteNonQuery() > 0) return true;
            }
            catch (Exception ex) { ex.ToString(); }
            finally { _con.Close(); }
            return false;
        }

        public KhachHang timKhachHang(string ho, string ten)
        {
            using (_medical = new NhaThuoc())
            {
                KhachHang khacHang = _medical.KhachHangs.FirstOrDefault
                    (kh => kh.Nguoi.Ho == ho && kh.Nguoi.Ten == ten);
                return khacHang;
            }
        }
    }
}
