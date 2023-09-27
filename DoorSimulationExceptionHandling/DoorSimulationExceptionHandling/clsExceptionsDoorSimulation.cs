using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSimulationExceptionHandling
{
    public class ExceptionDoorLocked : Exception
    {
        public ExceptionDoorLocked(string? message) : base(message)
        { 
        }

    }

}
