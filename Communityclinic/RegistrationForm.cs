using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Net.Mail;
using static CommunityClinic.Models.Patient;
using static CommunityClinic.Models.UserRegistration;

namespace CommunityClinic
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
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

        // REGISTER BUTTON
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullname.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmpassword.Text;
            string adminId = txtAdminId.Text.Trim();

            string role = "";

            if (radioPatient.Checked)
                role = "Patient";
            else if (radioAdmin.Checked)
                role = "Admin";
            else if (radioMedicalstaff.Checked)
                role = "Medical Staff";

            List<string> errors = new List<string>();

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
                    errors.Add("Enter a valid email address");
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

            // ADMIN VALIDATION
            if (role == "Admin")
            {
                if (string.IsNullOrWhiteSpace(adminId))
                    errors.Add("Admin ID is required");

                if (adminId != "12345")
                    errors.Add("Invalid Admin ID");
            }

            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errors), "Validation Error");
                return;
            }

            // HASH PASSWORD
            string passwordHash = HashPassword(password);

            try
            {
                // CALL DAL (THIS IS THE LINK)
                PatientDAL1 dal = new PatientDAL1();

                bool success = dal.RegisterUser(
                    fullName,
                    email,
                    passwordHash,
                    role,
                    role == "Admin" ? adminId : null
                );

                if (success)
                {
                    Form nextForm;

                    if (role == "Patient")
                    {
                        nextForm = new SuccessForm();
                    }
                    else
                    {
                        nextForm = new MainFormMDI();
                    }

                    nextForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error saving registration.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }

        // UI EVENTS (UNCHANGED)
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
            lblAdminId.Visible = false;
        }

        private void AdminID_TextChanged(object sender, EventArgs e)
        {
            txtAdminId.Visible = false;
        }

        private void radioPatient_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAdmin.Checked)
            {
                lblAdminId.Visible = true;
                txtAdminId.Visible = true;
            }
            else
            {
                lblAdminId.Visible = false;
                txtAdminId.Visible = false;
                txtAdminId.Clear();
            }
        }

        private void lblMedStaff_Click(object sender, EventArgs e)
        {
            lblMedStaff.Visible = false;
        }

        private void txtMedStaff_TextChanged(object sender, EventArgs e)
        {
            txtMedStaff.Visible = false;
        }

        private void radioMedicalstaff_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMedicalstaff.Checked)
            {
                lblMedStaff.Visible = true;
                txtMedStaff.Visible = true;
            }
            else
            {
                lblMedStaff.Visible = false;
                txtMedStaff.Visible = false;
                txtMedStaff.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
          "Are you sure you want to exit the application?",
          "Exit Application",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

