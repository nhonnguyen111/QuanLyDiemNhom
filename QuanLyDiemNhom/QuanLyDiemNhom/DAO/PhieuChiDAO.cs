using QuanLyDiemNhom.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom
{
    public class PhieuChiDAO
    {
        private static PhieuChiDAO instance;
        public static PhieuChiDAO Instance
        {
            get { if (instance == null) instance = new PhieuChiDAO(); return instance; }
            private set { instance = value; }
        }
        private PhieuChiDAO() { }
        public DataTable GetBangKePhieuChi()
        {
            string query = "SELECT * FROM PhieuChi";
            DataTable data = DataProvider.Instance.ExecuQuery(query);


            return data;
        }
        public bool InsertPhieuChi(int idphieuthu, DateTime ngaylap, string nguoichi, string loaitien, float sotien, string nguoinhan, string diachi, string dienthoai, int idsoquy, string lydochi, int idloaichi)
        {
            string query = string.Format("INSERT PhieuChi (IdPhieuChi, NgayLap, NguoiChi, LoaiTien, SoTien, NguoiNhan, DiaChi, DienThoai, IdSoQuy, LyDoChi, IdLoaiChi)" +
                "VALUES({0}, '{1}', N'{2}', N'{3}', {4}, N'{5}', N'{6}', N'{7}', {8}, N'{9}',{10})", idphieuthu, ngaylap, nguoichi, loaitien, sotien, nguoinhan, diachi, dienthoai, idsoquy, lydochi, idloaichi);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateTienSoQuy(float tienchi, int idsoquy)
        {
            string query = string.Format("UPDATE SoQuy SET TongTien = TongTien - {0} WHERE IdSoQuy ={1} ", tienchi, idsoquy);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeletePhieuChi(int idphieuchi)
        {
            string query = string.Format("DELETE PhieuChi WHERE IdPhieuChi = {0}", idphieuchi);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public int GetSoTienByIdQuy(int idquy)
        {
            string query = string.Format("SELECT TongTien FROM SoQuy WHERE IdSoQuy = {0}", idquy);

            DataTable data = DataProvider.Instance.ExecuQuery(query);

            if (data != null && data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0]["TongTien"]);
            }
            return 0;
        }
    }
}
