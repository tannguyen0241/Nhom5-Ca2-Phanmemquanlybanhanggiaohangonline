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
using QuanLiBanHangOnline.GUI;
using QuanLiBanHangOnline.UC;

namespace QuanLiBanHangOnline
{
    public partial class Quanlibanhang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Quanlibanhang()
        {
            InitializeComponent();
        }
        public Quanlibanhang(string TK)
        {
            InitializeComponent();
            labelTK.Caption = TK;
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
        private void xtraTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            xtraTabControl.TabPages.RemoveAt(xtraTabControl.SelectedTabPageIndex);
            xtraTabControl.SelectedTabPageIndex = xtraTabControl.TabPages.Count - 1;
        }

        private void xtraTabControl_ControlAdded(object sender, ControlEventArgs e)
        {
            xtraTabControl.SelectedTabPageIndex = xtraTabControl.TabPages.Count - 1;
        }
        private void AddTabControl(UserControl userControl, string itemTabName)
        {
            bool isExists = false;
            foreach (XtraTabPage tabItem in xtraTabControl.TabPages)
            {
                if (tabItem.Text == itemTabName)
                {
                    isExists = true;
                    xtraTabControl.SelectedTabPage = tabItem;
                }
            }
            if (isExists == false)
            {
                AddTab(xtraTabControl, itemTabName, userControl);
            }
        }
        private void btntttk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_TTTaikhoan tTTaikhoan = new UC_TTTaikhoan(labelTK.Caption);
            AddTabControl(tTTaikhoan,"Thông tin tài khoản");
        }

        private void btnDonDatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_DonDatHang uC_DonDatHang = new UC_DonDatHang();
            AddTab(xtraTabControl, "Đơn đặt hàng", uC_DonDatHang);
        }

        private void btnGiaoHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_Giaohang uC_Giaohang = new UC_Giaohang();
            AddTab(xtraTabControl, "Giao hàng", uC_Giaohang);
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_TTNhanVien uC_TTNhanVien = new UC_TTNhanVien();
            AddTab(xtraTabControl, "Nhân viên", uC_TTNhanVien);
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            DangNhap a =new  DangNhap();
            a.Show();
            a.FormClosed += new FormClosedEventHandler(frm_dong);

            this.Hide();
        }

        private void frm_dong(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
