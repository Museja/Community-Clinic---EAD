using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOLLCommunityClinicWeb
{
    public class MedicalHistoryModels1
    {
        public int Id { get; set; }

        public int PatientId { get; set; }

        public string Condition { get; set; }

        public string Notes { get; set; }

        public DateTime DateRecorded { get; set; }
    }
}