namespace QuanLyDiemNhom
{
    partial class BangKePhieuChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangKePhieuChi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnthem = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnxoa = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnxuat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barLinkContainerItem1 = new DevExpress.XtraBars.BarLinkContainerItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dtgvphieuchi = new DevExpress.XtraGrid.GridControl();
            this.gvmaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idPhieuChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSoQuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvsoquy = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LyDoChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdLoaiChi = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvphieuchi)).BeginInit();
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
            this.btnxoa,
            this.barLinkContainerItem1,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnxoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnxuat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btncapnhat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnthem
            // 
            this.btnthem.Caption = "Thêm phiếu chi";
            this.btnthem.Id = 0;
            this.btnthem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.LargeImage")));
            this.btnthem.Name = "btnthem";
            // 
            // btnxoa
            // 
            this.btnxoa.Caption = "Xóa phiếu chi";
            this.btnxoa.Id = 1;
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
            // barLinkContainerItem1
            // 
            this.barLinkContainerItem1.Caption = "barLinkContainerItem1";
            this.barLinkContainerItem1.Id = 2;
            this.barLinkContainerItem1.Name = "barLinkContainerItem1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dtgvphieuchi);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 69);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(950, 488);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dtgvphieuchi
            // 
            this.dtgvphieuchi.Location = new System.Drawing.Point(12, 12);
            this.dtgvphieuchi.MainView = this.gvmaster;
            this.dtgvphieuchi.MenuManager = this.barManager1;
            this.dtgvphieuchi.Name = "dtgvphieuchi";
            this.dtgvphieuchi.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gvsoquy,
            this.gvloaichi});
            this.dtgvphieuchi.Size = new System.Drawing.Size(926, 464);
            this.dtgvphieuchi.TabIndex = 11;
            this.dtgvphieuchi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvmaster,
            this.gvdetail});
            // 
            // gvmaster
            // 
            this.gvmaster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idPhieuChi,
            this.gridColumn1,
            this.NguoiChi,
            this.SoTien,
            this.LoaiTien,
            this.NguoiNhan,
            this.DiaChi,
            this.DienThoai,
            this.IdSoQuy,
            this.LyDoChi,
            this.IdLoaiChi});
            this.gvmaster.GridControl = this.dtgvphieuchi;
            this.gvmaster.Name = "gvmaster";
            this.gvmaster.OptionsView.ShowGroupPanel = false;
            // 
            // idPhieuChi
            // 
            this.idPhieuChi.AppearanceCell.Options.UseTextOptions = true;
            this.idPhieuChi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.idPhieuChi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.idPhieuChi.AppearanceHeader.Options.UseFont = true;
            this.idPhieuChi.AppearanceHeader.Options.UseTextOptions = true;
            this.idPhieuChi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.idPhieuChi.Caption = "Số phiếu chi";
            this.idPhieuChi.FieldName = "idPhieuChi";
            this.idPhieuChi.MinWidth = 25;
            this.idPhieuChi.Name = "idPhieuChi";
            this.idPhieuChi.OptionsColumn.ReadOnly = true;
            this.idPhieuChi.Visible = true;
            this.idPhieuChi.VisibleIndex = 0;
            this.idPhieuChi.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Ngày lập";
            this.gridColumn1.FieldName = "NgayLap";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 94;
            // 
            // NguoiChi
            // 
            this.NguoiChi.AppearanceCell.Options.UseTextOptions = true;
            this.NguoiChi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NguoiChi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NguoiChi.AppearanceHeader.Options.UseFont = true;
            this.NguoiChi.AppearanceHeader.Options.UseTextOptions = true;
            this.NguoiChi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NguoiChi.Caption = "Người chi";
            this.NguoiChi.FieldName = "NguoiChi";
            this.NguoiChi.MinWidth = 25;
            this.NguoiChi.Name = "NguoiChi";
            this.NguoiChi.OptionsColumn.ReadOnly = true;
            this.NguoiChi.Visible = true;
            this.NguoiChi.VisibleIndex = 2;
            this.NguoiChi.Width = 94;
            // 
            // SoTien
            // 
            this.SoTien.AppearanceCell.Options.UseTextOptions = true;
            this.SoTien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoTien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.SoTien.AppearanceHeader.Options.UseFont = true;
            this.SoTien.AppearanceHeader.Options.UseTextOptions = true;
            this.SoTien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoTien.Caption = "Số tiền đóng";
            this.SoTien.FieldName = "SoTien";
            this.SoTien.MinWidth = 25;
            this.SoTien.Name = "SoTien";
            this.SoTien.OptionsColumn.ReadOnly = true;
            this.SoTien.Visible = true;
            this.SoTien.VisibleIndex = 3;
            this.SoTien.Width = 94;
            // 
            // LoaiTien
            // 
            this.LoaiTien.AppearanceCell.Options.UseTextOptions = true;
            this.LoaiTien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LoaiTien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.LoaiTien.AppearanceHeader.Options.UseFont = true;
            this.LoaiTien.AppearanceHeader.Options.UseTextOptions = true;
            this.LoaiTien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LoaiTien.Caption = "Loại tiền";
            this.LoaiTien.FieldName = "LoaiTien";
            this.LoaiTien.MinWidth = 25;
            this.LoaiTien.Name = "LoaiTien";
            this.LoaiTien.OptionsColumn.ReadOnly = true;
            this.LoaiTien.Visible = true;
            this.LoaiTien.VisibleIndex = 4;
            this.LoaiTien.Width = 94;
            // 
            // NguoiNhan
            // 
            this.NguoiNhan.AppearanceCell.Options.UseTextOptions = true;
            this.NguoiNhan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NguoiNhan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NguoiNhan.AppearanceHeader.Options.UseFont = true;
            this.NguoiNhan.AppearanceHeader.Options.UseTextOptions = true;
            this.NguoiNhan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NguoiNhan.Caption = "Người nhận";
            this.NguoiNhan.FieldName = "NguoiNhan";
            this.NguoiNhan.MinWidth = 25;
            this.NguoiNhan.Name = "NguoiNhan";
            this.NguoiNhan.OptionsColumn.ReadOnly = true;
            this.NguoiNhan.Visible = true;
            this.NguoiNhan.VisibleIndex = 5;
            this.NguoiNhan.Width = 94;
            // 
            // DiaChi
            // 
            this.DiaChi.AppearanceCell.Options.UseTextOptions = true;
            this.DiaChi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            this.DiaChi.VisibleIndex = 6;
            this.DiaChi.Width = 94;
            // 
            // DienThoai
            // 
            this.DienThoai.AppearanceCell.Options.UseTextOptions = true;
            this.DienThoai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DienThoai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.DienThoai.AppearanceHeader.Options.UseFont = true;
            this.DienThoai.AppearanceHeader.Options.UseTextOptions = true;
            this.DienThoai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DienThoai.Caption = "Điện thoại";
            this.DienThoai.FieldName = "DienThoai";
            this.DienThoai.MinWidth = 25;
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.OptionsColumn.ReadOnly = true;
            this.DienThoai.Visible = true;
            this.DienThoai.VisibleIndex = 7;
            this.DienThoai.Width = 94;
            // 
            // IdSoQuy
            // 
            this.IdSoQuy.AppearanceCell.Options.UseTextOptions = true;
            this.IdSoQuy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdSoQuy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdSoQuy.AppearanceHeader.Options.UseFont = true;
            this.IdSoQuy.AppearanceHeader.Options.UseTextOptions = true;
            this.IdSoQuy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdSoQuy.Caption = "Sổ quỹ";
            this.IdSoQuy.ColumnEdit = this.gvsoquy;
            this.IdSoQuy.FieldName = "IdSoQuy";
            this.IdSoQuy.MinWidth = 25;
            this.IdSoQuy.Name = "IdSoQuy";
            this.IdSoQuy.OptionsColumn.ReadOnly = true;
            this.IdSoQuy.Visible = true;
            this.IdSoQuy.VisibleIndex = 8;
            this.IdSoQuy.Width = 94;
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
            // LyDoChi
            // 
            this.LyDoChi.AppearanceCell.Options.UseTextOptions = true;
            this.LyDoChi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LyDoChi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.LyDoChi.AppearanceHeader.Options.UseFont = true;
            this.LyDoChi.AppearanceHeader.Options.UseTextOptions = true;
            this.LyDoChi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LyDoChi.Caption = "Lý do chi";
            this.LyDoChi.FieldName = "LyDoChi";
            this.LyDoChi.MinWidth = 25;
            this.LyDoChi.Name = "LyDoChi";
            this.LyDoChi.OptionsColumn.ReadOnly = true;
            this.LyDoChi.Visible = true;
            this.LyDoChi.VisibleIndex = 9;
            this.LyDoChi.Width = 94;
            // 
            // IdLoaiChi
            // 
            this.IdLoaiChi.AppearanceCell.Options.UseTextOptions = true;
            this.IdLoaiChi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdLoaiChi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdLoaiChi.AppearanceHeader.Options.UseFont = true;
            this.IdLoaiChi.AppearanceHeader.Options.UseTextOptions = true;
            this.IdLoaiChi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdLoaiChi.Caption = "Loại chi";
            this.IdLoaiChi.ColumnEdit = this.gvloaichi;
            this.IdLoaiChi.FieldName = "IdLoaiChi";
            this.IdLoaiChi.MinWidth = 25;
            this.IdLoaiChi.Name = "IdLoaiChi";
            this.IdLoaiChi.OptionsColumn.ReadOnly = true;
            this.IdLoaiChi.Visible = true;
            this.IdLoaiChi.VisibleIndex = 10;
            this.IdLoaiChi.Width = 94;
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
            this.gvdetail.GridControl = this.dtgvphieuchi;
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
            this.layoutControlItem1.Control = this.dtgvphieuchi;
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
            // BangKePhieuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 557);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "BangKePhieuChi";
            this.Text = "Bảng kê phiếu chi";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvphieuchi)).EndInit();
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
        private DevExpress.XtraBars.BarLargeButtonItem btnxoa;
        private DevExpress.XtraBars.BarLargeButtonItem btnxuat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarLinkContainerItem barLinkContainerItem1;
        private DevExpress.XtraGrid.GridControl dtgvphieuchi;
        public DevExpress.XtraGrid.Views.Grid.GridView gvmaster;
        private DevExpress.XtraGrid.Columns.GridColumn idPhieuChi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiChi;
        private DevExpress.XtraGrid.Columns.GridColumn SoTien;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiTien;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiNhan;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn IdSoQuy;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvsoquy;
        private DevExpress.XtraGrid.Columns.GridColumn LyDoChi;
        private DevExpress.XtraGrid.Columns.GridColumn IdLoaiChi;
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