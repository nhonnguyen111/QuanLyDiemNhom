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
    public partial class DSSuKien : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dtbannganh;
        public DSSuKien()
        {
            InitializeComponent();
            dtbannganh = new DataTable();
            LoadSuKien();
            LoadBanNganh();
        }
        void LoadBanNganh()
        {
            dtbannganh = BanNganhDAO.Instance.GetBanNganh();
            gvbannganh.DataSource = dtbannganh;
            gvbannganh.DisplayMember = "TenBanNganh";
            gvbannganh.ValueMember = "IdBanNganh";
        }
        void LoadSuKien()
        {
            dtgvsukien.DataSource = SuKienDAO.Instance.GetSukienFull();
        }

        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SuKienTuyChon suKienTuyChon = new SuKienTuyChon();
            suKienTuyChon.SetMode("Thêm");
            suKienTuyChon.ShowDialog();
            LoadSuKien();
        }

        private void btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idsukien = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdSuKien"));
                string tensukien = gvmaster.GetRowCellValue(selectedRowHandle, "TenSuKien").ToString();
                string noidung = gvmaster.GetRowCellValue(selectedRowHandle, "NoiDung").ToString();
                string vitri = gvmaster.GetRowCellValue(selectedRowHandle, "ViTriDienRa").ToString();
                int idbannganh = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdBanNganh"));
                DateTime ngaybatdau = Convert.ToDateTime(gvmaster.GetRowCellValue(selectedRowHandle, "NgayDienRa"));
                DateTime ngayketthuc = Convert.ToDateTime(gvmaster.GetRowCellValue(selectedRowHandle, "NgayKetThuc"));
                TimeSpan giobatdau = (TimeSpan)gvmaster.GetRowCellValue(selectedRowHandle, "GioDienRa");
                TimeSpan gioketthuc = (TimeSpan)gvmaster.GetRowCellValue(selectedRowHandle, "GioKetThuc");
                SuKienTuyChon suKienTuyChon = new SuKienTuyChon();
                suKienTuyChon.SetMode("Sửa");
                suKienTuyChon.SetValues(idsukien, tensukien, noidung, ngaybatdau, ngayketthuc, giobatdau, gioketthuc, vitri, idbannganh);
                suKienTuyChon.ShowDialog();
                LoadSuKien();
            }
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idsukien = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdSuKien"));
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    if (SuKienDAO.Instance.DeleteSuKien(idsukien))
                    {
                        MessageBox.Show("Xóa sự kiện thành công");
                        LoadSuKien();
                    }
                    else
                    {
                        MessageBox.Show("Xóa  sự kiện thất bại");
                        return;
                    }

                    
                }

            }
        }
        private string GetNameFromDataTable(DataTable dataTable, string keyFieldName, object keyFieldValue, string valueFieldName)
        {
            DataRow[] rows = dataTable.Select($"{keyFieldName} = {keyFieldValue}");
            if (rows.Length > 0)
            {
                return rows[0][valueFieldName].ToString();
            }
            return null;
        }
        private void btnxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            if (gvmaster.RowCount > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                    FileName = "Danh sách sự kiện.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(saveFileDialog.FileName);

                    using (ExcelPackage package = new ExcelPackage(file))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Danh sách sự kiện");

                        for (int i = 0; i < gvmaster.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = gvmaster.Columns[i].Caption;
                            worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                            worksheet.Cells[1, i + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            worksheet.Cells[1, i + 1].Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                            worksheet.Cells[1, i + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        }

                        for (int i = 0; i < gvmaster.RowCount; i++)
                        {
                            for (int j = 0; j < gvmaster.Columns.Count; j++)
                            {
                                object cellValue = gvmaster.GetRowCellValue(i, gvmaster.Columns[j]);

                                if (gvmaster.Columns[j].FieldName == "IdBanNganh")
                                {
                                    var thanhvienName = GetNameFromDataTable(dtbannganh, "IdBanNganh", cellValue, "TenBanNganh");
                                    worksheet.Cells[i + 2, j + 1].Value = thanhvienName;
                                }
                               
                                else
                                {
                                    worksheet.Cells[i + 2, j + 1].Value = cellValue;
                                }

                                worksheet.Cells[i + 2, j + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                            }
                        }
                        worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

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

        private void barLargeButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadSuKien();
        }
    }
}