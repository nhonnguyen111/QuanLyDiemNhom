namespace QuanLyDiemNhom
{
    partial class DSNhanSu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSNhanSu));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnthem = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnsua = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnxoa = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnxuatexcel = new DevExpress.XtraBars.BarLargeButtonItem();
            this.lbsoluong = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dtgvNhanSu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtgvquyen = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhuVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btncapnhat = new DevExpress.XtraBars.BarLargeButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvquyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnthem,
            this.btnsua,
            this.btnxoa,
            this.btnxuatexcel,
            this.lbsoluong,
            this.btncapnhat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnthem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnsua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnxoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnxuatexcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.lbsoluong),
            new DevExpress.XtraBars.LinkPersistInfo(this.btncapnhat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnthem
            // 
            this.btnthem.Caption = "Thêm";
            this.btnthem.Id = 0;
            this.btnthem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.LargeImage")));
            this.btnthem.Name = "btnthem";
            this.btnthem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnthem_ItemClick);
            // 
            // btnsua
            // 
            this.btnsua.Caption = "Sửa";
            this.btnsua.Id = 1;
            this.btnsua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnsua.ImageOptions.LargeImage")));
            this.btnsua.Name = "btnsua";
            this.btnsua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsua_ItemClick);
            // 
            // btnxoa
            // 
            this.btnxoa.Caption = "Xóa";
            this.btnxoa.Id = 2;
            this.btnxoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.LargeImage")));
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxoa_ItemClick);
            // 
            // btnxuatexcel
            // 
            this.btnxuatexcel.Caption = "Xuất Excel";
            this.btnxuatexcel.Id = 3;
            this.btnxuatexcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnxuatexcel.ImageOptions.LargeImage")));
            this.btnxuatexcel.Name = "btnxuatexcel";
            this.btnxuatexcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxuatexcel_ItemClick);
            // 
            // lbsoluong
            // 
            this.lbsoluong.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lbsoluong.Caption = "Số lượng nhân sự :";
            this.lbsoluong.Id = 4;
            this.lbsoluong.Name = "lbsoluong";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(950, 69);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 557);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(950, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 69);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 488);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(950, 69);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 488);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dtgvNhanSu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 69);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(950, 488);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dtgvNhanSu
            // 
            this.dtgvNhanSu.Location = new System.Drawing.Point(12, 12);
            this.dtgvNhanSu.MainView = this.gridView1;
            this.dtgvNhanSu.MenuManager = this.barManager1;
            this.dtgvNhanSu.Name = "dtgvNhanSu";
            this.dtgvNhanSu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dtgvquyen});
            this.dtgvNhanSu.Size = new System.Drawing.Size(926, 464);
            this.dtgvNhanSu.TabIndex = 8;
            this.dtgvNhanSu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdUser,
            this.TaiKhoan,
            this.HoTen,
            this.Email,
            this.SoDienThoai,
            this.GioiTinh,
            this.IdQuyen,
            this.DiaChi,
            this.KhuVuc});
            this.gridView1.GridControl = this.dtgvNhanSu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // IdUser
            // 
            this.IdUser.AppearanceCell.Options.UseTextOptions = true;
            this.IdUser.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdUser.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.IdUser.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdUser.AppearanceHeader.Options.UseFont = true;
            this.IdUser.AppearanceHeader.Options.UseTextOptions = true;
            this.IdUser.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdUser.Caption = "Mã nhân sự";
            this.IdUser.FieldName = "IdUser";
            this.IdUser.MinWidth = 25;
            this.IdUser.Name = "IdUser";
            this.IdUser.OptionsColumn.ReadOnly = true;
            this.IdUser.Visible = true;
            this.IdUser.VisibleIndex = 0;
            this.IdUser.Width = 93;
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.AppearanceCell.Options.UseTextOptions = true;
            this.TaiKhoan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TaiKhoan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TaiKhoan.AppearanceHeader.Options.UseFont = true;
            this.TaiKhoan.AppearanceHeader.Options.UseTextOptions = true;
            this.TaiKhoan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TaiKhoan.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TaiKhoan.Caption = "Tên đăng nhập";
            this.TaiKhoan.FieldName = "TaiKhoan";
            this.TaiKhoan.MinWidth = 25;
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.OptionsColumn.ReadOnly = true;
            this.TaiKhoan.Visible = true;
            this.TaiKhoan.VisibleIndex = 1;
            this.TaiKhoan.Width = 94;
            // 
            // HoTen
            // 
            this.HoTen.AppearanceCell.Options.UseTextOptions = true;
            this.HoTen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HoTen.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.HoTen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.HoTen.AppearanceHeader.Options.UseFont = true;
            this.HoTen.AppearanceHeader.Options.UseTextOptions = true;
            this.HoTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HoTen.Caption = "Họ và tên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.MinWidth = 25;
            this.HoTen.Name = "HoTen";
            this.HoTen.OptionsColumn.ReadOnly = true;
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 2;
            this.HoTen.Width = 69;
            // 
            // Email
            // 
            this.Email.AppearanceCell.Options.UseTextOptions = true;
            this.Email.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Email.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Email.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.Email.AppearanceHeader.Options.UseFont = true;
            this.Email.AppearanceHeader.Options.UseTextOptions = true;
            this.Email.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.MinWidth = 25;
            this.Email.Name = "Email";
            this.Email.OptionsColumn.ReadOnly = true;
            this.Email.Visible = true;
            this.Email.VisibleIndex = 3;
            this.Email.Width = 69;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.AppearanceCell.Options.UseTextOptions = true;
            this.SoDienThoai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoDienThoai.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SoDienThoai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.SoDienThoai.AppearanceHeader.Options.UseFont = true;
            this.SoDienThoai.AppearanceHeader.Options.UseTextOptions = true;
            this.SoDienThoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoDienThoai.Caption = "Số điện thoại";
            this.SoDienThoai.FieldName = "SoDienThoai";
            this.SoDienThoai.MinWidth = 25;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.OptionsColumn.ReadOnly = true;
            this.SoDienThoai.Visible = true;
            this.SoDienThoai.VisibleIndex = 4;
            this.SoDienThoai.Width = 82;
            // 
            // GioiTinh
            // 
            this.GioiTinh.AppearanceCell.Options.UseTextOptions = true;
            this.GioiTinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GioiTinh.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GioiTinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.GioiTinh.AppearanceHeader.Options.UseFont = true;
            this.GioiTinh.AppearanceHeader.Options.UseTextOptions = true;
            this.GioiTinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GioiTinh.Caption = "Giới tính";
            this.GioiTinh.FieldName = "GioiTinh";
            this.GioiTinh.MinWidth = 25;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.OptionsColumn.ReadOnly = true;
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 8;
            this.GioiTinh.Width = 72;
            // 
            // IdQuyen
            // 
            this.IdQuyen.AppearanceCell.Options.UseTextOptions = true;
            this.IdQuyen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdQuyen.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdQuyen.AppearanceHeader.Options.UseFont = true;
            this.IdQuyen.AppearanceHeader.Options.UseTextOptions = true;
            this.IdQuyen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdQuyen.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.IdQuyen.Caption = "Quyền";
            this.IdQuyen.ColumnEdit = this.dtgvquyen;
            this.IdQuyen.FieldName = "IdQuyen";
            this.IdQuyen.MinWidth = 25;
            this.IdQuyen.Name = "IdQuyen";
            this.IdQuyen.OptionsColumn.ReadOnly = true;
            this.IdQuyen.Visible = true;
            this.IdQuyen.VisibleIndex = 7;
            this.IdQuyen.Width = 55;
            // 
            // dtgvquyen
            // 
            this.dtgvquyen.AutoHeight = false;
            this.dtgvquyen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtgvquyen.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdQuyen", "IdQuyen"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenQuyen", "Quyền")});
            this.dtgvquyen.Name = "dtgvquyen";
            // 
            // DiaChi
            // 
            this.DiaChi.AppearanceCell.Options.UseTextOptions = true;
            this.DiaChi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DiaChi.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DiaChi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.DiaChi.AppearanceHeader.Options.UseFont = true;
            this.DiaChi.AppearanceHeader.Options.UseTextOptions = true;
            this.DiaChi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.MinWidth = 25;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.OptionsColumn.ReadOnly = true;
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 5;
            this.DiaChi.Width = 66;
            // 
            // KhuVuc
            // 
            this.KhuVuc.AppearanceCell.Options.UseTextOptions = true;
            this.KhuVuc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.KhuVuc.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.KhuVuc.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.KhuVuc.AppearanceHeader.Options.UseFont = true;
            this.KhuVuc.AppearanceHeader.Options.UseTextOptions = true;
            this.KhuVuc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.KhuVuc.Caption = "Khu vực";
            this.KhuVuc.FieldName = "KhuVuc";
            this.KhuVuc.MinWidth = 25;
            this.KhuVuc.Name = "KhuVuc";
            this.KhuVuc.OptionsColumn.ReadOnly = true;
            this.KhuVuc.Visible = true;
            this.KhuVuc.VisibleIndex = 6;
            this.KhuVuc.Width = 74;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(950, 488);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dtgvNhanSu;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(930, 468);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // btncapnhat
            // 
            this.btncapnhat.Caption = "Cập nhật";
            this.btncapnhat.Id = 5;
            this.btncapnhat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem1.ImageOptions.LargeImage")));
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncapnhat_ItemClick);
            // 
            // DSNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 557);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DSNhanSu";
            this.Text = "Danh sách nhân sự";
            this.Load += new System.EventHandler(this.DSNhanSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvquyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem btnthem;
        private DevExpress.XtraBars.BarLargeButtonItem btnsua;
        private DevExpress.XtraBars.BarLargeButtonItem btnxoa;
        private DevExpress.XtraBars.BarLargeButtonItem btnxuatexcel;
        private DevExpress.XtraBars.BarStaticItem lbsoluong;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl dtgvNhanSu;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IdUser;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn SoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn KhuVuc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn IdQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn TaiKhoan;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit dtgvquyen;
        private DevExpress.XtraBars.BarLargeButtonItem btncapnhat;
    }
}