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
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace QuanLyDiemNhom
{
    public partial class PhieuThanhLyVatTu : DevExpress.XtraEditors.XtraForm
    {
        private Dictionary<string, int> VattuDictionary = new Dictionary<string, int>();
        private Dictionary<string, int> SoQuyDictionary = new Dictionary<string, int>();
        public PhieuThanhLyVatTu()
        {
            InitializeComponent();
            LoadVatTu();
            LoadSoQuy();
        }
        void LoadSoQuy()
        {
            DataTable dataTable = SoQuyDAO.Instance.GetSoQuy();
            cbsoquy.Properties.Items.Clear();
            SoQuyDictionary.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                int idso = Convert.ToInt32(row["IdSoQuy"]);
                string tenso = row["TenSo"].ToString();
                SoQuyDictionary.Add(tenso, idso);
                cbsoquy.Properties.Items.Add(tenso);
            }
        }
        int GetSelectedValueMemberSoQuy()
        {
            string selectedDisplayText = cbsoquy.SelectedItem.ToString();
            int selectedValueMember = SoQuyDictionary[selectedDisplayText];
            return selectedValueMember;
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

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            int idsoquy = GetSelectedValueMemberSoQuy();
            int idvattu = GetSelectedValueMember();
            int soluongthanhly = int.Parse(txtsoluong.Text);
            float tienthanhly =  float.Parse(txtsotien.Text);
            string nguoiban = txtnguoiban.Text;
            string noiban = txtnoiban.Text;
            DateTime ngayban = DateTime.Parse(dtngayban.Text);
            int soluong = VatTuDAO.Instance.GetSoLuongByIdVatTu(idvattu);
            int sudung = VatTuDAO.Instance.GetSoLuongSuDungByIdVatTu(idvattu);
            int soluongconlai = soluong - sudung;
            if (soluongthanhly > soluongconlai)
            {
                MessageBox.Show($"Số lượng trang thiết bị trong kho chỉ còn {soluongconlai}");
                return;
            }
            else
            {
                if (ThanhLyVatTuDAO.Instance.InsertTaoPhieu(idvattu, soluongthanhly, tienthanhly, ngayban, nguoiban, noiban, idsoquy))
                {
                    ThanhLyVatTuDAO.Instance.UpdateVatTu(soluongthanhly, idvattu);
                    ThanhLyVatTuDAO.Instance.UpdateSoQuy(tienthanhly, idsoquy);
                    MessageBox.Show("Tạo phiếu thanh lý thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tạo phiếu thanh lý thất bại");
                    return;
                }
            }
           
            
        }
    }
}