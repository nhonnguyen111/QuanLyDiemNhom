namespace QuanLyDiemNhom
{
    partial class NhapSoLuongXoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapSoLuongXoa));
            this.label1 = new System.Windows.Forms.Label();
            this.txtsoluongxoa = new DevExpress.XtraEditors.TextEdit();
            this.btnxacnhan = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluongxoa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng cần xóa";
            // 
            // txtsoluongxoa
            // 
            this.txtsoluongxoa.EditValue = "0";
            this.txtsoluongxoa.Location = new System.Drawing.Point(141, 17);
            this.txtsoluongxoa.Name = "txtsoluongxoa";
            this.txtsoluongxoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsoluongxoa.Size = new System.Drawing.Size(204, 22);
            this.txtsoluongxoa.TabIndex = 1;
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnxacnhan.Location = new System.Drawing.Point(128, 69);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(109, 40);
            this.btnxacnhan.TabIndex = 2;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // NhapSoLuongXoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 131);
            this.Controls.Add(this.btnxacnhan);
            this.Controls.Add(this.txtsoluongxoa);
            this.Controls.Add(this.label1);
            this.Name = "NhapSoLuongXoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluongxoa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtsoluongxoa;
        private DevExpress.XtraEditors.SimpleButton btnxacnhan;
    }
}