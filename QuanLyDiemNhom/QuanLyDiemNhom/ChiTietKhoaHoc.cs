using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
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
using DevExpress.XtraGrid.Views.Grid;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Mail;
using System.Net;
using QuanLyDiemNhom.DTO;

namespace QuanLyDiemNhom
{
    public partial class ChiTietKhoaHoc : DevExpress.XtraEditors.XtraForm
    {
        private int idkhoahoc;
        private DataTable dtThanhVien;
        private DataTable dtKhoaHoc;
        private string email;

        public ChiTietKhoaHoc(int idkhoahoc, string email)
        {
            InitializeComponent();
            this.idkhoahoc = idkhoahoc;
            LoadChiTietKhoaHoc();
            LoadThanhVien();
            LoadKhoaHoc();
            DemSoThanhVien();
            this.email = email;
        }

        void DemSoThanhVien()
        {
            int sothanhvien = ChiTietKhoaHocDAO.Instance.DemSoThanhVien(idkhoahoc);
            lbsoluonghocsinh.Caption = "Số lượng học sinh :" + sothanhvien.ToString();
        }

        void LoadThanhVien()
        {
            dtThanhVien = ThanhVienDAO.Instance.GetThanhVien();
            gvhocisnh.DataSource = dtThanhVien;
            gvhocisnh.DisplayMember = "HoTen";
            gvhocisnh.ValueMember = "IdThanhVien";
        }

        void LoadKhoaHoc()
        {
            dtKhoaHoc = KhoaHocDAO.Instance.GetKhoaHoc();
            gvkhoahoc.DataSource = dtKhoaHoc;
            gvkhoahoc.DisplayMember = "TenKhoaHoc";
            gvkhoahoc.ValueMember = "IdKhoaHoc";
        }

        void LoadChiTietKhoaHoc()
        {
            dtgvchitietkhoahoc.DataSource = ChiTietKhoaHocDAO.Instance.GetChiTietKhoaHoc(idkhoahoc);
        }

        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemHocSinh themHocSinh = new ThemHocSinh(idkhoahoc);
            themHocSinh.ShowDialog();
            LoadChiTietKhoaHoc();
            DemSoThanhVien();
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idchitietkhoahoc = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdChiTietKhoaHoc"));

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    if (ChiTietKhoaHocDAO.Instance.DeleteThanhVien(idchitietkhoahoc))
                    {
                        MessageBox.Show("Xóa thành viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadChiTietKhoaHoc();
                        DemSoThanhVien();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thành viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                    FileName = "Danh sách thành viên trong khóa học.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(saveFileDialog.FileName);

                    using (ExcelPackage package = new ExcelPackage(file))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Danh sách thành viên trong khóa học");

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

                                if (gvmaster.Columns[j].FieldName == "IdThanhVien")
                                {
                                    var thanhvienName = GetNameFromDataTable(dtThanhVien, "IdThanhVien", cellValue, "HoTen");
                                    worksheet.Cells[i + 2, j + 1].Value = thanhvienName;
                                }
                                else if (gvmaster.Columns[j].FieldName == "IdKhoaHoc")
                                {
                                    var khoahocName = GetNameFromDataTable(dtKhoaHoc, "IdKhoaHoc", cellValue, "TenKhoaHoc");
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

        private string GetNameFromDataTable(DataTable dataTable, string keyFieldName, object keyFieldValue, string valueFieldName)
        {
            DataRow[] rows = dataTable.Select($"{keyFieldName} = {keyFieldValue}");
            if (rows.Length > 0)
            {
                return rows[0][valueFieldName].ToString();
            }
            return null;
        }
        void NotiEMail()
        {
            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idkhoahoc = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdKhoaHoc"));
                int idthanhvien = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdThanhVien"));
                try
                {
                    string tenkhoahoc = ChiTietKhoaHocDAO.Instance.GetTenKhoaHocById(idkhoahoc);
                    string emailnhan = ChiTietKhoaHocDAO.Instance.GetEmailThanhVienByIdKhoaHoc(idkhoahoc, idthanhvien);
                    var fromAdress = new MailAddress(email);
                    var toAdress = new MailAddress(emailnhan);
                    const string frompass = "lzxmhlhtpophksbg";
                    const string subject = "Thông báo từ quản lý";
                    string body = "Bạn được thêm vào khóa học " + tenkhoahoc;
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAdress.Address, frompass),
                        Timeout = 200000
                    };
                    using (var message = new MailMessage(fromAdress, toAdress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(message);
                    }
                    MessageBox.Show("Gửi thông báo thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }
        private void btnthongbao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NotiEMail();
        }

        private void btnketthuckhoahoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string tinhtrang = KhoaHocDAO.Instance.GetTinhTrangByIdKhoaHoc(idkhoahoc);
            if ( tinhtrang == "Đã kết thúc" ) 
            { 
                btnketthuckhoahoc.Enabled = false;
                btnthem.Enabled = false;    
                btnxoa.Enabled = false;
                btnthongbao.Enabled = false;
            }
            else
            {
                btnketthuckhoahoc.Enabled = true;
                var selectedRowHandle = gvmaster.FocusedRowHandle;
                if (selectedRowHandle >= 0)
                {
                    int idkhoahoc = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdKhoaHoc"));
                    string tenkhoahoc = KhoaHocDAO.Instance.GetTenKhoaHocByIdKhoaHoc(idkhoahoc);
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn kết thúc khóa học không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    string tenchungchi = ($"Chứng chỉ {tenkhoahoc}");
                    string noidung = "Đã hoàn thành khóa học";
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (KhoaHocDAO.Instance.UpdateKetThucKhoaHoc(idkhoahoc))
                        {
                            for (int i = 0; i < gvmaster.RowCount; i++)
                            {
                                int idthanhvien = Convert.ToInt32(gvmaster.GetRowCellValue(i, "IdThanhVien"));
                                int rowIdKhoaHoc = Convert.ToInt32(gvmaster.GetRowCellValue(i, "IdKhoaHoc"));

                                if (rowIdKhoaHoc == idkhoahoc)
                                {
                                    KhoaHocDAO.Instance.InsertChungChi(tenchungchi, noidung, idkhoahoc, idthanhvien);
                                }
                            }

                            MessageBox.Show("Khóa học đã kết thúc và chứng chỉ đã được thêm cho tất cả các thành viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }

        }
    }
}
