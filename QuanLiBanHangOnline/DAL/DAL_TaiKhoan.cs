using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.QuanLyBanHanOnlineTableAdapters;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        QL_NGUOIDUNGTableAdapter qL_NGUOIDUNGTableAdapter = new QL_NGUOIDUNGTableAdapter();
        public int timTaiKhoan(string TenTK,string MatKhau)
        {
            if (qL_NGUOIDUNGTableAdapter.timTaiKhoan(TenTK,MatKhau) > 0)
                return 0;
            return 1;
        }
    }
}
