using CommunityClinic.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CommunityClinic
{
    public class PatientDAL
    {
        // Add a new patient to the database.
        public bool AddPatient(Patient patient)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO Patient 
                                (Name, DOB, Age, Address, Phone, Email, Gender, Allergies, History, Medications)
                                VALUES 
                                (@Name, @DateOfBirth, @Age, @Address, @PhoneNumber, @EmailAddress, @Gender, @Allergies, @History, @Medications)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Name", patient.Name);
                cmd.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
                cmd.Parameters.AddWithValue("@Age", patient.Age);
                cmd.Parameters.AddWithValue("@Address", patient.Address);
                cmd.Parameters.AddWithValue("@PhoneNumber", patient.PhoneNumber);
                cmd.Parameters.AddWithValue("@EmailAddress", patient.EmailAddress);
                cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                cmd.Parameters.AddWithValue("@Allergies", patient.Allergies ?? string.Empty);
                cmd.Parameters.AddWithValue("@History", patient.History ?? string.Empty);
                cmd.Parameters.AddWithValue("@Medications", patient.Medications ?? string.Empty);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Update an existing patient.
        public bool UpdatePatient(Patient patient)
        {
            if (patient.PatientID <= 0)
                throw new ArgumentException("PatientID is required for update.");

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"UPDATE Patient SET
                                    Name=@Name,
                                    DOB=@DateOfBirth,
                                    Age=@Age,
                                    Address=@Address,
                                    Phone=@PhoneNumber,
                                    Email=@EmailAddress,
                                    Gender=@Gender,
                                    Allergies=@Allergies,
                                    History=@History,
                                    Medications=@Medications
                                 WHERE ID=@PatientID";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@PatientID", patient.PatientID);
                cmd.Parameters.AddWithValue("@Name", patient.Name);
                cmd.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
                cmd.Parameters.AddWithValue("@Age", patient.Age);
                cmd.Parameters.AddWithValue("@Address", patient.Address);
                cmd.Parameters.AddWithValue("@PhoneNumber", patient.PhoneNumber);
                cmd.Parameters.AddWithValue("@EmailAddress", patient.EmailAddress);
                cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                cmd.Parameters.AddWithValue("@Allergies", patient.Allergies ?? string.Empty);
                cmd.Parameters.AddWithValue("@History", patient.History ?? string.Empty);
                cmd.Parameters.AddWithValue("@Medications", patient.Medications ?? string.Empty);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Get a patient by email.
        public Patient GetPatientByEmail(string email)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM Patient WHERE Email=@Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return MapReaderToPatient(reader);
                    else
                        return null;
                }
            }
        }

        /// Get a patient by ID.
        public Patient GetPatientById(int id)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM Patient WHERE ID=@PatientID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PatientID", id);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return MapReaderToPatient(reader);
                    else
                        return null;
                }
            }
        }

        /// Retrieve all patients.
        public DataTable GetPatients()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM Patient";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Maps a SQL row to Patient object.
        private Patient MapReaderToPatient(SqlDataReader reader)
        {
            return new Patient
            {
                PatientID = (int)reader["ID"],
                Name = reader["Name"].ToString(),
                DateOfBirth = (DateTime)reader["DOB"],
                Age = (int)reader["Age"],
                Address = reader["Address"].ToString(),
                PhoneNumber = reader["Phone"].ToString(),
                EmailAddress = reader["Email"].ToString(),
                Gender = reader["Gender"].ToString(),
                Allergies = reader["Allergies"].ToString(),
                History = reader["History"].ToString(),
                Medications = reader["Medications"].ToString()
            };
        }
    }
}