using QuanLyDiemNhom.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom.DAO
{
    public class ChiTietKhoaHocDAO
    {
        private static ChiTietKhoaHocDAO instance;

        public static ChiTietKhoaHocDAO Instance
        {
            get { if (instance == null) instance = new ChiTietKhoaHocDAO(); return instance; }
            private set { instance = value; }
        }
        private ChiTietKhoaHocDAO() { }
        public DataTable GetChiTietKhoaHoc(int idkhoahoc)
        {
            string query = string.Format("SELECT * FROM ChiTietKhoaHoc WHERE IdKhoaHoc = {0} ", idkhoahoc);
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            return data;
        }
        public int DemSoThanhVien(int idkhoahoc)
        {
            string query = string.Format("SELECT COUNT(*) FROM ChiTietKhoaHoc WHERE IdKhoaHoc ={0}",idkhoahoc);
            DataTable data = DataProvider.Instance.ExecuQuery(query);

            if (data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0][0]);
            }
            return 0;
        }
        public bool InsertThanhVien(int idkhoahoc, int idthanhvien)
        {
            string query = string.Format("INSERT ChiTietKhoaHoc (IdKhoaHoc, IdThanhVien) VALUES({0}, {1})", idkhoahoc, idthanhvien);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeleteThanhVien(int idchitietkhoahoc)
        {
            string query = string.Format("DELETE ChiTietKhoaHoc WHERE IdChiTietKhoaHoc = {0}", idchitietkhoahoc);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public string GetEmailThanhVienByIdKhoaHoc(int idkhoahoc, int idthanhvien)
        {
            string query = string.Format("SELECT b.Email FROM ChiTietKhoaHoc a, ThanhVien b WHERE a.IdThanhVien = b.IdThanhVien AND a.IdKhoaHoc = {0} AND a.IdThanhVien = {1}", idkhoahoc, idthanhvien);
            DataTable data = DataProvider.Instance.ExecuQuery(query);

            if (data != null && data.Rows.Count > 0)
            {
                return data.Rows[0]["Email"].ToString();
            }

            return string.Empty;
        }
        public string GetTenKhoaHocById(int idkhoahoc)
        {

            string query = string.Format("SELECT TenKhoaHoc FROM KhoaHoc WHERE IdKhoaHoc = {0}", idkhoahoc);


            DataTable data = DataProvider.Instance.ExecuQuery(query);


            if (data != null && data.Rows.Count > 0)
            {

                return data.Rows[0]["TenKhoaHoc"].ToString();
            }


            return string.Empty;
        }
    }
}
