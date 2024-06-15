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
    public partial class DSNhanSu : DevExpress.XtraEditors.XtraForm
    {
        private int iduser;
        public DSNhanSu(int iduser)
        {
            InitializeComponent();
            this.iduser = iduser;
            LoadNhanSu();
            LoadQuyen();
            DemSoNhanSu();
        }

        void DemSoNhanSu()
        {
            int sonhansu = TaiKhoanDAO.Instance.DemSoTaiKhoan();
            lbsoluong.Caption = "Số lượng nhân sự : " + sonhansu.ToString();
        }
        void LoadQuyen()
        {
            dtgvquyen.DataSource = TaiKhoanDAO.Instance.GetQuyen();
            dtgvquyen.DisplayMember = "TenQuyen";
            dtgvquyen.ValueMember = "IdQuyen";
        }
        void LoadNhanSu()
        {
            dtgvNhanSu.DataSource = TaiKhoanDAO.Instance.GetTaiKhoans();
        }
        private void DSNhanSu_Load(object sender, EventArgs e)
        {

        }

        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemNhanSu themNhanSu = new ThemNhanSu();
            themNhanSu.ShowDialog();
            LoadNhanSu();
            DemSoNhanSu();
        }

        private void btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gridView1.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int iduser = Convert.ToInt32(gridView1.GetRowCellValue(selectedRowHandle, "IdUser"));
                int tenquyen = Convert.ToInt32(gridView1.GetRowCellValue(selectedRowHandle, "IdQuyen"));
                
                SuaNhanSu suaNhanSu = new SuaNhanSu(iduser, tenquyen);
                suaNhanSu.ShowDialog();
             
                LoadNhanSu();
            }
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gridView1.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int iduserr = Convert.ToInt32(gridView1.GetRowCellValue(selectedRowHandle, "IdUser"));
                if(iduserr == iduser)
                {
                    MessageBox.Show("Nhân sự đang sử dụng không thể xóa");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        if (TaiKhoanDAO.Instance.DeleteTaiKhoan(iduserr))
                        {
                            MessageBox.Show("Xóa nhân sự thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Xóa nhân sự thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        LoadNhanSu();
                        DemSoNhanSu();
                    }
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
                    FileName = "Danh sách nhân sự.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(saveFileDialog.FileName);

                    using (ExcelPackage package = new ExcelPackage(file))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Danh sách nhân sự");

                        // Thêm tiêu đề cho các cột
                        for (int i = 0; i < gridView1.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = gridView1.Columns[i].Caption; // Sử dụng Caption cho tiêu đề cột
                            worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                            worksheet.Cells[1, i + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            worksheet.Cells[1, i + 1].Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                            worksheet.Cells[1, i + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        }

                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            for (int j = 0; j < gridView1.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = gridView1.GetRowCellValue(i, gridView1.Columns[j]);
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
            LoadNhanSu();
        }
    }
}