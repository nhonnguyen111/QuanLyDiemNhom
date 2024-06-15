namespace QuanLyDiemNhom
{
    partial class ThemKhoaHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemKhoaHoc));
            this.lbtitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttenkhoahoc = new DevExpress.XtraEditors.TextEdit();
            this.cbgiaovien = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtbatdau = new System.Windows.Forms.DateTimePicker();
            this.dtketthuc = new System.Windows.Forms.DateTimePicker();
            this.btnxacnhan = new DevExpress.XtraEditors.SimpleButton();
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.cbthoigian = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.cbtinhtrang = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenkhoahoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbgiaovien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbthoigian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtinhtrang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.Location = new System.Drawing.Point(160, 19);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(163, 24);
            this.lbtitle.TabIndex = 0;
            this.lbtitle.Text = "Thêm khóa học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khóa học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giáo viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày kết thúc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tình trạng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thời gian học";
            // 
            // txttenkhoahoc
            // 
            this.txttenkhoahoc.Location = new System.Drawing.Point(140, 73);
            this.txttenkhoahoc.Name = "txttenkhoahoc";
            this.txttenkhoahoc.Size = new System.Drawing.Size(309, 22);
            this.txttenkhoahoc.TabIndex = 7;
            // 
            // cbgiaovien
            // 
            this.cbgiaovien.EditValue = "Chọn giáo viên";
            this.cbgiaovien.Location = new System.Drawing.Point(140, 130);
            this.cbgiaovien.Name = "cbgiaovien";
            this.cbgiaovien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbgiaovien.Size = new System.Drawing.Size(309, 22);
            this.cbgiaovien.TabIndex = 8;
            // 
            // dtbatdau
            // 
            this.dtbatdau.Location = new System.Drawing.Point(140, 184);
            this.dtbatdau.Name = "dtbatdau";
            this.dtbatdau.Size = new System.Drawing.Size(309, 23);
            this.dtbatdau.TabIndex = 9;
            this.dtbatdau.ValueChanged += new System.EventHandler(this.Dtbatdau_ValueChanged);
            // 
            // dtketthuc
            // 
            this.dtketthuc.Location = new System.Drawing.Point(140, 248);
            this.dtketthuc.Name = "dtketthuc";
            this.dtketthuc.Size = new System.Drawing.Size(309, 23);
            this.dtketthuc.TabIndex = 10;
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxacnhan.ImageOptions.Image")));
            this.btnxacnhan.Location = new System.Drawing.Point(284, 431);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(108, 44);
            this.btnxacnhan.TabIndex = 14;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.ImageOptions.Image")));
            this.btnhuy.Location = new System.Drawing.Point(103, 431);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(108, 44);
            this.btnhuy.TabIndex = 15;
            this.btnhuy.Text = "Hủy";
            // 
            // cbthoigian
            // 
            this.cbthoigian.EditValue = "Chọn thời gian học";
            this.cbthoigian.Location = new System.Drawing.Point(140, 374);
            this.cbthoigian.Name = "cbthoigian";
            this.cbthoigian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbthoigian.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Thứ hai"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Thứ ba"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Thứ tư"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Thứ năm"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Thứ sáu"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Thứ bảy"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Chủ nhật", "", "Chủ nhật")});
            this.cbthoigian.Size = new System.Drawing.Size(309, 22);
            this.cbthoigian.TabIndex = 16;
            // 
            // cbtinhtrang
            // 
            this.cbtinhtrang.EditValue = "Chọn tình trạng khóa học";
            this.cbtinhtrang.Location = new System.Drawing.Point(140, 311);
            this.cbtinhtrang.Name = "cbtinhtrang";
            this.cbtinhtrang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbtinhtrang.Properties.Items.AddRange(new object[] {
            "Đang hoạt động",
            "Tạm ngưng"});
            this.cbtinhtrang.Size = new System.Drawing.Size(309, 22);
            this.cbtinhtrang.TabIndex = 17;
            // 
            // ThemKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 505);
            this.Controls.Add(this.cbtinhtrang);
            this.Controls.Add(this.cbthoigian);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnxacnhan);
            this.Controls.Add(this.dtketthuc);
            this.Controls.Add(this.dtbatdau);
            this.Controls.Add(this.cbgiaovien);
            this.Controls.Add(this.txttenkhoahoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbtitle);
            this.Name = "ThemKhoaHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm khóa học";
            ((System.ComponentModel.ISupportInitialize)(this.txttenkhoahoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbgiaovien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbthoigian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtinhtrang.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txttenkhoahoc;
        private DevExpress.XtraEditors.ComboBoxEdit cbgiaovien;
        private System.Windows.Forms.DateTimePicker dtbatdau;
        private System.Windows.Forms.DateTimePicker dtketthuc;
        private DevExpress.XtraEditors.SimpleButton btnxacnhan;
        private DevExpress.XtraEditors.SimpleButton btnhuy;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbthoigian;
        private DevExpress.XtraEditors.ComboBoxEdit cbtinhtrang;
    }
}