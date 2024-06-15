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
    public partial class ThemThanhVien : DevExpress.XtraEditors.XtraForm
    {
        private Dictionary<string, int> thanhVienDictionary = new Dictionary<string, int>();
        private int idbannganh;
        public ThemThanhVien(int idbannganh)
        {
            InitializeComponent();
            LoadThanhVien();
            this.idbannganh = idbannganh;
        }
        void LoadThanhVien()
        {
            
            DataTable dataTable = ThanhVienDAO.Instance.GetThanhVien();
            cbthanhvien.Properties.Items.Clear();
            thanhVienDictionary.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                int idthanhvien = Convert.ToInt32(row["idthanhvien"]);
                string hoten = row["hoten"].ToString();
                thanhVienDictionary.Add(hoten, idthanhvien);
                cbthanhvien.Properties.Items.Add(hoten);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (cbthanhvien.SelectedItem != null)
            {
                int idthanhvien = GetSelectedValueMember();
                if (ChiTietBanNganhDAO.Instance.InsertThanhVien(idthanhvien, idbannganh))
                {
                    MessageBox.Show("Thêm thành viên vào nhóm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thành viên vào nhóm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một thành viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int GetSelectedValueMember()
        {
            string selectedDisplayText = cbthanhvien.SelectedItem.ToString();
            int selectedValueMember = thanhVienDictionary[selectedDisplayText];
            return selectedValueMember;
        }
    }
}