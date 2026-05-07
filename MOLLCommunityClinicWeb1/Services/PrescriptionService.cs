using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MOLLCommunityClinicWeb1.Services
{
    public class PrescriptionService
    {
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings["CommunityClinicLLOMDB"].ConnectionString;

        // ADD PRESCRIPTION
        public void AddPrescription(PrescriptionsWeb prescription)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Prescriptions
                                (PatientId, Medication, Dosage, DoctorName, DateIssued)
                                VALUES
                                (@PatientId, @Medication, @Dosage, @DoctorName, @DateIssued)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@PatientId", prescription.PatientId);
                cmd.Parameters.AddWithValue("@Medication", prescription.Medication);
                cmd.Parameters.AddWithValue("@Dosage", prescription.Dosage);
                cmd.Parameters.AddWithValue("@DoctorName", prescription.DoctorName);
                cmd.Parameters.AddWithValue("@DateIssued", prescription.DateIssued);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // GET ALL PRESCRIPTIONS
        public List<PrescriptionsWeb> GetAllPrescriptions()
        {
            List<PrescriptionsWeb> list = new List<PrescriptionsWeb>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Prescriptions ORDER BY DateIssued DESC";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new PrescriptionsWeb
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        PatientId = Convert.ToInt32(reader["PatientId"]),
                        Medication = reader["Medication"].ToString(),
                        Dosage = reader["Dosage"].ToString(),
                        DoctorName = reader["DoctorName"].ToString(),
                        DateIssued = Convert.ToDateTime(reader["DateIssued"])
                    });
                }
            }

            return list;
        }

        // GET BY PATIENT
        public List<PrescriptionsWeb> GetByPatientId(int patientId)
        {
            List<PrescriptionsWeb> list = new List<PrescriptionsWeb>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM Prescriptions
                                 WHERE PatientId = @PatientId
                                 ORDER BY DateIssued DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PatientId", patientId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new PrescriptionsWeb
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        PatientId = Convert.ToInt32(reader["PatientId"]),
                        Medication = reader["Medication"].ToString(),
                        Dosage = reader["Dosage"].ToString(),
                        DoctorName = reader["DoctorName"].ToString(),
                        DateIssued = Convert.ToDateTime(reader["DateIssued"])
                    });
                }
            }

            return list;
        }

        // DELETE PRESCRIPTION
        public void DeletePrescription(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Prescriptions WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}