using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom.DAO
{
    public class ChiTietBanNganhDAO
    {
        private static ChiTietBanNganhDAO instance;

        public static ChiTietBanNganhDAO Instance
        {
            get { if (instance == null) instance = new ChiTietBanNganhDAO(); return instance; }
            private set { instance = value; }
        }
        private ChiTietBanNganhDAO() { }
        public DataTable GetChiTietBanNganh(int idbannganh)
        {
            // Tạo câu truy vấn SQL
            string query = string.Format("SELECT * FROM ChiTietBanNganh WHERE IdBanNganh = {0} ", idbannganh);
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            return data;
        }
        public DataTable GetTenQuanLy(int idbannganh)
        {
            // Tạo câu truy vấn SQL
            string query = string.Format("SELECT d.HoTen FROM QuanLyJoinBanNganh a, BanNganh b, ChiTietBanNganh c, TaiKhoan d WHERE a.IdBanNganh = b.IdBanNganh AND b.IdBanNganh = c.IdBanNganh AND a.IdUser = d.IdUser AND a.IdBanNganh = {0}", idbannganh);
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            return data;
        }
        public bool InsertThanhVien(int thanhvien, int idbannganh)
        {
            string query = string.Format("INSERT INTO ChiTietBanNganh (IdThanhVien, ChucVu, NgayThamGia, IdBanNganh) VALUES({0},  N'Thành viên', GETDATE(),{1});",thanhvien,idbannganh );
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeleteThanhVien(int idchitietbannganh)
        {
            string query = string.Format("DELETE ChiTietBanNganh  WHERE IdChiTietBanNganh  ={0}", idchitietbannganh);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public int DemSoThanhVien(int idbannganh)
        {
            string query = string.Format("SELECT COUNT(*) FROM ChiTietBanNganh WHERE IdBanNganh = {0}", idbannganh);
            DataTable data = DataProvider.Instance.ExecuQuery(query);

            if (data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0][0]);
            }
            return 0;
        }
    }
}
