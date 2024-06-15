namespace QuanLyDiemNhom
{
    partial class ChiTietKhoaHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietKhoaHoc));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnthem = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnxoa = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnxuatexcel = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnthongbao = new DevExpress.XtraBars.BarLargeButtonItem();
            this.lbsoluonghocsinh = new DevExpress.XtraBars.BarStaticItem();
            this.btnketthuckhoahoc = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dtgvchitietkhoahoc = new DevExpress.XtraGrid.GridControl();
            this.gvmaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdChiTietKhoaHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdThanhVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvhocisnh = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.IdKhoaHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvkhoahoc = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gvThanhVien = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gvbannganh = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gvdetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvchitietkhoahoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvmaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvhocisnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvkhoahoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvbannganh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
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
            this.btnthem,
            this.btnxoa,
            this.btnxuatexcel,
            this.btnthongbao,
            this.lbsoluonghocsinh,
            this.btnketthuckhoahoc});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnxoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnxuatexcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnthongbao),
            new DevExpress.XtraBars.LinkPersistInfo(this.lbsoluonghocsinh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnketthuckhoahoc)});
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
            // btnxoa
            // 
            this.btnxoa.Caption = "Xóa";
            this.btnxoa.Id = 1;
            this.btnxoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.LargeImage")));
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxoa_ItemClick);
            // 
            // btnxuatexcel
            // 
            this.btnxuatexcel.Caption = "Xuất Excel";
            this.btnxuatexcel.Id = 2;
            this.btnxuatexcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnxuatexcel.ImageOptions.LargeImage")));
            this.btnxuatexcel.Name = "btnxuatexcel";
            this.btnxuatexcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnxuatexcel_ItemClick);
            // 
            // btnthongbao
            // 
            this.btnthongbao.Caption = "Thông báo Email";
            this.btnthongbao.Id = 3;
            this.btnthongbao.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnthongbao.ImageOptions.LargeImage")));
            this.btnthongbao.Name = "btnthongbao";
            this.btnthongbao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnthongbao_ItemClick);
            // 
            // lbsoluonghocsinh
            // 
            this.lbsoluonghocsinh.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lbsoluonghocsinh.Caption = "Số lượng học sinh";
            this.lbsoluonghocsinh.Id = 4;
            this.lbsoluonghocsinh.Name = "lbsoluonghocsinh";
            // 
            // btnketthuckhoahoc
            // 
            this.btnketthuckhoahoc.Caption = "Kết thúc khóa học";
            this.btnketthuckhoahoc.Id = 5;
            this.btnketthuckhoahoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnketthuckhoahoc.ImageOptions.LargeImage")));
            this.btnketthuckhoahoc.Name = "btnketthuckhoahoc";
            this.btnketthuckhoahoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnketthuckhoahoc_ItemClick);
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
            this.layoutControl1.Controls.Add(this.dtgvchitietkhoahoc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 69);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(950, 488);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dtgvchitietkhoahoc
            // 
            this.dtgvchitietkhoahoc.Location = new System.Drawing.Point(12, 12);
            this.dtgvchitietkhoahoc.MainView = this.gvmaster;
            this.dtgvchitietkhoahoc.MenuManager = this.barManager1;
            this.dtgvchitietkhoahoc.Name = "dtgvchitietkhoahoc";
            this.dtgvchitietkhoahoc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gvThanhVien,
            this.gvbannganh,
            this.gvhocisnh,
            this.gvkhoahoc});
            this.dtgvchitietkhoahoc.Size = new System.Drawing.Size(926, 464);
            this.dtgvchitietkhoahoc.TabIndex = 10;
            this.dtgvchitietkhoahoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvmaster,
            this.gvdetail});
            // 
            // gvmaster
            // 
            this.gvmaster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChiTietKhoaHoc,
            this.IdThanhVien,
            this.IdKhoaHoc});
            this.gvmaster.GridControl = this.dtgvchitietkhoahoc;
            this.gvmaster.Name = "gvmaster";
            this.gvmaster.OptionsView.ShowGroupPanel = false;
            // 
            // IdChiTietKhoaHoc
            // 
            this.IdChiTietKhoaHoc.AppearanceCell.Options.UseTextOptions = true;
            this.IdChiTietKhoaHoc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdChiTietKhoaHoc.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.IdChiTietKhoaHoc.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdChiTietKhoaHoc.AppearanceHeader.Options.UseFont = true;
            this.IdChiTietKhoaHoc.AppearanceHeader.Options.UseTextOptions = true;
            this.IdChiTietKhoaHoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdChiTietKhoaHoc.Caption = "Số thứ tự";
            this.IdChiTietKhoaHoc.FieldName = "IdChiTietKhoaHoc";
            this.IdChiTietKhoaHoc.MinWidth = 25;
            this.IdChiTietKhoaHoc.Name = "IdChiTietKhoaHoc";
            this.IdChiTietKhoaHoc.OptionsColumn.ReadOnly = true;
            this.IdChiTietKhoaHoc.Visible = true;
            this.IdChiTietKhoaHoc.VisibleIndex = 0;
            // 
            // IdThanhVien
            // 
            this.IdThanhVien.AppearanceCell.Options.UseTextOptions = true;
            this.IdThanhVien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdThanhVien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdThanhVien.AppearanceHeader.Options.UseFont = true;
            this.IdThanhVien.AppearanceHeader.Options.UseTextOptions = true;
            this.IdThanhVien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdThanhVien.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.IdThanhVien.Caption = "Họ và tên";
            this.IdThanhVien.ColumnEdit = this.gvhocisnh;
            this.IdThanhVien.FieldName = "IdThanhVien";
            this.IdThanhVien.MinWidth = 25;
            this.IdThanhVien.Name = "IdThanhVien";
            this.IdThanhVien.Visible = true;
            this.IdThanhVien.VisibleIndex = 1;
            this.IdThanhVien.Width = 94;
            // 
            // gvhocisnh
            // 
            this.gvhocisnh.AutoHeight = false;
            this.gvhocisnh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvhocisnh.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdThanhVien", "IdThanhVien"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HoTen", "Họ và tên")});
            this.gvhocisnh.Name = "gvhocisnh";
            // 
            // IdKhoaHoc
            // 
            this.IdKhoaHoc.AppearanceCell.Options.UseTextOptions = true;
            this.IdKhoaHoc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdKhoaHoc.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdKhoaHoc.AppearanceHeader.Options.UseFont = true;
            this.IdKhoaHoc.AppearanceHeader.Options.UseTextOptions = true;
            this.IdKhoaHoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdKhoaHoc.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.IdKhoaHoc.Caption = "Khóa học";
            this.IdKhoaHoc.ColumnEdit = this.gvkhoahoc;
            this.IdKhoaHoc.FieldName = "IdKhoaHoc";
            this.IdKhoaHoc.MinWidth = 25;
            this.IdKhoaHoc.Name = "IdKhoaHoc";
            this.IdKhoaHoc.Visible = true;
            this.IdKhoaHoc.VisibleIndex = 2;
            this.IdKhoaHoc.Width = 94;
            // 
            // gvkhoahoc
            // 
            this.gvkhoahoc.AutoHeight = false;
            this.gvkhoahoc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvkhoahoc.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdKhoaHoc", "IdKhoaHoc"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKhoaHoc", "Tên khóa học")});
            this.gvkhoahoc.Name = "gvkhoahoc";
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
            this.gvdetail.GridControl = this.dtgvchitietkhoahoc;
            this.gvdetail.Name = "gvdetail";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(950, 488);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dtgvchitietkhoahoc;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(930, 468);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ChiTietKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 557);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ChiTietKhoaHoc";
            this.Text = "Chi tiết khóa học";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvchitietkhoahoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvmaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvhocisnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvkhoahoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvbannganh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarLargeButtonItem btnthem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem btnxoa;
        private DevExpress.XtraBars.BarLargeButtonItem btnxuatexcel;
        private DevExpress.XtraBars.BarLargeButtonItem btnthongbao;
        private DevExpress.XtraBars.BarStaticItem lbsoluonghocsinh;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl dtgvchitietkhoahoc;
        public DevExpress.XtraGrid.Views.Grid.GridView gvmaster;
        private DevExpress.XtraGrid.Columns.GridColumn IdChiTietKhoaHoc;
        private DevExpress.XtraGrid.Columns.GridColumn IdThanhVien;
        private DevExpress.XtraGrid.Columns.GridColumn IdKhoaHoc;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvThanhVien;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvbannganh;
        private DevExpress.XtraGrid.Views.Grid.GridView gvdetail;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvhocisnh;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvkhoahoc;
        private DevExpress.XtraBars.BarLargeButtonItem btnketthuckhoahoc;
    }
}