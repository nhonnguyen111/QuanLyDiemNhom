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
    public partial class ThemSoQuy : DevExpress.XtraEditors.XtraForm
    {
        private bool isAddingMode;
        private int idso {  get; set; }
        private string tenso { get; set; }
        public ThemSoQuy()
        {
            InitializeComponent();
        }
        public void SetValues(int Idso, string Tenso)
        {
            this.tenso = Tenso;
            this.idso = Idso;
            this.txtten.Text = Tenso;
        }

        public void SetMode(string mode)
        {
            if (mode == "Thêm")
            {
                isAddingMode = true;
                

                this.lbtitle.Text = "Thêm quỹ mới";
            }
            else if (mode == "Sửa")
            {
                isAddingMode = false;
                this.lbtitle.Text = "Sửa sổ quỹ";
            }
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if (isAddingMode)
            {
                string tenso = txtten.Text;
                if (SoQuyDAO.Instance.InsertSoQuy(tenso))
                {
                    MessageBox.Show("Thêm quỹ mới thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm quỹ mới thất bại");
                }
            }
            else
            {
                string tenso = txtten.Text;
                if (SoQuyDAO.Instance.UpdateSoQuy(tenso,idso))
                {
                    MessageBox.Show("Sửa tên quỹ thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa tên quỹ thất bại");
                }
            }
            
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}