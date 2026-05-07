using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MOLLCommunityClinicWeb
{
    public class AppointmentDAL1
    {
        // GET APPOINTMENTS FOR A PATIENT
        public DataTable GetAppointmentsByPatient(int patientId)
        {
            using (SqlConnection conn = Databasehelper1.GetConnection())
            {
                string query = "SELECT * FROM Appointments WHERE PatientId=@Id";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Id", patientId);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        // BOOK APPOINTMENT
        public bool BookAppointment(int patientId, DateTime date, string reason)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO Appointments
                                (PatientId, AppointmentDate, Reason)
                                VALUES (@PatientId, @Date, @Reason)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@PatientId", patientId);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Reason", reason);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}