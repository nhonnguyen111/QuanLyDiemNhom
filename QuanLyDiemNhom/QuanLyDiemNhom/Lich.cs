using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
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
    public partial class Lich : DevExpress.XtraEditors.XtraForm
    {
        public Lich()
        {
            InitializeComponent();
            schedulerControl1.MouseDown += SchedulerControl1_MouseDown;
            schedulerControl1.Start = DateTime.Today; 
            LoadEvents(schedulerControl1);
        }
        void LoadEvents(SchedulerControl schedulerControl)
        {
            DataTable dataTable = SuKienDAO.Instance.GetSukien();

            foreach (DataRow row in dataTable.Rows)
            {
                DateTime startDate = Convert.ToDateTime(row["NgayDienRa"]);
                TimeSpan startTime = TimeSpan.Parse(row["GioDienRa"].ToString());
                DateTime startDateTime = startDate.Date + startTime;

                DateTime endDate = Convert.ToDateTime(row["NgayKetThuc"]);
                TimeSpan endTime = TimeSpan.Parse(row["GioKetThuc"].ToString());
                DateTime endDateTime = endDate.Date + endTime;

                Appointment appointment = schedulerControl.Storage.CreateAppointment(AppointmentType.Normal);
                appointment.Start = startDateTime;
                appointment.End = endDateTime;
                appointment.Subject = string.Format("Tên sự kiện : {0}" ,row["TenSuKien"]);
                appointment.Location = string.Format("Nơi diễn ra : {0} - Đội phụ trách: {1}", row["ViTriDienRa"], row["TenBanNganh"]);
                appointment.Description = row["NoiDung"].ToString();
                schedulerControl.Storage.Appointments.Add(appointment);
            }
        }



        private void SchedulerControl1_MouseDown(object sender, MouseEventArgs e)
        {
            SchedulerControl scheduler = sender as SchedulerControl;
            SchedulerHitInfo hitInfo = scheduler.ActiveView.ViewInfo.CalcHitInfo(e.Location, true);

            if (hitInfo.HitTest == SchedulerHitTest.Cell)
            {
                DateTime selectedDate = hitInfo.ViewInfo.Interval.Start;
                TimeSpan selectedTime = hitInfo.ViewInfo.Interval.Start.TimeOfDay;
                ThemSuKien addEventForm = new ThemSuKien(selectedDate, selectedTime);
                addEventForm.ShowDialog();
               
                if (addEventForm.DialogResult == DialogResult.OK)
                {
                    AddEventToScheduler(addEventForm.EventName, addEventForm.EventDescription, addEventForm.EventDate, addEventForm.EventDateEnd, addEventForm.EventLocation);
                }
            }
            schedulerControl1.Storage.Appointments.Clear();
            LoadEvents(schedulerControl1);
        }

        private void AddEventToScheduler(string eventName, string eventDescription, DateTime eventDate, DateTime EventDateEnd, string EventLocation)
        {
            Appointment appointment = schedulerControl1.Storage.CreateAppointment(AppointmentType.Normal);
            appointment.Start = eventDate;
            appointment.End = EventDateEnd;
            appointment.Subject = eventName;
            appointment.Description = eventDescription;
            appointment.Location = string.Format("Nơi diễn ra : {0}", EventLocation);
            schedulerControl1.Storage.Appointments.Add(appointment);
        }

       
    }
}