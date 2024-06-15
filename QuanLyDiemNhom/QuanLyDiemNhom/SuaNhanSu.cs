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
    public partial class SuaNhanSu : DevExpress.XtraEditors.XtraForm
    {
        private int iduser;
        private int idquyen;
        public SuaNhanSu(int iduser, int idquyen)
        {
            InitializeComponent();
            LoadComBoBoxQuyen();
            this.iduser = iduser;
            this.idquyen = idquyen;
            string tenquyen = "";
            if(idquyen == 1 )
            {
                tenquyen = "Quản trị";

            }
            if (idquyen == 2)
            {
                tenquyen = "Quản lý";

            }
            this.cbquyen.Text = tenquyen;
        }
        void LoadComBoBoxQuyen()
        {
            DataTable dataTable = TaiKhoanDAO.Instance.GetQuyen();
            cbquyen.Properties.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                string hoten = row["TenQuyen"].ToString();
                cbquyen.Properties.Items.Add(hoten);

            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string tenquyen = cbquyen.Text;
            if (tenquyen == "Quản trị")
            {
                idquyen = 1;
            }
            if (tenquyen == "Quản lý")
            {
                idquyen = 2;
            }
            if (TaiKhoanDAO.Instance.UpdateQuyenTaiKhoan(idquyen, iduser))
            {
                MessageBox.Show("Cập nhật quyền thành công");
                this.Close();

            }
            else
            {
                MessageBox.Show("Cập nhật quyền thất bại");

            }
        }
    }
}