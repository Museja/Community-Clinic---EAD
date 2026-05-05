using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class RegistrationDAL
    {
        // Insert new user
        public bool InsertUser(Registration user)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO Users
                (FullName, EmailAddress, Password, Role, AdminID)
                VALUES
                (@FullName, @EmailAddress, @Password, @Role, @AdminID)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@FullName", user.FullName);
                cmd.Parameters.AddWithValue("@EmailAddress", user.EmailAddress);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Role", user.Role);

                // Handle NULL AdminID (for Patients)
                if (string.IsNullOrWhiteSpace(user.AdminID))
                    cmd.Parameters.AddWithValue("@AdminID", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@AdminID", user.AdminID);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Get all users
        public DataTable GetAllUsers()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

        // Updates user
        public void UpdateUser(Registration user, int id)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"UPDATE Users SET
                    FullName=@FullName,
                    EmailAddress=@EmailAddress,
                    Password=@Password,
                    Role=@Role,
                    AdminID=@AdminID
                    MedStaffID=@MedStaffID
                    WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@FullName", user.FullName);
                cmd.Parameters.AddWithValue("@EmailAddress", user.EmailAddress);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Role", user.Role);

                if (string.IsNullOrWhiteSpace(user.AdminID))
                    cmd.Parameters.AddWithValue("@AdminID", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@AdminID", user.AdminID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Deletes user
        public void DeleteUser(int id)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM Users WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public bool EmailExists(string email)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Users WHERE EmailAddress=@Email";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }
    }
}