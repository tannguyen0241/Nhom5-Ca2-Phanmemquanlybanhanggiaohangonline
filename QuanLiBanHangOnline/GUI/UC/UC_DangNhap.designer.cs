namespace QuanLyCuaHangThucAn.Control
{
    partial class UC_DangNhap
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DangNhap));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.txtTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 44);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên tài khoản";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(315, 197);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 30);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 92);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 17);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(460, 197);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 30);
            this.btnDong.TabIndex = 10;
            this.btnDong.Text = "Đóng";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(137, 39);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(245, 24);
            this.txtTaiKhoan.TabIndex = 11;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(137, 86);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(245, 24);
            this.txtMatKhau.TabIndex = 12;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(1, 4);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(180, 186);
            this.pictureEdit1.TabIndex = 13;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 153);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(121, 17);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Bạn quên mật khẩu?";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Controls.Add(this.hyperlinkLabelControl1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtMatKhau);
            this.groupControl1.Controls.Add(this.txtTaiKhoan);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(177, 4);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(427, 186);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Đăng nhập";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(269, 120);
            this.checkEdit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Nhớ mật khẩu";
            this.checkEdit1.Size = new System.Drawing.Size(113, 21);
            this.checkEdit1.TabIndex = 16;
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(163, 153);
            this.hyperlinkLabelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(98, 17);
            this.hyperlinkLabelControl1.TabIndex = 15;
            this.hyperlinkLabelControl1.Text = "Lấy lại mật khẩu";
            // 
            // UC_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnOK);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_DangNhap";
            this.Size = new System.Drawing.Size(608, 242);
            this.Load += new System.EventHandler(this.UC_DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.TextEdit txtTaiKhoan;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
    }
}
