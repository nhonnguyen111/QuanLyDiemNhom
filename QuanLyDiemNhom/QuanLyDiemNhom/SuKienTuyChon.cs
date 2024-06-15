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
    public partial class SuKienTuyChon : DevExpress.XtraEditors.XtraForm
    {
        private Dictionary<string, int> BannganhDictionary = new Dictionary<string, int>();
        private bool isAddingMode;
        private int idsukien { get; set; }
        private string tensukien { get; set; }
        private string noidung { get; set; }
        private DateTime ngaybatdau { get; set; }
        private DateTime ngayketthuc { get; set; }
        private TimeSpan giobatdau { get; set; }
        private TimeSpan gioketthuc { get; set; }
        private string vitri { get; set; }
        private int idbannganh { get; set; }

        public SuKienTuyChon()
        {
            InitializeComponent();
            LoadBanNganh();
        }
        public void SetValues(int IdSukien, string TenSuKien, string NoiDung, DateTime Ngaydienra, DateTime NgayKetThuc, TimeSpan Giobatdau, TimeSpan GioKetThuc, string noidienra, int IdBannganh)
        {
           this.idsukien = IdSukien;
            this.tensukien = TenSuKien;
            this.noidung = NoiDung;
            this.ngaybatdau = Ngaydienra;
            this.ngayketthuc = NgayKetThuc;
            this.giobatdau = Giobatdau;
            this.gioketthuc= GioKetThuc;
            this.vitri = noidienra;
            this.idbannganh = IdBannganh;
            this.txttensukien.Text = TenSuKien;
            this.txtnoidung.Text = NoiDung;
            this.dtngaydienra.Value = Ngaydienra;
            this.dtngayketthuc.Value = NgayKetThuc;
            this.timedienra.Time = DateTime.Today.Add(Giobatdau);
            this.timeketthuc.Time = DateTime.Today.Add(GioKetThuc);
            this.txtvitri.Text = noidienra;
            string tenbannganh = BanNganhDAO.Instance.GetTenBanNganhById(IdBannganh);
            this.cbbannganh.Text = tenbannganh;
        }

        public void SetMode(string mode)
        {
            if (mode == "Thêm")
            {
                isAddingMode = true;
                
                this.lbtitle.Text = "Thêm sự kiện mới";
            }
            else if (mode == "Sửa")
            {
                isAddingMode = false;
                this.lbtitle.Text = "Sửa sự kiện";
            }
        }
        void LoadBanNganh()
        {
            DataTable dataTable = BanNganhDAO.Instance.GetBanNganh();
            cbbannganh.Properties.Items.Clear();
            BannganhDictionary.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                int idbannganh = Convert.ToInt32(row["IdBanNganh"]);
                string tenbannganh = row["TenBanNganh"].ToString();
                BannganhDictionary.Add(tenbannganh, idbannganh);
                cbbannganh.Properties.Items.Add(tenbannganh);
            }
        }

        int GetSelectedValueMember()
        {
            string selectedDisplayText = cbbannganh.SelectedItem.ToString();
            int selectedValueMember = BannganhDictionary[selectedDisplayText];
            return selectedValueMember;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(isAddingMode)
            {
                string tensukien = txttensukien.Text;
                string noidung = txtnoidung.Text;
                DateTime ngaybatdau = dtngaydienra.Value;
                DateTime ngayketthuc = dtngayketthuc.Value;
                TimeSpan giobatdau =timedienra.Time.TimeOfDay;
                TimeSpan gioketthuc = timeketthuc.Time.TimeOfDay;
                string vitri= txtvitri.Text;
                int idbannganh = GetSelectedValueMember();
                if(SuKienDAO.Instance.InsertSuKien(tensukien, noidung, ngaybatdau, ngayketthuc, giobatdau, gioketthuc, vitri, idbannganh))
                {
                    MessageBox.Show("Tạo sự kiện mới thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tạo sự kiện mới thất bại");
                }
            }
            else
            {
                string tensukien = txttensukien.Text;
                string noidung = txtnoidung.Text;
                DateTime ngaybatdau = dtngaydienra.Value;
                DateTime ngayketthuc = dtngayketthuc.Value;
                TimeSpan giobatdau = timedienra.Time.TimeOfDay;
                TimeSpan gioketthuc = timeketthuc.Time.TimeOfDay;
                string vitri = txtvitri.Text;
                int idbannganh = GetSelectedValueMember();
                if (SuKienDAO.Instance.UpdateSuKien(tensukien, noidung, ngaybatdau, ngayketthuc, giobatdau, gioketthuc, vitri, idbannganh, idsukien))
                {
                    MessageBox.Show("Sửa sự kiện thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa sự kiện thất bại");
                    return;
                }
            }
        }
    }
}