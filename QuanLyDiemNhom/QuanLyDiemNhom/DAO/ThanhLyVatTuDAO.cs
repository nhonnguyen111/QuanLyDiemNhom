using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom.DAO
{
    public class ThanhLyVatTuDAO
    {
        private static ThanhLyVatTuDAO instance;

        public static ThanhLyVatTuDAO Instance
        {
            get { if (instance == null) instance = new ThanhLyVatTuDAO(); return instance; }
            private set { instance = value; }
        }
        private ThanhLyVatTuDAO() { }
        public DataTable GetPhieuThanhLy()
        {

            string query = " SELECT * FROM ThanhLyVatTu";
            DataTable data = DataProvider.Instance.ExecuQuery(query);


            return data;
        }
        public bool InsertTaoPhieu(int idvattu, int soluongthanhly, float tienthanhly, DateTime ngayban, string nguoiban,string noiban, int idsoquy)
        {
            string query = string.Format("INSERT ThanhLyVatTu (IdVatTu, SoLuongThanhLy, TienThanhLy,NgayBan, NguoiBan,NoiBan, IdSoQuy)VALUES({0},{1},{2}, '{3}',N'{4}', N'{5}',{6})", idvattu, soluongthanhly, tienthanhly,ngayban, nguoiban, noiban,idsoquy);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateVatTu(int soluong,int idvattu)
        {
            string query = string.Format("UPDATE VatTu SET SoLuong = SoLuong - {0} WHERE IdVatTu = {1}",soluong, idvattu);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateSoQuy(float tienthanhly, int idsoquy)
        {
            string query = string.Format("UPDATE SoQuy SET TongTien = TongTien + {0} WHERE IdSoQuy = {1}", tienthanhly, idsoquy);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
    }
}
