using DevExpress.XtraEditors;
using QuanLyDiemNhom.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyDiemNhom
{
    public partial class CapNhatPhieuVatTu : DevExpress.XtraEditors.XtraForm
    {
        private int idphieu;
        private int soluongxuat;
        private DateTime ngayxuat;
        private int idnguoixuat;
        private string noidung;
        private string nguoinhan;
        private int soluongTra;
        private int idvattu;

        public CapNhatPhieuVatTu(int idphieu, int soluongxuat, DateTime ngayxuat, int idnguoixuat, string noidung, string nguoinhan, int soluongTra, int idvattu)
        {
            InitializeComponent();
            this.idphieu = idphieu;
            this.soluongxuat = soluongxuat;
            this.ngayxuat = ngayxuat;
            this.idnguoixuat = idnguoixuat;
            this.noidung = noidung;
            this.nguoinhan = nguoinhan;
            this.soluongTra = soluongTra;
            this.idvattu = idvattu;

            InitializeFields();
        }

        private void InitializeFields()
        {
            string tennguoixuat = TaiKhoanDAO.Instance.GetTaikhoanById(idnguoixuat);
            this.txtmasophieu.Text = idphieu.ToString();
            this.txtsoluong.Text = soluongxuat.ToString();
            this.dtngayxuat.Text = ngayxuat.ToString("yyyy-MM-dd");
            this.txtnguoixuat.Text = tennguoixuat;
            this.txtnoidung.Text = noidung;
            this.txtngnhan.Text = nguoinhan;

            DateTime? ngaytra = PhieuVatTuDAO.Instance.GetNgayTraByIdPhieu(idphieu);
            this.dtngaytra.Text = ngaytra?.ToString("yyyy-MM-dd") ?? string.Empty;
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                int soluongxuat = int.Parse(txtsoluong.Text);
                int soluongtra = int.Parse(txtsoluongtra.Text);

                int soluong = PhieuVatTuDAO.Instance.GetSoLuongXuatByIdPhieu(idphieu);
                int vattutang = soluongxuat - soluong;
                int soluongdatra = PhieuVatTuDAO.Instance.GetSoLuongTraByIdPhieu(idphieu);
                int soluongtrudi = soluong - soluongdatra;
                string noidung = txtnoidung.Text;
                string nguoinhan = txtngnhan.Text;
                int soluongtrongkho = VatTuDAO.Instance.GetSoLuongByIdVatTu(idvattu);
                int soluongsudung = VatTuDAO.Instance.GetSoLuongSuDungByIdVatTu(idvattu);
                int soluongconlai = soluongtrongkho - soluongsudung;
                if(soluongxuat > soluongconlai && soluongxuat != soluong)
                {
                    MessageBox.Show($"Vật tư trong kho chỉ còn {soluongconlai}");
                    return;
                }
                DateTime ngayxuat;
                DateTime ngatra;

                if (!DateTime.TryParse(dtngayxuat.Text, out ngayxuat))
                {
                    MessageBox.Show("Ngày xuất không hợp lệ");
                    return;
                }

                if (soluongtra == 0)
                {
                    if (PhieuVatTuDAO.Instance.UpdatePhieuVatTuKhongtrasoluong(soluongxuat, noidung, nguoinhan, ngayxuat, idphieu))
                    {
                        VatTuDAO.Instance.UpdateVatTuTonKho(vattutang, idvattu);
                        VatTuDAO.Instance.UpdateVatTuSuDung(vattutang, idvattu);
                        MessageBox.Show("Cập nhật phiếu thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật phiếu thất bại");
                    }
                }
                else
                {
                    if (!DateTime.TryParse(dtngaytra.Text, out ngatra))
                    {
                        MessageBox.Show("Ngày trả không hợp lệ");
                        return;
                    }
                    if (soluongtra > soluongtrudi)
                    {
                        MessageBox.Show($"Đã trả trước {soluongTra}, hãy nhập số còn lại");
                        return;
                    }
                    if (soluongdatra == soluong)
                    {
                        MessageBox.Show("Vật tư đã được trả hết");
                        return;
                    }
                    string tinhtrang;
                    if (soluongtra + soluongdatra < soluongxuat)
                    {
                        tinhtrang = "Trả một phần";
                    }
                    else
                    {
                        tinhtrang = "Đã trả hết";
                    }
                   
                    if (PhieuVatTuDAO.Instance.UpdatePhieuVatTu(soluongxuat, noidung, nguoinhan, ngayxuat, ngatra, soluongtra, idphieu))
                    {
                        PhieuVatTuDAO.Instance.UpdateTinhTrang(tinhtrang, idphieu);
                        VatTuDAO.Instance.UpdateVatTuSuDungXong(soluongtra, idvattu);
                        VatTuDAO.Instance.UpdateVatTuSuDung(vattutang, idvattu);
                        VatTuDAO.Instance.UpdateVatTuTonKho(vattutang, idvattu);
                        MessageBox.Show("Cập nhật phiếu thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật phiếu thất bại");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số lượng");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
