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
    public partial class ThemKhoaHoc : DevExpress.XtraEditors.XtraForm
    {
        private bool isAddingMode;
        private Dictionary<string, int> thanhVienDictionary = new Dictionary<string, int>();
        private int idkhoahoc {  get; set; }
        private string tenkhoahoc { get; set; }
        private int idgiaovien {  get; set; }
        private DateTime ngaybatdau { get; set; }
        private DateTime ngaykethuc {  get; set; }
        private string tinhtrang {  get; set; }
        private string thoigianhoc {  get; set; }
        public void SetValues(int IdKhoahoc, string Tenkhoahoc, int Idgiaovien, DateTime Ngaybatdau, DateTime Ngaykethuc, string Tinhtrang, string Thoigianhoc)
        {
            this.idkhoahoc = IdKhoahoc;
            this.tenkhoahoc = Tenkhoahoc;
            this.idgiaovien = Idgiaovien;
            this.ngaybatdau = Ngaybatdau;
            this.ngaykethuc = Ngaykethuc;
            this.tinhtrang = Tinhtrang;
            this.thoigianhoc = Thoigianhoc;
            this.txttenkhoahoc.Text = Tenkhoahoc;
            this.dtbatdau.Value = Ngaybatdau;
            this.dtketthuc.Value = Ngaykethuc;
            string tengiaovien = TaiKhoanDAO.Instance.GetTaikhoanById(Idgiaovien);
            this.cbgiaovien.Text = tengiaovien;
            this.cbtinhtrang.Text = Tinhtrang;
            this.cbthoigian.Text = Thoigianhoc.ToString();
        }

        public void SetMode(string mode)
        {
            if (mode == "Thêm")
            {
                isAddingMode = true;
                this.txttenkhoahoc.Text = "";
                this.dtbatdau.Value = DateTime.Today;
                this.dtketthuc.Value = DateTime.Today;
                this.cbgiaovien.Text = "Chọn giáo viên";
                this.cbtinhtrang.Text = "Chọn tình trạng khóa học";
                this.lbtitle.Text = "Thêm khóa học";
            }
            else if (mode == "Sửa")
            {
                isAddingMode = false;
                this.lbtitle.Text = "Sửa khóa học";
            }
        }

        public ThemKhoaHoc()
        {
            InitializeComponent();
            LoadGiaoVien();
        }

        void LoadGiaoVien()
        {
            DataTable dataTable = TaiKhoanDAO.Instance.GetTaiKhoans();
            cbgiaovien.Properties.Items.Clear();
            thanhVienDictionary.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                int idthanhvien = Convert.ToInt32(row["IdUser"]);
                string hoten = row["hoten"].ToString();
                thanhVienDictionary.Add(hoten, idthanhvien);
                cbgiaovien.Properties.Items.Add(hoten);
            }
        }

        private void Dtbatdau_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtbatdau.Value;
            DateTime today = DateTime.Today;

           
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if(isAddingMode)
            {
                string tenkhoahoc = txttenkhoahoc.Text;
                DateTime ngaybatdau = dtbatdau.Value;
                DateTime ngayketthuc = dtketthuc.Value;
                string thoigianhoc = cbthoigian.Text;

               string tinhtrang = cbtinhtrang.Text;

                if (cbgiaovien.SelectedItem != null)
                {
                    int idthanhvien = GetSelectedValueMember();
                    if (KhoaHocDAO.Instance.InsertKhoaHoc(tenkhoahoc, idthanhvien, ngaybatdau, ngayketthuc, tinhtrang, thoigianhoc))
                    {
                        MessageBox.Show("Thêm khóa học mới thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm khóa học mới thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng giáo viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                string tenkhoahoc = txttenkhoahoc.Text;
                DateTime ngaybatdau = dtbatdau.Value;
                DateTime ngayketthuc = dtketthuc.Value;
                string thoigianhoc = cbthoigian.Text;
                string tinhtrang = cbtinhtrang.Text;


                if (cbgiaovien.SelectedItem != null)
                {
                    int idthanhvien = GetSelectedValueMember();
                    if (KhoaHocDAO.Instance.UpdateKhoaHoc(tenkhoahoc, idthanhvien, ngaybatdau, ngayketthuc, tinhtrang, thoigianhoc,idkhoahoc))
                    {
                        MessageBox.Show("Sửa khóa học thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sửa khóa học thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng giáo viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        int GetSelectedValueMember()
        {
            string selectedDisplayText = cbgiaovien.SelectedItem.ToString();
            int selectedValueMember = thanhVienDictionary[selectedDisplayText];
            return selectedValueMember;
        }
    }
}
