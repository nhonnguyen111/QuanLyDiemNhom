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
    public partial class ThemHocSinh : DevExpress.XtraEditors.XtraForm
    {
        private Dictionary<string, int> thanhVienDictionary = new Dictionary<string, int>();
        private int idkhoahoc;
        public ThemHocSinh(int idkhoahoc)
        {
            InitializeComponent();
            LoadHocSinh();
            this.idkhoahoc = idkhoahoc;
        }
        void LoadHocSinh()
        {
            DataTable dataTable = ThanhVienDAO.Instance.GetThanhVien();
            cbhocsinh.Properties.Items.Clear();
            thanhVienDictionary.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                int idthanhvien = Convert.ToInt32(row["IdThanhVien"]);
                string hoten = row["HoTen"].ToString();
                thanhVienDictionary.Add(hoten, idthanhvien);
                cbhocsinh.Properties.Items.Add(hoten);
            }
        }
        int GetSelectedValueMember()
        {
            string selectedDisplayText = cbhocsinh.SelectedItem.ToString();
            int selectedValueMember = thanhVienDictionary[selectedDisplayText];
            return selectedValueMember;
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            int idthanhvien = GetSelectedValueMember();
            if(ChiTietKhoaHocDAO.Instance.InsertThanhVien(idkhoahoc, idthanhvien))
            {
                MessageBox.Show("Thêm học sinh mới thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm học sinh mới thất bại");
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}