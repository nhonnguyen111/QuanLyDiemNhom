namespace QuanLyDiemNhom
{
    partial class DSVatTuThanhLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSVatTuThanhLy));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btntaodon = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnxuat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dtgvthanhly = new DevExpress.XtraGrid.GridControl();
            this.gvmaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdThanhLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvvattu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.SoLuongThanhLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienThanhLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoiBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSoQuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvquy = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvthanhly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvmaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvvattu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvquy)).BeginInit();
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
            this.btntaodon,
            this.btnxuat,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btntaodon),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnxuat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btncapnhat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btntaodon
            // 
            this.btntaodon.Caption = "Tạo đơn thanh lý";
            this.btntaodon.Id = 0;
            this.btntaodon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btntaodon.ImageOptions.LargeImage")));
            this.btntaodon.Name = "btntaodon";
            this.btntaodon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btntaodon_ItemClick);
            // 
            // btnxuat
            // 
            this.btnxuat.Caption = "Xuất Excel";
            this.btnxuat.Id = 1;
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
            this.layoutControl1.Controls.Add(this.dtgvthanhly);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 69);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(950, 488);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dtgvthanhly
            // 
            this.dtgvthanhly.Location = new System.Drawing.Point(12, 12);
            this.dtgvthanhly.MainView = this.gvmaster;
            this.dtgvthanhly.MenuManager = this.barManager1;
            this.dtgvthanhly.Name = "dtgvthanhly";
            this.dtgvthanhly.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gvsoquy,
            this.gvloaichi,
            this.gvvattu,
            this.gvquy});
            this.dtgvthanhly.Size = new System.Drawing.Size(926, 464);
            this.dtgvthanhly.TabIndex = 13;
            this.dtgvthanhly.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvmaster,
            this.gvdetail});
            // 
            // gvmaster
            // 
            this.gvmaster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdThanhLy,
            this.IdVatTu,
            this.SoLuongThanhLy,
            this.TienThanhLy,
            this.NgayBan,
            this.NguoiBan,
            this.NoiBan,
            this.IdSoQuy});
            this.gvmaster.GridControl = this.dtgvthanhly;
            this.gvmaster.Name = "gvmaster";
            this.gvmaster.OptionsView.ShowGroupPanel = false;
            // 
            // IdThanhLy
            // 
            this.IdThanhLy.AppearanceCell.Options.UseTextOptions = true;
            this.IdThanhLy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdThanhLy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdThanhLy.AppearanceHeader.Options.UseFont = true;
            this.IdThanhLy.AppearanceHeader.Options.UseTextOptions = true;
            this.IdThanhLy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdThanhLy.Caption = "Số phiếu";
            this.IdThanhLy.FieldName = "IdThanhLy";
            this.IdThanhLy.MinWidth = 25;
            this.IdThanhLy.Name = "IdThanhLy";
            this.IdThanhLy.OptionsColumn.ReadOnly = true;
            this.IdThanhLy.Visible = true;
            this.IdThanhLy.VisibleIndex = 0;
            this.IdThanhLy.Width = 94;
            // 
            // IdVatTu
            // 
            this.IdVatTu.AppearanceCell.Options.UseTextOptions = true;
            this.IdVatTu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdVatTu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdVatTu.AppearanceHeader.Options.UseFont = true;
            this.IdVatTu.AppearanceHeader.Options.UseTextOptions = true;
            this.IdVatTu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdVatTu.Caption = "Tên trang thiết bị";
            this.IdVatTu.ColumnEdit = this.gvvattu;
            this.IdVatTu.FieldName = "IdVatTu";
            this.IdVatTu.MinWidth = 25;
            this.IdVatTu.Name = "IdVatTu";
            this.IdVatTu.OptionsColumn.ReadOnly = true;
            this.IdVatTu.Visible = true;
            this.IdVatTu.VisibleIndex = 1;
            this.IdVatTu.Width = 94;
            // 
            // gvvattu
            // 
            this.gvvattu.AutoHeight = false;
            this.gvvattu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvvattu.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdVatTu", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenVatTu", "Tên vật tư")});
            this.gvvattu.Name = "gvvattu";
            // 
            // SoLuongThanhLy
            // 
            this.SoLuongThanhLy.AppearanceCell.Options.UseTextOptions = true;
            this.SoLuongThanhLy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoLuongThanhLy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.SoLuongThanhLy.AppearanceHeader.Options.UseFont = true;
            this.SoLuongThanhLy.AppearanceHeader.Options.UseTextOptions = true;
            this.SoLuongThanhLy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoLuongThanhLy.Caption = "Số lượng thanh lý";
            this.SoLuongThanhLy.FieldName = "SoLuongThanhLy";
            this.SoLuongThanhLy.MinWidth = 25;
            this.SoLuongThanhLy.Name = "SoLuongThanhLy";
            this.SoLuongThanhLy.OptionsColumn.ReadOnly = true;
            this.SoLuongThanhLy.Visible = true;
            this.SoLuongThanhLy.VisibleIndex = 2;
            this.SoLuongThanhLy.Width = 94;
            // 
            // TienThanhLy
            // 
            this.TienThanhLy.AppearanceCell.Options.UseTextOptions = true;
            this.TienThanhLy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TienThanhLy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TienThanhLy.AppearanceHeader.Options.UseFont = true;
            this.TienThanhLy.AppearanceHeader.Options.UseTextOptions = true;
            this.TienThanhLy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TienThanhLy.Caption = "Tiền thanh lý được";
            this.TienThanhLy.FieldName = "TienThanhLy";
            this.TienThanhLy.MinWidth = 25;
            this.TienThanhLy.Name = "TienThanhLy";
            this.TienThanhLy.OptionsColumn.ReadOnly = true;
            this.TienThanhLy.Visible = true;
            this.TienThanhLy.VisibleIndex = 3;
            this.TienThanhLy.Width = 94;
            // 
            // NgayBan
            // 
            this.NgayBan.AppearanceCell.Options.UseTextOptions = true;
            this.NgayBan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayBan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NgayBan.AppearanceHeader.Options.UseFont = true;
            this.NgayBan.AppearanceHeader.Options.UseTextOptions = true;
            this.NgayBan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayBan.Caption = "Ngày bán";
            this.NgayBan.FieldName = "NgayBan";
            this.NgayBan.MinWidth = 25;
            this.NgayBan.Name = "NgayBan";
            this.NgayBan.OptionsColumn.ReadOnly = true;
            this.NgayBan.Visible = true;
            this.NgayBan.VisibleIndex = 4;
            this.NgayBan.Width = 94;
            // 
            // NguoiBan
            // 
            this.NguoiBan.AppearanceCell.Options.UseTextOptions = true;
            this.NguoiBan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NguoiBan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NguoiBan.AppearanceHeader.Options.UseFont = true;
            this.NguoiBan.AppearanceHeader.Options.UseTextOptions = true;
            this.NguoiBan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NguoiBan.Caption = "Người bán";
            this.NguoiBan.FieldName = "NguoiBan";
            this.NguoiBan.MinWidth = 25;
            this.NguoiBan.Name = "NguoiBan";
            this.NguoiBan.OptionsColumn.ReadOnly = true;
            this.NguoiBan.Visible = true;
            this.NguoiBan.VisibleIndex = 5;
            this.NguoiBan.Width = 94;
            // 
            // NoiBan
            // 
            this.NoiBan.AppearanceCell.Options.UseTextOptions = true;
            this.NoiBan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NoiBan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NoiBan.AppearanceHeader.Options.UseFont = true;
            this.NoiBan.AppearanceHeader.Options.UseTextOptions = true;
            this.NoiBan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NoiBan.Caption = "Nơi bán thiết bị";
            this.NoiBan.FieldName = "NoiBan";
            this.NoiBan.MinWidth = 25;
            this.NoiBan.Name = "NoiBan";
            this.NoiBan.OptionsColumn.ReadOnly = true;
            this.NoiBan.Visible = true;
            this.NoiBan.VisibleIndex = 6;
            this.NoiBan.Width = 94;
            // 
            // IdSoQuy
            // 
            this.IdSoQuy.AppearanceCell.Options.UseTextOptions = true;
            this.IdSoQuy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdSoQuy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdSoQuy.AppearanceHeader.Options.UseFont = true;
            this.IdSoQuy.AppearanceHeader.Options.UseTextOptions = true;
            this.IdSoQuy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdSoQuy.Caption = "Cộng vào quỹ";
            this.IdSoQuy.ColumnEdit = this.gvquy;
            this.IdSoQuy.FieldName = "IdSoQuy";
            this.IdSoQuy.MinWidth = 25;
            this.IdSoQuy.Name = "IdSoQuy";
            this.IdSoQuy.OptionsColumn.ReadOnly = true;
            this.IdSoQuy.Visible = true;
            this.IdSoQuy.VisibleIndex = 7;
            this.IdSoQuy.Width = 94;
            // 
            // gvquy
            // 
            this.gvquy.AutoHeight = false;
            this.gvquy.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvquy.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdSoQuy", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenSo", "Tên sổ")});
            this.gvquy.Name = "gvquy";
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
            this.gvdetail.GridControl = this.dtgvthanhly;
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
            this.layoutControlItem1.Control = this.dtgvthanhly;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(930, 468);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // btncapnhat
            // 
            this.btncapnhat.Caption = "Cập nhật";
            this.btncapnhat.Id = 2;
            this.btncapnhat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem1.ImageOptions.LargeImage")));
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncapnhat_ItemClick);
            // 
            // DSVatTuThanhLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 557);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DSVatTuThanhLy";
            this.Text = "Danh sách trang thiết bị đã thanh lý";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvthanhly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvmaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvvattu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvquy)).EndInit();
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
        private DevExpress.XtraBars.BarLargeButtonItem btntaodon;
        private DevExpress.XtraBars.BarLargeButtonItem btnxuat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl dtgvthanhly;
        public DevExpress.XtraGrid.Views.Grid.GridView gvmaster;
        private DevExpress.XtraGrid.Columns.GridColumn IdThanhLy;
        private DevExpress.XtraGrid.Columns.GridColumn IdVatTu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvvattu;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongThanhLy;
        private DevExpress.XtraGrid.Columns.GridColumn TienThanhLy;
        private DevExpress.XtraGrid.Columns.GridColumn NgayBan;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiBan;
        private DevExpress.XtraGrid.Columns.GridColumn NoiBan;
        private DevExpress.XtraGrid.Columns.GridColumn IdSoQuy;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvquy;
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