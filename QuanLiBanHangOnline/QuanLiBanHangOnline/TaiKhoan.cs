using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHangOnline
{
    internal class TaiKhoan
    {
        public string _email, _matkhau, _quyen, _sdt, _taikhoan;
        public TaiKhoan()
        {
            
        }
        public TaiKhoan(string email, string matkhau, string quyen, string sdt, string taikhoan)
        {
            this._email = email;
            this._matkhau = matkhau;
            this._quyen = quyen;
            this._sdt = sdt;
            this._taikhoan = taikhoan;
        }

        public string email { get; set; }
        public string matkhau { get; set; }
        public string quyen { get; set; }
        public string sdt { get; set; }
        public string taikhoan { get; set; }
    }
}
