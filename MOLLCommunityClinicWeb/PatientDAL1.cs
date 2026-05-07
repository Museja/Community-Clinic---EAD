using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MOLLCommunityClinicWeb
{
    public class PatientDAL1
         {
        private string connString =
            ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        // ADD PATIENT
        public bool AddPatient(PatientModel1 patient)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"INSERT INTO Patients
                (Name, DateOfBirth, Age, Address, PhoneNumber, EmailAddress, Gender, Allergies, History, Medications)
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
                cmd.Parameters.AddWithValue("@Allergies", patient.Allergies);
                cmd.Parameters.AddWithValue("@History", patient.History);
                cmd.Parameters.AddWithValue("@Medications", patient.Medications);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // UPDATE PATIENT
        public bool UpdatePatient(PatientModel1 patient)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"UPDATE Patients SET
                    Name=@Name,
                    DateOfBirth=@DateOfBirth,
                    Age=@Age,
                    Address=@Address,
                    PhoneNumber=@PhoneNumber,
                    EmailAddress=@EmailAddress,
                    Gender=@Gender,
                    Allergies=@Allergies,
                    History=@History,
                    Medications=@Medications
                    WHERE EmailAddress=@EmailAddress";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Name", patient.Name);
                cmd.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
                cmd.Parameters.AddWithValue("@Age", patient.Age);
                cmd.Parameters.AddWithValue("@Address", patient.Address);
                cmd.Parameters.AddWithValue("@PhoneNumber", patient.PhoneNumber);
                cmd.Parameters.AddWithValue("@EmailAddress", patient.EmailAddress);
                cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                cmd.Parameters.AddWithValue("@Allergies", patient.Allergies);
                cmd.Parameters.AddWithValue("@History", patient.History);
                cmd.Parameters.AddWithValue("@Medications", patient.Medications);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // GET ALL PATIENTS
        public DataTable GetPatients()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT * FROM Patients";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        // GET PATIENT BY EMAIL
        public PatientModel1 GetPatientByEmail(string email)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT * FROM Patients WHERE EmailAddress=@Email";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new PatientModel
                    {
                        Name = reader["Name"].ToString(),
                        DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                        Age = Convert.ToInt32(reader["Age"]),
                        Address = reader["Address"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        EmailAddress = reader["EmailAddress"].ToString(),
                        Gender = reader["Gender"].ToString(),
                        Allergies = reader["Allergies"].ToString(),
                        History = reader["History"].ToString(),
                        Medications = reader["Medications"].ToString()
                    };
                }

                return null;
            }
        }
    }
}