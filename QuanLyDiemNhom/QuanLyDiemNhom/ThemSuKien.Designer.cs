using System.Windows.Forms;

namespace QuanLyDiemNhom
{
    partial class ThemSuKien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button btnSave;
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttensukien = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnoidung = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timedienra = new DevExpress.XtraEditors.TimeEdit();
            this.timeketthuc = new DevExpress.XtraEditors.TimeEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtvitri = new DevExpress.XtraEditors.TextEdit();
            this.cbbannganh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnhuy = new System.Windows.Forms.Button();
            this.dtngaydienra = new System.Windows.Forms.DateTimePicker();
            this.dtngayketthuc = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.txttensukien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timedienra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeketthuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvitri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbannganh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(337, 384);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Thêm";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thêm sự kiện mới";
            // 
            // txttensukien
            // 
            this.txttensukien.Location = new System.Drawing.Point(119, 55);
            this.txttensukien.Name = "txttensukien";
            this.txttensukien.Size = new System.Drawing.Size(401, 22);
            this.txttensukien.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên sự kiện";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nội dung";
            // 
            // txtnoidung
            // 
            this.txtnoidung.Location = new System.Drawing.Point(119, 100);
            this.txtnoidung.Name = "txtnoidung";
            this.txtnoidung.Size = new System.Drawing.Size(401, 106);
            this.txtnoidung.TabIndex = 8;
            this.txtnoidung.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày diễn ra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày kết thúc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Giờ diễn ra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Giờ kết thúc";
            // 
            // timedienra
            // 
            this.timedienra.EditValue = new System.DateTime(2024, 6, 10, 0, 0, 0, 0);
            this.timedienra.Location = new System.Drawing.Point(379, 214);
            this.timedienra.Name = "timedienra";
            this.timedienra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timedienra.Size = new System.Drawing.Size(141, 24);
            this.timedienra.TabIndex = 15;
            // 
            // timeketthuc
            // 
            this.timeketthuc.EditValue = new System.DateTime(2024, 6, 10, 0, 0, 0, 0);
            this.timeketthuc.Location = new System.Drawing.Point(379, 254);
            this.timeketthuc.Name = "timeketthuc";
            this.timeketthuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeketthuc.Size = new System.Drawing.Size(141, 24);
            this.timeketthuc.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nơi diễn ra";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Đội phụ trách";
            // 
            // txtvitri
            // 
            this.txtvitri.Location = new System.Drawing.Point(119, 301);
            this.txtvitri.Name = "txtvitri";
            this.txtvitri.Size = new System.Drawing.Size(401, 22);
            this.txtvitri.TabIndex = 19;
            // 
            // cbbannganh
            // 
            this.cbbannganh.EditValue = "Chọn đội phụ trách";
            this.cbbannganh.Location = new System.Drawing.Point(119, 340);
            this.cbbannganh.Name = "cbbannganh";
            this.cbbannganh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbannganh.Size = new System.Drawing.Size(401, 22);
            this.cbbannganh.TabIndex = 20;
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(163, 384);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(88, 28);
            this.btnhuy.TabIndex = 21;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            // 
            // dtngaydienra
            // 
            this.dtngaydienra.Location = new System.Drawing.Point(119, 215);
            this.dtngaydienra.Name = "dtngaydienra";
            this.dtngaydienra.Size = new System.Drawing.Size(178, 23);
            this.dtngaydienra.TabIndex = 22;
            // 
            // dtngayketthuc
            // 
            this.dtngayketthuc.Location = new System.Drawing.Point(119, 259);
            this.dtngayketthuc.Name = "dtngayketthuc";
            this.dtngayketthuc.Size = new System.Drawing.Size(178, 23);
            this.dtngayketthuc.TabIndex = 23;
            // 
            // ThemSuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 441);
            this.Controls.Add(this.dtngayketthuc);
            this.Controls.Add(this.dtngaydienra);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.cbbannganh);
            this.Controls.Add(this.txtvitri);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timeketthuc);
            this.Controls.Add(this.timedienra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnoidung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttensukien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThemSuKien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Event";
            ((System.ComponentModel.ISupportInitialize)(this.txttensukien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timedienra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeketthuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvitri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbannganh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DevExpress.XtraEditors.TextEdit txttensukien;
        private Label label2;
        private Label label3;
        private RichTextBox txtnoidung;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DevExpress.XtraEditors.TimeEdit timedienra;
        private DevExpress.XtraEditors.TimeEdit timeketthuc;
        private Label label8;
        private Label label9;
        private DevExpress.XtraEditors.TextEdit txtvitri;
        private DevExpress.XtraEditors.ComboBoxEdit cbbannganh;
        private Button btnhuy;
        private DateTimePicker dtngaydienra;
        private DateTimePicker dtngayketthuc;
    }
}