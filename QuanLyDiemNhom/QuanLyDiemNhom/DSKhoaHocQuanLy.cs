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
    public partial class DSKhoaHocQuanLy : DevExpress.XtraEditors.XtraForm
    {
        private int iduser;
        private DashboardQuanLy dashboard;
        public DSKhoaHocQuanLy(int iduser, DashboardQuanLy dashboard)
        {
            InitializeComponent();
            this.iduser = iduser;
            this.dashboard = dashboard;
            LoadKhoaHocQuanLy();
            Loadgiaovien();
        }
        void Loadgiaovien()
        {
            gvgiaovien.DataSource = TaiKhoanDAO.Instance.GetTaiKhoans();
            gvgiaovien.DisplayMember = "HoTen";
            gvgiaovien.ValueMember = "IdUser";
        }
        void LoadKhoaHocQuanLy()
        {
            dtgvkhoahoc.DataSource = KhoaHocDAO.Instance.GetKhoaHocByIdUser(iduser);
        }
        void SendClassNotification()
        {
            string gmail = "nhonnguyen1112333@gmail.com";
            const string fromPass = "lzxmhlhtpophksbg";
            string subject = "Thông báo từ quản lý";
            string[] daysOfWeek = { "Chủ nhật", "Thứ hai", "Thứ ba", "Thứ tư", "Thứ năm", "Thứ sáu", "Thứ bảy" };

            string currentDay = daysOfWeek[(int)DateTime.Now.DayOfWeek];

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                string thoigian = gridView1.GetRowCellValue(i, "LapLai").ToString();
                string[] thoigianArray = thoigian.Split(',');

                // Trim any leading/trailing whitespace from each day and check if current day is in the list
                bool shouldNotify = thoigianArray.Any(day => day.Trim() == currentDay);

                if (shouldNotify)
                {
                    int idkhoahoc = Convert.ToInt32(gridView1.GetRowCellValue(i, "IdKhoaHoc"));
                    int idthanhvien = Convert.ToInt32(gridView1.GetRowCellValue(i, "IdGiaoVien"));
                    try
                    {
                        string emailnhan = KhoaHocDAO.Instance.GetEmailByIdKhoaHoc(idkhoahoc);

                        string tenkhoahoc = ChiTietKhoaHocDAO.Instance.GetTenKhoaHocById(idkhoahoc);
                        List<string> emailList = KhoaHocDAO.Instance.GetEmailThanhVienByIdKhoaHoc(idkhoahoc);

                        // Add the course email to the list if not already in it
                        if (!emailList.Contains(emailnhan))
                        {
                            emailList.Add(emailnhan);
                        }

                        var fromAddress = new MailAddress(gmail);

                        // Email body
                        string body = "Hôm nay là ngày lên lớp cho khóa học " + tenkhoahoc;

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

                        // Send email to each member
                        foreach (string memberEmail in emailList)
                        {
                            var toAddress = new MailAddress(memberEmail);

                            using (var message = new MailMessage(fromAddress, toAddress)
                            {
                                Subject = subject,
                                Body = body
                            })
                            {
                                smtp.Send(message);
                            }
                        }

                        MessageBox.Show("Gửi thông báo thành công cho khóa học " + tenkhoahoc);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi gửi thông báo cho khóa học : " + ex.Message);
                    }
                }
            }

        }
        private void btnthongbao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SendClassNotification();
        }

        private void btnxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            if (gridView1.RowCount > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                    FileName = "Danh sách khóa học.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(saveFileDialog.FileName);

                    using (ExcelPackage package = new ExcelPackage(file))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Danh sách khóa học");


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
            LoadKhoaHocQuanLy();
        }

        private void btnchitiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gridView1.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idkhoahoc = Convert.ToInt32(gridView1.GetRowCellValue(selectedRowHandle, "IdKhoaHoc"));

                dashboard.OpenChiTietKhoaHocQuanLy(idkhoahoc);

            }
        }
    }
}