using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemNhom
{
    public partial class ChiTietKhoaHocQuanLy : DevExpress.XtraEditors.XtraForm
    {
        private int idkhoahoc;
        public ChiTietKhoaHocQuanLy(int idkhoahoc)
        {
            InitializeComponent();
            this.idkhoahoc = idkhoahoc;
        }
    }
}