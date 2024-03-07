using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UZSyntra.Libraries.ViewModels
{
    public class RoomViewModel
    {
        public int Id { get; set; }
        public string Number { get; set; }
        [Range(1, 20)]
        public int MaxAmountBeds { get; set; } = 1;
        public IEnumerable<UZSyntra.Data.Models.Bed> Beds { get; set; }
    }
}
