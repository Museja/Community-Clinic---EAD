using System;
using System.Web.UI;

namespace MOLLCommunityClinicWeb
{
    public partial class Success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Prevents direct access
            if (Session["User"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PatientData.aspx");
        }
    }
}