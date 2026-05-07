using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Web.UI;

namespace MOLLCommunityClinicWeb
{
    public partial class Registration : System.Web.UI.Page
    {
        string connectionString =
            ConfigurationManager.ConnectionStrings["CommunityClinicLLOMDB"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }

        // HASH PASSWORD
        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        // ROLE TOGGLE
        protected void Role_CheckedChanged(object sender, EventArgs e)
        {
            pnlAdmin.Visible = radioAdmin.Checked;
            pnlMedStaff.Visible = radioMedicalstaff.Checked;

            if (!radioAdmin.Checked)
                txtAdminId.Text = "";

            if (!radioMedicalstaff.Checked)
                txtMedStaff.Text = "";
        }

        // REGISTER
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();

            string fullName = txtFullname.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmpassword.Text;
            string adminId = txtAdminId.Text.Trim();
            string medStaffId = txtMedStaff.Text.Trim();

            string role = GetRole();

            // VALIDATION
            if (string.IsNullOrWhiteSpace(fullName))
                errors.Add("Full Name is required");

            if (string.IsNullOrWhiteSpace(email))
                errors.Add("Email is required");
            else
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                }
                catch
                {
                    errors.Add("Invalid email format");
                }
            }

            if (string.IsNullOrWhiteSpace(password))
                errors.Add("Password is required");
            else if (password.Length < 6)
                errors.Add("Password must be at least 6 characters");

            if (password != confirmPassword)
                errors.Add("Passwords do not match");

            if (string.IsNullOrEmpty(role))
                errors.Add("Please select a role");

            if (role == "Admin" && adminId != "12345")
                errors.Add("Invalid Admin ID");

            if (role == "Medical Staff" && medStaffId != "54321")
                errors.Add("Invalid Medical Staff ID");

            if (errors.Count > 0)
            {
                ShowMessage(string.Join("<br/>", errors), false);
                return;
            }

            string passwordHash = HashPassword(password);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Users
                                    (FullName, Email, PasswordHash, Role, AdminID, MedStaffID)
                                    VALUES
                                    (@FullName, @Email, @PasswordHash, @Role, @AdminID, @MedStaffID)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@FullName", System.Data.SqlDbType.NVarChar).Value = fullName;
                        cmd.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar).Value = email;
                        cmd.Parameters.Add("@PasswordHash", System.Data.SqlDbType.NVarChar).Value = passwordHash;
                        cmd.Parameters.Add("@Role", System.Data.SqlDbType.NVarChar).Value = role;

                        cmd.Parameters.Add("@AdminID", System.Data.SqlDbType.NVarChar).Value =
                            role == "Admin" ? (object)adminId : DBNull.Value;

                        cmd.Parameters.Add("@MedStaffID", System.Data.SqlDbType.NVarChar).Value =
                            role == "Medical Staff" ? (object)medStaffId : DBNull.Value;

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            Session["User"] = email;
                            Session["Role"] = role;

                            if (role == "Patient")
                                Response.Redirect("~/Success.aspx");
                            else if (role == "Admin")
                                Response.Redirect("~/AdminDashboard.aspx");
                            else
                                Response.Redirect("~/MedicalStaffDashboard.aspx");
                        }
                        else
                        {
                            ShowMessage("Registration failed.", false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage("Error: " + ex.Message, false);
            }
        }

        // ROLE HELPER
        private string GetRole()
        {
            if (radioPatient.Checked) return "Patient";
            if (radioAdmin.Checked) return "Admin";
            if (radioMedicalstaff.Checked) return "Medical Staff";
            return "";
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