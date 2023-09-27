using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSimulationExceptionHandling
{
    public class Door
    {
        public Door(bool blnOpened, bool blnLocked)
        {
            DoorOpened = blnOpened;
            DoorLocked = blnLocked;
        }

        public bool DoorOpened { get; set; }
        public bool DoorLocked { get; set; }

        public void LockDoor()
        {
            if (DoorOpened) 
            {
                throw new ExceptionDoorOpened("Door can't be locked while open.");
            }
            else
            {
                Console.WriteLine("Door has been locked.");
            }

        }

        public void UnlockDoor()
        {

        }

        public void OpenDoor()
        {

            if (DoorLocked)
            {
                throw new ExceptionDoorLocked("Door can't be opened while locked.");
            }
            else
            {
                DoorOpened = true;
                Console.WriteLine("Door has been opened.");
            }

        }

        public void CloseDoor()
        {

        }

        private void LogDoorError()
        { 
        }

    }

}
