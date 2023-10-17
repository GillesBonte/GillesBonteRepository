using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeVoetbalApp
{
    public class PlayerNameTooLongException : Exception
    {
        public PlayerNameTooLongException(string? message) : base(message)
        {
        }

    }

}
