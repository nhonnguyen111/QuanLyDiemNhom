namespace QuanLyDiemNhom
{
    partial class ChangePass
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btndoimatkhau = new DevExpress.XtraEditors.SimpleButton();
            this.txtpassold = new System.Windows.Forms.TextBox();
            this.txtpassnew = new System.Windows.Forms.TextBox();
            this.txtrepassnew = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // btndoimatkhau
            // 
            this.btndoimatkhau.Location = new System.Drawing.Point(193, 190);
            this.btndoimatkhau.Name = "btndoimatkhau";
            this.btndoimatkhau.Size = new System.Drawing.Size(159, 37);
            this.btndoimatkhau.TabIndex = 6;
            this.btndoimatkhau.Text = "Đổi mật khẩu";
            this.btndoimatkhau.Click += new System.EventHandler(this.btndoimatkhau_Click);
            // 
            // txtpassold
            // 
            this.txtpassold.Location = new System.Drawing.Point(224, 31);
            this.txtpassold.Name = "txtpassold";
            this.txtpassold.Size = new System.Drawing.Size(276, 23);
            this.txtpassold.TabIndex = 7;
            this.txtpassold.UseSystemPasswordChar = true;
            // 
            // txtpassnew
            // 
            this.txtpassnew.Location = new System.Drawing.Point(224, 94);
            this.txtpassnew.Name = "txtpassnew";
            this.txtpassnew.Size = new System.Drawing.Size(276, 23);
            this.txtpassnew.TabIndex = 8;
            this.txtpassnew.UseSystemPasswordChar = true;
            // 
            // txtrepassnew
            // 
            this.txtrepassnew.Location = new System.Drawing.Point(224, 147);
            this.txtrepassnew.Name = "txtrepassnew";
            this.txtrepassnew.Size = new System.Drawing.Size(276, 23);
            this.txtrepassnew.TabIndex = 9;
            this.txtrepassnew.UseSystemPasswordChar = true;
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 249);
            this.Controls.Add(this.txtrepassnew);
            this.Controls.Add(this.txtpassnew);
            this.Controls.Add(this.txtpassold);
            this.Controls.Add(this.btndoimatkhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btndoimatkhau;
        private System.Windows.Forms.TextBox txtpassold;
        private System.Windows.Forms.TextBox txtpassnew;
        private System.Windows.Forms.TextBox txtrepassnew;
    }
}