using System;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using DTO_QLNT;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace DAL_QLNT
{
    public class DAL_Loai : DBConnect
    {
        public List<string> getLoai()
        {
            using (_medical = new NhaThuoc())
            {
                return (from l in _medical.Loais
                        orderby l.MaLoai select l.TenLoai).ToList();
            }
        }

        public Loai timLoai(string ten)
        {
            using (_medical = new NhaThuoc())
            {
                Loai loai = _medical.Loais.FirstOrDefault (l => l.TenLoai == ten);
                return loai;
            }
        }
    }
}

