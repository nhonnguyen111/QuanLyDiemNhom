namespace QuanLyDiemNhom
{
    partial class CapNhatTinhTrangVatTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapNhatTinhTrangVatTu));
            this.label1 = new System.Windows.Forms.Label();
            this.cbtinhtrang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnxacnhan = new DevExpress.XtraEditors.SimpleButton();
            this.lbsoluong = new System.Windows.Forms.Label();
            this.txtsoluonghu = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtinhtrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluonghu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tình trạng";
            // 
            // cbtinhtrang
            // 
            this.cbtinhtrang.EditValue = "Chọn tình trạng";
            this.cbtinhtrang.Location = new System.Drawing.Point(140, 61);
            this.cbtinhtrang.Name = "cbtinhtrang";
            this.cbtinhtrang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbtinhtrang.Properties.Items.AddRange(new object[] {
            "Đang hoạt động",
            "Hư hỏng",
            "Ngừng hoạt động"});
            this.cbtinhtrang.Size = new System.Drawing.Size(229, 22);
            this.cbtinhtrang.TabIndex = 1;
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnxacnhan.Location = new System.Drawing.Point(157, 104);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(100, 42);
            this.btnxacnhan.TabIndex = 2;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // lbsoluong
            // 
            this.lbsoluong.AutoSize = true;
            this.lbsoluong.Location = new System.Drawing.Point(31, 20);
            this.lbsoluong.Name = "lbsoluong";
            this.lbsoluong.Size = new System.Drawing.Size(97, 16);
            this.lbsoluong.TabIndex = 3;
            this.lbsoluong.Text = "Số thiết bị hỏng";
            // 
            // txtsoluonghu
            // 
            this.txtsoluonghu.EditValue = "0";
            this.txtsoluonghu.Location = new System.Drawing.Point(140, 20);
            this.txtsoluonghu.Name = "txtsoluonghu";
            this.txtsoluonghu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsoluonghu.Size = new System.Drawing.Size(229, 22);
            this.txtsoluonghu.TabIndex = 4;
            // 
            // CapNhatTinhTrangVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 158);
            this.Controls.Add(this.txtsoluonghu);
            this.Controls.Add(this.lbsoluong);
            this.Controls.Add(this.btnxacnhan);
            this.Controls.Add(this.cbtinhtrang);
            this.Controls.Add(this.label1);
            this.Name = "CapNhatTinhTrangVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.cbtinhtrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluonghu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit cbtinhtrang;
        private DevExpress.XtraEditors.SimpleButton btnxacnhan;
        private System.Windows.Forms.Label lbsoluong;
        private DevExpress.XtraEditors.TextEdit txtsoluonghu;
    }
}