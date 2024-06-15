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
    public partial class PhieuChi : DevExpress.XtraEditors.XtraForm
    {
        private Dictionary<string, int> SoquyDictionary = new Dictionary<string, int>();
        private Dictionary<string, int> LoaiChiDictionary = new Dictionary<string, int>();
        private Random random;
        public PhieuChi()
        {
            InitializeComponent();
            random = new Random();
            int randomNumber = GenerateRandomNumber();
            txtsophieu.Text = randomNumber.ToString();
            LoadSoQuy();
            LoadLoaiChi();
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
        void LoadLoaiChi()
        {
            DataTable dataTable = LoaiChiDAO.Instance.GetLoaiChi();
            cbloaichi.Properties.Items.Clear();
            LoaiChiDictionary.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                int idloaithu = Convert.ToInt32(row["IdLoaiChi"]);
                string ten = row["TenLoaiChi"].ToString();
                LoaiChiDictionary.Add(ten, idloaithu);
                cbloaichi.Properties.Items.Add(ten);
            }
        }
        int GetSelectedValueMemberLoaiChi()
        {
            string selectedDisplayText = cbloaichi.SelectedItem.ToString();
            int selectedValueMember = LoaiChiDictionary[selectedDisplayText];
            return selectedValueMember;
        }
        int GetSelectedValueMember()
        {
            string selectedDisplayText = cbsoquy.SelectedItem.ToString();
            int selectedValueMember = SoquyDictionary[selectedDisplayText];
            return selectedValueMember;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int idphieuthu = int.Parse(txtsophieu.Text);
            string nguoinhan = txtnguoinhan.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtdienthoai.Text;
            int idsoquy = GetSelectedValueMember();
            string lydochi= txtlydochi.Text;
            int idloaithu = GetSelectedValueMemberLoaiChi();
            DateTime ngaylap = DateTime.Parse(dtngaylap.Text);
            string nguoichi = txtnguoichi.Text;
            string loaitien = cbloaitien.Text;
            float sotien = float.Parse(txtsotien.Text);
            float doitien = 0;
            int tongtientrongquy = PhieuChiDAO.Instance.GetSoTienByIdQuy(idsoquy);
            if(sotien > tongtientrongquy)
            {
                MessageBox.Show($"Tiền trong quỹ chỉ còn {tongtientrongquy} không đủ để tạo phiếu chi");
                return;
            }
            if (loaitien == "USD")
            {
                doitien = sotien * 25410;
            }
            else
            {
                doitien = sotien;
            }
            if (PhieuChiDAO.Instance.InsertPhieuChi(idphieuthu, ngaylap, nguoichi, loaitien, sotien, nguoinhan, diachi, sdt, idsoquy, lydochi, idloaithu))
            {
                PhieuChiDAO.Instance.UpdateTienSoQuy(doitien, idsoquy);
                MessageBox.Show("Tạo phiếu chi thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Tạo phiếu chi thất bại");
            }
        }
    }
}