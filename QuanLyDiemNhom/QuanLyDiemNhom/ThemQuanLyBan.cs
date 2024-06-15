using DevExpress.XtraEditors;
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
    public partial class ThemQuanLyBan : DevExpress.XtraEditors.XtraForm
    {
        private Dictionary<string, int> thanhVienDictionary = new Dictionary<string, int>();
        private int idbannganh;
        public ThemQuanLyBan(int idbannganh)
        {
            InitializeComponent();
            LoadNhanSu();
            this.idbannganh = idbannganh;
        }
        void LoadNhanSu()
        {
            DataTable dataTable = TaiKhoanDAO.Instance.GetTaiKhoans();
            cbquanly.Properties.Items.Clear();
            thanhVienDictionary.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                int idthanhvien = Convert.ToInt32(row["IdUser"]);
                string hoten = row["hoten"].ToString();
                thanhVienDictionary.Add(hoten, idthanhvien);
                cbquanly.Properties.Items.Add(hoten);
            }
        }
        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if (cbquanly.SelectedItem != null)
            {
                int idthanhvien = GetSelectedValueMember();
                if (BanNganhDAO.Instance.InsertQuanLy( idbannganh, idthanhvien))
                {
                    MessageBox.Show("Thêm quản lý vào nhóm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm quản lý vào nhóm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn quản lý.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        int GetSelectedValueMember()
        {
            string selectedDisplayText = cbquanly.SelectedItem.ToString();
            int selectedValueMember = thanhVienDictionary[selectedDisplayText];
            return selectedValueMember;
        }
    }
}