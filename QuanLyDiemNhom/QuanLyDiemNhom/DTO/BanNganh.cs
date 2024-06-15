using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemNhom.DTO
{
    public class BanNganh
    {
        

        public int Idbannganh { get; set; }
        public string Tenbannganh { get ; set; }
        public int Soluong { get; set; }
        public string Hoatdong { get ; set; }
        public bool Laplai { get; set; }
        public string Thoigian { get; set; }
    }
}
