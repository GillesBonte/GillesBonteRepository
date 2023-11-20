using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControlLogic.Models
{
    public class Token
    {
        public string Id { get; set; } 
        public List<int> AllowedDoors { get; set; }
        public bool Blocked { get; set; }

    }
}
