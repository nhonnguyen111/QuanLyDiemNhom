namespace QuanLyDiemNhom
{
    partial class ChonThaoTacXoa
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
            this.btnxoahet = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa1phan = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnxoahet
            // 
            this.btnxoahet.Location = new System.Drawing.Point(214, 27);
            this.btnxoahet.Name = "btnxoahet";
            this.btnxoahet.Size = new System.Drawing.Size(112, 34);
            this.btnxoahet.TabIndex = 0;
            this.btnxoahet.Text = "Xóa hết thiết bị";
            this.btnxoahet.Click += new System.EventHandler(this.btnxoahet_Click);
            // 
            // btnxoa1phan
            // 
            this.btnxoa1phan.Location = new System.Drawing.Point(60, 27);
            this.btnxoa1phan.Name = "btnxoa1phan";
            this.btnxoa1phan.Size = new System.Drawing.Size(112, 34);
            this.btnxoa1phan.TabIndex = 1;
            this.btnxoa1phan.Text = "Xóa một phần";
            this.btnxoa1phan.Click += new System.EventHandler(this.btnxoa1phan_Click);
            // 
            // ChonThaoTacXoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 100);
            this.Controls.Add(this.btnxoa1phan);
            this.Controls.Add(this.btnxoahet);
            this.Name = "ChonThaoTacXoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnxoahet;
        private DevExpress.XtraEditors.SimpleButton btnxoa1phan;
    }
}