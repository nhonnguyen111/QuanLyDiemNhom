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
    public partial class DSPhieuVatTu : DevExpress.XtraEditors.XtraForm
    {
        private int iduser;
        private DataTable dtvattu;
        private DataTable dttennguoinhap;
        public DSPhieuVatTu(int iduser)
        {
            InitializeComponent();
            LoadPhieuVatTu();
            LoadTenVatTu();
            LoadTenNguoiNhap();
            this.iduser = iduser;
        }
        void LoadTenVatTu()
        {
            dtvattu = VatTuDAO.Instance.GetVatTu();
            gvvattu.DataSource = dtvattu;
            gvvattu.DisplayMember = "TenVatTu";
            gvvattu.ValueMember = "IdVatTu";

        }
        void LoadTenNguoiNhap()
        {
            dttennguoinhap = TaiKhoanDAO.Instance.GetTaiKhoans();
            gvnguoixuat.DataSource = dttennguoinhap;
            gvnguoixuat.DisplayMember = "HoTen";
            gvnguoixuat.ValueMember = "IdUser";
        }
        void LoadPhieuVatTu()
        {
            dtgvphieuvattu.DataSource = PhieuVatTuDAO.Instance.GetPhieuVatTu();
        }

        private void barLargeButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhieuXuatVatTu phieuXuatVatTu = new PhieuXuatVatTu(iduser);
            phieuXuatVatTu.ShowDialog();
            LoadPhieuVatTu();
        }

        private void btncapnhatphieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idphieu = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdPhieuVatTu"));
                int idvattu = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdVatTu"));
                int soluongxuat = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "SoLuongXuat"));
                DateTime ngayxuat = Convert.ToDateTime(gvmaster.GetRowCellValue(selectedRowHandle, "NgayXuat"));
                int idnguoixuat = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdNguoiXuat"));
                int soluongtra = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "SoLuongTra"));
                string noidung = gvmaster.GetRowCellValue(selectedRowHandle, "NoiSuDung").ToString();
                string nguoinhan = gvmaster.GetRowCellValue(selectedRowHandle, "NguoiNhan").ToString();
                CapNhatPhieuVatTu capNhatPhieuVatTu = new CapNhatPhieuVatTu(idphieu, soluongxuat, ngayxuat, idnguoixuat,noidung, nguoinhan, soluongtra,idvattu);
                capNhatPhieuVatTu.ShowDialog();
                LoadPhieuVatTu();
            }
        }

        private void barLargeButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idphieu = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdPhieuVatTu"));
                int idvattu = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdVatTu"));
                int soluongxuat = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "SoLuongXuat"));
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    if (PhieuVatTuDAO.Instance.DeletePhieu(idphieu))
                    {
                        VatTuDAO.Instance.UpdateVatTuTonKhoTraLai(soluongxuat, idvattu);
                        VatTuDAO.Instance.UpdateVatTuSuDungXong(soluongxuat, idvattu);
                        MessageBox.Show("Xóa phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa phiếu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadPhieuVatTu();
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
        private void btnexcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            if (gvmaster.RowCount > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                    FileName = "Danh sách phiếu vật tư.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(saveFileDialog.FileName);

                    using (ExcelPackage package = new ExcelPackage(file))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Danh sách phiếu vật tư");

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
                                    var vattuname = GetNameFromDataTable(dtvattu, "IdVatTu", cellValue, "TenVatTu");
                                    worksheet.Cells[i + 2, j + 1].Value = vattuname;
                                }
                                else if (gvmaster.Columns[j].FieldName == "IdNguoiXuat")
                                {
                                    var khoahocName = GetNameFromDataTable(dttennguoinhap, "IdUser", cellValue, "HoTen");
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
            LoadPhieuVatTu();
        }
    }
}