using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLNT;

namespace DAL_QLNT
{
    public class DAL_DuocPham : DBConnect
    {
        public DataTable getDuocPham()
        {
            using (_medical = new NhaThuoc())
            {
                var query = from dp in _medical.DuocPhams
                            join ct in _medical.ChiTietDPs on dp.MaDP equals ct.MaDP
                            join loai in _medical.Loais on ct.MaLoai equals loai.MaLoai
                            orderby dp.MaDP
                            select new
                            {
                                Tên_thuốc = dp.TenDP,
                                Loại_thuốc = loai.TenLoai,
                                Số_lượng = ct.SoLuong,
                                Đơn_giá = ct.DonGia,
                                Hạn_sử_dụng = ct.HanSuDung,
                                Mô_tả = dp.MoTa
                            };
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
        }

        public DataTable getDuocPham(int ma)
        {
            using (_medical = new NhaThuoc())
            {
                try
                {
                    var query = from dp in _medical.DuocPhams
                                join ct in _medical.ChiTietDPs on dp.MaDP equals ct.MaDP
                                join loai in _medical.Loais on ct.MaLoai equals loai.MaLoai
                                where ct.MaLoai == ma
                                orderby dp.MaDP
                                select new
                                {
                                    Tên_thuốc = dp.TenDP,
                                    Loại_thuốc = loai.TenLoai,
                                    Số_lượng = ct.SoLuong,
                                    Đơn_giá = ct.DonGia,
                                    Hạn_sử_dụng = ct.HanSuDung,
                                    Mô_tả = dp.MoTa
                                };
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
                } catch (Exception ex) { ex.ToString(); return null; }
            }
        }

        public DataTable getDuocPham(string ten)
        {
            using (_medical = new NhaThuoc())
            {
                try
                {
                    var query = from dp in _medical.DuocPhams
                                join ct in _medical.ChiTietDPs on dp.MaDP equals ct.MaDP
                                join loai in _medical.Loais on ct.MaLoai equals loai.MaLoai
                                where dp.TenDP.ToLower().Contains(ten.ToLower()) 
                                orderby dp.MaDP
                                select new
                                {
                                    Tên_thuốc = dp.TenDP,
                                    Loại_thuốc = loai.TenLoai,
                                    Số_lượng = ct.SoLuong,
                                    Đơn_giá = ct.DonGia,
                                    Hạn_sử_dụng = ct.HanSuDung,
                                    Mô_tả = dp.MoTa
                                };
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
                catch (Exception ex) { ex.ToString(); return null; }
            }
        }

        public DuocPham timDuocPham(string ten)
        {
            using(_medical = new NhaThuoc())
            {
                DuocPham duocPham = _medical.DuocPhams.FirstOrDefault (dp => dp.TenDP == ten);
                return duocPham;
            }
        }
    }
}
