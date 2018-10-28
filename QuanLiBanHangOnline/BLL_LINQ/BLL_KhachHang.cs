using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_LINQ
{
    public class BLL_KhachHang
    {
        LINQ_QLBHDataContext linQ = new LINQ_QLBHDataContext();
        public KHACHHANG LoadMotKhachHang(string MAKH)
        {
            var kh = from Khach in linQ.KHACHHANGs where Khach.MAKH.Equals(MAKH) select Khach;
            return (KHACHHANG)kh.ToList<KHACHHANG>()[0];
        }
    }
}
