using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseExerciseLinq
{
    internal class Courses : List<Course>
    {
        public Courses()
        {
            this.Add(new Course("Vincent", 1, 13, "F30", Course.Period.Day));
            this.Add(new Course("Arne", 2, 15, "F30", Course.Period.Day));
            this.Add(new Course("Arne", 3, 13, "F30", Course.Period.Day));
            this.Add(new Course("Vincent", 24, 5, "F33", Course.Period.Day));
            this.Add(new Course("Arne", 5, 13, "F33", Course.Period.Night));
            this.Add(new Course("Arne", 5, 15, "F30", Course.Period.Day));
            this.Add(new Course("Arne", 4, 13, "F30", Course.Period.Night));
            this.Add(new Course("Vincent", 33, 5, "F30", Course.Period.Day));
            this.Add(new Course("Arne", 2, 12, "F35", Course.Period.Day));
            this.Add(new Course("Arne", 1, 22, "F30", Course.Period.Day));
            this.Add(new Course("Gilles", 3, 15, "F35", Course.Period.Night));
        }

    }

}
