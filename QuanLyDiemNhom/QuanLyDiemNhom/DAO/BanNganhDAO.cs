using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom.DAO
{
    public class BanNganhDAO
    {
        private static BanNganhDAO instance;

        public static BanNganhDAO Instance
        {
            get { if (instance == null) instance = new BanNganhDAO(); return instance; }
            private set { instance = value; }
        }
        private BanNganhDAO() { }
        public DataTable GetBanNganh()
        {
         
            string query = "SELECT a.IdBanNganh, a.TenBanNganh, COUNT(b.IdChiTietBanNganh) AS SoLuong, a.HoatDong, a.LapLai, a.ThoiGian FROM BanNganh a LEFT JOIN ChiTietBanNganh b ON a.IdBanNganh = b.IdBanNganh GROUP BY a.IdBanNganh, a.TenBanNganh, a.HoatDong, a.LapLai, a.ThoiGian";
            DataTable data = DataProvider.Instance.ExecuQuery(query);

           
            return data;
        }
        public DataTable GetBanNganhByIdUser(int iduser)
        {

            string query =string.Format("SELECT a.IdBanNganh, a.TenBanNganh, COUNT(b.IdChiTietBanNganh) AS SoLuong, a.HoatDong, a.LapLai, a.ThoiGian FROM BanNganh a LEFT JOIN ChiTietBanNganh b ON a.IdBanNganh = b.IdBanNganh JOIN QuanLyJoinBanNganh q ON a.IdBanNganh = q.IdBanNganh WHERE q.IdUser = {0} GROUP BY a.IdBanNganh, a.TenBanNganh, a.HoatDong, a.LapLai,  a.ThoiGian;",iduser);
            DataTable data = DataProvider.Instance.ExecuQuery(query);


            return data;
        }
        public string GetEmailByIdBanNganh(int idbannganh)
        {
            string query = string.Format("SELECT b.Email FROM BanNganh a, TaiKhoan b, QuanLyJoinBanNganh c WHERE a.IdBanNganh = c.IdBanNganh AND c.IdUser = b.IdUser AND a.IdBanNganh = {0}", idbannganh);
            DataTable data = DataProvider.Instance.ExecuQuery(query);

            if (data != null && data.Rows.Count > 0)
            {
                // Lấy giá trị của cột Email từ dòng đầu tiên
                return data.Rows[0]["Email"].ToString();
            }

            return string.Empty;
        }
        public string GetTenBanNganhById(int idbannganh)
        {
           
            string query = string.Format("SELECT TenBanNganh FROM BanNganh WHERE IdBanNganh = {0}", idbannganh);

            
            DataTable data = DataProvider.Instance.ExecuQuery(query);

           
            if (data != null && data.Rows.Count > 0)
            {
              
                return data.Rows[0]["TenBanNganh"].ToString();
            }

          
            return string.Empty;
        }

        public string GetEmailByIdThanhVien(int idbannganh, int idhthanhvien)
        {
            string query = string.Format("SELECT b.Email FROM ChiTietBanNganh a, ThanhVien b WHERE a.IdThanhVien = b.IdThanhVien  AND a.IdBanNganh = {0} AND b.IdThanhVien = {1}", idbannganh, idhthanhvien);
            DataTable data = DataProvider.Instance.ExecuQuery(query);

            if (data != null && data.Rows.Count > 0)
            {
                return data.Rows[0]["Email"].ToString();
            }

            return string.Empty;
        }

        public List<string> GetEmailThanhVienByIdBanNganh(int idbannganh)
        {
            string query = string.Format("SELECT b.Email FROM ChiTietBanNganh a, ThanhVien b WHERE a.IdThanhVien = b.IdThanhVien AND a.IdBanNganh = {0}", idbannganh);
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


        public int DemSoBanNganh()
        {
            string query = "SELECT COUNT(*) FROM BanNganh";
            DataTable data = DataProvider.Instance.ExecuQuery(query);

            if (data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0][0]);
            }
            return 0;
        }
    
        public bool InsertBanNganh(string tenbannganh, string hoatdong, int laplai, string thoigianhd)
        {
            string query = string.Format("INSERT INTO BanNganh(TenBanNganh, SoLuong, HoatDong, LapLai, ThoiGian) VALUES(N'{0}', 0, N'{1}', {2}, N'{3}')", tenbannganh, hoatdong, laplai, thoigianhd);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateSoLuongBanNganh(int soluong, int idbannganh)
        {
            string query = string.Format("UPDATE BanNganh SET SoLuong = {0} WHERE IdBanNganh = {1}", soluong, idbannganh);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool InsertQuanLy(int idbannganh, int iduser)
        {
            string query = string.Format("INSERT QuanLyJoinBanNganh (IdBanNganh, IdUser)VALUES({0},{1})", idbannganh, iduser);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateBanNganh(string tenbannganh, string hoatdong, int laplai, string thoigianhd, int idbannganh)
        {
            string query = string.Format("UPDATE BanNganh SET TenBanNganh = N'{0}', HoatDong =N'{1}',LapLai = {2}, ThoiGian = N'{3}' WHERE IdBanNganh = {4}", tenbannganh, hoatdong, laplai, thoigianhd, idbannganh);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeleteBanNganh(int idbannganh)
        {
            string query = string.Format("DELETE BanNganh WHERE IdBanNganh = {0}", idbannganh);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public DataTable SearchBanNganhByName(string tenbannganh)
        {
            string query = string.Format("SELECT * FROM BanNganh WHERE LOWER(TenBanNganh) COLLATE Latin1_General_CI_AI LIKE '%' + LOWER(N'{0}') + '%';", tenbannganh);
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            return data;
        }
        public DataTable SearchBanNganhByLapLai(int laplai)
        {
            string query = string.Format("SELECT * FROM BanNganh WHERE LOWER(LapLai) COLLATE Latin1_General_CI_AI LIKE '%' + LOWER({0}) + '%';", laplai);
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            return data;
        }
    }
}
