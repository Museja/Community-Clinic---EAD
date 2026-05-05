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

namespace Communityclinic
{
    public partial class MedicalNotesForm : Form
    {
        string connectionString = @"Data Source=YOUR_SERVER_NAME;Initial Catalog=YOUR_DATABASE;Integrated Security=True";
        public MedicalNotesForm()
        {
            InitializeComponent();
        }

        private void btnSubmitMNF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPatientName.Text) ||
        string.IsNullOrWhiteSpace(txtPatientIDNum.Text) ||
        string.IsNullOrWhiteSpace(txtDoctorName.Text) ||
        string.IsNullOrWhiteSpace(txtNotes.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO PatientNotes 
                        (PatientName, PatientID, DoctorName, NoteDate, Notes)
                        VALUES 
                        (@PatientName, @PatientID, @DoctorName, @NoteDate, @Notes)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@PatientName", txtPatientName.Text);
                cmd.Parameters.AddWithValue("@PatientID", txtPatientIDNum.Text);
                cmd.Parameters.AddWithValue("@DoctorName", txtDoctorName.Text);
                cmd.Parameters.AddWithValue("@NoteDate", dtpDate.Value);
                cmd.Parameters.AddWithValue("@Notes", txtNotes.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Note saved successfully!");

                    // Clear fields after save
                    txtPatientName.Clear();
                    txtPatientIDNum.Clear();
                    txtDoctorName.Clear();
                    txtNotes.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

