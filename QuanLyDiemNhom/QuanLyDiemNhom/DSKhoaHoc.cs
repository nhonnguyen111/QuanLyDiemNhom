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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Mail;
using System.Net;
using DevExpress.XtraGrid;

namespace QuanLyDiemNhom
{
    public partial class DSKhoaHoc : DevExpress.XtraEditors.XtraForm
    {
        private Dashboard Dashboard;
        private string email;
        public DSKhoaHoc(Dashboard dashboard, string email)
        {
            InitializeComponent();
            LoadKhoaHoc();
            Loadgiaovien();
            DemSoKhoaHoc();
            Dashboard = dashboard;
            this.email = email;
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;

        }
        void DemSoKhoaHoc()
        {
            int sokhoahoc = KhoaHocDAO.Instance.DemSoKhoaHoc();
            lbsokhoahoc.Caption = "Số lượng khóa học : " + sokhoahoc.ToString();
        }
        void Loadgiaovien()
        {
            gvgiaovien.DataSource = TaiKhoanDAO.Instance.GetTaiKhoans();
            gvgiaovien.DisplayMember = "HoTen";
            gvgiaovien.ValueMember = "IdUser";
        }
        void LoadKhoaHoc()
        {
            dtgvkhoahoc.DataSource = KhoaHocDAO.Instance.GetKhoaHoc();
        }

        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemKhoaHoc themKhoaHoc = new ThemKhoaHoc();
            themKhoaHoc.SetMode("Thêm");
            themKhoaHoc.ShowDialog();         
            LoadKhoaHoc();
            DemSoKhoaHoc();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var selectedRowHandle = gridView1.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                string tinhtrang = gridView1.GetRowCellValue(selectedRowHandle, "TinhTrang").ToString();
                if (tinhtrang == "Đã kết thúc")
                {
                    btnedit.Enabled = false;
                }
                else
                {
                    btnedit.Enabled = true;
                }
            }
            else
            {
                btnedit.Enabled = false;
            }
        }
        private void btnedit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gridView1.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idkhoahoc = Convert.ToInt32(gridView1.GetRowCellValue(selectedRowHandle, "IdKhoaHoc"));
                string tenkhoahoc = gridView1.GetRowCellValue(selectedRowHandle, "TenKhoaHoc").ToString();
                int idgiaovien = Convert.ToInt32(gridView1.GetRowCellValue(selectedRowHandle, "IdGiaoVien"));
                DateTime ngaybatdau = Convert.ToDateTime(gridView1.GetRowCellValue(selectedRowHandle, "NgayBatDau"));
                DateTime ngaykethuc = Convert.ToDateTime(gridView1.GetRowCellValue(selectedRowHandle, "NgayKetThuc"));
                string tinhtrang = gridView1.GetRowCellValue(selectedRowHandle, "TinhTrang").ToString();
                string thoigianhoc = gridView1.GetRowCellValue(selectedRowHandle, "LapLai").ToString();
                if(tinhtrang == "Đã kết thúc")
                {
                    btnedit.Enabled = false;
                }
                else
                {
                    btnedit.Enabled = true;
                    ThemKhoaHoc themKhoaHoc = new ThemKhoaHoc();
                    themKhoaHoc.SetMode("Sửa");
                    themKhoaHoc.SetValues(idkhoahoc, tenkhoahoc, idgiaovien, ngaybatdau, ngaykethuc, tinhtrang, thoigianhoc);
                    themKhoaHoc.ShowDialog();
                    LoadKhoaHoc();
                }
                
            }
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gridView1.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idkhoahoc = Convert.ToInt32(gridView1.GetRowCellValue(selectedRowHandle, "IdKhoaHoc"));
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    if (KhoaHocDAO.Instance.DeleteKhoaHoc(idkhoahoc))
                    {
                        MessageBox.Show("Xóa khóa học thành công");
                        
                    }
                    else
                    {
                        MessageBox.Show("Xóa khóa học thất bại");
                    }

                    LoadKhoaHoc();
                    DemSoKhoaHoc();
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

        private void btnchitietkhoahoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gridView1.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idkhoahoc = Convert.ToInt32(gridView1.GetRowCellValue(selectedRowHandle, "IdKhoaHoc"));

                Dashboard.OpenChiTietKhoaHoc(idkhoahoc, email);

            }
        }

        void SendClassNotification()
        {
            string gmail = email;
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

                        var fromAddress = new MailAddress(email);

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
        private void btnemail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SendClassNotification();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string searchValue = txttimkiem.Text.Trim();
            DataTable dtSearchResult = KhoaHocDAO.Instance.SearchKhoaHocByName(searchValue);

            // Liên kết GridControl với DataTable để hiển thị kết quả tìm kiếm
            dtgvkhoahoc.DataSource = dtSearchResult;
        }

        private void btncapnhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadKhoaHoc();
        }
    }
}