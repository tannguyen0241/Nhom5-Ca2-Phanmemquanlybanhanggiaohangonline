using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_TaiKhoan
    {
        DAL_TaiKhoan dAL_TaiKhoan = new DAL_TaiKhoan();
        public int timTaiKhoan(string TenTK, string MatKhau)
        {
            return dAL_TaiKhoan.timTaiKhoan(TenTK, MatKhau);
        }
    }
}
