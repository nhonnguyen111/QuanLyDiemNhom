using DevExpress.XtraEditors;
using QuanLyDiemNhom.DAO;
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
    public partial class ThemBanNganh : DevExpress.XtraEditors.XtraForm
    {
        public ThemBanNganh()
        {
            InitializeComponent();
        }
       
        

        private void btnsave_Click(object sender, EventArgs e)
        {
            string tenbannganh = txttenbannganh.Text;
            string hoatdong = txthoatdong.Text;
            string thoigian = txtthoigian.Text;
            int idlaplai = 0;
            if (checkco.Checked)
            {
                idlaplai = 1;
            }
            if (checkkhong.Checked)
            {
                idlaplai = 0;
            }
            if (BanNganhDAO.Instance.InsertBanNganh(tenbannganh, hoatdong, idlaplai, thoigian))
            {
                MessageBox.Show("Thêm ban ngành mới thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm ban ngành mới thất bại");
            }
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}