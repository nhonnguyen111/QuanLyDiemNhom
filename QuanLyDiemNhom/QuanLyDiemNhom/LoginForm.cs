using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Layout;
using QuanLyDiemNhom.DAO;
using QuanLyDiemNhom.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyDiemNhom
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {

            string username = txttaikhoan.Text;
            string password = txtmatkhau.Text;
            if (Login(username, password))
            {
                int idChucVu = TaiKhoanDAO.Instance.GetIdChucVuByUserName(username);
                TaiKhoan loginaccount = TaiKhoanDAO.Instance.GetAccountByUserName(username);

                this.Hide();
                Form homeForm;
                switch (idChucVu)
                {
                    case 1:
                        homeForm = new Dashboard(loginaccount);
                        break;
                    case 2:
                        homeForm = new DashboardQuanLy(loginaccount);
                        break;
                    
                    default:
                        MessageBox.Show("Chức vụ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Show();
                        return;
                }

                homeForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc Mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool Login(string UserName, string PassWord)
        {
            return TaiKhoanDAO.Instance.Login(UserName, PassWord);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}