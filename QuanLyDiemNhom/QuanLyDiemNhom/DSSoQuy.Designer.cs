namespace QuanLyDiemNhom
{
    partial class DSSoQuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSSoQuy));
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
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
            this.barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dtgvsoquy = new DevExpress.XtraGrid.GridControl();
            this.gvmaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdSoQuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongTien = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvsoquy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvmaster)).BeginInit();
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
            this.btnsua,
            this.btnxoa,
            this.btnxuat,
            this.barWorkspaceMenuItem1,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnxuat),
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
            this.btnsua.Caption = "Sửa ";
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
            // barWorkspaceMenuItem1
            // 
            this.barWorkspaceMenuItem1.Caption = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.Id = 4;
            this.barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.WorkspaceManager = this.workspaceManager1;
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dtgvsoquy);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 69);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(950, 488);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dtgvsoquy
            // 
            this.dtgvsoquy.Location = new System.Drawing.Point(12, 12);
            this.dtgvsoquy.MainView = this.gvmaster;
            this.dtgvsoquy.MenuManager = this.barManager1;
            this.dtgvsoquy.Name = "dtgvsoquy";
            this.dtgvsoquy.Size = new System.Drawing.Size(926, 464);
            this.dtgvsoquy.TabIndex = 9;
            this.dtgvsoquy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvmaster,
            this.gvdetail});
            // 
            // gvmaster
            // 
            this.gvmaster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdSoQuy,
            this.TenSo,
            this.TongTien});
            this.gvmaster.GridControl = this.dtgvsoquy;
            this.gvmaster.Name = "gvmaster";
            this.gvmaster.OptionsView.ShowGroupPanel = false;
            // 
            // IdSoQuy
            // 
            this.IdSoQuy.AppearanceCell.Options.UseTextOptions = true;
            this.IdSoQuy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdSoQuy.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IdSoQuy.AppearanceHeader.Options.UseFont = true;
            this.IdSoQuy.AppearanceHeader.Options.UseTextOptions = true;
            this.IdSoQuy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdSoQuy.Caption = "Mã";
            this.IdSoQuy.FieldName = "IdSoQuy";
            this.IdSoQuy.MinWidth = 25;
            this.IdSoQuy.Name = "IdSoQuy";
            this.IdSoQuy.Width = 94;
            // 
            // TenSo
            // 
            this.TenSo.AppearanceCell.Options.UseTextOptions = true;
            this.TenSo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenSo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TenSo.AppearanceHeader.Options.UseFont = true;
            this.TenSo.AppearanceHeader.Options.UseTextOptions = true;
            this.TenSo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TenSo.Caption = "Tên sổ quỹ";
            this.TenSo.FieldName = "TenSo";
            this.TenSo.MinWidth = 25;
            this.TenSo.Name = "TenSo";
            this.TenSo.OptionsColumn.ReadOnly = true;
            this.TenSo.Visible = true;
            this.TenSo.VisibleIndex = 0;
            this.TenSo.Width = 94;
            // 
            // TongTien
            // 
            this.TongTien.AppearanceCell.Options.UseTextOptions = true;
            this.TongTien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TongTien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TongTien.AppearanceHeader.Options.UseFont = true;
            this.TongTien.AppearanceHeader.Options.UseTextOptions = true;
            this.TongTien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TongTien.Caption = "Tổng tiền";
            this.TongTien.FieldName = "TongTien";
            this.TongTien.MinWidth = 25;
            this.TongTien.Name = "TongTien";
            this.TongTien.OptionsColumn.ReadOnly = true;
            this.TongTien.Visible = true;
            this.TongTien.VisibleIndex = 1;
            this.TongTien.Width = 94;
            // 
            // gvdetail
            // 
            this.gvdetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdChiTietBanNganh,
            this.IdThanhVien,
            this.ChucVu,
            this.NgayThamGia,
            this.IdBanNgan});
            this.gvdetail.GridControl = this.dtgvsoquy;
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
            this.layoutControlItem1.Control = this.dtgvsoquy;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(930, 468);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // btncapnhat
            // 
            this.btncapnhat.Caption = "Cập nhật";
            this.btncapnhat.Id = 5;
            this.btncapnhat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem1.ImageOptions.LargeImage")));
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncapnhat_ItemClick);
            // 
            // DSSoQuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 557);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DSSoQuy";
            this.Text = "Danh sách sổ quỹ";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvsoquy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvmaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
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
        private DevExpress.XtraBars.BarLargeButtonItem btnxuat;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarWorkspaceMenuItem barWorkspaceMenuItem1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraGrid.GridControl dtgvsoquy;
        public DevExpress.XtraGrid.Views.Grid.GridView gvmaster;
        private DevExpress.XtraGrid.Columns.GridColumn IdSoQuy;
        private DevExpress.XtraGrid.Columns.GridColumn TenSo;
        private DevExpress.XtraGrid.Columns.GridColumn TongTien;
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