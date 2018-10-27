using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraTab;
using QuanLyCuaHangThucAn.Control;

namespace QuanLiBanHangOnline
{
    public partial class Quanlibanhang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Quanlibanhang()
        {
            InitializeComponent();
        }
        public void AddTab(XtraTabControl XtraTabCha, string TabNameAdd, UserControl UserControl)
        {
            // Khởi tạo 1 Tab Con (XtraTabPage)
            DevExpress.XtraTab.XtraTabPage TAbAdd = new DevExpress.XtraTab.XtraTabPage();
            // Đặt đại cái tên cho nó là TestTab (Đây là tên nhé)
            TAbAdd.Name = "Tab";
            // Tên của nó là đối số như đã nói ở trên
            TAbAdd.Text = TabNameAdd;
            // Add đối số UserControl vào Tab con vừa khởi tạo ở trên
            TAbAdd.Controls.Add(UserControl);
            // Dock cho nó tràn hết TAb con đó
            UserControl.Dock = DockStyle.Fill;
            // Quăng nó lên TAb Cha (XtraTabCha là đối số thứ nhất như đã nói ở trên)
            XtraTabCha.TabPages.Add(TAbAdd);
        }
        private void btnDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_DangKy uC_DangKy = new UC_DangKy();
            AddTab(xtraTabControl1, "Đăng ký",uC_DangKy);
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_DangNhap uC_DangNhap = new UC_DangNhap();
            AddTab(xtraTabControl1, "Đăng nhập", uC_DangNhap);
        }
    }
}
