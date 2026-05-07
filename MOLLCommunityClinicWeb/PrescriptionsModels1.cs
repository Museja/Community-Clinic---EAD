using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOLLCommunityClinicWeb
{
    public class PrescriptionsModels1
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string Medication { get; set; }
        public string Dosage { get; set; }
        public string DoctorName { get; set; }
        public DateTime DateIssued { get; set; }
    }
}