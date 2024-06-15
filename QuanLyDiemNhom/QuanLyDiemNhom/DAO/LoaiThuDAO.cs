using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom.DAO
{
    public class LoaiThuDAO
    {
        private static LoaiThuDAO instance;

        public static LoaiThuDAO Instance
        {
            get { if (instance == null) instance = new LoaiThuDAO(); return instance; }
            private set { instance = value; }
        }
        private LoaiThuDAO() { }
        public DataTable GetLoaiThu()
        {
            string query = string.Format("SELECT * FROM LoaiThu");
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            return data;
        }
        public bool InsertLoaiThu(string tenloaithu)
        {
            string query = string.Format("INSERT LoaiThu(TenLoaiThu)VALUES(N'{0}')",tenloaithu);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateLoaiThu(string tenloaithu, int idloaithu)
        {
            string query = string.Format("UPDATE LoaiThu SET TenLoaiThu =N'{0}'WHERE IdLoaiThu = {1}", tenloaithu, idloaithu);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeleteLoaiThu( int idloaithu)
        {
            string query = string.Format("DELETE LoaiThu WHERE IdLoaiThu = {0}", idloaithu);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
    }
}
