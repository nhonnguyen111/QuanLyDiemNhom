using DevExpress.XtraEditors;
using QuanLyDiemNhom.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QuanLyDiemNhom
{
    public partial class ThemSuKien : DevExpress.XtraEditors.XtraForm
    {
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EventDateEnd { get; set; }
        public TimeSpan EventTime { get; set; }
        public TimeSpan EventTimeEnd { get; set; }
        public string EventLocation { get; set; }
        public int IdBanNganh { get; set; }
        private Dictionary<string, int> BannganhDictionary = new Dictionary<string, int>();

        public ThemSuKien(DateTime selectedDate, TimeSpan selectTime)
        {
            InitializeComponent();
            dtngaydienra.Value = selectedDate;
            timedienra.Time = DateTime.Today + selectTime;
            LoadBanNganh();
        }

        void LoadBanNganh()
        {
            DataTable dataTable = BanNganhDAO.Instance.GetBanNganh();
            cbbannganh.Properties.Items.Clear();
            BannganhDictionary.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                int idbannganh = Convert.ToInt32(row["IdBanNganh"]);
                string tenbannganh = row["TenBanNganh"].ToString();
                BannganhDictionary.Add(tenbannganh, idbannganh);
                cbbannganh.Properties.Items.Add(tenbannganh);
            }
        }

        int GetSelectedValueMember()
        {
            string selectedDisplayText = cbbannganh.SelectedItem.ToString();
            int selectedValueMember = BannganhDictionary[selectedDisplayText];
            return selectedValueMember;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EventName = txttensukien.Text;
            EventDescription = txtnoidung.Text;
            EventDate = dtngaydienra.Value;
            EventDateEnd = dtngayketthuc.Value;
            EventTime = timedienra.Time.TimeOfDay;
            EventTimeEnd = timeketthuc.Time.TimeOfDay;
            EventLocation = txtvitri.Text;
            IdBanNganh = GetSelectedValueMember();

            bool isInserted = SuKienDAO.Instance.InsertSuKien(EventName, EventDescription, EventDate, EventDateEnd, EventTime, EventTimeEnd, EventLocation, IdBanNganh);
            if (isInserted)
            {
                MessageBox.Show("Sự kiện đã được thêm thành công.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại.");
            }
        }
    }
}
