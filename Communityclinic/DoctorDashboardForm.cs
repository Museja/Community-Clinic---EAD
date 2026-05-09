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
    public partial class DoctorDashboardForm : Form
    {
        private string currentDoctor;
        private List<Appointment> appointments;
        public DoctorDashboardForm(string doctorName, List<Appointment> appointmentList)
        {
            InitializeComponent();

            currentDoctor = doctorName;
            appointments = appointmentList;
        }
        private void DoctorDashboard_Load(object sender, EventArgs e)
        {
            lblWelcomeDoctor.Text = $"Welcome, Dr. {currentDoctor}";
            LoadAppointments();
        }
        private void LoadAppointments()
        {
            var todaysAppointments = appointments
                .Where(a => a.DoctorName == currentDoctor && a.Time.Date == DateTime.Today)
                .ToList();

            dgvAppointmentsDD.DataSource = null;
            dgvAppointmentsDD.DataSource = todaysAppointments;

            lblTodayCount.Text = $"Appointments Today: {todaysAppointments.Count}";
        }

        //Marked Complete Button
        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
            if (dgvAppointmentsDD.CurrentRow != null)
            {
                var selected = (Appointment)dgvAppointmentsDD.CurrentRow.DataBoundItem;

                selected.Status = "Completed";

                dgvAppointmentsDD.Refresh();
            }
            else
            {
                MessageBox.Show("Select an appointment first.");
            }
        }


        //Refresh Button

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        //Exit the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
