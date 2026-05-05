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
    public partial class PatientDashboardForm : Form
    {
        private string currentPatient;
        private List<Appointment> appointments;

        public PatientDashboardForm(string patientName, List<Appointment> appointmentList)
        {
            InitializeComponent();

            currentPatient = patientName;
            appointments = appointmentList;
        }

        private void PatientDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {currentPatient}";
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            var patientAppointments = appointments
                .Where(a => a.PatientName == currentPatient)
                .Select(a => new
                {
                    Date = a.Time.Date,
                    Doctor = a.DoctorName,
                    Status = a.Status,
                    Time = a.Time.ToShortTimeString()
                })
                .ToList();

            dgvAppointmentsPDB.DataSource = null;
            dgvAppointmentsPDB.DataSource = patientAppointments;
        }

        //Book Appointment Button

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            BookAppointmentForm form = new BookAppointmentForm(currentPatient);
            form.Show();
        }

        //View Prescription Button

        private void btnViewPrescription_Click(object sender, EventArgs e)
        {
            PrescriptionForm form = new PrescriptionForm(currentPatient);
            form.Show();
        }

        //Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
}
}
