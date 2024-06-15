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
    public partial class ThemVatTuVaoPhong : DevExpress.XtraEditors.XtraForm
    {
        private Dictionary<string, int> vattuDictionary = new Dictionary<string, int>();
        private int idphong;
        public ThemVatTuVaoPhong(int idphongban)
        {
            this.idphong = idphongban;
            InitializeComponent();
            LoadVatTu();
        }
        void LoadVatTu()
        {
            DataTable dataTable = VatTuDAO.Instance.GetVatTu();
            cbvattu.Properties.Items.Clear();
            vattuDictionary.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                int idvattu = Convert.ToInt32(row["IdVatTu"]);
                string tenvattu = row["TenVatTu"].ToString();
                vattuDictionary.Add(tenvattu, idvattu);
                cbvattu.Properties.Items.Add(tenvattu);
            }
        }
        int GetSelectedValueMember()
        {
            string selectedDisplayText = cbvattu.SelectedItem.ToString();
            int selectedValueMember = vattuDictionary[selectedDisplayText];
            return selectedValueMember;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int idvattu = GetSelectedValueMember();
            int soluong = int.Parse(txtsoluong.Text);
            int soluongtrongkho = VatTuDAO.Instance.GetSoLuongByIdVatTu(idvattu);
            int sudung = VatTuDAO.Instance.GetSoLuongSuDungByIdVatTu(idvattu);
            int soluongconlai = soluongtrongkho - sudung;
            if (soluong > soluongconlai)
            {
                MessageBox.Show($"Số lượng vật tư trong kho chỉ còn {soluongconlai}");
                return;
            }
            else
            {
                if (PhongBanDAO.Instance.InsertVatTuJoinPhong(idvattu, soluong, idphong))
                {
                    VatTuDAO.Instance.UpdateVatTuSuDung(soluong, idvattu);
                    VatTuDAO.Instance.UpdateVatTuTonKho(soluong, idvattu);
                    MessageBox.Show("Thêm thiết bị vào phòng thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thiết bị vào phòng thất bại");
                }
            }
            
        }
    }
}