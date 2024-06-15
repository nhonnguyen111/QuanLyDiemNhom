using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom.DAO
{
    public class PhieuThuDAO
    {
        private static PhieuThuDAO instance;

        public static PhieuThuDAO Instance
        {
            get { if (instance == null) instance = new PhieuThuDAO(); return instance; }
            private set { instance = value; }
        }
        private PhieuThuDAO() { }
        public DataTable GetBangKePhieuThu()
        {
            string query = "SELECT * FROM PhieuThu";
            DataTable data = DataProvider.Instance.ExecuQuery(query);


            return data;
        }
        public bool InsertPhieuThu(int idphieuthu, DateTime ngaylap, string nguoithu, string loaitien, float sotien, string nguoinop, string diachi, string dienthoai, int idsoquy, string lydothu, int idloaithu )
        {
            string query = string.Format("INSERT PhieuThu (IdPhieuThu, NgayLap, NguoiThu, LoaiTien, SoTien, NguoiNop, DiaChi, DienThoai, IdSoQuy, LyDoThu, IdLoaiThu)" +
                "VALUES({0}, '{1}', N'{2}', N'{3}', {4}, N'{5}', N'{6}', N'{7}', {8}, N'{9}',{10})", idphieuthu, ngaylap, nguoithu, loaitien, sotien, nguoinop, diachi, dienthoai, idsoquy, lydothu, idloaithu);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateTienSoQuy(float tiennhan, int idsoquy)
        {
            string query = string.Format("UPDATE SoQuy SET TongTien = TongTien + {0} WHERE IdSoQuy ={1} ", tiennhan, idsoquy);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeletePhieuThu(int idphieuthu)
        {
            string query = string.Format("DELETE PhieuThu WHERE IdPhieuThu = {0}", idphieuthu);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
    }
}
