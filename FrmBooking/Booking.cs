using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBooking
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
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
            if (!radioNo.Checked && !radioYes.Checked)
            {
                MessageBox.Show("Please select if the patient is new or existing.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            // Phone validation
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone number is required.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtPhone.Focus();
                return false;
            }

            // Ensure only digits and max 10 characters
            if (!txtPhone.Text.All(char.IsDigit) || txtPhone.Text.Length > 10)
            {
                MessageBox.Show("Phone number must be digits 10 only.", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtPhone.Focus();
                return false;
            }

            return true; // ✅ everything passed
                         
        }

        private void TxtFirstName_TextChanged(object sender, EventArgs e)
        { 
            
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            radioYes.Checked = false;
            radioNo.Checked = false;
            dtpDob.Value = DateTime.Now.AddYears(-18);
        }

        private void btnBook_Click_1(object sender, EventArgs e)
        {
            FrmNewA newAppointmentForm = new FrmNewA();
            newAppointmentForm.ShowDialog();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            FrmViewUsers viewUsers = new FrmViewUsers();
            viewUsers.ShowDialog();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            FrmEditUsers editUsers = new FrmEditUsers();
            editUsers.ShowDialog();
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            FrmRemoveUsers removeUsers = new FrmRemoveUsers();
            removeUsers.ShowDialog();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            txtPhone.Text = "(876)555-5555";
            txtPhone.ForeColor = Color.Gray;
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;
            string first = txtFirstName.Text;
            string last = txtLastName.Text;

            MessageBox.Show("User Created: " + first + " " + last, "Welcome", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "(876)555-5555")
            {
                txtPhone.Text = "";
                txtPhone.ForeColor = Color.Black;
            }
        }
        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                txtPhone.Text = "(876)555-5555";
                txtPhone.ForeColor = Color.Gray;
            }
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Limit to 10 digits
            if (txtPhone.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    
}
