namespace QuanLyDiemNhom
{
    partial class DSChungChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSChungChi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnxuatchungchi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnxoa = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btntimkiem = new DevExpress.XtraEditors.SimpleButton();
            this.dtgvchungchi = new DevExpress.XtraGrid.GridControl();
            this.gvmaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChungChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenChungChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvthanhvien = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.IdKhoaHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvkhoahoc = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.NgayHoanThanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvsoquy = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gvloaichi = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gvdetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChiTietBanNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdThanhVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayThamGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdBanNgan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txttimkiem = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btncapnhat = new DevExpress.XtraBars.BarLargeButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvchungchi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvmaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvthanhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvkhoahoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvsoquy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvloaichi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttimkiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
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
            this.btnxuatchungchi,
            this.btnxoa,
            this.btncapnhat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnxuatchungchi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnxoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btncapnhat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnxuatchungchi
            // 
            this.btnxuatchungchi.Caption = "In chứng chỉ";
            this.btnxuatchungchi.Id = 0;
            this.btnxuatchungchi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnxuatchungchi.ImageOptions.LargeImage")));
            this.btnxuatchungchi.Name = "btnxuatchungchi";
            this.btnxuatchungchi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxuatchungchi_ItemClick);
            // 
            // btnxoa
            // 
            this.btnxoa.Caption = "Xóa chứng chỉ";
            this.btnxoa.Id = 1;
            this.btnxoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.LargeImage")));
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxoa_ItemClick);
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
            this.layoutControl1.Controls.Add(this.btntimkiem);
            this.layoutControl1.Controls.Add(this.dtgvchungchi);
            this.layoutControl1.Controls.Add(this.txttimkiem);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 69);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(950, 488);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(24, 437);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(142, 27);
            this.btntimkiem.StyleController = this.layoutControl1;
            this.btntimkiem.TabIndex = 16;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // dtgvchungchi
            // 
            this.dtgvchungchi.Location = new System.Drawing.Point(182, 12);
            this.dtgvchungchi.MainView = this.gvmaster;
            this.dtgvchungchi.MenuManager = this.barManager1;
            this.dtgvchungchi.Name = "dtgvchungchi";
            this.dtgvchungchi.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gvsoquy,
            this.gvloaichi,
            this.gvthanhvien,
            this.gvkhoahoc});
            this.dtgvchungchi.Size = new System.Drawing.Size(756, 464);
            this.dtgvchungchi.TabIndex = 13;
            this.dtgvchungchi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvmaster,
            this.gvdetail});
            // 
            // gvmaster
            // 
            this.gvmaster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChungChi,
            this.TenChungChi,
            this.NoiDung,
            this.NgayKetThuc,
            this.IdKhoaHoc,
            this.NgayHoanThanh});
            this.gvmaster.GridControl = this.dtgvchungchi;
            this.gvmaster.Name = "gvmaster";
            this.gvmaster.OptionsView.ShowGroupPanel = false;
            // 
            // IdChungChi
            // 
            this.IdChungChi.AppearanceCell.Options.UseTextOptions = true;
            this.IdChungChi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdChungChi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdChungChi.AppearanceHeader.Options.UseFont = true;
            this.IdChungChi.AppearanceHeader.Options.UseTextOptions = true;
            this.IdChungChi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdChungChi.Caption = "Mã chứng chỉ";
            this.IdChungChi.FieldName = "IdChungChi";
            this.IdChungChi.MinWidth = 25;
            this.IdChungChi.Name = "IdChungChi";
            this.IdChungChi.OptionsColumn.ReadOnly = true;
            this.IdChungChi.Visible = true;
            this.IdChungChi.VisibleIndex = 0;
            this.IdChungChi.Width = 94;
            // 
            // TenChungChi
            // 
            this.TenChungChi.AppearanceCell.Options.UseTextOptions = true;
            this.TenChungChi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenChungChi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TenChungChi.AppearanceHeader.Options.UseFont = true;
            this.TenChungChi.AppearanceHeader.Options.UseTextOptions = true;
            this.TenChungChi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenChungChi.Caption = "Tên chứng chỉ";
            this.TenChungChi.FieldName = "TenChungChi";
            this.TenChungChi.MinWidth = 25;
            this.TenChungChi.Name = "TenChungChi";
            this.TenChungChi.OptionsColumn.ReadOnly = true;
            this.TenChungChi.Visible = true;
            this.TenChungChi.VisibleIndex = 1;
            this.TenChungChi.Width = 94;
            // 
            // NoiDung
            // 
            this.NoiDung.AppearanceCell.Options.UseTextOptions = true;
            this.NoiDung.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NoiDung.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NoiDung.AppearanceHeader.Options.UseFont = true;
            this.NoiDung.AppearanceHeader.Options.UseTextOptions = true;
            this.NoiDung.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NoiDung.Caption = "Nội dung";
            this.NoiDung.FieldName = "NoiDung";
            this.NoiDung.MinWidth = 25;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.OptionsColumn.ReadOnly = true;
            this.NoiDung.Visible = true;
            this.NoiDung.VisibleIndex = 2;
            this.NoiDung.Width = 94;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.AppearanceCell.Options.UseTextOptions = true;
            this.NgayKetThuc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayKetThuc.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NgayKetThuc.AppearanceHeader.Options.UseFont = true;
            this.NgayKetThuc.AppearanceHeader.Options.UseTextOptions = true;
            this.NgayKetThuc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayKetThuc.Caption = "Người nhận";
            this.NgayKetThuc.ColumnEdit = this.gvthanhvien;
            this.NgayKetThuc.FieldName = "IdThanhVien";
            this.NgayKetThuc.MinWidth = 25;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.OptionsColumn.ReadOnly = true;
            this.NgayKetThuc.Visible = true;
            this.NgayKetThuc.VisibleIndex = 3;
            this.NgayKetThuc.Width = 94;
            // 
            // gvthanhvien
            // 
            this.gvthanhvien.AutoHeight = false;
            this.gvthanhvien.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvthanhvien.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdThanhVien", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HoTen", "Tên tín hữu")});
            this.gvthanhvien.Name = "gvthanhvien";
            // 
            // IdKhoaHoc
            // 
            this.IdKhoaHoc.AppearanceCell.Options.UseTextOptions = true;
            this.IdKhoaHoc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdKhoaHoc.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdKhoaHoc.AppearanceHeader.Options.UseFont = true;
            this.IdKhoaHoc.AppearanceHeader.Options.UseTextOptions = true;
            this.IdKhoaHoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdKhoaHoc.Caption = "Thuộc khóa học";
            this.IdKhoaHoc.ColumnEdit = this.gvkhoahoc;
            this.IdKhoaHoc.FieldName = "IdKhoaHoc";
            this.IdKhoaHoc.MinWidth = 25;
            this.IdKhoaHoc.Name = "IdKhoaHoc";
            this.IdKhoaHoc.OptionsColumn.ReadOnly = true;
            this.IdKhoaHoc.Visible = true;
            this.IdKhoaHoc.VisibleIndex = 4;
            this.IdKhoaHoc.Width = 94;
            // 
            // gvkhoahoc
            // 
            this.gvkhoahoc.AutoHeight = false;
            this.gvkhoahoc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvkhoahoc.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdKhoaHoc", "STT"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKhoaHoc", "Tên khóa học")});
            this.gvkhoahoc.Name = "gvkhoahoc";
            // 
            // NgayHoanThanh
            // 
            this.NgayHoanThanh.AppearanceCell.Options.UseTextOptions = true;
            this.NgayHoanThanh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayHoanThanh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NgayHoanThanh.AppearanceHeader.Options.UseFont = true;
            this.NgayHoanThanh.AppearanceHeader.Options.UseTextOptions = true;
            this.NgayHoanThanh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayHoanThanh.Caption = "Ngày hoàn thành";
            this.NgayHoanThanh.FieldName = "NgayHoanThanh";
            this.NgayHoanThanh.MinWidth = 25;
            this.NgayHoanThanh.Name = "NgayHoanThanh";
            this.NgayHoanThanh.Visible = true;
            this.NgayHoanThanh.VisibleIndex = 5;
            this.NgayHoanThanh.Width = 94;
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
            this.gvdetail.GridControl = this.dtgvchungchi;
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
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(24, 52);
            this.txttimkiem.MenuManager = this.barManager1;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(142, 22);
            this.txttimkiem.StyleController = this.layoutControl1;
            this.txttimkiem.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(950, 488);
            this.Root.TextVisible = false;
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup1;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(170, 468);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(146, 416);
            this.layoutControlGroup1.Text = "Tìm kiếm";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txttimkiem;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(146, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btntimkiem;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 385);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(146, 31);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 26);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(146, 359);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dtgvchungchi;
            this.layoutControlItem2.Location = new System.Drawing.Point(170, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(760, 468);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // btncapnhat
            // 
            this.btncapnhat.Caption = "Cập nhật";
            this.btncapnhat.Id = 2;
            this.btncapnhat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem1.ImageOptions.LargeImage")));
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncapnhat_ItemClick);
            // 
            // DSChungChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 557);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DSChungChi";
            this.Text = "Danh sách các chứng chỉ của tín hữu";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvchungchi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvmaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvthanhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvkhoahoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvsoquy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvloaichi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttimkiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
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
        private DevExpress.XtraBars.BarLargeButtonItem btnxuatchungchi;
        private DevExpress.XtraBars.BarLargeButtonItem btnxoa;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txttimkiem;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btntimkiem;
        private DevExpress.XtraGrid.GridControl dtgvchungchi;
        public DevExpress.XtraGrid.Views.Grid.GridView gvmaster;
        private DevExpress.XtraGrid.Columns.GridColumn IdChungChi;
        private DevExpress.XtraGrid.Columns.GridColumn TenChungChi;
        private DevExpress.XtraGrid.Columns.GridColumn NoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn NgayKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn IdKhoaHoc;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvsoquy;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvloaichi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdetail;
        private DevExpress.XtraGrid.Columns.GridColumn IdChiTietBanNganh;
        private DevExpress.XtraGrid.Columns.GridColumn IdThanhVien;
        private DevExpress.XtraGrid.Columns.GridColumn ChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn NgayThamGia;
        private DevExpress.XtraGrid.Columns.GridColumn IdBanNgan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvthanhvien;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvkhoahoc;
        private DevExpress.XtraGrid.Columns.GridColumn NgayHoanThanh;
        private DevExpress.XtraBars.BarLargeButtonItem btncapnhat;
    }
}