using DTO_QLNT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLNT
{
    public class DAL_DoanhThu : DBConnect
    {
        private DataTable FormatDt(IQueryable<object> query)
        {
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

        public DataTable getDoanhThu()
        {
            /*  SELECT HD.MaHD as 'Mã HD', 
                CONCAT(kh.Ho, ' ', kh.Ten) as 'Khách Hàng', 
                CONCAT(nv.Ho, ' ', nv.Ten) as 'Nhân Viên', 
                NgayLap as 'Ngày lập', 
                Count(ct.MaDP) as 'Số thuốc đã mua', 
                ThanhTien as 'Thành tiền'
                FROM HoaDon HD
                    INNER JOIN KhachHang ON HD.MaKH = KhachHang.MaKH 
                    INNER JOIN Nguoi kh ON KhachHang.MaNg = kh.MaNg 
                    INNER JOIN NhanVien ON HD.MaNV = NhanVien.MaNV 
                    INNER JOIN Nguoi nv ON NhanVien.MaNg = nv.MaNg 
                    INNER JOIN ChiTietHD ct ON HD.MaHD = ct.MaHD 
                GROUP BY 
                    HD.MaHD, kh.Ho, kh.Ten, nv.Ho, nv.Ten, NgayLap, ThanhTien; */
            using (_medical = new NhaThuoc())
            {
                try
                {
                    var query = from hd in _medical.HoaDons
                                join KH in _medical.KhachHangs on hd.MaKH equals KH.MaKH
                                join kh in _medical.Nguois on KH.MaNg equals kh.MaNg
                                join NV in _medical.NhanViens on hd.MaNV equals NV.MaNV
                                join nv in _medical.Nguois on NV.MaNg equals nv.MaNg
                                join ct in _medical.ChiTietHDs on hd.MaHD equals ct.MaHD
                                group ct by new
                                {
                                    hd.MaHD,
                                    khachHang = kh.Ho + " " + kh.Ten,
                                    nhanVien = nv.Ho + " " + nv.Ten,
                                    hd.NgayLap,
                                    hd.ThanhTien
                                } into g
                                select new
                                {
                                    Mã_Hóa_Đơn = g.Key.MaHD,
                                    Khách_Hàng = g.Key.khachHang,
                                    Nhân_Viên = g.Key.nhanVien,
                                    Ngày_lập = g.Key.NgayLap,
                                    Số_thuốc_đã_mua = g.Count(),
                                    Thành_tiền = g.Key.ThanhTien
                                };
                return FormatDt(query);
                }
                catch (Exception ex) { ex.ToString(); return null; }
            }
        }

        public DataTable getDoanhThu(DateTime batDau, DateTime ketThuc)
        {
            try
            {
                using (_medical = new NhaThuoc())
                {
                    var query = from hd in _medical.HoaDons
                                join KH in _medical.KhachHangs on hd.MaKH equals KH.MaKH
                                join kh in _medical.Nguois on KH.MaNg equals kh.MaNg
                                join NV in _medical.NhanViens on hd.MaNV equals NV.MaNV
                                join nv in _medical.Nguois on NV.MaNg equals nv.MaNg
                                join ct in _medical.ChiTietHDs on hd.MaHD equals ct.MaHD
                                where hd.NgayLap >= batDau && hd.NgayLap <= ketThuc
                                orderby hd.NgayLap group ct by new
                                {
                                    hd.MaHD,
                                    khachHang = kh.Ho + " " + kh.Ten,
                                    nhanVien = nv.Ho + " " + nv.Ten,
                                    hd.NgayLap,
                                    hd.ThanhTien
                                } into g
                                select new
                                {
                                    Mã_Hóa_Đơn = g.Key.MaHD,
                                    Khách_Hàng = g.Key.khachHang,
                                    Nhân_Viên = g.Key.nhanVien,
                                    Ngày_lập = g.Key.NgayLap,
                                    Số_thuốc_đã_mua = g.Count(),
                                    Thành_tiền = g.Key.ThanhTien
                                };
                    return FormatDt(query);
                }
            } catch (Exception ex) { ex.ToString(); return null; }
        }

        public DataTable getDoanhThu(string loai)
        {
            using(_medical = new NhaThuoc())
            {
                try
                {
                    var query = from cthd in _medical.ChiTietHDs
                                join ctdp in _medical.ChiTietDPs on cthd.MaDP equals ctdp.MaDP
                                join l in _medical.Loais on ctdp.MaLoai equals l.MaLoai
                                join dp in _medical.DuocPhams on ctdp.MaDP equals dp.MaDP
                                join hd in _medical.HoaDons on cthd.MaHD equals hd.MaHD
                                join KH in _medical.KhachHangs on hd.MaKH equals KH.MaKH
                                join kh in _medical.Nguois on KH.MaNg equals kh.MaNg
                                join NV in _medical.NhanViens on hd.MaNV equals NV.MaNV
                                join nv in _medical.Nguois on NV.MaNg equals nv.MaNg
                                where l.TenLoai == loai orderby dp.MaDP
                                select new
                                {
                                    Mã_thuốc = dp.MaDP,
                                    Tên_thuốc = dp.TenDP,
                                    Loại_thuốc = l.TenLoai,
                                    Khách_hàng = kh.Ho + " " + kh.Ten,
                                    Nhân_viên = nv.Ho + " " + nv.Ten,
                                    Ngày_mua = hd.NgayLap,
                                    Số_lượng = cthd.SoLuong,
                                    Tổng_tiền = ctdp.DonGia * cthd.SoLuong
                                };
                    return FormatDt(query);
                } catch(Exception ex) { ex.ToString(); return null; }
            }
        }

        public DataTable getDoanhThu(string ho, string ten)
        {
            string hoTen = ho + " " + ten;
            try
            {
                using (_medical = new NhaThuoc())
                {
                    var query = from hd in _medical.HoaDons
                                join KH in _medical.KhachHangs on hd.MaKH equals KH.MaKH
                                join kh in _medical.Nguois on KH.MaNg equals kh.MaNg
                                join NV in _medical.NhanViens on hd.MaNV equals NV.MaNV
                                join nv in _medical.Nguois on NV.MaNg equals nv.MaNg
                                where (nv.Ho + " " + nv.Ten).Contains(hoTen) || nv.Ten.Contains(ho)
                                orderby hd.NgayLap select new
                                {
                                    Nhân_viên = nv.Ho + " " + nv.Ten,
                                    Khách_hàng = kh.Ho + " " + kh.Ten,
                                    Ngày_lập = hd.NgayLap,
                                    Thành_tiền = hd.ThanhTien,
                                //      Tái_khám = KH.Co_KeDon,
                                    Ghi_chú_khách_hàng = kh.GhiChu
                                };
                    return FormatDt(query);
                }
            }
            catch (Exception ex) { ex.ToString(); return null; }
        }
    }
}
