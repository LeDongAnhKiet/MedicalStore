using DTO_QLNT;
using System;
using System.Data;
using System.Linq;

namespace DAL_QLNT
{
    public class DAL_HoaDon : DBConnect
    {
        public DataTable getDuocPham(int maKH)
        {
            using (_medical = new NhaThuoc())
            {
                /*  SELECT DISTINCT DP.TenDP AS [Tên thuốc],
                        L.TenLoai AS [Loại thuốc],
                        CTHD.SoLuong AS [Số lượng],
                        CTDP.DonGia AS [Đơn giá],
                        CTDP.HanSuDung AS [Hạn sử dụng],
                        DP.MoTa AS [Mô tả]
                    FROM HoaDon HD
                        INNER JOIN ChiTietHD CTHD ON HD.MaHD = CTHD.MaHD
                        INNER JOIN DuocPham DP ON CTHD.MaDP = DP.MaDP
                        INNER JOIN ChiTietDP CTDP ON DP.MaDP = CTDP.MaDP
                        INNER JOIN Loai L ON CTDP.MaLoai = L.MaLoai
                    WHERE HD.MaKH = @maKH   */
                try
                {
                    var query = _medical.HoaDons
                                    .Where(hd => hd.MaKH == maKH)
                                    .SelectMany(hd => hd.ChiTietHDs)
                                    .Select(cthd => new {
                                        Tên_thuốc = cthd.DuocPham.TenDP,
                                        Loại_thuốc = cthd.DuocPham.ChiTietDPs.Where(ctdp =>
                                            ctdp.MaDP == cthd.MaDP).FirstOrDefault().Loai.TenLoai,
                                        Số_lượng = cthd.SoLuong,
                                        Đơn_giá = cthd.DuocPham.ChiTietDPs.Where(ctdp =>
                                            ctdp.MaDP == cthd.MaDP).FirstOrDefault().DonGia,
                                        Hạn_sử_dụng = cthd.DuocPham.ChiTietDPs.Where(ctdp =>
                                            ctdp.MaDP == cthd.MaDP).FirstOrDefault().HanSuDung,
                                        Mô_tả = cthd.DuocPham.MoTa
                                    }).Distinct().ToList();
                    DataTable dt = new DataTable();
                    foreach (var col in query.First().GetType().GetProperties())
                        dt.Columns.Add(col.Name.Replace("_", " "));
                    foreach (var item in query)
                    {
                        DataRow dr = dt.NewRow();
                        foreach (var row in item.GetType().GetProperties())
                            dr[row.Name.Replace("_", " ")] = row.GetValue(item);
                        dt.Rows.Add(dr);
                    }
                    return dt;
                }
                catch(Exception ex) { ex.ToString(); return null; }
            }
        }

        public HoaDon themHoaDon(int maKH, int maNV, DateTime dt)
        {
            using (_medical = new NhaThuoc())
            {
                HoaDon hoaDon = new HoaDon(maKH, maNV, dt, 0);
                _medical.HoaDons.Add(hoaDon);
                _medical.SaveChanges();
                return hoaDon;
            }
        }
       
        public HoaDon timHoaDon(int maKH, DateTime dt)
        {
            using (_medical = new NhaThuoc())
            {
                return _medical.HoaDons.FirstOrDefault(hd => hd.MaKH == maKH && hd.NgayLap == dt);
            }
        }

        public bool themDuocPham(string tenDP, int slg, int ma)
        {
            try
            {
                _medical = new NhaThuoc();
                HoaDon hoaDon = _medical.HoaDons.Find(ma);
                DAL_DuocPham dalDP = new DAL_DuocPham();
                DuocPham duocPham = dalDP.timDuocPham(tenDP);
                if (duocPham == null) return false;
                ChiTietHD chiTietHD = new ChiTietHD(hoaDon.MaHD, duocPham.MaDP, slg);
                _medical.ChiTietHDs.Add(chiTietHD);
                ChiTietDP ctdp = _medical.ChiTietDPs.FirstOrDefault(ct => ct.MaDP == duocPham.MaDP);
                if (ctdp.SoLuong < slg) return false;
                ctdp.SoLuong -= slg;
                _medical.SaveChanges();
                return true;
            } catch { return false; }
        }

        public bool suaDuocPham(string tenDP, int slg, int ma)
        {
            using (_medical = new NhaThuoc())
            {
                HoaDon hoaDon = _medical.HoaDons.Find(ma);
                ChiTietHD cthd = hoaDon.ChiTietHDs.FirstOrDefault(ct => ct.DuocPham.TenDP == tenDP);
                if (cthd == null) return false;
                DuocPham duocPham = _medical.DuocPhams.FirstOrDefault(dp => dp.TenDP == tenDP);
                ChiTietDP ctdp = _medical.ChiTietDPs.FirstOrDefault(ct => ct.MaDP == duocPham.MaDP);
                ctdp.SoLuong += cthd.SoLuong;
                if (ctdp.SoLuong < slg) return false;
                ctdp.SoLuong -= slg;
                cthd.SoLuong = slg;
                _medical.SaveChanges();
                return true;
            }
        }

        public bool xoaDuocPham(string tenDP, int ma)
        {
            using(_medical = new NhaThuoc())
            {
                HoaDon hoaDon = _medical.HoaDons.Find(ma);
                ChiTietHD cthd = hoaDon.ChiTietHDs.FirstOrDefault(ct => ct.DuocPham.TenDP == tenDP);
                if (cthd == null) return false;
                DuocPham duocPham = _medical.DuocPhams.FirstOrDefault(dp => dp.TenDP == tenDP);
                ChiTietDP ctdp = _medical.ChiTietDPs.FirstOrDefault(ct => ct.MaDP == duocPham.MaDP);
                ctdp.SoLuong += cthd.SoLuong;
                _medical.ChiTietHDs.Remove(cthd);
                _medical.SaveChanges();
                return true;
            }
        }

        public decimal tinhThanhTien(int ma)
        {
            /*  DECLARE @thanhTien MONEY = 0
                SELECT @thanhTien = @thanhTien + ctdp.DonGia * cthd.SoLuong
                FROM ChiTietHD cthd JOIN ChiTietDP ctdp
                ON cthd.MaDP = ctdp.MaDP WHERE cthd.MaHD = @maHD    */

            decimal thanhTien = 0;
            using (_medical = new NhaThuoc())
            {
                try
                {
                    HoaDon hoaDon = _medical.HoaDons.Find(ma);
                    thanhTien = hoaDon.ChiTietHDs.Where(cthd => cthd.MaHD == ma)
                        .Join(_medical.ChiTietDPs, cthd => cthd.MaDP, ctdp => ctdp.MaDP,
                        (cthd, ctdp) => new { ChiTietHD = cthd, ChiTietDP = ctdp })
                        .Sum(ct => ct.ChiTietDP.DonGia * ct.ChiTietHD.SoLuong);
                    hoaDon.ThanhTien = thanhTien;
                    _medical.SaveChanges();
                }
                catch(Exception ex) { ex.ToString(); }
            }
            return thanhTien;
        }

        public bool xoaHoaDon(int ma)
        {
            using (_medical = new NhaThuoc())
            {
                HoaDon hoaDon = _medical.HoaDons.Find(ma);
                _medical.HoaDons.Remove(hoaDon);
                _medical.SaveChanges();
            }
            return true;
        }
    }
}
