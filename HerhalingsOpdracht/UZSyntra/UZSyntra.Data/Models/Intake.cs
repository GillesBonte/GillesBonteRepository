using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UZSyntra.Data.Models
{
    public class Intake
    {
        public int ID { get; set; }
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        public Patient Patient { get; set; }
        public DateTime IntakeDateTime { get; set; }
        public DateTime? DischargeDateTime { get; set; }
        public string Remarks { get; set; }
        [ForeignKey("Bed")]
        public int BedID { get; set; }
        public Bed Bed { get; set; }

    }
}
