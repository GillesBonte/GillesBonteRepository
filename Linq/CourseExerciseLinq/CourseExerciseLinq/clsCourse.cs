using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseExerciseLinq
{
    public class Course
    {
        public Course(string teacher, int duration, int studentCount, string room, Period periode)
        {
            Teacher = teacher;
            Duration = duration;
            StudentCount = studentCount;
            Room = room;
            Periode = periode;
        }

        public string Teacher { get; set; }
        public enum Period
        {
            Day,
            Night
        }
        public int Duration { get; set; }
        public int StudentCount { get; set; }
        public string Room { get; set; }
        public Period Periode { get; set; }

    }

}
