using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UZSyntra.Data.Models
{
    public class Bed
    {
        public int ID { get; set; }
        [Required]
        public string Number { get; set; }
        [ForeignKey("Room")]
        public int RoomID { get; set; }
        public Room Room { get; set; }
        [Range(1, 20)]
        public int MaxAmountOfBeds { get; set; } = 1;
    }
}
