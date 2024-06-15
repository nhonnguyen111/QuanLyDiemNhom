using DevExpress.XtraBars;
using QuanLyDiemNhom.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyDiemNhom
{
    public partial class DashboardQuanLy : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int idbannganh;
        private int idkhoahoc;
        public DashboardQuanLy(TaiKhoan acc)
        {
            InitializeComponent();
            InitializeFormCreators();
            this.loginAccount = acc;
        }
        private TaiKhoan loginAccount;
        public TaiKhoan LoginAccount
        {
            get => loginAccount;
            set
            {
                loginAccount = value;
                ChangAccount(loginAccount.Iduser);

            }
        }
        private Dictionary<Type, Func<Form>> formCreators;

        private void InitializeFormCreators()
        {

            formCreators = new Dictionary<Type, Func<Form>>
            {
                { typeof(ChiTietBanNganhQuanLy), () => new ChiTietBanNganhQuanLy(idbannganh) },
                { typeof(DSBanNganhQuanLy), () => new DSBanNganhQuanLy(loginAccount.Iduser, this) },
                { typeof(ChiTietKhoaHoc), () => new ChiTietKhoaHoc(idkhoahoc, loginAccount.Email) },
            };
        }
        public void OpenChiTietKhoaHocQuanLy(int idkhoahoc)
        {
            this.idkhoahoc = idkhoahoc;
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(ChiTietKhoaHoc))
                {
                    frm.Activate();
                    return;
                }
            }
            ChiTietKhoaHoc chiTiet = new ChiTietKhoaHoc(idkhoahoc, loginAccount.Email);
            chiTiet.MdiParent = this;
            chiTiet.Show();
        }
        public void OpenChiTietBanNganh(int idban)
        {
            this.idbannganh = idban;
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(ChiTietBanNganhQuanLy))
                {
                    frm.Activate();
                    return;
                }
            }
            ChiTietBanNganhQuanLy chiTietBanNganh = new ChiTietBanNganhQuanLy(idban);
            chiTietBanNganh.MdiParent = this;
            chiTietBanNganh.Show();
        }
        void ChangAccount(int iduser)
        {

        }

        private void btnprofile_ItemClick(object sender, ItemClickEventArgs e)
        {
            Profile profile = new Profile(loginAccount.Iduser, loginAccount.Hoten, loginAccount.Sdt, loginAccount.Email, loginAccount.Khuvuc, loginAccount.Gioitinh, loginAccount.Diachi);
            profile.ShowDialog();
        }

        private void btndoimatkhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangePass changePass = new ChangePass(loginAccount.Iduser);
            changePass.ShowDialog();
        }

        private void btndangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Bạn có muốn đăng xuất khỏi chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            this.Close();
        }

        private void btndsbannganh_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(DSBanNganhQuanLy))
                {
                    frm.Activate();
                    return;
                }
            }
            DSBanNganhQuanLy dSBanNganhQuan = new DSBanNganhQuanLy(loginAccount.Iduser , this);
            dSBanNganhQuan.MdiParent = this;
            dSBanNganhQuan.Show();
        }

        private void btndskhoahoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(DSKhoaHocQuanLy))
                {
                    frm.Activate();
                    return;
                }
            }
            DSKhoaHocQuanLy dSBanNganhQuan = new DSKhoaHocQuanLy(loginAccount.Iduser, this);
            dSBanNganhQuan.MdiParent = this;
            dSBanNganhQuan.Show();
        }
    }
}