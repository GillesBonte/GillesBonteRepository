using CourseExerciseLinq;
using Microsoft.VisualBasic;
using System.Linq;
using System.Runtime.CompilerServices;

Courses courses = new Courses();
IEnumerable<Course> queryResult;
//queryResult = MoreThanFifteen(courses);
queryResult = DayCourses(courses);

foreach (Course course in queryResult)
{
    Console.WriteLine($"{course.Teacher}\t{course.Room}\t{course.StudentCount}\t{course.Periode}");
}

Console.ReadLine();

static IEnumerable<Course> MoreThanFifteen(Courses courses)
{

    var result = from course in courses
             where course.StudentCount >= 15
             select course;

    return result;
}

static IEnumerable<Course> DayCourses(Courses courses)
{

    var result = from course in courses
                 where course.Periode.Equals(Course.Period.Day)
                 select course;

    return result;
}







