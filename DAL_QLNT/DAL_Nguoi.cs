using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using DTO_QLNT;

namespace DAL_QLNT
{
    public class DAL_Nguoi : DBConnect
    {
        public int themNguoi(string ho, string ten, string sdt, string desc)
        {
            try
            {
                _con.Open();
                string sql = @"IF NOT EXISTS(SELECT MaNg FROM Nguoi WHERE Ho = @Ho AND Ten = @Ten)
                                BEGIN
                                    SET IDENTITY_INSERT Nguoi ON;
                                    DECLARE @maNg INT; SET @maNg = 1;
                                    WHILE EXISTS (SELECT * FROM Nguoi WHERE MaNg = @maNg)
                                    BEGIN
                                        SET @maNg = @maNg + 1;
                                    END
                                    INSERT INTO Nguoi (MaNg, Ho, Ten, Sdt, GhiChu)
                                    VALUES (@maNg, @Ho, @Ten, @Sdt, @GhiChu);
                                    SET IDENTITY_INSERT Nguoi OFF;
                                END
                                ELSE
                                BEGIN
                                    UPDATE Nguoi SET Sdt = @sdt, GhiChu = @ghiChu WHERE Ho = @Ho AND Ten = @Ten;
                                END";
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.Parameters.AddWithValue("@Ho", ho);
                cmd.Parameters.AddWithValue("@Ten", ten);
                cmd.Parameters.AddWithValue("@Sdt", sdt);
                cmd.Parameters.AddWithValue("@GhiChu", desc);
                cmd.ExecuteNonQuery();
                _medical = new NhaThuoc();
                Nguoi nguoi = _medical.Nguois.Where(ng => ng.Ho == ho && ng.Ten == ten)
                                .FirstOrDefault();
                return nguoi.MaNg;
            }
            catch (Exception ex) { ex.ToString(); }
            finally { _con.Close(); }
            return 0;
        }

        public Nguoi timNguoi(string ho, string ten)
        {
            Nguoi nguoi = _medical.Nguois.FirstOrDefault (nv => nv.Ho == ho && nv.Ten == ten);
            return nguoi;
        }
    }
}
