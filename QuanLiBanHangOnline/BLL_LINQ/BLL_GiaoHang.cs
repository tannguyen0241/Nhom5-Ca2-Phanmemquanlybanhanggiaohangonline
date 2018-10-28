using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_LINQ
{
    public class HD_GH
    {
        public string MAHD { get; set; }
        public string MAKH { get; set; }
        public string MANV { get; set; }
        public string MAHINHTHUC { get; set; }
        public string MAKHUYENMAI { get; set; }
        public DateTime NGAYDAT { get; set; }
        public string DIACHIGIAO { get; set; }
        public double? KHOANGCACH { get; set; }
        public double? PHIKC { get; set; }
        public double? THANHTIEN { get; set; }
        public string TINHTRANGTHANHTOAN { get; set; }

    }
    public class BLL_GiaoHang
    {
        LINQ_QLBHDataContext linQ = new LINQ_QLBHDataContext();
        public List<HD_GH> Load_HD_GH()
        {
            List<HD_GH> a = new List<HD_GH>();
            var hoadon = from hd in linQ.HOADONs       
                         where hd.TINHTRANGTHANHTOAN.Equals("Chưa được nhận")
                         select new HD_GH()
                         {
                             MAHD = hd.MAHD,
                             MAKH = hd.MAKH,
                             MANV = "",
                             MAHINHTHUC = hd.MAHINHTHUC,
                             MAKHUYENMAI = hd.MAKHUYENMAI,
                             NGAYDAT = hd.NGAYDAT,
                             DIACHIGIAO = hd.DIACHIGIAO,
                             KHOANGCACH = hd.KHOANGCACH,
                             PHIKC = hd.PHIKC,
                             THANHTIEN = hd.THANHTIEN,
                             TINHTRANGTHANHTOAN = hd.TINHTRANGTHANHTOAN,
                         };
            var hoadon1 = from hd in linQ.HOADONs
                         join gh in linQ.GIAOHANGs on hd.MAHD equals gh.MAHD

                          select new HD_GH()
                         {
                             MAHD = hd.MAHD,
                             MAKH = hd.MAKH,
                             MANV = gh.MANV,
                             MAHINHTHUC = hd.MAHINHTHUC,
                             MAKHUYENMAI = hd.MAKHUYENMAI,
                             NGAYDAT = hd.NGAYDAT,
                             DIACHIGIAO = hd.DIACHIGIAO,
                             KHOANGCACH = hd.KHOANGCACH,
                             PHIKC = hd.PHIKC,
                             THANHTIEN = hd.THANHTIEN,
                             TINHTRANGTHANHTOAN = hd.TINHTRANGTHANHTOAN,
                         };
            for(int i=0;i<hoadon.ToList<HD_GH>().Count;i++)
            {
                a.Add(hoadon.ToList<HD_GH>()[i]);
            }
            for (int i = 0; i < hoadon1.ToList<HD_GH>().Count; i++)
            {
                a.Add(hoadon1.ToList<HD_GH>()[i]);
            }
            return a;
        }
        public List<HD_GH> Load_HD_GH_DK(string TinhTrang)
        {

            var hoadon = from hd in linQ.HOADONs
                         join gh in linQ.GIAOHANGs on hd.MAHD equals gh.MAHD
                         where hd.TINHTRANGTHANHTOAN.Equals(TinhTrang)
                         select new HD_GH()
                         {
                             MAHD = hd.MAHD,
                             MAKH = hd.MAKH,
                             MANV = gh.MANV,
                             MAHINHTHUC = hd.MAHINHTHUC,
                             MAKHUYENMAI = hd.MAKHUYENMAI,
                             NGAYDAT = hd.NGAYDAT,
                             DIACHIGIAO = hd.DIACHIGIAO,
                             KHOANGCACH = hd.KHOANGCACH,
                             PHIKC = hd.PHIKC,
                             THANHTIEN = hd.THANHTIEN,
                             TINHTRANGTHANHTOAN = hd.TINHTRANGTHANHTOAN,
                         };
           return hoadon.ToList<HD_GH>();
        }
        public List<HD_GH> tim_HD_GH_DK(string MAHD)
        {

            var hoadon = from hd in linQ.HOADONs
                         join gh in linQ.GIAOHANGs on hd.MAHD equals gh.MAHD
                         where hd.MAHD.Equals(MAHD)
                         select new HD_GH()
                         {
                             MAHD = hd.MAHD,
                             MAKH = hd.MAKH,
                             MANV = gh.MANV,
                             MAHINHTHUC = hd.MAHINHTHUC,
                             MAKHUYENMAI = hd.MAKHUYENMAI,
                             NGAYDAT = hd.NGAYDAT,
                             DIACHIGIAO = hd.DIACHIGIAO,
                             KHOANGCACH = hd.KHOANGCACH,
                             PHIKC = hd.PHIKC,
                             THANHTIEN = hd.THANHTIEN,
                             TINHTRANGTHANHTOAN = hd.TINHTRANGTHANHTOAN,
                         };
            return hoadon.ToList<HD_GH>();
        }
        public List<HD_GH> Load_HD_GH_DKCHUANHAN()
        {

            var hoadon = from hd in linQ.HOADONs                         
                         where hd.TINHTRANGTHANHTOAN.Equals("Chưa được nhận")
                         select new HD_GH()
                         {
                             MAHD = hd.MAHD,
                             MAKH = hd.MAKH,
                             MANV = "",
                             MAHINHTHUC = hd.MAHINHTHUC,
                             MAKHUYENMAI = hd.MAKHUYENMAI,
                             NGAYDAT = hd.NGAYDAT,
                             DIACHIGIAO = hd.DIACHIGIAO,
                             KHOANGCACH = hd.KHOANGCACH,
                             PHIKC = hd.PHIKC,
                             THANHTIEN = hd.THANHTIEN,
                             TINHTRANGTHANHTOAN = hd.TINHTRANGTHANHTOAN,
                         };
            return hoadon.ToList<HD_GH>();
        }
        public int update_insert_HD_GH(string MAHD, string MANV, string TinhTrang)
        {
            try
            {
                if (TinhTrang == "Chưa được nhận")
                {
                    var update = linQ.HOADONs.Where(s => s.MAHD == MAHD).Single();
                    update.TINHTRANGTHANHTOAN = "Chưa giao";
                    linQ.SubmitChanges();
                    GIAOHANG a = new GIAOHANG();
                    a.MAHD = MAHD;
                    a.MANV = MANV;
                    linQ.GIAOHANGs.InsertOnSubmit(a);
                    linQ.SubmitChanges();
                }
                else if (TinhTrang == "Chưa giao")
                {
                    var delete = linQ.GIAOHANGs.Where(s => s.MAHD == MAHD).Single();
                    linQ.GIAOHANGs.DeleteOnSubmit(delete);
                    linQ.SubmitChanges();
                    GIAOHANG a = new GIAOHANG();
                    a.MAHD = MAHD;
                    a.MANV = MANV;
                    linQ.GIAOHANGs.InsertOnSubmit(a);
                    linQ.SubmitChanges();
                }
                return 1;
            }
            catch
            {
                return 0;
            }
            
        }
        public int delete_HD_GH(string MAHD)
        {
            try
            {
                var delete = linQ.GIAOHANGs.Where(s => s.MAHD == MAHD).Single();
                linQ.GIAOHANGs.DeleteOnSubmit(delete);
                linQ.SubmitChanges();
                var delete1 = linQ.HOADONs.Where(s => s.MAHD == MAHD).Single();
                linQ.HOADONs.DeleteOnSubmit(delete1);
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
