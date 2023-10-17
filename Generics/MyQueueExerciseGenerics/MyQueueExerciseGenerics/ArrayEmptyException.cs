using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueueExerciseGenerics
{
    public class ArrayEmptyException : Exception
    {
        public ArrayEmptyException(string? message) : base(message)
        {
        }
    }

}
