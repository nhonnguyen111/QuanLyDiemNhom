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
    public partial class BangKePhieuThu : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dtsoquy;
        private DataTable dtloaithu;
        public BangKePhieuThu()
        {
            InitializeComponent();
            dtloaithu = new DataTable();
            dtsoquy =  new DataTable();
            LoadPhieuThu();
            LoadSoQuy();
            LoadLoaiThu();
        }
        void LoadSoQuy()
        {
            dtsoquy = SoQuyDAO.Instance.GetSoQuy();
            gvsoquy.DataSource = dtsoquy;
            gvsoquy.DisplayMember = "TenSo";
            gvsoquy.ValueMember = "IdSoQuy";
        }
        void LoadLoaiThu()
        {
            dtloaithu = LoaiThuDAO.Instance.GetLoaiThu();
            gvloaithu.DataSource = dtloaithu;
            gvloaithu.DisplayMember = "TenLoaiThu";
            gvloaithu.ValueMember = "IdLoaiThu";
        }
        void LoadPhieuThu()
        {
            dtgvphieuthu.DataSource =  PhieuThuDAO.Instance.GetBangKePhieuThu();
        }

        private void btntaophieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhieuThu phieuThu = new PhieuThu();
            phieuThu.ShowDialog();
            LoadPhieuThu();
        }

        private void btnxoaphieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idphieu = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdPhieuThu"));

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    if (PhieuThuDAO.Instance.DeletePhieuThu(idphieu))
                    {
                        MessageBox.Show("Xóa phiếu thu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa phiêu thu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadPhieuThu();
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
                    FileName = "Danh sách phiếu thu.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(saveFileDialog.FileName);

                    using (ExcelPackage package = new ExcelPackage(file))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Danh sách phiếu thu");

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

                                if (gvmaster.Columns[j].FieldName == "IdSoQuy")
                                {
                                    var vattuname = GetNameFromDataTable(dtsoquy, "IdSoQuy", cellValue, "TenSo");
                                    worksheet.Cells[i + 2, j + 1].Value = vattuname;
                                }
                                else if (gvmaster.Columns[j].FieldName == "IdLoaiThu")
                                {
                                    var khoahocName = GetNameFromDataTable(dtloaithu, "IdLoaiThu", cellValue, "TenLoaiThu");
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
            LoadPhieuThu();
        }
    }
}