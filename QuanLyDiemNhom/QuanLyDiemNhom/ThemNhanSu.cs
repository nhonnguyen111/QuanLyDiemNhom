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
    public partial class ThemNhanSu : DevExpress.XtraEditors.XtraForm
    {
        public ThemNhanSu()
        {
            InitializeComponent();
            LoadComBoBoxThanhVien();
            LoadComBoBoxQuyen();
        }
        void LoadComBoBoxThanhVien()
        {
            DataTable dataTable = ThanhVienDAO.Instance.GetThanhVien();
            cbhoten.Properties.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                string hoten = row["hoten"].ToString();
                cbhoten.Properties.Items.Add(hoten);
            }
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            string taikhoan =  txttendangnhap.Text;
            string matkhau = txtpasss.Text;
            string nhaplaimatkhau = txtrepass.Text;
            string hoten =  cbhoten.Text;
            string tenquyen =  cbquyen.Text;
            int idquyen = 0;
            if(tenquyen == "Quản trị")
            {
                idquyen = 1;
            }
            if (tenquyen == "Quản lý")
            {
                idquyen = 2;
            }
            if (TaiKhoanDAO.Instance.CheckUsernameExists(taikhoan))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại trên hệ thống");
            }
            else
            {
                if (matkhau != nhaplaimatkhau)
                {
                    MessageBox.Show("Vui lòng xem lại mật khẩu");
                }
                else
                {
                    if (string.IsNullOrEmpty(taikhoan) || string.IsNullOrEmpty(matkhau) || string.IsNullOrEmpty(nhaplaimatkhau))
                    {
                        MessageBox.Show("Kiểm tra lại thông tin");
                    }
                    else
                    {
                        if (TaiKhoanDAO.Instance.InsertTaiKhoan(taikhoan, nhaplaimatkhau, hoten, idquyen))
                        {
                            MessageBox.Show("Thêm nhân sự mới thành công");
                            this.Close();
                        }

                        else
                        {
                            MessageBox.Show("Thêm nhân sự mới thất bại");
                        }
                    }
                }
            }
            
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}