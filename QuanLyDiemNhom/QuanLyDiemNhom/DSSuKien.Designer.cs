namespace QuanLyDiemNhom
{
    partial class DSSuKien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSSuKien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnthem = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnsua = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnxoa = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnxuat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barLinkContainerItem1 = new DevExpress.XtraBars.BarLinkContainerItem();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dtgvsukien = new DevExpress.XtraGrid.GridControl();
            this.gvmaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdSuKien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSuKien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayDienRa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdBanNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvbannganh = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.GioDienRa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ViTriDienRa = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.barLargeButtonItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvsukien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvmaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvbannganh)).BeginInit();
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
            this.barLinkContainerItem1,
            this.barLargeButtonItem1,
            this.btnthem,
            this.btnsua,
            this.btnxoa,
            this.btnxuat,
            this.barLargeButtonItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnxuat),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem2)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnthem
            // 
            this.btnthem.Caption = "Thêm sự kiện";
            this.btnthem.Id = 2;
            this.btnthem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.LargeImage")));
            this.btnthem.Name = "btnthem";
            this.btnthem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnthem_ItemClick);
            // 
            // btnsua
            // 
            this.btnsua.Caption = "Sửa sự kiện";
            this.btnsua.Id = 3;
            this.btnsua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnsua.ImageOptions.LargeImage")));
            this.btnsua.Name = "btnsua";
            this.btnsua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsua_ItemClick);
            // 
            // btnxoa
            // 
            this.btnxoa.Caption = "Xóa sự kiện";
            this.btnxoa.Id = 4;
            this.btnxoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.LargeImage")));
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxoa_ItemClick);
            // 
            // btnxuat
            // 
            this.btnxuat.Caption = "Xuất Excel";
            this.btnxuat.Id = 5;
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
            // barLinkContainerItem1
            // 
            this.barLinkContainerItem1.Caption = "barLinkContainerItem1";
            this.barLinkContainerItem1.Id = 0;
            this.barLinkContainerItem1.Name = "barLinkContainerItem1";
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "Thêm sự kiện";
            this.barLargeButtonItem1.Id = 1;
            this.barLargeButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem1.ImageOptions.Image")));
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dtgvsukien);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 69);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(950, 488);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dtgvsukien
            // 
            this.dtgvsukien.Location = new System.Drawing.Point(12, 12);
            this.dtgvsukien.MainView = this.gvmaster;
            this.dtgvsukien.MenuManager = this.barManager1;
            this.dtgvsukien.Name = "dtgvsukien";
            this.dtgvsukien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gvsoquy,
            this.gvloaichi,
            this.gvbannganh});
            this.dtgvsukien.Size = new System.Drawing.Size(926, 464);
            this.dtgvsukien.TabIndex = 13;
            this.dtgvsukien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvmaster,
            this.gvdetail});
            // 
            // gvmaster
            // 
            this.gvmaster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdSuKien,
            this.TenSuKien,
            this.NoiDung,
            this.NgayDienRa,
            this.NgayKetThuc,
            this.IdBanNganh,
            this.GioDienRa,
            this.GioKetThuc,
            this.ViTriDienRa});
            this.gvmaster.GridControl = this.dtgvsukien;
            this.gvmaster.Name = "gvmaster";
            this.gvmaster.OptionsView.ShowGroupPanel = false;
            // 
            // IdSuKien
            // 
            this.IdSuKien.AppearanceCell.Options.UseTextOptions = true;
            this.IdSuKien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdSuKien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdSuKien.AppearanceHeader.Options.UseFont = true;
            this.IdSuKien.AppearanceHeader.Options.UseTextOptions = true;
            this.IdSuKien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdSuKien.Caption = "Mã sự kiện";
            this.IdSuKien.FieldName = "IdSuKien";
            this.IdSuKien.MinWidth = 25;
            this.IdSuKien.Name = "IdSuKien";
            this.IdSuKien.OptionsColumn.ReadOnly = true;
            this.IdSuKien.Visible = true;
            this.IdSuKien.VisibleIndex = 0;
            this.IdSuKien.Width = 94;
            // 
            // TenSuKien
            // 
            this.TenSuKien.AppearanceCell.Options.UseTextOptions = true;
            this.TenSuKien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenSuKien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TenSuKien.AppearanceHeader.Options.UseFont = true;
            this.TenSuKien.AppearanceHeader.Options.UseTextOptions = true;
            this.TenSuKien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenSuKien.Caption = "Tên sự kiện";
            this.TenSuKien.FieldName = "TenSuKien";
            this.TenSuKien.MinWidth = 25;
            this.TenSuKien.Name = "TenSuKien";
            this.TenSuKien.OptionsColumn.ReadOnly = true;
            this.TenSuKien.Visible = true;
            this.TenSuKien.VisibleIndex = 1;
            this.TenSuKien.Width = 94;
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
            // NgayDienRa
            // 
            this.NgayDienRa.AppearanceCell.Options.UseTextOptions = true;
            this.NgayDienRa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayDienRa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NgayDienRa.AppearanceHeader.Options.UseFont = true;
            this.NgayDienRa.AppearanceHeader.Options.UseTextOptions = true;
            this.NgayDienRa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayDienRa.Caption = "Từ ngày";
            this.NgayDienRa.FieldName = "NgayDienRa";
            this.NgayDienRa.MinWidth = 25;
            this.NgayDienRa.Name = "NgayDienRa";
            this.NgayDienRa.OptionsColumn.ReadOnly = true;
            this.NgayDienRa.Visible = true;
            this.NgayDienRa.VisibleIndex = 3;
            this.NgayDienRa.Width = 94;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.AppearanceCell.Options.UseTextOptions = true;
            this.NgayKetThuc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayKetThuc.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NgayKetThuc.AppearanceHeader.Options.UseFont = true;
            this.NgayKetThuc.AppearanceHeader.Options.UseTextOptions = true;
            this.NgayKetThuc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayKetThuc.Caption = "Ngày kết thúc";
            this.NgayKetThuc.FieldName = "NgayKetThuc";
            this.NgayKetThuc.MinWidth = 25;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.OptionsColumn.ReadOnly = true;
            this.NgayKetThuc.Visible = true;
            this.NgayKetThuc.VisibleIndex = 4;
            this.NgayKetThuc.Width = 94;
            // 
            // IdBanNganh
            // 
            this.IdBanNganh.AppearanceCell.Options.UseTextOptions = true;
            this.IdBanNganh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdBanNganh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdBanNganh.AppearanceHeader.Options.UseFont = true;
            this.IdBanNganh.AppearanceHeader.Options.UseTextOptions = true;
            this.IdBanNganh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdBanNganh.Caption = "Đội phụ trách";
            this.IdBanNganh.ColumnEdit = this.gvbannganh;
            this.IdBanNganh.FieldName = "IdBanNganh";
            this.IdBanNganh.MinWidth = 25;
            this.IdBanNganh.Name = "IdBanNganh";
            this.IdBanNganh.OptionsColumn.ReadOnly = true;
            this.IdBanNganh.Visible = true;
            this.IdBanNganh.VisibleIndex = 5;
            this.IdBanNganh.Width = 94;
            // 
            // gvbannganh
            // 
            this.gvbannganh.AutoHeight = false;
            this.gvbannganh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvbannganh.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdBanNganh", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenBanNganh", "Tên ban ngành")});
            this.gvbannganh.Name = "gvbannganh";
            // 
            // GioDienRa
            // 
            this.GioDienRa.AppearanceCell.Options.UseTextOptions = true;
            this.GioDienRa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GioDienRa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.GioDienRa.AppearanceHeader.Options.UseFont = true;
            this.GioDienRa.AppearanceHeader.Options.UseTextOptions = true;
            this.GioDienRa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GioDienRa.Caption = "Giờ diễn ra";
            this.GioDienRa.FieldName = "GioDienRa";
            this.GioDienRa.MinWidth = 25;
            this.GioDienRa.Name = "GioDienRa";
            this.GioDienRa.OptionsColumn.ReadOnly = true;
            this.GioDienRa.Visible = true;
            this.GioDienRa.VisibleIndex = 6;
            this.GioDienRa.Width = 94;
            // 
            // GioKetThuc
            // 
            this.GioKetThuc.AppearanceCell.Options.UseTextOptions = true;
            this.GioKetThuc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GioKetThuc.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.GioKetThuc.AppearanceHeader.Options.UseFont = true;
            this.GioKetThuc.AppearanceHeader.Options.UseTextOptions = true;
            this.GioKetThuc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GioKetThuc.Caption = "Giờ kết thúc";
            this.GioKetThuc.FieldName = "GioKetThuc";
            this.GioKetThuc.MinWidth = 25;
            this.GioKetThuc.Name = "GioKetThuc";
            this.GioKetThuc.OptionsColumn.ReadOnly = true;
            this.GioKetThuc.Visible = true;
            this.GioKetThuc.VisibleIndex = 7;
            this.GioKetThuc.Width = 94;
            // 
            // ViTriDienRa
            // 
            this.ViTriDienRa.AppearanceCell.Options.UseTextOptions = true;
            this.ViTriDienRa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ViTriDienRa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.ViTriDienRa.AppearanceHeader.Options.UseFont = true;
            this.ViTriDienRa.AppearanceHeader.Options.UseTextOptions = true;
            this.ViTriDienRa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ViTriDienRa.Caption = "Nơi diễn ra";
            this.ViTriDienRa.FieldName = "ViTriDienRa";
            this.ViTriDienRa.MinWidth = 25;
            this.ViTriDienRa.Name = "ViTriDienRa";
            this.ViTriDienRa.Visible = true;
            this.ViTriDienRa.VisibleIndex = 8;
            this.ViTriDienRa.Width = 94;
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
            this.gvdetail.GridControl = this.dtgvsukien;
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
            this.layoutControlItem1.Control = this.dtgvsukien;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(930, 468);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // barLargeButtonItem2
            // 
            this.barLargeButtonItem2.Caption = "Cập nhật";
            this.barLargeButtonItem2.Id = 6;
            this.barLargeButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem2.ImageOptions.LargeImage")));
            this.barLargeButtonItem2.Name = "barLargeButtonItem2";
            this.barLargeButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonItem2_ItemClick);
            // 
            // DSSuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 557);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DSSuKien";
            this.Text = "Danh sách sự kiện";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvsukien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvmaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvbannganh)).EndInit();
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
        private DevExpress.XtraBars.BarLargeButtonItem btnsua;
        private DevExpress.XtraBars.BarLargeButtonItem btnxoa;
        private DevExpress.XtraBars.BarLargeButtonItem btnxuat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLinkContainerItem barLinkContainerItem1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl dtgvsukien;
        public DevExpress.XtraGrid.Views.Grid.GridView gvmaster;
        private DevExpress.XtraGrid.Columns.GridColumn IdSuKien;
        private DevExpress.XtraGrid.Columns.GridColumn TenSuKien;
        private DevExpress.XtraGrid.Columns.GridColumn NoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn NgayDienRa;
        private DevExpress.XtraGrid.Columns.GridColumn NgayKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn IdBanNganh;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvbannganh;
        private DevExpress.XtraGrid.Columns.GridColumn GioDienRa;
        private DevExpress.XtraGrid.Columns.GridColumn GioKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn ViTriDienRa;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvsoquy;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvloaichi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdetail;
        private DevExpress.XtraGrid.Columns.GridColumn IdChiTietBanNganh;
        private DevExpress.XtraGrid.Columns.GridColumn IdThanhVien;
        private DevExpress.XtraGrid.Columns.GridColumn ChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn NgayThamGia;
        private DevExpress.XtraGrid.Columns.GridColumn IdBanNgan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem2;
    }
}