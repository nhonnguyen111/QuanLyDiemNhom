using DevExpress.XtraEditors;
using QuanLyDiemNhom.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.IO;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace QuanLyDiemNhom
{
    public partial class ChiTietBanNganhQuanLy : DevExpress.XtraEditors.XtraForm
    {
        private int idbannganh;
        public ChiTietBanNganhQuanLy(int idbannganh)
        {
            InitializeComponent();
            this.idbannganh = idbannganh;
            LoadThanhVien();
            LoadBan();
            LoadChiTietBanNganh();
        }
        void LoadThanhVien()
        {
            gvThanhVien.DataSource = ThanhVienDAO.Instance.GetThanhVien();
            gvThanhVien.DisplayMember = "HoTen";
            gvThanhVien.ValueMember = "IdThanhVien";
        }
        void LoadBan()
        {
            gvbannganh.DataSource = BanNganhDAO.Instance.GetBanNganh();
            gvbannganh.DisplayMember = "TenBanNganh";
            gvbannganh.ValueMember = "IdBanNganh";
        }
        void LoadChiTietBanNganh()
        {
            dtgvchitiet.DataSource = ChiTietBanNganhDAO.Instance.GetChiTietBanNganh(idbannganh);
        }

        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemThanhVien themThanhVien = new ThemThanhVien(idbannganh);
            themThanhVien.ShowDialog();
            LoadChiTietBanNganh();
            SendEmailThanhVien();
        }
        void SendEmailThanhVien()
        {
            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idbannganh = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdBanNganh"));
                int idhthanhvien = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdThanhVien"));
                try
                {
                    string emailnhan = BanNganhDAO.Instance.GetEmailByIdThanhVien(idbannganh, idhthanhvien);
                    string tenbanganh = BanNganhDAO.Instance.GetTenBanNganhById(idbannganh);
                    if (!string.IsNullOrEmpty(emailnhan))
                    {
                        var fromAddress = new MailAddress("nhonnguyen1112333@gmail.com");
                        var toAddress = new MailAddress(emailnhan);
                        const string fromPass = "lzxmhlhtpophksbg";
                        const string subject = "Thông báo từ quản lý";
                        string body = "Bạn đã được thêm vào " + tenbanganh;

                        var smtp = new SmtpClient
                        {
                            Host = "smtp.gmail.com",
                            Port = 587,
                            EnableSsl = true,
                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            UseDefaultCredentials = false,
                            Credentials = new NetworkCredential(fromAddress.Address, fromPass),
                            Timeout = 200000
                        };

                        using (var message = new MailMessage(fromAddress, toAddress)
                        {
                            Subject = subject,
                            Body = body
                        })
                        {
                            smtp.Send(message);
                        }

                        MessageBox.Show("Đã gửi thông báo đến thành viên thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không có email nào để gửi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idchitietbanngnah = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdChiTietBanNganh"));

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    if (ChiTietBanNganhDAO.Instance.DeleteThanhVien(idchitietbanngnah))
                    {
                        MessageBox.Show("Xóa thành viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadChiTietBanNganh();
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
                    FileName = "Danh sách thành viên trong ban.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(saveFileDialog.FileName);

                    using (ExcelPackage package = new ExcelPackage(file))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Danh sách thành viên trong ban");

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

        private void btnthongbao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SendEmailThanhVien();
        }
    }
}