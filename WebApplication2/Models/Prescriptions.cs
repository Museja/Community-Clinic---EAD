using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Prescriptions
    {
        internal class PrescriptionsModels
        {
            public int Id { get; set; }
            public int PatientId { get; set; }
            public string Medication { get; set; }
            public string Dosage { get; set; }
            public string DoctorName { get; set; }
            public DateTime DateIssued { get; set; }
        }
    }
}