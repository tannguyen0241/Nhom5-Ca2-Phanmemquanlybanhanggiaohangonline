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
using System.Net;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp.Config;
using QuanLiBanHangOnline;

namespace QuanLyCuaHangThucAn.Control
{
    
    public partial class UC_DangKy : DevExpress.XtraEditors.XtraUserControl
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "HMeNGe4d1v6X4EXhlTi1YSoWJyH5BN5j082uCJV6",
            BasePath = "https://fash-159a7.firebaseio.com/",
        };
        IFirebaseClient client;
        public UC_DangKy()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            
        }

        private async void btnOK_ClickAsync(object sender, EventArgs e)
        {
            FirebaseResponse resp = await client.GetAsync("Counter/node");//lấy ra node
            Counter get = resp.ResultAs<Counter>();
            if (get== null)
            {
                var obj1 = new Counter { dem = 0};
                SetResponse setResponse1 = await client.SetAsync("Counter/node", obj1);
            }
            resp = await client.GetAsync("Counter/node");//lấy ra node
            get = resp.ResultAs<Counter>();
            try
            {
                var data = new TaiKhoan
                {
                    email = txtEmail.Text,
                    matkhau = txtMatKhau.Text,
                    quyen = "NV",
                    sdt = txtSDT.Text,
                    taikhoan = txtTaiKhoan.Text,
                };
                SetResponse response = await client.SetAsync("TaiKhoan/" + (get.dem+1), data);
                TaiKhoan result = response.ResultAs<TaiKhoan>();

                var obj = new Counter { dem = get.dem+1 };
                SetResponse setResponse = await client.SetAsync("Counter/node", obj);
            }
            catch
            {
                MessageBox.Show("Vui lòng thử lại");
            }
        }

        private async void btnDoiMK_Click(object sender, EventArgs e)
        {
            int i = 1;
            FirebaseResponse resp = await client.GetAsync("Counter/node");//lấy ra node
            Counter get = resp.ResultAs<Counter>();
            if (get == null)
            {
                var obj1 = new Counter { dem = 0 };
                SetResponse setResponse1 = await client.SetAsync("Counter/node", obj1);
            }
            resp = await client.GetAsync("Counter/node");//lấy ra node
            get = resp.ResultAs<Counter>();
            while (true)
            {
                try
                {
                    var data = new TaiKhoan
                    {
                        email = txtEmail.Text,
                        matkhau = "123",
                        quyen = "NV",
                        sdt = txtSDT.Text,
                        taikhoan = txtTaiKhoan.Text,
                    };
                    FirebaseResponse response = await client.GetAsync(("TaiKhoan/" + i).ToString());
                    TaiKhoan result = response.ResultAs<TaiKhoan>();

                    if (txtTaiKhoan.Text.Equals(result.taikhoan) && txtMatKhau.Text.Equals(result.matkhau))
                    {
                        SetResponse response1 = await client.SetAsync("TaiKhoan/" + i, data);
                        TaiKhoan result1 = response.ResultAs<TaiKhoan>();
                        break;
                    }
                    i++;
                }
                catch
                {
                    MessageBox.Show("Vui lòng thử lại");
                }
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            int i = 1;
            FirebaseResponse resp = await client.GetAsync("Counter/node");//lấy ra node
            Counter get = resp.ResultAs<Counter>();
            if (get == null)
            {
                var obj1 = new Counter { dem = 0 };
                SetResponse setResponse1 = await client.SetAsync("Counter/node", obj1);
            }
            resp = await client.GetAsync("Counter/node");//lấy ra node
            get = resp.ResultAs<Counter>();
            while (true)
            {
                try
                {
                    var data = new TaiKhoan
                    {
                    };
                    FirebaseResponse response = await client.GetAsync(("TaiKhoan/" + i).ToString());
                    TaiKhoan result = response.ResultAs<TaiKhoan>();

                    if (txtTaiKhoan.Text.Equals(result.taikhoan) && txtMatKhau.Text.Equals(result.matkhau))
                    {
                        SetResponse response1 = await client.SetAsync("TaiKhoan/" + i, data);
                        TaiKhoan result1 = response.ResultAs<TaiKhoan>();
                        var obj = new Counter { dem = get.dem - 1 };
                        SetResponse setResponse = await client.SetAsync("Counter/node", obj);
                        break;
                    }
                    i++;
                }
                catch
                {
                    MessageBox.Show("Vui lòng thử lại");
                    break;
                }
            }
        }
    }
}
