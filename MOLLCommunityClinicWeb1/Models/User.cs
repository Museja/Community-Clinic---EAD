using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOLLCommunityClinicWeb1.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        // Store hashed password (NEVER plain text)
        public string PasswordHash { get; set; }

        public string Role { get; set; }

        // Only used depending on role
        public string AdminID { get; set; }

        public string MedStaffID { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
