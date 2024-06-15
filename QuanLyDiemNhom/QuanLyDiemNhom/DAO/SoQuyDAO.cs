using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom.DAO
{
    public class SoQuyDAO
    {
        private static SoQuyDAO instance;

        public static SoQuyDAO Instance
        {
            get { if (instance == null) instance = new SoQuyDAO(); return instance; }
            private set { instance = value; }
        }
        private SoQuyDAO() { }
        public DataTable GetSoQuy()
        {
            string query = "SELECT * FROM SoQuy";
            DataTable data = DataProvider.Instance.ExecuQuery(query);


            return data;
        }
        public bool InsertSoQuy(string tenso)
        {
            string query = string.Format("INSERT SoQuy (TenSo, TongTien)VALUES(N'{0}', 0)",tenso);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateSoQuy(string tenso, int idsoquy)
        {
            string query = string.Format("UPDATE SoQuy SET TenSo = N'{0}' WHERE IdSoQuy ={1} ", tenso, idsoquy);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeleteSoQuy( int idsoquy)
        {
            string query = string.Format("DELETE SoQuy WHERE IdSoQuy ={0} ", idsoquy);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
    }
}
