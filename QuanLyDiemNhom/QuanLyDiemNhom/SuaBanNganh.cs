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
    public partial class SuaBanNganh : DevExpress.XtraEditors.XtraForm
    {
        private int idbannganh;
        private string tenbannganh;
        private string hoatdong;
        private string thoigian;
        private int laplai;
        public SuaBanNganh(int idbannganh, string tenbannganh, string hoatdong, string thoigian, int laplai)
        {
            InitializeComponent();
            this.idbannganh = idbannganh;
            this.tenbannganh = tenbannganh;
            this.hoatdong = hoatdong;
            this.thoigian = thoigian;
            this.laplai = laplai;
            this.txttenbannganh.Text = tenbannganh;
            this.txthoatdong.Text = hoatdong;
            this.txtthoigian.Text = thoigian;
            if(laplai == 1)
            {
                checkco.Checked = true;
            }
            if (laplai == 0)
            {
                checkkhong.Checked = true;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
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
            if (BanNganhDAO.Instance.UpdateBanNganh(tenbannganh, hoatdong, idlaplai, thoigian,idbannganh))
            {
                MessageBox.Show("Sửa ban ngành thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa ban ngành thất bại");
            }

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}