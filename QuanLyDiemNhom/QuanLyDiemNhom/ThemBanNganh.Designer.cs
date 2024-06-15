namespace QuanLyDiemNhom
{
    partial class ThemBanNganh
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
            this.lbtitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttenbannganh = new DevExpress.XtraEditors.TextEdit();
            this.txtthoigian = new DevExpress.XtraEditors.TextEdit();
            this.checkco = new DevExpress.XtraEditors.CheckEdit();
            this.checkkhong = new DevExpress.XtraEditors.CheckEdit();
            this.txthoatdong = new System.Windows.Forms.RichTextBox();
            this.btnhuybo = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txttenbannganh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtthoigian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkkhong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.Location = new System.Drawing.Point(192, 18);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(180, 24);
            this.lbtitle.TabIndex = 0;
            this.lbtitle.Text = "Thêm ban ngành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên ban ngành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hoạt động";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lặp lại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thời gian hoạt động";
            // 
            // txttenbannganh
            // 
            this.txttenbannganh.Location = new System.Drawing.Point(61, 85);
            this.txttenbannganh.Name = "txttenbannganh";
            this.txttenbannganh.Size = new System.Drawing.Size(454, 22);
            this.txttenbannganh.TabIndex = 5;
            // 
            // txtthoigian
            // 
            this.txtthoigian.Location = new System.Drawing.Point(61, 191);
            this.txtthoigian.Name = "txtthoigian";
            this.txtthoigian.Size = new System.Drawing.Size(454, 22);
            this.txtthoigian.TabIndex = 7;
            // 
            // checkco
            // 
            this.checkco.Location = new System.Drawing.Point(177, 124);
            this.checkco.Name = "checkco";
            this.checkco.Properties.Caption = "Có";
            this.checkco.Size = new System.Drawing.Size(48, 24);
            this.checkco.TabIndex = 9;
            // 
            // checkkhong
            // 
            this.checkkhong.Location = new System.Drawing.Point(387, 124);
            this.checkkhong.Name = "checkkhong";
            this.checkkhong.Properties.Caption = "Không";
            this.checkkhong.Size = new System.Drawing.Size(64, 24);
            this.checkkhong.TabIndex = 10;
            // 
            // txthoatdong
            // 
            this.txthoatdong.Location = new System.Drawing.Point(61, 257);
            this.txthoatdong.Name = "txthoatdong";
            this.txthoatdong.Size = new System.Drawing.Size(454, 227);
            this.txthoatdong.TabIndex = 41;
            this.txthoatdong.Text = "";
            // 
            // btnhuybo
            // 
            this.btnhuybo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhuybo.Location = new System.Drawing.Point(129, 506);
            this.btnhuybo.Name = "btnhuybo";
            this.btnhuybo.Size = new System.Drawing.Size(109, 36);
            this.btnhuybo.TabIndex = 42;
            this.btnhuybo.Text = "Hủy bỏ";
            this.btnhuybo.UseVisualStyleBackColor = true;
            this.btnhuybo.Click += new System.EventHandler(this.btnhuybo_Click);
            // 
            // btnsave
            // 
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Location = new System.Drawing.Point(342, 506);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(109, 36);
            this.btnsave.TabIndex = 43;
            this.btnsave.Text = "Xác nhận";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // ThemBanNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 606);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnhuybo);
            this.Controls.Add(this.txthoatdong);
            this.Controls.Add(this.checkkhong);
            this.Controls.Add(this.checkco);
            this.Controls.Add(this.txtthoigian);
            this.Controls.Add(this.txttenbannganh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbtitle);
            this.Name = "ThemBanNganh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm ban ngành";
            ((System.ComponentModel.ISupportInitialize)(this.txttenbannganh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtthoigian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkkhong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txttenbannganh;
        private DevExpress.XtraEditors.TextEdit txtthoigian;
        private DevExpress.XtraEditors.CheckEdit checkco;
        private DevExpress.XtraEditors.CheckEdit checkkhong;
        private System.Windows.Forms.RichTextBox txthoatdong;
        private System.Windows.Forms.Button btnhuybo;
        private System.Windows.Forms.Button btnsave;
    }
}