using System;
using System.Text;
using System.Security.Cryptography;
using MOLLCommunityClinicWeb1.Models;
using MOLLCommunityClinicWeb1.Services;

namespace MOLLCommunityClinicWeb1
{
    public partial class Registration : System.Web.UI.Page
    {
        private Userservice userService = new Userservice();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        protected void Role_CheckedChanged(object sender, EventArgs e)
        {
            pnlAdmin.Visible = radioAdmin.Checked;
            pnlMedStaff.Visible = radioMedicalstaff.Checked;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //  Validate password match
            if (txtPassword.Text != txtConfirmpassword.Text)
            {
                lblMessage.Text = "Passwords do not match.";
                return;
            }

            string role = GetRole();

            if (string.IsNullOrEmpty(role))
            {
                lblMessage.Text = "Please select a role.";
                return;
            }

            // Build User model
            User user = new User
            {
                FullName = txtFullname.Text,
                Email = txtEmail.Text,
                PasswordHash = HashPassword(txtPassword.Text),
                Role = role,
                AdminID = role == "Admin" ? txtAdminId.Text : null,
                MedStaffID = role == "Medical Staff" ? txtMedStaff.Text : null
            };

            //  Call SERVICE LAYER 
            userService.RegisterUser(user);


            // REDIRECT TO SUCCESS PAGE
            Response.Redirect("~/Success.aspx");
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
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