using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;
namespace QuanLyCuaHangThucAn.Control
{
    public partial class UC_DangNhap : DevExpress.XtraEditors.XtraUserControl
    {
        BLL_TaiKhoan bLLNhaCungCap = new BLL_TaiKhoan();
        public UC_DangNhap()
        {
            InitializeComponent();
        }

        private void UC_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(bLLNhaCungCap.timTaiKhoan(txtTaiKhoan.Text,txtMatKhau.Text)==0)
            {
                MessageBox.Show("Đăng nhập thành công");

            }
            else
                MessageBox.Show("Kiểm tra lại tài khoản mật khẩu");
        }
    }
}
