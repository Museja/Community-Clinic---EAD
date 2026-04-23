using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserMgmt
{
    public partial class FrmNewAppt : Form
    {
        public FrmNewAppt()
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

            // Radio buttons (Male / Female)
            if (!radioMale.Checked && !radioFemale.Checked)
            {
                MessageBox.Show("Please select Male or Female.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            // Radio buttons (New or Returning Patient Yes / No)
            if (!radioYes.Checked && !radioNo.Checked)
            {
                MessageBox.Show("Please indicate whether this is a returning patient or not. (Yes or No).", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            // Phone validation — at least one contact required
            bool hasCell = !string.IsNullOrWhiteSpace(txtCell.Text)
                           && txtCell.Text != "(876)555-5555";
            bool hasMobile = !string.IsNullOrWhiteSpace(txtMobile.Text)
                             && txtMobile.Text != "(876)555-5555";

            if (!hasCell && !hasMobile)
            {
                MessageBox.Show("Please enter at least one phone number (Cell or Mobile).",
                                "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtCell.Focus();
                return false;
            }

            // Validate cell only if it was filled in
            if (hasCell && (!txtCell.Text.All(char.IsDigit) || txtCell.Text.Length != 10))
            {
                MessageBox.Show("Cell number must be exactly 10 digits.",
                                "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtCell.Focus();
                return false;
            }

            // Validate mobile only if it was filled in
            if (hasMobile && (!txtMobile.Text.All(char.IsDigit) || txtMobile.Text.Length != 10))
            {
                MessageBox.Show("Mobile number must be exactly 10 digits.",
                                "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

            // Day validation
            if (cmbDay.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a day.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cmbDay.Focus();
                return false;
            }

            // Month validation
            if (cmbMonth.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a Month.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cmbMonth.Focus();
                return false;
            }

            // Year validation
            if (cmbYear.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a year.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cmbYear.Focus();
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

            // Appointment Type
            if (cmbApptType.SelectedIndex == 0)
            {
                MessageBox.Show("Please select an appointment type.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cmbApptType.Focus();
                return false;
            }

            // Doctor
            if (cmbDocName.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a doctor.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cmbDocName.Focus();
                return false;
            }

            // Appointment Time
            if (cmbTime.SelectedIndex == 0)
            {
                MessageBox.Show("Please select an appointment time.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cmbTime.Focus();
                return false;
            }

            // Appointment Time
            if (cmbTime.SelectedIndex == 0)
            {
                MessageBox.Show("Please select an appointment time.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cmbTime.Focus();
                return false;
            }

            // Appointment Date — combined parse + must be today or future
            int day = int.Parse(cmbDay.Text);
            int month = cmbMonth.SelectedIndex;   // Items: index 0 = placeholder, 1 = January ... 12 = December
            int year = int.Parse(cmbYear.Text);

            DateTime apptDate;
            if (!DateTime.TryParse($"{year}-{month}-{day}", out apptDate))
            {
                MessageBox.Show("The selected date is not valid (e.g. February 30 does not exist).",
                                "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cmbDay.Focus();
                return false;
            }

            if (apptDate.Date < DateTime.Today)
            {
                MessageBox.Show("Appointment date must be today or a future date.",
                                "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cmbDay.Focus();
                return false;
            }

            return true; // ✅ everything passed

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtNotes.Clear();
            txtCell.Text = "(876)555-5555";
            txtCell.ForeColor = Color.FromArgb(220, 220, 220);
            txtMobile.Text = "(876)555-5555";
            txtMobile.ForeColor = Color.FromArgb(220, 220, 220);
            radioFemale.Checked = false;
            radioMale.Checked = false;
            radioYes.Checked = false;
            radioNo.Checked = false;
            txtAddress.Clear();
            txtTown.Clear();
            cmbParish.SelectedIndex = 0;
            cmbDay.SelectedIndex = 0;
            cmbMonth.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;
            cmbApptType.SelectedIndex = 0;
            cmbTime.SelectedIndex = 0;
            cmbDocName.SelectedIndex = 0;
        }

        private void SaveAppointment()
        {
            // todo: add database logic here
        }

        private void btnNewAppt_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;
            string first = txtFirstName.Text;
            string last = txtLastName.Text;

            try
            {
                SaveAppointment();
                MessageBox.Show("Appointment Created: " + first + " " + last, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating appointment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Block non-digit input
            }
        } 
        private void txtCell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Block non-digit input
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
        private void FrmNewAppt_Load(object sender, EventArgs e)
        {
            if (cmbDay.Items.Count == 0)
            {
                for (int d = 1; d <= 31; d++)
                    cmbDay.Items.Add(d.ToString());
            }

            if (cmbMonth.Items.Count == 0)
            {
                cmbMonth.Items.Add("Month");
                cmbMonth.Items.AddRange(new object[]
                {
                    "January", "February", "March", "April",
                    "May", "June", "July", "August",
                    "September", "October", "November", "December"
                });
            }
            cmbDay.Items.Insert(0, "Day");
            cmbDay.SelectedIndex = 0;
            cmbMonth.Items.Insert(0, "Month");
            cmbMonth.SelectedIndex = 0;
            cmbYear.Items.Insert(0, "Year");
            cmbYear.SelectedIndex = 0;
            cmbParish.Items.Insert(0, "Select a Parish");
            cmbParish.SelectedIndex = 0;
            txtCell.Text = "(876)555-5555";
            txtCell.ForeColor = Color.FromArgb(220, 220, 220);
            txtMobile.Text = "(876)555-5555";
            txtMobile.ForeColor = Color.FromArgb(220, 220, 220);
            cmbTime.Items.Insert(0, "-- Select Time --");
            cmbTime.SelectedIndex = 0;
            cmbApptType.Items.Insert(0, "-- Select Appointment Type --");
            cmbApptType.SelectedIndex = 0;
            cmbDocName.Items.Insert(0, "-- Select Doctor --");
            cmbDocName.SelectedIndex = 0;
        }
    }
}
