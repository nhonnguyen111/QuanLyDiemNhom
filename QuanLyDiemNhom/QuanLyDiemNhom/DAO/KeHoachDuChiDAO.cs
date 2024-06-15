using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom.DAO
{
    public class KeHoachDuChiDAO
    {
        private static KeHoachDuChiDAO instance;

        public static KeHoachDuChiDAO Instance
        {
            get { if (instance == null) instance = new KeHoachDuChiDAO(); return instance; }
            private set { instance = value; }
        }
        private KeHoachDuChiDAO() { }
        public bool InsertHangMuc(string tenhangmuc, float tienduchi, string loaitien)
        {
            string query = string.Format("INSERT HangMucDuChi (TenHangMuc, TienDuChi,LoaiTien) VALUES(N'{0}', {1}, N'{2}')", tenhangmuc, tienduchi,loaitien);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool InsertHangMucById(string tenhangmuc, float tienduchi, string loaitien, int IdKeHoach)
        {
            string query = string.Format("INSERT HangMucDuChi (TenHangMuc, TienDuChi,LoaiTien, IdKeHoach) VALUES(N'{0}', {1}, N'{2}',{3})", tenhangmuc, tienduchi, loaitien, IdKeHoach);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public int InsertKeHoach(string tenkehoach, DateTime ngaybatdau, DateTime ngayketthuc, string quanly1, string quanly2, float tongchiphi, string mota)
        {
            if (DataProvider.Instance == null)
            {
                throw new InvalidOperationException("DataProvider instance is not initialized.");
            }

            string query = "INSERT INTO KeHoachDuChi (TenKeHoach, NgayBatDau, NgayKetThuc, QuanLy1, QuanLy2, TongChiPhi, MoTa) OUTPUT INSERTED.IdKeHoach VALUES (@tenkehoach, @ngaybatdau, @ngayketthuc, @quanly1, @quanly2, @tongchiphi, @mota)";

            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        { "@tenkehoach", tenkehoach },
        { "@ngaybatdau", ngaybatdau },
        { "@ngayketthuc", ngayketthuc },
        { "@quanly1", quanly1 },
        { "@quanly2", quanly2 },
        { "@tongchiphi", tongchiphi },
        { "@mota", mota }
    };

            object result = DataProvider.Instance.Execute(query, parameters);

            if (result == null)
            {
                throw new InvalidOperationException("InsertKeHoach failed to return the new IdKeHoach.");
            }

            return Convert.ToInt32(result);
        }



        public bool UpdateHangMuc(int idkehoach, int idhangmuc)
        {
            if (DataProvider.Instance == null)
            {
                throw new InvalidOperationException("DataProvider instance is not initialized.");
            }

            string query = "UPDATE HangMucDuChi SET IdKeHoach = @idkehoach WHERE IdHangMucDuChi = @idhangmuc";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { "@idkehoach", idkehoach },
                        { "@idhangmuc", idhangmuc }
                    };

            int rs = DataProvider.Instance.ExecuteNon(query, parameters);
            return rs > 0;
        }

        public bool DeleteHangMuc(int idhangmuc)
        {
            string query = string.Format("DELETE HangMucDuChi WHERE IdHangMucDuChi={0}", idhangmuc);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeleteHangMucByIdKeHoach(int idkehoach)
        {
            string query = string.Format("DELETE HangMucDuChi WHERE IdKeHoach={0}", idkehoach);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeleteKeHoach(int idkehoach)
        {
            string query = string.Format("DELETE KeHoachDuChi WHERE IdKeHoach={0}", idkehoach);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeleteHangMucNull()
        {
            string query = string.Format("DELETE HangMucDuChi WHERE IdKeHoach is null");
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateKeHoach(string tenkehoach, DateTime ngaybatdau, DateTime ngayketthuc, string quanly1, string quanly2, string mota, float tongchiphi, int idkehoach)
        {
            string query = string.Format("UPDATE KeHoachDuChi SET TenKeHoach =N'{0}', NgayBatDau ='{1}', NgayKetThuc='{2}', QuanLy1 = N'{3}', QuanLy2 = N'{4}', MoTa = N'{5}', TongChiPhi = {6} WHERE IdKeHoach = {7}", tenkehoach, ngaybatdau, ngayketthuc,quanly1, quanly2, mota, tongchiphi, idkehoach);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public DataTable GetHangMucNull() { 

            string query = "SELECT * FROM HangMucDuChi WHERE IdKeHoach is null";
            DataTable data = DataProvider.Instance.ExecuQuery(query);


            return data;
        }
        public DataTable GetHangMucByIdKeHoach(int idkehoach)
        {

            string query = string.Format("SELECT * FROM HangMucDuChi WHERE IdKeHoach = {0}",idkehoach);
            DataTable data = DataProvider.Instance.ExecuQuery(query);


            return data;
        }
        public DataTable GetKeHoach()
        {

            string query = "SELECT * FROM KeHoachDuChi";
            DataTable data = DataProvider.Instance.ExecuQuery(query);


            return data;
        }
    }
}
