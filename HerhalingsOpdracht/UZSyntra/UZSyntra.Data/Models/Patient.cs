using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UZSyntra.Data.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Firstname { get; set; }
        public string SocialSecurityNumber { get; set; }
        public DateOnly BirthDate { get; set; }

    }
}
