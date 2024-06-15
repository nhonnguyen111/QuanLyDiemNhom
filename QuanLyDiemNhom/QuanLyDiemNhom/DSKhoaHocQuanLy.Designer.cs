namespace QuanLyDiemNhom
{
    partial class DSKhoaHocQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSKhoaHocQuanLy));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnthongbao = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnxuat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnchitiet = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btncapnhat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dtgvkhoahoc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdKhoaHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKhoaHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdGiaoVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvgiaovien = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.NgayBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LapLai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtgvquyen = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvkhoahoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvgiaovien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvquyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
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
            this.btnthongbao,
            this.btnxuat,
            this.btnchitiet,
            this.btncapnhat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnthongbao),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnxuat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnchitiet),
            new DevExpress.XtraBars.LinkPersistInfo(this.btncapnhat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnthongbao
            // 
            this.btnthongbao.Caption = "Thông báo Email";
            this.btnthongbao.Id = 0;
            this.btnthongbao.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem1.ImageOptions.LargeImage")));
            this.btnthongbao.Name = "btnthongbao";
            this.btnthongbao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnthongbao_ItemClick);
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
            // btnxuat
            // 
            this.btnxuat.Caption = "Xuất Excel";
            this.btnxuat.Id = 1;
            this.btnxuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem2.ImageOptions.LargeImage")));
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxuat_ItemClick);
            // 
            // btnchitiet
            // 
            this.btnchitiet.Caption = "Chi tiết khóa học";
            this.btnchitiet.Id = 2;
            this.btnchitiet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem3.ImageOptions.LargeImage")));
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnchitiet_ItemClick);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Caption = "Cập nhật";
            this.btncapnhat.Id = 3;
            this.btncapnhat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem4.ImageOptions.LargeImage")));
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncapnhat_ItemClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dtgvkhoahoc);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 69);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(950, 488);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup1,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(950, 488);
            this.Root.TextVisible = false;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(24, 52);
            this.textEdit1.MenuManager = this.barManager1;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(137, 22);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 4;
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup1;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(165, 468);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(141, 416);
            this.layoutControlGroup1.Text = "Tìm kiếm";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(141, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(24, 437);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(137, 27);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Tìm kiếm";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 385);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(141, 31);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // dtgvkhoahoc
            // 
            this.dtgvkhoahoc.Location = new System.Drawing.Point(177, 12);
            this.dtgvkhoahoc.MainView = this.gridView1;
            this.dtgvkhoahoc.MenuManager = this.barManager1;
            this.dtgvkhoahoc.Name = "dtgvkhoahoc";
            this.dtgvkhoahoc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dtgvquyen,
            this.gvgiaovien});
            this.dtgvkhoahoc.Size = new System.Drawing.Size(761, 464);
            this.dtgvkhoahoc.TabIndex = 10;
            this.dtgvkhoahoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdKhoaHoc,
            this.TenKhoaHoc,
            this.SoLuong,
            this.IdGiaoVien,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.TinhTrang,
            this.LapLai});
            this.gridView1.GridControl = this.dtgvkhoahoc;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // IdKhoaHoc
            // 
            this.IdKhoaHoc.AppearanceCell.Options.UseTextOptions = true;
            this.IdKhoaHoc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdKhoaHoc.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.IdKhoaHoc.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdKhoaHoc.AppearanceHeader.Options.UseFont = true;
            this.IdKhoaHoc.AppearanceHeader.Options.UseTextOptions = true;
            this.IdKhoaHoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdKhoaHoc.Caption = "Mã khóa học";
            this.IdKhoaHoc.FieldName = "IdKhoaHoc";
            this.IdKhoaHoc.MinWidth = 25;
            this.IdKhoaHoc.Name = "IdKhoaHoc";
            this.IdKhoaHoc.OptionsColumn.ReadOnly = true;
            this.IdKhoaHoc.Width = 93;
            // 
            // TenKhoaHoc
            // 
            this.TenKhoaHoc.AppearanceCell.Options.UseTextOptions = true;
            this.TenKhoaHoc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenKhoaHoc.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TenKhoaHoc.AppearanceHeader.Options.UseFont = true;
            this.TenKhoaHoc.AppearanceHeader.Options.UseTextOptions = true;
            this.TenKhoaHoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenKhoaHoc.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TenKhoaHoc.Caption = "Tên khóa học";
            this.TenKhoaHoc.FieldName = "TenKhoaHoc";
            this.TenKhoaHoc.MinWidth = 25;
            this.TenKhoaHoc.Name = "TenKhoaHoc";
            this.TenKhoaHoc.OptionsColumn.ReadOnly = true;
            this.TenKhoaHoc.Visible = true;
            this.TenKhoaHoc.VisibleIndex = 0;
            this.TenKhoaHoc.Width = 94;
            // 
            // SoLuong
            // 
            this.SoLuong.AppearanceCell.Options.UseTextOptions = true;
            this.SoLuong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoLuong.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SoLuong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.SoLuong.AppearanceHeader.Options.UseFont = true;
            this.SoLuong.AppearanceHeader.Options.UseTextOptions = true;
            this.SoLuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoLuong.Caption = "Số lượng học sinh";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.MinWidth = 25;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.OptionsColumn.ReadOnly = true;
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 2;
            this.SoLuong.Width = 69;
            // 
            // IdGiaoVien
            // 
            this.IdGiaoVien.AppearanceCell.Options.UseTextOptions = true;
            this.IdGiaoVien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdGiaoVien.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.IdGiaoVien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdGiaoVien.AppearanceHeader.Options.UseFont = true;
            this.IdGiaoVien.AppearanceHeader.Options.UseTextOptions = true;
            this.IdGiaoVien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdGiaoVien.Caption = "Giáo viên";
            this.IdGiaoVien.ColumnEdit = this.gvgiaovien;
            this.IdGiaoVien.FieldName = "IdGiaoVien";
            this.IdGiaoVien.MinWidth = 25;
            this.IdGiaoVien.Name = "IdGiaoVien";
            this.IdGiaoVien.OptionsColumn.ReadOnly = true;
            this.IdGiaoVien.Visible = true;
            this.IdGiaoVien.VisibleIndex = 1;
            this.IdGiaoVien.Width = 69;
            // 
            // gvgiaovien
            // 
            this.gvgiaovien.AutoHeight = false;
            this.gvgiaovien.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvgiaovien.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdUser", "IdUser"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HoTen", "Tên giáo viên")});
            this.gvgiaovien.Name = "gvgiaovien";
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.AppearanceCell.Options.UseTextOptions = true;
            this.NgayBatDau.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayBatDau.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NgayBatDau.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NgayBatDau.AppearanceHeader.Options.UseFont = true;
            this.NgayBatDau.AppearanceHeader.Options.UseTextOptions = true;
            this.NgayBatDau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayBatDau.Caption = "Ngày bắt đầu";
            this.NgayBatDau.FieldName = "NgayBatDau";
            this.NgayBatDau.MinWidth = 25;
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.OptionsColumn.ReadOnly = true;
            this.NgayBatDau.Visible = true;
            this.NgayBatDau.VisibleIndex = 3;
            this.NgayBatDau.Width = 82;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.AppearanceCell.Options.UseTextOptions = true;
            this.NgayKetThuc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NgayKetThuc.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
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
            this.NgayKetThuc.VisibleIndex = 6;
            this.NgayKetThuc.Width = 72;
            // 
            // TinhTrang
            // 
            this.TinhTrang.AppearanceCell.Options.UseTextOptions = true;
            this.TinhTrang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TinhTrang.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
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
            this.TinhTrang.VisibleIndex = 4;
            this.TinhTrang.Width = 66;
            // 
            // LapLai
            // 
            this.LapLai.AppearanceCell.Options.UseTextOptions = true;
            this.LapLai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LapLai.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.LapLai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.LapLai.AppearanceHeader.Options.UseFont = true;
            this.LapLai.AppearanceHeader.Options.UseTextOptions = true;
            this.LapLai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LapLai.Caption = "Thời gian lên lớp";
            this.LapLai.FieldName = "LapLai";
            this.LapLai.MinWidth = 25;
            this.LapLai.Name = "LapLai";
            this.LapLai.OptionsColumn.ReadOnly = true;
            this.LapLai.Visible = true;
            this.LapLai.VisibleIndex = 5;
            this.LapLai.Width = 74;
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
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dtgvkhoahoc;
            this.layoutControlItem3.Location = new System.Drawing.Point(165, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(765, 468);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 26);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(141, 359);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // DSKhoaHocQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 557);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DSKhoaHocQuanLy";
            this.Text = "Danh sách khóa học của bạn";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvkhoahoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvgiaovien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvquyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
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
        private DevExpress.XtraBars.BarLargeButtonItem btnthongbao;
        private DevExpress.XtraBars.BarLargeButtonItem btnxuat;
        private DevExpress.XtraBars.BarLargeButtonItem btnchitiet;
        private DevExpress.XtraBars.BarLargeButtonItem btncapnhat;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl dtgvkhoahoc;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IdKhoaHoc;
        private DevExpress.XtraGrid.Columns.GridColumn TenKhoaHoc;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn IdGiaoVien;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvgiaovien;
        private DevExpress.XtraGrid.Columns.GridColumn NgayBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn NgayKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn TinhTrang;
        private DevExpress.XtraGrid.Columns.GridColumn LapLai;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit dtgvquyen;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}