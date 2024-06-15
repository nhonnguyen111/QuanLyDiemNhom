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
    public partial class ChangePass : DevExpress.XtraEditors.XtraForm
    {
        private int iduser;
        public ChangePass(int iduser)
        {
            InitializeComponent();
            this.iduser = iduser;
        }

        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            string matkhaucu = txtpassold.Text;
            string matkhaumoi = txtpassnew.Text;
            string nhaplaimatkhau = txtrepassnew.Text;

            if (TaiKhoanDAO.Instance.CheckPassWordExists(matkhaucu))
            {
                if (matkhaumoi != nhaplaimatkhau || string.IsNullOrEmpty(matkhaumoi))
                {
                    MessageBox.Show("Vui lòng nhập lại mật khẩu");
                }
                else
                {
                    if (TaiKhoanDAO.Instance.UpdateMatKhau(nhaplaimatkhau, iduser))
                    {
                        MessageBox.Show("Thay đổi mật khẩu thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi mật khẩu thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng");

            }
        }
    }
}