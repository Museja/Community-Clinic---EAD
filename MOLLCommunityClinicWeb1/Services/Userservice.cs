using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MOLLCommunityClinicWeb1.Models;

namespace MOLLCommunityClinicWeb1.Services
{
    public class Userservice
    {
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings["CommunityClinicLLOMDB"].ConnectionString;

        // CREATE / REGISTER USER
        public void RegisterUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Users
                (FullName, Email, PasswordHash, Role, AdminID, MedStaffID)
                VALUES
                (@FullName, @Email, @PasswordHash, @Role, @AdminID, @MedStaffID)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@FullName", user.FullName);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                cmd.Parameters.AddWithValue("@Role", user.Role);

                cmd.Parameters.AddWithValue("@AdminID",
                    (object)user.AdminID ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@MedStaffID",
                    (object)user.MedStaffID ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // GET USER BY EMAIL (for login later)
        public User GetUserByEmail(string email)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users WHERE Email = @Email";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new User
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        FullName = reader["FullName"].ToString(),
                        Email = reader["Email"].ToString(),
                        PasswordHash = reader["PasswordHash"].ToString(),
                        Role = reader["Role"].ToString(),
                        AdminID = reader["AdminID"].ToString(),
                        MedStaffID = reader["MedStaffID"].ToString()
                    };
                }

                return null;
            }
        }
    }
}
