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
using static DevExpress.XtraEditors.Mask.MaskSettings;
using LicenseContext = OfficeOpenXml.LicenseContext;
using System.Net.Mail;
using System.Net;
using DevExpress.XtraGrid;

namespace QuanLyDiemNhom
{
    public partial class DSBanNganh : DevExpress.XtraEditors.XtraForm
    {
        private Dashboard dashboard;
        private string email;
        public DSBanNganh(Dashboard dashboard, string email)
        {
            InitializeComponent();
            LoadBanNganh();
            DemSoBanNganh();
           
            this.dashboard = dashboard;
            this.email = email;
        }

        void DemSoBanNganh()
        {
            int sobannganh = BanNganhDAO.Instance.DemSoBanNganh();
            lbsoluong.Caption = "Tổng số ban : " + sobannganh.ToString();
        }
        
        void LoadBanNganh()
        {
            dtgvbannganh.DataSource = BanNganhDAO.Instance.GetBanNganh();
           
        }

        private void btnthen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemBanNganh themBanNganh = new ThemBanNganh();
            themBanNganh.ShowDialog();
            LoadBanNganh();
            DemSoBanNganh();
        }

        private void btnsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idBanNganh = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdBanNganh"));
                string tenbannganh =gvmaster.GetRowCellValue(selectedRowHandle, "TenBanNganh").ToString();
                string hoatdong = gvmaster.GetRowCellValue(selectedRowHandle, "HoatDong").ToString();
                string thoigian = gvmaster.GetRowCellValue(selectedRowHandle, "ThoiGian").ToString();
                int laplai = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "LapLai"));
                SuaBanNganh suaBanNganh = new SuaBanNganh(idBanNganh,tenbannganh,hoatdong,thoigian,laplai);
                suaBanNganh.ShowDialog(); 
                LoadBanNganh();
            }
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idbannganh = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdBanNganh"));
               
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        if (BanNganhDAO.Instance.DeleteBanNganh(idbannganh))
                        {
                            MessageBox.Show("Xóa ban thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Xóa ban thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    LoadBanNganh();
                    DemSoBanNganh();
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
                    FileName = "Danh sách ban ngành.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(saveFileDialog.FileName);

                    using (ExcelPackage package = new ExcelPackage(file))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Danh sách ban ngành");

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
        void SendEmailThanhVien()
        {
            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idbannganh = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdBanNganh"));
                string tenbanganh = gvmaster.GetRowCellValue(selectedRowHandle, "TenBanNganh").ToString();
                try
                {
                    List<string> emailnhan = BanNganhDAO.Instance.GetEmailThanhVienByIdBanNganh(idbannganh);
                    if (emailnhan != null && emailnhan.Count > 0)
                    {
                        var fromAddress = new MailAddress(email);
                        const string fromPass = "lzxmhlhtpophksbg";
                        const string subject = "Thông báo từ quản lý";
                        string body = "Hôm nay là ngày hoạt động của " + tenbanganh;

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

                        using (var message = new MailMessage()
                        {
                            From = fromAddress,
                            Subject = subject,
                            Body = body
                        })
                        {
                            foreach (string email in emailnhan)
                            {
                                message.To.Add(new MailAddress(email));
                            }

                            smtp.Send(message);
                        }

                        MessageBox.Show("Đã gửi thông báo thành công tới " + tenbanganh);
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

        private void btnchitiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idbannganh = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdBanNganh"));

                dashboard.OpenChiTietBanNganh(idbannganh, email);

            }
        }

        private void btnsentmail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idbannganh = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdBanNganh"));
                string tenbanganh = gvmaster.GetRowCellValue(selectedRowHandle, "TenBanNganh").ToString();
                try
                {
                    string emailnhan = BanNganhDAO.Instance.GetEmailByIdBanNganh(idbannganh);
                    var fromAdress = new MailAddress(email);
                    var toAdress = new MailAddress(emailnhan);
                    const string frompass = "lzxmhlhtpophksbg";
                    const string subject = "Thông báo từ quản lý";
                    string body = "Hôm nay là ngày hoạt động của " + tenbanganh;
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

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            SendEmailThanhVien();


        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string searchValue = txttimkiem.Text.Trim();
            DataTable dtSearchResult = BanNganhDAO.Instance.SearchBanNganhByName(searchValue);

            // Liên kết GridControl với DataTable để hiển thị kết quả tìm kiếm
            dtgvbannganh.DataSource = dtSearchResult;
        }

        private void checklaplai_CheckedChanged(object sender, EventArgs e)
        {
            if (checklaplai.Checked)
            {
                DataTable dtSearchResult = BanNganhDAO.Instance.SearchBanNganhByLapLai(1);
                dtgvbannganh.DataSource = dtSearchResult;
            }
            else
            {
                LoadBanNganh(); // Gọi lại hàm LoadThanhVien() để tải lại dữ liệu ban đầu
            }
        }

        private void checkkolaplai_CheckedChanged(object sender, EventArgs e)
        {
            if (checkkolaplai.Checked)
            {
                DataTable dtSearchResult = BanNganhDAO.Instance.SearchBanNganhByLapLai(0);
                dtgvbannganh.DataSource = dtSearchResult;
            }
            else
            {
                LoadBanNganh(); // Gọi lại hàm LoadThanhVien() để tải lại dữ liệu ban đầu
            }
        }

        private void btncapnhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadBanNganh();
        }
    }
}
