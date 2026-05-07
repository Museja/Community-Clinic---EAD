using System;
using System.Web.UI;
using System.Xml.Linq;

namespace MOLLCommunityClinicWeb
{
    public partial class PatientData : Page
    {
        PatientDAL1 dal = new PatientDAL1();

        protected void Page_Load(object sender, EventArgs e)
        {
            // SECURITY CHECK
            if (Session["User"] == null)https://localhost:44380/Patientdata.aspx.cs
            {
                Response.Redirect("~/Login.aspx");
            }
        }

        // SAVE PATIENT
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                PatientModel1 patient = GetFormData();

                bool success = dal.AddPatient(patient);

                ShowMessage(success
                    ? "Patient saved successfully!"
                    : "Error saving patient.", success);
            }
            catch (Exception ex)
            {
                ShowMessage("Error: " + ex.Message, false);
            }
        }

        // UPDATE PATIENT
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                PatientModel1 patient = GetFormData();

                bool success = dal.UpdatePatient(patient);

                ShowMessage(success
                    ? "Patient updated successfully!"
                    : "Update failed.", success);
            }
            catch (Exception ex)
            {
                ShowMessage("Error: " + ex.Message, false);
            }
        }

        // CLEAR FORM
        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtDOB.Text = "";
            txtAge.Text = "";
            txtAddress.Text = "";
            txtPhonenumber.Text = "";
            txtEmail.Text = "";
            txtGender.Text = "";
            txtAllergies.Text = "";
            txtHistory.Text = "";
            txtMedications.Text = "";

            lblMessage.Visible = false;
        }

        // BACK BUTTON
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PatientPortal.aspx");
        }

        // MAP FORM, MODEL
        private PatientModel1 GetFormData()
        {
            return new PatientModel1
            {
                Name = txtName.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                PhoneNumber = txtPhonenumber.Text.Trim(),
                EmailAddress = txtEmail.Text.Trim(),
                Gender = txtGender.Text.Trim(),
                Allergies = txtAllergies.Text.Trim(),
                History = txtHistory.Text.Trim(),
                Medications = txtMedications.Text.Trim(),

                DateOfBirth = DateTime.TryParse(txtDOB.Text, out DateTime dob)
                    ? dob
                    : DateTime.MinValue,

                Age = int.TryParse(txtAge.Text, out int age)
                    ? age
                    : 0
            };
        }

        // CLEAN MESSAGE HANDLER
        private void ShowMessage(string message, bool success)
        {
            lblMessage.Visible = true;
            lblMessage.Text = message;
            lblMessage.CssClass = success ? "text-success" : "text-danger";
        }
    }
}