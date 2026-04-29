using Communityclinic;
using Communityclinic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Communityclinic.Models.PatientModels;

namespace CommunityClinic
{
    public partial class PatientPortalForm : Form
    {
        private int patientId;

        public PatientPortalForm(int id)
        {
            InitializeComponent();
            patientId = id;
        }
        public PatientPortalForm()
        {
            InitializeComponent();
        }

        // =========================
        // FORM LOAD
        // =========================
        private void PatientPortalForm_Load(object sender, EventArgs e)
        {
            if (patientId > 0)
            {
                LoadPatientProfile();
            }
        }

        // =========================
        // LOAD PROFILE (Tab 1)
        // Uses YOUR textBox1 - textBox5
        // =========================
        private void LoadPatientProfile()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM Patients WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", patientId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtFullName.Text = reader["FullName"].ToString();
                    txtPhone.Text = reader["Phone"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                    DateTime dob = DateTimePicker.Value
                }
            }
        }

        // Load button (Profile tab)
        private void btnLoadProfile_Click(object sender, EventArgs e)
        {
            LoadPatientProfile();
        }

        // =========================
        // UPDATE PROFILE
        // =========================
        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"UPDATE Patients SET
                                FullName=@FullName,
                                Phone=@Phone,
                                Email=@Email,
                                Address=@Address,
                                DOB=@DOB
                                WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@DOB", txtDOB.Text);
                cmd.Parameters.AddWithValue("@Id", patientId);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Profile updated successfully!");
            }
        }

        // =========================
        // APPOINTMENTS TAB
        // =========================
        private void btnRefreshAppointments_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM Appointments WHERE PatientId=@Id";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Id", patientId);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvappointments1.DataSource = dt;
            }
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking feature will be added here.");
        }

        // =========================
        // MEDICAL HISTORY TAB
        // =========================
        private void btnLoadHistory_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM MedicalHistory WHERE PatientId=@Id";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Id", patientId);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvHistory1.DataSource = dt;
            }
        }

        // =========================
        // PRESCRIPTIONS TAB
        // =========================
        private void btnLoadPrescriptions_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM Prescriptions WHERE PatientId=@Id";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Id", patientId);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPrescriptions1.DataSource = dt;
            }
        }

        // =========================
        // LOGOUT
        // =========================
        private void Logout_Click(object sender, EventArgs e)
        {
            LogoutForm form = new LogoutForm(); // or LoginForm if that's what you use
            form.Show();
            this.Close();
        }
    }
}