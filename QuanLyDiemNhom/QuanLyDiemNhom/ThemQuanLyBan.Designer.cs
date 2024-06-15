namespace QuanLyDiemNhom
{
    partial class ThemQuanLyBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemQuanLyBan));
            this.label1 = new System.Windows.Forms.Label();
            this.cbquanly = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnxacnhan = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbquanly.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên quản lý";
            // 
            // cbquanly
            // 
            this.cbquanly.EditValue = "Chọn quản lý";
            this.cbquanly.Location = new System.Drawing.Point(120, 25);
            this.cbquanly.Name = "cbquanly";
            this.cbquanly.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbquanly.Size = new System.Drawing.Size(281, 22);
            this.cbquanly.TabIndex = 1;
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxacnhan.ImageOptions.Image")));
            this.btnxacnhan.Location = new System.Drawing.Point(158, 86);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(105, 41);
            this.btnxacnhan.TabIndex = 2;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // ThemQuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 157);
            this.Controls.Add(this.btnxacnhan);
            this.Controls.Add(this.cbquanly);
            this.Controls.Add(this.label1);
            this.Name = "ThemQuanLyBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm quản lý ban";
            ((System.ComponentModel.ISupportInitialize)(this.cbquanly.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit cbquanly;
        private DevExpress.XtraEditors.SimpleButton btnxacnhan;
    }
}