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
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp;
using FireSharp.Response;
using QuanLiBanHangOnline;

namespace QuanLyCuaHangThucAn.Control
{
    public partial class UC_DangNhap : DevExpress.XtraEditors.XtraUserControl
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "HMeNGe4d1v6X4EXhlTi1YSoWJyH5BN5j082uCJV6",
            BasePath = "https://fash-159a7.firebaseio.com/",
        };
        IFirebaseClient client;

        public UC_DangNhap()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
                   }

        private void UC_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private async void btnOK_ClickAsync(object sender, EventArgs e)
        {
            int i = 1;
            FirebaseResponse response1 = await client.GetAsync("Counter/node");
            Counter obj = response1.ResultAs<Counter>();
            int cnt = Convert.ToInt32(obj.dem);
            while (true)
            {
                try
                {

                    FirebaseResponse response = await client.GetAsync("TaiKhoan/"+i);
                    TaiKhoan taiKhoan = response.ResultAs<TaiKhoan>();
                    if (taiKhoan.taikhoan.Equals(txtTaiKhoan.Text) && taiKhoan.matkhau.Equals(txtMatKhau.Text))
                    {
                        MessageBox.Show("Dang Nhap Thanh Cong");

                        break;
                    }
                    else if (i == cnt)
                    {
                        MessageBox.Show("Vui long kiem tra lai tai khoan mat khau");
                        break;
                    }
                    else

                        i++;
                }
                catch
                {

                }

            }
        }
    }
}
