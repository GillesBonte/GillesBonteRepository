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
        }
        
        public void PowerOff()
        {
        }

    }

}

