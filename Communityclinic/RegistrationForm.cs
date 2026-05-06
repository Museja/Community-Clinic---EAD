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
using static CommunityClinic.Models.UserRegistration;

namespace CommunityClinic
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // trims input
            string fullName = txtFullname.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmpassword.Text;
            string adminId = txtAdminId.Text.Trim(); // new field

            // Determines role
            string role = "";
            if (radioPatient.Checked)
                role = "Patient";
            else if (radioAdmin.Checked)
                role = "Admin";

            // Validation
            List<string> errors = new List<string>();

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

            // Role validation
            if (string.IsNullOrEmpty(role))
                errors.Add("Please select Patient or Admin");

            // Admin specific validation
            if (role == "Admin")
            {
                if (string.IsNullOrWhiteSpace(adminId))
                    errors.Add("Admin ID is required");

                // Example check (replace with real DB validation)
                if (adminId != "12345")
                    errors.Add("Invalid Admin ID");
            }

            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errors), "Validation Error");
                return;
            }

            // Hash password
            string passwordHash = HashPassword(password);

            if (passwordHash != null)
            {
                string connectionString = "Data Source=23.95.235.16;Initial Catalog=CommunityClinicLLOMDB;User ID=vtdi_student;Password=P@ssword1;";
                string query = "INSERT INTO Users (FullName, Email, PasswordHash, Role, AdminID) VALUES (@FullName, @Email, @PasswordHash, @Role, @AdminID)";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                        cmd.Parameters.AddWithValue("@Role", role);

                        if (role == "Admin")
                            cmd.Parameters.AddWithValue("@AdminID", adminId);
                        else
                            cmd.Parameters.AddWithValue("@AdminID", DBNull.Value);

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            // ✅ ROLE-BASED NAVIGATION FIX
                            Form nextForm;

                            if (role == "Patient")
                            {
                                nextForm = new SuccessForm();
                            }
                            else // Admin
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
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
            }

        }
        
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
                txtAdminId.Visible = true;
            }
            else
            {
                lblMedStaff.Visible = false;
                txtMedStaff.Visible = false;
                txtMedStaff.Clear();
            }
        }
    }
}
