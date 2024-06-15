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
    public partial class LoaiThu : DevExpress.XtraEditors.XtraForm
    {
        private bool isAddingMode;
        private int idloaithu {  get; set; }
        private string tenloai {  get; set; }
        public LoaiThu()
        {
            InitializeComponent();
        }
        public void SetValues(int IdLoaiThu, string TenLoaiThu)
        {
            this.idloaithu = IdLoaiThu;
            this.tenloai = TenLoaiThu;
            this.txtten.Text = TenLoaiThu;
        }

        public void SetMode(string mode)
        {
            if (mode == "Thêm")
            {
                isAddingMode = true;


                this.lbtitle.Text = "Thêm loại thu";
            }
            else if (mode == "Sửa")
            {
                isAddingMode = false;
                this.lbtitle.Text = "Sửa loại thu";
            }
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if (isAddingMode)
            {
                string tenloaithu = txtten.Text;
                if (LoaiThuDAO.Instance.InsertLoaiThu(tenloaithu))
                {
                    MessageBox.Show("Thêm loại thu mới thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm loại thu mới thất bại");
                }
            }
            else
            {
                string tenloaithu = txtten.Text;
                if (LoaiThuDAO.Instance.UpdateLoaiThu(tenloaithu, idloaithu))
                {
                    MessageBox.Show("Sửa loại thu thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa loại thu thất bại");
                }
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}