using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom.DAO
{
    public class PhongBanDAO
    {
        private static PhongBanDAO instance;

        public static PhongBanDAO Instance
        {
            get { if (instance == null) instance = new PhongBanDAO(); return instance; }
            private set { instance = value; }
        }
        private PhongBanDAO() { }
        public DataTable GetPhongBan()
        {

            string query = "SELECT * FROM PhongBan";
            DataTable data = DataProvider.Instance.ExecuQuery(query);


            return data;
        }
        public DataTable GetVatTuPhongBan(int idphong)
        {

            string query = string.Format("SELECT * FROM VatTuJoinPhong WHERE IdPhong = {0}",idphong);
            DataTable data = DataProvider.Instance.ExecuQuery(query);


            return data;
        }
        public bool InsertPhongBan(string tenphongban)
        {
            string query = string.Format("INSERT INTO PhongBan (TenPhongBan) VALUES(N'{0}');",tenphongban);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool InsertVatTuJoinPhong(int idvattu, int soluong, int idphong)
        {
            string query = string.Format("INSERT VatTuJoinPhong (IdVatTu,SoLuong, TinhTrang, IdPhong, HuHong)VALUES({0}, {1},N'Đang hoạt động', {2},0)", idvattu, soluong, idphong);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdatetPhongBan(string tenphongban, int idphongban)
        {
            string query = string.Format("UPDATE PhongBan SET TenPhongBan =N'{0}' WHERE IdPhongBan = {1};", tenphongban, idphongban);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateVatTuTinhTrangHuHong(string tinhtrang,int soluonghuhong, int idvattujoinphong)
        {
            string query = string.Format("UPDATE VatTuJoinPhong SET TinhTrang =N'{0}',HuHong = HuHong + {1} WHERE IdVatTuJoinPhong = {2};", tinhtrang, soluonghuhong, idvattujoinphong);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateVatTuTinhTrang(string tinhtrang, int soluonghuhong, int idvattujoinphong)
        {
            string query = string.Format("UPDATE VatTuJoinPhong SET TinhTrang =N'{0}',HuHong = HuHong - {1} WHERE IdVatTuJoinPhong = {2};", tinhtrang, soluonghuhong, idvattujoinphong);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeletePhongBan( int idphongban)
        {
            string query = string.Format("DELETE PhongBan WHERE IdPhongBan = {0};", idphongban);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeleteVatTuJoinPhong(int idphongban)
        {
            string query = string.Format("DELETE VatTuJoinPhong WHERE IdPhong = {0};", idphongban);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeleteVatTuTatJoinPhong(int idvattujoinphong)
        {
            string query = string.Format("DELETE VatTuJoinPhong WHERE IdVatTuJoinPhong = {0};", idvattujoinphong);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeleteVatTuJoinPhong1Phan(int soluong,int idvattujoinphong)
        {
            string query = string.Format("UPDATE VatTuJoinPhong SET SoLuong = SoLuong - {0} WHERE IdVatTuJoinPhong = {1};",soluong ,idvattujoinphong);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
    }
}
