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
    public partial class PhongBan : DevExpress.XtraEditors.XtraForm
    {
        private Dictionary<string, int> phongbanDictionary = new Dictionary<string, int>();

        public PhongBan()
        {
            InitializeComponent();
            LoadPhongBan();
        }
        void LoadChiTietVatTuPhong()
        {
            if (cbphong.SelectedItem != null)
            {
                string selectedDisplayText = cbphong.SelectedItem.ToString();

                if (phongbanDictionary.TryGetValue(selectedDisplayText, out int selectedValueMember))
                {
                    dtgvvattuphong.DataSource = PhongBanDAO.Instance.GetVatTuPhongBan(selectedValueMember);
                }
                else
                {
                    MessageBox.Show("Hãy chọn phòng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a department from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void Phong()
        {
            gvphong.DataSource = PhongBanDAO.Instance.GetPhongBan();
            gvphong.DisplayMember = "TenPhongBan";
            gvphong.ValueMember = "IdPhongBan";
        }
        void LoadVatTu()
        {
            gvvattu.DataSource = VatTuDAO.Instance.GetVatTu();
            gvvattu.DisplayMember = "TenVatTu";
            gvvattu.ValueMember = "IdVatTu";
        }
        void LoadPhongBan()
        {
            DataTable dataTable = PhongBanDAO.Instance.GetPhongBan();
            cbphong.Properties.Items.Clear();
            phongbanDictionary.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                int idphong = Convert.ToInt32(row["IdPhongBan"]);
                string tenphong = row["TenPhongBan"].ToString();
                phongbanDictionary.Add(tenphong, idphong);
                cbphong.Properties.Items.Add(tenphong);
            }
        }
        int GetSelectedValueMember()
        {
            string selectedDisplayText = cbphong.SelectedItem.ToString();
            int selectedValueMember = phongbanDictionary[selectedDisplayText];
            return selectedValueMember;
        }
        private void btnthemphong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThaoTacPhong thaoTacPhong = new ThaoTacPhong();
            thaoTacPhong.SetMode("Thêm");
            thaoTacPhong.ShowDialog();
            LoadPhongBan();
        }

        private void btnsuaphong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbphong.SelectedItem != null)
            {
                string selectedDisplayText = cbphong.SelectedItem.ToString();

                if (phongbanDictionary.TryGetValue(selectedDisplayText, out int selectedValueMember))
                {
                    ThaoTacPhong thaoTacPhong = new ThaoTacPhong();
                    thaoTacPhong.SetMode("Sửa");
                    thaoTacPhong.SetValues(selectedValueMember, selectedDisplayText);
                    thaoTacPhong.ShowDialog();
                    this.cbphong.Text = "Hãy chọn phòng";
                    LoadPhongBan();
                }
                else
                {
                    MessageBox.Show("Hãy chọn phòng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a department from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnxoaphong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbphong.SelectedItem != null)
            {
                string selectedDisplayText = cbphong.SelectedItem.ToString();

                if (phongbanDictionary.TryGetValue(selectedDisplayText, out int selectedValueMember))
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (PhongBanDAO.Instance.DeletePhongBan(selectedValueMember))
                        {
                            PhongBanDAO.Instance.DeleteVatTuJoinPhong(selectedValueMember);
                            MessageBox.Show($"Xóa {selectedDisplayText} thành công");
                            this.cbphong.Text = "Hãy chọn phòng";
                            LoadPhongBan();
                        }
                        else
                        {
                            MessageBox.Show($"Xóa {selectedDisplayText} thất bại");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn phòng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a department from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            Phong();
            LoadVatTu();
            LoadChiTietVatTuPhong();

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (cbphong.SelectedItem != null)
            {
                string selectedDisplayText = cbphong.SelectedItem.ToString();

                if (phongbanDictionary.TryGetValue(selectedDisplayText, out int selectedValueMember))
                {
                    ThemVatTuVaoPhong themVatTuVaoPhong = new ThemVatTuVaoPhong(selectedValueMember);
                    themVatTuVaoPhong.ShowDialog();
                    Phong();
                    LoadVatTu();
                    LoadChiTietVatTuPhong();
                }
                else
                {
                    MessageBox.Show("Hãy chọn phòng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a department from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (cbphong.SelectedItem != null)
            {
                string selectedDisplayText = cbphong.SelectedItem.ToString();

                if (phongbanDictionary.TryGetValue(selectedDisplayText, out int selectedValueMember))
                {
                    var selectedRowHandle = gvmaster.FocusedRowHandle;
                    if (selectedRowHandle >= 0)
                    {
                        int idvattujoinphong = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdVatTuJoinPhong"));
                        int idvattu = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdVatTu"));
                        int soluong = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "SoLuong"));
                        string tinhtrang = gvmaster.GetRowCellValue(selectedRowHandle, "TinhTrang").ToString();
                        CapNhatTinhTrangVatTu capNhatTinhTrangVatTu = new CapNhatTinhTrangVatTu(idvattujoinphong, idvattu, soluong, tinhtrang);
                        capNhatTinhTrangVatTu.ShowDialog();
                        Phong();
                        LoadVatTu();
                        LoadChiTietVatTuPhong();

                    }
                   
                }
                else
                {
                    MessageBox.Show("Hãy chọn phòng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a department from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (cbphong.SelectedItem != null)
            {
                string selectedDisplayText = cbphong.SelectedItem.ToString();

                if (phongbanDictionary.TryGetValue(selectedDisplayText, out int selectedValueMember))
                {
                    var selectedRowHandle = gvmaster.FocusedRowHandle;
                    if (selectedRowHandle >= 0)
                    {
                        int idvattujoinphong = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdVatTuJoinPhong"));
                        int idvattu = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdVatTu"));
                        int soluong = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "SoLuong"));
                        int soluonghu = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "HuHong"));
                        ChonThaoTacXoa chonThaoTacXoa = new ChonThaoTacXoa(idvattujoinphong,idvattu, soluong, selectedValueMember, soluonghu);
                        chonThaoTacXoa.ShowDialog();
                        Phong();
                        LoadVatTu();
                        LoadChiTietVatTuPhong();

                    }
                   
                   
                }
                else
                {
                    MessageBox.Show("Hãy chọn phòng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a department from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}