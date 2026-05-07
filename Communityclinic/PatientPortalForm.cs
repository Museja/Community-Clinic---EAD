using CommunityClinic;
using CommunityClinic.Data;
using CommunityClinic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static CommunityClinic.Models.AppointmentsModels;
using static CommunityClinic.Models.MedicalHistoryModels;
using static CommunityClinic.Models.Patient;
using static CommunityClinic.Models.PrescriptionsModels;

namespace CommunityClinic
{
    public partial class PatientPortalForm : Form
    {
        private int patientId;

        // DAL INSTANCES (LINKED LAYERS)
        private PatientDAL patientDAL = new PatientDAL();
        private AppointmentsDAL appointmentDAL = new AppointmentsDAL();
        private MedicalHistoryDAL historyDAL = new MedicalHistoryDAL();
        private PrescriptionsDAL prescriptionDAL = new PrescriptionsDAL();

        // Constructor with ID
        public PatientPortalForm(int id)
        {
            InitializeComponent();
            patientId = id;
            this.Load += PatientPortalForm_Load;
        }

        // Default constructor
        public PatientPortalForm()
        {
            InitializeComponent();
            patientId = -1;
            this.Load += PatientPortalForm_Load;
        }

        // FORM LOAD
        private void PatientPortalForm_Load(object sender, EventArgs e)
        {
            if (patientId > 0)
            {
                LoadPatientProfile();
            }
        }

        // PATIENT PROFILE (DAL LINK)

        private void LoadPatientProfile()
        {
            try
            {
                Patient patient = patientDAL.GetPatientByEmail(txtEmail.Text);

                if (patient != null)
                {
                    txtFullName.Text = patient.Name;
                    txtPhone.Text = patient.PhoneNumber;
                    txtEmail.Text = patient.EmailAddress;
                    txtAddress.Text = patient.Address;
                    dtDOB.Value = patient.DateOfBirth;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }

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

                bool success = patientDAL.UpdatePatient(patient);

                MessageBox.Show(success
                    ? "Profile updated successfully!"
                    : "Update failed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message);
            }
        }

        // APPOINTMENTS (DAL LINK)

        private void btnRefreshAppointments_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt =
                    appointmentDAL.GetAppointmentsByPatient(patientId);

                dgvappointments1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message);
            }
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking feature will be implemented here.");
        }

        // MEDICAL HISTORY (DAL LINK)

        private void btnLoadHistory_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt =
                    historyDAL.GetHistoryByPatient(patientId);

                dgvHistory1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading history: " + ex.Message);
            }
        }

        // PRESCRIPTIONS (DAL LINK)
     

        private void btnLoadPrescriptions_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt =
                    prescriptionDAL.GetPrescriptionsByPatient(patientId);

                dgvPrescriptions1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading prescriptions: " + ex.Message);
            }
        }

        // NAVIGATION

        private void Logout_Click(object sender, EventArgs e)
        {
            LogoutForm form = new LogoutForm();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormMDI form = new MainFormMDI();
            form.Show();
            this.Close();
        }

        private void btnLoadProfile_Click(object sender, EventArgs e)
        {
            LoadPatientProfile();
        }
    }
}