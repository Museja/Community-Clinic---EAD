using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MOLLCommunityClinicWeb1
{
    public partial class PatientPortal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // LOAD DATA (DB later)
        protected void btnLoad_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Patient data loaded (database will be connected later).";
        }

        // SAVE PROFILE
        protected void btnSave_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Profile saved successfully (DB not connected yet).";
        }

        // RESCHEDULE APPOINTMENT
        protected void btnReschedule_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Appointment rescheduled successfully.";
        }

        // CANCEL APPOINTMENT
        protected void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Appointment cancelled successfully.";
        }

        // BACK TO MAIN MDI
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MainMDI.aspx");
        }

        // EXIT APPLICATION
        protected void btnExit_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }
    }
}