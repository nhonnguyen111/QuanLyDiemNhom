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
    public partial class ThemVatTu : DevExpress.XtraEditors.XtraForm
    {
        private bool isAddingMode;
        private int idvattu { get; set; }
        private string tenvattu { get; set; }
        private int soluong { get; set; }
        private string dvt {  get; set; }
        public void SetValues(int IdVatTu, string TenVatTu, int SoLuong, string DVT)
        {
            this.idvattu = IdVatTu;
            this.tenvattu = TenVatTu;   
            this.soluong = SoLuong;
            this.dvt = DVT;
            this.txttenvattu.Text = TenVatTu;
            this.txtsoluong.Text = SoLuong.ToString();
            this.cbdvt.Text = DVT;
        }

        public void SetMode(string mode)
        {
            if (mode == "Thêm")
            {
                isAddingMode = true;
                this.txttenvattu.Text = "";
                this.txtsoluong.Text = "0";
                
                this.lbtitle.Text = "Thêm trang thiết bị";
            }
            else if (mode == "Sửa")
            {
                isAddingMode = false;
                this.lbtitle.Text = "Sửa trang thiết bị";
            }
        }
        public ThemVatTu()
        {
            InitializeComponent();
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if (isAddingMode)
            {
                string tenvattu = txttenvattu.Text;
                int soluong = int.Parse(txtsoluong.Text);
                string dvt = cbdvt.Text;
                if (VatTuDAO.Instance.InsertVatTu(tenvattu, soluong, dvt))
                {
                    MessageBox.Show("Thêm trang thiết bị mới thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm trang thiết bị mới thất bại");
                }
            }
            else
            {
                string tenvattu = txttenvattu.Text;
                int soluong = int.Parse(txtsoluong.Text);
                string dvt = cbdvt.Text;
                if (VatTuDAO.Instance.UpdatetVatTu(tenvattu, soluong, dvt,idvattu))
                {
                    MessageBox.Show("Sửa trang thiết bị thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa trang thiết bị thất bại");
                }
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}