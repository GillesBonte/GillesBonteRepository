using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatProgramExamPrep
{
    public class UserEventArgs : EventArgs
    {
        public UserEventArgs(string strUsername)
        {
            UserName = strUsername;
        }
        public string UserName { get; set; } 

    }
}

