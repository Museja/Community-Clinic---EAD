using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MOLLCommunityClinicWeb1
{
    public partial class PatientList : System.Web.UI.Page
    {
        public partial class PatientList : System.Web.UI.Page
        {
            protected void Page_Load(object sender, EventArgs e)
            {
                if (!IsPostBack)
                {
                    LoadPatients();
                }
            }

            // LOAD ALL PATIENTS (placeholder for DB)
            private DataTable GetPatientTable()
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("DOB");
                dt.Columns.Add("Age");
                dt.Columns.Add("Gender");
                dt.Columns.Add("Phone");
                dt.Columns.Add("Address");
                dt.Columns.Add("Allergies");
                dt.Columns.Add("MedicalHistory");
                dt.Columns.Add("Medications");
                dt.Columns.Add("Email");

                dt.Rows.Add("1", "John Doe", "1990-01-10", "35", "Male", "123456",
                    "Kingston", "Peanuts", "Diabetes", "Metformin", "john@email.com");

                dt.Rows.Add("2", "Jane Smith", "1985-06-20", "40", "Female", "987654",
                    "Half Way Tree", "None", "Hypertension", "Amlodipine", "jane@email.com");

                dt.Rows.Add("3", "Mark Lee", "2000-03-15", "25", "Male", "555555",
                    "Portmore", "Dust Allergy", "Asthma", "Ventolin", "mark@email.com");

                return dt;
            }

            private void LoadPatients()
            {
                gvPatients.DataSource = GetPatientTable();
                gvPatients.DataBind();
            }

            // SEARCH
            protected void btnSearch_Click(object sender, EventArgs e)
            {
                string search = txtSearch.Text.ToLower();

                DataTable dt = GetPatientTable();
                DataView dv = dt.DefaultView;

                dv.RowFilter =
                    $"Name LIKE '%{search}%' OR " +
                    $"ID LIKE '%{search}%' OR " +
                    $"Phone LIKE '%{search}%' OR " +
                    $"Email LIKE '%{search}%' OR " +
                    $"Gender LIKE '%{search}%' OR " +
                    $"Allergies LIKE '%{search}%'";

                gvPatients.DataSource = dv;
                gvPatients.DataBind();
            }

            // REFRESH
            protected void btnRefresh_Click(object sender, EventArgs e)
            {
                txtSearch.Text = "";
                LoadPatients();
            }

            // BACK TO MAINMDI
            protected void btnBack_Click(object sender, EventArgs e)
            {
                Response.Redirect("~/MainMDI.aspx");
            }

            // EXIT SYSTEM
            protected void btnExit_Click(object sender, EventArgs e)
            {
                Session.Clear();
                Session.Abandon();
                Response.Redirect("~/Login.aspx");
            }
        }
    }
}