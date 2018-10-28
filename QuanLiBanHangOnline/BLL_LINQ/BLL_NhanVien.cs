using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_LINQ
{
    public class BLL_NhanVien
    {
        LINQ_QLBHDataContext linQ = new LINQ_QLBHDataContext();

        BLL_TaiKhoan bLL_TaiKhoan = new BLL_TaiKhoan();
        public List<NHANVIEN> loadNhanVien()
        {
            var nv = from Nhanvien in linQ.NHANVIENs select Nhanvien;
            return nv.ToList<NHANVIEN>();
        }
        public List<NHANVIEN> timkiem_NhanVien(string MANV)
        {
            var nv = from Nhanvien in linQ.NHANVIENs where Nhanvien.MANV.Equals(MANV) select Nhanvien;
            return nv.ToList<NHANVIEN>();
        }
        public List<NHANVIEN> timkiem_NhanVienTen(string TENNV)
        {
            var nv = from Nhanvien in linQ.NHANVIENs where Nhanvien.TENNV.Equals(TENNV) select Nhanvien;
            return nv.ToList<NHANVIEN>();
        }
        public int them_NhanVien(string MANV, string TENNV, string SDT, string DIACHI, string GIOITINH, string NGAYSINH, string CHUCVU, string hinh)
        {
            try
            {
                NHANVIEN a = new NHANVIEN();
                a.MANV = MANV;
                a.TENNV = TENNV;
                a.SDT = SDT;
                a.DIACHI = DIACHI;
                a.GIOITINH = GIOITINH;
                a.NGAYSINH = DateTime.Parse(NGAYSINH);
                a.CHUCVU = CHUCVU;
                a.IMAGE= CoverFilltoByte(hinh);
                linQ.NHANVIENs.InsertOnSubmit(a);
                linQ.SubmitChanges();
                bLL_TaiKhoan.them_TaiKhoan(MANV);
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int sua_NhanVien(string MANV, string TENNV, string SDT, string DIACHI, string GIOITINH, string NGAYSINH, string CHUCVU, string hinh)
        {
            try
            {
                var update = linQ.NHANVIENs.Where(s => s.MANV == MANV).Single();
                update.TENNV = TENNV;
                update.SDT = SDT;
                update.DIACHI = DIACHI;
                update.GIOITINH = GIOITINH;
                update.NGAYSINH = DateTime.Parse(NGAYSINH);
                update.CHUCVU = CHUCVU;
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
        public int xoa_NhanVien(string MANV)
        {
            try
            {
                var delete = linQ.NHANVIENs.Where(s => s.MANV == MANV).Single();
                linQ.NHANVIENs.DeleteOnSubmit(delete);
                linQ.SubmitChanges();
                return 1;
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
