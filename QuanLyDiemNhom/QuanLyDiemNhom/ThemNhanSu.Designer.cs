namespace QuanLyDiemNhom
{
    partial class ThemNhanSu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemNhanSu));
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.cbhoten = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbquyen = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpasss = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txttendangnhap = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.lbtitle = new System.Windows.Forms.Label();
            this.txtrepass = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cbhoten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbquyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpasss.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttendangnhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrepass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhuy
            // 
            this.btnhuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.ImageOptions.Image")));
            this.btnhuy.Location = new System.Drawing.Point(73, 371);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(109, 40);
            this.btnhuy.TabIndex = 38;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(283, 371);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(109, 40);
            this.btnthem.TabIndex = 37;
            this.btnthem.Text = "Xác nhận";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // cbhoten
            // 
            this.cbhoten.EditValue = "Chọn tín hữu";
            this.cbhoten.Location = new System.Drawing.Point(146, 234);
            this.cbhoten.Name = "cbhoten";
            this.cbhoten.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbhoten.Size = new System.Drawing.Size(246, 22);
            this.cbhoten.TabIndex = 36;
            // 
            // cbquyen
            // 
            this.cbquyen.EditValue = "Chọn quyền";
            this.cbquyen.Location = new System.Drawing.Point(146, 292);
            this.cbquyen.Name = "cbquyen";
            this.cbquyen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbquyen.Size = new System.Drawing.Size(246, 22);
            this.cbquyen.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Họ và tên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Quyền";
            // 
            // txtpasss
            // 
            this.txtpasss.Location = new System.Drawing.Point(146, 123);
            this.txtpasss.Name = "txtpasss";
            this.txtpasss.Size = new System.Drawing.Size(246, 22);
            this.txtpasss.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Mật khẩu";
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Location = new System.Drawing.Point(146, 73);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(246, 22);
            this.txttendangnhap.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tên đăng nhập";
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.Location = new System.Drawing.Point(154, 22);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(153, 24);
            this.lbtitle.TabIndex = 20;
            this.lbtitle.Text = "Thêm nhân sự";
            // 
            // txtrepass
            // 
            this.txtrepass.Location = new System.Drawing.Point(146, 177);
            this.txtrepass.Name = "txtrepass";
            this.txtrepass.Size = new System.Drawing.Size(246, 22);
            this.txtrepass.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nhập lại mật khẩu";
            // 
            // ThemNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 472);
            this.Controls.Add(this.txtrepass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.cbhoten);
            this.Controls.Add(this.cbquyen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtpasss);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttendangnhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbtitle);
            this.Name = "ThemNhanSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhân sự";
            ((System.ComponentModel.ISupportInitialize)(this.cbhoten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbquyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpasss.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttendangnhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrepass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnhuy;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.ComboBoxEdit cbhoten;
        private DevExpress.XtraEditors.ComboBoxEdit cbquyen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtpasss;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txttendangnhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbtitle;
        private DevExpress.XtraEditors.TextEdit txtrepass;
        private System.Windows.Forms.Label label1;
    }
}