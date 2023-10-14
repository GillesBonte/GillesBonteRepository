using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuziekSpeler
{
    public delegate void MuziekSpelerEventHandler(object? sender, MuziekSpelerEventArgs e);

    public class MuziekSpeler
    {
        public event MuziekSpelerEventHandler LiedGespeeld;

        public MuziekSpeler()
        {

        }

        public void SpeelLied(string strLiedNaam)
        {
            LiedGespeeld.Invoke(this, new MuziekSpelerEventArgs(strLiedNaam));
        }

    }

}
