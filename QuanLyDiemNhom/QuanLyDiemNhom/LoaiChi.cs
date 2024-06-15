using DevExpress.XtraEditors;
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
    public partial class LoaiChi : DevExpress.XtraEditors.XtraForm
    {
        private bool isAddingMode;
        private int idloaichi { get; set; }
        private string tenloaichi { get; set; }
        public void SetValues(int IdLoaiChi, string TenLoaiChi)
        {
            this.idloaichi = IdLoaiChi;
            this.tenloaichi = TenLoaiChi;
            this.txtten.Text = TenLoaiChi;
        }

        public void SetMode(string mode)
        {
            if (mode == "Thêm")
            {
                isAddingMode = true;


                this.lbtitle.Text = "Thêm loại chi";
            }
            else if (mode == "Sửa")
            {
                isAddingMode = false;
                this.lbtitle.Text = "Sửa loại chi";
            }
        }
        public LoaiChi()
        {
            InitializeComponent();
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if (isAddingMode)
            {
                string tenloaichi = txtten.Text;
                if (LoaiChiDAO.Instance.InsertLoaiChi(tenloaichi))
                {
                    MessageBox.Show("Thêm loại chi mới thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm loại chi mới thất bại");
                }
            }
            else
            {
                string tenloaichi = txtten.Text;
                if (LoaiChiDAO.Instance.UpdateLoaiChi(tenloaichi,idloaichi))
                {
                    MessageBox.Show("Sửa loại chi thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa loại chi thất bại");
                }
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}