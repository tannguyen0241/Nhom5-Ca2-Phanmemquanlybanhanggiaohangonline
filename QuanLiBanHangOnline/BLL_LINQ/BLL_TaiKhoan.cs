using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_LINQ
{
    public class BLL_TaiKhoan
    {
        LINQ_QLBHDataContext linQ = new LINQ_QLBHDataContext();
        public class TK_NV
        {
            public string TAIKHOAN { get; set; }
            public string TENNV { get; set; }
            public string DIACHI { get; set; }
            public string SDT { get; set; }
            public string MATKHAU { get; set; }
            public Binary Hinh { get; set; }

        }
        public TK_NV load_TK_NV(string TAIKHOAN)
        {
            try
            {
                var hoadon1 = from tk in linQ.QL_NGUOIDUNGs
                              join nv in linQ.NHANVIENs on tk.MANV equals nv.MANV
                              where tk.TENDANGNHAP.Equals(TAIKHOAN)
                              select new TK_NV()
                              {
                                  TAIKHOAN = tk.TENDANGNHAP,
                                  TENNV = nv.TENNV,
                                  DIACHI=nv.DIACHI,
                                  SDT=nv.SDT,
                                  MATKHAU=tk.MATKHAU,
                                  Hinh=nv.IMAGE,
                              };
                return hoadon1.ToList<TK_NV>()[0];
            }
            catch
            {
                return null;
            }
            
        }
        public int update_TaiKhoan(string TK, string mk, string mkm)
        {
            try
            {
                var update = from tk in linQ.QL_NGUOIDUNGs
                             where tk.TENDANGNHAP.Equals(TK) && tk.MATKHAU.Equals(mk)
                             select tk;
                update.ToList<QL_NGUOIDUNG>()[0].MATKHAU = mkm;
                linQ.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int sua_ImageTK(string TK,string hinh)
        {
            try
            {
                var update = linQ.NHANVIENs.Where(s => s.MANV == TK).Single();
               
                if (hinh != null)
                {
                    update.IMAGE = CoverFilltoByte(hinh);
                }
                linQ.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int them_TaiKhoan(string MANV)
        {
            try
            {
                QL_NGUOIDUNG a = new QL_NGUOIDUNG();
                a.MANV = MANV;
                a.TENDANGNHAP = MANV;
                a.MATKHAU = MANV;
                a.HOATDONG = "Kích hoạt";
                linQ.QL_NGUOIDUNGs.InsertOnSubmit(a);
                linQ.SubmitChanges();
                return 0;
            }
            catch
            {
                return 0;
            }
        }
        private byte[] CoverFilltoByte(string Path)
        {
            byte[] data = null;
            FileInfo info = new FileInfo(Path);
            long numByte = info.Length;
            FileStream fstream = new FileStream(Path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            data = br.ReadBytes((int)numByte);
            return data;
        }
        public byte[] layHinh(string ma)
        {
            try
            {
                var db = new LINQ_QLBHDataContext();
                var q = db.NHANVIENs.Where(c => c.MANV == ma).Single();
                byte[] arrpic = (byte[])(q.IMAGE).ToArray();
                return arrpic;
            }
            catch
            {
                return null;
            }
        }

    }
}
