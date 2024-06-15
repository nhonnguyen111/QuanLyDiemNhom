using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom.DAO
{
    public class PhieuVatTuDAO
    {
        private static PhieuVatTuDAO instance;

        public static PhieuVatTuDAO Instance
        {
            get { if (instance == null) instance = new PhieuVatTuDAO(); return instance; }
            private set { instance = value; }
        }
        private PhieuVatTuDAO() { }
        public DataTable GetPhieuVatTu()
        {

            string query = "SELECT * FROM PhieuVatTu";
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            return data;
        }
        public bool UpdatePhieuVatTu(int soluongxuat,string noisudung, string nguoinhan, DateTime ngayxuat, DateTime ngaytra, int soluongtra, int idphieu)
        {
            string query = string.Format("UPDATE PhieuVatTu SET SoLuongXuat = {0}, NoiSuDung = N'{1}', NguoiNhan =N'{2}', NgayXuat = '{3}', NgayTra ='{4}', SoLuongTra = SoLuongTra + {5} WHERE IdPhieuVatTu ={6} ", soluongxuat, noisudung, nguoinhan, ngayxuat, ngaytra, soluongtra, idphieu);

            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateTinhTrang( string tinhtrang, int idphieu)
        {
            string query = string.Format("UPDATE PhieuVatTu SET TinhTrang =N'{0}' WHERE IdPhieuVatTu ={1} ", tinhtrang, idphieu);

            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeletePhieu(int idphieu)
        {
            string query = string.Format("DELETE PhieuVatTu WHERE IdPhieuVatTu = {0}", idphieu);

            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdatePhieuVatTuKhongtrasoluong(int soluongxuat, string noisudung, string nguoinhan, DateTime ngayxuat,  int idphieu)
        {
            string query = string.Format("UPDATE PhieuVatTu SET SoLuongXuat = {0}, NoiSuDung = N'{1}', NguoiNhan =N'{2}', NgayXuat = '{3}' WHERE IdPhieuVatTu ={4} ", soluongxuat, noisudung, nguoinhan, ngayxuat, idphieu);

            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public int GetSoLuongXuatByIdPhieu(int idphieu)
        {
            string query = string.Format("SELECT SoLuongXuat FROM PhieuVatTu WHERE IdPhieuVatTu = {0}", idphieu);

            DataTable data = DataProvider.Instance.ExecuQuery(query);

            if (data != null && data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0]["SoLuongXuat"]);
            }
            return 0;
        }
        public int GetSoLuongTraByIdPhieu(int idphieu)
        {
            string query = string.Format("SELECT SoLuongTra FROM PhieuVatTu WHERE IdPhieuVatTu = {0}", idphieu);

            DataTable data = DataProvider.Instance.ExecuQuery(query);

            if (data != null && data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0]["SoLuongTra"]);
            }
            return 0;
        }
        public DateTime? GetNgayTraByIdPhieu(int idphieu)
        {
            string query = string.Format("SELECT NgayTra FROM PhieuVatTu WHERE IdPhieuVatTu = {0}", idphieu);

            DataTable data = DataProvider.Instance.ExecuQuery(query);

            if (data != null && data.Rows.Count > 0)
            {
                if (data.Rows[0]["NgayTra"] != DBNull.Value)
                {
                    return Convert.ToDateTime(data.Rows[0]["NgayTra"]);
                }
            }

            return null;
        }
        
    }
}
