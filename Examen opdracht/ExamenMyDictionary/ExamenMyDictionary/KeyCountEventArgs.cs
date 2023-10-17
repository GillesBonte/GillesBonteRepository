using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenMyDictionary
{
    public class KeyCountEventArgs : EventArgs
    {
        public KeyCountEventArgs(int keycount)
        {
            KeyCount = keycount;
        }

        public int KeyCount { get;  set; }

        public override string ToString()
        {
            return this.KeyCount.ToString();
        }
    }

}
