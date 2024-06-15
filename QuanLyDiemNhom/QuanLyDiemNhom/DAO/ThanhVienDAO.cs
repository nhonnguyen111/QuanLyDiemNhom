using QuanLyDiemNhom.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom.DAO
{
    public class ThanhVienDAO
    {
        private static ThanhVienDAO instance;

        public static ThanhVienDAO Instance
        {
            get { if (instance == null) instance = new ThanhVienDAO(); return instance; }
            private set { instance = value; }
        }
        private ThanhVienDAO() { }
        public DataTable GetThanhVien()
        {
            // Tạo câu truy vấn SQL
            string query = "SELECT * FROM ThanhVien";
            DataTable data = DataProvider.Instance.ExecuQuery(query);

            // Trả về DataTable
            return data;
        }
        public int DemSoThanhVien()
        {
            string query = "SELECT COUNT(*) FROM ThanhVien";
            DataTable data = DataProvider.Instance.ExecuQuery(query);

            if (data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0][0]);
            }
            return 0;
        }
        public string GetTenByIdThanhVien(int idthanhvien)
        {
            string query = string.Format("SELECT HoTen FROM ThanhVien WHERE IdThanhVien = {0}", idthanhvien);
            DataTable data = DataProvider.Instance.ExecuQuery(query);

            if (data != null && data.Rows.Count > 0)
            {
                return data.Rows[0]["HoTen"].ToString();
            }

            return string.Empty;
        }
        public bool InsertThanhVien(string hoten, string email, string sdt, string diachi, string khuvuc, string gioitinh, string honnhan,DateTime ngaysinh)
        {
            string query = string.Format("INSERT ThanhVien (HoTen, Email,SoDienThoai, DiaChi, KhuVuc, GioiTinh, HonNhan,NgayThamGia, NgaySinh)VALUES(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',GETDATE(),'{7}')",hoten, email, sdt, diachi , khuvuc,gioitinh, honnhan, ngaysinh);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateThanhVien(string hoten, string email, string sdt, string diachi, string khuvuc, string gioitinh, string honnhan, DateTime ngaysinh, int idthanhvien)
        {
            string query = string.Format("UPDATE ThanhVien SET HoTen =N'{0}', Email=N'{1}',SoDienThoai=N'{2}', DiaChi=N'{3}', KhuVuc=N'{4}', GioiTinh=N'{5}', HonNhan=N'{6}', NgaySinh ='{7}' WHERE IdThanhVien ={8} ", hoten, email, sdt, diachi, khuvuc, gioitinh, honnhan, ngaysinh,idthanhvien);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeleteThanhVien( int idthanhvien)
        {
            string query = string.Format("DELETE ThanhVien WHERE IdThanhVien ={0}", idthanhvien);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public DataTable SearchThanhVienByName(string hoten)
        {
            string query = string.Format("SELECT * FROM ThanhVien WHERE LOWER(HoTen) COLLATE Latin1_General_CI_AI LIKE '%' + LOWER(N'{0}') + '%';", hoten);
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            return data;
        }
        public DataTable SearchThanhVienByGioiTinh(string gioitinh)
        {
            string query = string.Format("SELECT * FROM ThanhVien WHERE LOWER(GioiTinh) COLLATE Latin1_General_CI_AI LIKE '%' + LOWER(N'{0}') + '%';", gioitinh);
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            return data;
        }
        public DataTable SearchThanhVienByHonNhan(string honnhan)
        {
            string query = string.Format("SELECT * FROM ThanhVien WHERE LOWER(HonNhan) COLLATE Latin1_General_CI_AI LIKE '%' + LOWER(N'{0}') + '%';", honnhan);
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            return data;
        }
    }
}
