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
    public partial class ChonThaoTacXoa : DevExpress.XtraEditors.XtraForm
    {
        private int idvattujoinphong;
        private int idvattu;
        private int soluong;
        private int idphong;
        private int soluonghu;
        public ChonThaoTacXoa(int idvattujoinphong, int idvattu, int soluong, int idphongban, int soluonghu)
        {
            InitializeComponent();
            this.idvattujoinphong = idvattujoinphong;
            this.idvattu = idvattu;
            this.soluong = soluong;
            this.idphong = idphongban;
            this.soluonghu = soluonghu;
        }

        private void btnxoahet_Click(object sender, EventArgs e)
        {
            if (PhongBanDAO.Instance.DeleteVatTuTatJoinPhong(idvattujoinphong))
            {
                VatTuDAO.Instance.UpdateVatTuTonKhoTraLai(soluong, idvattu);
                VatTuDAO.Instance.UpdateVatTuDaSuaChua(soluonghu, idvattu);
                VatTuDAO.Instance.UpdateVatTuSuDungXong(soluong, idvattu);
                MessageBox.Show("Xóa hết thiết bị trong phòng thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Xóa hết thiết bị trong phòng thất bại");
                return;
            }
        }

        private void btnxoa1phan_Click(object sender, EventArgs e)
        {
            NhapSoLuongXoa nhapSoLuongXoa = new NhapSoLuongXoa(idvattujoinphong,  idvattu, soluong, soluonghu);
            nhapSoLuongXoa.ShowDialog();
            this.Close();
        }
    }
}