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
using static DevExpress.XtraEditors.Mask.MaskSettings;
using LicenseContext = OfficeOpenXml.LicenseContext;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Mail;
using System.Net;

namespace QuanLyDiemNhom
{
    public partial class ChiTietBanNganh : DevExpress.XtraEditors.XtraForm
    {
        private int idbannganh;
        private string email;
        public ChiTietBanNganh(int idbannganh, string email)
        {
            InitializeComponent();
            this.idbannganh = idbannganh;
            LoadChiTietBanNganh();
            LoadThanhVien();
            LoadBan();
            DemSoThanhVien();
            LoadTenQuanLy();
            this.email = email;
        }
        void LoadTenQuanLy()
        {
            DataTable tenquanly = ChiTietBanNganhDAO.Instance.GetTenQuanLy(idbannganh);
            if (tenquanly.Rows.Count > 0) 
            {
                btnlead.Caption = "Quản lý " + tenquanly.Rows[0][0].ToString();
            }
            else
            {
                btnlead.Caption = "Không có quản lý";
            }
        }
        void DemSoThanhVien()
        {
            int sothanhvien = ChiTietBanNganhDAO.Instance.DemSoThanhVien(idbannganh);
            lbsothanhvien.Caption = "Số thành viên trong ban : " + sothanhvien.ToString();
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
            DemSoThanhVien();
            SendEmailThanhVien();
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
                        DemSoThanhVien();
                    }
                        else
                        {
                            MessageBox.Show("Xóa thành viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        
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

        private void btnlead_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemQuanLyBan themQuanLyBan = new ThemQuanLyBan(idbannganh);
            themQuanLyBan.ShowDialog();
            LoadTenQuanLy();
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
                        var fromAddress = new MailAddress(email);
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

        private void btnthongbaoemail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SendEmailThanhVien();
        }
    }
}