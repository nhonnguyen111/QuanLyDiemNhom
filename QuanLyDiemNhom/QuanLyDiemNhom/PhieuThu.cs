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
    public partial class PhieuThu : DevExpress.XtraEditors.XtraForm
    {
        private Dictionary<string, int> SoquyDictionary = new Dictionary<string, int>();
        private Dictionary<string, int> LoaiThuDictionary = new Dictionary<string, int>();
        private Random random;
        public PhieuThu()
        {
            InitializeComponent();
            random = new Random();
            LoadSoQuy();
            int randomNumber = GenerateRandomNumber();
            txtsophieu.Text = randomNumber.ToString();
            LoadLoaiThu();
        }
        private int GenerateRandomNumber()
        {
            return random.Next(1, 10001);
        }
        void LoadSoQuy()
        {
            DataTable dataTable = SoQuyDAO.Instance.GetSoQuy();
            cbsoquy.Properties.Items.Clear();
            SoquyDictionary.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                int idsoquy = Convert.ToInt32(row["IdSoQuy"]);
                string tenso = row["TenSo"].ToString();
                SoquyDictionary.Add(tenso, idsoquy);
                cbsoquy.Properties.Items.Add(tenso);
            }
        }
        void LoadLoaiThu()
        {
            DataTable dataTable = LoaiThuDAO.Instance.GetLoaiThu();
            cbloaithu.Properties.Items.Clear();
            LoaiThuDictionary.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                int idloaithu = Convert.ToInt32(row["IdLoaiThu"]);
                string ten = row["TenLoaiThu"].ToString();
                LoaiThuDictionary.Add(ten, idloaithu);
                cbloaithu.Properties.Items.Add(ten);
            }
        }
        int GetSelectedValueMemberLoaiThu()
        {
            string selectedDisplayText = cbloaithu.SelectedItem.ToString();
            int selectedValueMember = LoaiThuDictionary[selectedDisplayText];
            return selectedValueMember;
        }
        int GetSelectedValueMember()
        {
            string selectedDisplayText = cbsoquy.SelectedItem.ToString();
            int selectedValueMember = SoquyDictionary[selectedDisplayText];
            return selectedValueMember;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int idphieuthu = int.Parse(txtsophieu.Text);
            string nguoinop = txtnguoinop.Text;
            string diachi =  txtdiachi.Text;
            string sdt =  txtdienthoai.Text;
            int idsoquy =  GetSelectedValueMember();
            string lydothu =  txtlydothu.Text;
            int idloaithu = GetSelectedValueMemberLoaiThu();
            DateTime ngaylap = DateTime.Parse(dtngaylap.Text);
            string nguoithu = txtnguoithu.Text;
            string loaitien = cbloaitien.Text;
            float sotien = float.Parse(txtsotien.Text);
            float doitien = 0;
            if(loaitien == "USD")
            {
                doitien = sotien * 25410;
            }
            else
            {
                doitien = sotien;
            }
            if (PhieuThuDAO.Instance.InsertPhieuThu(idphieuthu, ngaylap,nguoithu,loaitien,sotien,nguoinop,diachi,sdt,idsoquy,lydothu,idloaithu))
            {
                PhieuThuDAO.Instance.UpdateTienSoQuy(doitien, idsoquy);
                MessageBox.Show("Tạo phiếu thu thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Tạo phiếu thu thất bại");
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}