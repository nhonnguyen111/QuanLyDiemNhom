using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom.DTO
{
    public class ThanhVien
    {
        public ThanhVien(int idthanhvien, string hoten, string email, string sdt, string diachi, string khuvuc, string gioitinh, string honnhan, DateTime ngaythamgia, DateTime ngaysinh) 
        { 
            this.Idthanhvien = idthanhvien;
            this.Hoten = hoten;
            this.Email = email;
            this.Sdt = sdt;
            this.Diachi = diachi;
            this.Khuvuc = khuvuc;
            this.Gioitinh = gioitinh;
            this.Honnhan = honnhan;
            this.Ngaythamgia = ngaythamgia;
            this.Ngaysinh = ngaysinh;
        }
        public ThanhVien(DataRow row)
        {

            this.Idthanhvien = (int)row["IdThanhVien"];
            this.Hoten = (string)row["HoTen"];
            this.Email = (string)row["Email"];
            this.Sdt = (string)row["SoDienThoai"];
            this.Diachi = (string)row["DiaChi"];
            this.Khuvuc = (string)row["KhuVuc"];
            this.Gioitinh = (string)row["GioiTinh"];
            this.Honnhan = (string)row["HonNhan"];
            this.Ngaythamgia = (DateTime)row["NgayThamGia"];
            this.Ngaysinh = (DateTime)row["NgaySinh"];
        }
        private int idthanhvien;
        private string hoten;
        private string email;
        private string sdt;
        private string diachi;
        private string khuvuc;
        private string gioitinh;
        private string honnhan;
        private DateTime ngaythamgia;
        private DateTime ngaysinh;

        public int Idthanhvien { get => idthanhvien; set => idthanhvien = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Khuvuc { get => khuvuc; set => khuvuc = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Honnhan { get => honnhan; set => honnhan = value; }
        public DateTime Ngaythamgia { get => ngaythamgia; set => ngaythamgia = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
    }
}
