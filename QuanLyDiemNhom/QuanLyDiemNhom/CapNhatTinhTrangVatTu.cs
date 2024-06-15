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
    public partial class CapNhatTinhTrangVatTu : DevExpress.XtraEditors.XtraForm
    {
        private int idvattujoinphong;
        private string tinhtrang;
        private int soluong;
        private int idvattu;
        public CapNhatTinhTrangVatTu(int idvattujoinphong, int idvattu, int soluong, string tinhtrang)
        {
            InitializeComponent();
            this.idvattujoinphong = idvattujoinphong;
            this.tinhtrang = tinhtrang;
            this.cbtinhtrang.Text = tinhtrang;
            this.soluong = soluong;
            this.idvattu = idvattu;
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            string tinhtrang = cbtinhtrang.Text;
            int soluonghu = int.Parse(txtsoluonghu.Text);
            if(soluonghu > soluong)
            {
                MessageBox.Show("Số thiết bị hư hỏng vượt quá số lượng có trong phòng");
                return;
            }
            if( tinhtrang == "Hư hỏng")
            {
                if(PhongBanDAO.Instance.UpdateVatTuTinhTrangHuHong(tinhtrang, soluonghu, idvattujoinphong))
                {
                    VatTuDAO.Instance.UpdateVatTuHuHong(soluonghu, idvattu);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật tình trạng thiết bị thất bại");
                }
            }
            else
            {
                if (PhongBanDAO.Instance.UpdateVatTuTinhTrang(tinhtrang, soluonghu, idvattujoinphong))
                {
                    VatTuDAO.Instance.UpdateVatTuDaSuaChua(soluonghu,idvattu );
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật tình trạng thiết bị thất bại");
                }
            }
        }
    }
}