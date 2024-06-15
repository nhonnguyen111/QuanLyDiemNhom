namespace QuanLyDiemNhom
{
    partial class PhieuThanhLyVatTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuThanhLyVatTu));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnxacnhan = new DevExpress.XtraEditors.SimpleButton();
            this.dtngayban = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsoluong = new DevExpress.XtraEditors.TextEdit();
            this.cbvattu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtnguoiban = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtnoiban = new DevExpress.XtraEditors.TextEdit();
            this.txtsotien = new DevExpress.XtraEditors.TextEdit();
            this.cbsoquy = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngayban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngayban.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbvattu.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnguoiban.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnoiban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsotien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbsoquy.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Người bán";
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
            // btnhuy
            // 
            this.btnhuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.ImageOptions.Image")));
            this.btnhuy.Location = new System.Drawing.Point(140, 150);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(121, 43);
            this.btnhuy.TabIndex = 14;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxacnhan.ImageOptions.Image")));
            this.btnxacnhan.Location = new System.Drawing.Point(292, 150);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(121, 43);
            this.btnxacnhan.TabIndex = 13;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // dtngayban
            // 
            this.dtngayban.EditValue = null;
            this.dtngayban.Location = new System.Drawing.Point(152, 106);
            this.dtngayban.Name = "dtngayban";
            this.dtngayban.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtngayban.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtngayban.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dtngayban.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dtngayban.Size = new System.Drawing.Size(261, 22);
            this.dtngayban.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số tiền bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày bán";
            // 
            // txtsoluong
            // 
            this.txtsoluong.EditValue = "0";
            this.txtsoluong.Location = new System.Drawing.Point(126, 65);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nơi bán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thêm vào quỹ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtnoiban);
            this.panel1.Controls.Add(this.txtnguoiban);
            this.panel1.Controls.Add(this.txtsoluong);
            this.panel1.Controls.Add(this.cbvattu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 208);
            this.panel1.TabIndex = 0;
            // 
            // txtnguoiban
            // 
            this.txtnguoiban.Location = new System.Drawing.Point(126, 106);
            this.txtnguoiban.Name = "txtnguoiban";
            this.txtnguoiban.Size = new System.Drawing.Size(261, 22);
            this.txtnguoiban.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtsotien);
            this.panel2.Controls.Add(this.btnhuy);
            this.panel2.Controls.Add(this.btnxacnhan);
            this.panel2.Controls.Add(this.dtngayban);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cbsoquy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(439, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 208);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 475F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(912, 216);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtnoiban
            // 
            this.txtnoiban.Location = new System.Drawing.Point(126, 148);
            this.txtnoiban.Name = "txtnoiban";
            this.txtnoiban.Size = new System.Drawing.Size(261, 22);
            this.txtnoiban.TabIndex = 9;
            // 
            // txtsotien
            // 
            this.txtsotien.EditValue = "0";
            this.txtsotien.Location = new System.Drawing.Point(152, 27);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsotien.Size = new System.Drawing.Size(261, 22);
            this.txtsotien.TabIndex = 15;
            // 
            // cbsoquy
            // 
            this.cbsoquy.EditValue = "Chọn sổ quỹ";
            this.cbsoquy.Location = new System.Drawing.Point(152, 65);
            this.cbsoquy.Name = "cbsoquy";
            this.cbsoquy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbsoquy.Size = new System.Drawing.Size(261, 22);
            this.cbsoquy.TabIndex = 10;
            // 
            // PhieuThanhLyVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 216);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PhieuThanhLyVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu thanh lý trang thiết bị";
            ((System.ComponentModel.ISupportInitialize)(this.dtngayban.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngayban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbvattu.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnguoiban.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtnoiban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsotien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbsoquy.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnhuy;
        private DevExpress.XtraEditors.SimpleButton btnxacnhan;
        private DevExpress.XtraEditors.DateEdit dtngayban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtsoluong;
        private DevExpress.XtraEditors.ComboBoxEdit cbvattu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtnguoiban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.TextEdit txtnoiban;
        private DevExpress.XtraEditors.TextEdit txtsotien;
        private DevExpress.XtraEditors.ComboBoxEdit cbsoquy;
    }
}