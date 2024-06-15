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
    public partial class PhieuXuatVatTu : DevExpress.XtraEditors.XtraForm
    {
        private Dictionary<string, int> VattuDictionary = new Dictionary<string, int>();
        private Random random;
        private int iduser;
        public PhieuXuatVatTu(int iduser)
        {
            InitializeComponent();
            string tennguoixuat = TaiKhoanDAO.Instance.GetTaikhoanById(iduser);
            this.txtnguoixuat.Text = tennguoixuat;
            LoadVatTu();
            random = new Random();
            int randomNumber = GenerateRandomNumber();
            txtmasophieu.Text = randomNumber.ToString();
            this.iduser = iduser;
        }
        void LoadVatTu()
        {
            DataTable dataTable = VatTuDAO.Instance.GetVatTu();
            cbvattu.Properties.Items.Clear();
            VattuDictionary.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                int idvattu = Convert.ToInt32(row["IdVatTu"]);
                string tenvattu = row["TenVatTu"].ToString();
                VattuDictionary.Add(tenvattu, idvattu);
                cbvattu.Properties.Items.Add(tenvattu);
            }
        }
        int GetSelectedValueMember()
        {
            string selectedDisplayText = cbvattu.SelectedItem.ToString();
            int selectedValueMember = VattuDictionary[selectedDisplayText];
            return selectedValueMember;
        }
        private int GenerateRandomNumber()
        {
            return random.Next(1, 10001);
        }
        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            int idphieuxuat =  int.Parse(txtmasophieu.Text);
            int idvattu = GetSelectedValueMember();
            int soluongxuat =  int.Parse(txtsoluong.Text);
            string noidung = txtnoidung.Text;
            string nguoinhan = txtngnhan.Text;
            DateTime ngayxuat = DateTime.Parse(dtngayxuat.Text);
            int soluong = VatTuDAO.Instance.GetSoLuongByIdVatTu(idvattu);
            int sudung = VatTuDAO.Instance.GetSoLuongSuDungByIdVatTu(idvattu);
            int soluongconlai = soluong - sudung;
            if(soluongxuat > soluongconlai)
            {
                MessageBox.Show($"Số lượng vật tư trong kho chỉ còn {soluongconlai}");
                return;
            }
            else
            {
                if (VatTuDAO.Instance.ExportVatTu(idphieuxuat, idvattu, soluongxuat, noidung, ngayxuat, iduser, nguoinhan))
                {
                    VatTuDAO.Instance.UpdateVatTuSuDung(soluongxuat, idvattu);
                    VatTuDAO.Instance.UpdateVatTuTonKho(soluongxuat, idvattu);
                    MessageBox.Show("Xuất vật tư thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xuất vật tư thất bại");
                }
            }
           
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}