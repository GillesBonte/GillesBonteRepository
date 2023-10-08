using CourseExerciseLinq;
using Microsoft.VisualBasic;
using System.Linq;
using System.Runtime.CompilerServices;

Courses courses = new Courses();
IEnumerable<Course> queryResult;
queryResult = MoreThanFifteen(courses);

foreach (Course course in queryResult)
{
    Console.WriteLine($"{course.Teacher}, {course.Room}, {course.StudentCount}");
}

Console.ReadLine();

static IEnumerable<Course> MoreThanFifteen(Courses courses)
{

    var result = from course in courses
             where course.StudentCount >= 15
             select course;

    return result;
}







