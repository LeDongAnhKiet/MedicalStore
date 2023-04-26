using DAL_QLNT;
using DTO_QLNT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS_QLNT
{
    public class BUS_Loai
    {
        DAL_Loai loai = new DAL_Loai();

        public List<string> getLoai() { return loai.getLoai(); }

        public Loai timLoai(string ten) { return loai.timLoai(ten); }
    }
}
