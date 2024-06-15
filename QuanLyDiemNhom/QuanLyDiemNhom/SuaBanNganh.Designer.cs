namespace QuanLyDiemNhom
{
    partial class SuaBanNganh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaBanNganh));
            this.txthoatdong = new System.Windows.Forms.RichTextBox();
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.checkkhong = new DevExpress.XtraEditors.CheckEdit();
            this.checkco = new DevExpress.XtraEditors.CheckEdit();
            this.txtthoigian = new DevExpress.XtraEditors.TextEdit();
            this.txttenbannganh = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbtitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.checkkhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtthoigian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenbannganh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txthoatdong
            // 
            this.txthoatdong.Location = new System.Drawing.Point(54, 256);
            this.txthoatdong.Name = "txthoatdong";
            this.txthoatdong.Size = new System.Drawing.Size(454, 227);
            this.txthoatdong.TabIndex = 53;
            this.txthoatdong.Text = "";
            // 
            // btnhuy
            // 
            this.btnhuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.ImageOptions.Image")));
            this.btnhuy.Location = new System.Drawing.Point(125, 503);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(109, 40);
            this.btnhuy.TabIndex = 52;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(335, 503);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(109, 40);
            this.btnthem.TabIndex = 51;
            this.btnthem.Text = "Xác nhận";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // checkkhong
            // 
            this.checkkhong.Location = new System.Drawing.Point(251, 125);
            this.checkkhong.Name = "checkkhong";
            this.checkkhong.Properties.Caption = "Không";
            this.checkkhong.Size = new System.Drawing.Size(94, 24);
            this.checkkhong.TabIndex = 50;
            // 
            // checkco
            // 
            this.checkco.Location = new System.Drawing.Point(140, 125);
            this.checkco.Name = "checkco";
            this.checkco.Properties.Caption = "Có";
            this.checkco.Size = new System.Drawing.Size(94, 24);
            this.checkco.TabIndex = 49;
            // 
            // txtthoigian
            // 
            this.txtthoigian.Location = new System.Drawing.Point(54, 190);
            this.txtthoigian.Name = "txtthoigian";
            this.txtthoigian.Size = new System.Drawing.Size(454, 22);
            this.txtthoigian.TabIndex = 48;
            // 
            // txttenbannganh
            // 
            this.txttenbannganh.Location = new System.Drawing.Point(54, 84);
            this.txttenbannganh.Name = "txttenbannganh";
            this.txttenbannganh.Size = new System.Drawing.Size(454, 22);
            this.txttenbannganh.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Thời gian hoạt động";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Lặp lại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Hoạt động";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Tên ban ngành";
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.Location = new System.Drawing.Point(185, 17);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(163, 24);
            this.lbtitle.TabIndex = 42;
            this.lbtitle.Text = "Sửa ban ngành";
            // 
            // SuaBanNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 564);
            this.Controls.Add(this.txthoatdong);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.checkkhong);
            this.Controls.Add(this.checkco);
            this.Controls.Add(this.txtthoigian);
            this.Controls.Add(this.txttenbannganh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbtitle);
            this.Name = "SuaBanNganh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa ban ngành";
            ((System.ComponentModel.ISupportInitialize)(this.checkkhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtthoigian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenbannganh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txthoatdong;
        private DevExpress.XtraEditors.SimpleButton btnhuy;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.CheckEdit checkkhong;
        private DevExpress.XtraEditors.CheckEdit checkco;
        private DevExpress.XtraEditors.TextEdit txtthoigian;
        private DevExpress.XtraEditors.TextEdit txttenbannganh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbtitle;
    }
}