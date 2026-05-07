using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MOLLCommunityClinicWeb1
{
    public partial class PatientForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // SAVE (DATABASE LATER)
        protected void btnSave_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = System.Drawing.Color.Green;
            lblMessage.Text = "Patient data saved successfully (DB will be connected later).";
        }

        // CLEAR FORM
        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtDOB.Text = "";
            txtAge.Text = "";
            ddlGender.SelectedIndex = 0;
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtAllergies.Text = "";
            txtMedications.Text = "";
            txtHistory.Text = "";

            lblMessage.Text = "";
        }

        // BACK TO SUCCESS PAGE
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Success.aspx");
        }

        // EXIT BUTTON
        protected void btnExit_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }
    }
}