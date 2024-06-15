using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using QuanLyDiemNhom.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace QuanLyDiemNhom
{
    public partial class DSTinhuu : DevExpress.XtraEditors.XtraForm
    {
        

        public DSTinhuu()
        {
            InitializeComponent();
            LoadThanhVien();
            DemSoThanhVien();
        }
        void LoadThanhVien()
        {
            dtgvThanhVien.DataSource = ThanhVienDAO.Instance.GetThanhVien();            
        }
        void DemSoThanhVien()
        {
            int sothanhvien = ThanhVienDAO.Instance.DemSoThanhVien();
            txtsothanhvien.Caption = "Số lượng tín hữu :" + sothanhvien.ToString();
        }

        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemTinHuu themTinHuu   = new ThemTinHuu();
            themTinHuu.SetMode("Thêm");
            themTinHuu.ShowDialog();
            LoadThanhVien();
            DemSoThanhVien();
        }

        private void btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gridView1.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idthanhvien = Convert.ToInt32(gridView1.GetRowCellValue(selectedRowHandle, "IdThanhVien"));
                string hoten = gridView1.GetRowCellValue(selectedRowHandle, "HoTen").ToString();
                string email = gridView1.GetRowCellValue(selectedRowHandle, "Email").ToString();
                string sdt = gridView1.GetRowCellValue(selectedRowHandle, "SoDienThoai").ToString();
                string diachi = gridView1.GetRowCellValue(selectedRowHandle, "DiaChi").ToString();
                string khuvuc = gridView1.GetRowCellValue(selectedRowHandle, "KhuVuc").ToString();
                string gioitinh = gridView1.GetRowCellValue(selectedRowHandle, "GioiTinh").ToString();
                string honnhan = gridView1.GetRowCellValue(selectedRowHandle, "HonNhan").ToString();
                DateTime ngaysinh = Convert.ToDateTime(gridView1.GetRowCellValue(selectedRowHandle, "NgaySinh"));

                ThemTinHuu themTinHuu = new ThemTinHuu();
                themTinHuu.SetMode("Sửa");
                themTinHuu.SetValues(idthanhvien, hoten, email, sdt, diachi, khuvuc, gioitinh, honnhan, ngaysinh);
                themTinHuu.ShowDialog();
                LoadThanhVien();
            }
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gridView1.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idthanhvien = Convert.ToInt32(gridView1.GetRowCellValue(selectedRowHandle, "IdThanhVien"));
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    if (ThanhVienDAO.Instance.DeleteThanhVien(idthanhvien))
                    {
                        MessageBox.Show("Xóa thành viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thành viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadThanhVien();
                    DemSoThanhVien();
                }
            }
        }
        private void btnxuatexcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            if (gridView1.RowCount > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                    FileName = "Danh sách thành viên.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(saveFileDialog.FileName);

                    using (ExcelPackage package = new ExcelPackage(file))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Danh sách Thành viên");

                        // Thêm tiêu đề cho các cột
                        for (int i = 0; i < gridView1.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = gridView1.Columns[i].Caption;
                            worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                            worksheet.Cells[1, i + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            worksheet.Cells[1, i + 1].Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                            worksheet.Cells[1, i + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        }

                        // Thêm dữ liệu từ DataGridView vào file Excel
                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            for (int j = 0; j < gridView1.Columns.Count; j++)
                            {
                                if (gridView1.Columns[j].ColumnType == typeof(DateTime))
                                {
                                    // Nếu cột là kiểu DateTime, cần chuyển đổi định dạng trước khi gán vào ô Excel
                                    DateTime dateValue = (DateTime)gridView1.GetRowCellValue(i, gridView1.Columns[j]);
                                    worksheet.Cells[i + 2, j + 1].Value = dateValue.ToString("dd/MM/yyyy");
                                }
                                else
                                {
                                    worksheet.Cells[i + 2, j + 1].Value = gridView1.GetRowCellValue(i, gridView1.Columns[j]);
                                }
                                worksheet.Cells[i + 2, j + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                            }
                        }

                        // AutoFit các cột cho vừa với nội dung
                        worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                        // Lưu file
                        package.Save();
                    }

                    MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất ra file Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string searchValue = txttimkiem.Text.Trim();
            DataTable dtSearchResult = ThanhVienDAO.Instance.SearchThanhVienByName(searchValue);

            // Liên kết GridControl với DataTable để hiển thị kết quả tìm kiếm
            dtgvThanhVien.DataSource = dtSearchResult;
        }

        private void checknam_CheckedChanged(object sender, EventArgs e)
        {
            if (checknam.Checked)
            {
                DataTable dtSearchResult = ThanhVienDAO.Instance.SearchThanhVienByGioiTinh(checknam.Text);
                dtgvThanhVien.DataSource = dtSearchResult;
            }
            else
            {
                LoadThanhVien();
            }
        }

        private void btncapnhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadThanhVien();
        }

        private void checknu_CheckedChanged(object sender, EventArgs e)
        {
            if (checknu.Checked)
            {
                DataTable dtSearchResult = ThanhVienDAO.Instance.SearchThanhVienByGioiTinh(checknu.Text);
                dtgvThanhVien.DataSource = dtSearchResult;
            }
            else
            {
                LoadThanhVien();
            }
        }

        private void checkkethon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkkethon.Checked)
            {
                DataTable dtSearchResult = ThanhVienDAO.Instance.SearchThanhVienByHonNhan(checkkethon.Text);
                dtgvThanhVien.DataSource = dtSearchResult;
            }
            else
            {
                LoadThanhVien();
            }
        }

        private void checkchuakethon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkchuakethon.Checked)
            {
                DataTable dtSearchResult = ThanhVienDAO.Instance.SearchThanhVienByHonNhan(checkchuakethon.Text);
                dtgvThanhVien.DataSource = dtSearchResult;
            }
            else
            {
                LoadThanhVien();
            }
        }
    }
}