namespace QuanLyDiemNhom
{
    partial class PhieuXuatVatTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuXuatVatTu));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtmasophieu = new System.Windows.Forms.TextBox();
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnxacnhan = new DevExpress.XtraEditors.SimpleButton();
            this.dtngayxuat = new DevExpress.XtraEditors.DateEdit();
            this.txtngnhan = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtnguoixuat = new System.Windows.Forms.TextBox();
            this.txtnoidung = new DevExpress.XtraEditors.TextEdit();
            this.txtsoluong = new DevExpress.XtraEditors.TextEdit();
            this.cbvattu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtngayxuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngayxuat.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngnhan.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnoidung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbvattu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 428F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(860, 257);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtmasophieu);
            this.panel2.Controls.Add(this.btnhuy);
            this.panel2.Controls.Add(this.btnxacnhan);
            this.panel2.Controls.Add(this.dtngayxuat);
            this.panel2.Controls.Add(this.txtngnhan);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(434, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 249);
            this.panel2.TabIndex = 1;
            // 
            // txtmasophieu
            // 
            this.txtmasophieu.Location = new System.Drawing.Point(130, 26);
            this.txtmasophieu.Name = "txtmasophieu";
            this.txtmasophieu.ReadOnly = true;
            this.txtmasophieu.Size = new System.Drawing.Size(261, 23);
            this.txtmasophieu.TabIndex = 15;
            // 
            // btnhuy
            // 
            this.btnhuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.ImageOptions.Image")));
            this.btnhuy.Location = new System.Drawing.Point(114, 187);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(121, 43);
            this.btnhuy.TabIndex = 14;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxacnhan.ImageOptions.Image")));
            this.btnxacnhan.Location = new System.Drawing.Point(270, 187);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(121, 43);
            this.btnxacnhan.TabIndex = 13;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // dtngayxuat
            // 
            this.dtngayxuat.EditValue = null;
            this.dtngayxuat.Location = new System.Drawing.Point(130, 129);
            this.dtngayxuat.Name = "dtngayxuat";
            this.dtngayxuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtngayxuat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtngayxuat.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dtngayxuat.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dtngayxuat.Size = new System.Drawing.Size(261, 22);
            this.dtngayxuat.TabIndex = 11;
            // 
            // txtngnhan
            // 
            this.txtngnhan.Location = new System.Drawing.Point(130, 78);
            this.txtngnhan.Name = "txtngnhan";
            this.txtngnhan.Size = new System.Drawing.Size(261, 22);
            this.txtngnhan.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã số phiếu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày xuất";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Người nhận";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtnguoixuat);
            this.panel1.Controls.Add(this.txtnoidung);
            this.panel1.Controls.Add(this.txtsoluong);
            this.panel1.Controls.Add(this.cbvattu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 249);
            this.panel1.TabIndex = 0;
            // 
            // txtnguoixuat
            // 
            this.txtnguoixuat.Location = new System.Drawing.Point(126, 132);
            this.txtnguoixuat.Name = "txtnguoixuat";
            this.txtnguoixuat.ReadOnly = true;
            this.txtnguoixuat.Size = new System.Drawing.Size(261, 23);
            this.txtnguoixuat.TabIndex = 16;
            // 
            // txtnoidung
            // 
            this.txtnoidung.Location = new System.Drawing.Point(126, 184);
            this.txtnoidung.Name = "txtnoidung";
            this.txtnoidung.Size = new System.Drawing.Size(261, 22);
            this.txtnoidung.TabIndex = 8;
            // 
            // txtsoluong
            // 
            this.txtsoluong.EditValue = "0";
            this.txtsoluong.Location = new System.Drawing.Point(126, 81);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(261, 22);
            this.txtsoluong.TabIndex = 6;
            // 
            // cbvattu
            // 
            this.cbvattu.EditValue = "Chọn thiết bị";
            this.cbvattu.Location = new System.Drawing.Point(126, 27);
            this.cbvattu.Name = "cbvattu";
            this.cbvattu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbvattu.Size = new System.Drawing.Size(261, 22);
            this.cbvattu.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nơi dùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Người xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thiết bị";
            // 
            // PhieuXuatVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 257);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PhieuXuatVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu cung cấp vật tư";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtngayxuat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngayxuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngnhan.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnoidung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbvattu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnhuy;
        private DevExpress.XtraEditors.SimpleButton btnxacnhan;
        private DevExpress.XtraEditors.DateEdit dtngayxuat;
        private DevExpress.XtraEditors.TextEdit txtngnhan;
        private DevExpress.XtraEditors.TextEdit txtnoidung;
        private DevExpress.XtraEditors.TextEdit txtsoluong;
        private DevExpress.XtraEditors.ComboBoxEdit cbvattu;
        private System.Windows.Forms.TextBox txtmasophieu;
        private System.Windows.Forms.TextBox txtnguoixuat;
    }
}