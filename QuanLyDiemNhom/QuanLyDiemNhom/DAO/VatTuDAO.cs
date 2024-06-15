using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom.DAO
{
    public class VatTuDAO
    {
        private static VatTuDAO instance;

        public static VatTuDAO Instance
        {
            get { if (instance == null) instance = new VatTuDAO(); return instance; }
            private set { instance = value; }
        }
        private VatTuDAO() { }
        public DataTable GetVatTu()
        {

            string query = "SELECT * FROM VatTu";
            DataTable data = DataProvider.Instance.ExecuQuery(query);


            return data;
        }
        public int DemSoVatTu()
        {
            string query = "SELECT COUNT(*) FROM VatTu";
            DataTable data = DataProvider.Instance.ExecuQuery(query);

            if (data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0][0]);
            }
            return 0;
        }
        public bool InsertVatTu(string tenvattu, int soluong, string dvt)
        {
            string query = string.Format("INSERT VatTu (TenVatTu, SoLuong, SuDung,HuHong, DVT) VALUES(N'{0}', {1}, 0, 0,N'{2}')", tenvattu, soluong,dvt);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdatetVatTu(string tenvattu, int soluong, string dvt, int idvattu)
        {
            string query = string.Format("UPDATE VatTu SET TenVatTu =N'{0}', SoLuong ={1} , DVT = N'{2}' WHERE IdVatTu ={3} ", tenvattu, soluong, dvt, idvattu);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeletetVatTu( int idvattu)
        {
            string query = string.Format("DELETE VatTu WHERE IdVatTu ={0}", idvattu);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateVatTuSuDung(int soluong, int idvattu)
        {
            string query = string.Format("UPDATE VatTu SET SuDung = SuDung + {0} WHERE IdVatTu = {1}",  soluong, idvattu);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateVatTuTonKho(int soluong, int idvattu)
        {
            string query = string.Format("UPDATE VatTu SET SoLuong = SoLuong - {0} WHERE IdVatTu = {1}", soluong, idvattu);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateVatTuTonKhoTraLai(int soluong, int idvattu)
        {
            string query = string.Format("UPDATE VatTu SET SoLuong = SoLuong + {0} WHERE IdVatTu = {1}", soluong, idvattu);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateVatTuHuHong(int soluong, int idvattu)
        {
            string query = string.Format("UPDATE VatTu SET HuHong = HuHong + {0} WHERE IdVatTu = {1}", soluong, idvattu);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateVatTuDaSuaChua(int soluong, int idvattu)
        {
            string query = string.Format("UPDATE VatTu SET HuHong = HuHong - {0} WHERE IdVatTu = {1}", soluong, idvattu);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateVatTuSuDungXong(int soluong, int idvattu)
        {
            string query = string.Format("UPDATE VatTu SET SuDung = SuDung - {0} WHERE IdVatTu = {1}", soluong, idvattu);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool ExportVatTu(int idphieuvattu, int idvattu, int soluongxuat, string noisudung, DateTime ngayxuat, int idnguoixuat, string nguoinhan)
        {
            string query = string.Format("INSERT PhieuVatTu(IdPhieuVatTu,IdVatTu, SoLuongXuat,NoiSuDung, NgayXuat,IdNguoiXuat, NguoiNhan, TinhTrang, SoLuongTra) VALUES({0},{1},{2},N'{3}','{4}',{5},N'{6}',N'Chưa hoàn trả',0)", idphieuvattu, idvattu, soluongxuat, noisudung, ngayxuat, idnguoixuat, nguoinhan);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public int GetSoLuongByIdVatTu(int idvattu)
        {
            string query = string.Format("SELECT SoLuong FROM VatTu WHERE IdVatTu = {0}", idvattu);

            DataTable data = DataProvider.Instance.ExecuQuery(query);

            if (data != null && data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0]["SoLuong"]);
            }
            return 0;
        }
        public int GetSoLuongSuDungByIdVatTu(int idvattu)
        {
            string query = string.Format("SELECT SuDung FROM VatTu WHERE IdVatTu = {0}", idvattu);

            DataTable data = DataProvider.Instance.ExecuQuery(query);

            if (data != null && data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0]["SuDung"]);
            }
            return 0;
        }

    }
}
