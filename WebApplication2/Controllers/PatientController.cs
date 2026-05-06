using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PatientController : Controller
    {
        // LOAD PAGE (replaces form load)
        public ActionResult Portal()
        {
            int patientId = Convert.ToInt32(Session["PatientId"]);

            Patient model = GetPatient(patientId);

            return View(model);
        }

        // GET PATIENT DATA (your LoadPatientProfile)
        private Patient GetPatient(int id)
        {
            Patient patient = new Patient();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"SELECT FullName, Phone, Email, Address, DOB 
                             FROM Patients 
                             WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    patient.Name = reader["FullName"].ToString();
                    patient.PhoneNumber = reader["Phone"].ToString();
                    patient.EmailAddress = reader["Email"].ToString();
                    patient.Address = reader["Address"].ToString();
                    patient.DateOfBirth = Convert.ToDateTime(reader["DOB"]);
                }
            }

            return patient;
        }

        // UPDATE PROFILE (replaces btnUpdateProfile_Click)
        [HttpPost]
        public ActionResult UpdateProfile(Patient model)
        {
            int patientId = Convert.ToInt32(Session["PatientId"]);

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

                cmd.Parameters.AddWithValue("@FullName", model.Name);
                cmd.Parameters.AddWithValue("@Phone", model.PhoneNumber);
                cmd.Parameters.AddWithValue("@Email", model.EmailAddress);
                cmd.Parameters.AddWithValue("@Address", model.Address);
                cmd.Parameters.AddWithValue("@DOB", model.DateOfBirth);
                cmd.Parameters.AddWithValue("@Id", patientId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            return RedirectToAction("Portal");
        }

        // LOAD APPOINTMENTS
        public ActionResult Appointments()
        {
            int patientId = Convert.ToInt32(Session["PatientId"]);
            DataTable dt = new DataTable();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM Appointments WHERE PatientId=@Id";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Id", patientId);

                da.Fill(dt);
            }

            return View(dt);
        }

        // LOAD MEDICAL HISTORY
        public ActionResult History()
        {
            int patientId = Convert.ToInt32(Session["PatientId"]);
            DataTable dt = new DataTable();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM MedicalHistory WHERE PatientId=@Id";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Id", patientId);

                da.Fill(dt);
            }

            return View(dt);
        }

        // LOAD PRESCRIPTIONS
        public ActionResult Prescriptions()
        {
            int patientId = Convert.ToInt32(Session["PatientId"]);
            DataTable dt = new DataTable();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM Prescriptions WHERE PatientId=@Id";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Id", patientId);

                da.Fill(dt);
            }

            return View(dt);
        }

        // LOGOUT
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login", "Account");
        }
    }
}
   