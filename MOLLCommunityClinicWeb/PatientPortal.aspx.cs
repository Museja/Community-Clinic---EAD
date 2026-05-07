using System;
using System.Web.UI;

namespace MOLLCommunityClinicWeb
{
    public partial class PatientPortal : Page
    {
        PatientDAL1 patientDAL = new PatientDAL1();
        AppointmentDAL1 appointmentDAL = new AppointmentDAL1();
        MedicalHistoryDAL1 historyDAL = new MedicalHistoryDAL1();
        PrescriptionsDAL1 prescriptionDAL = new PrescriptionsDAL1();

        private int patientId;

        protected void Page_Load(object sender, EventArgs e)
        {
            // SECURITY CHECK
            if (Session["PatientId"] == null)
            {
                Response.Redirect("~/Login.aspx");
                return;
            }

            patientId = Convert.ToInt32(Session["PatientId"]);

            if (!IsPostBack)
            {
                LoadProfile();
            }
        }

        // LOAD PROFILE
        private void LoadProfile()
        {
            var patient = patientDAL.GetPatientById(patientId);

            if (patient != null)
            {
                txtFullName.Text = patient.Name;
                txtPhone.Text = patient.PhoneNumber;
                txtEmail.Text = patient.EmailAddress;
                txtAddress.Text = patient.Address;
                dtDOB.Text = patient.DateOfBirth.ToString("yyyy-MM-dd");
            }
        }

        // UPDATE PROFILE
        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            try
            {
                var patient = new PatientModel1
                {
                    PatientId = patientId,
                    Name = txtFullName.Text.Trim(),
                    PhoneNumber = txtPhone.Text.Trim(),
                    EmailAddress = txtEmail.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    DateOfBirth = DateTime.TryParse(dtDOB.Text, out DateTime dob)
                        ? dob
                        : DateTime.MinValue
                };

                bool success = patientDAL.UpdatePatient(patient);

                ShowMessage(success
                    ? "Profile updated successfully!"
                    : "Update failed.", success);
            }
            catch (Exception ex)
            {
                ShowMessage("Error: " + ex.Message, false);
            }
        }

        // APPOINTMENTS
        protected void btnRefreshAppointments_Click(object sender, EventArgs e)
        {
            gvAppointments.DataSource = appointmentDAL.GetAppointmentsByPatient(patientId);
            gvAppointments.DataBind();
        }

        protected void btnBookAppointment_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/BookAppointment.aspx");
        }

        // HISTORY
        protected void btnLoadHistory_Click(object sender, EventArgs e)
        {
            gvHistory.DataSource = historyDAL.GetHistoryByPatient(patientId);
            gvHistory.DataBind();
        }

        // PRESCRIPTIONS
        protected void btnLoadPrescriptions_Click(object sender, EventArgs e)
        {
            gvPrescriptions.DataSource = prescriptionDAL.GetPrescriptionsByPatient(patientId);
            gvPrescriptions.DataBind();
        }

        // BACK
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        // LOGOUT
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }

        // MESSAGE HANDLER
        private void ShowMessage(string message, bool success)
        {
            lblMessage.Visible = true;
            lblMessage.Text = message;
            lblMessage.CssClass = success ? "text-success" : "text-danger";
        }
    }
}