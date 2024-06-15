namespace QuanLyDiemNhom
{
    partial class DSPhieuVatTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSPhieuVatTu));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btncapnhatphieu = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnexcel = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dtgvphieuvattu = new DevExpress.XtraGrid.GridControl();
            this.gvmaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdPhieuVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvvattu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.SoLuongXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoiSuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNguoiXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvnguoixuat = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.NguoiNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvThanhVien = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gvbannganh = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gvdetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btncapnhat = new DevExpress.XtraBars.BarLargeButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvphieuvattu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvmaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvvattu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvnguoixuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvbannganh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
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
            this.btncapnhatphieu,
            this.btnexcel,
            this.barLargeButtonItem1,
            this.barLargeButtonItem2,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btncapnhatphieu),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnexcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btncapnhat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "Bố trí trang thiết bị";
            this.barLargeButtonItem1.Id = 2;
            this.barLargeButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem1.ImageOptions.LargeImage")));
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            this.barLargeButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonItem1_ItemClick);
            // 
            // btncapnhatphieu
            // 
            this.btncapnhatphieu.Caption = "Cập nhật phiếu";
            this.btncapnhatphieu.Id = 0;
            this.btncapnhatphieu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btncapnhatphieu.ImageOptions.LargeImage")));
            this.btncapnhatphieu.Name = "btncapnhatphieu";
            this.btncapnhatphieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncapnhatphieu_ItemClick);
            // 
            // barLargeButtonItem2
            // 
            this.barLargeButtonItem2.Caption = "Xóa phiếu";
            this.barLargeButtonItem2.Id = 3;
            this.barLargeButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem2.ImageOptions.LargeImage")));
            this.barLargeButtonItem2.Name = "barLargeButtonItem2";
            this.barLargeButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonItem2_ItemClick);
            // 
            // btnexcel
            // 
            this.btnexcel.Caption = "Xuất Excel";
            this.btnexcel.Id = 1;
            this.btnexcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnexcel.ImageOptions.LargeImage")));
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnexcel_ItemClick);
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
            this.layoutControl1.Controls.Add(this.dtgvphieuvattu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 69);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(950, 488);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dtgvphieuvattu
            // 
            this.dtgvphieuvattu.Location = new System.Drawing.Point(12, 12);
            this.dtgvphieuvattu.MainView = this.gvmaster;
            this.dtgvphieuvattu.MenuManager = this.barManager1;
            this.dtgvphieuvattu.Name = "dtgvphieuvattu";
            this.dtgvphieuvattu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gvThanhVien,
            this.gvbannganh,
            this.gvvattu,
            this.gvnguoixuat});
            this.dtgvphieuvattu.Size = new System.Drawing.Size(926, 464);
            this.dtgvphieuvattu.TabIndex = 10;
            this.dtgvphieuvattu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvmaster,
            this.gvdetail});
            // 
            // gvmaster
            // 
            this.gvmaster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdPhieuVatTu,
            this.IdVatTu,
            this.SoLuongXuat,
            this.NoiSuDung,
            this.NgayXuat,
            this.IdNguoiXuat,
            this.NguoiNhan,
            this.TinhTrang,
            this.NgayTra,
            this.SoLuongTra});
            this.gvmaster.GridControl = this.dtgvphieuvattu;
            this.gvmaster.Name = "gvmaster";
            this.gvmaster.OptionsView.ShowGroupPanel = false;
            // 
            // IdPhieuVatTu
            // 
            this.IdPhieuVatTu.AppearanceCell.Options.UseTextOptions = true;
            this.IdPhieuVatTu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdPhieuVatTu.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.IdPhieuVatTu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdPhieuVatTu.AppearanceHeader.Options.UseFont = true;
            this.IdPhieuVatTu.AppearanceHeader.Options.UseTextOptions = true;
            this.IdPhieuVatTu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdPhieuVatTu.Caption = "Mã số phiếu";
            this.IdPhieuVatTu.FieldName = "IdPhieuVatTu";
            this.IdPhieuVatTu.MinWidth = 25;
            this.IdPhieuVatTu.Name = "IdPhieuVatTu";
            this.IdPhieuVatTu.OptionsColumn.ReadOnly = true;
            this.IdPhieuVatTu.Visible = true;
            this.IdPhieuVatTu.VisibleIndex = 0;
            // 
            // IdVatTu
            // 
            this.IdVatTu.AppearanceCell.Options.UseTextOptions = true;
            this.IdVatTu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdVatTu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdVatTu.AppearanceHeader.Options.UseFont = true;
            this.IdVatTu.AppearanceHeader.Options.UseTextOptions = true;
            this.IdVatTu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdVatTu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdVatTu", "Mã vật tư"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenVatTu", "Tên vật tư")});
            this.gvvattu.Name = "gvvattu";
            // 
            // SoLuongXuat
            // 
            this.SoLuongXuat.AppearanceCell.Options.UseTextOptions = true;
            this.SoLuongXuat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoLuongXuat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.SoLuongXuat.AppearanceHeader.Options.UseFont = true;
            this.SoLuongXuat.AppearanceHeader.Options.UseTextOptions = true;
            this.SoLuongXuat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoLuongXuat.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SoLuongXuat.Caption = "Số lượng xuất";
            this.SoLuongXuat.FieldName = "SoLuongXuat";
            this.SoLuongXuat.MinWidth = 25;
            this.SoLuongXuat.Name = "SoLuongXuat";
            this.SoLuongXuat.OptionsColumn.ReadOnly = true;
            this.SoLuongXuat.Visible = true;
            this.SoLuongXuat.VisibleIndex = 2;
            this.SoLuongXuat.Width = 94;
            // 
            // NoiSuDung
            // 
            this.NoiSuDung.AppearanceCell.Options.UseTextOptions = true;
            this.NoiSuDung.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NoiSuDung.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NoiSuDung.AppearanceHeader.Options.UseFont = true;
            this.NoiSuDung.AppearanceHeader.Options.UseTextOptions = true;
            this.NoiSuDung.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NoiSuDung.Caption = "Nơi sử dụng";
            this.NoiSuDung.FieldName = "NoiSuDung";
            this.NoiSuDung.MinWidth = 25;
            this.NoiSuDung.Name = "NoiSuDung";
            this.NoiSuDung.OptionsColumn.ReadOnly = true;
            this.NoiSuDung.Visible = true;
            this.NoiSuDung.VisibleIndex = 3;
            this.NoiSuDung.Width = 94;
            // 
            // NgayXuat
            // 
            this.NgayXuat.AppearanceCell.Options.UseTextOptions = true;
            this.NgayXuat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayXuat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NgayXuat.AppearanceHeader.Options.UseFont = true;
            this.NgayXuat.AppearanceHeader.Options.UseTextOptions = true;
            this.NgayXuat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayXuat.Caption = "Ngày xuất";
            this.NgayXuat.FieldName = "NgayXuat";
            this.NgayXuat.MinWidth = 25;
            this.NgayXuat.Name = "NgayXuat";
            this.NgayXuat.OptionsColumn.ReadOnly = true;
            this.NgayXuat.Visible = true;
            this.NgayXuat.VisibleIndex = 4;
            this.NgayXuat.Width = 94;
            // 
            // IdNguoiXuat
            // 
            this.IdNguoiXuat.AppearanceCell.Options.UseTextOptions = true;
            this.IdNguoiXuat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdNguoiXuat.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdNguoiXuat.AppearanceHeader.Options.UseFont = true;
            this.IdNguoiXuat.AppearanceHeader.Options.UseTextOptions = true;
            this.IdNguoiXuat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdNguoiXuat.Caption = "Tên người xuất";
            this.IdNguoiXuat.ColumnEdit = this.gvnguoixuat;
            this.IdNguoiXuat.FieldName = "IdNguoiXuat";
            this.IdNguoiXuat.MinWidth = 25;
            this.IdNguoiXuat.Name = "IdNguoiXuat";
            this.IdNguoiXuat.OptionsColumn.ReadOnly = true;
            this.IdNguoiXuat.Visible = true;
            this.IdNguoiXuat.VisibleIndex = 5;
            this.IdNguoiXuat.Width = 94;
            // 
            // gvnguoixuat
            // 
            this.gvnguoixuat.AutoHeight = false;
            this.gvnguoixuat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvnguoixuat.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdUser", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HoTen", "Họ và tên")});
            this.gvnguoixuat.Name = "gvnguoixuat";
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
            this.NguoiNhan.VisibleIndex = 6;
            this.NguoiNhan.Width = 94;
            // 
            // TinhTrang
            // 
            this.TinhTrang.AppearanceCell.Options.UseTextOptions = true;
            this.TinhTrang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TinhTrang.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TinhTrang.AppearanceHeader.Options.UseFont = true;
            this.TinhTrang.AppearanceHeader.Options.UseTextOptions = true;
            this.TinhTrang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TinhTrang.Caption = "Tình trạng";
            this.TinhTrang.FieldName = "TinhTrang";
            this.TinhTrang.MinWidth = 25;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.OptionsColumn.ReadOnly = true;
            this.TinhTrang.Visible = true;
            this.TinhTrang.VisibleIndex = 7;
            this.TinhTrang.Width = 94;
            // 
            // NgayTra
            // 
            this.NgayTra.AppearanceCell.Options.UseTextOptions = true;
            this.NgayTra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayTra.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NgayTra.AppearanceHeader.Options.UseFont = true;
            this.NgayTra.AppearanceHeader.Options.UseTextOptions = true;
            this.NgayTra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayTra.Caption = "Ngày trả";
            this.NgayTra.FieldName = "NgayTra";
            this.NgayTra.MinWidth = 25;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.OptionsColumn.ReadOnly = true;
            this.NgayTra.Visible = true;
            this.NgayTra.VisibleIndex = 8;
            this.NgayTra.Width = 94;
            // 
            // SoLuongTra
            // 
            this.SoLuongTra.AppearanceCell.Options.UseTextOptions = true;
            this.SoLuongTra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoLuongTra.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.SoLuongTra.AppearanceHeader.Options.UseFont = true;
            this.SoLuongTra.AppearanceHeader.Options.UseTextOptions = true;
            this.SoLuongTra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoLuongTra.Caption = "Số lượng trả";
            this.SoLuongTra.FieldName = "SoLuongTra";
            this.SoLuongTra.MinWidth = 25;
            this.SoLuongTra.Name = "SoLuongTra";
            this.SoLuongTra.OptionsColumn.ReadOnly = true;
            this.SoLuongTra.Visible = true;
            this.SoLuongTra.VisibleIndex = 9;
            this.SoLuongTra.Width = 94;
            // 
            // gvThanhVien
            // 
            this.gvThanhVien.AutoHeight = false;
            this.gvThanhVien.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvThanhVien.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdThanhVien", "IdThanhVien"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HoTen", "Họ và tên")});
            this.gvThanhVien.Name = "gvThanhVien";
            // 
            // gvbannganh
            // 
            this.gvbannganh.AutoHeight = false;
            this.gvbannganh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvbannganh.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdBanNganh", "idbanngnah"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenBanNganh", "Tên ban")});
            this.gvbannganh.Name = "gvbannganh";
            // 
            // gvdetail
            // 
            this.gvdetail.GridControl = this.dtgvphieuvattu;
            this.gvdetail.Name = "gvdetail";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(950, 488);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dtgvphieuvattu;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(930, 468);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // btncapnhat
            // 
            this.btncapnhat.Caption = "Cập nhật";
            this.btncapnhat.Id = 4;
            this.btncapnhat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem3.ImageOptions.LargeImage")));
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncapnhat_ItemClick);
            // 
            // DSPhieuVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 557);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DSPhieuVatTu";
            this.Text = "Danh sách phiếu thiết bị đã bố trí";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvphieuvattu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvmaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvvattu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvnguoixuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvbannganh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarLargeButtonItem btncapnhatphieu;
        private DevExpress.XtraBars.BarLargeButtonItem btnexcel;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem2;
        private DevExpress.XtraGrid.GridControl dtgvphieuvattu;
        public DevExpress.XtraGrid.Views.Grid.GridView gvmaster;
        private DevExpress.XtraGrid.Columns.GridColumn IdPhieuVatTu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvThanhVien;
        private DevExpress.XtraGrid.Columns.GridColumn IdVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongXuat;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvbannganh;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdetail;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn NoiSuDung;
        private DevExpress.XtraGrid.Columns.GridColumn NgayXuat;
        private DevExpress.XtraGrid.Columns.GridColumn IdNguoiXuat;
        private DevExpress.XtraGrid.Columns.GridColumn NguoiNhan;
        private DevExpress.XtraGrid.Columns.GridColumn TinhTrang;
        private DevExpress.XtraGrid.Columns.GridColumn NgayTra;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongTra;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvvattu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvnguoixuat;
        private DevExpress.XtraBars.BarLargeButtonItem btncapnhat;
    }
}