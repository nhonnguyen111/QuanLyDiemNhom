using QuanLyDiemNhom.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom
{
    public class LoaiChiDAO
    {
        private static LoaiChiDAO instance;

        public static LoaiChiDAO Instance
        {
            get { if (instance == null) instance = new LoaiChiDAO(); return instance; }
            private set { instance = value; }
        }
        private LoaiChiDAO() { }
        public DataTable GetLoaiChi()
        {
            string query = string.Format("SELECT * FROM LoaiChi");
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            return data;
        }
        public bool InsertLoaiChi(string tenloaichi)
        {
            string query = string.Format("INSERT LoaiChi(TenLoaiChi)VALUES(N'{0}')", tenloaichi);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateLoaiChi(string tenloaichi, int idloaichi)
        {
            string query = string.Format("UPDATE LoaiChi SET TenLoaiChi =N'{0}'WHERE IdLoaiChi = {1}", tenloaichi, idloaichi);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeleteLoaiChi(int idloaichi)
        {
            string query = string.Format("DELETE LoaiChi WHERE IdLoaiChi = {0}", idloaichi);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
    }
}
