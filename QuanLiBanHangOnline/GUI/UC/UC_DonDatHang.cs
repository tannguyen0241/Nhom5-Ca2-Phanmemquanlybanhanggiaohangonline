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
using BLL_LINQ;
namespace QuanLiBanHangOnline.UC
{
    public partial class UC_DonDatHang : DevExpress.XtraEditors.XtraUserControl
    {
        LINQ_QLBHDataContext linQ= new LINQ_QLBHDataContext();

        BLL_KhachHang bLL_KhachHang = new BLL_KhachHang();

        BLL_HoaDon bLL_HoaDon = new BLL_HoaDon();
        public UC_DonDatHang()
        {
            
            InitializeComponent();            
            LoadGrid();
            dongControl();

        }
        public void LoadGrid()
        {
            gridDSDonHang.DataSource = bLL_HoaDon.LoadHoaDon();
        }
        public void dongControl()
        {
            txtMADH.Enabled = false;
            txtNgayDat.Enabled= false;
            txtTenKhach.Enabled = false;
            txtTinhTrang.Enabled = false;
            txtTongTien.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var kh = bLL_HoaDon.LoadHoaDonDK(txtTKMADH.Text);
            gridDSDonHang.DataSource = kh;
            gridView1.SelectRow(0);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bLL_HoaDon.xoaHoaDon(txtMADH.Text) == 1)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bại");
            LoadGrid();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            HOADON ctob = (HOADON)gridView1.GetRow(gridView1.FocusedRowHandle);
            txtMADH.Text = ctob.MAHD;
            txtNgayDat.Text = ctob.NGAYDAT.ToString();
            txtTinhTrang.Text = ctob.TINHTRANGTHANHTOAN;
            txtTongTien.Text = ctob.THANHTIEN.ToString();
            var kh = bLL_KhachHang.LoadMotKhachHang(ctob.MAKH);
            txtTenKhach.Text = ((KHACHHANG)kh).TENKH;
        }
        
    }
}
