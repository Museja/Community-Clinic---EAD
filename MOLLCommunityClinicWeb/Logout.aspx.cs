using System;

namespace MOLLCommunityClinicWeb
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                // Clears session completely
                Session.Clear();
                Session.Abandon();

                // Removes authentication cookie if exists
                if (Request.Cookies["ASP.NET_SessionId"] != null)
                {
                    Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddDays(-1);
                }

                // Redirects to login page
                Response.Redirect("~/Login.aspx");
            }
        }
    }
}