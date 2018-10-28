using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_LINQ
{
    public class BLL_HoaDon
    {
        LINQ_QLBHDataContext linQ = new LINQ_QLBHDataContext();
        public List<HOADON> LoadHoaDon()
        {

            var hoadon = from hd in linQ.HOADONs select hd;
            return hoadon.ToList<HOADON>();
        }
        public List<HOADON> LoadHoaDonDK(string MAHD)
        {

            var hoadon = from hd in linQ.HOADONs where hd.MAHD.Equals(MAHD) select hd;
            return hoadon.ToList<HOADON>();
        }
        public List<HOADON> LoadHoaDonTinhTrang(string TinhTrang)
        {

            var hoadon = from hd in linQ.HOADONs where hd.TINHTRANGTHANHTOAN.Equals(TinhTrang) select hd;
            return hoadon.ToList<HOADON>();
        }
        public int xoaHoaDon(string MAHD)
        {
            try
            {
                var hoadon = from hd in linQ.HOADONs where hd.MAHD.Equals(MAHD) select hd;
                linQ.HOADONs.DeleteOnSubmit(hoadon.ToList<HOADON>()[0]);
                linQ.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
