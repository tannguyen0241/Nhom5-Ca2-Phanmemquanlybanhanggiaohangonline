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
using System.IO;

namespace QuanLiBanHangOnline.GUI
{
    public partial class UC_TTNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        BLL_NhanVien bLL_NhanVien = new BLL_NhanVien();
        string STT;
        public UC_TTNhanVien()
        {
            InitializeComponent();
            loadNV();
            dongControl();
        }
        public void loadNV()
        {
            gribDSNV.DataSource= bLL_NhanVien.loadNhanVien();
        }
        public void dongControl()
        {
            txtDiaChi.Enabled = false;
            txtMANV.Enabled = false;
            txtSDT.Enabled = false;
            txtTenNV.Enabled = false;
            rdoNam.Enabled = false;
            rdoNu.Enabled = false;
            dateNgaySinh.Enabled = false;
            cboChucVu.Enabled = false;
            btnLuu.Enabled = false;
            btnChon.Enabled = false;
        }
        public void moControl()
        {
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            txtTenNV.Enabled = true;
            rdoNam.Enabled = true;
            rdoNu.Enabled = true;
            dateNgaySinh.Enabled = true;
            cboChucVu.Enabled = true;
            btnLuu.Enabled = true;
            rdoNam.Checked = true;
            btnChon.Enabled = true;
        }
        public void resetControl()
        {
            foreach (Control a in groupThongtinnhanvien.Controls)
            {

                if (a is RadioButton)
                {
                    ((RadioButton)a).Checked = false;
                }
                else if (a is TextEdit)
                    a.Text = "";
                else if (a is PictureBox)
                    ((PictureBox)a).Image = null;
            }

            cboChucVu.Text = "";
            dateNgaySinh.Text = "";
        }
        public int ktControlTrong()
        {
            foreach (Control a in groupThongtinnhanvien.Controls)
            {
                
                    if (a is TextBox)
                    {
                        ((TextBox)a).Text = "";
                        return 0;
                    }                    
            }

            if (cboChucVu.Text == "")
                return 0;
            if (dateNgaySinh.Text == "")
                return 0;
            return 1;
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            NHANVIEN ctob = (NHANVIEN)gridView1.GetRow(gridView1.FocusedRowHandle);
            txtMANV.Text = ctob.MANV;
            txtDiaChi.Text = ctob.DIACHI;
            txtSDT.Text = ctob.SDT;
            txtTenNV.Text = ctob.TENNV;
            cboChucVu.Text = ctob.CHUCVU;
            dateNgaySinh.Text = ctob.NGAYSINH.ToString();
            image.Image = CovertBytetoImage(bLL_NhanVien.layHinh(txtMANV.Text));
            image.ImageLocation = null;
            if (ctob.GIOITINH == "Nam")
            {
                rdoNam.Checked = true;
            }
            else
                rdoNu.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            moControl();
            resetControl();
            STT = "Thêm";
            List<NHANVIEN> a = bLL_NhanVien.loadNhanVien();
            for (int i=0;i<i+1;i++)
            {
                int b = bLL_NhanVien.timkiem_NhanVien("NV0" + i).Count;
                if (bLL_NhanVien.timkiem_NhanVien("NV0"+i).Count==0)
                {
                    txtMANV.Text = "NV0" + i;
                    break;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            moControl();
            STT = "Sửa";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(ktControlTrong()==0)
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin");
                return;
            }
            if(STT=="Thêm")
            {
                string GT="Nữ";
                if (rdoNam.Checked == true)
                    GT = "Nam";
                if(bLL_NhanVien.them_NhanVien(txtMANV.Text, txtTenNV.Text, txtSDT.Text, txtDiaChi.Text, GT, dateNgaySinh.Text, cboChucVu.Text, image.ImageLocation)==1)
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Thất bại");
            }   
            if (STT == "Sửa")
            {
                string GT = "Nữ";
                if (rdoNam.Checked == true)
                    GT = "Nam";
                if(bLL_NhanVien.sua_NhanVien(txtMANV.Text, txtTenNV.Text, txtSDT.Text, txtDiaChi.Text, GT, dateNgaySinh.Text, cboChucVu.Text,image.ImageLocation)==1)
                    MessageBox.Show("Cập nhật thành công");
                else
                    MessageBox.Show("Thất bại");
            }
            dongControl();
            resetControl();
            loadNV();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (bLL_NhanVien.xoa_NhanVien(txtMANV.Text) == 1)
                MessageBox.Show("Thành công");
            else
                MessageBox.Show("Thất bại");
            resetControl();
            loadNV();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            gribDSNV.DataSource= bLL_NhanVien.timkiem_NhanVienTen(txtTKNV.Text);
        }
        private void btnchon_Click(object sender, EventArgs e)
        {
            string filepath = null;
            OpenFileDialog ofdImages = new OpenFileDialog();
            ofdImages.Title = "Vui lòng chọn hình";
            ofdImages.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                filepath = ofdImages.FileName;
            }
            if (filepath != null)
            {
                this.image.ImageLocation = filepath;
            }

        }
        private Image CovertBytetoImage(byte[] photo)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(photo))
                {

                    Image image = Image.FromStream(ms);
                    return image;
                }
            }
            catch
            {
                return null;
            }
            
        }
        

    }
}
