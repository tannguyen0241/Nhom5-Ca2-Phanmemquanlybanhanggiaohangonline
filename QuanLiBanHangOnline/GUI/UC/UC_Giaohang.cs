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
namespace QuanLiBanHangOnline.GUI
{
    public partial class UC_Giaohang : DevExpress.XtraEditors.XtraUserControl
    {
        LINQ_QLBHDataContext linQ= new LINQ_QLBHDataContext();

        BLL_KhachHang bLL_KhachHang = new BLL_KhachHang();
        BLL_NhanVien bLL_NhanVien = new BLL_NhanVien();
        BLL_HoaDon bLL_HoaDon = new BLL_HoaDon();
        BLL_GiaoHang bLL_GiaoHang = new BLL_GiaoHang();
        public UC_Giaohang()
        {
            InitializeComponent();
            rdoTatCa.Select();
            LoadGrid();
            txtMAHD.Enabled = false;
            txtTenKhach.Enabled = false;
            txtTinhTrang.Enabled = false;
            txtTongTien.Enabled = false;
            cboTenNhanVien.Enabled = false;
        }
        public void LoadGrid()
        {
            if (rdoTatCa.Checked == true)
            {
                gridDSDonHang.DataSource = bLL_GiaoHang.Load_HD_GH();
            }
            else
            {
                foreach(Control a in groupLoc.Controls)
                {
                    if(a is RadioButton)
                    {
                        if(((RadioButton)a).Checked==true)
                        {
                            if(((RadioButton)a).Text=="Chưa được nhận")
                            {
                                gridDSDonHang.DataSource = bLL_GiaoHang.Load_HD_GH_DKCHUANHAN();
                                return;
                            }
                            gridDSDonHang.DataSource = bLL_GiaoHang.Load_HD_GH_DK(((RadioButton)a).Text);
                        }
                    }
                }
            }
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            HD_GH ctob = (HD_GH)gridView1.GetRow(gridView1.FocusedRowHandle);
            txtMAHD.Text = ctob.MAHD;
            txtTinhTrang.Text = ctob.TINHTRANGTHANHTOAN;
            txtTongTien.Text = ctob.THANHTIEN.ToString();
            var kh = bLL_KhachHang.LoadMotKhachHang(ctob.MAKH);
            txtTenKhach.Text = ((KHACHHANG)kh).TENKH;
            cboTenNhanVien.DataSource = bLL_NhanVien.timkiem_NhanVien(ctob.MANV);
            cboTenNhanVien.DisplayMember = "TENNV";
        }


        private void rdoChuaNhan_CheckedChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cboTenNhanVien.Enabled = true;
            cboTenNhanVien.DataSource= bLL_NhanVien.loadNhanVien();
            cboTenNhanVien.DisplayMember = "TENNV";
            cboTenNhanVien.ValueMember = "MANV";

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTinhTrang.Text == "Chưa được nhận" || txtTinhTrang.Text == "Chưa giao")
            {
                if(bLL_GiaoHang.update_insert_HD_GH(txtMAHD.Text.Trim(), cboTenNhanVien.SelectedValue.ToString(), txtTinhTrang.Text)==1)
                    MessageBox.Show("Cập nhật thành công");
                else
                    MessageBox.Show("Cập nhật thất bại");
                LoadGrid();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bLL_GiaoHang.delete_HD_GH(txtMAHD.Text) == 1)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bại");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            gridDSDonHang.DataSource = bLL_GiaoHang.tim_HD_GH_DK(txtTKMAHD.Text);
        }
    }
}
