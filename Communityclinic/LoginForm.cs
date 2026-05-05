using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Communityclinic
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password");
                return;
            }


            // Check which role is selected

            if (!rbAdmin.Checked && !rbPatient.Checked && !rbDoctor.Checked)
            {
                MessageBox.Show("Please select a role (Admin, Patient, or Doctor)");
                return;
            }

            Form dashboard = null;

            // Admin Login
            if (rbAdmin.Checked)
            {
                if (username == "admin" && password == "admin123")
                {
                    dashboard = new AdminDashboardForm();
               
                }
               
            }

            // Patient Login
            else if (rbPatient.Checked)
            {
                if (username == "patient" && password == "1234")
                {
                    dashboard = new PatientDashboardForm();
                }
                
            }

            // Doctor Login
            else if (rbDoctor.Checked)
            {
                if (username == "doctor" && password == "doc123")
                {
                    dashboard = new DoctorDashboardForm();
                }
                else
                {
                    MessageBox.Show("Invalid login details");
                    return;
                }

                // Open MDI Parent
                MainFormMDI mdi = new MainFormMDI();

                // Set dashboard as child of MDI
                dashboard.MdiParent = mdi;


                // Show both
                mdi.Show();
                dashboard.Show();

                // Hide login form
                this.Hide();

                dashboard.Dock = DockStyle.Fill;

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();   // clears the username field
            txtPassword.Clear();   // clears the password field
            txtUsername.Focus();   // puts cursor back in the username box
        }
    }
}
