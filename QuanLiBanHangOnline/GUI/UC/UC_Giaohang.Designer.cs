namespace QuanLiBanHangOnline.GUI
{
    partial class UC_Giaohang
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
            this.label1 = new System.Windows.Forms.Label();
            this.TINHTRANGTHANHTOAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PHIKC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHOANGCACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIACHIGIAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYDAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAKHUYENMAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAHINHTHUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THANHTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDSDonHang = new DevExpress.XtraGrid.GridControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTKMAHD = new DevExpress.XtraEditors.TextEdit();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cboTenNhanVien = new System.Windows.Forms.ComboBox();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTinhTrang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenKhach = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMAHD = new DevExpress.XtraEditors.TextEdit();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupLoc = new DevExpress.XtraEditors.GroupControl();
            this.rdoThatBai = new System.Windows.Forms.RadioButton();
            this.rdoDaGiao = new System.Windows.Forms.RadioButton();
            this.rdoChuaGiao = new System.Windows.Forms.RadioButton();
            this.rdoChuaNhan = new System.Windows.Forms.RadioButton();
            this.rdoTatCa = new System.Windows.Forms.RadioButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTKMAHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTinhTrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupLoc)).BeginInit();
            this.groupLoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1350, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "THÔNG TIN GIAO HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TINHTRANGTHANHTOAN
            // 
            this.TINHTRANGTHANHTOAN.Caption = "Tình Trạng Thanh Toán";
            this.TINHTRANGTHANHTOAN.FieldName = "TINHTRANGTHANHTOAN";
            this.TINHTRANGTHANHTOAN.Name = "TINHTRANGTHANHTOAN";
            this.TINHTRANGTHANHTOAN.Visible = true;
            this.TINHTRANGTHANHTOAN.VisibleIndex = 10;
            // 
            // PHIKC
            // 
            this.PHIKC.Caption = "Phí Giao";
            this.PHIKC.FieldName = "PHIKC";
            this.PHIKC.Name = "PHIKC";
            this.PHIKC.Visible = true;
            this.PHIKC.VisibleIndex = 8;
            // 
            // KHOANGCACH
            // 
            this.KHOANGCACH.Caption = "Khoảng Cách";
            this.KHOANGCACH.FieldName = "KHOANGCACH";
            this.KHOANGCACH.Name = "KHOANGCACH";
            this.KHOANGCACH.Visible = true;
            this.KHOANGCACH.VisibleIndex = 7;
            // 
            // DIACHIGIAO
            // 
            this.DIACHIGIAO.Caption = "Địa Chỉ Giao";
            this.DIACHIGIAO.FieldName = "DIACHIGIAO";
            this.DIACHIGIAO.Name = "DIACHIGIAO";
            this.DIACHIGIAO.Visible = true;
            this.DIACHIGIAO.VisibleIndex = 6;
            // 
            // NGAYDAT
            // 
            this.NGAYDAT.Caption = "Ngày Đặt";
            this.NGAYDAT.FieldName = "NGAYDAT";
            this.NGAYDAT.Name = "NGAYDAT";
            this.NGAYDAT.Visible = true;
            this.NGAYDAT.VisibleIndex = 5;
            // 
            // MAKHUYENMAI
            // 
            this.MAKHUYENMAI.Caption = "Mã Khuyến Mãi";
            this.MAKHUYENMAI.FieldName = "MAKHUYENMAI";
            this.MAKHUYENMAI.Name = "MAKHUYENMAI";
            this.MAKHUYENMAI.Visible = true;
            this.MAKHUYENMAI.VisibleIndex = 4;
            // 
            // MAHINHTHUC
            // 
            this.MAHINHTHUC.Caption = "Mã Hình Thức";
            this.MAHINHTHUC.FieldName = "MAHINHTHUC";
            this.MAHINHTHUC.Name = "MAHINHTHUC";
            this.MAHINHTHUC.Visible = true;
            this.MAHINHTHUC.VisibleIndex = 3;
            // 
            // MAKH
            // 
            this.MAKH.Caption = "Mã Khách Hàng";
            this.MAKH.FieldName = "MAKH";
            this.MAKH.Name = "MAKH";
            this.MAKH.Visible = true;
            this.MAKH.VisibleIndex = 2;
            // 
            // MAHD
            // 
            this.MAHD.Caption = "Mã Hóa Đơn";
            this.MAHD.FieldName = "MAHD";
            this.MAHD.Name = "MAHD";
            this.MAHD.Visible = true;
            this.MAHD.VisibleIndex = 0;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAHD,
            this.MANV,
            this.MAKH,
            this.MAHINHTHUC,
            this.MAKHUYENMAI,
            this.NGAYDAT,
            this.DIACHIGIAO,
            this.KHOANGCACH,
            this.PHIKC,
            this.THANHTIEN,
            this.TINHTRANGTHANHTOAN});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridDSDonHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // MANV
            // 
            this.MANV.Caption = "Mã Nhân Viên";
            this.MANV.FieldName = "MANV";
            this.MANV.Name = "MANV";
            this.MANV.Visible = true;
            this.MANV.VisibleIndex = 1;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.Caption = "Thành Tiền";
            this.THANHTIEN.FieldName = "THANHTIEN";
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.Visible = true;
            this.THANHTIEN.VisibleIndex = 9;
            // 
            // gridDSDonHang
            // 
            this.gridDSDonHang.Location = new System.Drawing.Point(398, 60);
            this.gridDSDonHang.MainView = this.gridView1;
            this.gridDSDonHang.Name = "gridDSDonHang";
            this.gridDSDonHang.Size = new System.Drawing.Size(949, 488);
            this.gridDSDonHang.TabIndex = 8;
            this.gridDSDonHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 17);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Mã hóa đơn:";
            // 
            // txtTKMAHD
            // 
            this.txtTKMAHD.Location = new System.Drawing.Point(144, 27);
            this.txtTKMAHD.Name = "txtTKMAHD";
            this.txtTKMAHD.Size = new System.Drawing.Size(215, 24);
            this.txtTKMAHD.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(284, 57);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.groupControl2.Controls.Add(this.btnSua);
            this.groupControl2.Controls.Add(this.cboTenNhanVien);
            this.groupControl2.Controls.Add(this.btnLuu);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.txtTongTien);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtTinhTrang);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.txtTenKhach);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.txtMAHD);
            this.groupControl2.Controls.Add(this.btnXoa);
            this.groupControl2.Location = new System.Drawing.Point(0, 184);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(389, 304);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Thông tin đơn hàng";
            // 
            // cboTenNhanVien
            // 
            this.cboTenNhanVien.FormattingEnabled = true;
            this.cboTenNhanVien.Location = new System.Drawing.Point(144, 232);
            this.cboTenNhanVien.Name = "cboTenNhanVien";
            this.cboTenNhanVien.Size = new System.Drawing.Size(215, 25);
            this.cboTenNhanVien.TabIndex = 18;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(194, 268);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(23, 140);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(58, 17);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(144, 138);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(215, 24);
            this.txtTongTien.TabIndex = 15;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(23, 190);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 17);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Tình trạng";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(144, 188);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(215, 24);
            this.txtTinhTrang.TabIndex = 13;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 240);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(86, 17);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Tên nhân viên:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(97, 17);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Tên khách hàng:";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(144, 88);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(215, 24);
            this.txtTenKhach.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 17);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Mã hóa đơn:";
            // 
            // txtMAHD
            // 
            this.txtMAHD.Location = new System.Drawing.Point(144, 38);
            this.txtMAHD.Name = "txtMAHD";
            this.txtMAHD.Size = new System.Drawing.Size(215, 24);
            this.txtMAHD.TabIndex = 7;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(284, 268);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupLoc);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtTKMAHD);
            this.groupControl1.Controls.Add(this.btnTimKiem);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Location = new System.Drawing.Point(0, 60);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(389, 488);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Thông tin tìm kiếm";
            // 
            // groupLoc
            // 
            this.groupLoc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.groupLoc.Controls.Add(this.rdoThatBai);
            this.groupLoc.Controls.Add(this.rdoDaGiao);
            this.groupLoc.Controls.Add(this.rdoChuaGiao);
            this.groupLoc.Controls.Add(this.rdoChuaNhan);
            this.groupLoc.Controls.Add(this.rdoTatCa);
            this.groupLoc.Controls.Add(this.simpleButton1);
            this.groupLoc.Location = new System.Drawing.Point(0, 92);
            this.groupLoc.Name = "groupLoc";
            this.groupLoc.Size = new System.Drawing.Size(389, 93);
            this.groupLoc.TabIndex = 7;
            this.groupLoc.Text = "Lọc Danh Sách";
            // 
            // rdoThatBai
            // 
            this.rdoThatBai.AutoSize = true;
            this.rdoThatBai.Location = new System.Drawing.Point(287, 27);
            this.rdoThatBai.Name = "rdoThatBai";
            this.rdoThatBai.Size = new System.Drawing.Size(100, 21);
            this.rdoThatBai.TabIndex = 7;
            this.rdoThatBai.TabStop = true;
            this.rdoThatBai.Text = "Giao thất bại";
            this.rdoThatBai.UseVisualStyleBackColor = true;
            this.rdoThatBai.CheckedChanged += new System.EventHandler(this.rdoChuaNhan_CheckedChanged);
            // 
            // rdoDaGiao
            // 
            this.rdoDaGiao.AutoSize = true;
            this.rdoDaGiao.Location = new System.Drawing.Point(144, 54);
            this.rdoDaGiao.Name = "rdoDaGiao";
            this.rdoDaGiao.Size = new System.Drawing.Size(72, 21);
            this.rdoDaGiao.TabIndex = 6;
            this.rdoDaGiao.TabStop = true;
            this.rdoDaGiao.Text = "Đã giao";
            this.rdoDaGiao.UseVisualStyleBackColor = true;
            this.rdoDaGiao.CheckedChanged += new System.EventHandler(this.rdoChuaNhan_CheckedChanged);
            // 
            // rdoChuaGiao
            // 
            this.rdoChuaGiao.AutoSize = true;
            this.rdoChuaGiao.Location = new System.Drawing.Point(23, 54);
            this.rdoChuaGiao.Name = "rdoChuaGiao";
            this.rdoChuaGiao.Size = new System.Drawing.Size(86, 21);
            this.rdoChuaGiao.TabIndex = 5;
            this.rdoChuaGiao.TabStop = true;
            this.rdoChuaGiao.Text = "Chưa giao";
            this.rdoChuaGiao.UseVisualStyleBackColor = true;
            this.rdoChuaGiao.CheckedChanged += new System.EventHandler(this.rdoChuaNhan_CheckedChanged);
            // 
            // rdoChuaNhan
            // 
            this.rdoChuaNhan.AutoSize = true;
            this.rdoChuaNhan.Location = new System.Drawing.Point(144, 27);
            this.rdoChuaNhan.Name = "rdoChuaNhan";
            this.rdoChuaNhan.Size = new System.Drawing.Size(125, 21);
            this.rdoChuaNhan.TabIndex = 4;
            this.rdoChuaNhan.TabStop = true;
            this.rdoChuaNhan.Text = "Chưa được nhận";
            this.rdoChuaNhan.UseVisualStyleBackColor = true;
            this.rdoChuaNhan.CheckedChanged += new System.EventHandler(this.rdoChuaNhan_CheckedChanged);
            // 
            // rdoTatCa
            // 
            this.rdoTatCa.AutoSize = true;
            this.rdoTatCa.Location = new System.Drawing.Point(23, 27);
            this.rdoTatCa.Name = "rdoTatCa";
            this.rdoTatCa.Size = new System.Drawing.Size(64, 21);
            this.rdoTatCa.TabIndex = 3;
            this.rdoTatCa.TabStop = true;
            this.rdoTatCa.Text = "Tất cả";
            this.rdoTatCa.UseVisualStyleBackColor = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(284, 290);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(104, 268);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // UC_Giaohang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridDSDonHang);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label1);
            this.Name = "UC_Giaohang";
            this.Size = new System.Drawing.Size(1350, 548);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTKMAHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTinhTrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupLoc)).EndInit();
            this.groupLoc.ResumeLayout(false);
            this.groupLoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn TINHTRANGTHANHTOAN;
        private DevExpress.XtraGrid.Columns.GridColumn PHIKC;
        private DevExpress.XtraGrid.Columns.GridColumn KHOANGCACH;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHIGIAO;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYDAT;
        private DevExpress.XtraGrid.Columns.GridColumn MAKHUYENMAI;
        private DevExpress.XtraGrid.Columns.GridColumn MAHINHTHUC;
        private DevExpress.XtraGrid.Columns.GridColumn MAKH;
        private DevExpress.XtraGrid.Columns.GridColumn MAHD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn THANHTIEN;
        private DevExpress.XtraGrid.GridControl gridDSDonHang;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTKMAHD;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupLoc;
        private System.Windows.Forms.RadioButton rdoThatBai;
        private System.Windows.Forms.RadioButton rdoDaGiao;
        private System.Windows.Forms.RadioButton rdoChuaGiao;
        private System.Windows.Forms.RadioButton rdoChuaNhan;
        private System.Windows.Forms.RadioButton rdoTatCa;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtTongTien;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtTinhTrang;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTenKhach;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMAHD;
        private System.Windows.Forms.ComboBox cboTenNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraEditors.SimpleButton btnSua;
    }
}
