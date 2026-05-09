using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Communityclinic
{
    public partial class AdminDashboardForm : Form
    {

        private string currentAdmin;
        private List<Appointment> appointments;
        private List<Registration> registrations;
        public AdminDashboardForm(string adminName, List<Appointment> appointmentList, List<Registration> registrationList)
        {
            InitializeComponent();

            currentAdmin = adminName;
            appointments = appointmentList;
            registrations = registrationList;
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            lblWelcomeAdmin.Text = $"Welcome, {currentAdmin}";
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            var todaysAppointments = appointments
                .Where(a => a.Time.Date == DateTime.Today)
                .ToList();

            //Panel Counts
            lblTotalAppointments.Text = todaysAppointments.Count.ToString();

            lblTotalDoctors.Text = todaysAppointments
                .Select(a => a.DoctorName)
                .Distinct()
                .Count()
                .ToString();

            lblTotalPatients.Text = todaysAppointments
                .Select(a => a.PatientName)
                .Distinct()
                .Count()
                .ToString();

            // Doctors Grid
            var doctorsData = todaysAppointments
                .Select(a => new
                {
                    DoctorName = a.DoctorName,
                    Speciality = a.Speciality,   
                    Status = a.Status
                })
                .Distinct()
                .ToList();

            dgvDoctorsToday.DataSource = null;
            dgvDoctorsToday.DataSource = doctorsData;

            // Patients Grid
            var patientsData = todaysAppointments
                .Select(a => new
                {
                    PatientName = a.PatientName,
                    Doctor = a.DoctorName,
                    Time = a.Time.ToShortTimeString()
                })
                .ToList();

            dgvAppointmentsToday.DataSource = null;
            dgvAppointmentsToday.DataSource = patientsData;

            //Registrations Grid
            var regData = registrations
                .Select(r => new
                {
                    Name = r.Name,
                    Type = r.Type, // "Doctor" or "Patient"
                    DateRegistered = r.DateRegistered
                })
                .ToList();

            dgvRecentRegister.DataSource = null;
            dgvRecentRegister.DataSource = regData;
        }

        //View Reports Button
        private void btnViewReports_Click(object sender, EventArgs e)
        {
            
            SearchForm form = new SearchForm();
            form.Show();
        }

        //Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

