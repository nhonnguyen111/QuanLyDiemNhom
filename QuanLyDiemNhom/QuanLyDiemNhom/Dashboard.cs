using DevExpress.XtraBars;
using QuanLyDiemNhom.DAO;
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

namespace QuanLyDiemNhom
{
    public partial class Dashboard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int idbannganh;
        private int idkhoahoc;
        public Dashboard(TaiKhoan acc)
        {
            this.loginAccount = acc;
            InitializeComponent();
            InitializeFormCreators();
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(DSTinhuu))
                {
                    frm.Activate();
                    return;
                }
            }
            DSTinhuu formDSNhanSu = new DSTinhuu();
            formDSNhanSu.MdiParent = this;
            formDSNhanSu.Show();
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
        
        void ChangAccount(int iduser)
        {
            
        }
        private Dictionary<Type, Func<Form>> formCreators;

        private void InitializeFormCreators( )
        {
           
            formCreators = new Dictionary<Type, Func<Form>>
            {
                { typeof(ChiTietBanNganh), () => new ChiTietBanNganh(idbannganh, loginAccount.Email) },
                { typeof(DSBanNganh), () => new DSBanNganh(this, loginAccount.Email) },
                { typeof(ChiTietKhoaHoc), () => new ChiTietKhoaHoc(idkhoahoc, loginAccount.Email) },
            };
        }
        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(ChiTietBanNganh))
                {
                    frm.Activate();
                    return;
                }
            }
            ChiTietBanNganh formDSNhanSu = new ChiTietBanNganh(idbannganh, loginAccount.Email);
            formDSNhanSu.MdiParent = this;
            formDSNhanSu.Show();
        }
        public void OpenChiTietBanNganh(int idbannganh,string email)
        {
            this.idbannganh = idbannganh;
            this.loginAccount.Email  =email;
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(ChiTietBanNganh))
                {
                    frm.Activate();
                    return;
                }
            }
            ChiTietBanNganh chiTietBanNganh = new ChiTietBanNganh(idbannganh, email);
            chiTietBanNganh.MdiParent = this;
            chiTietBanNganh.Show();
        }
        public void OpenChiTietKhoaHoc(int idkhoahoc, string email)
        {
            this.idkhoahoc = idkhoahoc;
            this.loginAccount.Email = email;
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(ChiTietKhoaHoc))
                {
                    frm.Activate();
                    return;
                }
            }
            ChiTietKhoaHoc chiTietKhoaHoc = new ChiTietKhoaHoc(idkhoahoc,email);
            chiTietKhoaHoc.MdiParent = this;
            chiTietKhoaHoc.Show();
        }

        void OpenForm(Type typeform)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeform)
                {
                    frm.Activate();
                    return;
                }
            }

            if (formCreators.TryGetValue(typeform, out var creator))
            {
                Form form = creator();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                throw new InvalidOperationException($"No form creator defined for {typeform.FullName}");
            }
        }
        private void btnprofile_ItemClick(object sender, ItemClickEventArgs e)
        {
            Profile profile = new Profile(loginAccount.Iduser, loginAccount.Hoten,loginAccount.Sdt, loginAccount.Email,  loginAccount.Khuvuc, loginAccount.Gioitinh, loginAccount.Diachi);   
            profile.ShowDialog();
        }

        private void btnlogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Bạn có muốn đăng xuất khỏi chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            this.Close();
        }

        private void btnrecentpass_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangePass changePass = new ChangePass(loginAccount.Iduser);
            changePass.ShowDialog();
        }

        private void btntinhuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(DSTinhuu))
                {
                    frm.Activate();
                    return;
                }
            }
            DSTinhuu formDSNhanSu = new DSTinhuu();
            formDSNhanSu.MdiParent = this;
            formDSNhanSu.Show();
          
        }

        private void btnnhansu_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(DSNhanSu))
                {
                    frm.Activate();
                    return;
                }
            }
            DSNhanSu formDSNhanSu = new DSNhanSu(loginAccount.Iduser);
            formDSNhanSu.MdiParent = this;
            formDSNhanSu.Show();
        }

        private void btndsbannganh_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(DSBanNganh))
                {
                    frm.Activate();
                    return;
                }
            }
            DSBanNganh formDSNhanSu = new DSBanNganh(this, loginAccount.Email);
            formDSNhanSu.MdiParent = this;
            formDSNhanSu.Show();
           
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemBanNganh themBanNganh = new ThemBanNganh();
            themBanNganh.ShowDialog();
            OpenForm(typeof(DSBanNganh));
        }

        private void btnkhoahoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(DSKhoaHoc))
                {
                    frm.Activate();
                    return;
                }
            }
            DSKhoaHoc formDSkhoahoc = new DSKhoaHoc(this, loginAccount.Email);
            formDSkhoahoc.MdiParent = this;
            formDSkhoahoc.Show();
           
        }

        private void btnthemkhoahoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemKhoaHoc themKhoaHoc = new ThemKhoaHoc();   
            themKhoaHoc.ShowDialog();
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(DSKhoaHoc))
                {
                    frm.Activate();
                    return;
                }
            }
            DSKhoaHoc formDSkhoahoc = new DSKhoaHoc(this, loginAccount.Email);
            formDSkhoahoc.MdiParent = this;
            formDSkhoahoc.Show();
        }

        private void btndsvattu_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(DSVatTu))
                {
                    frm.Activate();
                    return;
                }
            }
            DSVatTu dSVatTu = new DSVatTu(loginAccount.Iduser);
            dSVatTu.MdiParent = this;
            dSVatTu.Show();
        }

        private void btnthemvattu_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemVatTu themVatTu = new ThemVatTu();
            themVatTu.SetMode("Sửa");
            themVatTu.ShowDialog();
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(DSVatTu))
                {
                    frm.Activate();
                    return;
                }
            }
            DSVatTu dSVatTu = new DSVatTu(loginAccount.Iduser);
            dSVatTu.MdiParent = this;
            dSVatTu.Show();
        }

        private void btnphieuvattu_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(DSPhieuVatTu))
                {
                    frm.Activate();
                    return;
                }
            }
            DSPhieuVatTu dSphieuVatTu = new DSPhieuVatTu(loginAccount.Iduser);
            dSphieuVatTu.MdiParent = this;
            dSphieuVatTu.Show();
        }

        private void btndssoquy_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(DSSoQuy))
                {
                    frm.Activate();
                    return;
                }
            }
            DSSoQuy dSSoQuy = new DSSoQuy();
            dSSoQuy.MdiParent = this;
            dSSoQuy.Show();
        }

        private void btnloaithu_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(DSLoaiThu))
                {
                    frm.Activate();
                    return;
                }
            }
            DSLoaiThu dSLoaiThu = new DSLoaiThu();
            dSLoaiThu.MdiParent = this;
            dSLoaiThu.Show();
        }

        private void btntaosoquy_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemSoQuy themSoQuy = new ThemSoQuy();
            themSoQuy.SetMode("Thêm");
            themSoQuy.ShowDialog();
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(DSSoQuy))
                {
                    frm.Activate();
                    return;
                }
            }
            DSSoQuy dSSoQuy = new DSSoQuy();
            dSSoQuy.MdiParent = this;
            dSSoQuy.Show();
        }

        private void btnloaichi_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach(Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(DSLoaiChi))
                {
                    frm.Activate();
                    return;
                }
            }
            DSLoaiChi dSLoaiChi = new DSLoaiChi();
            dSLoaiChi.MdiParent = this;
            dSLoaiChi.Show();
        }

        private void btnlapphieuthu_ItemClick(object sender, ItemClickEventArgs e)
        {
            PhieuThu phieuThu = new PhieuThu();
            phieuThu.ShowDialog();
        }

        private void btnbangkephieuthu_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(BangKePhieuThu))
                {
                    frm.Activate();
                    return;
                }
            }
            BangKePhieuThu bang = new BangKePhieuThu();
            bang.MdiParent = this;
            bang.Show();
        }

        private void btnlapphieuchi_ItemClick(object sender, ItemClickEventArgs e)
        {
            PhieuChi phieuChi = new PhieuChi();
            phieuChi.ShowDialog();
        }

        private void btnbangkephieuchi_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(BangKePhieuChi))
                {
                    frm.Activate();
                    return;
                }
            }
            BangKePhieuChi bang = new BangKePhieuChi();
            bang.MdiParent = this;
            bang.Show();
        }

        private void btnlapduchi_ItemClick(object sender, ItemClickEventArgs e)
        {
            LapDuChi lapDuChi = new LapDuChi();
            lapDuChi.ShowDialog();
        }

        private void btnbangkeduchi_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(BangKeDuChi))
                {
                    frm.Activate();
                    return;
                }
            }
            BangKeDuChi bang = new BangKeDuChi();
            bang.MdiParent = this;
            bang.Show();
        }

        private void btnlich_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(Lich))
                {
                    frm.Activate();
                    return;
                }
            }
            Lich lich = new Lich();
            lich.MdiParent = this;
            lich.Show();
        }

        private void btndssukien_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(DSSuKien))
                {
                    frm.Activate();
                    return;
                }
            }
            DSSuKien sSuKien = new DSSuKien();
            sSuKien.MdiParent = this;
            sSuKien.Show();
        }

        private void btnthanhly_ItemClick(object sender, ItemClickEventArgs e)
        {
            PhieuThanhLyVatTu phieuThanhLyVatTu = new PhieuThanhLyVatTu();
            phieuThanhLyVatTu.ShowDialog();
        }

        private void btndsthanhly_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(DSVatTuThanhLy))
                {
                    frm.Activate();
                    return;
                }
            }
            DSVatTuThanhLy vatTuThanhLy = new DSVatTuThanhLy();
            vatTuThanhLy.MdiParent = this;
            vatTuThanhLy.Show();
        }

        private void btnvatuphong_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(PhongBan))
                {
                    frm.Activate();
                    return;
                }
            }
             PhongBan phong = new PhongBan();
            phong.MdiParent = this;
            phong.Show();
        }

        private void btnthemvattuphong_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThaoTacPhong thaoTacPhong = new ThaoTacPhong();
            thaoTacPhong.ShowDialog();
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(PhongBan))
                {
                    frm.Activate();
                    return;
                }
            }
            PhongBan phong = new PhongBan();
            phong.MdiParent = this;
            phong.Show();
        }

        private void btnchungchi_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(DSChungChi))
                {
                    frm.Activate();
                    return;
                }
            }
            DSChungChi chungChi = new DSChungChi();
            chungChi.MdiParent = this;
            chungChi.Show();
        }
    }
}