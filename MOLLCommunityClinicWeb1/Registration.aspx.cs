using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace MOLLCommunityClinicWeb1
{
    public partial class Registration : System.Web.UI.Page
    {
        string connectionString =
            ConfigurationManager.ConnectionStrings["CommunityClinicLLOMDB"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        protected void Role_CheckedChanged(object sender, EventArgs e)
        {
            pnlAdmin.Visible = radioAdmin.Checked;
            pnlMedStaff.Visible = radioMedicalstaff.Checked;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string role = GetRole();

            string hashed = HashPassword(txtPassword.Text);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Users
                (FullName, Email, PasswordHash, Role, AdminID, MedStaffID)
                VALUES (@FullName, @Email, @PasswordHash, @Role, @AdminID, @MedStaffID)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@FullName", txtFullname.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@PasswordHash", hashed);
                cmd.Parameters.AddWithValue("@Role", role);

                cmd.Parameters.AddWithValue("@AdminID",
                    role == "Admin" ? txtAdminId.Text : (object)DBNull.Value);

                cmd.Parameters.AddWithValue("@MedStaffID",
                    role == "Medical Staff" ? txtMedStaff.Text : (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            Response.Redirect("~/Success.aspx");
        }

        private string GetRole()
        {
            if (radioPatient.Checked) return "Patient";
            if (radioAdmin.Checked) return "Admin";
            if (radioMedicalstaff.Checked) return "Medical Staff";
            return "";
        }
    }
}