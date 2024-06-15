using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom.DAO
{
    public class KhoaHocDAO
    {
        private static KhoaHocDAO instance;

        public static KhoaHocDAO Instance
        {
            get { if (instance == null) instance = new KhoaHocDAO(); return instance; }
            private set { instance = value; }
        }
        private KhoaHocDAO() { }
        public DataTable GetKhoaHoc()
        {
            string query = "SELECT * FROM KhoaHoc";
            DataTable data = DataProvider.Instance.ExecuQuery(query);

            return data;
        }
        public DataTable GetKhoaHocByIdUser(int idgiaovien)
        {
            string query =string.Format("SELECT * FROM KhoaHoc where IdGiaoVien ={0}", idgiaovien);
            DataTable data = DataProvider.Instance.ExecuQuery(query);

            return data;
        }
        public bool InsertKhoaHoc(string tenkhoahoc, int idgiaovien, DateTime ngaybatdau, DateTime ngaykethuc, string tinhtrang, string laplai)
        {
            string query = string.Format(
                "INSERT INTO KhoaHoc (TenKhoaHoc, SoLuong, IdGiaoVien, NgayBatDau, NgayKetThuc, TinhTrang, LapLai) " +
                "VALUES (N'{0}', 0, {1}, '{2}', '{3}', N'{4}', N'{5}')",
                tenkhoahoc, idgiaovien, ngaybatdau, ngaykethuc, tinhtrang, laplai);

            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool InsertChungChi(string tenchungchi, string noidung, int idkhoahoc, int idthanhvien)
        {
            string query = string.Format("INSERT ChungChi(TenChungChi, NoiDung,IdKhoaHoc, IdThanhVien,NgayHoanThanh)VALUES(N'{0}', N'{1}', {2},{3},GETDATE())",
                tenchungchi,noidung, idkhoahoc, idthanhvien);

            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateKhoaHoc(string tenkhoahoc, int idgiaovien, DateTime ngaybatdau, DateTime ngaykethuc, string tinhtrang, string laplai, int idkhoahoc)
        {
            string query = string.Format(
                "UPDATE KhoaHoc SET TenKhoaHoc = N'{0}', IdGiaoVien = {1}, NgayBatDau = '{2}', NgayKetThuc = '{3}', " +
                "TinhTrang = N'{4}', LapLai = N'{5}' WHERE IdKhoaHoc = {6}",
                tenkhoahoc, idgiaovien, ngaybatdau, ngaykethuc, tinhtrang, laplai, idkhoahoc);

            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateKetThucKhoaHoc(int idkhoahoc)
        {
            string query = string.Format("UPDATE KhoaHoc SET TinhTrang = N'Đã kết thúc' WHERE IdKhoaHoc ={0}",
                idkhoahoc);

            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeleteKhoaHoc(int idkhoahoc)
        {
            string query = string.Format("DELETE KhoaHoc WHERE IdKhoaHoc ={0}",
                idkhoahoc);

            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public int DemSoKhoaHoc()
        {
            string query = "SELECT COUNT(*) FROM KhoaHoc";
            DataTable data = DataProvider.Instance.ExecuQuery(query);

            if (data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0][0]);
            }
            return 0;
        }
        public string GetEmailByIdKhoaHoc(int idkhoahoc)
        {
            string query = string.Format("SELECT b.Email FROM KhoaHoc a, TaiKhoan b  WHERE a.IdGiaoVien = b.IdUser AND a.IdKhoaHoc = {0}", idkhoahoc);
            DataTable data = DataProvider.Instance.ExecuQuery(query);

            if (data != null && data.Rows.Count > 0)
            {
                return data.Rows[0]["Email"].ToString();
            }

            return string.Empty;
        }
        public string GetTinhTrangByIdKhoaHoc(int idkhoahoc)
        {
            string query = string.Format("SELECT TinhTrang FROM KhoaHoc WHERE IdKhoaHoc = {0}", idkhoahoc);
            DataTable data = DataProvider.Instance.ExecuQuery(query);

            if (data != null && data.Rows.Count > 0)
            {
                return data.Rows[0]["TinhTrang"].ToString();
            }

            return string.Empty;
        }
        public string GetTenKhoaHocByIdKhoaHoc(int idkhoahoc)
        {
            string query = string.Format("SELECT TenKhoaHoc FROM KhoaHoc WHERE IdKhoaHoc = {0}", idkhoahoc);
            DataTable data = DataProvider.Instance.ExecuQuery(query);

            if (data != null && data.Rows.Count > 0)
            {
                return data.Rows[0]["TenKhoaHoc"].ToString();
            }

            return string.Empty;
        }
        public List<string> GetEmailThanhVienByIdKhoaHoc(int idkhoahoc)
        {
            string query = string.Format("SELECT b.Email FROM ChiTietKhoaHoc a, ThanhVien b WHERE a.IdThanhVien = b.IdThanhVien AND a.IdKhoaHoc = {0}", idkhoahoc);
            DataTable data = DataProvider.Instance.ExecuQuery(query);

            List<string> emailList = new List<string>();

            if (data != null && data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    emailList.Add(row["Email"].ToString());
                }
            }
            return emailList;
        }
        public DataTable SearchKhoaHocByName(string tenkhoahoc)
        {
            string query = string.Format("SELECT * FROM KhoaHoc WHERE LOWER(TenKhoaHoc) COLLATE Latin1_General_CI_AI LIKE '%' + LOWER(N'{0}') + '%';", tenkhoahoc);
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            return data;
        }
    }
}
