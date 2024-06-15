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
    public partial class Profile : DevExpress.XtraEditors.XtraForm
    {
        private int iduser;
        private string name;
        private string sdt;
        private string email;
        private string khuvuc;
        private string diachi;
        private string gioitinh;

        public Profile(int iduser, string name, string sdt, string email, string khuvuc, string gioitinh, string diachi)
        {
            InitializeComponent();
            this.iduser = iduser;
            this.name = name;
            this.sdt = sdt;
            this.email = email;
            this.khuvuc = khuvuc;
            this.diachi = diachi;
            this.gioitinh = gioitinh;

            this.txthoten.Text = name;
            this.txtgmail.Text = email;
            this.txtsdt.Text = sdt;
            this.txtdiachi.Text = diachi;
            this.txtkhuvuc.Text = khuvuc;
            this.cbgioitinh.Text = gioitinh;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            string hoten = txthoten.Text;
            string sdt = txtsdt.Text;
            string email = txtgmail.Text;
            string khuvuc= txtkhuvuc.Text;
            string diachi = txtdiachi.Text;
            string gioitinh = cbgioitinh.Text;
            if (TaiKhoanDAO.Instance.UpdateTaiKhoanCaNhan(hoten,  sdt, diachi, email, khuvuc, gioitinh, iduser))
            {
                MessageBox.Show("Thay đổi thông tin cá nhân thành công");
            }
            else
            {
                MessageBox.Show("Thay đổi thông tin cá nhân thất bại");
            }
        }
    }
}