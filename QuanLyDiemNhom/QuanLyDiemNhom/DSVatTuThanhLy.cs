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
    public partial class DSVatTuThanhLy : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dtvattu;
        private DataTable dtsoquy;
        public DSVatTuThanhLy()
        {
            InitializeComponent();
            dtsoquy = new DataTable();
            dtvattu = new DataTable();
            LoadPhieuThanhLy();
            LoadVatTu();
            LoadSoQuy();
        }
        void LoadSoQuy()
        {
            dtsoquy= SoQuyDAO.Instance.GetSoQuy();
            gvquy.DataSource = dtsoquy;
            gvquy.DisplayMember = "TenSo";
            gvquy.ValueMember = "IdSoQuy";
        }
        void LoadVatTu()
        {
            dtvattu = VatTuDAO.Instance.GetVatTu();
            gvvattu.DataSource = dtvattu;
            gvvattu.DisplayMember = "TenVatTu";
            gvvattu.ValueMember = "IdVatTu";
        }
        void LoadPhieuThanhLy()
        {
            dtgvthanhly.DataSource = ThanhLyVatTuDAO.Instance.GetPhieuThanhLy();
        }

        private void btntaodon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhieuThanhLyVatTu phieuThanhLyVatTu = new PhieuThanhLyVatTu();
            phieuThanhLyVatTu.ShowDialog();
            LoadPhieuThanhLy();
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
                    FileName = "Danh sách trang thiết bị đã thanh lý.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(saveFileDialog.FileName);

                    using (ExcelPackage package = new ExcelPackage(file))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Danh sách trang thiết bị đã thanh lý");

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

                                if (gvmaster.Columns[j].FieldName == "IdVatTu")
                                {
                                    var thanhvienName = GetNameFromDataTable(dtvattu, "IdVatTu", cellValue, "TenVatTu");
                                    worksheet.Cells[i + 2, j + 1].Value = thanhvienName;
                                }
                                else if (gvmaster.Columns[j].FieldName == "IdSoQuy")
                                {
                                    var khoahocName = GetNameFromDataTable(dtsoquy, "IdSoQuy", cellValue, "TenSo");
                                    worksheet.Cells[i + 2, j + 1].Value = khoahocName;
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

        private void btncapnhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadPhieuThanhLy();
        }
    }
}