using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom.DTO
{
    public class ChiTietBanNganh
    {
        

        public int IdChitietbannganh { get; set ; }
        public int Idthanhvien { get; set; }
        public string Chucvu { get; set; }
        public DateTime Ngaythamgia { get; set; }
        public int Idbannganh { get; set; }
    }
}
