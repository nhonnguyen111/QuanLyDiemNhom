using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom.DAO
{
    public class ChungChiDAO
    {
        private static ChungChiDAO instance;

        public static ChungChiDAO Instance
        {
            get { if (instance == null) instance = new ChungChiDAO(); return instance; }
            private set { instance = value; }
        }
        private ChungChiDAO() { }
        public DataTable GetChungChi()
        {
            string query = "SELECT * FROM ChungChi";
            DataTable data = DataProvider.Instance.ExecuQuery(query);


            return data;
        }
        public bool DeleteChungChi(int idchungchi)
        {
            string query = string.Format("DELETE ChungChi WHERE IdChungChi = {0}", idchungchi);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public DataTable SearchChungChiByName(string tenchungchi)
        {
            string query = string.Format("SELECT * FROM ChungChi WHERE LOWER(TenChungChi) COLLATE Latin1_General_CI_AI LIKE '%' + LOWER(N'{0}') + '%';", tenchungchi);
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            return data;
        }
    }
}
