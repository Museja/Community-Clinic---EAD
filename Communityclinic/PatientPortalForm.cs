using CommunityClinic;
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

        // CONSTRUCTOR (MAIN)
        public PatientPortalForm(int id)
        {
            InitializeComponent();

            patientId = id;

            // Ensure Load event always runs
            this.Load += PatientPortalForm_Load;
        }

        //DEFAULT CONSTRUCTOR 
        public PatientPortalForm()
        {
            InitializeComponent();

            patientId = -1;

            this.Load += PatientPortalForm_Load;
        }


        // FORM LOAD

        private void PatientPortalForm_Load(object sender, EventArgs e)
        {
            if (patientId > 0)
            {
                LoadPatientProfile();
            }
        }

        // LOAD PROFILE
        private void LoadPatientProfile()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"SELECT FullName, Phone, Email, Address, DOB 
                                 FROM Patients 
                                 WHERE Id = @Id";

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
                    dtDOB.Value = Convert.ToDateTime(column["DOB"]);
                }
            }
        }

        // UPDATE PROFILE


        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"UPDATE Patients 
                                 SET FullName=@FullName,
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
                DateTime dob = dtDOB.Value;
                cmd.Parameters.AddWithValue("@Id", patientId);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Profile updated successfully!");
            }
        }

        // APPOINTMENTS TAB
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
            MessageBox.Show("Booking feature will be implemented here.");
        }

        // MEDICAL HISTORY TAB
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

        // PRESCRIPTIONS TAB
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

        // LOGOUT
        private void Logout_Click(object sender, EventArgs e)
        {
          LogoutForm form = new LogoutForm();
            form.Show();
            this.Close();
        }

        private void btnLoadProfile_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormMDI login = new MainFormMDI();
            login.Show();
            this.Close();
        }
    }
}