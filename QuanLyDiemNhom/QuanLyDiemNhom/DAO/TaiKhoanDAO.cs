using QuanLyDiemNhom.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyDiemNhom.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
        }
        private TaiKhoanDAO() { }
        //Login check tài khoản và mật khẩu
        public bool Login(string userName, string passWord)
        {
            string query = "select* from TaiKhoan where TaiKhoan = N'" + userName + "' and MatKhau = N'" + passWord + "'";
            DataTable result = DataProvider.Instance.ExecuQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }

        public int GetIdChucVuByUserName(string userName)
        {
            string query = "SELECT IdQuyen FROM TaiKhoan WHERE TaiKhoan = N'" + userName + "'";
            DataTable result = DataProvider.Instance.ExecuQuery(query, new object[] { userName });

            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["IdQuyen"]);
            }
            else
            {
                return -1; // Giá trị không hợp lệ
            }
        }

        //GetAccount xem trùng vs tài khoản trong data
        public TaiKhoan GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuQuery("SELECT * FROM TaiKhoan WHERE TaiKhoan = '" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new TaiKhoan(item);
            }
            return null;
        }
        //lấy danh sách nhân sự
        public DataTable GetTaiKhoans()
        { 
            string query = string.Format("select * from TaiKhoan ");
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            return data;
        }
        //lấy nhân sự theo id
        public string GetTaikhoanById(int iduser)
        {

            string query = string.Format("SELECT HoTen FROM TaiKhoan WHERE IdUser = {0}", iduser);


            DataTable data = DataProvider.Instance.ExecuQuery(query);


            if (data != null && data.Rows.Count > 0)
            {

                return data.Rows[0]["HoTen"].ToString();
            }


            return string.Empty;
        }
        public DataTable GetQuyen()
        {
            string query = string.Format("select * from Quyen ");
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            return data;
        }
        //thêm nhân sự
        public bool InsertTaiKhoan(string taikhoan, string matkhau, string hoten, int idquyen)
        {
            string query = string.Format("INSERT TaiKhoan(TaiKhoan, MatKhau,HoTen, SoDienThoai, DiaChi, Email,KhuVuc, IdQuyen, GioiTinh) VALUES(N'{0}', N'{1}', N'{2}',N'',N'',N'',N'',{3} ,N'')", taikhoan, matkhau, hoten,idquyen);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        //check tên tài khoản có trùng ko
        public bool CheckUsernameExists(string username)
        {
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectionData))
            {
                string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TaiKhoan = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        //Thay đổi mật khẩu
        public bool UpdateMatKhau(string matkhaumoi, int iduser)
        {
            string query = string.Format("UPDATE TaiKhoan SET MatKhau = N'{0}' WHERE IdUser = {1}", matkhaumoi, iduser);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        //Check pass nhập vào có trùng với pass cũ hay ko
        public bool CheckPassWordExists(string password)
        {
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectionData))
            {
                string query = "SELECT COUNT(*) FROM TaiKhoan WHERE MatKhau = @MatKhau";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MatKhau", password);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        //xóa tài khoản
        public bool DeleteTaiKhoan(int iduser)
        {
            string query = string.Format("DELETE TaiKhoan WHERE IdUser ={0} ",iduser );
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        //UPDATE TÀI KHOẢN CÁ NHÂN
        public bool UpdateTaiKhoanCaNhan(string hoten, string sdt, string diachi, string email,  string khuvuc, string gioitinh, int iduser)
        {
            string query = string.Format("UPDATE TaiKhoan SET HoTen = N'{0}', SoDienThoai = N'{1}', DiaChi = N'{2}', Email = N'{3}', KhuVuc = N'{4}', GioiTinh = N'{5}' WHERE IdUser ={6} ", hoten, sdt, diachi, email,khuvuc, gioitinh, iduser);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        //cập nhật quyền tài khoản
        public bool UpdateQuyenTaiKhoan(int idquyen, int iduser)
        {
            string query = string.Format("UPDATE TaiKhoan SET IdQuyen = {0} WHERE IdUser ={1}",idquyen, iduser);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        // đêm số tài khoản
        public int DemSoTaiKhoan()
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan";
            DataTable data = DataProvider.Instance.ExecuQuery(query);

            if (data.Rows.Count > 0)
            {
                return Convert.ToInt32(data.Rows[0][0]);
            }
            return 0;
        }
       


    }
}
