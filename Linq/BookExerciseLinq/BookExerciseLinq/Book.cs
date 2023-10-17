using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExerciseLinq
{
    public class Book
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public int WriterID { get; set; }
        public int PageCount { get; set; }
        public int Score { get; set; }
    }

}
