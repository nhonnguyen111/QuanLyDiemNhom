namespace QuanLyDiemNhom
{
    partial class BangKePhieuThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangKePhieuThu));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btntaophieu = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnxoaphieu = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnxuat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barLinkContainerItem1 = new DevExpress.XtraBars.BarLinkContainerItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dtgvphieuthu = new DevExpress.XtraGrid.GridControl();
            this.gvmaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdPhieuThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NguoiNop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSoQuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvsoquy = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LyDoThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdLoaiThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvloaithu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gvdetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChiTietBanNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdThanhVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayThamGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdBanNgan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.NgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncapnhat = new DevExpress.XtraBars.BarLargeButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvphieuthu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvmaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvsoquy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvloaithu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdetail)).BeginInit();
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
            this.btntaophieu,
            this.btnxoaphieu,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btntaophieu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnxoaphieu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnxuat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btncapnhat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btntaophieu
            // 
            this.btntaophieu.Caption = "Tạo phiếu thu";
            this.btntaophieu.Id = 0;
            this.btntaophieu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btntaophieu.ImageOptions.LargeImage")));
            this.btntaophieu.Name = "btntaophieu";
            this.btntaophieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btntaophieu_ItemClick);
            // 
            // btnxoaphieu
            // 
            this.btnxoaphieu.Caption = "Xóa phiếu thu";
            this.btnxoaphieu.Id = 1;
            this.btnxoaphieu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnxoaphieu.ImageOptions.LargeImage")));
            this.btnxoaphieu.Name = "btnxoaphieu";
            this.btnxoaphieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxoaphieu_ItemClick);
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
            this.layoutControl1.Controls.Add(this.dtgvphieuthu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 69);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(950, 488);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dtgvphieuthu
            // 
            this.dtgvphieuthu.Location = new System.Drawing.Point(12, 12);
            this.dtgvphieuthu.MainView = this.gvmaster;
            this.dtgvphieuthu.MenuManager = this.barManager1;
            this.dtgvphieuthu.Name = "dtgvphieuthu";
            this.dtgvphieuthu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gvsoquy,
            this.gvloaithu});
            this.dtgvphieuthu.Size = new System.Drawing.Size(926, 464);
            this.dtgvphieuthu.TabIndex = 10;
            this.dtgvphieuthu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvmaster,
            this.gvdetail});
            // 
            // gvmaster
            // 
            this.gvmaster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdPhieuThu,
            this.gridColumn1,
            this.NguoiThu,
            this.SoTien,
            this.LoaiTien,
            this.NguoiNop,
            this.DiaChi,
            this.DienThoai,
            this.IdSoQuy,
            this.LyDoThu,
            this.IdLoaiThu});
            this.gvmaster.GridControl = this.dtgvphieuthu;
            this.gvmaster.Name = "gvmaster";
            this.gvmaster.OptionsView.ShowGroupPanel = false;
            // 
            // IdPhieuThu
            // 
            this.IdPhieuThu.AppearanceCell.Options.UseTextOptions = true;
            this.IdPhieuThu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdPhieuThu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdPhieuThu.AppearanceHeader.Options.UseFont = true;
            this.IdPhieuThu.AppearanceHeader.Options.UseTextOptions = true;
            this.IdPhieuThu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdPhieuThu.Caption = "Số phiếu thu";
            this.IdPhieuThu.FieldName = "IdPhieuThu";
            this.IdPhieuThu.MinWidth = 25;
            this.IdPhieuThu.Name = "IdPhieuThu";
            this.IdPhieuThu.OptionsColumn.ReadOnly = true;
            this.IdPhieuThu.Visible = true;
            this.IdPhieuThu.VisibleIndex = 0;
            this.IdPhieuThu.Width = 94;
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
            // NguoiThu
            // 
            this.NguoiThu.AppearanceCell.Options.UseTextOptions = true;
            this.NguoiThu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NguoiThu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NguoiThu.AppearanceHeader.Options.UseFont = true;
            this.NguoiThu.AppearanceHeader.Options.UseTextOptions = true;
            this.NguoiThu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NguoiThu.Caption = "Người thu";
            this.NguoiThu.FieldName = "NguoiThu";
            this.NguoiThu.MinWidth = 25;
            this.NguoiThu.Name = "NguoiThu";
            this.NguoiThu.OptionsColumn.ReadOnly = true;
            this.NguoiThu.Visible = true;
            this.NguoiThu.VisibleIndex = 2;
            this.NguoiThu.Width = 94;
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
            // NguoiNop
            // 
            this.NguoiNop.AppearanceCell.Options.UseTextOptions = true;
            this.NguoiNop.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NguoiNop.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NguoiNop.AppearanceHeader.Options.UseFont = true;
            this.NguoiNop.AppearanceHeader.Options.UseTextOptions = true;
            this.NguoiNop.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NguoiNop.Caption = "Người nộp";
            this.NguoiNop.FieldName = "NguoiNop";
            this.NguoiNop.MinWidth = 25;
            this.NguoiNop.Name = "NguoiNop";
            this.NguoiNop.OptionsColumn.ReadOnly = true;
            this.NguoiNop.Visible = true;
            this.NguoiNop.VisibleIndex = 5;
            this.NguoiNop.Width = 94;
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
            // LyDoThu
            // 
            this.LyDoThu.AppearanceCell.Options.UseTextOptions = true;
            this.LyDoThu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LyDoThu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.LyDoThu.AppearanceHeader.Options.UseFont = true;
            this.LyDoThu.AppearanceHeader.Options.UseTextOptions = true;
            this.LyDoThu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LyDoThu.Caption = "Lý do thu";
            this.LyDoThu.FieldName = "LyDoThu";
            this.LyDoThu.MinWidth = 25;
            this.LyDoThu.Name = "LyDoThu";
            this.LyDoThu.OptionsColumn.ReadOnly = true;
            this.LyDoThu.Visible = true;
            this.LyDoThu.VisibleIndex = 9;
            this.LyDoThu.Width = 94;
            // 
            // IdLoaiThu
            // 
            this.IdLoaiThu.AppearanceCell.Options.UseTextOptions = true;
            this.IdLoaiThu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdLoaiThu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdLoaiThu.AppearanceHeader.Options.UseFont = true;
            this.IdLoaiThu.AppearanceHeader.Options.UseTextOptions = true;
            this.IdLoaiThu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdLoaiThu.Caption = "Loại thu";
            this.IdLoaiThu.ColumnEdit = this.gvloaithu;
            this.IdLoaiThu.FieldName = "IdLoaiThu";
            this.IdLoaiThu.MinWidth = 25;
            this.IdLoaiThu.Name = "IdLoaiThu";
            this.IdLoaiThu.OptionsColumn.ReadOnly = true;
            this.IdLoaiThu.Visible = true;
            this.IdLoaiThu.VisibleIndex = 10;
            this.IdLoaiThu.Width = 94;
            // 
            // gvloaithu
            // 
            this.gvloaithu.AutoHeight = false;
            this.gvloaithu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvloaithu.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdLoaiThu", "ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenLoaiThu", "Tên loại thu")});
            this.gvloaithu.Name = "gvloaithu";
            // 
            // gvdetail
            // 
            this.gvdetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChiTietBanNganh,
            this.IdThanhVien,
            this.ChucVu,
            this.NgayThamGia,
            this.IdBanNgan});
            this.gvdetail.GridControl = this.dtgvphieuthu;
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
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(950, 488);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dtgvphieuthu;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(930, 468);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // NgayLap
            // 
            this.NgayLap.AppearanceCell.Options.UseTextOptions = true;
            this.NgayLap.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayLap.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NgayLap.AppearanceHeader.Options.UseFont = true;
            this.NgayLap.AppearanceHeader.Options.UseTextOptions = true;
            this.NgayLap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayLap.Caption = "Ngày lập";
            this.NgayLap.FieldName = "NgayLap";
            this.NgayLap.MinWidth = 25;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.OptionsColumn.ReadOnly = true;
            this.NgayLap.Width = 94;
            // 
            // btncapnhat
            // 
            this.btncapnhat.Caption = "Cập nhật";
            this.btncapnhat.Id = 4;
            this.btncapnhat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem1.ImageOptions.LargeImage")));
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncapnhat_ItemClick);
            // 
            // BangKePhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 557);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "BangKePhieuThu";
            this.Text = "Bảng kê phiếu thu";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvphieuthu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvmaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvsoquy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvloaithu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarLargeButtonItem btntaophieu;
        private DevExpress.XtraBars.BarLargeButtonItem btnxoaphieu;
        private DevExpress.XtraBars.BarLargeButtonItem btnxuat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarLinkContainerItem barLinkContainerItem1;
        private DevExpress.XtraGrid.GridControl dtgvphieuthu;
        public DevExpress.XtraGrid.Views.Grid.GridView gvmaster;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiThu;
        private DevExpress.XtraGrid.Columns.GridColumn SoTien;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiTien;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiNop;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn IdSoQuy;
        private DevExpress.XtraGrid.Columns.GridColumn LyDoThu;
        private DevExpress.XtraGrid.Columns.GridColumn IdLoaiThu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdetail;
        private DevExpress.XtraGrid.Columns.GridColumn IdChiTietBanNganh;
        private DevExpress.XtraGrid.Columns.GridColumn IdThanhVien;
        private DevExpress.XtraGrid.Columns.GridColumn ChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn NgayThamGia;
        private DevExpress.XtraGrid.Columns.GridColumn IdBanNgan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn IdPhieuThu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLap;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvsoquy;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvloaithu;
        private DevExpress.XtraBars.BarLargeButtonItem btncapnhat;
    }
}