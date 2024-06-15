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
    public partial class DSVatTu : DevExpress.XtraEditors.XtraForm
    {
        private int iduser;
        public DSVatTu(int iduser)
        {
            InitializeComponent();
            LoadVatTu();
            DemVatTu();
            this.iduser = iduser;
        }
        void DemVatTu()
        {
            int soluongvatu = VatTuDAO.Instance.DemSoVatTu();
            lbsoluong.Caption = "Số lượng trang thiết bị : " + soluongvatu.ToString();
        }
        void LoadVatTu()
        {
            dtgvvattu.DataSource = VatTuDAO.Instance.GetVatTu();
        }

        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemVatTu themVatTu = new ThemVatTu();
            themVatTu.SetMode("Thêm");
            themVatTu.ShowDialog();
            LoadVatTu();
            DemVatTu();
        }

        private void btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idvattu = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdVatTu"));
                string tenvattu = gvmaster.GetRowCellValue(selectedRowHandle, "TenVatTu").ToString();
                int soluong = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "SoLuong"));
                string dvt = gvmaster.GetRowCellValue(selectedRowHandle, "DVT").ToString();
                ThemVatTu themVatTu = new ThemVatTu();
                themVatTu.SetMode("Sửa");
                themVatTu.SetValues(idvattu,tenvattu,soluong,dvt);
                themVatTu.ShowDialog();
                LoadVatTu();
            }
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idvattu = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdVatTu"));
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    if (VatTuDAO.Instance.DeletetVatTu(idvattu))
                    {
                        MessageBox.Show("Xóa trang thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa trang thiết bị thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadVatTu();
                    DemVatTu();
                }
               
            }
        }

        private void btnxuatexcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            if (gvmaster.RowCount > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                    FileName = "Danh sách trang thiết bị.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(saveFileDialog.FileName);

                    using (ExcelPackage package = new ExcelPackage(file))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Danh sách trang thiết bị");

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

        private void btnxuatvattu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhieuXuatVatTu phieuXuatVatTu = new PhieuXuatVatTu(iduser);
            phieuXuatVatTu.ShowDialog();
            LoadVatTu();
        }

        private void btnthanhly_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhieuThanhLyVatTu phieuThanhLyVatTu = new PhieuThanhLyVatTu();
            phieuThanhLyVatTu.ShowDialog();
            LoadVatTu();
        }

        private void btncapnhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadVatTu();
        }
    }
}