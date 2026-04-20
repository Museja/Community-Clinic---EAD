using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace UserMgmt
{
    public partial class FrmPortal : Form
    {
        public FrmPortal()
        {
            InitializeComponent();
        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateForm()
        {
            // First Name
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtFirstName.Focus();
                return false;
            }

            // Last Name
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last Name is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtLastName.Focus();
                return false;
            }

            // Email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtEmail.Focus();
                return false;
            }

            // Email format check
            try
            {
                var email = new System.Net.Mail.MailAddress(txtEmail.Text);
            }
            catch
            {
                MessageBox.Show("Enter a valid email address.", "Check", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtEmail.Focus();
                return false;
            }

            // Date of Birth (basic check)
            if (dtpDob.Value >= DateTime.Now)
            {
                MessageBox.Show("Date of Birth must be in the past.", "Check", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            // Radio buttons (New / Existing)
            if (!radioMale.Checked && !radioFemale.Checked)
            {
                MessageBox.Show("Please select Male or Female.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            // Cell validation
            if (string.IsNullOrWhiteSpace(txtCell.Text) || txtCell.Text == "(876)555-5555")
            {
                MessageBox.Show("Phone number is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtCell.Focus();
                return false;
            }
            // Ensure only digits and max 10 characters
            if (!txtCell.Text.All(char.IsDigit) || txtCell.Text.Length != 10)
            {
                MessageBox.Show("Phone number must be digits, 10 only.", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtCell.Focus();
                return false;
            }
            // Mobile validation
            if (string.IsNullOrWhiteSpace(txtMobile.Text) || txtMobile.Text == "(876)555-5555")
            {
                MessageBox.Show("Phone number is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtMobile.Focus();
                return false;
            }
            // Ensure only digits and max 10 characters
            if (!txtCell.Text.All(char.IsDigit) || txtCell.Text.Length != 10)
            {
                MessageBox.Show("Phone number must be digits, 10 only.", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtCell.Focus();
                return false;
            }

            // Ensure only digits and max 10 characters
            if (!txtMobile.Text.All(char.IsDigit) || txtMobile.Text.Length > 10)
            {
                MessageBox.Show("Phone number must be digits, 10 only.", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtMobile.Focus();
                return false;
            }

            // Parish validation
            if (cmbParish.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a parish.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cmbParish.Focus();
                return false;
            }

            // Address validation
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtAddress.Focus();
                return false;
            }

            // Town validation
            if (string.IsNullOrWhiteSpace(txtTown.Text))
            {
                MessageBox.Show("Town is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtTown.Focus();
                return false;
            }

            return true; // ✅ everything passed

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtCell.Text = "(876)555-5555";
            txtCell.ForeColor = Color.LightGray;
            txtMobile.Text = "(876)555-5555";
            txtMobile.ForeColor = Color.FromArgb(220, 220, 220);
            radioFemale.Checked = false;
            radioMale.Checked = false;
            dtpDob.Value = DateTime.Now.AddYears(-18);
            txtAddress.Clear();
            txtTown.Clear();
            cmbParish.SelectedIndex = 0;
        }

        private void btnNewAppt_Click(object sender, EventArgs e)
        {
            FrmNewAppt newAppointmentForm = new FrmNewAppt();
            newAppointmentForm.ShowDialog();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;
            string first = txtFirstName.Text;
            string last = txtLastName.Text;

            try
            {
                SaveUser();
                MessageBox.Show("User Created: " + first + " " + last, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCell_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits and backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMobile_Enter(object sender, EventArgs e)
        {
            if (txtMobile.Text == "(876)555-5555")
            {
                txtMobile.Text = "";
                txtMobile.ForeColor = Color.Black;
            }
        }
        private void txtMobile_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMobile.Text))
            {
                txtMobile.Text = "(876)555-5555";
                txtMobile.ForeColor = Color.FromArgb(220, 220, 220);
            }
        }
        private void txtCell_Enter(object sender, EventArgs e)
        {
            if (txtCell.Text == "(876)555-5555")
            {
                txtCell.Text = "";
                txtCell.ForeColor = Color.Black;
            }
        }

        private void txtCell_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCell.Text))
            {
                txtCell.Text = "(876)555-5555";
                txtCell.ForeColor = Color.FromArgb(220, 220, 220);
            }
        }
        private void SaveUser()
        {
            //todo: add database logic here
        }

        private void FrmPortal_Load(object sender, EventArgs e)
        {
            cmbParish.Items.Insert(0, "Select a Parish.");
            cmbParish.SelectedIndex = 0;

            // Set placeholder for Cell
            txtCell.Text = "(876)555-5555";
            txtCell.ForeColor = Color.FromArgb(220, 220, 220);

            // Set placeholder for Mobile
            txtMobile.Text = "(876)555-5555";
            txtMobile.ForeColor = Color.FromArgb(220, 220, 220);
        }
    }
    
}