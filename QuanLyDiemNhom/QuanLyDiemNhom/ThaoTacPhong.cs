using DevExpress.XtraEditors;
using QuanLyDiemNhom.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemNhom
{
    public partial class ThaoTacPhong : DevExpress.XtraEditors.XtraForm
    {
        private bool isAddingMode;
        private int idphongban {  get; set; }
        private string tenphong {  get; set; }
        public void SetValues(int idphong, string ten)
        {
            this.idphongban = idphong;
            this.tenphong = ten;
            this.txtphong.Text = ten;
        }

        public void SetMode(string mode)
        {
            if (mode == "Thêm")
            {
                isAddingMode = true;

                txtphong.Text = "";
                this.lbtitle.Text = "Thêm phòng";
            }
            else if (mode == "Sửa")
            {
                isAddingMode = false;
                this.lbtitle.Text = "Sửa phòng";
            }
        }

        public ThaoTacPhong()
        {
            InitializeComponent();
        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
           if(isAddingMode)
            {
                string tenphong = txtphong.Text;
                if (PhongBanDAO.Instance.InsertPhongBan(tenphong))
                {
                    MessageBox.Show("Thêm phòng thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm phòng thất bại");
                }
            }
            else
            {
                string tenphong = txtphong.Text;
                if (PhongBanDAO.Instance.UpdatetPhongBan(tenphong, idphongban))
                {
                    MessageBox.Show("Sửa phòng thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa phòng thất bại");
                }
            }
        }
    }
}