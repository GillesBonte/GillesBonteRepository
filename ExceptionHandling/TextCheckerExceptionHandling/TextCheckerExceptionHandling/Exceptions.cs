using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCheckerExceptionHandling
{
    public class ContainsNumberException : Exception
    {

        public ContainsNumberException(string? message) : base(message)
        {
        }

    }

    public class ContainsLetterFException : Exception
    {

        public ContainsLetterFException(string? message) : base(message)
        {
        }

    }

    public class ContainsAlotException : Exception
    {

        public ContainsAlotException(string? message) : base(message)
        {
        }

    }

}
