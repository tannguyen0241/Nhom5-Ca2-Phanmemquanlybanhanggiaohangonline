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
    public partial class UC_TTTaikhoan : DevExpress.XtraEditors.XtraUserControl
    {
        BLL_TaiKhoan bLL_TaiKhoan = new BLL_TaiKhoan();
        BLL_NhanVien bLL_NhanVien = new BLL_NhanVien();
        public string TK;
        public UC_TTTaikhoan()
        {
            InitializeComponent();
        
        }
        public UC_TTTaikhoan(string TK)
        {
            InitializeComponent();
            this.TK = TK;
            loadTT();
            dongControl();
        }
        public void dongControl()
        {
            txtDiaChi.Enabled = false;
            txtHoTen.Enabled = false;
            txtSDT.Enabled = false;
            txtMKCU.Enabled = false;
            txtMKM1.Enabled = false;
            txtMKM2.Enabled = false;
            btnLuuHinh.Enabled = false;
            btnLuuMK.Enabled = false;

        }
        public void loadTT()
        {
            var a = bLL_TaiKhoan.load_TK_NV(TK);
            txtHoTen.Text = a.TENNV;
            txtDiaChi.Text = a.DIACHI;
            txtSDT.Text = a.SDT;
            image.Image = CovertBytetoImage(bLL_NhanVien.layHinh(a.TAIKHOAN));
            image.ImageLocation = null;
        }

        private Image CovertBytetoImage(object p)
        {
            throw new NotImplementedException();
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
            btnLuuHinh.Enabled = true;

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

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            btnLuuMK.Enabled = true;
            txtMKCU.Enabled = true;
            txtMKM1.Enabled = true;
            txtMKM2.Enabled = true;
        }

        private void btnLuuMK_Click(object sender, EventArgs e)
        {
            if (txtMKM1.Text == txtMKM2.Text)
            {
                if(bLL_TaiKhoan.update_TaiKhoan(TK, txtMKCU.Text, txtMKM1.Text)==1)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");

                btnLuuMK.Enabled = false;
            }
            else
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp");
            }
        }

        private void btnLuuHinh_Click(object sender, EventArgs e)
        {
            if (bLL_TaiKhoan.sua_ImageTK(TK, image.ImageLocation) == 1)
                MessageBox.Show("Thành công");
            else
                MessageBox.Show("Thất bại");
            btnLuuHinh.Enabled = false;
        }
        
    }
}
