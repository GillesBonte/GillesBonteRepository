using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace EventExerciseLaptop
{
    public class Laptop
    {
        public event EventHandler PoweredOn;
        public event EventHandler PoweredOff;
        public Laptop()
        {
            Powered = false;
        }

        public bool Powered { get; set; }

        public void PowerOn()
        {           
            //TO DO: after 5 seconds, invoke the PoweredOn event;
        }
        
        public void PowerOff()
        {
            //TO DO: after 3 seconds, invoke the PoweredOff event;
        }

    }

}

