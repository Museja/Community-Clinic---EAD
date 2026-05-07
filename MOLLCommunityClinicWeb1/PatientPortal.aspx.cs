using System;
using System.Linq;
using System.Web.UI;
using MOLLCommunityClinicWeb1.Models;
using MOLLCommunityClinicWeb1.Services;

namespace MOLLCommunityClinicWeb1
{
    public partial class PatientPortal : System.Web.UI.Page
    {
        private PatientService patientService = new PatientService();
        private AppointmentsService appointmentService = new AppointmentsService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadPatientData();
                LoadAppointments();
            }
        }

        private void LoadPatientData()
        {
            try
            {
                if (Session["UserId"] == null)
                {
                    Response.Redirect("~/Login.aspx");
                    return;
                }

                int patientId = Convert.ToInt32(Session["UserId"]);

                var patients = patientService.GetAllPatients();

                var patient = patients.FirstOrDefault(p => p.PatientID == patientId);

                if (patient != null)
                {
                    lblMessages.Text = "";

                    txtFullName.Text = patient.Name;
                    txtEmail.Text = patient.EmailAddress;
                    txtPhone.Text = patient.PhoneNumber;
                    txtAddress.Text = patient.Address;
                }
                else
                {
                    lblMessages.Text = "Patient not found.";
                }
            }
            catch (Exception ex)
            {
                lblMessages.Text = "Error loading patient: " + ex.Message;
            }
        }

        private void LoadAppointments()
        {
            try
            {
                int patientId = Convert.ToInt32(Session["UserId"]);

                var appointments = appointmentService.GetByPatientId(patientId);

                gvAppointments.DataSource = appointments;
                gvAppointments.DataBind();
            }
            catch (Exception ex)
            {
                lblMessages.Text = "Error loading appointments: " + ex.Message;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int patientId = Convert.ToInt32(Session["UserId"]);

                PatientWeb patient = new PatientWeb
                {
                    PatientID = patientId,
                    Name = txtFullName.Text,
                    EmailAddress = txtEmail.Text,
                    PhoneNumber = txtPhone.Text,
                    Address = txtAddress.Text
                };

                patientService.UpdatePatient(patient);

                lblMessages.Text = "Profile updated successfully.";

                LoadPatientData();
            }
            catch (Exception ex)
            {
                lblMessages.Text = "Error updating profile: " + ex.Message;
            }
        }

        protected void btnReschedule_Click(object sender, EventArgs e)
        {
            try
            {
                int appointmentId = Convert.ToInt32(txtAppointmentId.Text);

                appointmentService.UpdateStatus(appointmentId, "Rescheduled");

                lblMessages.Text = "Appointment rescheduled successfully.";

                LoadAppointments();
            }
            catch (Exception ex)
            {
                lblMessages.Text = "Error rescheduling: " + ex.Message;
            }
        }

        protected void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                int appointmentId = Convert.ToInt32(txtAppointmentId.Text);

                appointmentService.UpdateStatus(appointmentId, "Cancelled");

                lblMessages.Text = "Appointment cancelled successfully.";

                LoadAppointments();
            }
            catch (Exception ex)
            {
                lblMessages.Text = "Error cancelling: " + ex.Message;
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MainMDI.aspx");
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }
    }
}