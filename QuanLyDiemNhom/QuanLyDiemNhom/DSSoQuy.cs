using DevExpress.XtraEditors;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using QuanLyDiemNhom.DAO;
using QuanLyDiemNhom.DTO;
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
    public partial class DSSoQuy : DevExpress.XtraEditors.XtraForm
    {
        public DSSoQuy()
        {
            InitializeComponent();
            LoadSoQuy();
        }
        void LoadSoQuy()
        {
            dtgvsoquy.DataSource = SoQuyDAO.Instance.GetSoQuy();
        }

        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemSoQuy themSoQuy = new ThemSoQuy();
            themSoQuy.SetMode("Thêm");
            themSoQuy.ShowDialog();
            LoadSoQuy();
        }

        private void btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idso = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdSoQuy"));
                string tenso = gvmaster.GetRowCellValue(selectedRowHandle, "TenSo").ToString();
                ThemSoQuy themSoQuy = new ThemSoQuy();
                themSoQuy.SetMode("Sửa");
                themSoQuy.SetValues(idso, tenso);
                themSoQuy.ShowDialog();
                LoadSoQuy();

            }
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idso = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdSoQuy"));
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    if (SoQuyDAO.Instance.DeleteSoQuy(idso))
                    {
                        MessageBox.Show("Xóa quỹ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa quỹ thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadSoQuy();
                }
                

            }
        }

        private void btnxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            if (gvmaster.RowCount > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                    FileName = "Danh sách sổ quỹ.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(saveFileDialog.FileName);

                    using (ExcelPackage package = new ExcelPackage(file))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Danh sách sổ quỹ");

                        // Thêm tiêu đề cho các cột
                        for (int i = 0; i < gvmaster.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = gvmaster.Columns[i].Caption; // Sử dụng Caption cho tiêu đề cột
                            worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                            worksheet.Cells[1, i + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            worksheet.Cells[1, i + 1].Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                            worksheet.Cells[1, i + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        }

                        for (int i = 0; i < gvmaster.RowCount; i++)
                        {
                            for (int j = 0; j < gvmaster.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = gvmaster.GetRowCellValue(i, gvmaster.Columns[j]);
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

        private void btncapnhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadSoQuy();
        }
    }
}