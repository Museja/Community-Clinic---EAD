using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Registration
    {
        // Properties
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Role { get; set; } // "Patient" or "Administrator"
        public string AdminID { get; set; }

        // Constructor with parameters
        public Registration(string fullName, string emailAddress, string password, string confirmPassword, string role, string adminID)
        {
            FullName = fullName;
            EmailAddress = emailAddress;
            Password = password;
            ConfirmPassword = confirmPassword;
            Role = role;
            AdminID = adminID;
        }

        // Validation Method (optional but VERY useful)
        public bool IsValid(out string message)
        {
            if (string.IsNullOrWhiteSpace(FullName))
            {
                message = "Full Name is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                message = "Email Address is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(Password))
            {
                message = "Password is required.";
                return false;
            }

            if (Password != ConfirmPassword)
            {
                message = "Passwords do not match.";
                return false;
            }

            if (Role == "Administrator" && string.IsNullOrWhiteSpace(AdminID))
            {
                message = "Administrator ID is required for admins.";
                return false;
            }

            message = "Valid";
            return true;
        }
    }
}
