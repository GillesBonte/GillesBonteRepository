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

    public class ExceptionDoorOpened : Exception
    {
        public ExceptionDoorOpened(string? message) : base(message)
        {
        }

    }

    public class ExceptionDoorAlreadyOpen : Exception
    {
        public ExceptionDoorAlreadyOpen(string? message) : base(message)
        {
        }

    }

    public class ExceptionDoorAlreadyLocked : Exception
    {
        public ExceptionDoorAlreadyLocked(string? message) : base(message)
        {
        }

    }
}
