using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace QuanLiBanHangOnline
{
    public partial class DangNhap : Form
    {
        BLL_TaiKhoan bLLNhaCungCap = new BLL_TaiKhoan();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (bLLNhaCungCap.timTaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text) == 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                Form a = new Quanlibanhang(txtTaiKhoan.Text);
                a.Show();
                a.FormClosed += new FormClosedEventHandler(frm_dong);                
                this.Hide();
            }            

        
            else
                MessageBox.Show("Kiểm tra lại tài khoản mật khẩu");
        }
        private void frm_dong(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
