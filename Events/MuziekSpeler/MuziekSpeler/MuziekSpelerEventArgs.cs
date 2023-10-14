using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuziekSpeler
{
    public class MuziekSpelerEventArgs : EventArgs
    {
        public MuziekSpelerEventArgs(string strLiedNaam)
        {
            LiedNaam = strLiedNaam;
        }

        public string LiedNaam { get; set; }

    }

}
