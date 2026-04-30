using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communityclinic.Models
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
