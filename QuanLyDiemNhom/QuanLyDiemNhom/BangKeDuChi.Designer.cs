namespace QuanLyDiemNhom
{
    partial class BangKeDuChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangKeDuChi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnthem = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnxeduchi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnxoa = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnxuat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dtgvduchi = new DevExpress.XtraGrid.GridControl();
            this.gvmaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdKeHoach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKeHoach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuanLy1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuanLy2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongChiPhi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvsoquy = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gvloaichi = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gvdetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChiTietBanNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdThanhVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayThamGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdBanNgan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btncapnhat = new DevExpress.XtraBars.BarLargeButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvduchi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvmaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvsoquy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvloaichi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
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
            this.btnxeduchi,
            this.btnxoa,
            this.btnxuat,
            this.btncapnhat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnthem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnxeduchi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnxoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnxuat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btncapnhat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnthem
            // 
            this.btnthem.Caption = "Tạo dự chi";
            this.btnthem.Id = 0;
            this.btnthem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.LargeImage")));
            this.btnthem.Name = "btnthem";
            this.btnthem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnthem_ItemClick);
            // 
            // btnxeduchi
            // 
            this.btnxeduchi.Caption = "Xem dự chi";
            this.btnxeduchi.Id = 1;
            this.btnxeduchi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnxeduchi.ImageOptions.LargeImage")));
            this.btnxeduchi.Name = "btnxeduchi";
            this.btnxeduchi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxeduchi_ItemClick);
            // 
            // btnxoa
            // 
            this.btnxoa.Caption = "Xóa dự chi";
            this.btnxoa.Id = 2;
            this.btnxoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.LargeImage")));
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxoa_ItemClick);
            // 
            // btnxuat
            // 
            this.btnxuat.Caption = "Xuất Excel";
            this.btnxuat.Id = 3;
            this.btnxuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnxuat.ImageOptions.LargeImage")));
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxuat_ItemClick);
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
            this.layoutControl1.Controls.Add(this.dtgvduchi);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 69);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(950, 488);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dtgvduchi
            // 
            this.dtgvduchi.Location = new System.Drawing.Point(12, 12);
            this.dtgvduchi.MainView = this.gvmaster;
            this.dtgvduchi.MenuManager = this.barManager1;
            this.dtgvduchi.Name = "dtgvduchi";
            this.dtgvduchi.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gvsoquy,
            this.gvloaichi});
            this.dtgvduchi.Size = new System.Drawing.Size(926, 464);
            this.dtgvduchi.TabIndex = 12;
            this.dtgvduchi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvmaster,
            this.gvdetail});
            // 
            // gvmaster
            // 
            this.gvmaster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdKeHoach,
            this.TenKeHoach,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.QuanLy1,
            this.QuanLy2,
            this.TongChiPhi,
            this.MoTa});
            this.gvmaster.GridControl = this.dtgvduchi;
            this.gvmaster.Name = "gvmaster";
            this.gvmaster.OptionsView.ShowGroupPanel = false;
            // 
            // IdKeHoach
            // 
            this.IdKeHoach.AppearanceCell.Options.UseTextOptions = true;
            this.IdKeHoach.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdKeHoach.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdKeHoach.AppearanceHeader.Options.UseFont = true;
            this.IdKeHoach.AppearanceHeader.Options.UseTextOptions = true;
            this.IdKeHoach.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdKeHoach.Caption = "Mã kế hoạch";
            this.IdKeHoach.FieldName = "IdKeHoach";
            this.IdKeHoach.MinWidth = 25;
            this.IdKeHoach.Name = "IdKeHoach";
            this.IdKeHoach.OptionsColumn.ReadOnly = true;
            this.IdKeHoach.Visible = true;
            this.IdKeHoach.VisibleIndex = 0;
            this.IdKeHoach.Width = 94;
            // 
            // TenKeHoach
            // 
            this.TenKeHoach.AppearanceCell.Options.UseTextOptions = true;
            this.TenKeHoach.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenKeHoach.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TenKeHoach.AppearanceHeader.Options.UseFont = true;
            this.TenKeHoach.AppearanceHeader.Options.UseTextOptions = true;
            this.TenKeHoach.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenKeHoach.Caption = "Tên kế hoạch";
            this.TenKeHoach.FieldName = "TenKeHoach";
            this.TenKeHoach.MinWidth = 25;
            this.TenKeHoach.Name = "TenKeHoach";
            this.TenKeHoach.OptionsColumn.ReadOnly = true;
            this.TenKeHoach.Visible = true;
            this.TenKeHoach.VisibleIndex = 1;
            this.TenKeHoach.Width = 94;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.AppearanceCell.Options.UseTextOptions = true;
            this.NgayBatDau.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayBatDau.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NgayBatDau.AppearanceHeader.Options.UseFont = true;
            this.NgayBatDau.AppearanceHeader.Options.UseTextOptions = true;
            this.NgayBatDau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayBatDau.Caption = "Từ ngày";
            this.NgayBatDau.FieldName = "NgayBatDau";
            this.NgayBatDau.MinWidth = 25;
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.OptionsColumn.ReadOnly = true;
            this.NgayBatDau.Visible = true;
            this.NgayBatDau.VisibleIndex = 2;
            this.NgayBatDau.Width = 94;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.AppearanceCell.Options.UseTextOptions = true;
            this.NgayKetThuc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayKetThuc.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NgayKetThuc.AppearanceHeader.Options.UseFont = true;
            this.NgayKetThuc.AppearanceHeader.Options.UseTextOptions = true;
            this.NgayKetThuc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayKetThuc.Caption = "Đến ngày";
            this.NgayKetThuc.FieldName = "NgayKetThuc";
            this.NgayKetThuc.MinWidth = 25;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.OptionsColumn.ReadOnly = true;
            this.NgayKetThuc.Visible = true;
            this.NgayKetThuc.VisibleIndex = 3;
            this.NgayKetThuc.Width = 94;
            // 
            // QuanLy1
            // 
            this.QuanLy1.AppearanceCell.Options.UseTextOptions = true;
            this.QuanLy1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QuanLy1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.QuanLy1.AppearanceHeader.Options.UseFont = true;
            this.QuanLy1.AppearanceHeader.Options.UseTextOptions = true;
            this.QuanLy1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QuanLy1.Caption = "Quản lý 1";
            this.QuanLy1.FieldName = "QuanLy1";
            this.QuanLy1.MinWidth = 25;
            this.QuanLy1.Name = "QuanLy1";
            this.QuanLy1.OptionsColumn.ReadOnly = true;
            this.QuanLy1.Visible = true;
            this.QuanLy1.VisibleIndex = 4;
            this.QuanLy1.Width = 94;
            // 
            // QuanLy2
            // 
            this.QuanLy2.AppearanceCell.Options.UseTextOptions = true;
            this.QuanLy2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QuanLy2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.QuanLy2.AppearanceHeader.Options.UseFont = true;
            this.QuanLy2.AppearanceHeader.Options.UseTextOptions = true;
            this.QuanLy2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.QuanLy2.Caption = "Quản lý 2";
            this.QuanLy2.FieldName = "QuanLy2";
            this.QuanLy2.MinWidth = 25;
            this.QuanLy2.Name = "QuanLy2";
            this.QuanLy2.OptionsColumn.ReadOnly = true;
            this.QuanLy2.Visible = true;
            this.QuanLy2.VisibleIndex = 5;
            this.QuanLy2.Width = 94;
            // 
            // TongChiPhi
            // 
            this.TongChiPhi.AppearanceCell.Options.UseTextOptions = true;
            this.TongChiPhi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TongChiPhi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TongChiPhi.AppearanceHeader.Options.UseFont = true;
            this.TongChiPhi.AppearanceHeader.Options.UseTextOptions = true;
            this.TongChiPhi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TongChiPhi.Caption = "Tổng chi phí";
            this.TongChiPhi.FieldName = "TongChiPhi";
            this.TongChiPhi.MinWidth = 25;
            this.TongChiPhi.Name = "TongChiPhi";
            this.TongChiPhi.OptionsColumn.ReadOnly = true;
            this.TongChiPhi.Visible = true;
            this.TongChiPhi.VisibleIndex = 6;
            this.TongChiPhi.Width = 94;
            // 
            // MoTa
            // 
            this.MoTa.AppearanceCell.Options.UseTextOptions = true;
            this.MoTa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MoTa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.MoTa.AppearanceHeader.Options.UseFont = true;
            this.MoTa.AppearanceHeader.Options.UseTextOptions = true;
            this.MoTa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MoTa.Caption = "Mô tả";
            this.MoTa.FieldName = "MoTa";
            this.MoTa.MinWidth = 25;
            this.MoTa.Name = "MoTa";
            this.MoTa.OptionsColumn.ReadOnly = true;
            this.MoTa.Visible = true;
            this.MoTa.VisibleIndex = 7;
            this.MoTa.Width = 94;
            // 
            // gvsoquy
            // 
            this.gvsoquy.AutoHeight = false;
            this.gvsoquy.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvsoquy.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdSoQuy", "Mã sổ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenSo", "Tên quỹ")});
            this.gvsoquy.Name = "gvsoquy";
            // 
            // gvloaichi
            // 
            this.gvloaichi.AutoHeight = false;
            this.gvloaichi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvloaichi.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdLoaiChi", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenLoaiChi", "Tên loại chi")});
            this.gvloaichi.Name = "gvloaichi";
            // 
            // gvdetail
            // 
            this.gvdetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChiTietBanNganh,
            this.IdThanhVien,
            this.ChucVu,
            this.NgayThamGia,
            this.IdBanNgan});
            this.gvdetail.GridControl = this.dtgvduchi;
            this.gvdetail.Name = "gvdetail";
            // 
            // IdChiTietBanNganh
            // 
            this.IdChiTietBanNganh.Caption = "Số thứ tự";
            this.IdChiTietBanNganh.FieldName = "IdChiTietBanNganh";
            this.IdChiTietBanNganh.MinWidth = 25;
            this.IdChiTietBanNganh.Name = "IdChiTietBanNganh";
            this.IdChiTietBanNganh.Visible = true;
            this.IdChiTietBanNganh.VisibleIndex = 0;
            this.IdChiTietBanNganh.Width = 94;
            // 
            // IdThanhVien
            // 
            this.IdThanhVien.Caption = "Họ và tên";
            this.IdThanhVien.FieldName = "IdThanhVien";
            this.IdThanhVien.MinWidth = 25;
            this.IdThanhVien.Name = "IdThanhVien";
            this.IdThanhVien.Visible = true;
            this.IdThanhVien.VisibleIndex = 1;
            this.IdThanhVien.Width = 94;
            // 
            // ChucVu
            // 
            this.ChucVu.Caption = "Chức vụ";
            this.ChucVu.FieldName = "ChucVu";
            this.ChucVu.MinWidth = 25;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Visible = true;
            this.ChucVu.VisibleIndex = 2;
            this.ChucVu.Width = 94;
            // 
            // NgayThamGia
            // 
            this.NgayThamGia.Caption = "Ngày tham giá";
            this.NgayThamGia.FieldName = "NgayThamGia";
            this.NgayThamGia.MinWidth = 25;
            this.NgayThamGia.Name = "NgayThamGia";
            this.NgayThamGia.Visible = true;
            this.NgayThamGia.VisibleIndex = 3;
            this.NgayThamGia.Width = 94;
            // 
            // IdBanNgan
            // 
            this.IdBanNgan.Caption = "Ban ngành";
            this.IdBanNgan.FieldName = "IdBanNganh";
            this.IdBanNgan.MinWidth = 25;
            this.IdBanNgan.Name = "IdBanNgan";
            this.IdBanNgan.Visible = true;
            this.IdBanNgan.VisibleIndex = 4;
            this.IdBanNgan.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(950, 488);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dtgvduchi;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(930, 468);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // btncapnhat
            // 
            this.btncapnhat.Caption = "Cập nhật";
            this.btncapnhat.Id = 4;
            this.btncapnhat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem1.ImageOptions.LargeImage")));
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncapnhat_ItemClick);
            // 
            // BangKeDuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 557);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "BangKeDuChi";
            this.Text = "Bảng kê dự chi";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvduchi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvmaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvsoquy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvloaichi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarLargeButtonItem btnthem;
        private DevExpress.XtraBars.BarLargeButtonItem btnxeduchi;
        private DevExpress.XtraBars.BarLargeButtonItem btnxoa;
        private DevExpress.XtraBars.BarLargeButtonItem btnxuat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl dtgvduchi;
        public DevExpress.XtraGrid.Views.Grid.GridView gvmaster;
        private DevExpress.XtraGrid.Columns.GridColumn IdKeHoach;
        private DevExpress.XtraGrid.Columns.GridColumn TenKeHoach;
        private DevExpress.XtraGrid.Columns.GridColumn NgayBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn NgayKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn QuanLy1;
        private DevExpress.XtraGrid.Columns.GridColumn QuanLy2;
        private DevExpress.XtraGrid.Columns.GridColumn TongChiPhi;
        private DevExpress.XtraGrid.Columns.GridColumn MoTa;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvsoquy;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvloaichi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdetail;
        private DevExpress.XtraGrid.Columns.GridColumn IdChiTietBanNganh;
        private DevExpress.XtraGrid.Columns.GridColumn IdThanhVien;
        private DevExpress.XtraGrid.Columns.GridColumn ChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn NgayThamGia;
        private DevExpress.XtraGrid.Columns.GridColumn IdBanNgan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarLargeButtonItem btncapnhat;
    }
}