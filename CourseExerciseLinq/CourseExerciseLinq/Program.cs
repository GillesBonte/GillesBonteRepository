using CourseExerciseLinq;
using Microsoft.VisualBasic;
using System.Linq;
using System.Runtime.CompilerServices;

Courses courses = new Courses();
IEnumerable<string> queryResult;
//queryResult = MoreThanFifteen(courses);
//queryResult = DayCourses(courses);
//queryResult = CoursesPerTeacher(courses);
//queryResult = AllCourses(courses);
queryResult = CoursesPerPeriod(courses);

foreach (string item in queryResult)
{
    Console.WriteLine(item);
}

Console.ReadLine();

static IEnumerable<Course> MoreThanFifteen(Courses courses)
{

    var result = from course in courses
             where course.StudentCount >= 15
             select course;

    return result;
}

static IEnumerable<string> DayCourses(Courses courses)
{

    var result = from course in courses
                 where course.Periode.Equals(Course.Period.Day)
                 select $"{course}";

    return result;
}

static IEnumerable<string> CoursesPerTeacher(Courses courses)
{

    IEnumerable<string> result = from course in courses
                                 group course by course.Teacher into groupTeachers
                                 select $"{groupTeachers.Key} - {groupTeachers.Count()}";

    return result;
}

static IEnumerable<string> AllCourses(Courses courses)
{
    IEnumerable<string> result = from course in courses
                                 select $"{course.Teacher} - {course.Room} - {course.Duration}";
    return result;
}

static IEnumerable<string> CoursesPerPeriod(Courses courses)
{
    IEnumerable<string> result = from course in courses
                                 group course by course.Periode into groupPeriod
                                 select $"{groupPeriod.Key} - {groupPeriod.Count()}";
    return result;
}









