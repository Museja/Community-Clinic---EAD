using CommunityClinic.Data;
using CommunityClinic.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace CommunityClinic
{
    public partial class PatientPortalForm : Form
    {
        private int patientId;

        // DAL OBJECTS
        private PatientDAL patientDAL = new PatientDAL();
        private AppointmentsDAL appointmentDAL = new AppointmentsDAL();
        private MedicalHistoryDAL historyDAL = new MedicalHistoryDAL();
        private PrescriptionsDAL prescriptionDAL = new PrescriptionsDAL();

        // CONSTRUCTOR WITH PATIENT ID
        public PatientPortalForm(int id)
        {
            InitializeComponent();
            patientId = id;
        }

        // DEFAULT CONSTRUCTOR
        public PatientPortalForm()
        {
            InitializeComponent();
            patientId = -1;
        }

        // FORM LOAD
        private void PatientPortalForm_Load(object sender, EventArgs e)
        {
            if (patientId > 0)
            {
                LoadPatientProfile();
            }
        }

        // LOAD PROFILE
        private void LoadPatientProfile()
        {
            try
            {
                Patient patient =
                    patientDAL.GetPatientById(patientId);

                if (patient != null)
                {
                    txtFullName.Text = patient.Name;
                    txtPhone.Text = patient.PhoneNumber;
                    txtEmail.Text = patient.EmailAddress;
                    txtAddress.Text = patient.Address;
                    dtDOB.Value = patient.DateOfBirth;
                }
                else
                {
                    MessageBox.Show("Patient not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading profile: " + ex.Message);
            }
        }

        // UPDATE PROFILE
        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            try
            {
                Patient patient = new Patient
                {
                    Id = patientId,
                    Name = txtFullName.Text.Trim(),
                    PhoneNumber = txtPhone.Text.Trim(),
                    EmailAddress = txtEmail.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    DateOfBirth = dtDOB.Value
                };

                bool success =
                    patientDAL.UpdatePatient(patient);

                if (success)
                {
                    MessageBox.Show(
                        "Profile updated successfully!");
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating profile: " + ex.Message);
            }
        }

        // LOAD APPOINTMENTS
        private void btnRefreshAppointments_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                DataTable dt =
                    appointmentDAL.GetAppointmentsByPatient(patientId);

                dgvappointments1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading appointments: " + ex.Message);
            }
        }

        // BOOK APPOINTMENT
        private void btnBookAppointment_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Booking feature coming soon.");
        }

        // LOAD HISTORY
        private void btnLoadHistory_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                DataTable dt =
                    historyDAL.GetHistoryByPatient(patientId);

                dgvHistory1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading history: " + ex.Message);
            }
        }

        // LOAD PRESCRIPTIONS
        private void btnLoadPrescriptions_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                DataTable dt =
                    prescriptionDAL.GetPrescriptionsByPatient(patientId);

                dgvPrescriptions1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading prescriptions: " + ex.Message);
            }
        }

        // LOAD PROFILE BUTTON
        private void btnLoadProfile_Click(
            object sender,
            EventArgs e)
        {
            LoadPatientProfile();
        }

        // LOGOUT
        private void Logout_Click(
            object sender,
            EventArgs e)
        {
            LogoutForm form = new LogoutForm();
            form.Show();

            this.Close();
        }

        // BACK
        private void button1_Click(
            object sender,
            EventArgs e)
        {
            MainFormMDI form = new MainFormMDI();
            form.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
           "Are you sure you want to exit the application?",
           "Exit Application",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}