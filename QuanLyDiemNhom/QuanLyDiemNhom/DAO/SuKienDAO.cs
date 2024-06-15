using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom.DAO
{
    public class SuKienDAO
    {
        private static SuKienDAO instance;

        public static SuKienDAO Instance
        {
            get { if (instance == null) instance = new SuKienDAO(); return instance; }
            private set { instance = value; }
        }
        private SuKienDAO() { }
        public DataTable GetSukien()
        {

            string query = "SELECT a.TenSuKien,a.NoiDung,a.NgayDienRa,a.NgayKetThuc,a.GioDienRa,a.GioKetThuc,a.ViTriDienRa, b.TenBanNganh FROM SuKien a, BanNganh b WHERE a.IdBanNganh = b.IdBanNganh";
            DataTable data = DataProvider.Instance.ExecuQuery(query);


            return data;
        }
        public DataTable GetSukienFull()
        {
            string query = "SELECT * FROM SuKien";
            DataTable data = DataProvider.Instance.ExecuQuery(query);


            return data;
        }
        public bool InsertSuKien(string tensukien, string noidung, DateTime ngaybatdau, DateTime ngayketthuc, TimeSpan giodienra, TimeSpan gioketthuc, string vitri, int idbannganh)
        {
            string query = string.Format("INSERT INTO SuKien (TenSuKien, NoiDung, NgayDienRa, NgayKetThuc, GioDienRa,GioKetThuc, ViTriDienRa, IdBanNganh )VALUES (N'{0}', N'{1}', '{2}', '{3}', '{4}','{5}', N'{6}',{7});", tensukien, noidung, ngaybatdau, ngayketthuc, giodienra, gioketthuc, vitri, idbannganh);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateSuKien(string tensukien, string noidung, DateTime ngaybatdau, DateTime ngayketthuc, TimeSpan giodienra, TimeSpan gioketthuc, string vitri, int idbannganh, int idsukien)
        {
            string query = string.Format("UPDATE SuKien SET TenSuKien = N'{0}', NoiDung = N'{1}', NgayDienRa = '{2}', NgayKetThuc ='{3}', GioDienRa = '{4}',GioKetThuc = '{5}', ViTriDienRa =N'{6}', IdBanNganh ={7} WHERE IdSuKien = {8}", tensukien, noidung, ngaybatdau, ngayketthuc, giodienra, gioketthuc, vitri, idbannganh, idsukien);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeleteSuKien(int idsukien)
        {
            string query = string.Format("DELETE SuKien WHERE IdSuKien = {0}",idsukien);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
    }
}
