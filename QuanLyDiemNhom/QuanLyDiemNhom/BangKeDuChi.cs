using DevExpress.XtraEditors;
using OfficeOpenXml.Style;
using OfficeOpenXml;
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
    public partial class BangKeDuChi : DevExpress.XtraEditors.XtraForm
    {
        public BangKeDuChi()
        {
            InitializeComponent();
            LoadKeHoach();
        }
        void LoadKeHoach()
        {
            dtgvduchi.DataSource = KeHoachDuChiDAO.Instance.GetKeHoach();
        }
        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LapDuChi lapDuChi = new LapDuChi(); 
            lapDuChi.ShowDialog();
        }

        private void btnxeduchi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idkehoach = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdKeHoach"));
                string tenkehoach = gvmaster.GetRowCellValue(selectedRowHandle, "TenKeHoach").ToString();
                DateTime ngaybatdau = Convert.ToDateTime(gvmaster.GetRowCellValue(selectedRowHandle, "NgayBatDau"));
                DateTime ngayketthuc = Convert.ToDateTime(gvmaster.GetRowCellValue(selectedRowHandle, "NgayKetThuc"));
                string quanly1 = gvmaster.GetRowCellValue(selectedRowHandle, "QuanLy1").ToString();
                string quanly2 = gvmaster.GetRowCellValue(selectedRowHandle, "QuanLy2").ToString();
                int tongchiphi = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "TongChiPhi"));
                string mota = gvmaster.GetRowCellValue(selectedRowHandle, "MoTa").ToString();
                XemDuChi xemDuChi = new XemDuChi(idkehoach, tenkehoach,ngaybatdau,ngayketthuc, quanly1,quanly2, tongchiphi, mota);
                xemDuChi.ShowDialog();
                LoadKeHoach();
            }
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idkehoach = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdKeHoach"));
                if(KeHoachDuChiDAO.Instance.DeleteHangMucByIdKeHoach(idkehoach))
                {
                    KeHoachDuChiDAO.Instance.DeleteKeHoach(idkehoach);
                    MessageBox.Show("Xóa kế hoach thành công");
                    LoadKeHoach();
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
                    FileName = "Danh sách kế hoạch.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(saveFileDialog.FileName);

                    using (ExcelPackage package = new ExcelPackage(file))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Danh sách kế hoạch");

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
            LoadKeHoach();
        }
    }
}