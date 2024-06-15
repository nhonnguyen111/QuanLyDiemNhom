using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using QuanLyDiemNhom.DAO;
using QuanLyDiemNhom.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;

namespace QuanLyDiemNhom
{
    public partial class DSChungChi : DevExpress.XtraEditors.XtraForm
    {

        public DSChungChi()
        {
            InitializeComponent();
            LoadChungChi();
            LoadKhoaHoc();
            LoadHocSinh();
             
        }
        void LoadKhoaHoc()
        {
            gvkhoahoc.DataSource = KhoaHocDAO.Instance.GetKhoaHoc();
            gvkhoahoc.DisplayMember = "TenKhoaHoc";
            gvkhoahoc.ValueMember = "IdKhoaHoc";
        }
        void LoadHocSinh()
        {
            gvthanhvien.DataSource = ThanhVienDAO.Instance.GetThanhVien();
            gvthanhvien.DisplayMember = "HoTen";
            gvthanhvien.ValueMember = "IdThanhVien";
        }
        void LoadChungChi()
        {
            dtgvchungchi.DataSource = ChungChiDAO.Instance.GetChungChi();
        }

        private void btnxuatchungchi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idthanhvien = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdThanhVien"));
                int  idkhoahoc = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdKhoaHoc"));
                DateTime ngayHoanThanh = Convert.ToDateTime(gvmaster.GetRowCellValue(selectedRowHandle, "NgayHoanThanh"));
                string tenkhoahoc = KhoaHocDAO.Instance.GetTenKhoaHocByIdKhoaHoc(idkhoahoc);
                string hoten = ThanhVienDAO.Instance.GetTenByIdThanhVien(idthanhvien);
                ExportCertificate(hoten, tenkhoahoc, ngayHoanThanh);
            }
        }
        private void ExportCertificate(string hoTen, string tenKhoaHoc, DateTime ngayHoanThanh)
        {
            var doc = DocX.Create(@"C:\Users\nhonn\OneDrive\Documents\Chứng chỉ\Chứng chỉ.docx");

            // Title
            var titleParagraph = doc.InsertParagraph("CHỨNG CHỈ KHÓA HỌC")
                                    .FontSize(20)
                                    .Bold()
                                    .SpacingAfter(20);
            titleParagraph.Alignment = Xceed.Document.NET.Alignment.center;


            // Recipient's Name
            var nameParagraph = doc.InsertParagraph($"Chứng nhận tín hữu: {hoTen}\n")
                                   .FontSize(14)
                                   .SpacingAfter(10);
            nameParagraph.Alignment = Xceed.Document.NET.Alignment.left;

            // Course Name
            var courseParagraph = doc.InsertParagraph($"Đã hoàn thành khóa học: {tenKhoaHoc}\n")
                                     .FontSize(14)
                                     .SpacingAfter(10);
            courseParagraph.Alignment = Xceed.Document.NET.Alignment.left;

            // Completion Date
            var dateParagraph = doc.InsertParagraph($"Ngày hoàn thành: {ngayHoanThanh.ToShortDateString()}\n")
                                   .FontSize(14)
                                   .SpacingAfter(40);
            dateParagraph.Alignment = Xceed.Document.NET.Alignment.left;

            // Congratulatory Message
            var congratsParagraph = doc.InsertParagraph("Chúc mừng!\n")
                                       .FontSize(16)
                                       .SpacingAfter(50);
            congratsParagraph.Alignment = Xceed.Document.NET.Alignment.right;

            // Signature Section
            var signatureParagraph = doc.InsertParagraph("______________________________\n")
                                        .FontSize(14)
                                        .SpacingBefore(50)
                                        .SpacingAfter(10);
            signatureParagraph.Alignment = Xceed.Document.NET.Alignment.right;

            var responsiblePersonParagraph = doc.InsertParagraph("Người chịu trách nhiệm\n")
                                                .FontSize(14);
            responsiblePersonParagraph.Alignment = Xceed.Document.NET.Alignment.right;

            // Save the document
            doc.Save();

            MessageBox.Show("Chứng chỉ đã được xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var selectedRowHandle = gvmaster.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int idchungchi = Convert.ToInt32(gvmaster.GetRowCellValue(selectedRowHandle, "IdChungChi"));
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    if (ChungChiDAO.Instance.DeleteChungChi(idchungchi))
                    {
                        MessageBox.Show("Xóa chứng chỉ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa chứng chỉ thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadChungChi();
                }

            }
        }

        private void btncapnhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadChungChi();
        }
        
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string searchValue = txttimkiem.Text.Trim();
            DataTable dtSearchResult = ChungChiDAO.Instance.SearchChungChiByName(searchValue);

            // Liên kết GridControl với DataTable để hiển thị kết quả tìm kiếm
            dtgvchungchi.DataSource = dtSearchResult;
        }
    }
    
    
}
