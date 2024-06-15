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
    
    public partial class NhapSoLuongXoa : DevExpress.XtraEditors.XtraForm
    {
        private int idvattujoinphong;
        private int idvattu;
        private int soluong;
        private int soluonghu;
        public NhapSoLuongXoa(int idvattujoinphong, int idvattu, int soluong, int soluonghu)
        {
            InitializeComponent();
            this.idvattujoinphong = idvattujoinphong;
            this.idvattu = idvattu;
            this.soluong = soluong;
            this.soluonghu = soluonghu;
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            int soluongxoa = int.Parse(txtsoluongxoa.Text);
            if(soluongxoa > soluong)
            {
                MessageBox.Show("Thiết bị trong phòng ít hơn số lượng bạn nhập");
                return;
            }
            if(PhongBanDAO.Instance.DeleteVatTuJoinPhong1Phan(soluongxoa, idvattujoinphong) )
            {
                if(soluongxoa == soluong)
                {
                    VatTuDAO.Instance.UpdateVatTuDaSuaChua(soluonghu, idvattu);
                    VatTuDAO.Instance.UpdateVatTuTonKhoTraLai(soluongxoa, idvattu);
                    VatTuDAO.Instance.UpdateVatTuSuDungXong(soluongxoa, idvattu);
                    MessageBox.Show("Xóa thiết bị thành công");
                    this.Close();
                }
                else
                {
                    VatTuDAO.Instance.UpdateVatTuTonKhoTraLai(soluongxoa, idvattu);
                    VatTuDAO.Instance.UpdateVatTuSuDungXong(soluongxoa, idvattu);
                    MessageBox.Show("Xóa thiết bị thành công");
                    this.Close();
                }
               
            }
            else
            {
                MessageBox.Show("Xóa thiết bị thất bại");
                return;
            }
        }
    }
}