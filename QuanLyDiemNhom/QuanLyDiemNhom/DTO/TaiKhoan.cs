using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom.DTO
{
    public class TaiKhoan
    {
        public TaiKhoan(int iduser, string username, string sdt, string password, string hoten, string email, int idquyen, string gioitinh, string diachi, string khuvuc)
        {
            this.Iduser = iduser;
            this.Username = username;
            this.Password = password;
            this.Hoten = hoten;
            this.Email = email;
            this.Idquyen = idquyen;
            this.Sdt = sdt;
            this.Gioitinh = gioitinh;
            this.diachi = diachi;
            this.Diachi = diachi;
            this.khuvuc = khuvuc;
            this.Khuvuc = khuvuc;
        }
        public TaiKhoan(DataRow row)
        {
            this.Iduser = (int)row["IdUser"];
            this.Username = (string)row["TaiKhoan"];
            this.Password = (string)row["MatKhau"];
            this.Hoten = (string)row["HoTen"];
            this.Email = (string)row["Email"];
            this.Idquyen = (int)row["IdQuyen"];
            this.Sdt = (string)row["SoDienThoai"];
            this.Gioitinh = (string)row["GioiTinh"];
            this.Diachi = (string)row["DiaChi"];
            this.Khuvuc = (string)row["KhuVuc"];
        }
        private string hoten;
        private int iduser;
        private string password;
        private string email;
        private string username;
        private int idquyen;
        private string sdt;
        private string gioitinh;
        private string diachi;
        private string khuvuc;
        public string Username { get => username; set => username = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public int Iduser { get => iduser; set => iduser = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public int Idquyen { get => idquyen; set => idquyen = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Khuvuc { get => khuvuc; set => khuvuc = value; }
    }
}
