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
    public partial class ThemTinHuu : DevExpress.XtraEditors.XtraForm
    {
        private bool isAddingMode;
        private int idthanhvien { get; set; }
        private string hovaten { get; set; }
        private string gmail { get; set; }
        private string sdthoai { get; set; }
        private string Diachi { get; set; }
        private string Khuvuc { get; set; }
        private string Gioitinh { get; set; }
        private string Honnhan { get; set; }
        private DateTime Ngaysinh { get; set; }

        public ThemTinHuu()
        {
            InitializeComponent();
        }

        public void SetValues(int idtinhuu, string hoten, string email, string sdt, string diachi, string khuvuc, string gioitinh, string honnhan, DateTime ngaysinh)
        {
            this.idthanhvien = idtinhuu;
            this.hovaten = hoten;
            this.gmail = email;
            this.sdthoai = sdt;
            this.Diachi = diachi;
            this.Khuvuc = khuvuc;
            this.Gioitinh = gioitinh;
            this.Honnhan = honnhan;
            this.Ngaysinh = ngaysinh;

            txthoten.Text = hoten;
            txtemail.Text = email;
            txtsdt.Text = sdt;
            txtdiachi.Text = diachi;
            txtkhuvuc.Text = khuvuc;
            cbgioitinh.Text = gioitinh;
            cbhonnhan.Text = honnhan;
            if (ngaysinh >= dtngaysinh.MinDate && ngaysinh <= dtngaysinh.MaxDate)
            {
                dtngaysinh.Value = ngaysinh;
            }
            else
            {
                dtngaysinh.Value = DateTime.Today;
            }
        }

        public void SetMode(string mode)
        {
            if (mode == "Thêm")
            {
                isAddingMode = true;
                txthoten.Text = "";
                txtemail.Text = "";
                txtsdt.Text = "";
                txtdiachi.Text = "";
                txtkhuvuc.Text = "";
                cbgioitinh.Text = "Chọn giới tính";
                cbhonnhan.Text = "Chọn tình trạng";
                dtngaysinh.Value = DateTime.Today;

                this.lbtitle.Text = "Thêm tín hữu";
            }
            else if (mode == "Sửa")
            {
                isAddingMode = false;
                this.lbtitle.Text = "Sửa tín hữu";
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            
            if (isAddingMode )
            {

                string hoten = txthoten.Text;
                string email = txtemail.Text;
                string sdt = txtsdt.Text;
                string diachi = txtdiachi.Text;
                string khuvuc = txtkhuvuc.Text;
                string gioitinh = cbgioitinh.SelectedText;
                string honnhan = cbhonnhan.SelectedText;
                DateTime ngaysinh = dtngaysinh.Value;

                if (ThanhVienDAO.Instance.InsertThanhVien(hoten, email, sdt, diachi, khuvuc, gioitinh, honnhan, ngaysinh))
                {
                    MessageBox.Show("Thêm tín hữu mới thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm tín hữu mới thất bại");
                }
            }
            else
            {
                string hoten = txthoten.Text;
                string email = txtemail.Text;
                string sdt = txtsdt.Text;
                string diachi = txtdiachi.Text;
                string khuvuc = txtkhuvuc.Text;
                string gioitinh = cbgioitinh.Text;
                string honnhan = cbhonnhan.Text;
                DateTime ngaysinh = dtngaysinh.Value;

                if (ThanhVienDAO.Instance.UpdateThanhVien(hoten, email, sdt, diachi, khuvuc, gioitinh, honnhan, ngaysinh, idthanhvien))
                {
                    MessageBox.Show("Sữa tín hữu thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa tín hữu thất bại");
                }
            }

            this.Close();

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}