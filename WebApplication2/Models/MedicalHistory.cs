using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class MedicalHistory
    {
        internal class MedicalHistoryModels
        {
            public int Id { get; set; }
            public int PatientId { get; set; }
            public string Condition { get; set; }
            public string Notes { get; set; }
            public DateTime DateRecorded { get; set; }
        }
    }
}