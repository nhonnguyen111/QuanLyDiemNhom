namespace QuanLyDiemNhom
{
    partial class ThemVatTuVaoPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemVatTuVaoPhong));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbvattu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtsoluong = new DevExpress.XtraEditors.TextEdit();
            this.btnsave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbvattu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thiết bị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // cbvattu
            // 
            this.cbvattu.EditValue = "Chọn trang thiết bị";
            this.cbvattu.Location = new System.Drawing.Point(136, 22);
            this.cbvattu.Name = "cbvattu";
            this.cbvattu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbvattu.Size = new System.Drawing.Size(287, 22);
            this.cbvattu.TabIndex = 2;
            // 
            // txtsoluong
            // 
            this.txtsoluong.EditValue = "0";
            this.txtsoluong.Location = new System.Drawing.Point(136, 74);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsoluong.Size = new System.Drawing.Size(287, 22);
            this.txtsoluong.TabIndex = 3;
            // 
            // btnsave
            // 
            this.btnsave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnsave.Location = new System.Drawing.Point(177, 110);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(108, 40);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Xác nhận";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // ThemVatTuVaoPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 165);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.cbvattu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemVatTuVaoPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm trang thiết bị vào phòng";
            ((System.ComponentModel.ISupportInitialize)(this.cbvattu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit cbvattu;
        private DevExpress.XtraEditors.TextEdit txtsoluong;
        private DevExpress.XtraEditors.SimpleButton btnsave;
    }
}